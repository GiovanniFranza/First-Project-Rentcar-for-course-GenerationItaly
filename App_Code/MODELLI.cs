using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class MODELLI
{
    public int codiceMarca;
    public int codiceModello;
    public string descrizione;
    public MODELLI()
    {
        
    }

    public DataTable SelectAll()
    {

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        //definisco query
        cmd.CommandText = "tabModelli_SelectAll";

        return c.EseguiSPselectParam(cmd);

    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabModelli_Insert";
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        c.EseguiSPcmdParam(cmd);
    }

    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabModelli_Update";
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);
        cmd.Parameters.AddWithValue("@descrizione", descrizione);
        cmd.Parameters.AddWithValue("@codicemodello", codiceModello);

        c.EseguiSPcmdParam(cmd);
    }

    public bool CheckOne()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabModelli_CheckOne";
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        dt = c.EseguiSPselectParam(cmd);

        return dt.Rows.Count > 0;
    }

    public DataTable SelectDdl()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabModelli_SelectforDdlModelli";
        return c.EseguiSPselectParam(cmd);

    }

    public DataTable SelectTextBox()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabModelli_SelectPopup";
        cmd.Parameters.AddWithValue("@codiceModello", codiceModello);

        dt = c.EseguiSPselectParam(cmd);

        return dt;
    }
}