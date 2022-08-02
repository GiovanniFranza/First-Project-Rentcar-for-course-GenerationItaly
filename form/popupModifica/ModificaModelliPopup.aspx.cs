using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupModifica_ModificaModelliPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { 
            CaricaDdlMarche();
            UpdateTextBox();

        }

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {

        MODELLI m = new MODELLI();

        m.descrizione = txtModello.Text.Trim();
        m.codiceMarca = int.Parse(ddlMarche.SelectedValue.ToString());
        m.codiceModello = int.Parse(Session["id"].ToString());


        #region CONTROLLI
        // controlli formali

        // Se textbox vuota
        if (string.IsNullOrEmpty(m.descrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti.')", true);
            return;
        }


        // se update già presente
        // SELECT
        if (m.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Modello già presente')", true);
            return;
        }

        #endregion

        //UPDATE

        m.Update();

        // reset campi
        txtModello.Text = "";
        ddlMarche.SelectedIndex = 0;


      

        // alert inserimento riuscito
        lblRes.Text = "Dati inseriti correttamente";


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

    public void UpdateTextBox()
    {
        MODELLI m = new MODELLI();
        DataTable dt = new DataTable();

        m.codiceModello = Convert.ToInt32(Session["id"]);
        dt = m.SelectTextBox();

        ddlMarche.SelectedValue = dt.Rows[0]["codiceMarca"].ToString();
        txtModello.Text = dt.Rows[0]["descrizione"].ToString();
    }

   
}