/*  -------------------------------------------------------
 *  CurrentStudentGUI.cs
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
    public partial class CurrentStudentGUI : Form
    {
        // Variables
        private InferenceEngine inferenceEngine;
        private KnowledgeBase knowledgeBase;
        private List<Node> courseInfoList;

        // No-arg Constructor
        public CurrentStudentGUI()
        {
            // Instantiate Objects
            inferenceEngine = new InferenceEngine();
            knowledgeBase = inferenceEngine.getKnowledgeBase();
            courseInfoList = knowledgeBase.getCourseNodesList();

            // Display CurrentStudentGUI()
            InitializeComponent();

            // Populate Data
            addCourseCodes();
            addYearComboBox();
            addYesOrNo();
            addDegrees();
        }

        /* 
         * ---- Methods ----
         * 1.  addDegrees()
         * 2.  addCourses()
         * 3.  addYearComboBox()
         * 4.  addYesOrNo()
         * 5.  addCourseCode()
         * 6.  courseCodeListBox_SelectedIndexChanged()
         * 7.  yearComboBox_SelectedIndexChanged()
         * 8.  degreesComboBox_SelectedIndexChanged()
         * 9.  yesOrNoComboBox_SelectedIndexChanged()
         * 10. adviceBtn_Click()
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

        // addCourses()
        private void addCourses(string degree)
        {
            List<string> temp = new List<string>();
            coursesCheckedListBox.Items.Clear();

            foreach (Node courses in courseInfoList)
            {
                List<string> coursesList = courses.getRawCourseInfo();
                char year = courses.getYear().ElementAt(0);
                char comboBoxYear = yearComboBox.Text.ElementAt(0);
                bool doProject = yesOrNoComboBox.Text.Equals("Yes") ? true : false;

                foreach (string course in coursesList)
                {
                    if (year <= comboBoxYear && courses.getDegree().Equals(degree))
                    {
                        if (temp.Contains(course))
                            continue;

                        else
                        {
                           if (course.Equals("COSC4086 - Fourth Year Project") && !doProject)
                            {
                                temp.Add(course);
                                continue;
                            }

                            else
                            {
                                coursesCheckedListBox.Items.Add(course);
                                temp.Add(course);
                            }
                        }
                    }
                }
            }
        }

        // addYearComboBox()
        private void addYearComboBox()
        {
            yearComboBox.Items.Add("1");
            yearComboBox.Items.Add("2");
            yearComboBox.Items.Add("3");
            yearComboBox.Items.Add("4");
        }

        // addYesOrNo()
        private void addYesOrNo()
        {
            yesOrNoComboBox.Items.Add("Yes");
            yesOrNoComboBox.Items.Add("No");
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

        // yearComboBox_SelectedIndexChanged()
        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Research Proj Applicable?
            if (yearComboBox.SelectedIndex == 3)
                yesOrNoComboBox.Enabled = true;

            else
            {
                yesOrNoComboBox.ResetText();
                yesOrNoComboBox.Enabled = false;
            }

            // Not all required fields are filled
            if (yearComboBox.SelectedIndex == 3 && yesOrNoComboBox.SelectedIndex == -1)
            {
                coursesCheckedListBox.Items.Clear();
                return;
            }

            else if (!(degreesComboBox.SelectedIndex != -1) ? true : false)
                return;

            string degree = degreesComboBox.Text;
            addCourses(degree);
        }

        // degreesComboBox_SelectedIndexChanged()
        private void degreesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yesOrNoComboBox.Enabled == true && yesOrNoComboBox.SelectedIndex != -1 && yearComboBox.SelectedIndex != -1 ? true : false || yesOrNoComboBox.Enabled == false && yearComboBox.SelectedIndex != -1 ? true : false)
            {
                string degree = degreesComboBox.Text;
                addCourses(degree);
            }

            // Not all required fields are filled
            else
                return;
        }

        // yesOrNoComboBox_SelectedIndexChanged()
        private void yesOrNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Not all required fields are filled
            if (!(yearComboBox.SelectedIndex != -1 && degreesComboBox.SelectedIndex != -1 && yesOrNoComboBox.SelectedIndex != -1) ? true : false)
                return;

            string degree = degreesComboBox.Text;
            addCourses(degree);
        }

        // adviceBtn_Click()
        private void adviceBtn_Click(object sender, EventArgs e)
        {
            // Can we proceed
            if (yearComboBox.SelectedIndex == 3 && yesOrNoComboBox.SelectedIndex == -1)
            {
                coursesCheckedListBox.Items.Clear();
                return;
            }

            else if (!(yearComboBox.SelectedIndex != -1 && degreesComboBox.SelectedIndex != -1) ? true : false)
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
            string year = yearComboBox.SelectedItem.ToString();

            // Retrieve Advice
            inferenceEngine.generateCurrentStudentAdvice(degree, year, yesOrNoComboBox.Enabled == true && yesOrNoComboBox.SelectedItem.Equals("Yes") ? true : false, this);
        }

        // getCoursesCheckedListBox()
        public CheckedListBox getCoursesCheckedListBox()
        {
            return coursesCheckedListBox;
        }

        // giveAdvice()
        public void giveCurrentStudentAdvice(string degree, string year, List<string> courseCodes, List<string> courseTitles, string explanation)
        {
            // Set data
            degreeListBox.Items.Add(degree);
            degreeYearBox.Items.Add(year);

            foreach (string courseCode in courseCodes)
                courseCodesListBox.Items.Add(courseCode);

            foreach (string courseTitle in courseTitles)
                courseTitlesListBox.Items.Add(courseTitle);

            courseExplainBox.Text = explanation;
        }
    }
}
