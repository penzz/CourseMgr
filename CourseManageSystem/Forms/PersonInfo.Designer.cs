namespace CourseManageSystem.Forms
{
    partial class PersonInfo
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
            System.Windows.Forms.Label useridLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label politicsLabel;
            System.Windows.Forms.Label nationLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label academyLabel;
            System.Windows.Forms.Label majorLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label idcardLabel;
            System.Windows.Forms.Label gradeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePhoto = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.selectStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseMgrDataSet = new CourseManageSystem.Database.CourseMgrDataSet();
            this.btnCommit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.StudentInfoTableAdapter();
            this.tableAdapterManager = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager();
            this.selectStudentTableAdapter = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.SelectStudentTableAdapter();
            this.useridTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.politicsTextBox = new System.Windows.Forms.TextBox();
            this.nationTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.academyTextBox = new System.Windows.Forms.TextBox();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.idcardTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            useridLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            politicsLabel = new System.Windows.Forms.Label();
            nationLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            academyLabel = new System.Windows.Forms.Label();
            majorLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            idcardLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // useridLabel
            // 
            useridLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            useridLabel.AutoSize = true;
            useridLabel.Location = new System.Drawing.Point(69, 117);
            useridLabel.Name = "useridLabel";
            useridLabel.Size = new System.Drawing.Size(53, 12);
            useridLabel.TabIndex = 1;
            useridLabel.Text = "用户名：";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(69, 144);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(53, 12);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "姓  名：";
            // 
            // sexLabel
            // 
            sexLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(69, 171);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(53, 12);
            sexLabel.TabIndex = 5;
            sexLabel.Text = "性  别：";
            // 
            // politicsLabel
            // 
            politicsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            politicsLabel.AutoSize = true;
            politicsLabel.Location = new System.Drawing.Point(69, 198);
            politicsLabel.Name = "politicsLabel";
            politicsLabel.Size = new System.Drawing.Size(65, 12);
            politicsLabel.TabIndex = 7;
            politicsLabel.Text = "政治面貌：";
            // 
            // nationLabel
            // 
            nationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nationLabel.AutoSize = true;
            nationLabel.Location = new System.Drawing.Point(69, 225);
            nationLabel.Name = "nationLabel";
            nationLabel.Size = new System.Drawing.Size(53, 12);
            nationLabel.TabIndex = 9;
            nationLabel.Text = "民  族：";
            // 
            // birthdayLabel
            // 
            birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(69, 253);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(65, 12);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "出生日期：";
            // 
            // academyLabel
            // 
            academyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            academyLabel.AutoSize = true;
            academyLabel.Location = new System.Drawing.Point(69, 284);
            academyLabel.Name = "academyLabel";
            academyLabel.Size = new System.Drawing.Size(53, 12);
            academyLabel.TabIndex = 13;
            academyLabel.Text = "学  院：";
            // 
            // majorLabel
            // 
            majorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            majorLabel.AutoSize = true;
            majorLabel.Location = new System.Drawing.Point(69, 311);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new System.Drawing.Size(53, 12);
            majorLabel.TabIndex = 15;
            majorLabel.Text = "专  业：";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(69, 338);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(65, 12);
            phoneLabel.TabIndex = 17;
            phoneLabel.Text = "联系方式：";
            // 
            // idcardLabel
            // 
            idcardLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idcardLabel.AutoSize = true;
            idcardLabel.Location = new System.Drawing.Point(69, 392);
            idcardLabel.Name = "idcardLabel";
            idcardLabel.Size = new System.Drawing.Size(53, 12);
            idcardLabel.TabIndex = 19;
            idcardLabel.Text = "身份证：";
            // 
            // gradeLabel
            // 
            gradeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(69, 365);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(53, 12);
            gradeLabel.TabIndex = 21;
            gradeLabel.Text = "年  级：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnUpdatePhoto);
            this.groupBox1.Controls.Add(this.photoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(301, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(170, 263);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "照片";
            // 
            // btnUpdatePhoto
            // 
            this.btnUpdatePhoto.Location = new System.Drawing.Point(49, 224);
            this.btnUpdatePhoto.Name = "btnUpdatePhoto";
            this.btnUpdatePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePhoto.TabIndex = 0;
            this.btnUpdatePhoto.Text = "更换";
            this.btnUpdatePhoto.UseVisualStyleBackColor = true;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.selectStudentBindingSource, "photo", true));
            this.photoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.photoPictureBox.Location = new System.Drawing.Point(10, 24);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(150, 185);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 49;
            this.photoPictureBox.TabStop = false;
            // 
            // selectStudentBindingSource
            // 
            this.selectStudentBindingSource.DataMember = "SelectStudent";
            this.selectStudentBindingSource.DataSource = this.courseMgrDataSet;
            // 
            // courseMgrDataSet
            // 
            this.courseMgrDataSet.DataSetName = "CourseMgrDataSet";
            this.courseMgrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCommit.Location = new System.Drawing.Point(396, 387);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 12;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.SCTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = this.studentInfoTableAdapter;
            this.tableAdapterManager.TeacherInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // selectStudentTableAdapter
            // 
            this.selectStudentTableAdapter.ClearBeforeFill = true;
            // 
            // useridTextBox
            // 
            this.useridTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.useridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "userid", true));
            this.useridTextBox.Location = new System.Drawing.Point(128, 114);
            this.useridTextBox.Name = "useridTextBox";
            this.useridTextBox.ReadOnly = true;
            this.useridTextBox.Size = new System.Drawing.Size(167, 21);
            this.useridTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(128, 141);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(167, 21);
            this.usernameTextBox.TabIndex = 1;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(128, 168);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(167, 21);
            this.sexTextBox.TabIndex = 2;
            // 
            // politicsTextBox
            // 
            this.politicsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.politicsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "politics", true));
            this.politicsTextBox.Location = new System.Drawing.Point(128, 195);
            this.politicsTextBox.Name = "politicsTextBox";
            this.politicsTextBox.Size = new System.Drawing.Size(167, 21);
            this.politicsTextBox.TabIndex = 3;
            // 
            // nationTextBox
            // 
            this.nationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "nation", true));
            this.nationTextBox.Location = new System.Drawing.Point(128, 222);
            this.nationTextBox.Name = "nationTextBox";
            this.nationTextBox.Size = new System.Drawing.Size(167, 21);
            this.nationTextBox.TabIndex = 4;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.selectStudentBindingSource, "birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(128, 249);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(167, 21);
            this.birthdayDateTimePicker.TabIndex = 5;
            // 
            // academyTextBox
            // 
            this.academyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.academyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "academy", true));
            this.academyTextBox.Location = new System.Drawing.Point(128, 276);
            this.academyTextBox.Name = "academyTextBox";
            this.academyTextBox.ReadOnly = true;
            this.academyTextBox.Size = new System.Drawing.Size(167, 21);
            this.academyTextBox.TabIndex = 6;
            // 
            // majorTextBox
            // 
            this.majorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.majorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "major", true));
            this.majorTextBox.Location = new System.Drawing.Point(128, 303);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.ReadOnly = true;
            this.majorTextBox.Size = new System.Drawing.Size(167, 21);
            this.majorTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(128, 330);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(167, 21);
            this.phoneTextBox.TabIndex = 8;
            // 
            // idcardTextBox
            // 
            this.idcardTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idcardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "idcard", true));
            this.idcardTextBox.Location = new System.Drawing.Point(128, 389);
            this.idcardTextBox.Name = "idcardTextBox";
            this.idcardTextBox.Size = new System.Drawing.Size(262, 21);
            this.idcardTextBox.TabIndex = 10;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectStudentBindingSource, "grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(128, 362);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.ReadOnly = true;
            this.gradeTextBox.Size = new System.Drawing.Size(167, 21);
            this.gradeTextBox.TabIndex = 9;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(194, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 33);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "个人信息";
            // 
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(541, 451);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.useridTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.politicsTextBox);
            this.Controls.Add(this.nationTextBox);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.academyTextBox);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.idcardTextBox);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(useridLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(sexLabel);
            this.Controls.Add(politicsLabel);
            this.Controls.Add(nationLabel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(academyLabel);
            this.Controls.Add(majorLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(idcardLabel);
            this.Controls.Add(gradeLabel);
            this.Name = "PersonInfo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdatePhoto;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Database.CourseMgrDataSet courseMgrDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private Database.CourseMgrDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private Database.CourseMgrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource selectStudentBindingSource;
        private Database.CourseMgrDataSetTableAdapters.SelectStudentTableAdapter selectStudentTableAdapter;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox useridTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox politicsTextBox;
        private System.Windows.Forms.TextBox nationTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox academyTextBox;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox idcardTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label labelTitle;

    }
}
