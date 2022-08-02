using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class MARCHE
{

    // Membri
    public int codiceMarca;
    public string descrizione;
    public MARCHE()
    {
        
    }

    // select all
    public DataTable SelectAll()
    {
       
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabMarche_SelectAll";

        //definisco query
        return c.EseguiSPselectParam(cmd);
    }

    // insert
    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabMarche_insert";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        c.EseguiSPcmdParam(cmd);
    }

    // modifica
    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabMarche_update";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);
        c.EseguiSPcmdParam(cmd);

    }

    // check se ci sono duplicati
    public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabMarche_Checkone";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        dt = c.EseguiSPselectParam(cmd);
        return dt.Rows.Count > 0;
    }

    public DataTable SelectTextBox()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabMarche_SelectTextBox";
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);

        dt = c.EseguiSPselectParam(cmd);

        return dt;
    }
}