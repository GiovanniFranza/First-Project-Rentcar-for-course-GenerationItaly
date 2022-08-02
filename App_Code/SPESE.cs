using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SPESE
/// </summary>
public class SPESE
{
    public int codiceSpesa;
    public int codiceTipoSpesa;
    public string descrizione;
    public string importo;
    public string data;
    public int anno;

    public SPESE()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable SelectAll()
    {

        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        //definisco query
        cmd.CommandText = "tabSpese_SelectAll";
        return c.EseguiSPselectParam(cmd);     
    }

    // Insert
    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabSpese_Insert";
        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", codiceTipoSpesa);
        cmd.Parameters.AddWithValue("@importo", importo);
        cmd.Parameters.AddWithValue("@dataSpesa", data);

        c.EseguiSPcmdParam(cmd);

    }

    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabSpese_Update";
        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", codiceTipoSpesa);
        cmd.Parameters.AddWithValue("@importo", importo);
        cmd.Parameters.AddWithValue("@dataSpesa", data);
        cmd.Parameters.AddWithValue("@codiceSpesa", codiceSpesa);
        
        c.EseguiSPcmdParam(cmd);
        

    }

    public void Delete()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        //string query = "DELETE FROM tabSpese WHERE codiceSpesa="+codiceSpesa+";";
        cmd.CommandText = "TabSpese_Delete";
        cmd.Parameters.AddWithValue("@codiceSpesa", codiceSpesa);


        c.EseguiSPcmdParam(cmd);


    }

    public DataTable SelectTextBox()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabSpese_SelectPopup";
        cmd.Parameters.AddWithValue("@codiceSpesa", codiceSpesa);


        dt = c.EseguiSPselectParam(cmd);

        return dt;
    }

    
}