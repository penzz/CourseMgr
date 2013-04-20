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
    public partial class MyCourse : CourseManageSystem.Common.BasePanelForm
    {
        public MyCourse()
        {
            InitializeComponent();
            this.Load += new EventHandler(MyCourse_Load);
        }

        void MyCourse_Load(object sender, EventArgs e)
        {
            this.dataGridViewMyCourse.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridViewMyCourse.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            this.labelStudent.Text = CC.getUserName();
            DBAccess.scAdapter.Fill(DBAccess.CMDataSet.SC);
            string strRowFilter = "Sno = '" + User.userid + "'";
            DBAccess.CMDataSet.SC.DefaultView.RowFilter = strRowFilter;
            this.dataGridViewMyCourse.DataSource = DBAccess.CMDataSet.SC.DefaultView;
            this.dataGridViewMyCourse.Columns[0].Visible = false;
            this.dataGridViewMyCourse.Columns[1].HeaderText = "学号";
            this.dataGridViewMyCourse.Columns[2].HeaderText = "课程号";
            this.dataGridViewMyCourse.Columns[3].HeaderText = "选课时间";
            this.dataGridViewMyCourse.Columns[4].HeaderText = "分数";
        }
    }
}
