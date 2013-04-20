namespace CourseManageSystem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelTLeft = new System.Windows.Forms.Panel();
            this.btnTMyCourse = new System.Windows.Forms.Button();
            this.btnTCourseMgr = new System.Windows.Forms.Button();
            this.btnTUpdatePwd = new System.Windows.Forms.Button();
            this.btnTPersonInfo = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnMyCourse = new System.Windows.Forms.Button();
            this.btnCourseInfo = new System.Windows.Forms.Button();
            this.btnUpdatePwd = new System.Windows.Forms.Button();
            this.btnPersonInfo = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelUserId = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panelTLeft.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelLocation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前位置：";
            // 
            // labelLocation
            // 
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(32, 17);
            this.labelLocation.Text = "系统";
            // 
            // panelCenter
            // 
            this.panelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(398, 33);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(446, 471);
            this.panelCenter.TabIndex = 3;
            // 
            // panelTLeft
            // 
            this.panelTLeft.BackgroundImage = global::CourseManageSystem.Properties.Resources.bg1;
            this.panelTLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTLeft.Controls.Add(this.btnTMyCourse);
            this.panelTLeft.Controls.Add(this.btnTCourseMgr);
            this.panelTLeft.Controls.Add(this.btnTUpdatePwd);
            this.panelTLeft.Controls.Add(this.btnTPersonInfo);
            this.panelTLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTLeft.Location = new System.Drawing.Point(199, 33);
            this.panelTLeft.Name = "panelTLeft";
            this.panelTLeft.Size = new System.Drawing.Size(199, 471);
            this.panelTLeft.TabIndex = 2;
            // 
            // btnTMyCourse
            // 
            this.btnTMyCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTMyCourse.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnTMyCourse.Location = new System.Drawing.Point(47, 337);
            this.btnTMyCourse.Name = "btnTMyCourse";
            this.btnTMyCourse.Size = new System.Drawing.Size(105, 76);
            this.btnTMyCourse.TabIndex = 3;
            this.btnTMyCourse.Text = "我的课程";
            this.btnTMyCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTMyCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTMyCourse.UseVisualStyleBackColor = true;
            // 
            // btnTCourseMgr
            // 
            this.btnTCourseMgr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTCourseMgr.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnTCourseMgr.Location = new System.Drawing.Point(47, 243);
            this.btnTCourseMgr.Name = "btnTCourseMgr";
            this.btnTCourseMgr.Size = new System.Drawing.Size(105, 76);
            this.btnTCourseMgr.TabIndex = 2;
            this.btnTCourseMgr.Text = "课程管理";
            this.btnTCourseMgr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTCourseMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTCourseMgr.UseVisualStyleBackColor = true;
            // 
            // btnTUpdatePwd
            // 
            this.btnTUpdatePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTUpdatePwd.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnTUpdatePwd.Location = new System.Drawing.Point(47, 149);
            this.btnTUpdatePwd.Name = "btnTUpdatePwd";
            this.btnTUpdatePwd.Size = new System.Drawing.Size(105, 76);
            this.btnTUpdatePwd.TabIndex = 1;
            this.btnTUpdatePwd.Text = "密码修改";
            this.btnTUpdatePwd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTUpdatePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTUpdatePwd.UseVisualStyleBackColor = true;
            // 
            // btnTPersonInfo
            // 
            this.btnTPersonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTPersonInfo.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnTPersonInfo.Location = new System.Drawing.Point(47, 55);
            this.btnTPersonInfo.Name = "btnTPersonInfo";
            this.btnTPersonInfo.Size = new System.Drawing.Size(105, 76);
            this.btnTPersonInfo.TabIndex = 0;
            this.btnTPersonInfo.Text = "个人信息";
            this.btnTPersonInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTPersonInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTPersonInfo.UseVisualStyleBackColor = true;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::CourseManageSystem.Properties.Resources.bg1;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.btnMyCourse);
            this.panelLeft.Controls.Add(this.btnCourseInfo);
            this.panelLeft.Controls.Add(this.btnUpdatePwd);
            this.panelLeft.Controls.Add(this.btnPersonInfo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 33);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(199, 471);
            this.panelLeft.TabIndex = 1;
            // 
            // btnMyCourse
            // 
            this.btnMyCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyCourse.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnMyCourse.Location = new System.Drawing.Point(47, 337);
            this.btnMyCourse.Name = "btnMyCourse";
            this.btnMyCourse.Size = new System.Drawing.Size(105, 76);
            this.btnMyCourse.TabIndex = 3;
            this.btnMyCourse.Text = "我的课程";
            this.btnMyCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMyCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMyCourse.UseVisualStyleBackColor = true;
            // 
            // btnCourseInfo
            // 
            this.btnCourseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCourseInfo.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnCourseInfo.Location = new System.Drawing.Point(47, 243);
            this.btnCourseInfo.Name = "btnCourseInfo";
            this.btnCourseInfo.Size = new System.Drawing.Size(105, 76);
            this.btnCourseInfo.TabIndex = 2;
            this.btnCourseInfo.Text = "开始选课";
            this.btnCourseInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCourseInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCourseInfo.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePwd
            // 
            this.btnUpdatePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatePwd.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnUpdatePwd.Location = new System.Drawing.Point(47, 149);
            this.btnUpdatePwd.Name = "btnUpdatePwd";
            this.btnUpdatePwd.Size = new System.Drawing.Size(105, 76);
            this.btnUpdatePwd.TabIndex = 1;
            this.btnUpdatePwd.Text = "密码修改";
            this.btnUpdatePwd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdatePwd.UseVisualStyleBackColor = true;
            // 
            // btnPersonInfo
            // 
            this.btnPersonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonInfo.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnPersonInfo.Location = new System.Drawing.Point(47, 55);
            this.btnPersonInfo.Name = "btnPersonInfo";
            this.btnPersonInfo.Size = new System.Drawing.Size(105, 76);
            this.btnPersonInfo.TabIndex = 0;
            this.btnPersonInfo.Text = "个人信息";
            this.btnPersonInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPersonInfo.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::CourseManageSystem.Properties.Resources.bar;
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.labelUserId);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(844, 33);
            this.panelTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(605, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "欢迎您：";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(766, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "安全退出";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // labelUserId
            // 
            this.labelUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Location = new System.Drawing.Point(662, 8);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(96, 16);
            this.labelUserId.TabIndex = 1;
            this.labelUserId.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 526);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTLeft);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "课程管理系统";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelTLeft.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelLocation;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button btnPersonInfo;
        private System.Windows.Forms.Button btnMyCourse;
        private System.Windows.Forms.Button btnCourseInfo;
        private System.Windows.Forms.Button btnUpdatePwd;
        private System.Windows.Forms.Panel panelTLeft;
        private System.Windows.Forms.Button btnTMyCourse;
        private System.Windows.Forms.Button btnTCourseMgr;
        private System.Windows.Forms.Button btnTUpdatePwd;
        private System.Windows.Forms.Button btnTPersonInfo;
    }
}