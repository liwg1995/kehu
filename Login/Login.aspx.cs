using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     

    }
    protected void btLog_Click(object sender, EventArgs e)
    {
        string uid = Request["txt1"];
        string pwd = Request["txt2"];

        admin admin = new admin();
        if (admin.CheckPwd(uid, pwd))
        {

            Session["USER"] = uid;
            SystemError.CreateErrorLog("用户：" + uid + "登陆成功！");
            Response.Redirect("system/default.aspx", false);

        }
        else {
            SystemError.CreateErrorLog("用户登录失败！用户名：" + uid + "密码：" + pwd);
            Maticsoft.Common.MessageBox.Show(Page,"用户名或密码错误！请重新登录！");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SystemError.sendEmail2CheckPwd();
    }
}