using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupModifica_ModificaSpesePopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            CaricaDdlTipiSpese();
            UpdateTextBox();

        }
    }
    protected void btnInvia_Click(object sender, EventArgs e)
    {

        // CONTROLLI

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
        // ciao
       

        // determino variabili da inserire nella query
        SPESE s = new SPESE();
        s.codiceSpesa = int.Parse(Session["id"].ToString());
        s.codiceTipoSpesa = int.Parse(ddlTipoSpesa.SelectedValue);
        s.importo = txtImporto.Text.Replace(",", ".");
        s.data = txtData.Text;


        // UPDATE
        s.Update();

        // pulisco campi
        txtImporto.Text = "";
        ddlTipoSpesa.SelectedIndex = 0;
        txtData.Text = "";

        lblRes.Text = "Dati modificati correttamente";


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

    public void UpdateTextBox()
    {
        SPESE s = new SPESE();
        DataTable dt = new DataTable();

        s.codiceSpesa = Convert.ToInt32(Session["id"]);
        dt = s.SelectTextBox();

        txtImporto.Text = dt.Rows[0]["importo"].ToString();
        ddlTipoSpesa.SelectedValue = dt.Rows[0]["codiceTipoSpesa"].ToString();
        txtData.Text = dt.Rows[0].Field<DateTime>(2).ToString("yyyy-MM-dd");
    }
}
