using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class system_set_customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Rid.Value = string.IsNullOrEmpty(Request["id"]) ? "" : Request["id"];

            if (!string.IsNullOrEmpty(Rid.Value))
            {
                Maticsoft.BLL.customer bll = new Maticsoft.BLL.customer();
                Maticsoft.Model.customer model = bll.GetModel(Convert.ToInt32(Rid.Value));


                agent.Text=model.agent;
                agenttel.Text=model.agenttel;
                createdate.Text = (model.createdate).ToString();
                customername.Text = model.customername;
                flag.Text=model.flag;
                intention.Text = model.intention;
                level.Text = model.level;
                source.Text = model.source;
                tel.Text = model.tel;
                zygw.Text = model.zygw;

            }
        }
    }

    protected void save_Click(object sender, EventArgs e)
    {
        Maticsoft.BLL.customer bll = new Maticsoft.BLL.customer();
        Maticsoft.Model.customer model = new Maticsoft.Model.customer();

        model.agent = agent.Text;
        model.agenttel = agenttel.Text;
        model.createdate = Convert.ToDateTime(createdate.Text);
        model.customername = customername.Text;
        model.flag = flag.Text;
        model.intention = intention.Text;
        model.level = level.Text;
        model.source = source.Text;
        model.tel = tel.Text;
        model.zygw = zygw.Text;
        
       

        if (string.IsNullOrEmpty(Rid.Value))
        {

            if (bll.Add(model) > 0) { Maticsoft.Common.MessageBox.ShowAndRedirect(Page, "添加成功", "get_customer.aspx"); }
            else { Maticsoft.Common.MessageBox.Show(Page, "添加失败"); }
        }
        else
        {
            model.id = Convert.ToInt32(Rid.Value);
            if (bll.Update(model)) { Maticsoft.Common.MessageBox.ShowAndRedirect(Page, "更新成功", "get_customer.aspx"); }
            else { Maticsoft.Common.MessageBox.Show(Page, "更新失败"); }
        }
    }
}