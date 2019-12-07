/*  -------------------------------------------------------
 *  MainGUI.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static COSC_Expert_System.InferenceEngine;

namespace COSC_Expert_System
{
    public partial class NewStudentGUI : Form
    {
        // Variables
        private InferenceEngine inferenceEngine;
        private KnowledgeBase knowledgeBase;
        private List<Node> courseInfoList;

        // No-arg Constructor
        public NewStudentGUI()
        {
            // Instantiate Objects
            inferenceEngine = new InferenceEngine();
            knowledgeBase = inferenceEngine.getKnowledgeBase();
            courseInfoList = knowledgeBase.getCourseNodesList();

            // Display CurrentStudentGUI()
            InitializeComponent();

            // Populate Data
            addCourseCodes();
            addDegrees();
        }

        /* 
         * ---- Methods ----
         * 1.  addDegrees()
         * 2.  addCourseCode()
         * 3.  courseCodeListBox_SelectedIndexChanged()
         * 4. adviceBtn_Click()
         * 5. giveNewStudentAdvice()
         */

        // addDegrees()
        private void addDegrees()
        {
            List<string> temp = new List<string>();
            foreach (Node courses in courseInfoList)
            {
                string degree = courses.getDegree();

                if (temp.Contains(degree))
                    continue;

                else
                {
                    degreesComboBox.Items.Add(degree);
                    temp.Add(degree);
                }
            }
        }

        // addCourseCode()
        private void addCourseCodes()
        {
            List<string> temp = new List<string>();
            foreach (Node courses in courseInfoList)
            {
                List<string> courseCodes = courses.getCourseCodes();
                List<string> courseNames = courses.getCourseTitles();
                List<string> rawCoursesInfo = courses.getRawCourseInfo();

                foreach (string courseCode in courseCodes)
                {
                    if (temp.Contains(courseCode))
                        continue;

                    else
                    {
                        courseCodeListBox.Items.Add(courseCode);
                        temp.Add(courseCode);
                    }
                }
            }
        }

        // courseCodeListBox_SelectedIndexChanged()
        private void courseCodeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox
            string courseCode = courseCodeListBox.SelectedItem as string;
            string courseTitle = knowledgeBase.retrieveCourseTitle(courseCode);
            List<string> degrees = knowledgeBase.retrieveAssociatedDegrees(courseCode);

            // Clear
            courseListBox.Items.Clear();
            uniDegreesBox.Items.Clear();
            yearListBox.Items.Clear();

            // Add degrees to GUI
            courseListBox.Items.Add(courseTitle);
            foreach (string degree in degrees)
                uniDegreesBox.Items.Add(degree);

            // Add year GUI
            if (courseCode.ElementAt(4) == 'X')
                yearListBox.Items.Add("4");
            else yearListBox.Items.Add(courseCode.ElementAt(4));
        }

        // adviceBtn_Click()
        private void adviceBtn_Click(object sender, EventArgs e)
        {
            // Can we proceed
            if (!(degreesComboBox.SelectedIndex != -1 ? true : false))
                return;

            // Clear previous
            degreeListBox.Items.Clear();
            degreeYearBox.Items.Clear();
            courseTitlesListBox.Items.Clear();
            courseCodesListBox.Items.Clear();
            courseExplainBox.Clear();
            courseTitlesListBox.Items.Clear();
            courseCodesListBox.Items.Clear();
            courseExplainBox.Clear();

            // Get data
            string degree = degreesComboBox.SelectedItem.ToString();

            // Retrieve Advice
            inferenceEngine.generateNewStudentAdvice(degree, this);
        }

        // giveNewStudentAdvice()
        public void giveNewStudentAdvice(string degree, List<string> courseCodes, List<string> courseTitles, string explanation)
        {
            // Set data
            degreeListBox.Items.Add(degree);
            degreeYearBox.Items.Add("1");

            foreach (string courseCode in courseCodes)
                courseCodesListBox.Items.Add(courseCode);

            foreach (string courseTitle in courseTitles)
                courseTitlesListBox.Items.Add(courseTitle);

            courseExplainBox.Text = explanation;
        }
    }
}
