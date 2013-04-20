using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseManageSystem.Common;
using System.Data.SqlClient;
using CourseManageSystem.Database;
using System.Linq;

namespace CourseManageSystem.Forms
{
    public partial class TPersonInfo : CourseManageSystem.Common.BasePanelForm
    {
        public TPersonInfo()
        {
            InitializeComponent();
            this.Load += new EventHandler(TPersonInfo_Load);
        }

        private void TPersonInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“courseMgrDataSet.TeacherInfo”中。您可以根据需要移动或删除它。
            try
            {
                this.selectTeacherTableAdapter.Fill(this.courseMgrDataSet.SelectTeacher, User.userid);
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
                CourseMgrDataContext c = new CourseMgrDataContext();
                var q = (from t in c.TeacherInfo where t.Tuserid == User.userid select t).Single();
                q.Tusername = this.tusernameTextBox.Text.Trim();
                q.Tsex = this.tsexTextBox.Text.Trim();
                q.Temail = this.temailTextBox.Text.Trim();
                q.Tphone = this.tphoneTextBox.Text.Trim();
                q.Tacademic = this.tacademicTextBox.Text.Trim();
                q.Theader = this.theaderTextBox.Text.Trim();
                q.Tintro = this.tintroTextBox.Text.Trim();
                q.Tbirthday = this.tbirthdayDateTimePicker.Value;
                c.SubmitChanges();
                string sql = "update TeacherInfo set Tphoto=@Photo where Tuserid = '" + User.userid + "'";
                SaveImage(this.tphotoPictureBox, sql);
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
