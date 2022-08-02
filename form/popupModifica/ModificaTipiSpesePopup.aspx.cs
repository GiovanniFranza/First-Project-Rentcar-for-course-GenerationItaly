using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupModifica_ModificaTipiSpese : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            
            UpdateTextBox();
        }
        
       
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {

        // Dati textbox e griglia
        string nuovaDescrizione = txtTipoSpesa.Text.Trim();
        int codTipoSpesa = Convert.ToInt32(Session["id"]);

        // set tipispese oggetto
        TIPISPESE t = new TIPISPESE();
        t.descrizione = nuovaDescrizione;
        t.codiceTipoSpesa = codTipoSpesa;

      

        // se campi vuoti
        if (string.IsNullOrEmpty(nuovaDescrizione))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }

        // veficare se esiste già descrizione
        if (t.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Descrizione spesa già presente')", true);
            return;
        }

        // se controlli ok UPDATE
        t.Update();

        txtTipoSpesa.Text = "";
        lblRes.Text = "Dati inseriti correttamente";


    }

    public void UpdateTextBox()
    {
        TIPISPESE t = new TIPISPESE();
        DataTable dt = new DataTable();

        t.codiceTipoSpesa= Convert.ToInt32(Session["id"]);
        dt = t.SelectTextBox();

        txtTipoSpesa.Text = dt.Rows[0]["descrizione"].ToString();
    }

}