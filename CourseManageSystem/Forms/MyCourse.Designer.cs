namespace CourseManageSystem.Forms
{
    partial class MyCourse
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
            this.dataGridViewMyCourse = new System.Windows.Forms.DataGridView();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMyCourse
            // 
            this.dataGridViewMyCourse.AllowUserToAddRows = false;
            this.dataGridViewMyCourse.AllowUserToDeleteRows = false;
            this.dataGridViewMyCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMyCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMyCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyCourse.Location = new System.Drawing.Point(0, 132);
            this.dataGridViewMyCourse.Name = "dataGridViewMyCourse";
            this.dataGridViewMyCourse.ReadOnly = true;
            this.dataGridViewMyCourse.RowTemplate.Height = 23;
            this.dataGridViewMyCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMyCourse.Size = new System.Drawing.Size(636, 317);
            this.dataGridViewMyCourse.TabIndex = 0;
            // 
            // labelStudent
            // 
            this.labelStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStudent.AutoSize = true;
            this.labelStudent.ForeColor = System.Drawing.Color.Red;
            this.labelStudent.Location = new System.Drawing.Point(253, 85);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(29, 12);
            this.labelStudent.TabIndex = 1;
            this.labelStudent.Text = "同学";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(249, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 33);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "我的课程";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(298, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "同学，欢迎您！";
            // 
            // MyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(636, 449);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.dataGridViewMyCourse);
            this.Name = "MyCourse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMyCourse;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
    }
}
