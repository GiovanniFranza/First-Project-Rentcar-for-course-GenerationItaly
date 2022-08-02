using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{

    

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        // verifico username e password

        //// set variabili
        UTENTI u = new UTENTI();
        u.utente = txtName.Text.Trim();
        u.password = txtPsw.Text.Trim();
        
        if (!u.CheckOne())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati errati')", true);
            return;
        }

        // se controlli ok faccio login
        Response.Redirect("Default.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        // set variabili
        UTENTI u = new UTENTI();

        string username = txtName.Text.Trim(); 
        string password = txtPsw.Text.Trim();


        // CONTROLLI
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('uno o più campi non inseriti')", true);
            return;
        }

        u.utente = username;
        u.password = password;

        // verifico se utente registrato
        if (u.CheckOneUser())
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Utente presente')", true);
            return;
        }

        // se controlli ok inserisco utente
        u.Insert();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Inserimento utente effettuato. Effettua ora il login')", true);

        txtName.Text = "";
        txtPsw.Text = "";
    }
}