using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Configuration;

public abstract class print_ecxel_report
{
    protected DBC DB = new DBC();

    protected virtual bool lsl(char op)
    {
        return false;
    }
    protected bool a()
    {
        return lsl('a');
    }
    protected bool u()
    {
        return lsl('u');
    }
    protected bool m()
    {
        return lsl('n');
    }
    protected bool m2()
    {
        return lsl('c');
    }
    protected bool q()
    {
        return lsl('d');
    }
    protected DataTable Search(string Searchtext)
    {
        try
        {
            //System.Data.SqlClient.SqlConnection.ClearPool(DB.conn);
            return DB.RunQury(Searchtext);
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
            return new DataTable();
        }
    }
}