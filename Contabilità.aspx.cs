using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        // populate dropdown list
        if (!IsPostBack)
        {
            UpdateDdl();
        }
    }
    
    protected void btnInvia_Click(object sender, EventArgs e)
    {
        CALCOLI ca = new CALCOLI();
        DataTable dt = new DataTable();
        CALCOLI.SommatoreSpese cs = new CALCOLI.SommatoreSpese();

        int anno = int.Parse(ddlAnno.SelectedValue);
        ca.Anno = anno;
        dt = cs.SelectSommaSpese();
        decimal sommaSpese = (decimal)dt.Rows[0]["somma"];
        decimal sommaLocazioni = (decimal)ca.SommaLocazioni(anno);
        decimal ricavi = sommaLocazioni - sommaSpese;

        ca.Anno = anno; // set

        // Soma spese per anno
        lblSommaSpese.Text = $"{sommaSpese}€";

        // Somma locazioni
        lblSommaLocazioni.Text = $"{sommaLocazioni}€";

        // Bilancio
        lblBilancio.Text = $"{ricavi}€";



        aggiornaGriglia();


    }

    public void UpdateDdl()
    {
        for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 2; i--)
        {
            ddlAnno.Items.Add(i.ToString());
        }
    }

    public void aggiornaGriglia()
    {
        CALCOLI c = new CALCOLI();
        giglia.DataSource = c.SommatoreMensili();
        giglia.DataBind();
    }

}