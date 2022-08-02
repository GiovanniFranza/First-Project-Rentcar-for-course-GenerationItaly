using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupDelete_EliminaSpesePopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblmessage.Text = $"Vuoi eliminare la spesa numero {Session["id"]}?";
    }

    protected void btnElimina_Click(object sender, EventArgs e)
    {
        SPESE s = new SPESE();
        s.codiceSpesa = Convert.ToInt32(Session["id"]);
        s.Delete();
        lblmessage.Text = "Spesa eliminata correttamente!";
    }
}