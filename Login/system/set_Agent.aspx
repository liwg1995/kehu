<%@ Page Language="C#" AutoEventWireup="true" CodeFile="set_Agent.aspx.cs" Inherits="system_set_Agent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="../js/My97DatePicker/WdatePicker.js"></script>
    <title></title>
        
     <style type="text/css">

.tab1
{
    width: 95%;
    margin: 0px auto;
    margin-top: 10px;
    text-align: center;
    border-left: 1px solid silver;
    border-top: 1px solid silver;
    line-height: 25px;
}
.tab1 th
{
    border-right: 1px solid silver;
    border-bottom: 1px solid silver;
    background: #eee;
}
.tab1 td
{
    border-right: 1px solid silver;
    border-bottom: 1px solid silver;
}
 </style>
     <script src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript">
        function check() {
            var n = 0;
            $("table").find("input").each(function (e, f) {
                if ($(f).val() == "") { n++; }
            })
            if (n > 0) { alert("信息填写不完全"); return false; }
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <table border="0" class="tab1">

               
           <tr>
             
                      <td>
                经纪人类别  </td><td> <asp:TextBox ID="category" runat="server"></asp:TextBox>

            </td></tr> <tr>
                      <td>
                姓名 

            </td> <td>
                 <asp:TextBox ID="agentname" runat="server"></asp:TextBox> 

            </td></tr> <tr>
                      <td>
                手机 

            </td> <td>
                <asp:TextBox ID="tel" runat="server"></asp:TextBox>

            </td></tr> <tr>
                      <td>
                所在地 

            </td> <td>
                <asp:TextBox ID="addr" runat="server"></asp:TextBox>

            </td></tr> <tr>
                      <td>
                积分 

            </td> <td>
                 <asp:TextBox ID="point" runat="server"></asp:TextBox>

            </td></tr> <tr>
                      <td>
                客户数量 

            </td> <td>
               <asp:TextBox ID="cuscount" runat="server"></asp:TextBox>

            </td></tr> <tr>
                      <td>
                正常 

            </td> <td>
                <asp:TextBox ID="flag" runat="server"></asp:TextBox>

            </td></tr> <tr>
                       <td>
                创建时间 

            </td> <td>
                <asp:TextBox ID="createdate" runat="server" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox>

            </td></tr> <tr>
                  
        </tr>
 
              <tr>
             
                      <td>
                         

            </td>
                      <td>
              

            </td>
                      <td>
             

            </td>
                      <td>
              

            </td>
                      <td>
             

            </td>
                      <td>
             

            </td>
                      <td>
            

            </td>
                       <td>
              

            </td>
                  
        </tr>

              <tr></tr>
              <tr></tr>
             
              <tr></tr>
              <tr></tr>
              <tr><td>
                <asp:LinkButton ID="save" OnClick="save_Click" OnClientClick="return check();" runat="server">保存</asp:LinkButton>
                  </td><td><a href="get_Agent.aspx">返回</a></td></tr>
             </table>

    </div>
        <asp:HiddenField ID="Rid" runat="server" />
    </form>
</body>
</html>
