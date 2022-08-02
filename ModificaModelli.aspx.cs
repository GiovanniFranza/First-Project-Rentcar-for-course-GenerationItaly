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

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {

        GridViewRow row = griglia.SelectedRow;
        // txtModello.Text = row.Cells[3].Text;

        // campi nascosti che non si vedono li rendo selezionabili
        // ddlMarche.SelectedValue = griglia.SelectedDataKey[0].ToString();

        int codiceModello = int.Parse(griglia.SelectedDataKey[1].ToString());
        Session["id"] = codiceModello;
        nascondi.Visible = true;
        
    }

    protected void CaricaGriglia()
    {
        MODELLI m = new MODELLI();
        griglia.DataSource = m.SelectAll();
        griglia.DataBind();
    }

  
}