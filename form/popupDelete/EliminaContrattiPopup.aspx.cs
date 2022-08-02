using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupDelete_EliminaContrattiPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblmessage.Text = $"Vuoi eliminare  il contratto numero {Session["id"]}?";

    }

    protected void btnElimina_Click(object sender, EventArgs e)
    {
        CONTRATTI c = new CONTRATTI();
        c.codiceContratto = Convert.ToInt32(Session["id"]);
        c.Delete();
        lblmessage.Text = "Contratto eliminato correttamente!";
    }
}