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
using static COSC_Expert_System.ExplanationSystem;
using static COSC_Expert_System.Node;
using static COSC_Expert_System.NewStudentGUI;
using static COSC_Expert_System.CurrentStudentGUI;

namespace COSC_Expert_System
{
    public partial class MainGUI : Form
    {
        // Variables
        private NewStudentGUI newStudentGUI;
        private CurrentStudentGUI currStudentGUI;

        // No-arg Constructor
        public MainGUI()
        {
            // Instantiate GUIs
            newStudentGUI = new NewStudentGUI();
            currStudentGUI = new CurrentStudentGUI();

            // Show MainGUI
            InitializeComponent();   
        }

        /* 
         * ---- Methods ----
         * 1. newStudentBtn_Click()
         * 2. currStudentBtn_Click()
         */

        // newStudentBtn_Click()
        private void newStudentBtn_Click(object sender, EventArgs e)
        {
            // Show our New Student GUI
            newStudentGUI.ShowDialog();
        }

        // currStudentBtn_Click()
        private void currStudentBtn_Click(object sender, EventArgs e)
        {
            // Show our Current Student GUI
            currStudentGUI.ShowDialog();
        }
    }
}
