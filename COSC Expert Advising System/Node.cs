/*  -------------------------------------------------------
 *  Node.cs
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

namespace COSC_Expert_System
{
    class Node
    {
        // Variables
        private List<string> courseTitles, courseCodes, rawCourseInfo;
        private string year, degree;
        private int credits;

        // No-arg Constructor
        public Node()
        {
            courseTitles = new List<string>();
            courseCodes = new List<string>();
            year = null;
            degree = null;
            credits = 0;
        }

        // Quint-arg Constructor
        public Node(List<string> courses, string year, string degree, int credits)
        {
            populateCourseData(courses);
            this.year = year;
            this.degree = degree;
            this.credits = credits;
        }

        /* 
         * ---- Methods ----
         * 1.  populateCourseData()
         * 2.  getCourseTitles()
         * 3.  getCourseCodes()
         * 4.  getRawCourseInfo()
         * 5.  getYear()
         * 6.  getDegree()
         * 7.  getCredits()
         * 8.  setCourseData()
         * 9.  setYear()
         * 10. setDegree()
         * 11. setCredits()
         */

        // populateCourseData()
        private void populateCourseData(List<string> coursesList)
        {
            // Populate course codes
            rawCourseInfo = new List<string>();
            foreach (string courseInfo in coursesList)
                rawCourseInfo.Add(courseInfo);

            // Populate course codes
            courseCodes = new List<string>();
            foreach (string course in coursesList)
                courseCodes.Add(course.Substring(0, 8));

            // Populate courses titles
            courseTitles = new List<string>();
            foreach (string course in coursesList)
                courseTitles.Add(course.Substring(11));
        }

        // getCourseTitles()
        public List<string> getCourseTitles()
        {
            return courseTitles;
        }

        // getCourseCodes()
        public List<string> getCourseCodes()
        {
            return courseCodes;
        }

        // getRawCourseInfo()
        public List<string> getRawCourseInfo()
        {
            return rawCourseInfo;
        }

        // getYear()
        public string getYear()
        {
            return year;
        }

        // getDegree()
        public string getDegree()
        {
            return degree;
        }

    }
}
