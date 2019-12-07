/*  -------------------------------------------------------
 *  MainGUI.cs
 *  -------------------------------------------------------
 *  Author:  Matthew Ferlaino
 *  Course:	 COSC3117
 *  ID:      169657520
 *  Email:   mferlaino@algomau.ca
 *  Date:	 Oct 21, 2019
 *  ------------------------------------------------------- */

namespace COSC_Expert_System
{
    partial class MainGUI
    {
        // Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox currentStudentBox;
        private System.Windows.Forms.PictureBox newStudentBox;
        private System.Windows.Forms.Button currStudentsBtn;
        private System.Windows.Forms.GroupBox currStudentsGrpBox;
        private System.Windows.Forms.GroupBox newStudentsGrpBox;
        private System.Windows.Forms.Button newStudentsBtn;

        /* 
         * ---- Methods ----
         * 1. Dispose()
         * 2. IntitializeComponent()
         * 3. 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.currentStudentBox = new System.Windows.Forms.PictureBox();
            this.newStudentBox = new System.Windows.Forms.PictureBox();
            this.currStudentsBtn = new System.Windows.Forms.Button();
            this.currStudentsGrpBox = new System.Windows.Forms.GroupBox();
            this.newStudentsGrpBox = new System.Windows.Forms.GroupBox();
            this.newStudentsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currentStudentBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentBox)).BeginInit();
            this.currStudentsGrpBox.SuspendLayout();
            this.newStudentsGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentStudentBox
            // 
            this.currentStudentBox.Image = ((System.Drawing.Image)(resources.GetObject("currentStudentBox.Image")));
            this.currentStudentBox.Location = new System.Drawing.Point(27, 28);
            this.currentStudentBox.Name = "currentStudentBox";
            this.currentStudentBox.Size = new System.Drawing.Size(245, 261);
            this.currentStudentBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.currentStudentBox.TabIndex = 1;
            this.currentStudentBox.TabStop = false;
            // 
            // newStudentBox
            // 
            this.newStudentBox.Image = ((System.Drawing.Image)(resources.GetObject("newStudentBox.Image")));
            this.newStudentBox.Location = new System.Drawing.Point(24, 28);
            this.newStudentBox.Name = "newStudentBox";
            this.newStudentBox.Size = new System.Drawing.Size(245, 261);
            this.newStudentBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.newStudentBox.TabIndex = 2;
            this.newStudentBox.TabStop = false;
            // 
            // currStudentsBtn
            // 
            this.currStudentsBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.currStudentsBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currStudentsBtn.Location = new System.Drawing.Point(53, 294);
            this.currStudentsBtn.Name = "currStudentsBtn";
            this.currStudentsBtn.Size = new System.Drawing.Size(204, 36);
            this.currStudentsBtn.TabIndex = 2;
            this.currStudentsBtn.Text = "Academic Advising";
            this.currStudentsBtn.UseVisualStyleBackColor = false;
            this.currStudentsBtn.Click += new System.EventHandler(this.currStudentBtn_Click);
            // 
            // currStudentsGrpBox
            // 
            this.currStudentsGrpBox.Controls.Add(this.currentStudentBox);
            this.currStudentsGrpBox.Controls.Add(this.currStudentsBtn);
            this.currStudentsGrpBox.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currStudentsGrpBox.Location = new System.Drawing.Point(328, 12);
            this.currStudentsGrpBox.Name = "currStudentsGrpBox";
            this.currStudentsGrpBox.Size = new System.Drawing.Size(300, 336);
            this.currStudentsGrpBox.TabIndex = 0;
            this.currStudentsGrpBox.TabStop = false;
            this.currStudentsGrpBox.Text = "Current Students";
            // 
            // newStudentsGrpBox
            // 
            this.newStudentsGrpBox.Controls.Add(this.newStudentsBtn);
            this.newStudentsGrpBox.Controls.Add(this.newStudentBox);
            this.newStudentsGrpBox.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStudentsGrpBox.Location = new System.Drawing.Point(12, 12);
            this.newStudentsGrpBox.Name = "newStudentsGrpBox";
            this.newStudentsGrpBox.Size = new System.Drawing.Size(300, 336);
            this.newStudentsGrpBox.TabIndex = 0;
            this.newStudentsGrpBox.TabStop = false;
            this.newStudentsGrpBox.Text = "New Students";
            // 
            // newStudentsBtn
            // 
            this.newStudentsBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newStudentsBtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStudentsBtn.Location = new System.Drawing.Point(48, 294);
            this.newStudentsBtn.Name = "newStudentsBtn";
            this.newStudentsBtn.Size = new System.Drawing.Size(204, 36);
            this.newStudentsBtn.TabIndex = 1;
            this.newStudentsBtn.Text = "Academic Advising";
            this.newStudentsBtn.UseVisualStyleBackColor = false;
            this.newStudentsBtn.Click += new System.EventHandler(this.newStudentBtn_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(640, 357);
            this.Controls.Add(this.newStudentsGrpBox);
            this.Controls.Add(this.currStudentsGrpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGUI";
            this.Text = "COSC Expert System Advisor";
            ((System.ComponentModel.ISupportInitialize)(this.currentStudentBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStudentBox)).EndInit();
            this.currStudentsGrpBox.ResumeLayout(false);
            this.newStudentsGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}

