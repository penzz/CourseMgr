using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Database;
using CourseManageSystem.Database.CourseMgrDataSetTableAdapters;
using CourseManageSystem.Common;
namespace CourseManageSystem
{
    /// <summary>
    /// 系统登录窗体
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Load += new EventHandler(Login_Load);
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Login_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tbUserName.Text = "0201300001";
            this.tbPassword.Text = "123";
            this.rbStudent.Checked = true;
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
            this.btnLogin.Click += new EventHandler(btnLogin_Click);
        }
        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnLogin_Click(object sender, EventArgs e)
        {
            //检查用户名是否为空
            if (tbUserName.Text.Trim() == "")
            {
                ShowMessage("用户名不能为空！");
                return;
            }
            //检查密码是否为空
            if (tbPassword.Text.Trim() == "")
            {
                ShowMessage("密码不能为空！");
                return;
            }
            //登录验证
            User.category = rbTeacher.Checked ? "1" : "0";
            User.userid = this.tbUserName.Text.Trim();
            User.password = this.tbPassword.Text.Trim();
            if (!CC.checkUser(User.userid, User.password, User.category))
            {
                ShowMessage("用户名或密码不正确，请重新输入！");
                return;
            }
            //登陆成功
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 退出按钮，系统关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
