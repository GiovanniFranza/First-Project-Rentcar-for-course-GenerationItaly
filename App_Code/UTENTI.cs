using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class UTENTI
{
    public int chiave;
    public string utente;
    public string password;

    public UTENTI()
    {
       
    }

    public bool CheckOne()
        // check if the usr and password inerted are ok
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabUtente_CheckOne";
        cmd.Parameters.AddWithValue("@utente", utente);
        cmd.Parameters.AddWithValue("@passw", password);


        dt = c.EseguiSPselectParam(cmd);

        return dt.Rows.Count > 0;
    }

    public bool CheckOneUser()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabUtente_CheckOneUser";
        cmd.Parameters.AddWithValue("@utente", utente);


        dt = c.EseguiSPselectParam(cmd);

        return dt.Rows.Count > 0;
    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabUtenti_Insert";
        cmd.Parameters.AddWithValue("@utente", utente);
        cmd.Parameters.AddWithValue("@passw", password);

        c.EseguiSPcmdParam(cmd);
    }
}