using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace notfinal
{
    public partial class Login : Form
    {
        DBC sssw = new DBC();
        public static class ControlID
        {
            public static int TextData { get; set; }
            public static string TextData2 { get; set; }
        }
        userss user = new userss();

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Data.SqlClient.SqlConnection.ClearPool(sssw.conn);
            //System.Environment.Exit(0);
            //System.Windows.Forms.Application.Exit();
            //System.Windows.Forms.Application.ExitThread();
            //this.Close();
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(user.Finduserdata(txtb1.Text, txtb2.Text))
                {
                    ControlID.TextData = Convert.ToInt32(user.user_id.ToString());
                    
                    string type = user.type.ToString();
                    //MessageBox.Show("Welcome");
                    if (user.type.ToString() == "Admin" && f1 == true && f2 == true)
                    {(new OverLord()).Show(); ControlID.TextData2 = "LogIn"; this.Close();}
                    else if(user.type.ToString() == "User")
                     { (new Use()).Show(); ControlID.TextData2 = "LogIn"; this.Close(); }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
                    }
                }
                else 
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if(ControlID.TextData2 == "LogIn")
            {
                ControlID.TextData2 = "";
            }
            else
            {
                //ControlID.TextData2 = ""; SqlConnection.ClearPool(sssw.conn);
                System.Windows.Forms.Application.Exit();
            } 
        }
        bool f1 = false;
        bool f2 = false;
        private void panel1_Paint(object sender, EventArgs e)
        {
            f1 = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            f2 = true;
        }
    }
}
