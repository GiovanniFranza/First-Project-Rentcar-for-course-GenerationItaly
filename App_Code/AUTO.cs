using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AUTO
/// </summary>
public class AUTO
{
    public int codiceAuto;
    public int codiceModello;
    public string targa;
    public string costo;
    public string prezzo;
    public string data;
    public AUTO()
    {
    }

    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabAuto_SelectAll";
        return c.EseguiSPselectParam(cmd);


    }

    public DataTable SelectDdl()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabAuto_SelectforDdlAuto";
        return c.EseguiSPselectParam(cmd);

    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabAuto_Insert";
        cmd.Parameters.AddWithValue("@codiceModello", codiceModello);
        cmd.Parameters.AddWithValue("@targa", targa);
        cmd.Parameters.AddWithValue("@costo", costo);
        cmd.Parameters.AddWithValue("@prezzo", prezzo);
        cmd.Parameters.AddWithValue("@dataAcquisto", data);


        c.EseguiSPcmdParam(cmd);
    }

    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabAuto_Update";
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);
        cmd.Parameters.AddWithValue("@codiceModello", codiceModello);
        cmd.Parameters.AddWithValue("@targa", targa);
        cmd.Parameters.AddWithValue("@costo", costo);
        cmd.Parameters.AddWithValue("@prezzo", prezzo);
        cmd.Parameters.AddWithValue("@dataAcquisto", data);


        c.EseguiSPcmdParam(cmd);
    }

    public DataTable SelectTextBox()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabAuto_SelectTextBox";
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);

        dt = c.EseguiSPselectParam(cmd);

        return dt;
    }
}