using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupInserisci_InserisciContrattiPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaDdlAuto();
            CaricaDdlClienti();
        }
    }

    // button event
    protected void btnInserisci_Click(object sender, EventArgs e)
    {

        // controlli formali
        if (string.IsNullOrEmpty(txtDataInizio.Text) ||
            (string.IsNullOrEmpty(txtdataFine.Text)
            ))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti.')", true);
            return;
        }

        CONTRATTI c = new CONTRATTI();

        c.codiceCliente = int.Parse(ddlClienti.SelectedValue);
        c.codiceAuto = int.Parse(ddlAuto.SelectedValue);
        c.dataInizioContratto = txtDataInizio.Text;
        c.dataFineContratto = txtdataFine.Text;
        c.Insert();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Inserimento marca effettuato.')", true);

    }

    //ddl
    public void CaricaDdlClienti()
    {
        CLIENTI c = new CLIENTI();
        ddlClienti.DataSource = c.SelectDdl();
        ddlClienti.DataValueField = "codiceCliente";
        ddlClienti.DataTextField = "ragioneSociale";
        ddlClienti.DataBind();
    }

    public void CaricaDdlAuto()
    {
        AUTO a = new AUTO();
        ddlAuto.DataSource = a.SelectDdl();
        ddlAuto.DataValueField = "codiceAuto";
        ddlAuto.DataTextField = "automobile";
        ddlAuto.DataBind();
    }
}