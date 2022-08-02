using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupModifica_ModificaClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { UpdateTextBox(); }
        lblRes.Text = $"Modifica cliente n°{Session["id"]}";
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        string ragioneSociale = txtRagioneSociale.Text.Trim();
        string pIva = txtPartitaIva.Text.Trim();
        string codiceFiscale = txtCodiceFiscale.Text.Trim();
        string indirizzo = txtIndirizzo.Text.Trim();
        string cap = txtCap.Text.Trim();
        string città = txtCitta.Text.Trim();
        string provincia = txtProvincia.Text.Trim();

        //   se textbox vuote
        if (string.IsNullOrEmpty(ragioneSociale) ||
            string.IsNullOrEmpty(pIva) ||
            string.IsNullOrEmpty(codiceFiscale) ||
            string.IsNullOrEmpty(indirizzo) ||
            string.IsNullOrEmpty(cap) ||
            string.IsNullOrEmpty(città) ||
            string.IsNullOrEmpty(provincia))
        {
            lblRes.Text = "Dati non inseriti";
            return;
        }

        CLIENTI c = new CLIENTI();
        c.ragioneSociale = ragioneSociale;
        c.pIva = pIva;
        c.codiceFiscale = codiceFiscale;
        c.indirizzo = indirizzo;
        c.cap = cap;
        c.citta = città;
        c.provincia = provincia;
        c.codiceCliente = Convert.ToInt32(Session["id"]);

        c.Update();

        // aggiorno griglia
        lblRes.Text = "Dati modificati correttamente";

        // pulisci campi
        txtRagioneSociale.Text = "";
        txtPartitaIva.Text = "";
        txtCodiceFiscale.Text = "";
        txtIndirizzo.Text = "";
        txtCap.Text = "";
        txtCitta.Text = "";
        txtProvincia.Text = "";
    }

    public void UpdateTextBox()
    {
        CLIENTI c = new CLIENTI();
        DataTable dt = new DataTable();

        c.codiceCliente = Convert.ToInt32(Session["id"]);
        dt = c.SelectTextBox();

        txtRagioneSociale.Text = dt.Rows[0]["ragioneSociale"].ToString();
        txtPartitaIva.Text = dt.Rows[0]["partitaIva"].ToString();
        txtCodiceFiscale.Text = dt.Rows[0]["codiceFiscale"].ToString();
        txtIndirizzo.Text = dt.Rows[0]["indirizzo"].ToString();
        txtCap.Text = dt.Rows[0]["cap"].ToString();
        txtCitta.Text = dt.Rows[0]["città"].ToString();
        txtProvincia.Text = dt.Rows[0]["provincia"].ToString();
    }
}