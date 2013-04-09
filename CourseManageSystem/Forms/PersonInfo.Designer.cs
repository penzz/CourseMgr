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
            this.courseMgrDataSet = new CourseManageSystem.Database.CourseMgrDataSet();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.StudentInfoTableAdapter();
            this.tableAdapterManager = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager();
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
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePhoto = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // useridLabel
            // 
            useridLabel.AutoSize = true;
            useridLabel.Location = new System.Drawing.Point(73, 70);
            useridLabel.Name = "useridLabel";
            useridLabel.Size = new System.Drawing.Size(53, 12);
            useridLabel.TabIndex = 1;
            useridLabel.Text = "用户名：";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(73, 97);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(53, 12);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "姓  名：";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(73, 124);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(53, 12);
            sexLabel.TabIndex = 5;
            sexLabel.Text = "性  别：";
            // 
            // politicsLabel
            // 
            politicsLabel.AutoSize = true;
            politicsLabel.Location = new System.Drawing.Point(73, 151);
            politicsLabel.Name = "politicsLabel";
            politicsLabel.Size = new System.Drawing.Size(65, 12);
            politicsLabel.TabIndex = 7;
            politicsLabel.Text = "政治面貌：";
            // 
            // nationLabel
            // 
            nationLabel.AutoSize = true;
            nationLabel.Location = new System.Drawing.Point(73, 178);
            nationLabel.Name = "nationLabel";
            nationLabel.Size = new System.Drawing.Size(53, 12);
            nationLabel.TabIndex = 9;
            nationLabel.Text = "民  族：";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(73, 206);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(65, 12);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "出生日期：";
            // 
            // academyLabel
            // 
            academyLabel.AutoSize = true;
            academyLabel.Location = new System.Drawing.Point(73, 237);
            academyLabel.Name = "academyLabel";
            academyLabel.Size = new System.Drawing.Size(53, 12);
            academyLabel.TabIndex = 13;
            academyLabel.Text = "学  院：";
            // 
            // majorLabel
            // 
            majorLabel.AutoSize = true;
            majorLabel.Location = new System.Drawing.Point(73, 264);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new System.Drawing.Size(53, 12);
            majorLabel.TabIndex = 15;
            majorLabel.Text = "专  业：";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(73, 291);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(65, 12);
            phoneLabel.TabIndex = 17;
            phoneLabel.Text = "联系方式：";
            // 
            // idcardLabel
            // 
            idcardLabel.AutoSize = true;
            idcardLabel.Location = new System.Drawing.Point(73, 345);
            idcardLabel.Name = "idcardLabel";
            idcardLabel.Size = new System.Drawing.Size(53, 12);
            idcardLabel.TabIndex = 19;
            idcardLabel.Text = "身份证：";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(73, 318);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(53, 12);
            gradeLabel.TabIndex = 21;
            gradeLabel.Text = "年  级：";
            // 
            // courseMgrDataSet
            // 
            this.courseMgrDataSet.DataSetName = "CourseMgrDataSet";
            this.courseMgrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.courseMgrDataSet;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = this.studentInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // useridTextBox
            // 
            this.useridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "userid", true));
            this.useridTextBox.Location = new System.Drawing.Point(138, 67);
            this.useridTextBox.Name = "useridTextBox";
            this.useridTextBox.ReadOnly = true;
            this.useridTextBox.Size = new System.Drawing.Size(144, 21);
            this.useridTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(138, 94);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(144, 21);
            this.usernameTextBox.TabIndex = 4;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(138, 121);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(144, 21);
            this.sexTextBox.TabIndex = 6;
            // 
            // politicsTextBox
            // 
            this.politicsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "politics", true));
            this.politicsTextBox.Location = new System.Drawing.Point(138, 148);
            this.politicsTextBox.Name = "politicsTextBox";
            this.politicsTextBox.Size = new System.Drawing.Size(144, 21);
            this.politicsTextBox.TabIndex = 8;
            // 
            // nationTextBox
            // 
            this.nationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "nation", true));
            this.nationTextBox.Location = new System.Drawing.Point(138, 175);
            this.nationTextBox.Name = "nationTextBox";
            this.nationTextBox.Size = new System.Drawing.Size(144, 21);
            this.nationTextBox.TabIndex = 10;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentInfoBindingSource, "birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(138, 202);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(144, 21);
            this.birthdayDateTimePicker.TabIndex = 12;
            // 
            // academyTextBox
            // 
            this.academyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "academy", true));
            this.academyTextBox.Location = new System.Drawing.Point(138, 234);
            this.academyTextBox.Name = "academyTextBox";
            this.academyTextBox.ReadOnly = true;
            this.academyTextBox.Size = new System.Drawing.Size(144, 21);
            this.academyTextBox.TabIndex = 14;
            // 
            // majorTextBox
            // 
            this.majorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "major", true));
            this.majorTextBox.Location = new System.Drawing.Point(138, 261);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.ReadOnly = true;
            this.majorTextBox.Size = new System.Drawing.Size(144, 21);
            this.majorTextBox.TabIndex = 16;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(138, 288);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(144, 21);
            this.phoneTextBox.TabIndex = 18;
            // 
            // idcardTextBox
            // 
            this.idcardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "idcard", true));
            this.idcardTextBox.Location = new System.Drawing.Point(138, 342);
            this.idcardTextBox.Name = "idcardTextBox";
            this.idcardTextBox.Size = new System.Drawing.Size(246, 21);
            this.idcardTextBox.TabIndex = 20;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(138, 315);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.ReadOnly = true;
            this.gradeTextBox.Size = new System.Drawing.Size(144, 21);
            this.gradeTextBox.TabIndex = 22;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentInfoBindingSource, "photo", true));
            this.photoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.photoPictureBox.Location = new System.Drawing.Point(10, 24);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(150, 185);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 24;
            this.photoPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdatePhoto);
            this.groupBox1.Controls.Add(this.photoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(305, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(170, 263);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "照片";
            // 
            // btnUpdatePhoto
            // 
            this.btnUpdatePhoto.Location = new System.Drawing.Point(49, 224);
            this.btnUpdatePhoto.Name = "btnUpdatePhoto";
            this.btnUpdatePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePhoto.TabIndex = 25;
            this.btnUpdatePhoto.Text = "更换";
            this.btnUpdatePhoto.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(400, 340);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 25;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            // 
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(548, 430);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(useridLabel);
            this.Controls.Add(this.useridTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(politicsLabel);
            this.Controls.Add(this.politicsTextBox);
            this.Controls.Add(nationLabel);
            this.Controls.Add(this.nationTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(academyLabel);
            this.Controls.Add(this.academyTextBox);
            this.Controls.Add(majorLabel);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(idcardLabel);
            this.Controls.Add(this.idcardTextBox);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Name = "PersonInfo";
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database.CourseMgrDataSet courseMgrDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private Database.CourseMgrDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private Database.CourseMgrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdatePhoto;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}
