/*  -------------------------------------------------------
 *  NewStudentGUI.cs
 *  -------------------------------------------------------
 *  Author:  Matthew Ferlaino
 *  Course:	 COSC3117
 *  ID:      169657520
 *  Email:   mferlaino@algomau.ca
 *  Date:	 Oct 21, 2019
 *  ------------------------------------------------------- */

 // Imports
using System.Windows.Forms;

namespace COSC_Expert_System
{
    partial class NewStudentGUI
    {
        // Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox courseCodeListBox;
        private System.Windows.Forms.Label courseCodeLbl;
        private System.Windows.Forms.Label degreeLbl1;
        private System.Windows.Forms.ListBox uniDegreesBox;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.GroupBox courseLegendGrpBox;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.ListBox yearListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label degreeLbl2;
        private System.Windows.Forms.Label courseExplanLbl;
        private System.Windows.Forms.RichTextBox courseExplainBox;
        private System.Windows.Forms.ListBox degreeYearBox;
        private System.Windows.Forms.Label yearLbl1;
        private System.Windows.Forms.ListBox degreeListBox;
        private System.Windows.Forms.Label courseTitlesLbl;
        private System.Windows.Forms.ListBox courseTitlesListBox;
        private System.Windows.Forms.ListBox courseCodesListBox;
        private System.Windows.Forms.Label courseCodesLbl;
        private System.Windows.Forms.Label degreeLbl3;
        private System.Windows.Forms.ComboBox degreesComboBox;
        private System.Windows.Forms.Button adviceBtn;

        /* 
         * ---- Methods ----
         * 1. Dispose()
         * 2. IntitializeComponent() 
         */

