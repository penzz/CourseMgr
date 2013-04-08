namespace CourseManageSystem
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnUpdatePwd = new System.Windows.Forms.Button();
            this.btnPersonInfo = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelUserId = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
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
            this.statusStrip1.TabIndex = 1;
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
            this.panelCenter.BackgroundImage = global::CourseManageSystem.Properties.Resources.background;
            this.panelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(199, 33);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(645, 471);
            this.panelCenter.TabIndex = 3;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::CourseManageSystem.Properties.Resources.bg1;
            this.panelLeft.Controls.Add(this.button3);
            this.panelLeft.Controls.Add(this.btnCourse);
            this.panelLeft.Controls.Add(this.btnUpdatePwd);
            this.panelLeft.Controls.Add(this.btnPersonInfo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 33);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(199, 471);
            this.panelLeft.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.button3.Location = new System.Drawing.Point(47, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 76);
            this.button3.TabIndex = 11;
            this.button3.Text = "个人信息";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCourse
            // 
            this.btnCourse.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnCourse.Location = new System.Drawing.Point(47, 243);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(105, 76);
            this.btnCourse.TabIndex = 11;
            this.btnCourse.Text = "课程信息";
            this.btnCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCourse.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePwd
            // 
            this.btnUpdatePwd.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnUpdatePwd.Location = new System.Drawing.Point(47, 149);
            this.btnUpdatePwd.Name = "btnUpdatePwd";
            this.btnUpdatePwd.Size = new System.Drawing.Size(105, 76);
            this.btnUpdatePwd.TabIndex = 11;
            this.btnUpdatePwd.Text = "密码修改";
            this.btnUpdatePwd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdatePwd.UseVisualStyleBackColor = true;
            // 
            // btnPersonInfo
            // 
            this.btnPersonInfo.Image = global::CourseManageSystem.Properties.Resources.btn;
            this.btnPersonInfo.Location = new System.Drawing.Point(47, 55);
            this.btnPersonInfo.Name = "btnPersonInfo";
            this.btnPersonInfo.Size = new System.Drawing.Size(105, 76);
            this.btnPersonInfo.TabIndex = 11;
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
            this.label2.Location = new System.Drawing.Point(583, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
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
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "安全退出";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // labelUserId
            // 
            this.labelUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Location = new System.Drawing.Point(640, 8);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(120, 16);
            this.labelUserId.TabIndex = 0;
            this.labelUserId.Text = "label1";
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 526);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentMain";
            this.Text = "StudentMain";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnUpdatePwd;
    }
}