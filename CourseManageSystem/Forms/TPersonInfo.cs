using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Common;

namespace CourseManageSystem.Forms
{
    public partial class TPersonInfo : CourseManageSystem.Common.BasePanelForm
    {
        public TPersonInfo()
        {
            InitializeComponent();
            this.Load+=new EventHandler(TPersonInfo_Load);
        }

        private void TPersonInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“courseMgrDataSet.TeacherInfo”中。您可以根据需要移动或删除它。
            this.teacherInfoTableAdapter.Fill(this.courseMgrDataSet.TeacherInfo);
            this.btnCommit.Click += new EventHandler(btnCommit_Click);
            this.btnUpdatePhoto.Click += new EventHandler(btnUpdatePhoto_Click);
            this.tuseridTextBox.Text = User.userid;

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
                this.tphotoPictureBox.Image = image;
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
                this.teacherInfoBindingSource.EndEdit();
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
            if (this.tphotoPictureBox.Image != null)
            {
                this.tphotoPictureBox.Image.Dispose();
                this.tphotoPictureBox.Image = null;
            }
        }
    }
}
