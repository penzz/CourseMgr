namespace CourseManageSystem.Forms
{
    partial class ShowTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTeacher));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tphotoPictureBox = new System.Windows.Forms.PictureBox();
            this.selectTeacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseMgrDataSet = new CourseManageSystem.Database.CourseMgrDataSet();
            this.selectTeacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.selectTeacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTeacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tuseridLabel
            // 
            tuseridLabel.AutoSize = true;
            tuseridLabel.Location = new System.Drawing.Point(12, 9);
            tuseridLabel.Name = "tuseridLabel";
            tuseridLabel.Size = new System.Drawing.Size(53, 12);
            tuseridLabel.TabIndex = 1;
            tuseridLabel.Text = "职工号：";
            // 
            // tusernameLabel
            // 
            tusernameLabel.AutoSize = true;
            tusernameLabel.Location = new System.Drawing.Point(12, 36);
            tusernameLabel.Name = "tusernameLabel";
            tusernameLabel.Size = new System.Drawing.Size(53, 12);
            tusernameLabel.TabIndex = 3;
            tusernameLabel.Text = "姓  名：";
            // 
            // tsexLabel
            // 
            tsexLabel.AutoSize = true;
            tsexLabel.Location = new System.Drawing.Point(12, 63);
            tsexLabel.Name = "tsexLabel";
            tsexLabel.Size = new System.Drawing.Size(53, 12);
            tsexLabel.TabIndex = 5;
            tsexLabel.Text = "性  别：";
            // 
            // tphoneLabel
            // 
            tphoneLabel.AutoSize = true;
            tphoneLabel.Location = new System.Drawing.Point(12, 90);
            tphoneLabel.Name = "tphoneLabel";
            tphoneLabel.Size = new System.Drawing.Size(53, 12);
            tphoneLabel.TabIndex = 7;
            tphoneLabel.Text = "电  话：";
            // 
            // temailLabel
            // 
            temailLabel.AutoSize = true;
            temailLabel.Location = new System.Drawing.Point(12, 117);
            temailLabel.Name = "temailLabel";
            temailLabel.Size = new System.Drawing.Size(53, 12);
            temailLabel.TabIndex = 9;
            temailLabel.Text = "邮  箱：";
            // 
            // tacademicLabel
            // 
            tacademicLabel.AutoSize = true;
            tacademicLabel.Location = new System.Drawing.Point(12, 144);
            tacademicLabel.Name = "tacademicLabel";
            tacademicLabel.Size = new System.Drawing.Size(53, 12);
            tacademicLabel.TabIndex = 11;
            tacademicLabel.Text = "学  院：";
            // 
            // theaderLabel
            // 
            theaderLabel.AutoSize = true;
            theaderLabel.Location = new System.Drawing.Point(12, 171);
            theaderLabel.Name = "theaderLabel";
            theaderLabel.Size = new System.Drawing.Size(53, 12);
            theaderLabel.TabIndex = 13;
            theaderLabel.Text = "职  称：";
            // 
            // tintroLabel
            // 
            tintroLabel.AutoSize = true;
            tintroLabel.Location = new System.Drawing.Point(12, 231);
            tintroLabel.Name = "tintroLabel";
            tintroLabel.Size = new System.Drawing.Size(53, 12);
            tintroLabel.TabIndex = 15;
            tintroLabel.Text = "简  介：";
            // 
            // tbirthdayLabel
            // 
            tbirthdayLabel.AutoSize = true;
            tbirthdayLabel.Location = new System.Drawing.Point(12, 201);
            tbirthdayLabel.Name = "tbirthdayLabel";
            tbirthdayLabel.Size = new System.Drawing.Size(65, 12);
            tbirthdayLabel.TabIndex = 19;
            tbirthdayLabel.Text = "出生年月：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tphotoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(241, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(155, 210);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "照片";
            // 
            // tphotoPictureBox
            // 
            this.tphotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tphotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.selectTeacherBindingSource1, "Tphoto", true));
            this.tphotoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tphotoPictureBox.Location = new System.Drawing.Point(10, 24);
            this.tphotoPictureBox.Name = "tphotoPictureBox";
            this.tphotoPictureBox.Size = new System.Drawing.Size(135, 176);
            this.tphotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tphotoPictureBox.TabIndex = 42;
            this.tphotoPictureBox.TabStop = false;
            // 
            // selectTeacherBindingSource1
            // 
            this.selectTeacherBindingSource1.DataMember = "SelectTeacher";
            this.selectTeacherBindingSource1.DataSource = this.courseMgrDataSet;
            // 
            // courseMgrDataSet
            // 
            this.courseMgrDataSet.DataSetName = "CourseMgrDataSet";
            this.courseMgrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectTeacherBindingSource
            // 
            this.selectTeacherBindingSource.DataMember = "SelectTeacher";
            this.selectTeacherBindingSource.DataSource = this.courseMgrDataSet;
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
            this.tuseridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tuserid", true));
            this.tuseridTextBox.Location = new System.Drawing.Point(71, 6);
            this.tuseridTextBox.Name = "tuseridTextBox";
            this.tuseridTextBox.ReadOnly = true;
            this.tuseridTextBox.Size = new System.Drawing.Size(164, 21);
            this.tuseridTextBox.TabIndex = 0;
            // 
            // tusernameTextBox
            // 
            this.tusernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tusername", true));
            this.tusernameTextBox.Location = new System.Drawing.Point(71, 33);
            this.tusernameTextBox.Name = "tusernameTextBox";
            this.tusernameTextBox.ReadOnly = true;
            this.tusernameTextBox.Size = new System.Drawing.Size(164, 21);
            this.tusernameTextBox.TabIndex = 1;
            // 
            // tsexTextBox
            // 
            this.tsexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tsex", true));
            this.tsexTextBox.Location = new System.Drawing.Point(71, 60);
            this.tsexTextBox.Name = "tsexTextBox";
            this.tsexTextBox.ReadOnly = true;
            this.tsexTextBox.Size = new System.Drawing.Size(164, 21);
            this.tsexTextBox.TabIndex = 2;
            // 
            // tphoneTextBox
            // 
            this.tphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tphone", true));
            this.tphoneTextBox.Location = new System.Drawing.Point(71, 87);
            this.tphoneTextBox.Name = "tphoneTextBox";
            this.tphoneTextBox.ReadOnly = true;
            this.tphoneTextBox.Size = new System.Drawing.Size(164, 21);
            this.tphoneTextBox.TabIndex = 3;
            // 
            // temailTextBox
            // 
            this.temailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Temail", true));
            this.temailTextBox.Location = new System.Drawing.Point(71, 114);
            this.temailTextBox.Name = "temailTextBox";
            this.temailTextBox.ReadOnly = true;
            this.temailTextBox.Size = new System.Drawing.Size(164, 21);
            this.temailTextBox.TabIndex = 4;
            // 
            // tacademicTextBox
            // 
            this.tacademicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tacademic", true));
            this.tacademicTextBox.Location = new System.Drawing.Point(71, 141);
            this.tacademicTextBox.Name = "tacademicTextBox";
            this.tacademicTextBox.ReadOnly = true;
            this.tacademicTextBox.Size = new System.Drawing.Size(164, 21);
            this.tacademicTextBox.TabIndex = 5;
            // 
            // theaderTextBox
            // 
            this.theaderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Theader", true));
            this.theaderTextBox.Location = new System.Drawing.Point(71, 168);
            this.theaderTextBox.Name = "theaderTextBox";
            this.theaderTextBox.ReadOnly = true;
            this.theaderTextBox.Size = new System.Drawing.Size(164, 21);
            this.theaderTextBox.TabIndex = 6;
            // 
            // tintroTextBox
            // 
            this.tintroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectTeacherBindingSource, "Tintro", true));
            this.tintroTextBox.Location = new System.Drawing.Point(71, 228);
            this.tintroTextBox.Multiline = true;
            this.tintroTextBox.Name = "tintroTextBox";
            this.tintroTextBox.ReadOnly = true;
            this.tintroTextBox.Size = new System.Drawing.Size(325, 120);
            this.tintroTextBox.TabIndex = 8;
            // 
            // tbirthdayDateTimePicker
            // 
            this.tbirthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.selectTeacherBindingSource, "Tbirthday", true));
            this.tbirthdayDateTimePicker.Enabled = false;
            this.tbirthdayDateTimePicker.Location = new System.Drawing.Point(83, 197);
            this.tbirthdayDateTimePicker.Name = "tbirthdayDateTimePicker";
            this.tbirthdayDateTimePicker.Size = new System.Drawing.Size(152, 21);
            this.tbirthdayDateTimePicker.TabIndex = 7;
            // 
            // ShowTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 360);
            this.Controls.Add(this.tuseridTextBox);
            this.Controls.Add(this.tusernameTextBox);
            this.Controls.Add(this.tsexTextBox);
            this.Controls.Add(this.tphoneTextBox);
            this.Controls.Add(this.temailTextBox);
            this.Controls.Add(this.tacademicTextBox);
            this.Controls.Add(this.theaderTextBox);
            this.Controls.Add(this.tintroTextBox);
            this.Controls.Add(this.tbirthdayDateTimePicker);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowTeacher";
            this.Text = "教师详细信息";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tphotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTeacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTeacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Database.CourseMgrDataSet courseMgrDataSet;
        private System.Windows.Forms.BindingSource selectTeacherBindingSource;
        private Database.CourseMgrDataSetTableAdapters.SelectTeacherTableAdapter selectTeacherTableAdapter;
        private Database.CourseMgrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tuseridTextBox;
        private System.Windows.Forms.TextBox tusernameTextBox;
        private System.Windows.Forms.TextBox tsexTextBox;
        private System.Windows.Forms.TextBox tphoneTextBox;
        private System.Windows.Forms.TextBox temailTextBox;
        private System.Windows.Forms.TextBox tacademicTextBox;
        private System.Windows.Forms.TextBox theaderTextBox;
        private System.Windows.Forms.TextBox tintroTextBox;
        private System.Windows.Forms.DateTimePicker tbirthdayDateTimePicker;
        private System.Windows.Forms.BindingSource selectTeacherBindingSource1;
        private System.Windows.Forms.PictureBox tphotoPictureBox;
    }
}