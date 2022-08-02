using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaGriglia();
    }


    // Aggiorna griglia con btnAggiorna

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void CaricaGriglia()
    {
        TIPISPESE t = new TIPISPESE();

        //definisco query
        griglia.DataSource = t.SelectAll();
        griglia.DataBind();
    }

}