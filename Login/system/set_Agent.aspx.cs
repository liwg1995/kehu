using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class system_set_Agent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            Rid.Value = string.IsNullOrEmpty(Request["id"]) ? "" : Request["id"];

            if (!string.IsNullOrEmpty(Rid.Value)) {
                Maticsoft.BLL.Agent bll = new Maticsoft.BLL.Agent();
                Maticsoft.Model.Agent model = bll.GetModel(Convert.ToInt32(Rid.Value));


                addr.Text = model.addr;
                agentname.Text = model.agentname;
                category.Text = model.category;
                createdate.Text = (model.createdate).ToString();
                cuscount.Text = model.cuscount;
                flag.Text = model.flag;
                point.Text = model.point;
                tel.Text = model.tel;

            }
        }
    }
    protected void save_Click(object sender, EventArgs e)
    {
        Maticsoft.BLL.Agent bll = new Maticsoft.BLL.Agent();
        Maticsoft.Model.Agent model = new Maticsoft.Model.Agent();
        model.addr = addr.Text;
        model.agentname = agentname.Text;
        model.category = category.Text;
        model.createdate = Convert.ToDateTime(createdate.Text);
        model.cuscount = cuscount.Text;
        model.flag = flag.Text;
        model.point = point.Text;
        model.tel = tel.Text;

        if (string.IsNullOrEmpty(Rid.Value))
        {

            if (bll.Add(model) > 0) { Maticsoft.Common.MessageBox.ShowAndRedirect(Page, "添加成功", "get_Agent.aspx"); }
            else { Maticsoft.Common.MessageBox.Show(Page, "添加失败"); }
        }
        else {
            model.id = Convert.ToInt32(Rid.Value);
            if (bll.Update(model)) { Maticsoft.Common.MessageBox.ShowAndRedirect(Page, "更新成功", "get_Agent.aspx"); }
            else { Maticsoft.Common.MessageBox.Show(Page, "更新失败"); }
        }
    }
}