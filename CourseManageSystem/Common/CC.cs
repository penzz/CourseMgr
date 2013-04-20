using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CourseManageSystem.Database;

namespace CourseManageSystem.Common
{
    class CC
    {
        /// <summary>
        /// 验证用户登录信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool checkUser(string userid, string pwd, string category)
        {
            DBAccess.loginAdapter.Fill(DBAccess.CMDataSet.login);
            foreach (var item in DBAccess.CMDataSet.login)
            {
                if (item.category.Equals(category) && item.userid.Equals(userid) && item.password.Equals(pwd))
                {
                    return true;
                }
            }
            return false;
        }
        public static string getUserName()
        {
            string username = "";
            CourseMgrDataContext c = new CourseMgrDataContext();
            switch (User.category)
            {
                case "1":
                    var q1 = (from t in c.TeacherInfo where t.Tuserid == User.userid select t).Single();
                    username = q1.Tusername;
                    break;
                case "0":
                    var q2 = (from t in c.StudentInfo where t.userid == User.userid select t).Single();
                    username = q2.username;
                    break;
            }
            return username;
        }
    }
}
