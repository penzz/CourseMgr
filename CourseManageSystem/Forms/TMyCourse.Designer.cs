namespace CourseManageSystem.Forms
{
    partial class TMyCourse
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
            System.Windows.Forms.Label fenshuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMyCourse));
            this.courseMgrDataSet = new CourseManageSystem.Database.CourseMgrDataSet();
            this.selectCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectCourseTableAdapter = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.SelectCourseTableAdapter();
            this.tableAdapterManager = new CourseManageSystem.Database.CourseMgrDataSetTableAdapters.TableAdapterManager();
            this.selectCourseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectCourseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.fenshuTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCno = new System.Windows.Forms.ComboBox();
            this.labelCname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            useridLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            fenshuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCourseBindingNavigator)).BeginInit();
            this.selectCourseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectCourseDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // useridLabel
            // 
            useridLabel.AutoSize = true;
            useridLabel.Location = new System.Drawing.Point(20, 53);
            useridLabel.Name = "useridLabel";
            useridLabel.Size = new System.Drawing.Size(41, 12);
            useridLabel.TabIndex = 3;
            useridLabel.Text = "学号：";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(20, 80);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(41, 12);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "姓名：";
            // 
            // fenshuLabel
            // 
            fenshuLabel.AutoSize = true;
            fenshuLabel.Location = new System.Drawing.Point(20, 113);
            fenshuLabel.Name = "fenshuLabel";
            fenshuLabel.Size = new System.Drawing.Size(41, 12);
            fenshuLabel.TabIndex = 17;
            fenshuLabel.Text = "分数：";
            // 
            // courseMgrDataSet
            // 
            this.courseMgrDataSet.DataSetName = "CourseMgrDataSet";
            this.courseMgrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectCourseBindingSource
            // 
            this.selectCourseBindingSource.DataMember = "SelectCourse";
            this.selectCourseBindingSource.DataSource = this.courseMgrDataSet;
            // 
            // selectCourseTableAdapter
            // 
            this.selectCourseTableAdapter.ClearBeforeFill = true;
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
            // selectCourseBindingNavigator
            // 
            this.selectCourseBindingNavigator.AddNewItem = null;
            this.selectCourseBindingNavigator.BindingSource = this.selectCourseBindingSource;
            this.selectCourseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.selectCourseBindingNavigator.DeleteItem = null;
            this.selectCourseBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectCourseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.selectCourseBindingNavigator.Location = new System.Drawing.Point(7, 283);
            this.selectCourseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.selectCourseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.selectCourseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.selectCourseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.selectCourseBindingNavigator.Name = "selectCourseBindingNavigator";
            this.selectCourseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.selectCourseBindingNavigator.Size = new System.Drawing.Size(606, 25);
            this.selectCourseBindingNavigator.TabIndex = 0;
            this.selectCourseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // selectCourseDataGridView
            // 
            this.selectCourseDataGridView.AllowUserToAddRows = false;
            this.selectCourseDataGridView.AllowUserToDeleteRows = false;
            this.selectCourseDataGridView.AutoGenerateColumns = false;
            this.selectCourseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectCourseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.selectCourseDataGridView.DataSource = this.selectCourseBindingSource;
            this.selectCourseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectCourseDataGridView.Location = new System.Drawing.Point(7, 21);
            this.selectCourseDataGridView.Name = "selectCourseDataGridView";
            this.selectCourseDataGridView.ReadOnly = true;
            this.selectCourseDataGridView.RowTemplate.Height = 23;
            this.selectCourseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectCourseDataGridView.Size = new System.Drawing.Size(606, 262);
            this.selectCourseDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userid";
            this.dataGridViewTextBoxColumn1.HeaderText = "学号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn3.HeaderText = "性别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "academy";
            this.dataGridViewTextBoxColumn4.HeaderText = "学院";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "major";
            this.dataGridViewTextBoxColumn5.HeaderText = "专业";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn6.HeaderText = "年级";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ctime";
            this.dataGridViewTextBoxColumn7.HeaderText = "选课时间";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fenshu";
            this.dataGridViewTextBoxColumn8.HeaderText = "分数";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // useridTextBox
            // 
            this.useridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectCourseBindingSource, "userid", true));
            this.useridTextBox.Location = new System.Drawing.Point(60, 50);
            this.useridTextBox.Name = "useridTextBox";
            this.useridTextBox.ReadOnly = true;
            this.useridTextBox.Size = new System.Drawing.Size(200, 21);
            this.useridTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectCourseBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(60, 77);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(200, 21);
            this.usernameTextBox.TabIndex = 6;
            // 
            // fenshuTextBox
            // 
            this.fenshuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectCourseBindingSource, "fenshu", true));
            this.fenshuTextBox.Location = new System.Drawing.Point(60, 110);
            this.fenshuTextBox.Name = "fenshuTextBox";
            this.fenshuTextBox.Size = new System.Drawing.Size(200, 21);
            this.fenshuTextBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCno);
            this.groupBox1.Controls.Add(this.labelCname);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 74);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择课程";
            // 
            // cbCno
            // 
            this.cbCno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCno.FormattingEnabled = true;
            this.cbCno.Location = new System.Drawing.Point(20, 30);
            this.cbCno.Name = "cbCno";
            this.cbCno.Size = new System.Drawing.Size(84, 20);
            this.cbCno.TabIndex = 1;
            // 
            // labelCname
            // 
            this.labelCname.AutoSize = true;
            this.labelCname.ForeColor = System.Drawing.Color.Red;
            this.labelCname.Location = new System.Drawing.Point(110, 33);
            this.labelCname.Name = "labelCname";
            this.labelCname.Size = new System.Drawing.Size(41, 12);
            this.labelCname.TabIndex = 0;
            this.labelCname.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectCourseDataGridView);
            this.groupBox2.Controls.Add(this.selectCourseBindingNavigator);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox2.Size = new System.Drawing.Size(620, 315);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选课学生信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Controls.Add(useridLabel);
            this.groupBox3.Controls.Add(this.fenshuTextBox);
            this.groupBox3.Controls.Add(fenshuLabel);
            this.groupBox3.Controls.Add(this.usernameTextBox);
            this.groupBox3.Controls.Add(this.useridTextBox);
            this.groupBox3.Controls.Add(usernameLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(10, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 168);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "成绩";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(306, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // TMyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(640, 577);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "TMyCourse";
            this.Padding = new System.Windows.Forms.Padding(10);
            ((System.ComponentModel.ISupportInitialize)(this.courseMgrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectCourseBindingNavigator)).EndInit();
            this.selectCourseBindingNavigator.ResumeLayout(false);
            this.selectCourseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectCourseDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Database.CourseMgrDataSet courseMgrDataSet;
        private System.Windows.Forms.BindingSource selectCourseBindingSource;
        private Database.CourseMgrDataSetTableAdapters.SelectCourseTableAdapter selectCourseTableAdapter;
        private Database.CourseMgrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator selectCourseBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView selectCourseDataGridView;
        private System.Windows.Forms.TextBox useridTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox fenshuTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCno;
        private System.Windows.Forms.Label labelCname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnOK;
    }
}
