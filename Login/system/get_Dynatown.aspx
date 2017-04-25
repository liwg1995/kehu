<%@ Page Language="C#" AutoEventWireup="true" CodeFile="get_Dynatown.aspx.cs" Inherits="system_get_Dynatown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
 
.smenu_1,.smenu_3 {
    font-size: 13px;
    color: #354052;
    font-family: "宋体";
    float: left;
}
.smenu_3{margin:0 10px;}
.smenu_1{margin:0 0 0 4px;}


.smenu_2,.smenu_2:hover,.smenu_4,.smenu_4:hover,.smenu_12,.smenu_12:hover {
    float: left;
    width: 149px;
    height: 30px;
	
}
.smenu_2,.smenu_4,.smenu_12 { 
   background:url(../images/center/index_7.png) 0 0px no-repeat;
 }
 .smenu_9,.smenu_9:hover,.smenu_10,.smenu_10:hover {
    float: left;
    width: 76px;
    height: 30px;
	
}
.smenu_9,.smenu_10 { 
   background:url(../images/center/index_2.png) 0 0px no-repeat;
 }
.smenu_9:hover,.smenu_10:hover { 
   background:url(../images/center/index_2.png) 0 -30px no-repeat;
 }
 </style>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../js/My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#TextBox2").click(function () { WdatePicker({ dateFmt: 'yyyy-MM-dd' }); });
            $("#TextBox1").click(function () { WdatePicker({ dateFmt: 'yyyy-MM-dd' }); });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>


           <div class="s_right">
                                             <div class="smenu_1">
                                            手机号：
                                        </div>
                                        <div class="smenu_2">
                                            <asp:TextBox ID="txt1" runat="server" CssClass="t1"></asp:TextBox>
                                        </div>


                                        <div class="smenu_3">
                                            创建日期：
                                        </div>
                                      
                                           
                                              

                                            <div class="dingyi" >
                                             <div class="smenu_1">
                                            从：
                                        </div>   <div class="smenu_1">   <asp:TextBox ID="TextBox1" runat="server" CssClass="ty"></asp:TextBox></div>
                                                <div class="smenu_1">
                                            到：
                                        </div> 
                                               <div class="smenu_1">  <asp:TextBox ID="TextBox2" runat="server" CssClass="ty"></asp:TextBox></div>
                                            </div>




                                           
                                         
                                            
                                            
                                        <div class="smenu_5">
                                         
                                            <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" CssClass="cha" runat="server">查询</asp:LinkButton>
                                        </div>
    
       
         <table  border="0.2" class="tab1">

               
           <tr>
             
                      <th>
                账号 

            </th>
                      <th>
                姓名 

            </th>
                      <th>
                联系电话 

            </th>
                      <th>
                公司 

            </th>
                      <th>
                正常 

            </th>
                      <th>
                创建时间 

            </th>
                  <th>
                操作 

            </th>
                      
        </tr>
   
        <asp:Repeater ID="rp1" runat="server">
            <ItemTemplate>
                 <tr>
            <td style="display:none">
                <%#Eval("id") %>

            </td>

                    
                      <td>
                <%#Eval("accnumber") %>

            </td>
                      <td>
                <%#Eval("Dyname") %>

            </td>
                      <td>
                <%#Eval("tel") %>

            </td>
                      <td>
                <%#Eval("company") %>

            </td>
                      <td>
                <%#Eval("flag") %>

            </td>
                      <td>
                <%#Eval("createdate") %>

            </td>
                      <td>
                          
                           <asp:LinkButton ID="edit" OnClick="edit_Click" CommandArgument='<%#Eval("id") %>' runat="server">修改</asp:LinkButton>
                           <asp:LinkButton ID="delete" OnClick="delete_Click" CommandArgument='<%#Eval("id") %>' runat="server">删除</asp:LinkButton>

            </td>
                      
        </tr>
               
            </ItemTemplate>
        </asp:Repeater>

               <tr></tr>
              <tr></tr>
             
              <tr></tr>
              <tr></tr>
              <tr><td>
                  <asp:LinkButton ID="add" OnClick="add_Click" runat="server">新增</asp:LinkButton>
                  </td></tr>
   </table>


    </div>
    </form>
</body>
</html>
