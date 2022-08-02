using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupInserisci_InserisciClientiPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        CLIENTI c = new CLIENTI();


        #region CONTROLLI

        //   se textbox vuote
        if (string.IsNullOrEmpty(ragioneSociale) ||
            string.IsNullOrEmpty(pIva) ||
            string.IsNullOrEmpty(codiceFiscale) ||
            string.IsNullOrEmpty(indirizzo) ||
            string.IsNullOrEmpty(cap) ||
            string.IsNullOrEmpty(città) ||
            string.IsNullOrEmpty(provincia))


        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti.')", true);
            return;
        }

        c.ragioneSociale = ragioneSociale;
        c.pIva = pIva;
        c.codiceFiscale = codiceFiscale;
        c.indirizzo = indirizzo;
        c.cap = cap;
        c.citta = città;
        c.provincia = provincia;


        if (c.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('piva o codice fiscale già esistenti')", true);
            return;
        }

        // verifiche che piva e codice fiscale non siano ripetuti
        // SELECT

        #endregion


        c.Insert();
        // aggiorno griglia

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente')", true);

        // pulisci campi
        txtRagioneSociale.Text = "";
        txtPartitaIva.Text = "";
        txtCodiceFiscale.Text = "";
        txtIndirizzo.Text = "";
        txtCap.Text = "";
        txtCitta.Text = "";
        txtProvincia.Text = "";
    }
}