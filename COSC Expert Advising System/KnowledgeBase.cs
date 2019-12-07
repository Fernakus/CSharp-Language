/*  -------------------------------------------------------
 *  KnowledgeBase.cs
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static COSC_Expert_System.Node;

namespace COSC_Expert_System
{
    class KnowledgeBase
    {
        // Variables
        private readonly String EXPERT_SYS_DATA = "expertsystemdata.txt";
        private List<Node> courseNodes;

        // No-arg Constructor
        public KnowledgeBase()
        {
            // Instantiate
            courseNodes = new List<Node>();

            // Read in
            read();
        }

        /* 
         * ---- Methods ----
         * 1. insert()
         * 2. retrieve()
         * 3. printCourses()
         * 4. size()
         * 5. read()
         * 6. write()
         * 7. getCourseNodesList()
         */

        // insert()
        public void insert(Node courseInfo)
        {
            // Add
            courseNodes.Add(courseInfo);
        }

        // retrieveCourseTitle()
        public string retrieveCourseTitle(string courseCode)
        {
            foreach (Node courseInfo in courseNodes)
                foreach (string course in courseInfo.getRawCourseInfo())
                    if (course.Substring(0, 8).Equals(courseCode))
                        return course.Substring(11);

            return null;
        }

        // retrieveAssociatedDegrees()
        public List<string> retrieveAssociatedDegrees(string courseCode)
        {
            List<string> degrees = new List<string>();

            foreach (Node courseInfo in courseNodes)
                foreach (string code in courseInfo.getCourseCodes())
                    if (code.Equals(courseCode) && !degrees.Contains(courseInfo.getDegree()))
                        degrees.Add(courseInfo.getDegree());

            return degrees;
        }

        // retrieveAssociatedCourses()
        public List<string> retrieveAssociatedCourses(string degree)
        {
            List<string> associatedCourses = new List<string>();

            foreach (Node courseNode in courseNodes)
            {
                if (courseNode.getDegree().Equals(degree))
                    foreach (string course in courseNode.getRawCourseInfo())
                        if (!associatedCourses.Contains(course))
                            associatedCourses.Add(course);
            }

            return associatedCourses;
        }

        // read()
        private void read()
        {
            read(new StreamReader(EXPERT_SYS_DATA));
        }

        private void read(StreamReader dataStream)
        {
            String degree = "";
            String year = "";
            String aCourse = "";
            List<string> courses = new List<string>();

            String line = dataStream.ReadLine();
            while (line != null)
            {
                if (line.Equals("(Degree)"))
                {
                    // Grab data and assign to variables
                    degree = dataStream.ReadLine();
                    year = dataStream.ReadLine();
                    line = dataStream.ReadLine();

                    // Parse data in line
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i + 1 == line.Length)
                        {
                            aCourse += line.Substring(i); 
                            courses.Add(aCourse);
                            aCourse = "";
                        }
                        else if (line.ElementAt(i) == ',')
                        {
                            courses.Add(aCourse);
                            aCourse = "";
                        }
                        else
                            aCourse += line.ElementAt(i);
                    }

                    insert(new Node(courses, year, degree, (courses.Count * 3)));
                    courses.Clear();

                    line = dataStream.ReadLine();
                }

                else
                {
                    // Grab data and assign to variables
                    year = line;
                    line = dataStream.ReadLine();

                    // Parse data in line
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i + 1 == line.Length)
                        {
                            aCourse += line.Substring(i); ;
                            courses.Add(aCourse);
                            aCourse = "";
                        }
                        else if (line.ElementAt(i) == ',')
                        {
                            courses.Add(aCourse);
                            aCourse = "";
                        }
                        else
                            aCourse += line.ElementAt(i);
                    }

                    insert(new Node(courses, year, degree, (courses.Count * 3)));
                    courses.Clear();

                    line = dataStream.ReadLine();
                }
            }

            dataStream.Close();
        }

        // getCourseNodesList()
        public List<Node> getCourseNodesList()
        {
            return courseNodes;
        }
    }
}
