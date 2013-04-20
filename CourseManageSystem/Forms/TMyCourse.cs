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
    public partial class TMyCourse : CourseManageSystem.Common.BasePanelForm
    {
        int cno;
        public TMyCourse()
        {
            InitializeComponent();
            this.Load += new EventHandler(TMyCourse_Load);
            this.btnOK.Click += new EventHandler(btnOK_Click);
            this.cbCno.SelectedIndexChanged += new EventHandler(cbCno_SelectedIndexChanged);
        }

        void cbCno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cno = Int32.Parse(this.cbCno.SelectedItem.ToString());
            CourseMgrDataContext c = new CourseMgrDataContext();
            var q = from t in c.Course where t.Cid == cno select t;
            this.labelCname.Text = q.First().Cname;
            try
            {
                this.selectCourseTableAdapter.Fill(this.courseMgrDataSet.SelectCourse, User.userid, cno);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            int grade = 0;
            bool b = Int32.TryParse(this.fenshuTextBox.Text.Trim(), out grade);
            if (!b)
            {
                ShowMessage("分数只能为数字，请重新输入！");
                return;
            }

            CourseMgrDataContext c = new CourseMgrDataContext();
            var q = from t in c.SC where t.Cno == cno where t.Sno == this.useridTextBox.Text select t;
            if (q.Count() > 0)
            {
                var q1 = q.First();
                q1.Grade = grade;
                c.SubmitChanges();
                ShowMessage("登记分数成功");
                this.selectCourseTableAdapter.Fill(this.courseMgrDataSet.SelectCourse, User.userid, cno);
                this.selectCourseDataGridView.Refresh();
            }
        }

        void TMyCourse_Load(object sender, EventArgs e)
        {
            CourseMgrDataContext c = new CourseMgrDataContext();
            var q = from t in c.Course where t.Cteacher == User.userid select t;
            foreach (var item in q)
            {
                this.cbCno.Items.Add(item.Cid);
            }
            this.cbCno.SelectedIndex = 0;
        }
    }
}
