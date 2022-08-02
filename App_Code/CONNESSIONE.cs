using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

// <summary>
/// Classe che aiuta a connettermi al db
/// </summary>
public class CONNESSIONE
{

    // Membri della classe
    public SqlConnection conn = new SqlConnection();
    public string query;

    public CONNESSIONE()
    {

        // setta stringa di connessione con db
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["RENTCARConnectionString"].ConnectionString;
    }


    #region VECCHIMETODI
    //public DataTable EseguiSelect(string query)
    //{
    //    DataTable dt = new DataTable();
    //    SqlCommand cmd = new SqlCommand();
    //    SqlDataAdapter DA = new SqlDataAdapter();

    //    cmd.Connection = conn;
    //    cmd.CommandText = query;
    //    DA.SelectCommand = cmd;
    //    DA.Fill(dt);

    //    return dt;
    //}

    //public void EseguiCommand(string query)
    //{
    //    SqlCommand cmd = new SqlCommand();

    //    cmd.Connection = conn;

    //    cmd.CommandText = query;

    //    conn.Open();
    //    cmd.ExecuteNonQuery(); // inserisce dati, commit chiude
    //    conn.Close();
    //}

    //public DataTable EseguiSp()
    //{
    //    DataTable dt = new DataTable();
    //    SqlCommand cmd = new SqlCommand();
    //    SqlDataAdapter DA = new SqlDataAdapter();

    //    cmd.Connection = conn;
    //    cmd.CommandType = CommandType.StoredProcedure;

    //    cmd.CommandText = query;
    //    DA.SelectCommand = cmd;
    //    DA.Fill(dt);

    //    return dt;
    //}
    #endregion VECCHIMETODI


    //@param command with set query(store procedure)
    //and parameters used for INSERT UPDATE DELETE
    public void EseguiSPcmdParam(SqlCommand cmd)
    {
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    //@param command with set query(store procedure)
    // and parameters SELECT
    
    public DataTable EseguiSPselectParam(SqlCommand cmd)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter DA = new SqlDataAdapter();

        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;

        DA.SelectCommand = cmd;
        DA.Fill(dt);

        return dt;
    }




}