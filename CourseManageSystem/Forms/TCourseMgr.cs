using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Common;
using CourseManageSystem.Database;
using System.Linq;

namespace CourseManageSystem.Forms
{
    public partial class TCourseMgr : CourseManageSystem.Common.BasePanelForm
    {
        public TCourseMgr()
        {
            InitializeComponent();
            this.Load += new EventHandler(TCourseMgr_Load);
        }

        void TCourseMgr_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“courseMgrDataSet.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.courseMgrDataSet.Course);

            this.courseDataGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.courseDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            this.btnAddNewCourse.Click += new EventHandler(btnAddNewCourse_Click);
            this.btnDeleteCourse.Click += new EventHandler(btnDeleteCourse_Click);
        }

        void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count <= 0)
            {
                ShowMessage("请选择要删除的课程");
                return;
            }
            string cTeacher = this.courseDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            if (cTeacher != User.userid)
            {
                ShowMessage("无法删除不是自己的课程");
                return;
            }
            DialogResult dr = MessageBox.Show("确定删除选中的课程？", "提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                string scno = this.courseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                int cno = Int32.Parse(scno);
                CourseMgrDataContext c = new CourseMgrDataContext();
                var q = from t in c.Course where t.Cid == cno select t;
                if (q.Count()>0)
                {
                    var q1 = q.First();
                    c.Course.DeleteOnSubmit(q1);
                    c.SubmitChanges();
                    ShowMessage("删除成功");
                    this.courseTableAdapter.Fill(this.courseMgrDataSet.Course);
                    this.courseDataGridView.Refresh();
                }
            }
        }

        void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse();
            DialogResult dr = addCourse.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.courseTableAdapter.Fill(this.courseMgrDataSet.Course);
                this.courseDataGridView.Refresh();
            }
        }
    }
}
