using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupInserisci_InserisciSpesePopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            CaricaDdlTipiSpese();
        }
    }


    protected void btnInvia_Click(object sender, EventArgs e)
    {
        // controlli formali prima di salvare variabili
        if (string.IsNullOrEmpty(txtImporto.Text) || string.IsNullOrEmpty(txtData.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Errore dati non validi')", true);
            return;
        }

        // controllo su correttezza campi int
        // tryparse return true if is parsed else false
        if (decimal.TryParse(txtImporto.Text, out decimal result) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Errore dati non validi')", true);
            return;
        }


        // determino variabili da inserire nella query
        SPESE s = new SPESE();
        s.codiceTipoSpesa = int.Parse(ddlTipoSpesa.SelectedValue);
        s.importo = txtImporto.Text.Replace(",", ".");
        s.data = txtData.Text;

        s.Insert();

        //reset table dropdownlist
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente')", true);

        txtData.Text = "";
        txtImporto.Text = "";
        ddlTipoSpesa.SelectedIndex = 0;
        
    }

   

    protected void CaricaDdlTipiSpese()
    {
        // carico dati in ddl
        TIPISPESE t = new TIPISPESE();

        // SelectAll ritorna DataTable
        ddlTipoSpesa.DataSource = t.SelectAll();
        ddlTipoSpesa.DataValueField = "codiceTipoSpesa";
        ddlTipoSpesa.DataTextField = "descrizione";
        ddlTipoSpesa.DataBind();
    }
}