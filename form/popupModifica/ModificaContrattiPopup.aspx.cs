using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupModifica_ModificaContrattiPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaDdlAuto();
            CaricaDdlClienti();
            UpdateTextBox();

        }
        lblRes.Text = $"Modifica contratto n°{Session["id"]}";

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        CONTRATTI c = new CONTRATTI();
        c.codiceContratto = int.Parse(Session["id"].ToString());
        c.codiceCliente = int.Parse(ddlClienti.SelectedValue);
        c.codiceAuto = int.Parse(ddlAuto.SelectedValue);
        c.dataInizioContratto = txtDataInizio.Text;
        c.dataFineContratto = txtdataFine.Text;
        c.Update();
        lblRes.Text = "Dati modificati con successo!";
    }

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

    public void UpdateTextBox()
    {
        CONTRATTI c = new CONTRATTI();
        DataTable dt = new DataTable();

        c.codiceContratto = Convert.ToInt32(Session["id"]);
        dt = c.SelectTextBox();

        ddlClienti.SelectedValue = dt.Rows[0]["codiceCliente"].ToString();
        ddlAuto.SelectedValue = dt.Rows[0]["codiceAuto"].ToString();
        txtDataInizio.Text = dt.Rows[0].Field<DateTime>(2).ToString("yyyy-MM-dd");
        txtdataFine.Text = dt.Rows[0].Field<DateTime>(3).ToString("yyyy-MM-dd");
       
    }
}