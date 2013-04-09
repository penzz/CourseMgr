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
            foreach (var item in DBAccess.CMDataSet.login)
            {
                if (item.category.Equals(category) && item.userid.Equals(userid) && item.password.Equals(pwd))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
