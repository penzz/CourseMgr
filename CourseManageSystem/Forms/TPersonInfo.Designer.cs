namespace CourseManageSystem.Forms
{
    partial class TPersonInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tuseridLabel;
            System.Windows.Forms.Label tusernameLabel;
            System.Windows.Forms.Label tsexLabel;
            System.Windows.Forms.Label tphoneLabel;
            System.Windows.Forms.Label temailLabel;
            System.Windows.Forms.Label tacademicLabel;
            System.Windows.Forms.Label theaderLabel;
            System.Windows.Forms.Label tintroLabel;
            System.Windows.Forms.Label tbirthdayLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePhoto = new System.Windows.Forms.Button();
            this.tphotoPictureBox = new System.Windows.Forms.PictureBox();
            this.selectTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseMgrDataSet = new CourseManageSystem.Database.CourseMgrDataSet();
            this.btnCommit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectTeacherTableAdapter = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.SelectTeacherTableAdapter();
            this.tableAdapterManager = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager();
            this.tuseridTextBox = new System.Windows.Forms.TextBox();
            this.tusernameTextBox = new System.Windows.Forms.TextBox();
            this.tsexTextBox = new System.Windows.Forms.TextBox();
            this.tphoneTextBox = new System.Windows.Forms.TextBox();
            this.temailTextBox = new System.Windows.Forms.TextBox();
            this.tacademicTextBox = new System.Windows.Forms.TextBox();
            this.theaderTextBox = new System.Windows.Forms.TextBox();
            this.tintroTextBox = new System.Windows.Forms.TextBox();
            this.tbirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            tuseridLabel = new System.Windows.Forms.Label();
            tusernameLabel = new System.Windows.Forms.Label();
            tsexLabel = new System.Windows.Forms.Label();
            tphoneLabel = new System.Windows.Forms.Label();
            temailLabel = new System.Windows.Forms.Label();
            tacademicLabel = new System.Windows.Forms.Label();
            theaderLabel = new System.Windows.Forms.Label();
            tintroLabel = new System.Windows.Forms.Label();
            tbirthdayLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tphotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTeacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tuseridLabel
            // 
            tuseridLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tuseridLabel.AutoSize = true;
            tuseridLabel.Location = new System.Drawing.Point(68, 124);
            tuseridLabel.Name = "tuseridLabel";
            tuseridLabel.Size = new System.Drawing.Size(53, 12);
            tuseridLabel.TabIndex = 1;
            tuseridLabel.Text = "用户名：";
            // 
            // tusernameLabel
            // 
            tusernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tusernameLabel.AutoSize = true;
            tusernameLabel.Location = new System.Drawing.Point(68, 151);
            tusernameLabel.Name = "tusernameLabel";
            tusernameLabel.Size = new System.Drawing.Size(53, 12);
            tusernameLabel.TabIndex = 3;
            tusernameLabel.Text = "姓  名：";
            // 
            // tsexLabel
            // 
            tsexLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tsexLabel.AutoSize = true;
            tsexLabel.Location = new System.Drawing.Point(68, 178);
            tsexLabel.Name = "tsexLabel";
            tsexLabel.Size = new System.Drawing.Size(53, 12);
            tsexLabel.TabIndex = 5;
            tsexLabel.Text = "性  别：";
            // 
            // tphoneLabel
            // 
            tphoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tphoneLabel.AutoSize = true;
            tphoneLabel.Location = new System.Drawing.Point(68, 205);
            tphoneLabel.Name = "tphoneLabel";
            tphoneLabel.Size = new System.Drawing.Size(53, 12);
            tphoneLabel.TabIndex = 7;
            tphoneLabel.Text = "电  话：";
            // 
            // temailLabel
            // 
            temailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            temailLabel.AutoSize = true;
            temailLabel.Location = new System.Drawing.Point(68, 232);
            temailLabel.Name = "temailLabel";
            temailLabel.Size = new System.Drawing.Size(53, 12);
            temailLabel.TabIndex = 9;
            temailLabel.Text = "邮  箱：";
            // 
            // tacademicLabel
            // 
            tacademicLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tacademicLabel.AutoSize = true;
            tacademicLabel.Location = new System.Drawing.Point(68, 259);
            tacademicLabel.Name = "tacademicLabel";
            tacademicLabel.Size = new System.Drawing.Size(53, 12);
            tacademicLabel.TabIndex = 11;
            tacademicLabel.Text = "学  院：";
            // 
            // theaderLabel
            // 
            theaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            theaderLabel.AutoSize = true;
            theaderLabel.Location = new System.Drawing.Point(68, 286);
            theaderLabel.Name = "theaderLabel";
            theaderLabel.Size = new System.Drawing.Size(53, 12);
            theaderLabel.TabIndex = 13;
            theaderLabel.Text = "职  称：";
            // 
            // tintroLabel
            // 
            tintroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tintroLabel.AutoSize = true;
            tintroLabel.Location = new System.Drawing.Point(68, 345);
            tintroLabel.Name = "tintroLabel";
            tintroLabel.Size = new System.Drawing.Size(53, 12);
            tintroLabel.TabIndex = 15;
            tintroLabel.Text = "简  介：";
            // 
            // tbirthdayLabel
            // 
            tbirthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tbirthdayLabel.AutoSize = true;
            tbirthdayLabel.Location = new System.Drawing.Point(68, 315);
            tbirthdayLabel.Name = "tbirthdayLabel";
            tbirthdayLabel.Size = new System.Drawing.Size(65, 12);
            tbirthdayLabel.TabIndex = 19;
            tbirthdayLabel.Text = "出生日期：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnUpdatePhoto);
            this.groupBox1.Controls.Add(this.tphotoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(311, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(149, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "照片";
            // 
            // btnUpdatePhoto
            // 
            this.btnUpdatePhoto.Location = new System.Drawing.Point(38, 178);
            this.btnUpdatePhoto.Name = "btnUpdatePhoto";
            this.btnUpdatePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePhoto.TabIndex = 0;
            this.btnUpdatePhoto.Text = "更改";
            this.btnUpdatePhoto.UseVisualStyleBackColor = true;
            // 
            // tphotoPictureBox
            // 
            this.tphotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.selectTeacherBindingSource, "Tphoto", true));
            this.tphotoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tphotoPictureBox.Location = new System.Drawing.Point(10, 24);
            this.tphotoPictureBox.Name = "tphotoPictureBox";
            this.tphotoPictureBox.Size = new System.Drawing.Size(129, 153);
            this.tphotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tphotoPictureBox.TabIndex = 41;
            this.tphotoPictureBox.TabStop = false;
            // 
            // selectTeacherBindingSource
            // 
            this.selectTeacherBindingSource.DataMember = "SelectTeacher";
            this.selectTeacherBindingSource.DataSource = this.courseMgrDataSet;
            // 
            // courseMgrDataSet
            // 
            this.courseMgrDataSet.DataSetName = "CourseMgrDataSet";
            this.courseMgrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCommit.Location = new System.Drawing.Point(136, 443);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 10;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            // 
            // selectTeacherTableAdapter
            // 
            this.selectTeacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.SCTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tuseridTextBox
            // 
            this.tuseridTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tuseridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tuserid", true));
            this.tuseridTextBox.Location = new System.Drawing.Point(136, 121);
            this.tuseridTextBox.Name = "tuseridTextBox";
            this.tuseridTextBox.ReadOnly = true;
            this.tuseridTextBox.Size = new System.Drawing.Size(164, 21);
            this.tuseridTextBox.TabIndex = 0;
            // 
            // tusernameTextBox
            // 
            this.tusernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tusernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tusername", true));
            this.tusernameTextBox.Location = new System.Drawing.Point(136, 148);
            this.tusernameTextBox.Name = "tusernameTextBox";
            this.tusernameTextBox.Size = new System.Drawing.Size(164, 21);
            this.tusernameTextBox.TabIndex = 1;
            // 
            // tsexTextBox
            // 
            this.tsexTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tsex", true));
            this.tsexTextBox.Location = new System.Drawing.Point(136, 175);
            this.tsexTextBox.Name = "tsexTextBox";
            this.tsexTextBox.Size = new System.Drawing.Size(164, 21);
            this.tsexTextBox.TabIndex = 2;
            // 
            // tphoneTextBox
            // 
            this.tphoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tphone", true));
            this.tphoneTextBox.Location = new System.Drawing.Point(136, 202);
            this.tphoneTextBox.Name = "tphoneTextBox";
            this.tphoneTextBox.Size = new System.Drawing.Size(164, 21);
            this.tphoneTextBox.TabIndex = 3;
            // 
            // temailTextBox
            // 
            this.temailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Temail", true));
            this.temailTextBox.Location = new System.Drawing.Point(136, 229);
            this.temailTextBox.Name = "temailTextBox";
            this.temailTextBox.Size = new System.Drawing.Size(164, 21);
            this.temailTextBox.TabIndex = 4;
            // 
            // tacademicTextBox
            // 
            this.tacademicTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tacademicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tacademic", true));
            this.tacademicTextBox.Location = new System.Drawing.Point(136, 256);
            this.tacademicTextBox.Name = "tacademicTextBox";
            this.tacademicTextBox.Size = new System.Drawing.Size(164, 21);
            this.tacademicTextBox.TabIndex = 5;
            // 
            // theaderTextBox
            // 
            this.theaderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.theaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Theader", true));
            this.theaderTextBox.Location = new System.Drawing.Point(136, 283);
            this.theaderTextBox.Name = "theaderTextBox";
            this.theaderTextBox.Size = new System.Drawing.Size(164, 21);
            this.theaderTextBox.TabIndex = 6;
            // 
            // tintroTextBox
            // 
            this.tintroTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tintroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tintro", true));
            this.tintroTextBox.Location = new System.Drawing.Point(136, 342);
            this.tintroTextBox.Multiline = true;
            this.tintroTextBox.Name = "tintroTextBox";
            this.tintroTextBox.Size = new System.Drawing.Size(324, 95);
            this.tintroTextBox.TabIndex = 8;
            // 
            // tbirthdayDateTimePicker
            // 
            this.tbirthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbirthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.selectTeacherBindingSource, "Tbirthday", true));
            this.tbirthdayDateTimePicker.Location = new System.Drawing.Point(136, 315);
            this.tbirthdayDateTimePicker.Name = "tbirthdayDateTimePicker";
            this.tbirthdayDateTimePicker.Size = new System.Drawing.Size(164, 21);
            this.tbirthdayDateTimePicker.TabIndex = 7;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(190, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 33);
            this.labelTitle.TabIndex = 49;
            this.labelTitle.Text = "个人信息";
            // 
            // TPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(529, 513);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tuseridTextBox);
            this.Controls.Add(this.tusernameTextBox);
            this.Controls.Add(this.tsexTextBox);
            this.Controls.Add(this.tphoneTextBox);
            this.Controls.Add(this.temailTextBox);
            this.Controls.Add(this.tacademicTextBox);
            this.Controls.Add(this.theaderTextBox);
            this.Controls.Add(this.tintroTextBox);
            this.Controls.Add(this.tbirthdayDateTimePicker);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(tuseridLabel);
            this.Controls.Add(tusernameLabel);
            this.Controls.Add(tsexLabel);
            this.Controls.Add(tphoneLabel);
            this.Controls.Add(temailLabel);
            this.Controls.Add(tacademicLabel);
            this.Controls.Add(theaderLabel);
            this.Controls.Add(tintroLabel);
            this.Controls.Add(tbirthdayLabel);
            this.Name = "TPersonInfo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tphotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTeacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdatePhoto;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Database.CourseMgrDataSet courseMgrDataSet;
        private System.Windows.Forms.BindingSource selectTeacherBindingSource;
        private Database.CourseMgrDataSetTableAdapters.SelectTeacherTableAdapter selectTeacherTableAdapter;
        private Database.CourseMgrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox tphotoPictureBox;
        private System.Windows.Forms.TextBox tuseridTextBox;
        private System.Windows.Forms.TextBox tusernameTextBox;
        private System.Windows.Forms.TextBox tsexTextBox;
        private System.Windows.Forms.TextBox tphoneTextBox;
        private System.Windows.Forms.TextBox temailTextBox;
        private System.Windows.Forms.TextBox tacademicTextBox;
        private System.Windows.Forms.TextBox theaderTextBox;
        private System.Windows.Forms.TextBox tintroTextBox;
        private System.Windows.Forms.DateTimePicker tbirthdayDateTimePicker;
        private System.Windows.Forms.Label labelTitle;

    }
}
