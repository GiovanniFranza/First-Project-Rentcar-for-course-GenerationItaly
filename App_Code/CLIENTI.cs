using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CLIENTI
/// </summary>
public class CLIENTI
{
    public int codiceCliente;
    public string ragioneSociale;
    public string pIva;
    public string codiceFiscale;
    public string indirizzo;
    public string cap;
    public string citta;
    public string provincia;


    public CLIENTI()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        // controlli todo

        cmd.CommandText = "TabClienti_Insert";
        cmd.Parameters.AddWithValue("@ragioneSociale", ragioneSociale);
        cmd.Parameters.AddWithValue("@partitaIva", pIva);
        cmd.Parameters.AddWithValue("@codiceFiscale", codiceFiscale);
        cmd.Parameters.AddWithValue("@indirizzo", indirizzo);
        cmd.Parameters.AddWithValue("@cap", cap);
        cmd.Parameters.AddWithValue("@città", citta);
        cmd.Parameters.AddWithValue("@provincia", provincia);


        c.EseguiSPcmdParam(cmd);
    }

    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        // controlli todo

        cmd.CommandText = "TabClienti_Update";
        cmd.Parameters.AddWithValue("@ragioneSociale", ragioneSociale);
        cmd.Parameters.AddWithValue("@partitaIva", pIva);
        cmd.Parameters.AddWithValue("@codiceFiscale", codiceFiscale);
        cmd.Parameters.AddWithValue("@indirizzo", indirizzo);
        cmd.Parameters.AddWithValue("@cap", cap);
        cmd.Parameters.AddWithValue("@città", citta);
        cmd.Parameters.AddWithValue("@provincia", provincia);
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);


        c.EseguiSPcmdParam(cmd);
    }

    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabClienti_SelectAll";
        return c.EseguiSPselectParam(cmd);

    }


    public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabClienti_CheckOne";
        cmd.Parameters.AddWithValue("@partitaIva", pIva);
        cmd.Parameters.AddWithValue("@codiceFiscale", codiceFiscale);


        dt = c.EseguiSPselectParam(cmd);
        return dt.Rows.Count > 0;

    }

    public DataTable SelectDdl()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabClienti_selectforddlClienti";
        return c.EseguiSPselectParam(cmd);


    }

    // fill popup form fields
    public DataTable SelectTextBox()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabClienti_SelectTextBox";
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);

        dt = c.EseguiSPselectParam(cmd);

        return dt;
    }
}