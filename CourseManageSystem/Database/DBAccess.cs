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
        public static QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
        static DBAccess()
        {
            loginAdapter.Fill(CMDataSet.login);
        }
    }
}
