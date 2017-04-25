using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;

/// <summary>
/// SystemError 的摘要说明
/// </summary>
public class SystemError
{
    private static string m_fileName = HttpContext.Current.Server.MapPath("~/Systemlog.txt");
	public SystemError()
	{
		 
	}

    public static String FileName
    {
        get
        {
            return (m_fileName);
        }
        set
        {
            if (value != null || value != "")
            {
                m_fileName = value;
            }
        }
    }


    public static void CreateErrorLog(string message)
    {
        if (File.Exists(m_fileName))
        {
           
            StreamWriter sr = File.AppendText(FileName);
            sr.WriteLine("\n");
            sr.WriteLine("【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "】" + message);
            sr.Close();
        }
        else
        {
             
            StreamWriter sr = File.CreateText(FileName);
            sr.WriteLine("\n");
            sr.WriteLine("【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "】" + message);
            sr.Close();
        }
    }



    public static string sendEmail2CheckPwd()
    {
        MailMessage mail = new MailMessage();
        MailAddress from = new MailAddress("654701399@qq.com", "654701399"); //指定发件人的Email地址和显示名称

        //Attachment attachment = new Attachment("");  //邮件附件

        //string sendto = "915572879@qq.com";
        mail.To.Add("915572879@qq.com");
        mail.From = from;
        mail.Subject = "测试邮件";                      //邮件主题
        mail.Priority = System.Net.Mail.MailPriority.High;      //优先级
        mail.IsBodyHtml = true;                                 //是否为HTML格式
        mail.BodyEncoding = System.Text.Encoding.UTF8;          //编码
        mail.Body += "测试邮件！";                                   //邮件内容

        //mail.Attachments.Add(attachment);       //添加附件

        SmtpClient sc = new SmtpClient();  //SMTP发送邮件
        try
        {
            sc.Credentials = new System.Net.NetworkCredential("654701399@qq.com", "Wocaonima"); //发件人的用户名和密码
            sc.Host = "smtp.exmail.qq.com"; //发送服务器的名称
            sc.Send(mail);
            return "邮件发送成功！";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }


}