using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseManageSystem.Forms
{
    public partial class CourseInfo : CourseManageSystem.Common.BasePanelForm
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseMgrDataSet);

        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“courseMgrDataSet.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.courseMgrDataSet.Course);

        }
    }
}
