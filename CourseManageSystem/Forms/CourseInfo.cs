using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Common;
using CourseManageSystem.Database;

namespace CourseManageSystem.Forms
{
    public partial class CourseInfo : CourseManageSystem.Common.BasePanelForm
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“courseMgrDataSet.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.courseMgrDataSet.Course);

            this.courseDataGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.courseDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            this.btnAddMyCourse.Click += new EventHandler(btnAddMyCourse_Click);
            this.btnTeacherInfo.Click += new EventHandler(btnTeacherInfo_Click);
        }

        void btnTeacherInfo_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count <= 0)
            {
                ShowMessage("请选择要查看老师信息的课程");
                return;
            }
            string tid = this.courseDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            ShowTeacher st = new ShowTeacher(tid);
            st.ShowDialog();
        }

        void btnAddMyCourse_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count <= 0)
            {
                ShowMessage("请选择要添加的课程");
                return;
            }
            DialogResult dr = MessageBox.Show("确定将选中的课程加入我的课程？", "提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr != DialogResult.OK)
                return;
            string cno = this.courseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            if (!IsCourseExist(User.userid, Int32.Parse(cno)))
            {
                ShowMessage("您已经选择过该课程，不能重复选择！");
                return;
            }
            try
            {
                DBAccess.queriesTableAdapter.AddMyCourse(User.userid, Int32.Parse(cno));
                ShowMessage("加入课程成功");
            }
            catch (Exception ex)
            {
                ShowMessage("加入课程失败：" + ex.Message);
            }

        }
        bool IsCourseExist(string sno, int cno)
        {
            DBAccess.scAdapter.Fill(DBAccess.CMDataSet.SC);
            foreach (var item in DBAccess.CMDataSet.SC)
            {
                if (item.Cno.Equals(cno) && item.Sno.Equals(sno))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
