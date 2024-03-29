﻿namespace CourseManageSystem.Forms
{
    partial class AddCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCcredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCtime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCmajorname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCteacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCinfo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名：";
            // 
            // tbCname
            // 
            this.tbCname.Location = new System.Drawing.Point(81, 15);
            this.tbCname.Name = "tbCname";
            this.tbCname.Size = new System.Drawing.Size(175, 21);
            this.tbCname.TabIndex = 0;
            this.tbCname.Tag = "课程名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学  分：";
            // 
            // tbCcredit
            // 
            this.tbCcredit.Location = new System.Drawing.Point(81, 48);
            this.tbCcredit.Name = "tbCcredit";
            this.tbCcredit.Size = new System.Drawing.Size(175, 21);
            this.tbCcredit.TabIndex = 1;
            this.tbCcredit.Tag = "学分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "上课时间：";
            // 
            // tbCtime
            // 
            this.tbCtime.Location = new System.Drawing.Point(81, 81);
            this.tbCtime.Name = "tbCtime";
            this.tbCtime.Size = new System.Drawing.Size(175, 21);
            this.tbCtime.TabIndex = 2;
            this.tbCtime.Tag = "上课时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "适合专业：";
            // 
            // tbCmajorname
            // 
            this.tbCmajorname.Location = new System.Drawing.Point(81, 114);
            this.tbCmajorname.Name = "tbCmajorname";
            this.tbCmajorname.Size = new System.Drawing.Size(175, 21);
            this.tbCmajorname.TabIndex = 3;
            this.tbCmajorname.Tag = "适合专业";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "老师编号：";
            // 
            // tbCteacher
            // 
            this.tbCteacher.Location = new System.Drawing.Point(81, 147);
            this.tbCteacher.Name = "tbCteacher";
            this.tbCteacher.ReadOnly = true;
            this.tbCteacher.Size = new System.Drawing.Size(175, 21);
            this.tbCteacher.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "课程简介：";
            // 
            // tbCinfo
            // 
            this.tbCinfo.Location = new System.Drawing.Point(81, 182);
            this.tbCinfo.Multiline = true;
            this.tbCinfo.Name = "tbCinfo";
            this.tbCinfo.Size = new System.Drawing.Size(306, 99);
            this.tbCinfo.TabIndex = 4;
            this.tbCinfo.Tag = "简介";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 352);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCinfo);
            this.Controls.Add(this.tbCteacher);
            this.Controls.Add(this.tbCmajorname);
            this.Controls.Add(this.tbCtime);
            this.Controls.Add(this.tbCcredit);
            this.Controls.Add(this.tbCname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCourse";
            this.Text = "添加课程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCcredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCmajorname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCteacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCinfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}