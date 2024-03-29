﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Common;
using System.Reflection;

namespace CourseManageSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(StudentMain_Load);
            this.btnLogout.Click += new EventHandler(btnLogout_Click);
        }

        void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void StudentMain_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(User.userid))
            {
                MessageBox.Show("系统错误");
                Application.Exit();
                return;
            }
            this.labelUserId.Text = User.userid;
            panelLeft.Visible = User.category.Equals("0") ? true : false;
            panelTLeft.Visible = !panelLeft.Visible;
            foreach (Control ctrl in this.panelLeft.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Click += new EventHandler(btn_Click);
                }
            }
            foreach (Control ctrl in this.panelTLeft.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Click += new EventHandler(btn_Click);
                }
            }
        }
        /// <summary>
        /// 按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string btnName = btn.Name;
            Assembly assembly = Assembly.GetExecutingAssembly();
            Object obj = assembly.CreateInstance("CourseManageSystem.Forms." + btnName.Substring(3), true);
            Form form = obj as Form;
            ShowForm(btn.Text, form);
        }
        /// <summary>
        /// 切换要显示的窗体
        /// </summary>
        /// <param name="location"></param>
        /// <param name="form"></param>
        private void ShowForm(string location, Form form)
        {
            this.labelLocation.Text = location;
            this.panelCenter.Controls.Clear();
            if (form == null)
            {
                return;
            }
            form.TopLevel = false;
            this.panelCenter.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
