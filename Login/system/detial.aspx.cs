using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class system_detial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string sql = "select count(*) from Agent;select count(*) from customer;select count(*) from  Dynatown;";

            DataSet ds = CommonHelp.GetDataSetBySql(sql);

            
            Agent.Text = ds.Tables[0].Rows[0][0].ToString();

            Customer.Text = ds.Tables[1].Rows[0][0].ToString();

            Dynatown.Text = ds.Tables[2].Rows[0][0].ToString();

        }

    }
}