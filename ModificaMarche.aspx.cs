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

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        // selezione descrizione da modificare 
        GridViewRow row = griglia.SelectedRow;

        // campi nascosti che non si vedono li rendo selezionabili

        int codiceMarca = int.Parse(griglia.SelectedDataKey[0].ToString());
        Session["id"] = codiceMarca;
        nascondi.Visible = true;

    }

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }


    protected void CaricaGriglia()
    {
        MARCHE m = new MARCHE();
        griglia.DataSource = m.SelectAll();
        griglia.DataBind();
    }
}