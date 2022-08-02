using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            nascondi.Visible = false;
        }
        CaricaGriglia();
    }

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id"] = griglia.SelectedDataKey[0];
        nascondi.Visible = true;
    }


    public void CaricaGriglia()
    {
        AUTO a = new AUTO();
        griglia.DataSource = a.SelectAll();
        griglia.DataBind();
    }
}