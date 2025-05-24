using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

public class DBC
{
    public SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hope.mdf;Integrated Security=True;Connect Timeout=60");
    SqlCommand cmd;
    private void RunDB(CommandType DBC,string OperationText)
    {
        //Decler  Data Source=DAISUKE;Initial Catalog=.MDF;Integrated Security=True
        //conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\.mdf;Integrated Security=True;Trusted_Connection=True");
        //conn 
        //Requirment   @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\STCo.mdf;Integrated Security=True;Trusted_Connection=True"
        //conn.ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();


        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = DBC;
        cmd.CommandText = OperationText;
        conn.Open();
    }
    private int INUPDE()
    {
        try
        {
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            return x;
        }
        catch (SqlException ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
            conn.Close();
            return ex.Number;
        }
    }
    public int RunProcrduer(string OperationName ,SortedList Var)
    {
        RunDB(CommandType.StoredProcedure,OperationName);
        for(int x=0;x<Var.Count;x++)
        {
            cmd.Parameters.AddWithValue(Convert.ToString( Var.GetKey(x)),Convert.ToString( Var.GetByIndex(x)));
        }
        return INUPDE();
    }
    public DataTable RunQury(string search)
    {
        try
        {
            RunDB(CommandType.Text, search);
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            return tbl;
        }
        catch (SqlException ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
            conn.Close();
            return new DataTable();
        }
    }
}