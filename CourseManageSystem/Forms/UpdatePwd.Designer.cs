namespace CourseManageSystem.Forms
{
    partial class UpdatePwd
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbOldPwd = new System.Windows.Forms.TextBox();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.tbRepeatPwd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "旧密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "重密码：";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(228, 90);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(152, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbOldPwd
            // 
            this.tbOldPwd.Location = new System.Drawing.Point(228, 139);
            this.tbOldPwd.Name = "tbOldPwd";
            this.tbOldPwd.PasswordChar = '*';
            this.tbOldPwd.Size = new System.Drawing.Size(152, 21);
            this.tbOldPwd.TabIndex = 1;
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Location = new System.Drawing.Point(228, 188);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.PasswordChar = '*';
            this.tbNewPwd.Size = new System.Drawing.Size(152, 21);
            this.tbNewPwd.TabIndex = 1;
            // 
            // tbRepeatPwd
            // 
            this.tbRepeatPwd.Location = new System.Drawing.Point(228, 237);
            this.tbRepeatPwd.Name = "tbRepeatPwd";
            this.tbRepeatPwd.PasswordChar = '*';
            this.tbRepeatPwd.Size = new System.Drawing.Size(152, 21);
            this.tbRepeatPwd.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdatePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(548, 402);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbRepeatPwd);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.tbOldPwd);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbOldPwd;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.TextBox tbRepeatPwd;
        private System.Windows.Forms.Button btnUpdate;
    }
}
