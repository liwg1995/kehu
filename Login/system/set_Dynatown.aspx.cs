using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class system_set_Dynatown : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Rid.Value = string.IsNullOrEmpty(Request["id"]) ? "" : Request["id"];

            if (!string.IsNullOrEmpty(Rid.Value))
            {
                Maticsoft.BLL.Dynatown bll = new Maticsoft.BLL.Dynatown();
                Maticsoft.Model.Dynatown model = bll.GetModel(Convert.ToInt32(Rid.Value));

                accnumber.Text = model.accnumber;
                company.Text = model.company;
                createdate.Text = (model.createdate).ToString();
                Dyname.Text = model.Dyname;
                flag.Text = model.flag;
                tel.Text = model.tel;
               

            }
        }
    }

    protected void save_Click(object sender, EventArgs e)
    {
        Maticsoft.BLL.Dynatown bll = new Maticsoft.BLL.Dynatown();
        Maticsoft.Model.Dynatown model = new Maticsoft.Model.Dynatown();

        model.accnumber = accnumber.Text;
        model.company = company.Text;
        model.createdate = Convert.ToDateTime(createdate.Text);
        model.Dyname = Dyname.Text;
        model.flag = flag.Text;
        model.tel = tel.Text;
        


        if (string.IsNullOrEmpty(Rid.Value))
        {

            if (bll.Add(model) > 0) { Maticsoft.Common.MessageBox.ShowAndRedirect(Page, "添加成功", "get_Dynatown.aspx"); }
            else { Maticsoft.Common.MessageBox.Show(Page, "添加失败"); }
        }
        else
        {
            model.id = Convert.ToInt32(Rid.Value);
            if (bll.Update(model)) { Maticsoft.Common.MessageBox.ShowAndRedirect(Page, "更新成功", "get_Dynatown.aspx"); }
            else { Maticsoft.Common.MessageBox.Show(Page, "更新失败"); }
        }
    }
}