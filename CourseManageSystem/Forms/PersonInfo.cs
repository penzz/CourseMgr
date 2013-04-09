﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Common;

namespace CourseManageSystem.Forms
{
    public partial class PersonInfo : CourseManageSystem.Common.BasePanelForm
    {
        public PersonInfo()
        {
            InitializeComponent();
            this.Load += new EventHandler(PersonInfo_Load);
        }

        void PersonInfo_Load(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.Fill(this.courseMgrDataSet.StudentInfo);
            this.btnCommit.Click += new EventHandler(btnCommit_Click);
            this.btnUpdatePhoto.Click += new EventHandler(btnUpdatePhoto_Click);
            this.useridTextBox.Text = User.userid;
        }
        /// <summary>
        /// 更新个人照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnUpdatePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                ClearPhoto();
                this.photoPictureBox.Image = image;
            }
        }
        /// <summary>
        /// 更新个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnCommit_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.studentInfoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.courseMgrDataSet);
                ShowMessage("保存成功");
            }
            catch (Exception ex)
            {
                ShowMessage("保存失败：" + ex.Message);
            }
        }

        /// <summary>
        /// 清除图片缓存
        /// </summary>
        private void ClearPhoto()
        {
            if (this.photoPictureBox.Image != null)
            {
                this.photoPictureBox.Image.Dispose();
                this.photoPictureBox.Image = null;
            }
        }
    }
}
