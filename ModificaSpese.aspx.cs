using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {


        CaricaGriglia();
        if (!IsPostBack)
        {
            nascondi.Visible = false;

        }

    }

    // select event
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = griglia.SelectedRow;
        int codiceSpesa = int.Parse(griglia.SelectedDataKey[1].ToString());
        Session["id"] = codiceSpesa;
        nascondi.Visible = true;
    }

 

    protected void CaricaGriglia()
    {
        SPESE s = new SPESE();
        griglia.DataSource = s.SelectAll();
        griglia.DataBind();
    }

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }


}