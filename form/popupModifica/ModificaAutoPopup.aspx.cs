using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form_popupModifica_ModificaAutoPopup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            CaricaDdlModelli();
            UpdateTextBox();
        }
            lblRes.Text = $"Modifica auto id#{Session["id"]}";

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        AUTO a = new AUTO();
        a.codiceAuto = Convert.ToInt32(Session["id"]);
        a.codiceModello = int.Parse(ddlModelli.SelectedValue);
        a.targa = txtTarga.Text;
        a.costo = txtCosto.Text.Replace(",", "."); 
     

        a.prezzo = txtPrezzo.Text.Replace(",", "."); ;
        a.data = txtData.Text;
        a.Update();
        lblRes.Text = "Dati modificati correttamente";
    }

    public void CaricaDdlModelli()
    {
        MODELLI m = new MODELLI();
        ddlModelli.DataSource = m.SelectDdl();
        ddlModelli.DataValueField = "codiceModello";
        ddlModelli.DataTextField = "automobile";
        ddlModelli.DataBind();
    }

    public void UpdateTextBox()
    {
        AUTO a = new AUTO();
        DataTable dt = new DataTable();

        a.codiceAuto = Convert.ToInt32(Session["id"]);
        dt = a.SelectTextBox();

        ddlModelli.SelectedValue = dt.Rows[0]["codiceModello"].ToString();
        txtTarga.Text = dt.Rows[0]["targa"].ToString();
        txtCosto.Text = dt.Rows[0]["costo"].ToString();
        txtPrezzo.Text = dt.Rows[0]["prezzo"].ToString();
        txtData.Text = dt.Rows[0].Field<DateTime>(4).ToString("yyyy-MM-dd");

    }
}