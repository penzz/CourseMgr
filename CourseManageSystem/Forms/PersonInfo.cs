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
using System.IO;
using System.Xml.Linq;
using System.Data.SqlClient;

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
            try
            {
                this.selectStudentTableAdapter.Fill(this.courseMgrDataSet.SelectStudent, User.userid);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.btnCommit.Click += new EventHandler(btnCommit_Click);
            this.btnUpdatePhoto.Click += new EventHandler(btnUpdatePhoto_Click);
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
                CourseMgrDataContext c = new CourseMgrDataContext();
                var q = (from t in c.StudentInfo where t.userid == User.userid select t).Single();
                q.username = this.usernameTextBox.Text.Trim();
                q.sex = this.sexTextBox.Text.Trim();
                q.politics = this.politicsTextBox.Text.Trim();
                q.nation = this.nationTextBox.Text.Trim();
                q.birthday = this.birthdayDateTimePicker.Value;
                q.phone = this.phoneTextBox.Text.Trim();
                q.idcard = this.idcardTextBox.Text.Trim();
                c.SubmitChanges();
                string sql = "update StudentInfo set photo=@Photo where userid = '" + User.userid + "'";
                SaveImage(this.photoPictureBox, sql);
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
