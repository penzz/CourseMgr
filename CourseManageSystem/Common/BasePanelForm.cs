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
using System.Data.SqlClient;
using System.IO;

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
        protected void SaveImage(PictureBox pb, string sql)
        {
            if (pb.Image==null)
            {
                return;
            }
            string connString = Properties.Settings.Default.CourseMgrConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                pb.Image.Save("a.bmp");
                FileStream fileStream = new FileStream("a.bmp", FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] bytes = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();
                File.Delete("a.bmp");
                cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = bytes;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
