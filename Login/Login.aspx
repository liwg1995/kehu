<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE HTML>
<html>
<head>
	<meta charset="UTF-8">
<title>后台登陆</title>
<link href="system/css/base.css" rel="stylesheet">
    <script src="js/jquery-1.7.2.min.js"></script>
<!--[if lt IE 9]>
<script src="images/html5shiv.js"></script>
<![endif]-->
    <script>
        function check() {

            if ($("#txt1").val() == "") { alert("用户名不能为空！"); return false; }
            if ($("#txt2").val() == "") { alert("密码不能为空！"); return false; }
            return true;
        }
    </script>
</head>
    
<body>
<div class="login_top_btn"><%--<a class="btn" href="register.html">新用户注册</a>--%></div>
<section class="reg_box">
	<form class="login-form" action="#" method="post" runat="server">
                   		<div class="logo_icon"></div>
						<div class="logo_text">后台管理</div>
       <div class="form_body">
          <div class="control-group">
            <label class="control-label" for="username">用户名</label>
            <div class="controls">
              <input type="text" id="txt1" class="span3" placeholder="请输入用户名" nullmsg="请填写用户名" value="" name="txt1">
            </div>
          </div>
          <div class="control-group">
            <label class="control-label" for="inputPassword">密 码</label>
            <div class="controls">
              <input type="password" id="txt2"  class="span3" placeholder="请输入密码" nullmsg="请填写密码" name="txt2">
            </div>
          </div>     
          <div class="control-group">
          	<label class="control-label">&nbsp;</label>
            <div class="controls">
             <%-- <button type="submit" class="btn btn-large">登 录</button>--%>
                 <asp:Button ID="btLog" runat="server" CssClass="btn btn-large" Text="管理员登录" OnClick="btLog_Click" OnClientClick="return check();" />
                <a href="mailto:1144018715@qq.com" class="btn btn-large" role="button" title="发邮件联系管理员">邮件联系我</a>
                
            </div>
          </div>
      </div>
    </form>
</section>
</body>
</html>