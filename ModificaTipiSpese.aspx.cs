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

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Seleziono riga e ricavo id tipo spesa da griglia
        GridViewRow row = griglia.SelectedRow;

        // selvo id nella session
        Session["id"] = int.Parse(row.Cells[1].Text);
        nascondi.Visible= true;
    }
    // to do se nn selezioni nulla
   
    protected void CaricaGriglia()
    {
        TIPISPESE t = new TIPISPESE();

        //definisco query
        griglia.DataSource = t.SelectAll();
        griglia.DataBind();
    }


    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }
}