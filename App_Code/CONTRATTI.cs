using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CONTRATTI
/// </summary>
public class CONTRATTI
{
    public int codiceContratto;
    public int codiceCliente;
    public int codiceAuto;
    public string dataInizioContratto;
    public string dataFineContratto;
    public CONTRATTI()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabContratti_SelectAll";
        return c.EseguiSPselectParam(cmd);


    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabContratti_insert";
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);
        cmd.Parameters.AddWithValue("@dataInizioContratto", dataInizioContratto);
        cmd.Parameters.AddWithValue("@dataFineContratto", dataFineContratto);

        c.EseguiSPcmdParam(cmd);
    }

    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabContratti_Update";
        cmd.Parameters.AddWithValue("@codiceContratto", codiceContratto);
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);
        cmd.Parameters.AddWithValue("@dataInizioContratto", dataInizioContratto);
        cmd.Parameters.AddWithValue("@dataFineContratto", dataFineContratto);

        c.EseguiSPcmdParam(cmd);
    }

    public void Delete()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabContratti_Delete";
        cmd.Parameters.AddWithValue("@codiceContratto", codiceContratto);
        c.EseguiSPcmdParam(cmd);

    }

    public DataTable SelectTextBox()
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TabContratti_SelectTextBox";
        cmd.Parameters.AddWithValue("@codiceContratto", codiceContratto);

        dt = c.EseguiSPselectParam(cmd);

        return dt;
    }

  
    

    



}