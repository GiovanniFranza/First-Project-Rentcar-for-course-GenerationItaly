using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupModifica_ModificaMarche : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { UpdateTextBox(); }
        lblres.Text = $"Modifica marca n°{Session["id"]}";
    }

    protected void btnMarca_Click(object sender, EventArgs e)
    {

        //  set variabili, ricavo dati da textbox
        MARCHE m = new MARCHE();
       


        #region CONTROLLI


        // verifico se inserita nuova marca in textbox
        if (string.IsNullOrEmpty(txtMarca.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }

        m.codiceMarca = int.Parse(Session["id"].ToString());
        m.descrizione = txtMarca.Text;

        // verifico se marca NON presente in db
        if (m.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Marca già presente')", true);
            return;
        }


        #endregion

        //se controlli ok faccio INSERT <--- qui
        m.Update();

        // reset textbox
        txtMarca.Text = "";
        lblres.Text = " Dati modificati correttamente";

        // reset index selezionato da griglia

        // avviso inserimento riuscito
        
    }


    public void UpdateTextBox()
    {
        MARCHE m = new MARCHE();
        DataTable dt = new DataTable();

        m.codiceMarca = Convert.ToInt32(Session["id"]);
        dt = m.SelectTextBox();

        txtMarca.Text = dt.Rows[0]["descrizione"].ToString();
    }
}