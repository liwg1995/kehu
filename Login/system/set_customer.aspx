<%@ Page Language="C#" AutoEventWireup="true" CodeFile="set_customer.aspx.cs" Inherits="system_set_customer" %>

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
                来源 

             </td>
                      <td>
                <asp:TextBox ID="source" runat="server"></asp:TextBox>

             </td></tr> <tr>
                      <td>
                客户姓名 

            </td>
                      <td>
               <asp:TextBox ID="customername" runat="server"></asp:TextBox>

             </td></tr> <tr>
                      <td>
                手机号 

            </td>
                      <td>
                <asp:TextBox ID="tel" runat="server"></asp:TextBox>

             </td></tr> <tr>
                      <td>
                意向项目 

            </td>
                      <td>
                <asp:TextBox ID="intention" runat="server"></asp:TextBox>

             </td></tr> <tr>
                      <td>
                经纪人 

            </td>
                      <td>
                  <asp:TextBox ID="agent" runat="server"></asp:TextBox>


             </td></tr> <tr>
                      <td>
                经纪人手机 

            </td>
                      <td>
                <asp:TextBox ID="agenttel" runat="server"></asp:TextBox>

             </td></tr> <tr>
                      <td>
                置业顾问 

            </td>
                      <td>
               <asp:TextBox ID="zygw" runat="server"></asp:TextBox>


             </td></tr> <tr>
                       <td>
                状态 

            </td>
                      <td>
                  <asp:TextBox ID="flag" runat="server"></asp:TextBox>

             </td></tr> <tr>
                  <td>
                创建时间 

            </td>
                      <td>
                  <asp:TextBox ID="createdate" runat="server" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox>

             </td></tr> <tr>
                  <td>
                客户等级 

            </td>
                      <td>
                <asp:TextBox ID="level" runat="server"></asp:TextBox>

             </td>
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
                  </td><td><a href="get_customer.aspx">返回</a></td></tr>
   </table>
    </div>
         <asp:HiddenField ID="Rid" runat="server" />
    </form>
</body>
</html>
