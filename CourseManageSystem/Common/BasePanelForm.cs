using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseManageSystem.Common
{
    public partial class BasePanelForm : Form
    {
        public BasePanelForm()
        {
            InitializeComponent();
            //if (String.IsNullOrEmpty(User.userid))
            //{
            //    MessageBox.Show("系统错误");
            //    Application.Exit();
            //    return;
            //}
        }
        /// <summary>
        /// 显示提示消息
        /// </summary>
        /// <param name="msg"></param>
        protected void ShowMessage(String msg)
        {
            MessageBox.Show(msg, "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
