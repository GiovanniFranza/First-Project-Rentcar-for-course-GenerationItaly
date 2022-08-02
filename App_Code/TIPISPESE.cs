using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TIPISPESE
/// </summary>
public class TIPISPESE
{
    // columns
    public int codiceTipoSpesa;
    public string descrizione;

    public TIPISPESE()
    {
        //
        // TODO: Add constructor logic here
        //

    }

    
    // Seleziona tutta la tabella
    /// <summary>
    /// Esegue una SELECT * sul db
    /// </summary>
    /// <returns>Restituisce una DataTable</returns>
    public DataTable SelectAll()
    {
     
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        //definisco query
        cmd.CommandText = "tabTipiSpese_SelectAll";

        return c.EseguiSPselectParam(cmd);
    }


    // INSERT
    // ins nuovo tipo spesa
    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabTipiSpese_Insert";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        c.EseguiSPcmdParam(cmd); 
    }

    //UPDATE
    // modificare un tipo spesa
    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabTipiSpese_Update";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);
        cmd.Parameters.AddWithValue("@codiceTipoSpesa", codiceTipoSpesa);

        c.EseguiSPcmdParam(cmd);
    }

    // SELECT
    // verifica esistenza tipo spesa
    public bool CheckOne()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabTipiSpese_CheckOne";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);
        dt = c.EseguiSPselectParam(cmd);

        return dt.Rows.Count > 0;
    }

    // riempe textBox in popup
    public DataTable SelectTextBox()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabTipiSpese_SelectTextBox";
        cmd.Parameters.AddWithValue("@codiceTipoSpesa", codiceTipoSpesa);
        dt = c.EseguiSPselectParam(cmd);

        return dt ;
    }
}