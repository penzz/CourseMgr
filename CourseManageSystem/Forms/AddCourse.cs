using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Common;
using CourseManageSystem.Database;

namespace CourseManageSystem.Forms
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
            this.Load += new EventHandler(AddCourse_Load);
        }

        void AddCourse_Load(object sender, EventArgs e)
        {
            this.tbCteacher.Text = User.userid;
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                TextBox tb = null;
                if (item is TextBox)
                {
                    tb = item as TextBox;
                    if (string.IsNullOrEmpty(tb.Text.Trim()))
                    {
                        ShowMessage(tb.Tag + "不能为空");
                        return;
                    }
                }
            }
            int credit = 0;
            bool b = Int32.TryParse(this.tbCcredit.Text.Trim(), out credit);
            if (!b)
            {
                ShowMessage("学分只能为数字，请重新输入！");
                return;
            }
            CourseMgrDataContext c = new CourseMgrDataContext();
            Course course = new Course();
            course.Cname = this.tbCname.Text.Trim();
            course.Cmajorname = this.tbCmajorname.Text.Trim();
            course.Cinfo = this.tbCinfo.Text.Trim();
            course.Cteacher = this.tbCteacher.Text.Trim();
            course.Ctime = this.tbCtime.Text.Trim();
            course.Ccredit = credit;
            c.Course.InsertOnSubmit(course);
            c.SubmitChanges();
            ShowMessage("添加新课程成功");
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 显示提示消息
        /// </summary>
        /// <param name="msg"></param>
        void ShowMessage(String msg)
        {
            MessageBox.Show(msg, "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
