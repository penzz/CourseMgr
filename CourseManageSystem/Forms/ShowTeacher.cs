using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseManageSystem.Forms
{
    public partial class ShowTeacher : Form
    {
        private string tid;

        public string Tid
        {
            get { return tid; }
            set { tid = value; }
        }

        public ShowTeacher()
        {
            InitializeComponent();
        }
        public ShowTeacher(string tid)
        {
            InitializeComponent();
            this.Load += new EventHandler(ShowTeacher_Load);
            this.tid = tid;
            this.Text = "教师[" + tid + "]详细介绍";
        }

        void ShowTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                this.selectTeacherTableAdapter.Fill(this.courseMgrDataSet.SelectTeacher, Tid);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
