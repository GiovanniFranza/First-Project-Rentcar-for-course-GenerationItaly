using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CALCOLI
/// </summary>
public class CALCOLI
{

    private static int anno;
    private int mese;

    public int Anno { get { return anno; } set { anno = value; } }


    public CALCOLI()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    // ricava tot spese in un anno
    public class SommatoreSpese
    {
        public DataTable SelectSommaSpese()
        {
            DataTable dt = new DataTable();
            CONNESSIONE c = new CONNESSIONE();


            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "tabSpese_SommaPerAnno";
            cmd.Parameters.AddWithValue("@anno", anno);

            dt = c.EseguiSPselectParam(cmd);

            return dt;
        }
    }

    // ricava tot locazioni in un anno
    public decimal SommaLocazioni(int anno)
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabContratti_selectSumLocazioni";
        cmd.Parameters.AddWithValue("@anno", anno);

        dt = c.EseguiSPselectParam(cmd);

        return (decimal)dt.Rows[0]["Importo"];
    }

    // for months table
    public DataTable SommatoreMensili()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();

        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabContratti_selectMonthlySum";
        cmd.Parameters.AddWithValue("@anno", anno);

        dt = c.EseguiSPselectParam(cmd);

        return dt;

    }

    // restituisce quanti euro ha fatturato un cotnratto per quel mese dell'anno
    


    
}