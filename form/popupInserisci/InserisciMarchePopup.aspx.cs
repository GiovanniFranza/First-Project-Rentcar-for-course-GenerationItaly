using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupInserisci_InserisciMarchePopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisciMarca_Click(object sender, EventArgs e)
    {
        
        MARCHE m = new MARCHE();
        m.descrizione = txtMarca.Text;

        // verifico che non esista già
        if (m.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Marca già presente')", true);
            return;
        }

        // controlli formali
        if (string.IsNullOrEmpty(txtMarca.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti.')", true);
            return;
        }


        // Se verifiche ok insert
        m.Insert();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Inserimento marca effettuato.')", true);

        // svuoto campi e aggiorno griglia
        txtMarca.Text = "";
        
    }
}