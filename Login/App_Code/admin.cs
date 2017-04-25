using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// 管理员登录方法
/// </summary>
public class admin
{

    public bool CheckPwd(string uid, string pwd) {

        try {
        bool result = false;
        string sql = "select pwd from users where uid='" + uid + "'";
        DataSet ds = CommonHelp.GetDataSetBySql(sql);
        if (ds != null && ds.Tables.Count > 0) {

            if (ds.Tables[0].Rows[0]["pwd"].ToString().Trim().Equals(pwd))
            {   result = true; }
        }
        return result;
        }
        catch (Exception e) { return false; }
    }

}
