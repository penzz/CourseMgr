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
    public partial class UpdatePwd : CourseManageSystem.Common.BasePanelForm
    {
        public UpdatePwd()
        {
            InitializeComponent();
            this.Load += new EventHandler(UpdatePwd_Load);
        }

        void UpdatePwd_Load(object sender, EventArgs e)
        {
            this.tbUserName.Text = User.userid;
            this.btnUpdate.Click += new EventHandler(btnUpdate_Click);
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldpwd = this.tbOldPwd.Text.Trim();
            string newpwd = this.tbNewPwd.Text.Trim();
            string repeatpwd = this.tbRepeatPwd.Text.Trim();
            //检查密码是否为空
            if (string.IsNullOrEmpty(oldpwd) || string.IsNullOrEmpty(newpwd) || string.IsNullOrEmpty(repeatpwd))
            {
                ShowMessage("密码不能为空！");
                clearTextBox();
                return;
            }
            if (!newpwd.Equals(repeatpwd))
            {
                ShowMessage("新密码输入不一致，请重新输入！");
                clearTextBox();
                return;
            }
            if (!CC.checkUser(User.userid, oldpwd, User.category))
            {
                ShowMessage("旧密码输入错误，请重新输入！");
                clearTextBox();
                return;
            }
            int b = DBAccess.queriesTableAdapter.UpdatePassword(User.userid, newpwd);
            if (b > 0)
                ShowMessage("密码修改成功");
            else
                ShowMessage("密码修改失败，请重试");

        }
        /// <summary>
        /// 清除密码框
        /// </summary>
        void clearTextBox()
        {
            this.tbRepeatPwd.Text = "";
            this.tbNewPwd.Text = "";
            this.tbOldPwd.Text = "";
        }
    }
}
