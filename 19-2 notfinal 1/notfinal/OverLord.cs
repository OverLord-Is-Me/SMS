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

    public partial class OverLord : Form
    {
        equ eq = new equ();

        //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\hope.mdf;Integrated Security=True");
        public OverLord()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.overlord_FormClosed);
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox21.SelectedIndexChanged -= new System.EventHandler(comboBox2_SelectedIndexChanged);
            comboBox21.DataSource = eq.get_all();
            comboBox21.ValueMember = "equ_id";
            comboBox21.DisplayMember = "equ_type_id";
            comboBox21.SelectedIndexChanged += new System.EventHandler(comboBox2_SelectedIndexChanged);
        }

        private void OverLord_Load(object sender, EventArgs e)
        {
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.overlord_FormClosed);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void overlord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
              MessageBox.Show(eq.Addequ(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox7.Text, textBox8.Text,
                    textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text,
                    textBox16.Text, textBox17.Text, textBox18.Text));

                dataGridView1.DataSource = eq.get_all();
                comboBox21.SelectedIndexChanged -= new System.EventHandler(comboBox2_SelectedIndexChanged);
                comboBox21.DataSource = eq.get_all();
                comboBox21.ValueMember = "equ_id";
                comboBox21.DisplayMember = "equ_type_id";
                comboBox21.SelectedIndexChanged += new System.EventHandler(comboBox2_SelectedIndexChanged);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dee = eq.Searchequ22(Convert.ToInt32(comboBox21.SelectedValue));
            if (dee.Rows.Count > 0)
            {
                dataGridequ1.DataSource = dee;
                textBox1.Text = dataGridequ1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridequ1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridequ1.CurrentRow.Cells[3].Value.ToString();
                //string[] num2 = System.Text.RegularExpressions.Regex.Split(textBox3.Text, "<#>");
                textBox4.Text = dataGridequ1.CurrentRow.Cells[0].Value.ToString();
                //textBox5.Text = num2[1];
                textBox6.Text = dataGridequ1.CurrentRow.Cells[4].Value.ToString();
                textBox7.Text = dataGridequ1.CurrentRow.Cells[5].Value.ToString();
                textBox8.Text = dataGridequ1.CurrentRow.Cells[6].Value.ToString();
                textBox9.Text = dataGridequ1.CurrentRow.Cells[7].Value.ToString();
                textBox10.Text = dataGridequ1.CurrentRow.Cells[8].Value.ToString();
                textBox11.Text = dataGridequ1.CurrentRow.Cells[9].Value.ToString();
                textBox12.Text = dataGridequ1.CurrentRow.Cells[10].Value.ToString();
                textBox13.Text = dataGridequ1.CurrentRow.Cells[11].Value.ToString();
                textBox14.Text = dataGridequ1.CurrentRow.Cells[12].Value.ToString();
                textBox15.Text = dataGridequ1.CurrentRow.Cells[13].Value.ToString();
                textBox16.Text = dataGridequ1.CurrentRow.Cells[14].Value.ToString();
                textBox17.Text = dataGridequ1.CurrentRow.Cells[15].Value.ToString();
                textBox18.Text = dataGridequ1.CurrentRow.Cells[16].Value.ToString();
                
                //lbl_belt.Text = dataGridequ1.CurrentRow.Cells[14].Value.ToString();
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maintain ma = new maintain();
            MessageBox.Show(ma.add_new_eq_hu(Convert.ToInt32(comboBox21.SelectedValue)));
            dataGridView1.DataSource = ma.get_all();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maintain ma = new maintain();
            MessageBox.Show(ma.add_new_eq_chk(Convert.ToInt32(comboBox21.SelectedValue)));
            dataGridView1.DataSource = ma.get_all();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maintain ma = new maintain();
            MessageBox.Show(ma.add_new_eq_per(Convert.ToInt32(comboBox21.SelectedValue), Convert.ToInt32(textBox4.Text)));
            dataGridView1.DataSource = ma.get_all();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hope.mdf;Integrated Security=True");
                conn.Open();
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "SQL Server database backup files|*.bak";
                sd.Title = "Create Database Backup";
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    string sqlStmt = string.Format("backup database [" + System.Windows.Forms.Application.StartupPath + "\\hope.mdf] to disk='{0}'", sd.FileName);
                    using (SqlCommand bu2 = new SqlCommand(sqlStmt, conn))
                    {
                        bu2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Backup Created Sucessfully");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "SQL SERVER database backup files|*.bak";
                dlg.Title = "Database restore";
                SqlConnection.ClearAllPools();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\hope.mdf;Integrated Security=True");
                    con.Open();
                    string sqlStmt2 = string.Format("USE MASTER ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\hope.mdf] SET MULTI_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                    bu2.ExecuteNonQuery();
                    //string sqlStmt2 = "USE MASTER RESTORE DATABASE [hope] FROM DISK = '" + dlg.FileName + "' WITH MOVE 'DataFileLogicalName' TO 'C:\\DATA\\[hope.mdf]',MOVE 'LogFileLogicalName' TO 'C:\\DATA\\[hope.ldf]',REPLACE--Needed if database [hope] already exists";wwwwww WITH MOVE 'hope' TO 'D:\\hope.mdf',MOVE 'hope_log' TO 'D:\\hope.ldf',,REPLACE--Needed if database [hope] already exists
                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\hope.mdf] FROM DISK = '" + dlg.FileName + "'";
                    //string sqlStmt3 = "USE MASTER RESTORE DATABASE [hope] FROM DISK = '" + dlg.FileName + "' WITH REPLACE;";
                    SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                    bu3.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("USE MASTER ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\hope.mdf] SET MULTI_USER");
                    SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
                    bu4.ExecuteNonQuery();

                    MessageBox.Show("Database Restoration Finished successefully");
                    con.Close();
                    //btn_notf_Click(sender, e);

                    maintain ma = new maintain();
                    comboBox21.DataSource = ma.get_them_all("equ");
                    comboBox21.DisplayMember = "equ_type_id";
                    comboBox21.ValueMember = "equ_id";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
