using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupInserisci_InserisciModelliPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaDdlMarche();
        }
    }
    protected void btnInserisci_Click(object sender, EventArgs e)
    {

        MODELLI m = new MODELLI();

        //query variables
        m.descrizione = txtDescrizione.Text;
        m.codiceMarca = int.Parse(ddlMarche.SelectedValue);

        #region CONTROLLI
        // Se textbox vuota
        if (string.IsNullOrEmpty(m.descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti.')", true);
            return;
        }


        // se modello già presente
        if (m.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Modello già presente')", true);
            return;
        }

        #endregion

        m.Insert();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente')", true);


        ddlMarche.SelectedIndex = 0;
        txtDescrizione.Text = "";

    }



    protected void CaricaDdlMarche()
    {
        // carico dati in ddl
        MARCHE m = new MARCHE();

        // SelectAll ritorna DataTable
        ddlMarche.DataSource = m.SelectAll();
        ddlMarche.DataValueField = "codiceMarca";
        ddlMarche.DataTextField = "descrizione";
        ddlMarche.DataBind();
    }

  


}
