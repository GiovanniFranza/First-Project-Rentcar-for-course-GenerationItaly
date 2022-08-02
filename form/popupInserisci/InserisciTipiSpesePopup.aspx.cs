using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupInserisci_InserisciTipiSpesePopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        TIPISPESE t = new TIPISPESE();

        t.descrizione = txtTipoSpesa.Text;

        // verifico che non esista già
        if (t.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Tipo spesa già presente')", true);
            return;
        }

        // verifico se campi vuoti
        if (string.IsNullOrEmpty(txtTipoSpesa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente')", true);
            return;
        }

        // se verifiche ok
        t.Insert();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Spesa inserita correttamente')", true);

        txtTipoSpesa.Text = "";
        //CaricaGriglia();
    }

}