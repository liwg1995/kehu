using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class system_get_customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     if (!IsPostBack) {

            Bind();
        }
    }

      public void Bind() {

          string where = " 1=1 ";
          if (!string.IsNullOrEmpty(txt1.Text)) { where += " and tel like '%" + txt1.Text + "%'"; }

          if (!string.IsNullOrEmpty(TextBox1.Text)) { where += " and createdate>='" + TextBox1.Text + "'"; }
          if (!string.IsNullOrEmpty(TextBox2.Text)) { where += " and createdate<='" + TextBox2.Text + "'"; }

           

          string sql = "select * from customer where " + where;

          DataSet ds = CommonHelp.GetDataSetBySql(sql);

          if (ds != null && ds.Tables.Count > 0)
          {
              rp1.DataSource = ds.Tables[0];
              rp1.DataBind();

          }
          else
          {
              rp1.Controls.Clear();
          }

    
    
    }


      protected void delete_Click(object sender, EventArgs e)
      {
          int id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
          Maticsoft.BLL.customer bll = new Maticsoft.BLL.customer();
          if (bll.Delete(id)) { Maticsoft.Common.MessageBox.ShowAndRedirect(Page, "删除成功！", "get_customer.aspx"); }
          else { Maticsoft.Common.MessageBox.Show(Page, "删除失败！"); }
      }
      protected void edit_Click(object sender, EventArgs e)
      {
          int id = Convert.ToInt32(((LinkButton)sender).CommandArgument);

          Response.Redirect("set_customer.aspx?id=" + id, false);
      }
      protected void add_Click(object sender, EventArgs e)
      {
          Response.Redirect("set_customer.aspx", false);
      }
      protected void LinkButton1_Click(object sender, EventArgs e)
      {
          Bind();
      }
}


 