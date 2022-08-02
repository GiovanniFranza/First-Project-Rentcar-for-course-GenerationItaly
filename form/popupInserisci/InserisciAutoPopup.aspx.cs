using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupInserisci_InserisciAutoPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaDdlModelli();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        AUTO a = new AUTO();
        a.codiceModello = int.Parse(ddlModelli.SelectedValue);
        a.targa = txtTarga.Text;
        a.costo = txtCosto.Text;
        a.prezzo = txtPrezzo.Text;
        a.data = txtData.Text;
        a.Insert();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente')", true);



    }

    public void CaricaDdlModelli()
    {
        MODELLI m = new MODELLI();
        ddlModelli.DataSource = m.SelectDdl();
        ddlModelli.DataValueField = "codiceModello";
        ddlModelli.DataTextField = "automobile";
        ddlModelli.DataBind();
    }
}