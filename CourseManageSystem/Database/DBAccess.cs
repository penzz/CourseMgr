using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CourseManageSystem.Database.CourseMgrDataSetTableAdapters;

namespace CourseManageSystem.Database
{
    public static class DBAccess
    {
        public static CourseMgrDataSet CMDataSet = new CourseMgrDataSet();
        public static loginTableAdapter loginAdapter = new loginTableAdapter();
        public static SCTableAdapter scAdapter = new SCTableAdapter();
        public static QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
        public static StudentInfoTableAdapter SITableAdapter = new StudentInfoTableAdapter();
        static DBAccess()
        {
            loginAdapter.Fill(CMDataSet.login);
            scAdapter.Fill(CMDataSet.SC);
        }
    }
}
