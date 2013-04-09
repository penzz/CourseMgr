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
            this.courseMgrDataSet = new CourseManageSystem.Database.CourseMgrDataSet();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherInfoTableAdapter = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TeacherInfoTableAdapter();
            this.tableAdapterManager = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager();
            this.tuseridTextBox = new System.Windows.Forms.TextBox();
            this.tusernameTextBox = new System.Windows.Forms.TextBox();
            this.tsexTextBox = new System.Windows.Forms.TextBox();
            this.tphoneTextBox = new System.Windows.Forms.TextBox();
            this.temailTextBox = new System.Windows.Forms.TextBox();
            this.tacademicTextBox = new System.Windows.Forms.TextBox();
            this.theaderTextBox = new System.Windows.Forms.TextBox();
            this.tintroTextBox = new System.Windows.Forms.TextBox();
            this.tphotoPictureBox = new System.Windows.Forms.PictureBox();
            this.tbirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePhoto = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            tuseridLabel = new System.Windows.Forms.Label();
            tusernameLabel = new System.Windows.Forms.Label();
            tsexLabel = new System.Windows.Forms.Label();
            tphoneLabel = new System.Windows.Forms.Label();
            temailLabel = new System.Windows.Forms.Label();
            tacademicLabel = new System.Windows.Forms.Label();
            theaderLabel = new System.Windows.Forms.Label();
            tintroLabel = new System.Windows.Forms.Label();
            tbirthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tphotoPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tuseridLabel
            // 
            tuseridLabel.AutoSize = true;
            tuseridLabel.Location = new System.Drawing.Point(78, 32);
            tuseridLabel.Name = "tuseridLabel";
            tuseridLabel.Size = new System.Drawing.Size(53, 12);
            tuseridLabel.TabIndex = 1;
            tuseridLabel.Text = "用户名：";
            // 
            // tusernameLabel
            // 
            tusernameLabel.AutoSize = true;
            tusernameLabel.Location = new System.Drawing.Point(78, 59);
            tusernameLabel.Name = "tusernameLabel";
            tusernameLabel.Size = new System.Drawing.Size(53, 12);
            tusernameLabel.TabIndex = 3;
            tusernameLabel.Text = "姓  名：";
            // 
            // tsexLabel
            // 
            tsexLabel.AutoSize = true;
            tsexLabel.Location = new System.Drawing.Point(78, 86);
            tsexLabel.Name = "tsexLabel";
            tsexLabel.Size = new System.Drawing.Size(53, 12);
            tsexLabel.TabIndex = 5;
            tsexLabel.Text = "性  别：";
            // 
            // tphoneLabel
            // 
            tphoneLabel.AutoSize = true;
            tphoneLabel.Location = new System.Drawing.Point(78, 113);
            tphoneLabel.Name = "tphoneLabel";
            tphoneLabel.Size = new System.Drawing.Size(53, 12);
            tphoneLabel.TabIndex = 7;
            tphoneLabel.Text = "电  话：";
            // 
            // temailLabel
            // 
            temailLabel.AutoSize = true;
            temailLabel.Location = new System.Drawing.Point(78, 140);
            temailLabel.Name = "temailLabel";
            temailLabel.Size = new System.Drawing.Size(53, 12);
            temailLabel.TabIndex = 9;
            temailLabel.Text = "邮  箱：";
            // 
            // tacademicLabel
            // 
            tacademicLabel.AutoSize = true;
            tacademicLabel.Location = new System.Drawing.Point(78, 167);
            tacademicLabel.Name = "tacademicLabel";
            tacademicLabel.Size = new System.Drawing.Size(53, 12);
            tacademicLabel.TabIndex = 11;
            tacademicLabel.Text = "学  院：";
            // 
            // theaderLabel
            // 
            theaderLabel.AutoSize = true;
            theaderLabel.Location = new System.Drawing.Point(78, 194);
            theaderLabel.Name = "theaderLabel";
            theaderLabel.Size = new System.Drawing.Size(53, 12);
            theaderLabel.TabIndex = 13;
            theaderLabel.Text = "职  称：";
            // 
            // tintroLabel
            // 
            tintroLabel.AutoSize = true;
            tintroLabel.Location = new System.Drawing.Point(78, 253);
            tintroLabel.Name = "tintroLabel";
            tintroLabel.Size = new System.Drawing.Size(53, 12);
            tintroLabel.TabIndex = 15;
            tintroLabel.Text = "简  介：";
            // 
            // tbirthdayLabel
            // 
            tbirthdayLabel.AutoSize = true;
            tbirthdayLabel.Location = new System.Drawing.Point(78, 223);
            tbirthdayLabel.Name = "tbirthdayLabel";
            tbirthdayLabel.Size = new System.Drawing.Size(65, 12);
            tbirthdayLabel.TabIndex = 19;
            tbirthdayLabel.Text = "出生日期：";
            // 
            // courseMgrDataSet
            // 
            this.courseMgrDataSet.DataSetName = "CourseMgrDataSet";
            this.courseMgrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherInfoBindingSource
            // 
            this.teacherInfoBindingSource.DataMember = "TeacherInfo";
            this.teacherInfoBindingSource.DataSource = this.courseMgrDataSet;
            // 
            // teacherInfoTableAdapter
            // 
            this.teacherInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.TeacherInfoTableAdapter = this.teacherInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tuseridTextBox
            // 
            this.tuseridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Tuserid", true));
            this.tuseridTextBox.Location = new System.Drawing.Point(146, 29);
            this.tuseridTextBox.Name = "tuseridTextBox";
            this.tuseridTextBox.ReadOnly = true;
            this.tuseridTextBox.Size = new System.Drawing.Size(138, 21);
            this.tuseridTextBox.TabIndex = 2;
            // 
            // tusernameTextBox
            // 
            this.tusernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Tusername", true));
            this.tusernameTextBox.Location = new System.Drawing.Point(146, 56);
            this.tusernameTextBox.Name = "tusernameTextBox";
            this.tusernameTextBox.Size = new System.Drawing.Size(138, 21);
            this.tusernameTextBox.TabIndex = 4;
            // 
            // tsexTextBox
            // 
            this.tsexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Tsex", true));
            this.tsexTextBox.Location = new System.Drawing.Point(146, 83);
            this.tsexTextBox.Name = "tsexTextBox";
            this.tsexTextBox.Size = new System.Drawing.Size(138, 21);
            this.tsexTextBox.TabIndex = 6;
            // 
            // tphoneTextBox
            // 
            this.tphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Tphone", true));
            this.tphoneTextBox.Location = new System.Drawing.Point(146, 110);
            this.tphoneTextBox.Name = "tphoneTextBox";
            this.tphoneTextBox.Size = new System.Drawing.Size(138, 21);
            this.tphoneTextBox.TabIndex = 8;
            // 
            // temailTextBox
            // 
            this.temailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Temail", true));
            this.temailTextBox.Location = new System.Drawing.Point(146, 137);
            this.temailTextBox.Name = "temailTextBox";
            this.temailTextBox.Size = new System.Drawing.Size(138, 21);
            this.temailTextBox.TabIndex = 10;
            // 
            // tacademicTextBox
            // 
            this.tacademicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Tacademic", true));
            this.tacademicTextBox.Location = new System.Drawing.Point(146, 164);
            this.tacademicTextBox.Name = "tacademicTextBox";
            this.tacademicTextBox.Size = new System.Drawing.Size(138, 21);
            this.tacademicTextBox.TabIndex = 12;
            // 
            // theaderTextBox
            // 
            this.theaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Theader", true));
            this.theaderTextBox.Location = new System.Drawing.Point(146, 191);
            this.theaderTextBox.Name = "theaderTextBox";
            this.theaderTextBox.Size = new System.Drawing.Size(138, 21);
            this.theaderTextBox.TabIndex = 14;
            // 
            // tintroTextBox
            // 
            this.tintroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherInfoBindingSource, "Tintro", true));
            this.tintroTextBox.Location = new System.Drawing.Point(146, 250);
            this.tintroTextBox.Multiline = true;
            this.tintroTextBox.Name = "tintroTextBox";
            this.tintroTextBox.Size = new System.Drawing.Size(314, 91);
            this.tintroTextBox.TabIndex = 16;
            // 
            // tphotoPictureBox
            // 
            this.tphotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.teacherInfoBindingSource, "Tphoto", true));
            this.tphotoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.tphotoPictureBox.Location = new System.Drawing.Point(10, 24);
            this.tphotoPictureBox.Name = "tphotoPictureBox";
            this.tphotoPictureBox.Size = new System.Drawing.Size(129, 145);
            this.tphotoPictureBox.TabIndex = 18;
            this.tphotoPictureBox.TabStop = false;
            // 
            // tbirthdayDateTimePicker
            // 
            this.tbirthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teacherInfoBindingSource, "Tbirthday", true));
            this.tbirthdayDateTimePicker.Location = new System.Drawing.Point(146, 219);
            this.tbirthdayDateTimePicker.Name = "tbirthdayDateTimePicker";
            this.tbirthdayDateTimePicker.Size = new System.Drawing.Size(138, 21);
            this.tbirthdayDateTimePicker.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdatePhoto);
            this.groupBox1.Controls.Add(this.tphotoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(321, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(149, 211);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "照片";
            // 
            // btnUpdatePhoto
            // 
            this.btnUpdatePhoto.Location = new System.Drawing.Point(38, 178);
            this.btnUpdatePhoto.Name = "btnUpdatePhoto";
            this.btnUpdatePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePhoto.TabIndex = 22;
            this.btnUpdatePhoto.Text = "更改";
            this.btnUpdatePhoto.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(146, 351);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 22;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            // 
            // TPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(548, 402);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(tuseridLabel);
            this.Controls.Add(this.tuseridTextBox);
            this.Controls.Add(tusernameLabel);
            this.Controls.Add(this.tusernameTextBox);
            this.Controls.Add(tsexLabel);
            this.Controls.Add(this.tsexTextBox);
            this.Controls.Add(tphoneLabel);
            this.Controls.Add(this.tphoneTextBox);
            this.Controls.Add(temailLabel);
            this.Controls.Add(this.temailTextBox);
            this.Controls.Add(tacademicLabel);
            this.Controls.Add(this.tacademicTextBox);
            this.Controls.Add(theaderLabel);
            this.Controls.Add(this.theaderTextBox);
            this.Controls.Add(tintroLabel);
            this.Controls.Add(this.tintroTextBox);
            this.Controls.Add(tbirthdayLabel);
            this.Controls.Add(this.tbirthdayDateTimePicker);
            this.Name = "TPersonInfo";
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tphotoPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database.CourseMgrDataSet courseMgrDataSet;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private Database.CourseMgrDataSetTableAdapters.TeacherInfoTableAdapter teacherInfoTableAdapter;
        private Database.CourseMgrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tuseridTextBox;
        private System.Windows.Forms.TextBox tusernameTextBox;
        private System.Windows.Forms.TextBox tsexTextBox;
        private System.Windows.Forms.TextBox tphoneTextBox;
        private System.Windows.Forms.TextBox temailTextBox;
        private System.Windows.Forms.TextBox tacademicTextBox;
        private System.Windows.Forms.TextBox theaderTextBox;
        private System.Windows.Forms.TextBox tintroTextBox;
        private System.Windows.Forms.PictureBox tphotoPictureBox;
        private System.Windows.Forms.DateTimePicker tbirthdayDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdatePhoto;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}
