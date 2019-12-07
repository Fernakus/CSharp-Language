/*  -------------------------------------------------------
 *  InferenceEngine.cs
 *  -------------------------------------------------------
 *  Author:  Matthew Ferlaino
 *  Course:	 COSC3117
 *  ID:      169657520
 *  Email:   mferlaino@algomau.ca
 *  Date:	 Oct 21, 2019
 *  ------------------------------------------------------- */

// Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC_Expert_System
{
    class InferenceEngine
    {
        // Variables
        private KnowledgeBase knowledgeBase;
        private ExplanationSystem explanationSystem;
         
        // No-arg Constructor
        public InferenceEngine()
        {
            // Instantiate
            explanationSystem = new ExplanationSystem();
            knowledgeBase = new KnowledgeBase();
        }

        /* 
         * ---- Methods ----
         * 1. getKnowledgeBaseEditor()
         * 2. getExplanationSystem()
         * 3. getKnowledgeBase()
         */

        // generateCurrentStudentAdvice()
        public void generateCurrentStudentAdvice(string degree, string year, bool doProject, CurrentStudentGUI gui)
        {
            // Variables 
            List<string> rawCoursesTaken = new List<string>();
            List<string> rawCoursesNotTaken = new List<string>();
            List<string> courseCodes = new List<string>();
            List<string> courseTitles = new List<string>();
            bool firstYearClasses = false;
            bool secondYearClasses = false;
            bool thirdYearClasses = false;
            bool fourthYearClasses = false;

            // Courses taken
            foreach (string courseTaken in gui.getCoursesCheckedListBox().CheckedItems)
                rawCoursesTaken.Add(courseTaken);

            // Courses not taken
            foreach (string arbitraryCourse in gui.getCoursesCheckedListBox().Items)
            {
                if (!rawCoursesTaken.Contains(arbitraryCourse))
                {
                    rawCoursesNotTaken.Add(arbitraryCourse);
                    courseCodes.Add(arbitraryCourse.Substring(0, 8));
                    courseTitles.Add(arbitraryCourse.Substring(11));
                }
            }

            // Variables 
            foreach (string courseNotTaken in rawCoursesNotTaken)
            {
                if (courseNotTaken.ElementAt(4) == '1')
                    firstYearClasses = true;
                else if (courseNotTaken.ElementAt(4) == '2')
                    secondYearClasses = true;
                else if (courseNotTaken.ElementAt(4) == '3')
                    thirdYearClasses = true;
                else
                    fourthYearClasses = true;
            }

            gui.giveCurrentStudentAdvice(degree, year, courseCodes, courseTitles, explanationSystem.generateCurrentStudentExplanation(doProject, degree, year, firstYearClasses, secondYearClasses, thirdYearClasses, fourthYearClasses));
        }

        // generateNewStudentAdvice()
        public void generateNewStudentAdvice(string degree, NewStudentGUI gui)
        {
            // Variables 
            List<string> rawCoursesInfo = knowledgeBase.retrieveAssociatedCourses(degree);
            List<string> courseCodes = new List<string>();
            List<string> courseTitles = new List<string>();

            // Add course titles and course codes
            foreach (string rawCourseInfo in rawCoursesInfo)
            {
                courseCodes.Add(rawCourseInfo.Substring(0, 8));
                courseTitles.Add(rawCourseInfo.Substring(11));
            }

            gui.giveNewStudentAdvice(degree, courseCodes, courseTitles, explanationSystem.generateNewStudentExplanation(degree));
        }

        // getKnowledgeBase()
        public KnowledgeBase getKnowledgeBase()
        {
            return knowledgeBase;
        }
    }
}