        // Dispose()
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // IntitializeComponent()
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStudentGUI));
            this.courseCodeListBox = new System.Windows.Forms.ListBox();
            this.courseCodeLbl = new System.Windows.Forms.Label();
            this.degreeLbl1 = new System.Windows.Forms.Label();
            this.uniDegreesBox = new System.Windows.Forms.ListBox();
            this.courseLbl = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.courseLegendGrpBox = new System.Windows.Forms.GroupBox();
            this.yearListBox = new System.Windows.Forms.ListBox();
            this.yearLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adviceBtn = new System.Windows.Forms.Button();
            this.degreesComboBox = new System.Windows.Forms.ComboBox();
            this.degreeLbl3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.courseCodesListBox = new System.Windows.Forms.ListBox();
            this.courseCodesLbl = new System.Windows.Forms.Label();
            this.courseTitlesListBox = new System.Windows.Forms.ListBox();
            this.courseTitlesLbl = new System.Windows.Forms.Label();
            this.degreeYearBox = new System.Windows.Forms.ListBox();
            this.yearLbl1 = new System.Windows.Forms.Label();
            this.degreeListBox = new System.Windows.Forms.ListBox();
            this.degreeLbl2 = new System.Windows.Forms.Label();
            this.courseExplanLbl = new System.Windows.Forms.Label();
            this.courseExplainBox = new System.Windows.Forms.RichTextBox();
            this.courseLegendGrpBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseCodeListBox
            // 
            this.courseCodeListBox.BackColor = System.Drawing.Color.Silver;
            this.courseCodeListBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodeListBox.FormattingEnabled = true;
            this.courseCodeListBox.ItemHeight = 16;
            this.courseCodeListBox.Location = new System.Drawing.Point(6, 49);
            this.courseCodeListBox.Name = "courseCodeListBox";
            this.courseCodeListBox.Size = new System.Drawing.Size(150, 148);
            this.courseCodeListBox.Sorted = true;
            this.courseCodeListBox.TabIndex = 1;
            this.courseCodeListBox.SelectedIndexChanged += new System.EventHandler(this.courseCodeListBox_SelectedIndexChanged);
            // 
            // courseCodeLbl
            // 
            this.courseCodeLbl.AutoSize = true;
            this.courseCodeLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.courseCodeLbl.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodeLbl.Location = new System.Drawing.Point(21, 26);
            this.courseCodeLbl.Name = "courseCodeLbl";
            this.courseCodeLbl.Size = new System.Drawing.Size(118, 20);
            this.courseCodeLbl.TabIndex = 2;
            this.courseCodeLbl.Text = "Course Codes";
            // 
            // degreeLbl1
            // 
            this.degreeLbl1.AutoSize = true;
            this.degreeLbl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.degreeLbl1.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeLbl1.ForeColor = System.Drawing.Color.Black;
            this.degreeLbl1.Location = new System.Drawing.Point(257, 26);
            this.degreeLbl1.Name = "degreeLbl1";
            this.degreeLbl1.Size = new System.Drawing.Size(310, 20);
            this.degreeLbl1.TabIndex = 4;
            this.degreeLbl1.Text = "University Degrees Requiring Course";
            // 
            // uniDegreesBox
            // 
            this.uniDegreesBox.BackColor = System.Drawing.Color.Silver;
            this.uniDegreesBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniDegreesBox.FormattingEnabled = true;
            this.uniDegreesBox.ItemHeight = 16;
            this.uniDegreesBox.Location = new System.Drawing.Point(171, 49);
            this.uniDegreesBox.Name = "uniDegreesBox";
            this.uniDegreesBox.Size = new System.Drawing.Size(490, 84);
            this.uniDegreesBox.Sorted = true;
            this.uniDegreesBox.TabIndex = 5;
            // 
            // courseLbl
            // 
            this.courseLbl.AutoSize = true;
            this.courseLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.courseLbl.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.Location = new System.Drawing.Point(176, 147);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(70, 20);
            this.courseLbl.TabIndex = 6;
            this.courseLbl.Text = "Course:";
            // 
            // courseListBox
            // 
            this.courseListBox.BackColor = System.Drawing.Color.Silver;
            this.courseListBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 16;
            this.courseListBox.Location = new System.Drawing.Point(252, 147);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(301, 20);
            this.courseListBox.TabIndex = 9;
            // 
            // courseLegendGrpBox
            // 
            this.courseLegendGrpBox.BackColor = System.Drawing.Color.SlateGray;
            this.courseLegendGrpBox.Controls.Add(this.yearListBox);
            this.courseLegendGrpBox.Controls.Add(this.yearLbl);
            this.courseLegendGrpBox.Controls.Add(this.courseListBox);
            this.courseLegendGrpBox.Controls.Add(this.courseCodeListBox);
            this.courseLegendGrpBox.Controls.Add(this.courseLbl);
            this.courseLegendGrpBox.Controls.Add(this.courseCodeLbl);
            this.courseLegendGrpBox.Controls.Add(this.uniDegreesBox);
            this.courseLegendGrpBox.Controls.Add(this.degreeLbl1);
            this.courseLegendGrpBox.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLegendGrpBox.Location = new System.Drawing.Point(12, 12);
            this.courseLegendGrpBox.Name = "courseLegendGrpBox";
            this.courseLegendGrpBox.Size = new System.Drawing.Size(670, 213);
            this.courseLegendGrpBox.TabIndex = 11;
            this.courseLegendGrpBox.TabStop = false;
            this.courseLegendGrpBox.Text = "Courses Legend";
            // 
            // yearListBox
            // 
            this.yearListBox.BackColor = System.Drawing.Color.Silver;
            this.yearListBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearListBox.FormattingEnabled = true;
            this.yearListBox.ItemHeight = 16;
            this.yearListBox.Location = new System.Drawing.Point(252, 177);
            this.yearListBox.Name = "yearListBox";
            this.yearListBox.Size = new System.Drawing.Size(32, 20);
            this.yearListBox.TabIndex = 11;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.yearLbl.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(176, 177);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(52, 20);
            this.yearLbl.TabIndex = 10;
            this.yearLbl.Text = "Year:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.adviceBtn);
            this.groupBox1.Controls.Add(this.degreesComboBox);
            this.groupBox1.Controls.Add(this.degreeLbl3);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(702, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courses Generator";
            // 
            // adviceBtn
            // 
            this.adviceBtn.Location = new System.Drawing.Point(183, 79);
            this.adviceBtn.Name = "adviceBtn";
            this.adviceBtn.Size = new System.Drawing.Size(192, 32);
            this.adviceBtn.TabIndex = 25;
            this.adviceBtn.Text = "Receive Advice";
            this.adviceBtn.UseVisualStyleBackColor = true;
            this.adviceBtn.Click += new System.EventHandler(this.adviceBtn_Click);
            // 
            // degreesComboBox
            // 
            this.degreesComboBox.BackColor = System.Drawing.Color.Silver;
            this.degreesComboBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesComboBox.FormattingEnabled = true;
            this.degreesComboBox.Location = new System.Drawing.Point(27, 49);
            this.degreesComboBox.Name = "degreesComboBox";
            this.degreesComboBox.Size = new System.Drawing.Size(490, 24);
            this.degreesComboBox.TabIndex = 18;
            // 
            // degreeLbl3
            // 
            this.degreeLbl3.AutoSize = true;
            this.degreeLbl3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.degreeLbl3.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeLbl3.Location = new System.Drawing.Point(243, 26);
            this.degreeLbl3.Name = "degreeLbl3";
            this.degreeLbl3.Size = new System.Drawing.Size(64, 20);
            this.degreeLbl3.TabIndex = 17;
            this.degreeLbl3.Text = "Degree";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Controls.Add(this.courseCodesListBox);
            this.groupBox2.Controls.Add(this.courseCodesLbl);
            this.groupBox2.Controls.Add(this.courseTitlesListBox);
            this.groupBox2.Controls.Add(this.courseTitlesLbl);
            this.groupBox2.Controls.Add(this.degreeYearBox);
            this.groupBox2.Controls.Add(this.yearLbl1);
            this.groupBox2.Controls.Add(this.degreeListBox);
            this.groupBox2.Controls.Add(this.degreeLbl2);
            this.groupBox2.Controls.Add(this.courseExplanLbl);
            this.groupBox2.Controls.Add(this.courseExplainBox);
            this.groupBox2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 283);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Recommendations";
            // 
            // courseCodesListBox
            // 
            this.courseCodesListBox.BackColor = System.Drawing.Color.Silver;
            this.courseCodesListBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodesListBox.FormattingEnabled = true;
            this.courseCodesListBox.ItemHeight = 16;
            this.courseCodesListBox.Location = new System.Drawing.Point(502, 109);
            this.courseCodesListBox.Name = "courseCodesListBox";
            this.courseCodesListBox.Size = new System.Drawing.Size(159, 68);
            this.courseCodesListBox.Sorted = true;
            this.courseCodesListBox.TabIndex = 19;
            // 
            // courseCodesLbl
            // 
            this.courseCodesLbl.AutoSize = true;
            this.courseCodesLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.courseCodesLbl.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodesLbl.Location = new System.Drawing.Point(518, 86);
            this.courseCodesLbl.Name = "courseCodesLbl";
            this.courseCodesLbl.Size = new System.Drawing.Size(126, 20);
            this.courseCodesLbl.TabIndex = 18;
            this.courseCodesLbl.Text = "Courses Codes";
            // 
            // courseTitlesListBox
            // 
            this.courseTitlesListBox.BackColor = System.Drawing.Color.Silver;
            this.courseTitlesListBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitlesListBox.FormattingEnabled = true;
            this.courseTitlesListBox.ItemHeight = 16;
            this.courseTitlesListBox.Location = new System.Drawing.Point(6, 109);
            this.courseTitlesListBox.Name = "courseTitlesListBox";
            this.courseTitlesListBox.Size = new System.Drawing.Size(490, 68);
            this.courseTitlesListBox.Sorted = true;
            this.courseTitlesListBox.TabIndex = 17;
            // 
            // courseTitlesLbl
            // 
            this.courseTitlesLbl.AutoSize = true;
            this.courseTitlesLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.courseTitlesLbl.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitlesLbl.Location = new System.Drawing.Point(188, 86);
            this.courseTitlesLbl.Name = "courseTitlesLbl";
            this.courseTitlesLbl.Size = new System.Drawing.Size(117, 20);
            this.courseTitlesLbl.TabIndex = 16;
            this.courseTitlesLbl.Text = "Course Titles";
            // 
            // degreeYearBox
            // 
            this.degreeYearBox.BackColor = System.Drawing.Color.Silver;
            this.degreeYearBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeYearBox.FormattingEnabled = true;
            this.degreeYearBox.ItemHeight = 16;
            this.degreeYearBox.Location = new System.Drawing.Point(77, 58);
            this.degreeYearBox.Name = "degreeYearBox";
            this.degreeYearBox.Size = new System.Drawing.Size(32, 20);
            this.degreeYearBox.TabIndex = 15;
            // 
            // yearLbl1
            // 
            this.yearLbl1.AutoSize = true;
            this.yearLbl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.yearLbl1.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl1.Location = new System.Drawing.Point(6, 58);
            this.yearLbl1.Name = "yearLbl1";
            this.yearLbl1.Size = new System.Drawing.Size(52, 20);
            this.yearLbl1.TabIndex = 14;
            this.yearLbl1.Text = "Year:";
            // 
            // degreeListBox
            // 
            this.degreeListBox.BackColor = System.Drawing.Color.Silver;
            this.degreeListBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeListBox.FormattingEnabled = true;
            this.degreeListBox.ItemHeight = 16;
            this.degreeListBox.Location = new System.Drawing.Point(77, 26);
            this.degreeListBox.Name = "degreeListBox";
            this.degreeListBox.Size = new System.Drawing.Size(490, 20);
            this.degreeListBox.TabIndex = 13;
            // 
            // degreeLbl2
            // 
            this.degreeLbl2.AutoSize = true;
            this.degreeLbl2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.degreeLbl2.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeLbl2.Location = new System.Drawing.Point(6, 26);
            this.degreeLbl2.Name = "degreeLbl2";
            this.degreeLbl2.Size = new System.Drawing.Size(69, 20);
            this.degreeLbl2.TabIndex = 12;
            this.degreeLbl2.Text = "Degree:";
            // 
            // courseExplanLbl
            // 
            this.courseExplanLbl.AutoSize = true;
            this.courseExplanLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.courseExplanLbl.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseExplanLbl.Location = new System.Drawing.Point(202, 183);
            this.courseExplanLbl.Name = "courseExplanLbl";
            this.courseExplanLbl.Size = new System.Drawing.Size(253, 20);
            this.courseExplanLbl.TabIndex = 11;
            this.courseExplanLbl.Text = "Course Selection Explanation";
            // 
            // courseExplainBox
            // 
            this.courseExplainBox.BackColor = System.Drawing.Color.Silver;
            this.courseExplainBox.Font = new System.Drawing.Font("Century Schoolbook", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseExplainBox.Location = new System.Drawing.Point(6, 206);
            this.courseExplainBox.Name = "courseExplainBox";
            this.courseExplainBox.Size = new System.Drawing.Size(655, 69);
            this.courseExplainBox.TabIndex = 0;
            this.courseExplainBox.Text = "";
            // 
            // NewStudentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1256, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.courseLegendGrpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewStudentGUI";
            this.Text = "New Student Advisor";
            this.courseLegendGrpBox.ResumeLayout(false);
            this.courseLegendGrpBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

