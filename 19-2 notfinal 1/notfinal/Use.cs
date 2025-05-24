using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Imaging;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Windows.Forms.DataVisualization.Charting;

namespace notfinal
{
    public partial class Use : Form
    {

        #region Page codes
        int id = Login.ControlID.TextData;
        string id_string = Convert.ToString(Login.ControlID.TextData);
        filter fl = new filter();
        equ eq = new equ();
        fuel fu = new fuel();
        maintain ma = new maintain();
        oil oi = new oil();
        worker wo = new worker();
        work_sal_mob worksal = new work_sal_mob();
        equ_work_h equ_work = new equ_work_h();
        List<CheckBox> CheckBoxes = new List<CheckBox>();
        List<CheckBox> CheckBoxes2 = new List<CheckBox>();
        int dea = 0;
        int[] report_iid;
        pop1 uu = new pop1();
        public static class ControlID22
        {
            public static int TextData22 { get; set; }
            public static string info { get; set; }
            public static string idd { get; set; }
            public static decimal hours { get; set; }
            public static string cancel { get; set; }
        }
        public Use()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.use_FormClosed);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Use_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopeDataSet.filter' table. You can move, or remove it, as needed.
            this.filterTableAdapter.Fill(this.hopeDataSet.filter);
            // TODO: This line of code loads data into the 'hopeDataSet.oil' table. You can move, or remove it, as needed.
            this.oilTableAdapter.Fill(this.hopeDataSet.oil);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0,1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl7.Appearance = TabAppearance.FlatButtons;
            tabControl7.ItemSize = new Size(0, 1);
            tabControl7.SizeMode = TabSizeMode.Fixed;
            tabControl8.Appearance = TabAppearance.FlatButtons;
            tabControl8.ItemSize = new Size(0, 1);
            tabControl8.SizeMode = TabSizeMode.Fixed;

            

            // TODO: This line of code loads data into the 'hopeDataSet.worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.hopeDataSet.worker);
            // TODO: This line of code loads data into the 'hopeDataSet.equ' table. You can move, or remove it, as needed.
            this.equTableAdapter.Fill(this.hopeDataSet.equ);
            btn_notf_Click(sender, e);

            #region MyRegion
            fu.round_pic(picreport);
            fu.round_pic(pictureBox2);
            fu.round_pic(pictureBox3);
            fu.round_pic(pictureBox22);
            fu.round_pic(pictureBox23);
            fu.round_pic(pictureBox24);

            fu.round_pic(picoil);
            fu.round_pic(pichours);
            fu.round_pic(picfuel);
            fu.round_pic(picfilter);
            fu.round_pic(pictureBox1);
            fu.round_pic(pictureBox11);
            fu.round_pic(pictureBox10);
            //eq.get_all_oils();
            //string bb = eq.mac();
            combo_equ_show.SelectedIndexChanged -= new System.EventHandler(combo_equ_show_SelectedIndexChanged);
            comb_add_hours.SelectedIndexChanged -= new System.EventHandler(comb_add_hours_SelectedIndexChanged);
            comb_prev_main1.SelectedIndexChanged -= new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
            comb_CP_main_equ.SelectedIndexChanged -= new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
            combo_cor_equ.SelectedIndexChanged -= new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
            combo_oil_ins.SelectedIndexChanged -= new System.EventHandler(combo_oil_ins_SelectedIndexChanged);
            comb_oil_del_equ.SelectedIndexChanged -= new System.EventHandler(comb_oil_del_equ_SelectedIndexChanged);
            comb_fuel_ins_equ.SelectedIndexChanged -= new System.EventHandler(comb_fuel_ins_equ_SelectedIndexChanged);
            comb_fuel_del_equ.SelectedIndexChanged -= new System.EventHandler(comb_fuel_del_equ_SelectedIndexChanged);
            comb_flt_del_equ.SelectedIndexChanged -= new System.EventHandler(comb_flt_del_equ_SelectedIndexChanged);
            combo_filter_equ_ins.SelectedIndexChanged -= new System.EventHandler(combo_filter_equ_ins_SelectedIndexChanged);
            combo_oil_rep.SelectedIndexChanged -= new System.EventHandler(combo_oil_rep_SelectedIndexChanged);
            combo_oil_rep.SelectedIndexChanged -= new System.EventHandler(comboBox4_SelectedIndexChanged);
            comboBox6.SelectedIndexChanged -= new System.EventHandler(comboBox6_SelectedIndexChanged);
            comboBox9.SelectedIndexChanged -= new System.EventHandler(comboBox9_SelectedIndexChanged);
            comboBox4.SelectedIndexChanged -= new System.EventHandler(comboBox4_SelectedIndexChanged);
            refre(combo_equ_show);
            refre(comb_add_hours);
            refre(comb_prev_main1);
            refre(comb_CP_main_equ);
            refre(combo_cor_equ);
            refre(combo_oil_ins);
            refre(comb_oil_del_equ);
            refre(comb_fuel_ins_equ);
            refre(comb_fuel_del_equ);
            refre(comb_flt_del_equ);
            refre(combo_filter_equ_ins);
            refre(com_report);
            refre(comboBox1);
            refre(combo_use);
            refre(combo_oil_rep);
            refre(comboBox4);
            refre(comboBox6);
            refre(comboBox9);
            comboBox4.SelectedIndexChanged += new System.EventHandler(comboBox4_SelectedIndexChanged);
            comboBox9.SelectedIndexChanged += new System.EventHandler(comboBox9_SelectedIndexChanged);
            comboBox6.SelectedIndexChanged += new System.EventHandler(comboBox6_SelectedIndexChanged);
            combo_oil_rep.SelectedIndexChanged += new System.EventHandler(comboBox4_SelectedIndexChanged);
            combo_oil_rep.SelectedIndexChanged += new System.EventHandler(combo_oil_rep_SelectedIndexChanged);
            combo_equ_show.SelectedIndexChanged += new System.EventHandler(combo_equ_show_SelectedIndexChanged);
            comb_add_hours.SelectedIndexChanged += new System.EventHandler(comb_add_hours_SelectedIndexChanged);
            comb_prev_main1.SelectedIndexChanged += new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
            comb_CP_main_equ.SelectedIndexChanged += new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
            combo_cor_equ.SelectedIndexChanged += new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
            combo_oil_ins.SelectedIndexChanged += new System.EventHandler(combo_oil_ins_SelectedIndexChanged);
            comb_oil_del_equ.SelectedIndexChanged += new System.EventHandler(comb_oil_del_equ_SelectedIndexChanged);
            comb_fuel_ins_equ.SelectedIndexChanged += new System.EventHandler(comb_fuel_ins_equ_SelectedIndexChanged);
            comb_fuel_del_equ.SelectedIndexChanged += new System.EventHandler(comb_fuel_del_equ_SelectedIndexChanged);
            comb_flt_del_equ.SelectedIndexChanged += new System.EventHandler(comb_flt_del_equ_SelectedIndexChanged);
            combo_filter_equ_ins.SelectedIndexChanged += new System.EventHandler(combo_filter_equ_ins_SelectedIndexChanged);
            combo_labor_report.SelectedIndex = -1;
            //combo_equ_show.SelectedIndex = -1;
            //comb_add_hours.SelectedIndex = -1;
            //comb_prev_main1.SelectedIndex = -1;
            //comb_CP_main_equ.SelectedIndex = -1;
            //combo_cor_equ.SelectedIndex = -1;
            //combo_oil_ins.SelectedIndex = -1;
            //comb_oil_del_equ.SelectedIndex = -1;
            //comb_fuel_ins_equ.SelectedIndex = -1;
            //comb_fuel_del_equ.SelectedIndex = -1;
            //combo_laboe_upd.SelectedIndex = -1;
            //combo_filter_equ_ins.SelectedIndex = -1;
            //comb_flt_del_equ.SelectedIndex = -1; 
            #endregion

            DataTable er = oi.Find_oil_show_Catalogue_Equivalent(-99);
            var qd = new AutoCompleteStringCollection();
            for (int i =0; i < er.Rows.Count; i++)
            {
                qd.Add(er.Rows[i][2].ToString());
            }
            textBox7.AutoCompleteCustomSource = qd;
            textBox7.AutoCompleteSource = AutoCompleteSource.CustomSource;




            DataTable er2 = fl.get_all_cata2222();
            var qd2 = new AutoCompleteStringCollection();
            for (int i = 0; i < er2.Rows.Count; i++)
            {
                qd2.Add(er2.Rows[i][2].ToString());
            }
            txtfilter1.AutoCompleteCustomSource = qd2;
            txtfilter1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            

        }
        private void use_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Data.SqlClient.SqlConnection.ClearPool(sssw.conn);
            Application.Exit();
        }
        public void refre(ComboBox cm)
        {
            DataTable dd = eq.gettt2();
            cm.DataSource = null;
            cm.DataSource = dd;
            cm.DisplayMember = "equ_type_id";
            cm.ValueMember = "equ_id";
            cm.SelectedIndex = -1;       
        }
        #endregion
        #region pictureBoxs
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 0; tabControl1.SelectedIndex = 3;
        }
        private void picoil_Click(object sender, EventArgs e)
        {
            tabControl8.SelectedIndex = 0; tabControl1.SelectedIndex = 5;
        }
        private void picfuel_Click(object sender, EventArgs e)
        {
            tabControl8.SelectedIndex = 1; tabControl1.SelectedIndex = 5;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            tabControl8.SelectedIndex = 2; tabControl1.SelectedIndex = 5;
        }
        private void picfilter_Click(object sender, EventArgs e)
        {
            tabControl8.SelectedIndex = 3; tabControl1.SelectedIndex = 5;
            rdio_filt_new.Checked = true;
            rdio_filt_new_CheckedChanged(sender, e);
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            tabControl7.SelectedIndex = 0; tabControl1.SelectedIndex = 4;
            if (btn_del_labor.Visible != true)
            {
                btn_add_labor_Click(sender, e);
            }
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            tabControl7.SelectedIndex = 1; tabControl1.SelectedIndex = 4;
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            tabControl7.SelectedIndex = 2; tabControl1.SelectedIndex = 4;
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 1; tabControl1.SelectedIndex = 3;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 3; tabControl1.SelectedIndex = 3;
        }
        #endregion
        #region KeyPress
        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
        private void txt_oil_ins3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //If you want, you can allow decimal(decimal) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //If you want, you can allow decimal(decimal) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
          }
        #endregion
        #region Inserts delets and updates
        private void btnhours_Click(object sender, EventArgs e)
        {
            if (txt_input_hours.Text == "") 
            {
                MessageBox.Show("Please Enter Valid Hours Counter"); return; 
            }
            if (date_add_hours.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comb_add_hours.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }
            if (Convert.ToInt32(lbl_hours2.Text) >= Convert.ToInt32(txt_input_hours.Text))
            {
                MessageBox.Show("Can Not Enter Hours Counter Smaller than Equipment Hours Counter"); return;
            }
            try
            {
                int tot = Convert.ToInt32(txt_input_hours.Text) - Convert.ToInt32(lbl_hours2.Text);
                string ss = equ_work.Add_equ_work_h(Convert.ToInt32(comb_add_hours.SelectedValue), tot, date_add_hours.Value, Convert.ToInt32(txt_input_hours.Text));
                //dataGridView3.DataSource = equ_work.test;
                if (ss == "Success")
                {
                    string ss2 = ma.Modify_hours(Convert.ToInt32(lbl_main_id.Text), Convert.ToInt32(comb_add_hours.SelectedValue), date_add_hours.Value.Date);
                    if (ss2 != "Failed")
                    {
                        MessageBox.Show(ss2);
                        comb_add_hours_SelectedIndexChanged(sender, e);
                        txt_input_hours.Text = "";
                        lb_mod_2.Text = "no";
                    }
                    else
                    {
                        MessageBox.Show(ss2);
                       // equ_work.del_equ_work_h();
                    }
                }
                else { MessageBox.Show(ss); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n Please Enter valid number V38"); return;
            }
        }
        private void btn_oil_ins_equ_Click(object sender, EventArgs e)
        {
            try 
            {
                string b = combo_equ_show.SelectedValue.ToString();
                lb_mod_1.Text = "no";
                tabControl8.SelectedIndex = 0; tabControl1.SelectedIndex = 5;
                radioButton3.Checked = true;

                txt_oil_upd8.Text = id_string; where.Text = "info";
                combo_oil_ins.SelectedValue = b;
                combo_oil_ins_SelectedIndexChanged(sender, e);
                rdio_oil_cata.Checked = true;
                btn_oil_ins.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_flt_ins_equ_Click(object sender, EventArgs e)
        {
            try 
            {
                string b = combo_equ_show.SelectedValue.ToString();
                lb_mod_1.Text = "no";
                tabControl8.SelectedIndex = 3; tabControl1.SelectedIndex = 5;
                radioButton8.Checked = true;
                txtfilter5.Text = id_string;
                txt_filt_upd8.Text = id_string;
                combo_filter_equ_ins.SelectedValue = b;
                combo_filter_equ_ins_SelectedIndexChanged(sender, e);
                rdio_filt_new.Checked = true;
                label22.Text = "info";
                         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_fuel_ins_equ_Click(object sender, EventArgs e)
        {
            try
            {
                string b = combo_equ_show.SelectedValue.ToString();
                lb_mod_1.Text = "no";
                tabControl8.SelectedIndex = 1; tabControl1.SelectedIndex = 5;
                radioButton2.Checked = true;
                radioButton11.Checked = true; label26.Text = "info";
                txt_fuel_ins5.Text = id_string;
                txt_fuel_upd8.Text = id_string;
                comb_fuel_ins_equ.SelectedValue = b; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_flt_upd_equ_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(dataGridequ2.Rows[dataGridequ2.SelectedCells[0].RowIndex].Cells["filt_id"].Value);
                string b = Convert.ToString(dataGridequ2.Rows[dataGridequ2.SelectedCells[1].RowIndex].Cells["equ_id"].Value);
                lb_mod_1.Text = "no"; label22.Text = "info";
                tabControl8.SelectedIndex = 3; tabControl1.SelectedIndex = 5;
                radioButton7.Checked = true; lbl_what_filter.Text = "Edit Catalogue Data";
                comb_flt_del_equ.SelectedValue = b;
                comb_flt_del_equ_SelectedIndexChanged(sender, e);
                comb_flt_del.SelectedValue = a;
                comb_flt_del_SelectedIndexChanged(sender, e);
                btn_flt_sho_Click(sender, e);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_oil_upd_equ_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(dataGridequ4.Rows[dataGridequ4.SelectedCells[0].RowIndex].Cells["oil_id"].Value);
                string b = Convert.ToString(dataGridequ4.Rows[dataGridequ4.SelectedCells[1].RowIndex].Cells["equ_id"].Value);
                string c = Convert.ToString(dataGridequ4.Rows[dataGridequ4.SelectedCells[2].RowIndex].Cells["oil_type"].Value);
                lb_mod_1.Text = "no"; where.Text = "info";
                tabControl8.SelectedIndex = 0; tabControl1.SelectedIndex = 5;
                radioButton4.Checked = true;
                //comb_oil_del_equ.Enabled = false;
                comb_oil_del_equ.SelectedValue = b;
                comb_oil_del.DataSource =null;

                comb_oil_del.Items.Add(c);


                comb_oil_del.Text = c;
                //comb_oil_del.SelectedText = c; 
                txt_oil_upd1.Text = a;
                comb_oil_del.Enabled = false;
                btn_oil_sho_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_fuel_upd_equ_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(dataGridequ3.Rows[dataGridequ3.SelectedCells[0].RowIndex].Cells["fuel_id"].Value);
                string b = Convert.ToString(dataGridequ3.Rows[dataGridequ3.SelectedCells[1].RowIndex].Cells["equ_id"].Value);
                lb_mod_1.Text = "no"; label26.Text = "info";
                tabControl8.SelectedIndex = 1; tabControl1.SelectedIndex = 5;
                radioButton1.Checked = true;
                comb_fuel_del_equ.SelectedValue = b;

                comb_fuel_del.SelectedValue = a;
                btn_fuel_sho_Click(sender, e);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_oil_dlt_equ2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete This Oil Data?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = Convert.ToString(dataGridequ4.Rows[dataGridequ4.SelectedCells[0].RowIndex].Cells["oil_id"].Value);
                MessageBox.Show(oi.deloil(Convert.ToInt32(a)));
                dataGridequ4.DataSource = oi.Find_oil_show_Catalogue_Equivalent(Convert.ToInt32((combo_equ_show.SelectedValue)));
                combo_equ_show_SelectedIndexChanged(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void btn_flt_dlt_equ_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete This Filter Data?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = Convert.ToString(dataGridequ2.Rows[dataGridequ2.SelectedCells[0].RowIndex].Cells["filt_id"].Value);
                MessageBox.Show(fl.delflt(Convert.ToInt32(a)));
                dataGridequ2.DataSource = fl.Find_filt_show_data(Convert.ToInt32((combo_equ_show.SelectedValue)));
                combo_equ_show_SelectedIndexChanged(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void btn_fuel_dlt_equ_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete This Fuel Data?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = Convert.ToString(dataGridequ3.Rows[dataGridequ3.SelectedCells[0].RowIndex].Cells["fuel_id"].Value);
                MessageBox.Show(fu.delfuel(Convert.ToInt32(a)));
                dataGridequ3.DataSource = fu.Find_fuel_show_data(Convert.ToInt32((combo_equ_show.SelectedValue)));
                combo_equ_show_SelectedIndexChanged(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
       
      
     
       
   
      
       
       
        private void btn_fuel_del_Click(object sender, EventArgs e)
        {
            if (comb_fuel_del.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose Fuel Type First"); return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Fuel Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(fu.delfuel(Convert.ToInt32(comb_fuel_del.SelectedValue)));
                comb_fuel_del_equ_SelectedIndexChanged(sender, e);
            }
            if (dialogResult == DialogResult.No) { }
        }
       
        private void btn_fuel_sho_Click(object sender, EventArgs e)
        {
            if (comb_fuel_del.SelectedIndex != -1 && comb_fuel_del_equ.SelectedIndex != -1)
            {
                pnl_filer_fuel_del.Enabled = true;
                fu.Findfuel(Convert.ToInt32(comb_fuel_del.SelectedValue));
                txt_fuel_upd1.Text = fu.fuel_id.ToString();
                //txt_fuel_upd2.Text = fu.equ_id.ToString();
                txt_fuel_upd4.Text = fu.fuel_name.ToString();
                txt_fuel_upd5.Text = fu.fuel_cap.ToString();
                txt_fuel_upd6.Text = fu.fuel_cost.ToString();
                date_fuel_upd.Value = fu.fuel_date;
                textBox1.Text = fu.main_hours.ToString();
                textBox2.Text = fu.fuel_active.ToString();
            }
            else
            {
                pnl_filer_fuel_del.Enabled = false;
                txt_fuel_upd1.Text = "";
                txt_fuel_upd2.Text = "";
                comb_fuel_del.SelectedIndex = -1;
                txt_fuel_upd4.Text = "0";
                txt_fuel_upd5.Text = "";
                txt_fuel_upd6.Text = "";
            }
        }
     
        
        private void btn_fuel_upd_Click(object sender, EventArgs e)
        {
            if (date_fuel_upd.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comb_fuel_del.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }
            if (comb_fuel_del_equ.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Fuel Type"); return;
            }
            int ii = ma.Find_work_hours_int(Convert.ToInt32(comb_fuel_del_equ.SelectedValue));
            string a =fu.updatefuel(Convert.ToInt32(txt_fuel_upd1.Text),
                    Convert.ToInt32(comb_fuel_del_equ.SelectedValue), comb_fuel_del.Text,
             ii.ToString(), Convert.ToDecimal(txt_fuel_upd5.Text),
             Convert.ToInt32(txt_fuel_upd6.Text), date_fuel_upd.Value, id, ii, textBox2.Text, 0);


            if (a == "Success")
            {
                MessageBox.Show(a);
                comb_fuel_del.SelectedIndexChanged -= new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
                comb_fuel_del.DataSource = null;
                comb_fuel_del.SelectedIndexChanged += new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
                comb_fuel_del_equ_SelectedIndexChanged(sender, e);
                txt_fuel_upd4.Text = "0";
                if (label26.Text == "Report")
                {
                    label26.Text = "";
                    tabControl6.SelectedIndex = 4; tabControl1.SelectedIndex = 3;
                    pictureBox7_Click(sender, e);
                }
                if (label26.Text == "info")
                {
                    //combo_equ_show.SelectedIndex = comb_fuel_del_equ.SelectedIndex;
                    label26.Text = "";
                    tabControl1.SelectedIndex = 1;
                    combo_equ_show_SelectedIndexChanged(sender, e);
                }

            }
            else { MessageBox.Show("Please recheck your data V1"); }
        }
        private void btn_labor_ins_Click(object sender, EventArgs e)
        {
            if (txt_wrker_name.Text != "" && txt_salary.Text != "" && txt_wrk_hrs_ins.Text != "")
            {
                string asd = wo.Add_worker(txt_wrker_name.Text, Convert.ToInt32(txt_salary.Text), Convert.ToInt32(txt_wrk_hrs_ins.Text));
                if (asd == "Success")
                {
                    MessageBox.Show(asd);
                    txt_wrker_name.Text = "";
                    txt_salary.Text = "";
                    txt_wrk_hrs_ins.Text = "";
                    DataTable asdq = wo.bring_labor_names();
                    combo_laboe_upd.SelectedIndexChanged -= new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                    combo_laboe_upd.DataSource = asdq;
                    combo_laboe_upd.ValueMember = "worker_id";
                    combo_laboe_upd.DisplayMember = "worker_name";
                    combo_laboe_upd.SelectedIndexChanged += new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                    combo_labor_report.DataSource = asdq;
                    combo_labor_report.ValueMember = "worker_id";
                    combo_labor_report.DisplayMember = "worker_name";
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Data V39");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Data V40");
            }

        }
        private void btn_labor_del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Technician?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sdf = wo.del_worker(Convert.ToInt32(combo_laboe_upd.SelectedValue));
                if (sdf == "Success")
                {
                    dataGridView2.DataSource = new DataTable();
                    MessageBox.Show(sdf);
                    DataTable asdq = wo.bring_labor_names();
                    int y = asdq.Rows.Count;
                    if (y == 0)
                    {
                        combo_laboe_upd.SelectedIndexChanged -= new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                        combo_laboe_upd.DataSource = null;
                        combo_laboe_upd.SelectedIndex = -1;
                        combo_laboe_upd.Text = "No Data";
                        combo_laboe_upd.SelectedValue = 0;
                        combo_laboe_upd.SelectedIndexChanged += new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                    }
                    else
                    {
                        combo_laboe_upd.SelectedIndexChanged -= new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                        combo_laboe_upd.DataSource = asdq;
                        combo_laboe_upd.ValueMember = "worker_id";
                        combo_laboe_upd.DisplayMember = "worker_name";
                        combo_labor_report.DataSource = asdq;
                        combo_labor_report.ValueMember = "worker_id";
                        combo_labor_report.DisplayMember = "worker_name";
                        combo_laboe_upd.SelectedIndexChanged += new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
        private void btn_labor_upd_Click(object sender, EventArgs e)
        {
            string qwe = wo.update_worker(Convert.ToInt32(combo_laboe_upd.SelectedValue.ToString()), txt_lp_up_name.Text, Convert.ToInt32(txt_lp_up_salary.Text), Convert.ToInt32(txt_lp_up_hours.Text));
            if (qwe == "Success")
            {
                dataGridView2.DataSource = new DataTable();
                //if you want to update all past name records in all Databases
                wo.bring_labor_data(Convert.ToInt32(combo_laboe_upd.SelectedValue));
                if (wo.worker_name.ToString() != txt_lp_up_name.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to update Labor Name in all Databases with the new modifications?", "Update The Name In All Databases", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataTable ds = worksal.update_work_reprot(Convert.ToInt32(label38.Text));
                        string ad = "Done";
                        for (int x = 0; x < ds.Rows.Count; x++)
                        {
                            int a1 = Convert.ToInt32(ds.Rows[x][0].ToString());
                            string ad2 = worksal.Update_work_reprot(a1, txt_lp_up_name.Text);
                            if (ad2 == "Failed")
                            { ad = "Failed"; }
                        }
                        if (ad == "Success")
                        {
                            txt_lp_up_name.Text = "";
                            txt_lp_up_salary.Text = "";
                            txt_lp_up_hours.Text = "";
                            txt_lp_up_name.Visible = false;
                            txt_lp_up_salary.Visible = false;
                            txt_lp_up_hours.Visible = false;
                            txt_lp_up_name.Enabled = false;
                            txt_lp_up_salary.Enabled = false;
                            txt_lp_up_hours.Enabled = false;
                            btn_labor_upd.Enabled = false;
                            btn_labor_upd.Visible = false;
                            dataGridView2.Visible = false;
                            label74.Visible = false;
                            // refresh combobox 1 for labors name after update
                            DataTable asdq = wo.bring_labor_names();
                            combo_laboe_upd.SelectedIndexChanged -= new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                            combo_laboe_upd.DataSource = asdq;
                            combo_laboe_upd.ValueMember = "worker_id";
                            combo_laboe_upd.DisplayMember = "worker_name";
                            combo_laboe_upd.SelectedIndexChanged += new System.EventHandler(combo_laboe_upd_SelectedIndexChanged);
                            // refresh combobox 2 for labors name after update  
                            combo_labor_report.DataSource = asdq;
                            combo_labor_report.ValueMember = "worker_id";
                            combo_labor_report.DisplayMember = "worker_name";
                        }
                        else
                        {
                            MessageBox.Show(" Name Has Been Changed \n [Failed] to update Labor Name in works Database");
                            return;
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                MessageBox.Show(qwe);
            }
            else
            {
                MessageBox.Show("Please Enter Valid Data V41");
            }
        }
        #endregion
        #region Comboboxs
      
     
      
      
        private void comb_fuel_del_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btn_fuel_sho_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_fuel_upd1.Text = "";
                txt_fuel_upd2.Text = "";
                comb_fuel_del.SelectedIndex = -1;
                date_fuel_upd.Value = DateTime.Now;
                txt_fuel_upd4.Text = "0";
                txt_fuel_upd5.Text = "";
                txt_fuel_upd6.Text = "";
                pnl_filer_fuel_del.Enabled = false;
            }
        }
        private void combo_equ_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_equ_show.SelectedIndex == -1 || combo_equ_show.SelectedValue.ToString() == "{System.Data.DataRowView}")
            {
                comb_prv_sq.SelectedIndexChanged -= new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                comb_prv_sq.DataSource = new DataTable();
                comb_prv_sq.SelectedIndex = -1;
                //comb_prv_sq.Text = "--No Data--";
                comb_prv_sq.Enabled = false;
                comb_prv_sq.SelectedIndexChanged += new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.SuspendLayout();
                while (tableLayoutPanel1.RowCount > 1)
                {
                    int row = tableLayoutPanel1.RowCount - 1;
                    for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                    {
                        Control c = tableLayoutPanel1.GetControlFromPosition(i, row);
                        tableLayoutPanel1.Controls.Remove(c);
                        //c.Dispose();
                    }
                    tableLayoutPanel1.RowStyles.RemoveAt(row);
                    tableLayoutPanel1.RowCount--;
                }
                tableLayoutPanel1.ResumeLayout(false);
                tableLayoutPanel1.PerformLayout();
                panel3.Enabled = false;
                dataGridequ1.DataSource = new DataTable();
                lbl_sn.Text ="";
                lbl_id.Text = "";
                textBox15.Text = "";
                lbl_arr.Text = "";
                label88.Text = "";
                lbl_lng.Text = "";
                lbl_high.Text = "";
                lbl_width.Text = "";
                lbl_wiegt.Text = "";
                lbl_engsn.Text = "";
                lbl_engp.Text = "";
                lbl_highidle.Text = "";
                lbl_lowidle.Text = "";
                lbl_transn.Text = "";
                lbl_tiersize.Text = "";
                lbl_eng_size.Text = "";
                lbl_ac_size.Text = "";
                lbl_mg_size.Text = "";
                btn_oil_ins_equ.Enabled = false;
                btn_flt_ins_equ.Enabled = false;
                btn_fuel_ins_equ.Enabled = false;
                dataGridequ2.DataSource = new DataTable();
                dataGridequ2.Enabled = false;
                btn_flt_upd_equ.Enabled = false;
                btn_flt_dlt_equ.Enabled = false;
                dataGridequ3.DataSource = new DataTable();
                dataGridequ3.Enabled = false;
                btn_fuel_upd_equ.Enabled = false;
                btn_fuel_dlt_equ.Enabled = false;
                dataGridequ4.DataSource = new DataTable();
                dataGridequ4.Enabled = false;
                btn_oil_upd_equ.Enabled = false;
                btn_oil_dlt_equ2.Enabled = false;

                return ;
            }
            try
            {
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.SuspendLayout();
                while (tableLayoutPanel1.RowCount > 1)
                {
                    int row = tableLayoutPanel1.RowCount - 1;
                    for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                    {
                        Control c = tableLayoutPanel1.GetControlFromPosition(i, row);
                        tableLayoutPanel1.Controls.Remove(c);
                        //c.Dispose();
                    }

                    tableLayoutPanel1.RowStyles.RemoveAt(row);
                    tableLayoutPanel1.RowCount--;
                }
                tableLayoutPanel1.ResumeLayout(false);
                tableLayoutPanel1.PerformLayout();

                comb_prv_sq.SelectedIndex = -1;
                DataTable dee = eq.Searchequ22(Convert.ToInt32(combo_equ_show.SelectedValue));
                if (dee.Rows.Count > 0)
                {
                    lb_mod_1.Text = "yes";
                    panel3.Enabled = true;
                    dataGridequ1.DataSource = dee;
                    //panel3.Visible = true;
                    dataGridequ1.Rows[0].Selected = true;
                    lbl_sn.Text = dataGridequ1.CurrentRow.Cells[1].Value.ToString();
                    lbl_id.Text = dataGridequ1.CurrentRow.Cells[2].Value.ToString();
                    string all2 = dataGridequ1.CurrentRow.Cells[3].Value.ToString();
                    string[] num2 = Regex.Split(all2, "<#>");
                    lbl_arr.Text = num2[0];
                    label88.Text = num2[1];
                    lbl_lng.Text = dataGridequ1.CurrentRow.Cells[4].Value.ToString() + " m";
                    lbl_high.Text = dataGridequ1.CurrentRow.Cells[5].Value.ToString() + " m";
                    lbl_width.Text = dataGridequ1.CurrentRow.Cells[6].Value.ToString() + " m";
                    lbl_wiegt.Text = dataGridequ1.CurrentRow.Cells[7].Value.ToString() + " ton";
                    lbl_engsn.Text = dataGridequ1.CurrentRow.Cells[8].Value.ToString();
                    lbl_engp.Text = dataGridequ1.CurrentRow.Cells[9].Value.ToString() + " HP";
                    lbl_highidle.Text = dataGridequ1.CurrentRow.Cells[10].Value.ToString() + " rpm";
                    lbl_lowidle.Text = dataGridequ1.CurrentRow.Cells[11].Value.ToString() + " rpm";
                    lbl_transn.Text = dataGridequ1.CurrentRow.Cells[16].Value.ToString();
                    lbl_tiersize.Text = dataGridequ1.CurrentRow.Cells[15].Value.ToString();
                    //lbl_belt.Text = dataGridequ1.CurrentRow.Cells[14].Value.ToString();
                    lbl_eng_size.Text = dataGridequ1.CurrentRow.Cells[12].Value.ToString();
                    lbl_ac_size.Text = dataGridequ1.CurrentRow.Cells[13].Value.ToString();
                    lbl_mg_size.Text = dataGridequ1.CurrentRow.Cells[14].Value.ToString();
                    btn_oil_ins_equ.Enabled = true;
                    btn_flt_ins_equ.Enabled = true;
                    btn_fuel_ins_equ.Enabled = true;

                    DataTable dee1 = fl.Find_filt_show_data_equ(Convert.ToInt32((combo_equ_show.SelectedValue)));
                    if (dee1.Rows.Count > 0)
                    {
                        dataGridequ2.Enabled = true;
                        btn_flt_upd_equ.Enabled = true;
                        btn_flt_dlt_equ.Enabled = true;
                        dataGridequ2.DataSource = dee1;
                        dataGridequ2.Columns[0].Visible = false;
                        dataGridequ2.Columns[1].Visible = false;
                        dataGridequ2.Columns[2].HeaderText = "Filter Type";
                        dataGridequ2.Columns[3].HeaderText = "Active OEM Part No.";
                        dataGridequ2.Columns[4].HeaderText = "Filter Quantity";
                        dataGridequ2.Columns[5].Visible = false; /*HeaderText = "Filter Cost";*/
                        dataGridequ2.Columns[6].HeaderText = "Posting Date";
                        dataGridequ2.Columns[7].Visible = false;
                        dataGridequ2.Columns[8].Visible = false;
                        dataGridequ2.Columns[9].Visible = false;
                        dataGridequ2.Columns[10].Visible = false;
                        dataGridequ2.Columns[11].Visible = false;
                        dataGridequ2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                        dataGridequ2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dataGridequ2.ColumnHeadersHeight = 35;
                    }
                    else
                    {
                        dataGridequ2.DataSource = new DataTable();
                        dataGridequ2.Enabled = false;
                        btn_flt_upd_equ.Enabled = false;
                        btn_flt_dlt_equ.Enabled = false;
                    }

                    DataTable dee2 = fu.Find_fuel_show_data_equ(Convert.ToInt32((combo_equ_show.SelectedValue)));
                    if (dee2.Rows.Count > 0)
                    {
                        dataGridequ3.Enabled = true;
                        btn_fuel_upd_equ.Enabled = true;
                        btn_fuel_dlt_equ.Enabled = true;
                        dataGridequ3.DataSource = dee2;
                        dataGridequ3.Columns[0].Visible = false;
                        dataGridequ3.Columns[1].Visible = false;
                        dataGridequ3.Columns[2].HeaderText = "Fuel Type";
                        dataGridequ3.Columns[3].Visible = false;
                        dataGridequ3.Columns[4].HeaderText = "Fuel Refill Capacity";
                        dataGridequ3.Columns[5].Visible = false;
                        dataGridequ3.Columns[6].HeaderText = "Posting Date";
                        dataGridequ3.Columns[7].Visible = false;
                        dataGridequ3.Columns[8].Visible = false;
                        dataGridequ3.Columns[9].Visible = false;
                        dataGridequ3.Columns[10].Visible = false;
                        dataGridequ3.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                        dataGridequ3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dataGridequ3.ColumnHeadersHeight = 35;
                    }
                    else
                    {
                        dataGridequ3.DataSource = new DataTable();
                        dataGridequ3.Enabled = false;
                        btn_fuel_upd_equ.Enabled = false;
                        btn_fuel_dlt_equ.Enabled = false;
                    }

                    DataTable dee3 = oi.Find_oil_show_Catalogue_Equivalent(Convert.ToInt32((combo_equ_show.SelectedValue)));
                    if (dee3.Rows.Count > 0)
                    {
                        dataGridequ4.Enabled = true;
                        btn_oil_upd_equ.Enabled = true;
                        btn_oil_dlt_equ2.Enabled = true;
                        dataGridequ4.DataSource = dee3;
                        dataGridequ4.Columns[0].Visible = false;
                        dataGridequ4.Columns[1].Visible = false;
                        dataGridequ4.Columns[2].HeaderText = "Oil Type";
                        dataGridequ4.Columns[3].HeaderText = "Active Oil Name";
                        dataGridequ4.Columns[4].HeaderText = "Oil Refill Capacity";
                        dataGridequ4.Columns[5].Visible = false;
                        dataGridequ4.Columns[6].HeaderText = "Posting Date";
                        dataGridequ4.Columns[7].Visible = false;
                        dataGridequ4.Columns[8].Visible = false;
                        dataGridequ4.Columns[9].Visible = false;
                        dataGridequ4.Columns[10].Visible = false;
                        dataGridequ4.Columns[11].Visible = false;
                        dataGridequ4.Columns[12].Visible = false;
                        dataGridequ4.Columns[17].Visible = false;
                        dataGridequ4.Columns[18].Visible = false;
                        //dataGridequ4.Columns[13].HeaderText = "Oil refill capacity";
                        //dataGridequ4.Columns[14].HeaderText = "Oil Cost";
                        //dataGridequ4.Columns[15].HeaderText = "Oil Cost";
                        dataGridequ4.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                        dataGridequ4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        dataGridequ4.ColumnHeadersHeight = 35;
                    }
                    else
                    {
                        dataGridequ4.DataSource = new DataTable();
                        dataGridequ4.Enabled = false;
                        btn_oil_upd_equ.Enabled = false;
                        btn_oil_dlt_equ2.Enabled = false;
                    }


                    DataTable ss = ma.bring_all_prev_hours(Convert.ToInt32((combo_equ_show.SelectedValue)));
                    if (ss.Rows.Count > 0)
                    {
                        comb_prv_sq.SelectedIndexChanged -= new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                        comb_prv_sq.DataSource = ss;
                        comb_prv_sq.ValueMember = "main_id";
                        comb_prv_sq.DisplayMember = "main_periodnum";
                        comb_prv_sq.SelectedIndex = -1;
                        //comb_prv_sq.Text = "--select--";
                        comb_prv_sq.Enabled = true;
                        comb_prv_sq.SelectedIndexChanged += new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                    }
                    else
                    {
                        comb_prv_sq.SelectedIndexChanged -= new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                        comb_prv_sq.DataSource = new DataTable();
                        comb_prv_sq.SelectedIndex = -1;
                        //comb_prv_sq.Text = "--No Data--";
                        comb_prv_sq.Enabled = false;
                        comb_prv_sq.SelectedIndexChanged += new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comb_add_hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_add_hours.SelectedIndex == -1 || comb_add_hours.SelectedValue == null)
            {
                txt_input_hours.Text = "";
                lbl_main_id.Text = "0";
                lbl_hours2.Text = "";
                txt_add_hours_total.Text = "0";
                lbl_after.Text = "";
                lbl_prv_hrs_stage2.Text = "0";
                lbl_prv_hrs_part2.Text = "";
                lb_mod_2.Text = "yes";
                panel7.Enabled = false;
                panel28.Enabled = false;
                return;
            }
            string km_hous = "";
            if (ma.if_km(Convert.ToInt32(comb_add_hours.SelectedValue)))
            {
                label92.Text = "Add Work Kilometers";
                lbl_hours1.Text = "Current Worked Kilometers";
                label67.Text = "Working Kilometers";
                km_hous = "Kilometers";
            }
            else
            {
                label92.Text = "Add Work Hours";
                lbl_hours1.Text = "Current Worked Hours";
                label67.Text = "Working Hours";
                km_hous = "Hours";
            }
            if (ma.Find_work_hours(Convert.ToInt32(comb_add_hours.SelectedValue)))
            {
               
                lb_mod_2.Text = "yes";
                txt_input_hours.Text = "";
                lbl_main_id.Text = ma.main_id.ToString();
                ControlID22.cancel = lbl_main_id.Text;
                lbl_hours2.Text = ma.main_periodnum.ToString();
                txt_add_hours_total.Text = ma.main_periodnum.ToString();
                int x = ma.main_periodnum;// ma.find_true_hours_now(Convert.ToInt32(comb_add_hours.SelectedValue), Convert.ToInt32(lbl_hours2.Text));
                int y = ma.find_higher_period_stage_hours(Convert.ToInt32(comb_add_hours.SelectedValue), Convert.ToInt32(lbl_hours2.Text));
                int last = ma.last(Convert.ToInt32(comb_add_hours.SelectedValue));
                int hours_left = 0;
                if (last == 0)
                {
                    hours_left = y - x;
                }
                else
                {
                    hours_left = (last + Convert.ToInt32(ma.main_state_details)) - x;
                }


                if (y == 0)
                {
                    txt_add_hours_total.Text = ma.main_periodnum.ToString();
                    lbl_hours2.Text = ma.main_periodnum.ToString();
                    date_add_hours.Enabled = true;
                    btn_detais_hours.Enabled = true;
                    btnhours.Enabled = true;
                    lbl_after.Text = "No Periodic Maintenance for this Equipment";
                    txt_input_hours.Enabled = true;
                    btnhours.Enabled = true;
                    lbl_after.Text = "0";
                    lbl_prv_hrs_stage2.Text = "0";
                    lbl_prv_hrs_part2.Text = "No Periodic Maintenance for this Equipment";
                }
                else
                {
                    if(hours_left < 0)
                    {
                        string dd= Convert.ToString((hours_left * -1) +" "+  km_hous + " (late)" + "\n" + "(you need To Do Periodic Maintenance Now)");
                        lbl_after.Text = dd;
                    }
                    else
                    {
                        lbl_after.Text = Convert.ToString(hours_left + " "+ km_hous);
                    }
                    string value = ma.main_part.ToString();
                    lbl_prv_hrs_part2.Text = "";
                    string[] lines2 = Regex.Split(value, "<##>");
                    string[] lines = Regex.Split(lines2[0], "<#>");
                    foreach (string line in lines)
                    {
                        if (lbl_prv_hrs_part2.Text == "")
                        { lbl_prv_hrs_part2.Text = line; }
                        else
                        {
                            lbl_prv_hrs_part2.Text = lbl_prv_hrs_part2.Text + "\n" + line;
                        }
                    }
                    btnhours.Enabled = true;
                    btn_detais_hours.Enabled = true;
                    txt_input_hours.Enabled = true;
                    lbl_prv_hrs_part2.Visible = true;
                    date_add_hours.Enabled = true;
                }
                #region MyRegion

                //if (y != x && y > 0)
                //{

                //    //lbl_prv_hrs_stage2.Text = Convert.ToString(y);
                //    //lbl_after.Visible = true;
                //    //lowww.Visible = true;

                //    //lbl_prv_hrs_part1.Visible = true;

                //    //lbl_prv_hrs_stage1.Visible = true;
                //    //lbl_prv_hrs_stage2.Visible = true;
                //}
                //else if (y == x && y > 0)
                //{
                //    lbl_after.Text = "now";
                //    lbl_prv_hrs_part2.Text = "";
                //    lbl_prv_hrs_stage2.Text = Convert.ToString(y);
                //    string value = ma.main_part.ToString();
                //    string[] lines2 = Regex.Split(value, "<##>");
                //    string[] lines = Regex.Split(lines2[0], "<#>");
                //    foreach (string line in lines)
                //    {
                //        if (lbl_prv_hrs_part2.Text == "")
                //        { lbl_prv_hrs_part2.Text = line; }
                //        else
                //        {
                //            lbl_prv_hrs_part2.Text = lbl_prv_hrs_part2.Text + "\n" + line;
                //        }
                //    }
                //    btn_detais_hours.Enabled = true;
                //    date_add_hours.Enabled = true;
                //    btnhours.Enabled = true;
                //    txt_input_hours.Enabled = true;
                //    //lbl_after.Visible = true;
                //    //lowww.Visible = true;
                //    //lbl_prv_hrs_part1.Visible = true;
                //    lbl_prv_hrs_part2.Visible = true;
                //    //lbl_prv_hrs_stage1.Visible = true;
                //    //lbl_prv_hrs_stage2.Visible = true;
                //}

                #endregion

                panel7.Enabled = true;
                panel28.Enabled = true;
            }
            else
            {
                txt_input_hours.Text = "";
                lbl_main_id.Text = "0";
                lbl_hours2.Text = "No "+ km_hous + " Counter For this Equipment";
                txt_add_hours_total.Text = "0";
                lbl_after.Text = "No " + km_hous + " Counter For this Equipment";
                lbl_prv_hrs_stage2.Text = "0"; 
                lbl_prv_hrs_part2.Text = "No Periodic maintenance for this Equipment";
                lb_mod_2.Text = "yes";
                panel7.Enabled = false;
                panel28.Enabled = false;
            }
        }
        private void comb_prev_main1_SelectedIndexChanged(object sender, EventArgs e)
        {
            date_prv.Value = DateTime.Now;
            //label102.Visible = false;
            //label101.Visible = false;
            txt_pre_0_now_hours.Text = "";
            txt_pre_4_parts.Visible = false;
            txt_pre_4_parts.Text = "";
            txt_pre_4_parts.Enabled = false;
            //btn_del_labor.Enabled = false; 
            btn_del_labor.Visible = false; 
           // panel2.Enabled = false;
            btn_bring_to_upd.Enabled = false;
            btn_bring_to_upd.Visible = false;
            pnl_labor.Visible = false;
            lbl_state_prev.Text = "a";
            flow_labor.Controls.Clear();
            if (btn_del_labor.Visible != true)
            {
                btn_add_labor_Click(sender, e);
            }
            txt_pre_3_hours.Text = "";
            txt_pre_6_cost.Text = ""; 
            txt_duration.Text = "";
            txt_pre_7_det.Text = "";
            lbl_prv3.Visible = false;
            flowLayoutPanel2.Controls.Clear();
            panel5.Visible = false;
            dat_grid_prev1.DataSource = new DataTable();
            dat_grid_prev1.Visible = false;
            string woo = "Hours";
            if(ma.if_km(Convert.ToInt32(comb_prev_main1.SelectedValue)))
            {
                woo = "Kilometers";
                
            }
            lbl_hours_ins1.Text = "Current Working "+ woo;
            if (ma.Find_work_hours(Convert.ToInt32(comb_prev_main1.SelectedValue)))
            {
                lbl_hours_ins2.Text = ma.main_periodnum.ToString();
                btn_pre_upd_Click(sender, e);
                #region MyRegion
                // int x = ma.find_true_hours_now(Convert.ToInt32(comb_prev_main1.SelectedValue), Convert.ToInt32(lbl_hours_ins2.Text));
                // int y = ma.find_higher_period_stage_hours(Convert.ToInt32(comb_prev_main1.SelectedValue), Convert.ToInt32(lbl_hours_ins2.Text));
                if (false /*y != x && y > 0*/)
                {
                    lbl_hours_ins1.Visible = true;
                    lbl_hours_ins2.Visible = true;
                    txt_pre_2_type_number.Text = ma.main_type.ToString();
                    //lbl_prv_after.Text = Convert.ToString(y - x + " Hours");
                    //lbl_prv_hrs_stage4.Text = Convert.ToString(y);
                    lbl_prv_after.Visible = true;
                    lowww_prv.Visible = true;
                   // lbl_prv_hrs_stage3.Visible = true;
                   // lbl_prv_hrs_stage4.Visible = true;
                    label100.Visible = false;
                    lbl_prv_hrs_stage3.Text = "Next Periodic Maintenance Stage";
                }
                else if (false /*y == x && y > 0*/)
                {
                    //panel2.Enabled = true;
                    flowLayoutPanel2.Controls.Clear(); panel5.Visible = false;
                    lbl_prv_after.Text = "now";
                    //lbl_prv_hrs_stage4.Text = Convert.ToString(y);
                    txt_pre_4_parts.Text = ma.main_part.ToString();
                    lbl_prv_hrs_stage3.Text = "Now Periodic Maintenance Stage";
                    lbl_prv_after.Visible = true;
                    lowww_prv.Visible = true;
                   // lbl_prv_hrs_stage3.Visible = true;
                   // lbl_prv_hrs_stage4.Visible = true;
                    btn_pre_upd_Click(sender, e);
                }
                else if (false) /*y == 0)*/
                {
                    //panel2.Enabled = false;

                    lbl_prv_hrs_stage4.Text = "No Periodic maintenance for this Equipment";
                    lbl_hours_ins2.Text = ma.main_periodnum.ToString();
                    lbl_prv_after.Visible = false;//
                    lowww_prv.Visible = false;//
                  //  lbl_prv_hrs_stage3.Visible = true;
                    dat_grid_prev1.DataSource = new DataTable();
                    dat_grid_prev1.Visible = false;
                    lbl_prv_hrs_stage4.Visible = true;
                 //   lbl_prv_hrs_stage3.Visible = true;
                    lbl_prv_after.Text = "0";
                    flowLayoutPanel2.Controls.Clear();
                    panel5.Visible = false;
                } 
                #endregion
            }
            else
            {
                //panel2.Enabled = false;
                 
                lbl_hours_ins2.Text = "No "+ woo + " Counter For This Equipment";
                lbl_hours_ins1.Visible = true;
                lbl_hours_ins2.Visible = true;
                lbl_prv_after.Visible = false;
                lowww_prv.Visible = false;
              //  lbl_prv_hrs_stage3.Visible = false;
                lbl_prv_hrs_stage4.Visible = false;
                flowLayoutPanel2.Controls.Clear(); panel5.Visible = false;
            }
            if (false)
            {
                try
                {
                    if (Convert.ToInt32(lbl_hours_ins2.Text) > Convert.ToInt32(txt_pre_3_hours.Text))
                    {
                        label232.Text = Convert.ToString(Convert.ToInt32(lbl_hours_ins2.Text) - Convert.ToInt32(txt_pre_3_hours.Text));
                        label237.Text = "Behind Requsted Service Counter";
                        panel32.Visible = true;
                    }
                    else
                    {

                        label232.Text = Convert.ToString(Convert.ToInt32(txt_pre_3_hours.Text) - Convert.ToInt32(lbl_hours_ins2.Text));
                        label237.Text = "Left Until Next Maintenance";
                        panel32.Visible = true;
                        //label232.Text = ""; 
                        //panel32.Visible = false;
                    }
                }
                catch
                {
                    label232.Text = "";
                    panel32.Visible = false;
                }
                try
                {
                    return;
                    ma.check_all_undone_prev(Convert.ToInt32(comb_prev_main1.SelectedValue));
                    return;
                    int qx = ma.table.Rows.Count;
                    if (qx >= 1)
                    {
                        dat_grid_prev1.DataSource = ma.table;
                        if (txt_pre_1_id.Text != "")
                        {
                            if (qx == 1) { if (Convert.ToInt32(txt_pre_1_id.Text) == Convert.ToInt32(dat_grid_prev1.Rows[dat_grid_prev1.SelectedCells[0].RowIndex].Cells["main_id"].Value.ToString())) return; }
                        }

                        label100.Visible = true;
                        dat_grid_prev1.Visible = true;
                        btn_bring_to_upd.Visible = true;
                        btn_bring_to_upd.Enabled = true;
                        dat_grid_prev1.Columns[0].Visible = false;
                        dat_grid_prev1.Columns[1].HeaderText = "Maintain Type";
                        dat_grid_prev1.Columns[2].HeaderText = "Total Work Hours";
                        dat_grid_prev1.Columns[3].HeaderText = "Maintain Parts";
                        dat_grid_prev1.Columns[4].HeaderText = "Maintain State";
                        dat_grid_prev1.Columns[5].HeaderText = "Maintain Cost";
                        dat_grid_prev1.Columns[6].HeaderText = "Maintain Date";
                        dat_grid_prev1.Columns[7].HeaderText = "Details";
                        dat_grid_prev1.Columns[8].HeaderText = "Maintain duration";
                        dat_grid_prev1.Columns[9].HeaderText = "Labors Cost";
                        dat_grid_prev1.Rows[qx - 1].Selected = true;
                    }
                    else
                    {
                        label100.Visible = false;
                        dat_grid_prev1.DataSource = new DataTable();
                        dat_grid_prev1.Visible = false;
                        dat_grid_prev1.Visible = false;
                        btn_bring_to_upd.Visible = false;
                        btn_bring_to_upd.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dat_grid_prev1.DataSource = new DataTable();
                    dat_grid_prev1.Visible = false;
                    dat_grid_prev1.Visible = false;
                    btn_bring_to_upd.Visible = false;
                    btn_bring_to_upd.Enabled = false; label100.Visible = false;
                }
            }
        }
        private void combo_laboe_upd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_laboe_upd.SelectedIndex == -1 || combo_laboe_upd.SelectedValue.ToString() == "{System.Data.DataRowView}")
            {
                return;
            }
            if (wo.bring_labor_data(Convert.ToInt32(combo_laboe_upd.SelectedValue)))
            {
                label38.Text = combo_laboe_upd.SelectedValue.ToString();
                txt_lp_up_name.Text = wo.worker_name.ToString();
                txt_lp_up_salary.Text = wo.salary.ToString();
                txt_lp_up_hours.Text = wo.work_hours_per_m.ToString();
                txt_lp_up_name.Enabled = true;
                txt_lp_up_salary.Enabled = true;
                txt_lp_up_hours.Enabled = true;
                btn_labor_upd.Enabled = true;
                btn_labor_del.Enabled = true;
            }
            else
            {
                label38.Text = "";
                txt_lp_up_name.Text = "";
                txt_lp_up_salary.Text = "";
                txt_lp_up_hours.Text = "";
                txt_lp_up_name.Enabled = false;
                txt_lp_up_salary.Enabled = false;
                txt_lp_up_hours.Enabled = false;
                btn_labor_upd.Enabled = false; btn_labor_del.Enabled = false;
            }
        }
        private void comb_CP_main_equ_SelectedIndexChanged(object sender, EventArgs e)
        {
            flow_labor2.Controls.Clear();
            //btn_Corr_main_ins_upd.Enabled = false;
            //panel12.Enabled = false;
            txt_main_id.Text = ""; lbl_dai_state.Text = "a"; linkLabel2.Visible = false; panel15.Visible = false;
            flow_dai.Controls.Clear(); 
            //panel16.Visible = false;
            txt_main_ins4.Text = "";
            txt_main_ins5.Text = "";
            txt_main_ins6.Text = "";
            txt_main_ins7.Text = "";
            //label1072.Text = "";
            txt_duration2.Text = "";
            btn_del_labor2.Visible = false;
            btn_del_labor2.Enabled = false;
            pnl_labor2.Visible = false;
            btn_add_labor2.Visible = true;
            if (ma.Find_work_hours(Convert.ToInt32(comb_CP_main_equ.SelectedValue)))
            {
                txt_main_ins3.Text = ma.main_periodnum.ToString();
            }
            else
            {
                txt_main_ins3.Text = "0";
            }
            panel12.Enabled = true;
            btn_Corr_main_ins_upd.Enabled = true;
            if (btn_del_labor2.Visible == false)
            {
                btn_add_labor2_Click(sender, e);
            }
            try
            {
                ma.check_all_undone_main(Convert.ToInt32(comb_CP_main_equ.SelectedValue), -2);
                DataTable sss = ma.table.Clone();
                sss.Columns[1].DataType = typeof(string);
                foreach (DataRow row in ma.table.Rows)
                {
                    sss.ImportRow(row);
                }
                for (int i = 0; i < ma.table.Rows.Count; i++)
                {
                    int xe = Convert.ToInt32(sss.Rows[i][1].ToString());
                    string aa = eq.Searchequ(xe);
                    sss.Rows[i][1] = aa;
                }
                int qx = sss.Rows.Count;
                if (qx > 0)
                {
                    label107.Visible = true;
                    dataGrid_cor_dai.DataSource = sss;
                    dataGrid_cor_dai.Visible = true;
                    btn_bring_to_upd2.Visible = true;
                    btn_bring_to_upd2.Enabled = true;
                    dataGrid_cor_dai.Columns[0].Visible = false;
                    dataGrid_cor_dai.Columns[2].Visible = false;
                    dataGrid_cor_dai.Columns[9].Visible = false;
                    dataGrid_cor_dai.Columns[11].Visible = false;
                    dataGrid_cor_dai.Columns[1].HeaderText = "Maintain Type";
                    dataGrid_cor_dai.Columns[3].HeaderText = "Total Work Hours";
                    dataGrid_cor_dai.Columns[4].HeaderText = "Maintain Parts";
                    dataGrid_cor_dai.Columns[5].HeaderText = "Maintain State";
                    dataGrid_cor_dai.Columns[6].HeaderText = "Maintain Cost";
                    dataGrid_cor_dai.Columns[7].HeaderText = "Maintain Date";
                    dataGrid_cor_dai.Columns[8].HeaderText = "Details";
                    dataGrid_cor_dai.Columns[10].HeaderText = "Maintain Type";
                    dataGrid_cor_dai.Columns[12].HeaderText = "Maintain duration";
                    dataGrid_cor_dai.Columns[13].Visible = false;
                }
                else
                {
                    label107.Visible = false;
                    dataGrid_cor_dai.DataSource = new DataTable();
                    dataGrid_cor_dai.Visible = false;
                    btn_bring_to_upd2.Visible = false;
                    btn_bring_to_upd2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label107.Visible = false;
                dataGrid_cor_dai.DataSource = new DataTable();
                dataGrid_cor_dai.Visible = false;
                btn_bring_to_upd2.Visible = false;
                btn_bring_to_upd2.Enabled = false;
            }
            try
            {
                lbl_dai_parts.Text = ma.get_new_check_list(Convert.ToInt32(comb_CP_main_equ.SelectedValue));
                if(lbl_dai_parts.Text =="a")
                {
                    linkLabel1.Enabled = false;
                }
                else
                {
                    linkLabel1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Maintain
        private void btn_prev_main_ins_upd_Click(object sender, EventArgs e)
        {
            if (date_prv.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comb_prev_main1.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment V42"); return;
            }
            if(/*lbl_state_prev.Text != "Report" & lbl_state_prev.Text == "Update") & */(Convert.ToInt32(txt_pre_0_now_hours.Text)> Convert.ToInt32(lbl_hours_ins2.Text)))
            {
                MessageBox.Show("Can't Insert Working Hours Higher than Registered Working Hours"); return;
            }
            try
            {
                string ma_type = "Periodic Maintenance<#>" + label225.Text + "<#>" + Convert.ToString(Convert.ToInt32(txt_pre_0_now_hours.Text) - Convert.ToInt32(lbl_lastH.Text) - Convert.ToInt32(lbl_interval.Text));
                if (lbl_state_prev.Text == "Report" || lbl_state_prev.Text == "Update")
                {
                    string state = "Done";
                    string details = "";
                    string parts;
                    foreach (Panel con2 in flow_labor.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is TextBox)
                            {
                                string partss = con.Name;
                                string[] part = Regex.Split(partss, "__");
                                if (part[0] == "t1")
                                {
                                    if (((TextBox)con).Text == "")
                                    {
                                        MessageBox.Show("Please Enter valid Technician work Hours");
                                        return;
                                    }
                                    if ((Convert.ToInt32(((TextBox)con).Text)) > Convert.ToInt32(txt_duration.Text))
                                    {
                                        MessageBox.Show("Can Not Enter Technician Work Hours higher than Maintain Duration");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    foreach (Control control in flowLayoutPanel2.Controls)
                    {
                        if (control is CheckBox)
                        {
                            if (((CheckBox)control).Checked == true)
                            {
                                details = details + "Done" + "<#>";
                            }
                            else
                            {
                                details = details + "Not Done" + "<#>";
                                state = "Not All";
                            }
                        }
                    }
                    parts = txt_pre_4_parts.Text;
                    string weq = "";
                    try
                    {
                        ControlID22.idd = txt_pre_1_id.Text;
                        link_upd_oil_prv_LinkClicked();
                        if (ControlID22.cancel == "")
                        {

                        }
                        else
                        {
                            return;
                        }
                        try
                        {
                            weq = ma.update_main(Convert.ToInt32(txt_pre_1_id.Text), Convert.ToInt32(comb_prev_main1.SelectedValue),
                           Convert.ToInt32(label226.Text), Convert.ToInt32(txt_pre_0_now_hours.Text), parts, state,
                           Convert.ToInt32(txt_pre_6_cost.Text), Convert.ToDateTime(date_prv.Value), txt_pre_7_det.Text,
                           id, ma_type, details, Convert.ToInt32(txt_duration.Text), 0, label225.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please Write Valid Data V43" + "\n" + ex.Message); return;
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " \n Please Recheck Maintenance Data V2"); return;
                    }
                    if (weq == "Success")
                    {
                        try
                        {
                            string xsa = worksal.del_all_work_reprot(Convert.ToInt32(txt_pre_1_id.Text));
                            foreach (Panel con2 in flow_labor.Controls)
                            {
                                int mai_id = Convert.ToInt32(txt_pre_1_id.Text); 
                                int eq = Convert.ToInt32(comb_prev_main1.SelectedValue);
                                DateTime dd = date_prv.Value;
                                int hours = 0; int iiid = 0; string det = ""; string name = "";
                                foreach (Control con in con2.Controls)
                                {
                                    if (con is ComboBox)
                                    {
                                        iiid = Convert.ToInt32(((ComboBox)con).SelectedValue); //////
                                        name = ((ComboBox)con).Text; //////
                                    }
                                    if (con is TextBox)
                                    {
                                        string partss = con.Name;
                                        string[] part = Regex.Split(partss, "__");
                                        if (part[0] == "t1")
                                        {
                                            hours = Convert.ToInt32(((TextBox)con).Text); //////
                                        }
                                        else if (part[0] == "t2")
                                        {
                                            det = ((TextBox)con).Text; //////
                                            if (det == "")
                                            {
                                                det = "No Data";
                                            }
                                        }
                                    }
                                    if (hours != 0 && det != "" && name != "")
                                    {
                                        int sala = wo.bring_labor_salary(iiid, name);
                                        iiid = wo.worker_id;
                                        string qe = worksal.Add_work_reprot(mai_id, iiid, name, eq, hours, dd, sala, det, "Periodic Maintenance","0");
                                        if (qe == "Success")
                                        {
                                            hours = 0; iiid = 0; det = ""; name = "";
                                        }
                                    }
                                }
                            }
                            int aad;
                            try
                            {
                                DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_pre_1_id.Text));
                                aad = ma.update_cost(Convert.ToInt32(txt_pre_1_id.Text), xx);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + " \n Could Not Calculate Labors Cost");
                                aad = 0;
                            }
                            MessageBox.Show("Done");
                            txt_pre_1_id.Text = "";
                            lb_mod_4.Text = "no";
                            flow_labor.Controls.Clear();
                            flowLayoutPanel2.Controls.Clear();
                            panel5.Visible = false;
                            txt_pre_9_type_name.Text = "";
                            txt_pre_3_hours.Text = "";
                            txt_pre_4_parts.Text = "";
                            txt_pre_10_stat_2.Text = "";
                            txt_pre_6_cost.Text = "";
                            txt_pre_7_det.Text = "";
                            txt_duration.Text = "";
                            txt_pre_8_user.Text = "";
                            dat_grid_prev1.DataSource = new DataTable();
                            //txt_pre_3_hours.Visible = false;
                            //lbl_prv2.Visible = false;
                            pnl_labor.Visible = false;
                            txt_pre_4_parts.Visible = false;
                            txt_pre_4_parts.Enabled = false;
                            btn_del_labor.Visible = false;
                            btn_del_labor.Enabled = false;
                            //label102.Visible = false;
                            //label101.Visible = false;
                            if (lbl_state_prev.Text == "Report")
                            {
                                lbl_state_prev.Text = "a"; lb_mod_4.Text = "no";
                                tabControl1.SelectedIndex = 3;
                                //com_repcxort.SelectedValue = comb_prev_main1.SelectedValue;
                                //comb_prev_main1.SelectedIndex = -1;
                                btn_report_Click(sender, e);
                                return;
                            }
                            lbl_state_prev.Text = "a";
                            comb_prev_main1_SelectedIndexChanged(sender, e);
                            lb_mod_4.Text = "no";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " \n Please Recheck Labor Data V3");
                        }
                    }
                    else if (weq == "Failed")
                    {
                        MessageBox.Show("Please Recheck Maintenance data V4"); return;
                    }
                    else
                    {
                        MessageBox.Show(weq); return;
                    }
                }
                else
                {
                    try
                    {
                        int mai_id; ;
                        string st = "";
                        string state = "Done";
                        string details = "";
                        int lo = ma.get_last_main_counter(Convert.ToInt32(comb_prev_main1.SelectedValue));
                        if (Convert.ToInt32(txt_pre_0_now_hours.Text) < lo)
                        {
                            MessageBox.Show("Current Periodic Maintenance Hour Must Exceed Last Periodic Maintenance Hour (" + lo + " Hours) ");
                            return;
                        }
                        foreach (Panel con2 in flow_labor.Controls)
                        {
                            foreach (Control con in con2.Controls)
                            {
                                if (con is TextBox)
                                {
                                    string partss = con.Name;
                                    string[] part = Regex.Split(partss, "__");
                                    if (part[0] == "t1")
                                    {
                                        if (((TextBox)con).Text == "")
                                        {
                                            MessageBox.Show("Please Enter valid Technician work Hours");
                                            return;
                                        }
                                        if ((Convert.ToInt32(((TextBox)con).Text)) > Convert.ToInt32(txt_duration.Text))
                                        {
                                            MessageBox.Show("Can Not Enter Technician Work Hours higher than Maintain Duration");
                                            return;
                                        }
                                    }
                                }
                            }
                        }  //check valid value for textbox hours
                        foreach (Control control in flowLayoutPanel2.Controls)
                        {
                            if (control is CheckBox)
                            {
                                if (((CheckBox)control).Checked == true)
                                {
                                    details = details + "Done" + "<#>";
                                }
                                else
                                {
                                    details = details + "Not Done" + "<#>";
                                    state = "Not All";
                                }
                            }
                        } // register what done and what not
                        string xx = "";
                        try
                        {
                            // int hou = ma.Find_work_hours_int(Convert.ToInt32(comb_prev_main1.SelectedValue));
                            int s = 0;

                            try
                            {
                                xx = ma.Addmain(Convert.ToInt32(comb_prev_main1.SelectedValue), Convert.ToInt32(label226.Text),
                                Convert.ToInt32(txt_pre_0_now_hours.Text), txt_pre_4_parts.Text, state, Convert.ToInt32(txt_pre_6_cost.Text),
                                Convert.ToDateTime(date_prv.Value), txt_pre_7_det.Text, id, ma_type,
                                details, Convert.ToInt32(txt_duration.Text), s, label225.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Please Write Valid Data V44" + "\n" + ex.Message); return;
                            }

                            if (xx == "Failed")
                            {
                                MessageBox.Show("Please Recheck Maintenance data V5"); return;
                            }
                            else if (xx == "Success")
                            {
                                mai_id = ma.bring_new_main_id();
                                ControlID22.idd = mai_id.ToString();
                                link_upd_oil_prv_LinkClicked();
                                if (ControlID22.cancel == "")
                                {

                                }
                                else
                                {
                                    ma.del_main(mai_id);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show(xx); return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " \n Please Recheck Maintenance data V6"); st = "fail"; return;
                        }
                        try
                        {
                            int eq = Convert.ToInt32(comb_prev_main1.SelectedValue);
                            DateTime dd = date_prv.Value;
                            foreach (Panel con2 in flow_labor.Controls)
                            {
                                int hours = 0; int iiid = 0; string det = ""; string name = "";
                                foreach (Control con in con2.Controls)
                                {
                                    if (con is ComboBox)
                                    {
                                        iiid = Convert.ToInt32(((ComboBox)con).SelectedValue); //////
                                        name = ((ComboBox)con).Text; //////
                                    }
                                    if (con is TextBox)
                                    {
                                        string parts = con.Name;
                                        string[] part = Regex.Split(parts, "__");
                                        if (part[0] == "t1")
                                        {
                                            hours = Convert.ToInt32(((TextBox)con).Text); //////
                                        }
                                        else if (part[0] == "t2")
                                        {
                                            det = ((TextBox)con).Text; //////
                                            if (det == "")
                                            {
                                                det = "No Data";
                                            }
                                        }
                                    }
                                    if (hours != 0 && det != "" && iiid != 0 && name != "")
                                    {
                                        int sala = wo.bring_labor_salary(iiid, name);
                                        string qe = worksal.Add_work_reprot(mai_id, iiid, name, eq, hours, dd, sala, det, "Periodic Maintenance", "0");
                                        if (qe == "Success")
                                        {
                                            hours = 0; iiid = 0; det = ""; name = "";
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " \n Please Recheck Labors data V7"); st = "fail"; return;
                        }
                        if (st != "fail")
                        {
                            int aad;
                            try
                            {
                                DataTable xx2 = worksal.Find_worker_reprot(mai_id);
                                aad = ma.update_cost(mai_id, xx2);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + " \n Could Not Calculate Labors Cost");
                                aad = 0;
                            }
                            MessageBox.Show("Done");
                            txt_pre_1_id.Text = "";
                            flow_labor.Controls.Clear();
                            txt_pre_9_type_name.Text = "";
                            txt_pre_3_hours.Text = ""; lb_mod_4.Text = "no";
                            txt_pre_4_parts.Text = "";
                            txt_pre_10_stat_2.Text = "";
                            txt_pre_6_cost.Text = ""; txt_duration.Text = "";
                            txt_pre_7_det.Text = "";
                            txt_pre_8_user.Text = "";
                            flowLayoutPanel2.Controls.Clear();
                            panel5.Visible = false;
                            btn_del_labor.Visible = false;
                            btn_del_labor.Enabled = false;
                            pnl_labor.Visible = false;
                            flow_labor.Controls.Clear();
                            comb_prev_main1_SelectedIndexChanged(sender, e);
                        }
                    }
                    catch
                    {
                        try
                        {
                            int q = ma.bring_new_main_id();
                            if (ma.equ_id == Convert.ToInt32(comb_prev_main1.SelectedValue) && ma.main_type_name == "Periodic Maintenance")
                            {
                                worksal.del_all_work_reprot(q);
                                ma.del_last_main();
                                MessageBox.Show("Please Recheck your data V8");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " \n Please Recheck Inserted Data V9");
                        }
                    }
                }  //add main
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Data V45"); return;
            }
        }
        private void btn_Corr_main_ins_upd_Click(object sender, EventArgs e)
        {
            if (date_main_ins.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comb_CP_main_equ.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }
            ControlID22.hours = Convert.ToDecimal(txt_main_ins3.Text);
            string state = "Done";
            string details = "";
            string main_part = lbl_dai_parts.Text;

            if (lbl_dai_corr_state.Text == "Report" || lbl_dai_corr_state.Text == "Update")
            {
                try
                {
                    foreach (Panel con2 in flow_labor2.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is TextBox)
                            {
                                string partss = con.Name;
                                string[] part = Regex.Split(partss, "__");
                                if (part[0] == "t1")
                                {
                                    if (((TextBox)con).Text == "")
                                    {
                                        MessageBox.Show("Please Enter valid Technician work Hours");
                                        return;
                                    }
                                    if ((Convert.ToInt32(((TextBox)con).Text)) > Convert.ToInt32(txt_duration2.Text))
                                    {
                                        MessageBox.Show("Can Not Enter Technician Work Hours higher than Maintain Duration");
                                        return;
                                    }
                                }
                            }
                        }
                    } //steps
                    if (radio_corr_dai_done.Checked)
                    {
                        txt_main_ins5.Text = "Done";
                    }//steps
                    else if (radio_corr_dai_Not_done.Checked)
                    {
                        txt_main_ins5.Text = "Not All";
                    }//steps
                    int qwer = 0;
                    string weq = "";
                    int eru_id = 0;
                    try
                    {
                        if (linkLabel2.Visible == true)
                        {
                            int rwq = 0;
                            foreach (Panel pan in flow_labor2.Controls)
                            {
                                rwq++;
                            }

                            if (rwq == 0)
                            {
                                MessageBox.Show("Please Choose Technician that Responsible Of The CheckList check"); return;
                            }
                        }
                        eru_id = Convert.ToInt32(comb_CP_main_equ.SelectedValue);
                        ControlID22.idd = txt_main_id.Text;
                        DialogResult dialogResult = MessageBox.Show("Any Modified Oils?", "Modify Oils", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ControlID22.TextData22 = Convert.ToInt32(comb_CP_main_equ.SelectedValue);
                            linkLabel1_LinkClicked();
                            if (ControlID22.cancel == "")
                            {

                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                        try
                        {
                            weq = ma.update_main(Convert.ToInt32(txt_main_id.Text), eru_id, -2,
                            Convert.ToInt32(txt_main_ins3.Text), txt_main_ins4.Text, txt_main_ins5.Text, Convert.ToInt32(txt_main_ins6.Text),
                            Convert.ToDateTime(date_main_ins.Value), txt_main_ins7.Text, id, "Daily Maintenance", "k",
                            Convert.ToInt32(txt_duration2.Text), Convert.ToInt32(qwer), "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please Write Valid Data V46" + "\n"+ex.Message); return;
                        }
                        
                        if (weq == "Failed")
                        {
                            MessageBox.Show("Please Recheck Maintenance data V10"); return;
                        }
                        else if (weq == "Success")
                        {
                            if (linkLabel2.Visible == true)
                            {
                                try
                                {
                                    foreach (Control control in flow_dai.Controls)
                                    {
                                        if (control is CheckBox)
                                        {
                                            if (((CheckBox)control).Checked == true)
                                            {
                                                details = details + "Done" + "<#>";
                                            }
                                            else
                                            {
                                                details = details + "Not Done" + "<#>";
                                                state = "Not All";
                                            }
                                        }
                                    }
                                    
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show(weq); return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " \n Please Recheck Maintenance Data V11"); return; }
                    if (weq == "Success")
                    {
                        try
                        {
                            string xsa = worksal.del_all_work_reprot(Convert.ToInt32(txt_main_id.Text));
                            foreach (Panel con2 in flow_labor2.Controls)
                            {
                                int mai_id = Convert.ToInt32(txt_main_id.Text); int eq = eru_id;
                                DateTime dd = date_main_ins.Value;
                                int hours = 0; int iiid = 0; string det = ""; string name = "";
                                foreach (Control con in con2.Controls)
                                {
                                    if (con is ComboBox)
                                    {
                                        iiid = Convert.ToInt32(((ComboBox)con).SelectedValue); //////
                                        name = ((ComboBox)con).Text; //////
                                    }
                                    if (con is TextBox)
                                    {
                                        string partss = con.Name;
                                        string[] part = Regex.Split(partss, "__");
                                        if (part[0] == "t1")
                                        {
                                            hours = Convert.ToInt32(((TextBox)con).Text); //////
                                        }
                                        else if (part[0] == "t2")
                                        {
                                            det = ((TextBox)con).Text; //////
                                            if (det == "")
                                            {
                                                det = "No Data";
                                            }
                                        }
                                    }
                                    if (hours != 0 && det != "" && name != "")
                                    {
                                        int sala = wo.bring_labor_salary(iiid, name);
                                        iiid = wo.worker_id;
                                        string qe = worksal.Add_work_reprot(mai_id, iiid, name, eq, hours, dd, sala, det, "Daily Maintenance", "0");
                                        if (qe == "Success")
                                        {
                                            

                                            hours = 0; iiid = 0; det = ""; name = "";
                                        }
                                        else
                                        {
                                            try
                                            {
                                                worksal.del_all_work_reprot(Convert.ToInt32(txt_main_id.Text));
                                                ma.del_main(Convert.ToInt32(txt_main_id.Text));
                                                MessageBox.Show("Please Recheck Labors Data V12"); return;
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message+" \n Wrong Data in Database Error Code: C1" + "\n" + "Please Contact With Developer"); return; }
                                        }
                                    }
                                }
                            }
                            int aad;
                            string ee = "";
                            if (ma.check_daily_bring(Convert.ToInt32(txt_main_id.Text)))
                            {
                                if (linkLabel2.Visible == true)
                                {
                                    ee = ma.update_checklist(Convert.ToInt32(ma.table.Rows[0][0].ToString()), Convert.ToInt32(txt_main_id.Text),
                                  main_part, state, Convert.ToDateTime(date_main_ins.Value), "",
                                          Convert.ToInt32(txt_main_ins8.Text), details);
                                }else
                                {
                                    ee = ma.delete_dai_ch(Convert.ToInt32(txt_main_id.Text));
                                }
                            }
                            else if(linkLabel2.Visible == true)
                            {
                                ee = ma.Addchecklist(Convert.ToInt32(txt_main_id.Text), main_part, state, Convert.ToDateTime(date_main_ins.Value), "", id, details);
                            }
                                

                            if (ee == "Failed")
                            {
                                MessageBox.Show("Error Code: V7"); return;
                            }
                            try
                            {
                                DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_main_id.Text));
                                aad = ma.update_cost(Convert.ToInt32(txt_main_id.Text), xx);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message+ " \n Could Not Calculate Labors Cost");
                                aad = 0;
                            }

                            MessageBox.Show("Done");
                            lbl_dai_state.Text = "a";
                            linkLabel2.Visible = false;
                            panel15.Visible = false;
                            //panel16.Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message+ " \n Please Recheck Your Data V13"); return; }
                    } //update lapors
                    else { MessageBox.Show("Please Recheck Your Data V14"); }
                    if (lbl_dai_corr_state.Text == "Report")
                    {
                        lbl_dai_corr_state.Text = "";
                        comb_CP_main_equ.Enabled = true;
                        txt_main_id.Text = "";
                        txt_main_ins4.Text = "";
                        txt_main_ins5.Text = "";
                        txt_main_ins6.Text = "";
                        txt_duration2.Text = "";
                        txt_main_ins7.Text = "";
                        //label1072.Text = "";
                        lb_mod_6.Text = "no";
                        flow_labor2.Controls.Clear();
                        pnl_labor2.Visible = false;
                        btn_del_labor2.Visible = false;
                        btn_del_labor2.Enabled = false;
                        tabControl1.SelectedIndex = 3;
                        com_report.SelectedValue = comb_CP_main_equ.SelectedValue;
                        comb_CP_main_equ.SelectedIndex= -1;
                        if (btn_del_labor2.Visible == false)
                        {
                            btn_add_labor2_Click(sender, e);
                        }
                        btn_report_Click(sender, e);
                        return;
                    }
                    else
                    {
                        try
                        {
                            ma.check_all_undone_main(Convert.ToInt32(comb_CP_main_equ.SelectedValue),-2);
                            DataTable sss = ma.table.Clone();
                            sss.Columns[1].DataType = typeof(string);
                            foreach (DataRow row in ma.table.Rows)
                            {
                                sss.ImportRow(row);
                            }
                            for (int i = 0; i < ma.table.Rows.Count; i++)
                            {
                                int xe = Convert.ToInt32(sss.Rows[i][1].ToString());
                                string aa = eq.Searchequ(xe);
                                sss.Rows[i][1] = aa;
                            }
                            int qx = sss.Rows.Count;
                            if (qx > 0)
                            {
                                //label1072.Visible = false;
                                //label114.Visible = false;
                                dataGrid_cor_dai.DataSource = sss;
                                dataGrid_cor_dai.Visible = true;
                                btn_bring_to_upd2.Visible = true;
                                btn_bring_to_upd2.Enabled = true;
                                dataGrid_cor_dai.Columns[0].Visible = false;
                                dataGrid_cor_dai.Columns[2].Visible = false;
                                dataGrid_cor_dai.Columns[9].Visible = false;
                                dataGrid_cor_dai.Columns[11].Visible = false;
                                dataGrid_cor_dai.Columns[1].HeaderText = "Maintain Type";
                                dataGrid_cor_dai.Columns[3].HeaderText = "Total Work Hours";
                                dataGrid_cor_dai.Columns[4].HeaderText = "Maintain Parts";
                                dataGrid_cor_dai.Columns[5].HeaderText = "Maintain State";
                                dataGrid_cor_dai.Columns[6].HeaderText = "Maintain Cost";
                                dataGrid_cor_dai.Columns[7].HeaderText = "Maintain Date";
                                dataGrid_cor_dai.Columns[8].HeaderText = "Details";
                                dataGrid_cor_dai.Columns[10].HeaderText = "Maintain Type";
                                dataGrid_cor_dai.Columns[12].HeaderText = "Maintain duration";
                                dataGrid_cor_dai.Columns[13].Visible = false;
                            }
                            else
                            {
                                label107.Visible = false;
                                dataGrid_cor_dai.DataSource = new DataTable();
                                dataGrid_cor_dai.Visible = false;
                                dataGrid_cor_dai.Visible = false;
                                btn_bring_to_upd2.Visible = false;
                                btn_bring_to_upd2.Enabled = false;
                            }
                        }
                        catch
                        {
                            dataGrid_cor_dai.DataSource = new DataTable();
                            dataGrid_cor_dai.Visible = false;
                            dataGrid_cor_dai.Visible = false;
                            btn_bring_to_upd2.Visible = false;
                            btn_bring_to_upd2.Enabled = false; label107.Visible = false;
                        }  //unfinished maintan
                    } //unfinished maintan
                    txt_main_id.Text = "";
                    txt_main_ins4.Text = "";
                    txt_main_ins5.Text = "";
                    txt_main_ins6.Text = "";
                    txt_duration2.Text = "";
                    txt_main_ins7.Text = ""; lb_mod_6.Text = "no";
                    //label1072.Text = "";
                    lbl_dai_corr_state.Text = "";
                    txt_duration2.Text = "";
                    flow_labor2.Controls.Clear();
                    pnl_labor2.Visible = false;
                    btn_del_labor2.Visible = false;
                    //btn_del_labor2.Enabled = false;
                    if (btn_del_labor2.Visible == false)
                    {
                        btn_add_labor2_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+ " \n Please Recheck Your Data V15"); }
            }
            else
            {
                try
                {
                    foreach (Panel con2 in flow_labor2.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is TextBox)
                            {
                                string partss = con.Name;
                                string[] part = Regex.Split(partss, "__");
                                if (part[0] == "t1")
                                {
                                    if (((TextBox)con).Text == "")
                                    {
                                        MessageBox.Show("Please Enter valid Technician work Hours");
                                        return;
                                    }
                                    if ((Convert.ToInt32(((TextBox)con).Text)) > Convert.ToInt32(txt_duration2.Text))
                                    {
                                        MessageBox.Show("Can Not Enter Technician Work Hours higher than Maintain Duration");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    if (radio_corr_dai_done.Checked)
                    {
                        txt_main_ins5.Text = "Done";
                    }
                    else if (radio_corr_dai_Not_done.Checked)
                    {
                        txt_main_ins5.Text = "Not All";
                    }
                    int qwer = 0;
                    string www = "";
                    int mai_id = 0;
                    try
                    {
                        if (linkLabel2.Visible == true)
                        {
                            int rwq = 0;
                            foreach (Panel pan in flow_labor2.Controls)
                            {
                                rwq++;
                            }

                            if (rwq == 0)
                            {
                                MessageBox.Show("Please Choose Technician that Responsible Of The CheckList check"); return;
                            }
                        }
                        int x = -2;
                        try
                        {
                            www = ma.Addmain(Convert.ToInt32(comb_CP_main_equ.SelectedValue), x,
                            Convert.ToInt32(txt_main_ins3.Text), txt_main_ins4.Text, txt_main_ins5.Text,
                            Convert.ToInt32(txt_main_ins6.Text), Convert.ToDateTime(date_main_ins.Value), txt_main_ins7.Text,
                            id, "Daily Maintenance", "k", Convert.ToInt32(txt_duration2.Text), Convert.ToInt32(qwer), "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please Write Valid Data V47" + "\n" + ex.Message); return;
                        }
                       
                        if (www == "Failed")
                        {
                            MessageBox.Show("Please Recheck Maintenance data V16"); return;
                        }
                        else if (www == "Success")
                        {
                            mai_id = ma.bring_new_main_id();
                            ControlID22.idd = mai_id.ToString();
                            ControlID22.TextData22 = Convert.ToInt32(comb_CP_main_equ.SelectedValue);

                            DialogResult dialogResult = MessageBox.Show("Any Modified Oils?", "Modify Oils", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                linkLabel1_LinkClicked();
                                if (ControlID22.cancel == "")
                                {

                                }
                                else
                                {
                                    ma.del_main(mai_id);
                                    return;
                                }
                            }
                           
                            if (linkLabel2.Visible == true)
                            {
                                try
                                {
                                    int maiin_iid = mai_id;
                                    
                                    foreach (Control control in flow_dai.Controls)
                                    {
                                        if (control is CheckBox)
                                        {
                                            if (((CheckBox)control).Checked == true)
                                            {
                                                details = details + "Done" + "<#>";
                                            }
                                            else
                                            {
                                                details = details + "Not Done" + "<#>";
                                                state = "Not All";
                                            }
                                        }
                                    }
                                    
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(www); return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " \n Please Recheck Maintenance data V17"); return;
                    }
                    if (www == "Success")
                    {
                        foreach (Panel con2 in flow_labor2.Controls)
                        {
                            int eq = Convert.ToInt32(comb_CP_main_equ.SelectedValue);
                            DateTime dd = date_main_ins.Value;
                            int hours = 0; int iiid = 0; string det = ""; string name = "";
                            foreach (Control con in con2.Controls)
                            {
                                if (con is ComboBox)
                                {
                                    iiid = Convert.ToInt32(((ComboBox)con).SelectedValue); //////
                                    name = ((ComboBox)con).Text; //////
                                }
                                if (con is TextBox)
                                {
                                    string parts = con.Name;
                                    string[] part = Regex.Split(parts, "__");
                                    if (part[0] == "t1")
                                    {
                                        hours = Convert.ToInt32(((TextBox)con).Text); //////
                                    }
                                    else if (part[0] == "t2")
                                    {
                                        det = ((TextBox)con).Text; //////
                                        if (det == "")
                                        {
                                            det = "No Data";
                                        }
                                    }
                                }
                                if (hours != 0 && det != "" && iiid != 0 && name != "")
                                {
                                    int sala = wo.bring_labor_salary(iiid, name);
                                    string qe = worksal.Add_work_reprot(mai_id, iiid, name, eq, hours, dd, sala, det, "Daily Maintenance", "0");
                                    if (qe == "Success")
                                    {
                                        hours = 0; iiid = 0; det = ""; name = "";
                                    }
                                }
                            }
                        }
                        string ee = ma.Addchecklist(mai_id, main_part, state, Convert.ToDateTime(date_main_ins.Value),"", id, details);
                        if (ee == "Failed")
                        {
                            ma.del_last_main();
                            MessageBox.Show("Please Restart The Software" + "\n" + "Error Code: V3"); return;
                        }
                        int aad;
                        try
                        {
                            DataTable xx2 = worksal.Find_worker_reprot(mai_id);
                            aad = ma.update_cost(mai_id, xx2);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message+" \n Could Not Calculate Labors Cost");
                            aad = 0;
                        }
                        
                        MessageBox.Show("Done");
                        flow_labor2.Controls.Clear(); panel15.Visible = false;
                        //label1072.Visible = false;
                        //label114.Visible = false;
                        pnl_labor2.Visible = false;
                        txt_main_ins4.Text = ""; lb_mod_6.Text = "no";
                        txt_main_ins5.Text = "";
                        txt_duration2.Text = "";
                        txt_main_ins6.Text = "";
                        txt_main_ins7.Text = "";
                        //label1072.Text = "";
                        comb_CP_main_equ_SelectedIndexChanged(sender, e);
                        if (btn_del_labor2.Visible == false)
                        {
                            btn_add_labor2_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " \n Please Recheck Maintenance data V18"); return; }
            }
        }
        private void btn_pre_upd_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            panel5.Visible = false;
            CheckBoxes.Clear();
            try
            {
                if (lbl_hours_ins2.Text == "No Hours Counter For This Equipment" || lbl_hours_ins2.Text == "No Data Yet")
                { 

                }
                else { 
                    //string qwe1 = "";
                    string[] arrx = new string[22];
                    arrx = ma.hole(Convert.ToInt32(comb_prev_main1.SelectedValue), Convert.ToInt32(lbl_hours_ins2.Text));
                    #region never -_-
                    if (false /*arrx[0] == "1" || arrx[0] == "13" || arrx[0] == "3" || arrx[0] == "5" || arrx[0] == "7" || arrx[0] == "9" || arrx[0] == "17"*/ )
                    {
                        txt_pre_2_type_number.Text = arrx[3];//stage numper
                        txt_pre_0_now_hours.Text = arrx[4];//hours when done
                        txt_pre_4_parts.Text = arrx[5];//parts
                        lbl_prv8.Text = arrx[6];//parts
                        txt_pre_10_stat_2.Text = "";
                        btn_pre_sho_Click(sender, e);
                        //panel2.Enabled = true;
                        lbl_state_prev.Text = "a";
                        MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 
                    }
                    else if (false /*arrx[0] == "2" || arrx[0] == "14" || arrx[0] == "16" || arrx[0] == "4" || arrx[0] == "6" || arrx[0] == "8" || arrx[0] == "10"*/)
                    {
                        DialogResult dialogResult = MessageBox.Show("There is a New Periodic Maintenance that should be done but the old one is not complete yet \n Yes : Add New Periodic Maintenance \n No : Update old Periodic Maintenance First", "New Periodic Maintenance Should be Done", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txt_pre_2_type_number.Text = arrx[3];//stage numper
                            txt_pre_3_numm.Text = arrx[3];// stage numper
                            txt_pre_3_hours.Text = txt_pre_0_now_hours.Text;//hours when done
                            txt_pre_4_parts.Text = arrx[4];//parts                      
                            txt_pre_10_stat_2.Text = "";
                            btn_pre_sho_Click(sender, e);
                            //panel2.Enabled = true;
                            lbl_state_prev.Text = "a";
                            MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            txt_pre_1_id.Text = arrx[5];// main id
                                                        // qwe1 = arrx[5];
                            txt_pre_3_numm.Text = arrx[6];// stage numper
                            txt_pre_2_type_number.Text = arrx[6];// stage numper
                            txt_pre_3_hours.Text = arrx[7];// hours when done
                            txt_pre_4_parts.Text = arrx[8];//parts
                            txt_pre_6_cost.Text = arrx[9];//cost
                            date_prv.Value = Convert.ToDateTime(arrx[10]);//date
                            txt_pre_7_det.Text = arrx[11];//details
                            txt_pre_8_user.Text = arrx[12];//user id
                                                           //txt_pre_9_type_name.Text = arrx[16];//name -_-
                            txt_pre_10_stat_2.Text = arrx[13];//state details
                            txt_duration.Text = arrx[14];//time needed
                            //label102.Text = arrx[15];//labor cost
                            lbl_state_prev.Text = "Update";
                            btn_pre_sho_Click(sender, e);
                            //panel2.Enabled = true;
                            MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 1
                        }
                    }
                    else if (false /*arrx[0] == "11"   || arrx[0] == "18" || arrx[0] == "19" || arrx[0] == "15"*/)
                    {

                        if (lbl_state_prev.Text == "Report" || lbl_state_prev.Text == "Update")
                        {
                            //panel2.Enabled = true; 
                        }
                        else
                        {
                            //panel2.Enabled = false; lbl_state_prev.Text = "a";
                        }

                        MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 
                    }
                    else if (false /*arrx[0] == "12"*/)
                    {
                        txt_pre_1_id.Text = arrx[3];// main id
                        //qwe1 = arrx[3];
                        txt_pre_2_type_number.Text = arrx[4];// stage numper
                        txt_pre_3_hours.Text = arrx[5];// hours when done
                        txt_pre_4_parts.Text = arrx[6];//parts
                        txt_pre_6_cost.Text = arrx[7];//cost
                        date_prv.Value = Convert.ToDateTime(arrx[8]);//date
                        txt_pre_7_det.Text = arrx[9];//details
                        txt_pre_8_user.Text = arrx[10];//user id
                        txt_pre_10_stat_2.Text = arrx[11];//state details
                        txt_duration.Text = arrx[12];//time needed
                       // label102.Text = arrx[13];//labor cost
                        lbl_state_prev.Text = "Update";
                        btn_pre_sho_Click(sender, e);
                        //panel2.Enabled = true;
                        DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_pre_1_id.Text));
                        int x = xx.Rows.Count;
                        if (x > 0)
                        {
                            flow_labor.Controls.Clear();
                            lbl_prv_after.Visible = true;
                            lowww_prv.Visible = true;
                         //   lbl_prv_hrs_stage3.Visible = true;
                          //  lbl_prv_hrs_stage4.Visible = true;
                            flow_labor.Visible = true;
                            int sw = 0; dea = 0;
                            report_iid = new int[x];
                            for (int w = 0; w < x; w++)
                            {
                                btn_del_labor.Visible = true;
                                btn_del_labor.Enabled = true;
                                pnl_labor.Visible = true;

                                ComboBox comb = new ComboBox();
                                TextBox txt = new TextBox();
                                TextBox txtd = new TextBox();
                                CheckBox lp = new CheckBox();
                                Panel pp = new Panel();

                                pp.Name = "p" + dea;
                                pp.Size = new Size(500, 30);

                                comb.Name = "c" + dea;
                                comb.Size = new Size(150, 21);
                                comb.Location = new Point(27, 4);
                                report_iid[w] = Convert.ToInt32(xx.Rows[w][0].ToString());
                                comb.SelectedText = xx.Rows[w][3].ToString();
                                comb.SelectedValue = xx.Rows[w][2].ToString();
                                comb.Enabled = false;

                                txt.Name = "t1__" + dea;
                                txt.Size = new Size(60, 20);
                                txt.Location = new Point(184, 4);
                                txt.Text = xx.Rows[w][5].ToString();
                                txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);

                                sw = dea + 1;
                                lp.Name = "lp" + dea;
                                lp.Text = sw + " -";
                                lp.Size = new Size(20, 20);
                                lp.Location = new Point(6, 4);

                                txtd.Name = "t2__" + dea;
                                txtd.Text = xx.Rows[w][8].ToString();
                                txtd.Size = new Size(245, 20);
                                txtd.Location = new Point(251, 4);

                                pp.Controls.Add(comb);
                                pp.Controls.Add(txt);
                                pp.Controls.Add(txtd);
                                pp.Controls.Add(lp);
                                flow_labor.Controls.Add(pp);
                                dea++;
                            }
                        }
                        else
                        {
                            pnl_labor.Visible = false;
                            flow_labor.Controls.Clear();
                            btn_del_labor.Visible = false;
                            btn_del_labor.Enabled = false;
                        }
                        // txt_pre_3_hours.Visible = true;
                        //lbl_prv2.Visible = true;
                        date_prv.Enabled = true;
                        txt_pre_6_cost.Visible = true;
                        txt_pre_6_cost.Enabled = true;
                        txt_pre_7_det.Visible = true;
                        txt_pre_7_det.Enabled = true;
                        MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 1
                    } 
                    #endregion
                    else if (arrx[0] == "25")
                    {
                        txt_pre_1_id.Text = arrx[3];// main id
                        //qwe1 = arrx[3];
                        label226.Text = arrx[4];// stage numper
                        txt_pre_0_now_hours.Text = arrx[5];// hours when done
                        txt_pre_4_parts.Text = arrx[6];//parts
                        txt_pre_6_cost.Text = arrx[7];//cost
                        date_prv.Value = Convert.ToDateTime(arrx[8]);//date
                        txt_pre_7_det.Text = arrx[9];//details
                        txt_pre_8_user.Text = arrx[10];//user id
                        txt_pre_10_stat_2.Text = arrx[11];//state details
                        txt_duration.Text = arrx[12];//time needed
                        //label102.Text = arrx[13];//labor cost
                        label225.Text = arrx[14];// real stage num
                        txt_pre_3_numm.Text = Convert.ToString(Convert.ToInt32(arrx[4])*Convert.ToInt32(arrx[17]));// stage hours
                        txt_pre_3_hours.Text = arrx[15];// stage hours
                        lbl_lastH.Text = arrx[16];// last hours
                        pnl_last_hours.Visible = true;
                        lbl_interval.Text = arrx[17];// interval
                        lbl_state_prev.Text = "Update";
                        btn_pre_sho_Click(sender, e);
                        //panel2.Enabled = true;
                        DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_pre_1_id.Text));
                        int x = xx.Rows.Count;
                        if (x > 0)
                        {
                            flow_labor.Controls.Clear();
                            lbl_prv_after.Visible = true;
                            lowww_prv.Visible = true;
                          //  lbl_prv_hrs_stage3.Visible = true;
                         //   lbl_prv_hrs_stage4.Visible = true;
                            flow_labor.Visible = true;
                            int sw = 0; dea = 0;
                            report_iid = new int[x];
                            for (int w = 0; w < x; w++)
                            {
                                btn_del_labor.Visible = true;
                                btn_del_labor.Enabled = true;
                                pnl_labor.Visible = true;

                                ComboBox comb = new ComboBox();
                                TextBox txt = new TextBox();
                                TextBox txtd = new TextBox();
                                CheckBox lp = new CheckBox();
                                Panel pp = new Panel();

                                pp.Name = "p" + dea;
                                pp.Size = new Size(500, 30);

                                comb.Name = "c" + dea;
                                comb.Size = new Size(150, 21);
                                comb.Location = new Point(27, 4);
                                report_iid[w] = Convert.ToInt32(xx.Rows[w][0].ToString());
                                comb.SelectedText = xx.Rows[w][3].ToString();
                                comb.SelectedValue = xx.Rows[w][2].ToString();
                                comb.Enabled = false;

                                txt.Name = "t1__" + dea;
                                txt.Size = new Size(60, 20);
                                txt.Location = new Point(184, 4);
                                txt.Text = xx.Rows[w][5].ToString();
                                txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);

                                sw = dea + 1;
                                lp.Name = "lp" + dea;
                                lp.Text = sw + " -";
                                lp.Size = new Size(20, 20);
                                lp.Location = new Point(6, 4);

                                txtd.Name = "t2__" + dea;
                                txtd.Text = xx.Rows[w][8].ToString();
                                txtd.Size = new Size(245, 20);
                                txtd.Location = new Point(251, 4);

                                pp.Controls.Add(comb);
                                pp.Controls.Add(txt);
                                pp.Controls.Add(txtd);
                                pp.Controls.Add(lp);
                                flow_labor.Controls.Add(pp);
                                dea++;
                            }
                        }
                        else
                        {
                            pnl_labor.Visible = false;
                            flow_labor.Controls.Clear();
                            btn_del_labor.Visible = false;
                            btn_del_labor.Enabled = false;
                        }
                        // txt_pre_3_hours.Visible = true;
                        //lbl_prv2.Visible = true;
                        date_prv.Enabled = true;
                        txt_pre_6_cost.Visible = true;
                        txt_pre_6_cost.Enabled = true;
                        txt_pre_7_det.Visible = true;
                        txt_pre_7_det.Enabled = true; panel2.Enabled = true;
                        MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 1
                    }
                    else if (arrx[0] == "17" || arrx[0] == "27" || arrx[0] == "270")
                    {
                        label226.Text = arrx[3];//stage numper
                        txt_pre_3_numm.Text = Convert.ToString(Convert.ToInt32(arrx[3]) * Convert.ToInt32(arrx[8]));// stage numper
                        txt_pre_3_hours.Text = arrx[4];//hours when done
                        txt_pre_4_parts.Text = arrx[5];//parts
                        label225.Text = arrx[6];//real stage numper
                        lbl_lastH.Text = arrx[7];// last hours
                        pnl_last_hours.Visible = true;
                        lbl_interval.Text = arrx[8];// interval
                        txt_pre_10_stat_2.Text = "";
                        btn_pre_sho_Click(sender, e);
                        panel2.Enabled = true;
                        //panel2.Enabled = true;
                        lbl_state_prev.Text = "a";
                        MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 

                    }
                    else if (arrx[0] == "26" || arrx[0] == "18" || arrx[0] == "19" || arrx[0] == "-1")
                    {
                        lbl_state_prev.Text = "a";
                        panel2.Enabled = false;
                        pnl_last_hours.Visible = false;
                        lbl_lastH.Text = "0";// last hours
                        MessageBox.Show(arrx[1] + "\n" + arrx[2]);//titlle 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_cor_step2_Click(object sender, EventArgs e)
        {
            if (date_cor.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (combo_cor_equ.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }

            ControlID22.hours = Convert.ToDecimal(txt_main_ins31.Text);
            if (lbl_dai_corr_state1.Text == "Report" || lbl_dai_corr_state1.Text == "Update")
            {
                try
                {
                    foreach (Panel con2 in flow_cor_labors.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is TextBox)
                            {
                                string partss = con.Name;
                                string[] part = Regex.Split(partss, "__");
                                if (part[0] == "t1")
                                {
                                    if (((TextBox)con).Text == "")
                                    {
                                        MessageBox.Show("Please Enter valid Technician work Hours");
                                        return;
                                    }
                                    if ((Convert.ToInt32(((TextBox)con).Text)) > Convert.ToInt32(txt_cor_dura.Text))
                                    {
                                        MessageBox.Show("Can Not Enter Technician Work Hours higher than Maintain Duration");
                                        return;
                                    }
                                }
                            }
                        }
                    } //steps
                    if (radi_cor_done.Checked)
                    {
                        txt_cor_state.Text = "Done";
                    }//steps
                    else if (radi_cor_notdone.Checked)
                    {
                        txt_cor_state.Text = "Not All";
                    }//steps
                    int qwer = 0;
                    string weq = "";
                    int eru_id = 0;
                    try
                    {
                        eru_id = Convert.ToInt32(combo_cor_equ.SelectedValue);
                        ControlID22.idd = txt_main_id1.Text;
                        ControlID22.TextData22 = eru_id;

                        DialogResult dialogResult = MessageBox.Show("Any Modified Oils?", "Modify Oils", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            linkLabel1_LinkClicked();
                            if (ControlID22.cancel == "")
                            {

                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                        try
                        {
                            weq = ma.update_main(Convert.ToInt32(txt_main_id1.Text), eru_id, -1,
                            Convert.ToInt32(txt_main_ins31.Text), txt_cor_parts.Text, txt_cor_state.Text,
                            Convert.ToInt32(txt_cor_cost.Text),
                            Convert.ToDateTime(date_cor.Value), txt_cor_deta.Text, id, "Corrective Maintenance", "k",
                            Convert.ToInt32(txt_cor_dura.Text), Convert.ToInt32(qwer), "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please Write Valid Data V19" + "\n" + ex.Message); return;
                        }
                        

                        if (weq == "Failed")
                        {
                            MessageBox.Show("Please Recheck Maintenance data V20"); return;
                        }
                        else if (weq == "Success")
                        {


                        }
                        else
                        {
                            MessageBox.Show(weq); return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " \n Please Recheck Maintenance Data V21"); return;
                    }

                    if (weq == "Success")
                    {
                        try
                        {
                            string xsa = worksal.del_all_work_reprot(Convert.ToInt32(txt_main_id1.Text));
                            foreach (Panel con2 in flow_cor_labors.Controls)
                            {
                                int mai_id = Convert.ToInt32(txt_main_id1.Text); int eq = eru_id;
                                DateTime dd = date_cor.Value;
                                int hours = 0; int iiid = 0; string det = ""; string name = "";
                                foreach (Control con in con2.Controls)
                                {
                                    if (con is ComboBox)
                                    {
                                        iiid = Convert.ToInt32(((ComboBox)con).SelectedValue); //////
                                        name = ((ComboBox)con).Text; //////
                                    }
                                    if (con is TextBox)
                                    {
                                        string partss = con.Name;
                                        string[] part = Regex.Split(partss, "__");
                                        if (part[0] == "t1")
                                        {
                                            hours = Convert.ToInt32(((TextBox)con).Text); //////
                                        }
                                        else if (part[0] == "t2")
                                        {
                                            det = ((TextBox)con).Text; //////
                                            if (det == "")
                                            {
                                                det = "No Data";
                                            }
                                        }
                                    }
                                    if (hours != 0 && det != "" && name != "")
                                    {
                                        int sala = wo.bring_labor_salary(iiid, name);
                                        iiid = wo.worker_id;
                                        string qe = worksal.Add_work_reprot(mai_id, iiid, name, eq, hours, dd, sala, det, "Corrective Maintenance", "0");
                                        if (qe == "Success")
                                        {
                                            hours = 0; iiid = 0; det = ""; name = "";
                                        }
                                        else
                                        {
                                            try
                                            {
                                                worksal.del_all_work_reprot(Convert.ToInt32(txt_main_id1.Text));
                                                ma.del_main(Convert.ToInt32(txt_main_id1.Text));
                                                MessageBox.Show("Please Recheck Labors Data V22"); return;
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message + " \n Wrong Data in Database Error Code: C1" + "\n" + "Please Contact With Developer"); return;
                                            }
                                        }
                                    }
                                }
                            }
                            int aad;
                            try
                            {
                                DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_main_id1.Text));
                                aad = ma.update_cost(Convert.ToInt32(txt_main_id1.Text), xx);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message + " \n Could Not Calculate Labors Cost");
                                aad = 0;
                            }
                            MessageBox.Show("Done");
                            lbl_dai_state1.Text = "a";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " \n Please Recheck Your Data V23"); return;
                        }
                    } //update lapors
                    else { MessageBox.Show("Please Recheck Your Data V24"); }
                    if (lbl_dai_corr_state1.Text == "Report")
                    {

                        lbl_dai_corr_state1.Text = "";
                        combo_cor_equ.Enabled = true;
                        txt_main_id1.Text = "";
                        txt_cor_parts.Text = "";
                        txt_cor_state.Text = ""; lb_mod_5.Text = "no";
                        txt_cor_cost.Text = "";
                        txt_cor_dura.Text = "";
                        txt_cor_deta.Text = "";
                        //lbl_cor_labor_cost.Text = "";
                        flow_cor_labors.Controls.Clear();
                        pnl_cor_names.Visible = false;
                        btn_cor_del_lapor.Visible = false;
                        //btn_cor_del_lapor.Enabled = false;
                        tabControl1.SelectedIndex = 3;
                        com_report.SelectedValue = combo_cor_equ.SelectedValue;
                        combo_cor_equ.SelectedIndex = -1;
                        if (btn_cor_del_lapor.Visible == false)
                        {
                            btn_cor_add_lapor_Click(sender, e);
                        }
                        btn_report_Click(sender, e);
                        return;
                    }
                    else
                    {
                        //combo_cor_equ_SelectedIndexChanged(sender, e); return;
                        try
                        {
                            ma.check_all_undone_main(Convert.ToInt32(combo_cor_equ.SelectedValue), -1);
                            DataTable sss = ma.table.Clone();
                            sss.Columns[1].DataType = typeof(string);
                            foreach (DataRow row in ma.table.Rows)
                            {
                                sss.ImportRow(row);
                            }
                            for (int i = 0; i < ma.table.Rows.Count; i++)
                            {
                                int xe = Convert.ToInt32(sss.Rows[i][1].ToString());
                                string aa = eq.Searchequ(xe);
                                sss.Rows[i][1] = aa;
                            }
                            int qx = sss.Rows.Count;
                            if (qx > 0)
                            {
                                //lbl_cor_labor_cost.Visible = false;
                                //label157.Visible = false;
                                datagrid_cor_notdone.DataSource = sss;
                                datagrid_cor_notdone.Visible = true;
                                btn_cor_bring.Visible = true;
                                btn_cor_bring.Enabled = true;
                                datagrid_cor_notdone.Columns[0].Visible = false;
                                datagrid_cor_notdone.Columns[2].Visible = false;
                                datagrid_cor_notdone.Columns[9].Visible = false;
                                datagrid_cor_notdone.Columns[11].Visible = false;
                                datagrid_cor_notdone.Columns[1].HeaderText = "Maintain Type";
                                datagrid_cor_notdone.Columns[3].HeaderText = "Total Work Hours";
                                datagrid_cor_notdone.Columns[4].HeaderText = "Maintain Parts";
                                datagrid_cor_notdone.Columns[5].HeaderText = "Maintain State";
                                datagrid_cor_notdone.Columns[6].HeaderText = "Maintain Cost";
                                datagrid_cor_notdone.Columns[7].HeaderText = "Maintain Date";
                                datagrid_cor_notdone.Columns[8].HeaderText = "Details";
                                datagrid_cor_notdone.Columns[10].HeaderText = "Maintain Type";
                                datagrid_cor_notdone.Columns[12].HeaderText = "Maintain duration";
                                datagrid_cor_notdone.Columns[13].Visible = false;
                            }
                            else
                            {
                                lbl_cor_not_done.Visible = false;
                                datagrid_cor_notdone.DataSource = new DataTable();
                                datagrid_cor_notdone.Visible = false;
                                datagrid_cor_notdone.Visible = false;
                                btn_cor_bring.Visible = false;
                                btn_cor_bring.Enabled = false;
                            }
                        }
                        catch
                        {
                            datagrid_cor_notdone.DataSource = new DataTable();
                            datagrid_cor_notdone.Visible = false;
                            datagrid_cor_notdone.Visible = false;
                            btn_cor_bring.Visible = false;
                            btn_cor_bring.Enabled = false; lbl_cor_not_done.Visible = false;
                        }  //unfinished maintan
                    } //unfinished maintan
                    txt_main_id1.Text = "";
                    txt_cor_parts.Text = "";
                    txt_cor_state.Text = "";
                    txt_cor_cost.Text = "";
                    lb_mod_5.Text = "no";
                    txt_cor_dura.Text = "";
                    txt_cor_deta.Text = "";
                    //lbl_cor_labor_cost.Text = "";
                    lbl_dai_corr_state1.Text = "";
                    txt_cor_dura.Text = "";
                    flow_cor_labors.Controls.Clear();
                    pnl_cor_names.Visible = false;
                    btn_cor_del_lapor.Visible = false;
                    if (btn_cor_del_lapor.Visible == false)
                    {
                        btn_cor_add_lapor_Click(sender, e);
                    }
                    // btn_cor_del_lapor.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " \n Please Recheck Your Data V25");
                }
            }
            else
            {
                try
                {
                    foreach (Panel con2 in flow_cor_labors.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is TextBox)
                            {
                                string partss = con.Name;
                                string[] part = Regex.Split(partss, "__");
                                if (part[0] == "t1")
                                {
                                    if (((TextBox)con).Text == "")
                                    {
                                        MessageBox.Show("Please Enter valid Technician work Hours");
                                        return;
                                    }
                                    if ((Convert.ToInt32(((TextBox)con).Text)) > Convert.ToInt32(txt_cor_dura.Text))
                                    {
                                        MessageBox.Show("Can Not Enter Technician Work Hours higher than Maintain Duration");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    if (radi_cor_done.Checked)
                    {
                        txt_cor_state.Text = "Done";
                    }
                    else if (radi_cor_notdone.Checked)
                    {
                        txt_cor_state.Text = "Not All";
                    }
                    int qwer = 0;
                    string www = "";
                    int mai_id = 0;
                    try
                    {
                        try
                        {
                            www = ma.Addmain(Convert.ToInt32(combo_cor_equ.SelectedValue), -1,
                       Convert.ToInt32(txt_main_ins31.Text), txt_cor_parts.Text, txt_cor_state.Text,
                       Convert.ToInt32(txt_cor_cost.Text), Convert.ToDateTime(date_cor.Value), txt_cor_deta.Text,
                           id, "Corrective Maintenance", "k", Convert.ToInt32(txt_cor_dura.Text), Convert.ToInt32(qwer), "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Please Write Valid Data V48" + "\n" + ex.Message); return;
                        }
                       
                        if (www == "Failed")
                        {
                            MessageBox.Show("Please Recheck Maintenance data V26"); return;
                        }
                        else if ( www == "Success")
                        {
                            mai_id = ma.bring_new_main_id();
                            ControlID22.idd = mai_id.ToString();
                            ControlID22.TextData22 = Convert.ToInt32(combo_cor_equ.SelectedValue);
                            DialogResult dialogResult = MessageBox.Show("Any Modified Oils?", "Modify Oils", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                linkLabel1_LinkClicked();
                                if (ControlID22.cancel == "")
                                {

                                }
                                else
                                {
                                    ma.del_main(mai_id);
                                    return;
                                }
                            }
                            else if (dialogResult == DialogResult.No)
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show(www); return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " \n Please Recheck Maintenance data V27"); return;
                    }
                    if (www == "Success")
                    {
                        foreach (Panel con2 in flow_cor_labors.Controls)
                        {
                            int eq = Convert.ToInt32(combo_cor_equ.SelectedValue);
                            DateTime dd = date_cor.Value;
                            int hours = 0; int iiid = 0; string det = ""; string name = "";
                            foreach (Control con in con2.Controls)
                            {
                                if (con is ComboBox)
                                {
                                    iiid = Convert.ToInt32(((ComboBox)con).SelectedValue); //////
                                    name = ((ComboBox)con).Text; //////
                                }
                                if (con is TextBox)
                                {
                                    string parts = con.Name;
                                    string[] part = Regex.Split(parts, "__");
                                    if (part[0] == "t1")
                                    {
                                        hours = Convert.ToInt32(((TextBox)con).Text); //////
                                    }
                                    else if (part[0] == "t2")
                                    {
                                        det = ((TextBox)con).Text; //////
                                        if (det == "")
                                        {
                                            det = "No Data";
                                        }
                                    }
                                }
                                if (hours != 0 && det != "" && iiid != 0 && name != "")
                                {
                                    int sala = wo.bring_labor_salary(iiid, name);
                                    string qe = worksal.Add_work_reprot(mai_id, iiid, name, eq, hours, dd, sala, det, "Corrective Maintenance", "0");
                                    if (qe == "Success")
                                    {
                                        hours = 0; iiid = 0; det = ""; name = "";
                                    }
                                }
                            }
                        }
                        int last = mai_id;

                        int aad;
                        try
                        {
                            DataTable xx2 = worksal.Find_worker_reprot(last);
                            aad = ma.update_cost(last, xx2);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " \n Could Not Calculate Labors Cost");
                            aad = 0;
                        }
                        MessageBox.Show("Done");
                        flow_cor_labors.Controls.Clear();
                        //lbl_cor_labor_cost.Visible = false;
                        //label157.Visible = false;
                        pnl_cor_names.Visible = false;
                        txt_cor_parts.Text = "";
                        txt_cor_state.Text = "";
                        txt_cor_dura.Text = "";
                        lb_mod_5.Text = "no";
                        txt_cor_cost.Text = "";
                        txt_cor_deta.Text = "";
                        //lbl_cor_labor_cost.Text = "";
                        comb_CP_main_equ_SelectedIndexChanged(sender, e);
                        if (btn_cor_del_lapor.Visible == false)
                        {
                            btn_cor_add_lapor_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " \n Please Recheck Maintenance Data V28");
                }

            }
        }


        private void linkLabel1_LinkClicked()
        {
            Form formBackground = new Form();
            try
            {
                ControlID22.info = "Add oil";
                using (pop1 uu = new pop1())
                {
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = this.Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
        private void link_upd_oil_prv_LinkClicked()
        {
            Form formBackground = new Form();
            try
            {
                ControlID22.TextData22 = Convert.ToInt32(comb_prev_main1.SelectedValue);
                ControlID22.info = "Add oil";
                ControlID22.hours =Convert.ToDecimal(txt_pre_0_now_hours.Text);
                
                using (pop1 uu = new pop1())
                {
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = this.Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                   // uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flow_dai.Controls.Clear();
            CheckBoxes2.Clear();
            if (lbl_dai_parts.Text != "a" && lbl_dai_state.Text == "a")
            {
                
                panel_dai.Visible = true;
                linkLabel2.Visible = true; 
                //panel16.Visible = true;
                string parts = lbl_dai_parts.Text;
                string[] part2 = Regex.Split(parts, "<##>");
                string[] part = Regex.Split(part2[0], "<#>");
                int n = part.Length - 1;
                CheckBox[] checkBoxB = new CheckBox[n];
                Label[] label = new Label[n];
                Panel[] pp = new Panel[n];
                for (int i = 0; i < n; i++)
                {
                    checkBoxB[i] = new CheckBox();
                    checkBoxB[i].Name = "c" + i;
                    checkBoxB[i].Text = "Checked";
                    checkBoxB[i].TextAlign = ContentAlignment.MiddleRight;
                    checkBoxB[i].Size = new Size(80, 25);
                    checkBoxB[i].Top = 30;
                    checkBoxB[i].Left = 50;
                    
                    label[i] = new Label();
                    label[i].Name = "l" + i;
                    label[i].Text = part[i];
                    label[i].Top = 50;
                    label[i].Left = 50;
                    label[i].TextAlign = ContentAlignment.MiddleLeft;
                    label[i].Size = new Size(630, 28);
                    CheckBoxes2.Add(checkBoxB[i]);

                    

                    pp[i] = new Panel();
                    pp[i].Name = "p" + i;
                    pp[i].Size = new Size(715, 5);
                    pp[i].Top = 30;
                    pp[i].Left = 50;

                    if(lbl_main_name.ForeColor == Color.DodgerBlue)
                    {
                        pp[i].BackColor = Color.DodgerBlue;
                        checkBoxB[i].ForeColor = Color.White;
                        label[i].ForeColor = Color.White;
                    }
                    else
                    {
                        pp[i].BackColor = Color.Green;
                        checkBoxB[i].ForeColor = Color.Black;
                        label[i].ForeColor = Color.Black;
                    }
                    
                }
                for (int i = 0; i < n; i++)
                {
                    flow_dai.Controls.Add(label[i]);
                    flow_dai.Controls.Add(checkBoxB[i]);
                    flow_dai.Controls.Add(pp[i]);
                }
                lb_mod_6.Text = "yes";
            }
            else if (lbl_dai_parts.Text != "a" && lbl_dai_state.Text != "a")
            {
                panel_dai.Visible = true;
                linkLabel2.Visible = true; 
                //panel16.Visible = true;
                CheckBoxes2.Clear();
                string parts = lbl_dai_parts.Text;
                string states = lbl_dai_state.Text;
                string[] part2 = Regex.Split(parts, "<##>");
                string[] part = Regex.Split(part2[0], "<#>");
                string[] state = Regex.Split(states, "<#>");
                int n = part.Length - 1;
                CheckBox[] checkBoxB = new CheckBox[n];
                Label[] label = new Label[n];
                Panel[] pp = new Panel[n];
                for (int i = 0; i < n; i++)
                {
                    checkBoxB[i] = new CheckBox();
                    checkBoxB[i].Name = "c" + i;
                    checkBoxB[i].Text = "State";
                    checkBoxB[i].TextAlign = ContentAlignment.MiddleRight;
                    checkBoxB[i].Size = new Size(80, 25);
                    checkBoxB[i].Top = 30;
                    checkBoxB[i].Left = 50;
                    if (state[i] == "Done")
                    {
                        checkBoxB[i].Checked = true;
                        checkBoxB[i].BackColor = System.Drawing.Color.Green;
                    }
                    label[i] = new Label();
                    label[i].Name = "l" + i;
                    label[i].Text = part[i];
                    label[i].Top = 50;
                    label[i].Left = 50;
                    label[i].TextAlign = ContentAlignment.MiddleLeft;
                    label[i].Size = new Size(630, 28);
                    CheckBoxes2.Add(checkBoxB[i]);
                    pp[i] = new Panel();
                    pp[i].Name = "p" + i;
                    pp[i].Size = new Size(715, 5);
                    pp[i].Top = 30;
                    pp[i].Left = 50;
                    pp[i].BackColor = Color.Green;

                }
                for (int i = 0; i < n; i++)
                {
                    flow_dai.Controls.Add(label[i]);
                    flow_dai.Controls.Add(checkBoxB[i]);
                    flow_dai.Controls.Add(pp[i]);
                }
                lb_mod_6.Text = "yes";
            }
            else
            {
                panel_dai.Visible = false;
                flow_dai.Controls.Clear(); 
                CheckBoxes2.Clear(); linkLabel2.Visible = false; 
                //panel16.Visible = false;
                MessageBox.Show("No Check List For This Equipment");
            }
        }
        private void checkBoxB_CheckedChanged(object sender, EventArgs e)
        {
            lb_mod_4.Text = "yes";
        }
        private void btn_pre_sho_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear(); 
            panel5.Visible = false;
            CheckBoxes.Clear();
            if (txt_pre_4_parts.Text != "" && txt_pre_10_stat_2.Text == "")
            {
                string parts = txt_pre_4_parts.Text;
                string[] part2 = Regex.Split(parts, "<##>");
                string[] part = Regex.Split(part2[0], "<#>");
                int n = part.Length - 1;
                CheckBox[] checkBoxB = new CheckBox[n];
                Label[] label = new Label[n];
                Panel[] pp = new Panel[n];
                for (int i = 0; i < n; i++)
                {
                    checkBoxB[i] = new CheckBox();
                    checkBoxB[i].Name = "c" + i;
                    checkBoxB[i].Text = "Checked";
                    checkBoxB[i].TextAlign = ContentAlignment.MiddleRight;
                    checkBoxB[i].Size = new Size(80, 25);
                    checkBoxB[i].Top = 30;
                    checkBoxB[i].Left = 50;
                    checkBoxB[i].CheckedChanged += new System.EventHandler(checkBoxB_CheckedChanged);
                   
                    label[i] = new Label();
                    label[i].Name = "l" + i;
                    label[i].Text = part[i];
                    label[i].Top = 50;
                    label[i].Left = 50;
                    label[i].TextAlign = ContentAlignment.MiddleLeft;
                    label[i].Size = new Size(630, 28);
                    CheckBoxes.Add(checkBoxB[i]);
                   
                    pp[i] = new Panel();
                    pp[i].Name = "p" + i;
                    pp[i].Size = new Size(715, 5);
                    pp[i].Top = 30;
                    pp[i].Left = 50;

                    if(label37.ForeColor == Color.DodgerBlue)
                    {
                        checkBoxB[i].ForeColor = Color.White;
                        label[i].ForeColor = Color.White;
                        pp[i].BackColor = Color.DodgerBlue;
                    }
                    else
                    {
                        checkBoxB[i].ForeColor = Color.Black;
                        label[i].ForeColor = Color.Black;
                        pp[i].BackColor = Color.Green;
                    }
                }
                panel5.Visible = true;
                for (int i = 0; i < n; i++)
                {
                    flowLayoutPanel2.Controls.Add(label[i]);
                    flowLayoutPanel2.Controls.Add(checkBoxB[i]);
                    flowLayoutPanel2.Controls.Add(pp[i]);
                }
                panel1.Visible = true;
            }
            else if (txt_pre_4_parts.Text != "" && txt_pre_10_stat_2.Text != "")
            {
                CheckBoxes.Clear();
                string parts = txt_pre_4_parts.Text;
                string states = txt_pre_10_stat_2.Text;
                string[] part2 = Regex.Split(parts, "<##>");
                string[] part = Regex.Split(part2[0], "<#>");
                string[] state = Regex.Split(states, "<#>");
                int n = part.Length - 1;
                CheckBox[] checkBoxB = new CheckBox[n];
                Label[] label = new Label[n];
                Panel[] pp = new Panel[n];
                for (int i = 0; i < n; i++)
                {
                    checkBoxB[i] = new CheckBox();
                    checkBoxB[i].Name = "c" + i;
                    checkBoxB[i].Text = "Checked";
                    checkBoxB[i].TextAlign = ContentAlignment.MiddleRight;
                    checkBoxB[i].Size = new Size(80, 25);
                    checkBoxB[i].Top = 30;
                    checkBoxB[i].Left = 50;
                    checkBoxB[i].ForeColor = System.Drawing.Color.White;
                    if (state[i] == "Done")
                    {
                        checkBoxB[i].Checked = true;
                        checkBoxB[i].BackColor = System.Drawing.Color.DodgerBlue;
                    }
                    label[i] = new Label();
                    label[i].Name = "l" + i;
                    label[i].Text = part[i];
                    label[i].Top = 50;
                    label[i].Left = 50;
                    label[i].TextAlign = ContentAlignment.MiddleLeft;
                    label[i].Size = new Size(630, 28);
                    label[i].ForeColor = System.Drawing.Color.White;
                    CheckBoxes.Add(checkBoxB[i]);
                    pp[i] = new Panel();
                    pp[i].Name = "p" + i;
                    pp[i].Size = new Size(715, 5);
                    pp[i].Top = 30;
                    pp[i].Left = 50;
                    pp[i].BackColor = Color.DodgerBlue;

                }
                panel5.Visible = true;
                for (int i = 0; i < n; i++)
                {
                    flowLayoutPanel2.Controls.Add(label[i]);
                    flowLayoutPanel2.Controls.Add(checkBoxB[i]);
                    flowLayoutPanel2.Controls.Add(pp[i]);
                }
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                flowLayoutPanel2.Controls.Clear();
                CheckBoxes.Clear();
            }
        }
        List<string> data;    
        protected void LB_Click(object sender, EventArgs e)
        {
            string h = "";
            if (sender is PictureBox)
            {
                PictureBox pic = sender as PictureBox;
                h = pic.Name;
            }
            if (sender is Label)
            {
                Label lbl = sender as Label;
                h = lbl.Name;
            }
            string[] lines = Regex.Split(h, "_");
            int x = Convert.ToInt32(lines[1]);
            string Oil_s = "Oil State:";
            string Maintinance_s =  "Maintinance State:";
            string done = "done";
            for (int i = x; i < data.Count; i++)
            {
                if (x == i)
                {
                    continue;
                }
                if (data[i] == "Green<#>" || data[i] == "<#>This Equipment Does not have Hours Counter")
                {
                    continue;
                }
                if (data[i] != "END")
                {
                    string[] lines3 = Regex.Split(data[i], "<#>");
                    if (lines3.Length > 1)
                    {
                        done = "";
                        Oil_s = Oil_s + "\n" + lines3[1];
                    }
                    else
                    {
                        done = "";
                        Oil_s = Oil_s + "\n" + data[i];
                    }
                }
                if (data[i] == "END")
                {
                    Maintinance_s = Maintinance_s + "\n" + data[i + 2] + "\n" + data[i + 3];
                    break;
                }
            }
            if( done == "" && Maintinance_s != "Maintinance State:\n\n")
            {
                MessageBox.Show( Oil_s + " \n "+ " \n" + Maintinance_s );
            }
            else if (done == "")
            {
                MessageBox.Show(Oil_s);
            }
            else if(Maintinance_s != "Maintinance State:\n\n")
            {
                MessageBox.Show(Maintinance_s);
            }
        }
        protected void pic1_Click(object sender, EventArgs e)
        {
            string h = "";
            if (sender is PictureBox)
            {
                PictureBox pic = sender as PictureBox;
                h = pic.Name;
            }
            //if (sender is Label)
            //{
            //    Label lbl = sender as Label;
            //    h = lbl.Name;
            //}
            string[] lines = Regex.Split(h, "_");
            int x = Convert.ToInt32(lines[1]);
            string Oil_s = "Oil State:";
            string done = "done";
            for (int i = x; i < data.Count; i++)
            {
                if (x == i)
                {
                    continue;
                }
                if (data[i] == "Green<#>" || data[i] == "<#>This Equipment Does not have Hours Counter")
                {
                    continue;
                }
                if (data[i] == "END")
                {
                    break;
                }
                if (data[i] != "END")
                {
                    string[] lines3 = Regex.Split(data[i], "<#>");
                    if(lines3.Length>1)
                    {
                        done = "";
                        Oil_s = Oil_s + "\n" + lines3[1];
                    }
                    else
                    {
                        done = "";
                        Oil_s = Oil_s + "\n" + data[i];
                    }
                }
            }
            if (done == "")
            {
                DialogResult dialogResult = MessageBox.Show("Flueids exceeded accepted values: " + "\n" + "\n" + Oil_s + "\n" + "\n" + "Has the problem been Solved?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string ss = oi.ignore(data[x]);
                    if (ss == "Success")
                    {
                        MessageBox.Show("Data Modified"); btn_notf_Click(sender,e);
                    }
                    else { MessageBox.Show("Error \n Please Try Again"); btn_notf_Click(sender, e); }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }          
        }
        protected void pic2_Click(object sender, EventArgs e)
        {
            string h = "";
            if (sender is PictureBox)
            {
                PictureBox pic = sender as PictureBox;
                h = pic.Name;
            }
            //if (sender is Label)
            //{
            //    Label lbl = sender as Label;
            //    h = lbl.Name;
            //}
            string[] lines = Regex.Split(h, "_");
            int x = Convert.ToInt32(lines[1]);
            string Maintinance_s = "Maintinance State:";
            for (int i = x; i < data.Count; i++)
            {
                if (data[i] == "END")
                {
                    Maintinance_s = Maintinance_s + "\n" + data[i + 2] + "\n" + data[i + 3];
                    break;
                }
            }
            if (Maintinance_s != "Maintinance State:\n\n")
            { MessageBox.Show(Maintinance_s); }
        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            #region MyRegion
            bool id;  //done
            bool state; //done
            bool cost; //done
            bool word; //done
            int idd; //done
            List<string> type_name = new List<string>(); //done
            //string[] type_name1; //done
            //string[] type_name2;//done
            string states = ""; //done
            string words = ""; //done
            decimal cost1 = 0; //done
            decimal cost2 = 0; //done
            lb_mod_31.Text = "yes";


            if (check_id.Checked)
            {
                if (com_report.SelectedValue == null || com_report.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Choose Equipment");
                    return;
                }
                id = true;
                idd = Convert.ToInt32(com_report.SelectedValue);
            }
            else { id = false; idd = 0; }


            if (chk_rep_word.Checked)
            {
                word = true;
                words = txt_rep_word.Text;
            }
            else { word = false; words = ""; }

            if (check_cost.Checked)
            {
                if (chk_cost3.Checked == false)
                {
                    if (txt_cost1.Text == "" || txt_cost2.Text == "")
                    {
                        MessageBox.Show("Please Enter Valid Cost");
                        return;
                    }
                    cost = true;
                    cost1 = Convert.ToDecimal(txt_cost1.Text);
                    cost2 = Convert.ToDecimal(txt_cost2.Text);
                    if (cost1 <= cost2)
                    {
                        cost1 = Convert.ToDecimal(txt_cost1.Text);
                        cost2 = Convert.ToDecimal(txt_cost2.Text);
                    }
                    else
                    {
                        cost2 = Convert.ToDecimal(txt_cost1.Text);
                        cost1 = Convert.ToDecimal(txt_cost2.Text);
                    }
                }
                else
                {
                    cost = true;
                    cost1 = Convert.ToDecimal(txt_cost3.Text);
                    cost2 = -1010101;
                }
            }
            else { cost = false; }
            if (check_state.Checked)
            {
                if (radio_done.Checked)
                {
                    states = "Done";
                }
                else if (radio_not.Checked)
                {
                    states = "Not All";
                }
                else
                {
                    MessageBox.Show("Please Choose Done Or Not All First");
                }
                state = true;
            }
            else
            {
                state = false;
            }

            if (check_type.Checked)
            {
                if (check_prev.Checked)
                {
                    type_name.Add("Periodic Maintenance");
                }
                if (check_corr.Checked)
                {
                    type_name.Add("Corrective Maintenance");
                }
                if (check_daily.Checked)
                {
                    type_name.Add("Daily Maintenance");
                }
            }
            else
            {
                type_name = new List<string>();
            }

            #endregion
            DataTable dt = ma.search_main(id, idd, type_name, date_old.Value.Date, date_new.Value.Date,
                state, states, cost, cost1, cost2, word, words);

            DataTable sss = dt.Clone();
            sss.Columns[1].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                sss.ImportRow(row);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string aa = eq.Searchequ(Convert.ToInt32(sss.Rows[i][1].ToString()));
                sss.Rows[i][1] = aa;
                string[] part = Regex.Split(sss.Rows[i][4].ToString(), "<##>");
                sss.Rows[i][4] = part[0];
            }
            int parts = 0;
            int lap = 0;
            int total = 0;
            int filte = 0;
            int fuwew = 0/*ma.main_state_details*/;
            int oii = 0/*ma.main_hours_repair*/;
            if (sss.Rows.Count > 0)
            {
                for (int r = 0; r < sss.Rows.Count; r++)
                {
                    parts = parts + Convert.ToInt32(dt.Rows[r][6].ToString());
                    lap = lap + Convert.ToInt32(dt.Rows[r][19].ToString());
                    fuwew = fuwew + Convert.ToInt32(dt.Rows[r][15].ToString());
                    oii = oii + Convert.ToInt32(dt.Rows[r][14].ToString());
                    filte = filte + Convert.ToInt32(dt.Rows[r][16].ToString());
                    total = total + Convert.ToInt32(dt.Rows[r][17].ToString());
                }
            }
            else
            {
                parts = 0; lap = 0; total = 0; oii = 0; fuwew = 0; filte = 0;
            }
            sss.Columns["main_cost"].SetOrdinal(12);
            sss.Columns["Labors Cost"].SetOrdinal(14);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = sss;
            dataGridView1.Visible = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Counter";
            dataGridView1.Columns[4].HeaderText = "Parts";
            dataGridView1.Columns[5].HeaderText = "State";
            dataGridView1.Columns[6].HeaderText = "Posting Date";
            dataGridView1.Columns[7].HeaderText = "Details";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].HeaderText = "Maintain Type";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Repair Duration";
            dataGridView1.Columns[12].HeaderText = "Parts Cost";
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
           
            
            //sss.Columns["Unit"].SetOrdinal(1);

            //total = parts + lap + Convert.ToInt32(fuwew) + oii;
            label94.Text = fuwew.ToString() + " $";
            label138.Text = oii.ToString() + " $";
            label217.Text = filte.ToString() + " $";
            label120.Text = parts.ToString() + " $";
            label119.Text = lap.ToString() + " $";
            label122.Text = total.ToString() + " $";

            panel9.Visible = true;
            panel11.Visible = true;
            panel11.Enabled = true;

            if(dataGridView1.Rows.Count>0)
            {
                panel11.Enabled = true;
            }
            else
            {
                panel11.Enabled = false;
            }

        }
        private void btn_bring_to_upd_Click(object sender, EventArgs e)
        {
            string[] arrx = new string[14];
            int xy = Convert.ToInt32(dat_grid_prev1.Rows[dat_grid_prev1.SelectedCells[0].RowIndex].Cells["main_id"].Value);// main id
            arrx = ma.bring_prev(xy);
            txt_pre_1_id.Text = arrx[0];// id
            txt_pre_2_type_number.Text = arrx[1];// stage numper
            txt_pre_3_hours.Text = arrx[2];// hours when done
            txt_pre_4_parts.Text = arrx[3];//parts
            //state
            txt_pre_6_cost.Text = arrx[5];//cost
            date_prv.Value = Convert.ToDateTime(arrx[6]);//date
            txt_pre_7_det.Text = arrx[7];//details
            txt_pre_8_user.Text = arrx[8];//user id
            txt_pre_9_type_name.Text = arrx[9];//name
            txt_pre_10_stat_2.Text = arrx[10];//state details
            txt_duration.Text = arrx[11];//time needed
            //label102.Text = arrx[12];//labor cost
            //txt_pre_9_type_name.Text = "Periodic Maintenance";
            //label102.Visible = true;
            //lbl_state_prev.Text = "Update";
            //label101.Visible = true;
            DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_pre_1_id.Text));
            int x = xx.Rows.Count;
            int total = 0;
            if (x > 0)
            {
                flow_labor.Controls.Clear();
                lbl_prv_after.Visible = true;
                lowww_prv.Visible = true;
               //lbl_prv_hrs_stage3.Visible = true;
              //  lbl_prv_hrs_stage4.Visible = true;
                int sw = 0; dea = 0;
                report_iid = new int[x];
                for (int w = 0; w < x; w++)
                {
                    btn_del_labor.Visible = true;
                    btn_del_labor.Enabled = true;
                    pnl_labor.Visible = true;

                    ComboBox comb = new ComboBox();
                    TextBox txt = new TextBox();
                    TextBox txtd = new TextBox();
                    CheckBox lp = new CheckBox();
                    Panel pp = new Panel();

                    pp.Name = "p" + dea;
                    pp.Size = new Size(500, 30);

                    comb.Name = "c" + dea;
                    comb.Size = new Size(150, 21);
                    comb.Location = new Point(27, 4);
                    report_iid[w] = Convert.ToInt32(xx.Rows[w][0].ToString());
                    comb.SelectedText = xx.Rows[w][3].ToString();
                    comb.SelectedValue = xx.Rows[w][2].ToString();
                    comb.Enabled = false;

                    txt.Name = "t1__" + dea;
                    txt.Size = new Size(60, 20);
                    txt.Location = new Point(184, 4);
                    txt.Text = xx.Rows[w][5].ToString();
                    txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);

                    sw = dea + 1;
                    lp.Name = "lp" + dea;
                    lp.Text = sw + " -";
                    lp.Size = new Size(20, 20);
                    lp.Location = new Point(6, 4);

                    txtd.Name = "t2__" + dea;
                    txtd.Text = xx.Rows[w][8].ToString();
                    txtd.Size = new Size(245, 20);
                    txtd.Location = new Point(251, 4);

                    pp.Controls.Add(comb);
                    pp.Controls.Add(txt);
                    pp.Controls.Add(txtd);
                    pp.Controls.Add(lp);
                    flow_labor.Controls.Add(pp);
                    total = total + Convert.ToInt32(xx.Rows[w][9].ToString());
                    dea++;
                }
            }
            else
            {
                pnl_labor.Visible = false;
                flow_labor.Controls.Clear();
                btn_del_labor.Visible = false;
                btn_del_labor.Enabled = false;
            }
            btn_pre_sho_Click(sender, e);
            //txt_pre_3_hours.Visible = true;
            //lbl_prv2.Visible = true;
        }
        private void btn_add_labor_Click(object sender, EventArgs e)
        {
            int io = 0;
            foreach (Panel pan in flow_labor.Controls)
            {
                io++;
            }
            lb_mod_4.Text = "yes";
            dea = io;
            btn_del_labor.Visible = true;
            btn_del_labor.Enabled = true;
            pnl_labor.Visible = true;
            flow_labor.Visible = true;

            ComboBox comb = new ComboBox();
            TextBox txt = new TextBox();
            TextBox txtd = new TextBox();
            CheckBox lp = new CheckBox();
            Panel pp = new Panel();
            lp.ForeColor = Color.White;
            pp.Name = "p" + dea;
            pp.Size = new Size(500, 30);

            comb.Name = "c" + dea;
            comb.Size = new Size(150, 21);
            comb.Location = new Point(27, 4);
            DataTable asdq = wo.bring_labor_names();
            comb.DataSource = asdq;

            comb.ValueMember = "worker_id";
            comb.DisplayMember = "worker_name";
            comb.SelectedIndex = -1;

            txt.Name = "t1__" + dea;
            txt.Size = new Size(60, 20);
            txt.Location = new Point(184, 4);
            txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);


            int sw = dea + 1;
            lp.Name = "lp" + dea;
            lp.Text = sw + " -";
            lp.Size = new Size(20, 20);
            lp.Location = new Point(6, 7);
            if (lbl_state_prev.Text == "Report" || lbl_state_prev.Text == "Update")
            {
                lp.Checked = true;
                lp.Enabled = false;
            }

            txtd.Name = "t2__" + dea;
            txtd.Size = new Size(245, 20);
            txtd.Location = new Point(251, 4);

            pp.Controls.Add(comb);
            pp.Controls.Add(txt);
            pp.Controls.Add(txtd);
            pp.Controls.Add(lp);
            flow_labor.Controls.Add(pp);
            dea++;
        }
        private void btn_del_labor_Click(object sender, EventArgs e)
        {
            if (lbl_state_prev.Text == "iiki")
            {
                int io = 0;
                foreach (Panel pan in flow_labor.Controls)
                {
                    io++;
                }
                io--;
                for (int y = 0; y <= io; y++)
                {
                    foreach (Panel pan in flow_labor.Controls)
                    {
                        string qwee = "p" + io;
                        if (pan.Name == qwee)
                        { flow_labor.Controls.Remove(pan); dea--; }
                    }
                }
                if (io == 0)
                {
                    btn_del_labor.Visible = false;
                    btn_del_labor.Enabled = false;
                    pnl_labor.Visible = false;
                }
            }
            else
            {
                int io = 0; int x = 0;
                foreach (Panel pan in flow_labor.Controls)
                {
                    io++;
                }
                x = io;
                string aaaqwe = "no";
                for (int i = 0; i <= io; i++)
                {
                    foreach (Panel con2 in flow_labor.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is CheckBox)
                            {
                                if (((CheckBox)con).Checked)
                                {
                                    aaaqwe = "yes";
                                }
                            }
                        }
                    }
                }
                if (aaaqwe == "yes")
                {
                    DialogResult dialogResult = MessageBox.Show("Sure to Erase All Selected Technicians from this maintenance", "Alert",
                        MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Please Make Sure to press update to save changes once Finished");
                        dea = 0;

                        for (int i = 0; i <= io; i++)
                        {
                            foreach (Panel con2 in flow_labor.Controls)
                            {
                                foreach (Control con in con2.Controls)
                                {
                                    if (con is CheckBox)
                                    {
                                        if (((CheckBox)con).Checked)
                                        {
                                            string aaa = con.Name;
                                            string[] part = Regex.Split(aaa, "lp");
                                            try
                                            {
                                                //worksal.del_work_reprot(report_iid[Convert.ToInt32(part[1])]);
                                                con2.Dispose();
                                                dea--;
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                            x--;
                                            if (x == 0)
                                            {
                                                pnl_labor.Visible = false;
                                                btn_del_labor.Visible = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Please Check Data to Erase");
                    }
                }
                else { MessageBox.Show("Please Mark CheckBox to Erase"); }
            }
        }
        private void btn_add_labor2_Click(object sender, EventArgs e)
        {
            int io = 0;
            foreach (Panel pan in flow_labor2.Controls)
            {
                io++;
            }
            lb_mod_6.Text = "yes";
            dea = io;
            flow_labor2.Visible = true;
            btn_del_labor2.Visible = true;
            btn_del_labor2.Enabled = true;
            pnl_labor2.Visible = true;

            ComboBox comb = new ComboBox();
            TextBox txt = new TextBox();
            TextBox txtd = new TextBox();
            CheckBox lp = new CheckBox();
            Panel pp = new Panel();

            pp.Name = "p" + dea;
            pp.Size = new Size(500, 30);

            comb.Name = "c" + dea;
            comb.Size = new Size(150, 21);
            comb.Location = new Point(27, 4);
            DataTable asdq = wo.bring_labor_names();
            comb.DataSource = asdq;

            comb.ValueMember = "worker_id";
            comb.DisplayMember = "worker_name";
            comb.SelectedIndex = -1;

            txt.Name = "t1__" + dea;
            txt.Size = new Size(60, 20);
            txt.Location = new Point(184, 4);
            txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);

            int sw = dea + 1;
            lp.Name = "lp" + dea;
            lp.Text = sw + " -";
            lp.Size = new Size(20, 20);
            lp.Location = new Point(6, 7);

            txtd.Name = "t2__" + dea;
            txtd.Size = new Size(245, 20);
            txtd.Location = new Point(251, 4);

            pp.Controls.Add(comb);
            pp.Controls.Add(txt);
            pp.Controls.Add(txtd);
            pp.Controls.Add(lp);
            flow_labor2.Controls.Add(pp);
            dea++;
        }
        private void btn_del_labor2_Click(object sender, EventArgs e)
        {
            if (lbl_dai_corr_state.Text != "Report")
            {
                int io = 0;
                foreach (Panel pan in flow_labor2.Controls)
                {
                    io++;
                }
                io--;
                for (int y = 0; y <= io; y++)
                {
                    foreach (Panel pan in flow_labor2.Controls)
                    {
                        string qwee = "p" + io;
                        if (pan.Name == qwee)
                        { flow_labor2.Controls.Remove(pan); dea--; }
                    }
                }
                if (io == 0)
                {
                    btn_del_labor2.Visible = false;
                    btn_del_labor2.Enabled = false;
                    pnl_labor2.Visible = false;
                }
            }
            else
            {
                int io = 0; int x = 0;
                foreach (Panel pan in flow_labor2.Controls)
                {
                    io++;
                }
                x = io;
                string aaaqwe = "no";
                for (int i = 0; i <= io; i++)
                {
                    foreach (Panel con2 in flow_labor2.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is CheckBox)
                            {
                                if (((CheckBox)con).Checked)
                                {
                                    aaaqwe = "yes";
                                }
                            }
                        }
                    }
                }
                if (aaaqwe == "yes")
                {
                    DialogResult dialogResult = MessageBox.Show("Sure to Erase All Selected Technicians from this maintenance", "Alert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Please Make Sure to press update to save changes once Finished");
                        dea = 0;
                        for (int i = 0; i <= io; i++)
                        {
                            foreach (Panel con2 in flow_labor2.Controls)
                            {
                                foreach (Control con in con2.Controls)
                                {
                                    if (con is CheckBox)
                                    {
                                        if (((CheckBox)con).Checked)
                                        {
                                            string aaa = con.Name;
                                            string[] part = Regex.Split(aaa, "lp");
                                            try
                                            {
                                                worksal.del_work_reprot(report_iid[Convert.ToInt32(part[1])]);
                                                con2.Dispose();
                                                dea--;
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                                con2.Dispose();
                                                dea--;
                                            }
                                            x--;
                                            if (x == 0)
                                            {
                                                pnl_labor2.Visible = false;
                                                btn_del_labor2.Visible = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Please Check Data to Erase");
                    }
                }
                else { MessageBox.Show("Please Mark CheckBox to Erase"); }
            }
        }
        #endregion
        private void btn_report_lp_Click(object sender, EventArgs e)
        {
            bool lp_id;  //done
            bool date; //done
            bool eq_id; //done
            int lp_idd; //done
            int eq_idd; //done
            lb_mod_32.Text = "yes";
            DateTime date_new2 = date_rep_new.Value; //done
            //DateTime date_new = date_rep_new.Date;
            DateTime date_old2 = date_rep_old.Value; //done
            //DateTime date_old = date_new2.Date;
            if (chk_id.Checked)
            { lp_id = true; lp_idd = Convert.ToInt32(combo_labor_report.SelectedValue); }
            else { lp_id = false; lp_idd = 0; }
            if (chk_date.Checked)
            {
                date = true;
            }
            else { date = false; }
            if (chk_equ.Checked)
            { eq_id = true; eq_idd = Convert.ToInt32(comboBox1.SelectedValue); }
            else { eq_id = false; eq_idd = 0; }
            DataTable dt = worksal.search_lapor(lp_id, lp_idd, eq_id, eq_idd, date, Convert.ToDateTime(date_rep_old.Value.Date), Convert.ToDateTime(date_rep_new.Value.Date));
            DataTable sss = dt.Clone();
            sss.Columns[4].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                sss.ImportRow(row);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int x = Convert.ToInt32(sss.Rows[i][4].ToString());
                string aa = eq.Searchequ(x);
                sss.Rows[i][4] = aa;
            }
            if (sss.Rows.Count > 0)
            {
                sss.Columns.Add("Maintenance Type");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] aa = ma.bring_prev(Convert.ToInt32(sss.Rows[i][1].ToString())); 
                    if(aa.Length > 0)
                    {
                        string num = aa[9].ToString();
                        string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                        sss.Rows[i][10] = part2[0];
                    }
                }
                dataGridView2.Visible = true;
                panel6.Visible = true;
                panel6.Enabled = true;
                dataGridView2.Columns.Clear();// = sss;
                dataGridView2.DataSource = sss;
                //dataGridView2.Columns[1].HeaderText = "Maintenance ID";
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.Columns[11].Visible = false;
                dataGridView2.Columns[12].Visible = false;
                dataGridView2.Columns[3].HeaderText = "Technician Name";
                dataGridView2.Columns[4].HeaderText = "Equipment ID";
                dataGridView2.Columns[5].HeaderText = "Work Hours";
                dataGridView2.Columns[6].HeaderText = "Posting Date";
                dataGridView2.Columns[8].HeaderText = "Details";
                dataGridView2.Columns[9].HeaderText = "Technician Cost";
                dataGridView2.Columns[10].HeaderText = "Job Type";
                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
                dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView2.ColumnHeadersHeight = 40;
                dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                int lap = 0;
                if (sss.Rows.Count > 0)
                {
                    for (int r = 0; r < sss.Rows.Count; r++)
                    {
                        lap = lap + Convert.ToInt32(sss.Rows[r][9].ToString());
                        panel10.Visible = true;
                        label128.Text = lap.ToString() + " $";
                    }
                }
                else { panel10.Visible = false; lap = 0; label128.Text = ""; }

            }
            else { panel6.Enabled = false; dataGridView2.DataSource = new DataTable(); dataGridView2.Visible = false; panel10.Visible = false; panel10.Visible = false; label128.Text = ""; }
        }
        private void chk_id_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_id.Checked)
            { combo_labor_report.Enabled = true; }
            else { combo_labor_report.Enabled = false; }
            dataGridView2.DataSource = new DataTable();
            panel6.Visible = false;
        }
        private void chk_equ_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_equ.Checked)
            { comboBox1.Enabled = true; }
            else { comboBox1.Enabled = false; }
            dataGridView2.DataSource = new DataTable(); panel6.Visible = false;
        }
        private void chk_date_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_date.Checked)
            {
                date_rep_old.Enabled = true; date_rep_new.Enabled = true;
            }
            else { date_rep_old.Enabled = false; date_rep_new.Enabled = false; }
            dataGridView2.DataSource = new DataTable(); panel6.Visible = false;
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                ControlID22.TextData22 = Convert.ToInt32(comb_add_hours.SelectedValue);
                ControlID22.info = "Hours Details";
                ControlID22.cancel = lbl_main_id.Text;
                using (pop1 uu = new pop1())
                {
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = this.Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    //uu.Owner = formBackground;
                    uu.ShowDialog();

                    //formBackground.Dispose();
                    comb_add_hours_SelectedIndexChanged(sender, e);
                    ControlID22.cancel = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
                ControlID22.cancel ="";
            }
        }
        private void comb_prv_sq_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ww = "";
                ww = ma.bring_all_prev_parts(Convert.ToInt32(combo_equ_show.SelectedValue), Convert.ToInt32(comb_prv_sq.Text));
                if (ww !="")
                {
                    tableLayoutPanel1.Visible = false;
                    string[] lines2 = Regex.Split(ww, "<##>");
                    string[] lines = Regex.Split(lines2[0], "<#>");
                    string[] qua = Regex.Split(lines2[1], "<#>");
                    //Label lb = new Label();
                    tableLayoutPanel1.SuspendLayout();

                    while (tableLayoutPanel1.RowCount > 1)
                    {
                        int row = tableLayoutPanel1.RowCount - 1;
                        for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                        {
                            Control c = tableLayoutPanel1.GetControlFromPosition(i, row);
                            tableLayoutPanel1.Controls.Remove(c);
                            //c.Dispose();
                        }

                        tableLayoutPanel1.RowStyles.RemoveAt(row);
                        tableLayoutPanel1.RowCount--;
                    }

                    tableLayoutPanel1.ResumeLayout(false);
                    tableLayoutPanel1.PerformLayout();
                    tableLayoutPanel1.Size = new System.Drawing.Size(366, 33 + (((lines.Length) - 1) * 40));
                    //Label lb2 = new Label();
                    //flowLayoutPanel1.Controls.Clear();
                    textBox15.Text = ma.main_cost.ToString();
                    textBox15.Enabled = true;
                    for (int rw=0; rw < lines.Length-1;rw++)
                    {
                        AddItem(tableLayoutPanel1, new Label() {Text =Convert.ToString(rw+1) + "-" }, new Label() { Text = lines[rw]}, new Label() { Text = qua[rw]});
                    }
                    tableLayoutPanel1.Visible = true;
                }
                else
                {
                    textBox15.Text = "";
                    textBox15.Enabled = false;
                    //tableLayoutPanel2.Visible = false;
                }
            }
            catch
            {
                //tableLayoutPanel2.Visible = false;
            }
        }
        private void btn_rep_lb_del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete this report?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int a = Convert.ToInt32(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells["report_id"].Value);
                worksal.del_work_reprot(a);
                if (dataGridView4.Rows.Count > 0)
                {
                    pictureBox12_Click(sender, e);
                }
                if (dataGridView7.Rows.Count > 0)
                {
                    pictureBox7_Click(sender, e);
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    pictureBox6_Click(sender, e);
                }
                if (dataGridView2.Rows.Count > 0)
                {
                    btn_report_lp_Click(sender, e);
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    btn_report_Click(sender, e);
                }
            }
            if (dialogResult == DialogResult.No)
            { }
        }
        private void btn_rep_lb_up_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                ControlID22.TextData22 = Convert.ToInt32(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells["report_id"].Value);
                ControlID22.info = "Update Labor";
                using (pop1 uu = new pop1())
                {
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = this.Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                    btn_report_lp_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
                dataGridView2.DefaultCellStyle.BackColor = Color.White;
                dataGridView2.Enabled = true;
                main_rep.Enabled = true;
                usa_ava.Enabled = true;
                //button1.Enabled = true;
                panel8.Enabled = true;
            }
        }
        private void btn_bring_to_upd2_Click(object sender, EventArgs e)
        {
            //dataGrid_cor_dai.CurrentRow.Selected = true;
            string[] arrx = new string[15];
            int xy = Convert.ToInt32(dataGrid_cor_dai.Rows[dataGrid_cor_dai.SelectedCells[0].RowIndex].Cells["main_id"].Value);// main id
            arrx = ma.bring_prev(xy);
            txt_main_id.Text = arrx[0];// id
            //txt_main_ins2.Text = arrx[1];// stage numper
            txt_main_ins3.Text = arrx[2];// hours when done
            txt_main_ins4.Text = arrx[3];//parts
            //state
            txt_main_ins6.Text = arrx[5];//cost
            date_main_ins.Value = Convert.ToDateTime(arrx[6]);//date
            txt_main_ins7.Text = arrx[7];//details
            txt_main_ins8.Text = arrx[8];//user id
            //txt_main_ins22.Text = arrx[9];//name
            txt_main_stg_det_corr.Text = arrx[10];//state details
            txt_duration2.Text = arrx[11];//time needed
            //label1072.Text = arrx[12];//labor cost
            lbl_dai_corr_state.Text = "Update";
            //label1072.Visible = true;
            //label114.Visible = true;
            btn_add_labor2.Visible = true;
            btn_add_labor2.Enabled = true;
            DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_main_id.Text));
            int total = 0;
            int x = xx.Rows.Count;
            if (x > 0)
            {
                flow_labor2.Controls.Clear();
                btn_add_labor2.Visible = true;
                btn_add_labor2.Enabled = true;
                int sw = 0; dea = 0;
                for (int w = 0; w < x; w++)
                {
                    btn_del_labor2.Visible = true;
                    btn_del_labor2.Enabled = true;
                    pnl_labor2.Visible = true;

                    ComboBox comb = new ComboBox();
                    TextBox txt = new TextBox();
                    TextBox txtd = new TextBox();
                    CheckBox lp = new CheckBox();
                    Panel pp = new Panel();

                    pp.Name = "p" + dea;
                    pp.Size = new Size(500, 30);

                    comb.Name = "c" + dea;
                    comb.Size = new Size(150, 21);
                    comb.Location = new Point(27, 4);
                    comb.SelectedText = xx.Rows[w][3].ToString();
                    comb.SelectedValue = xx.Rows[w][2].ToString();
                    comb.Enabled = false;

                    txt.Name = "t1__" + dea;
                    txt.Size = new Size(60, 20);
                    txt.Location = new Point(184, 4);
                    txt.Text = xx.Rows[w][5].ToString();
                    txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);


                    sw = dea + 1;
                    lp.Name = "lp" + dea;
                    lp.Text = sw + " -";
                    lp.Size = new Size(20, 20);
                    lp.Location = new Point(6, 4);


                    txtd.Name = "t2__" + dea;
                    txtd.Text = xx.Rows[w][8].ToString();
                    txtd.Size = new Size(245, 20);
                    txtd.Location = new Point(251, 4);

                    pp.Controls.Add(comb);
                    pp.Controls.Add(txt);
                    pp.Controls.Add(txtd);
                    pp.Controls.Add(lp);
                    flow_labor2.Controls.Add(pp);
                    total = total + Convert.ToInt32(xx.Rows[w][9].ToString());
                    dea++;
                }
            }
            else
            {
                pnl_labor2.Visible = false;
                flow_labor2.Controls.Clear();
                btn_add_labor2.Visible = true;
                btn_add_labor2.Enabled = true;
                btn_del_labor2.Visible = false;
                btn_del_labor2.Enabled = false;
            }
            label107.Visible = false;
            dataGrid_cor_dai.DataSource = new DataTable();
            dataGrid_cor_dai.Visible = false;
            // btn_prv_update2.Visible = true;
            // btn_prv_update2.Enabled = true;
            // btn_main_ins.Enabled = false;
            // btn_main_ins.Visible = false;
        }
        private void btn_use_Click(object sender, EventArgs e)
        {
            if(combo_use.SelectedIndex==-1)
            {
                MessageBox.Show("Please Choose Equipment First");return;
            }
            var dateAndTime = date_use_old.Value;
            var dateAndTime2 = date_use_new.Value;
            var date = dateAndTime.Date;
            var date2 = dateAndTime2.Date;
            DataTable ava =equ_work.available(Convert.ToInt32(combo_use.SelectedValue), date, date2);
            DataTable use = equ_work.usability(Convert.ToInt32(combo_use.SelectedValue), date, date2);
            DataTable all = equ_work.ava_use(ava, use, Convert.ToInt32(combo_use.SelectedValue));
            

            lb_mod_33.Text = "yes";
            if (all.Rows.Count > 0)
            {
                //foreach(DataRow dr in all.Rows)
                //{
                //    dr["Availabile Hours"] = 24 - Convert.ToInt32(dr["Work Hours"]) - Convert.ToInt32(dr["Maintenance Hours"]);
                //}
                dataGridView5.Columns.Clear();
                dataGridView5.DataSource = all;
                dataGridView5.Visible = true;
                dataGridView5.Columns["Counter"].Visible = false;
                string[] rd = new string[all.Rows.Count];
                double[] aa = new double[all.Rows.Count];
                string[] rd2 = new string[all.Rows.Count];
                double[] aa2 = new double[all.Rows.Count];
                for (int y = 0; y < all.Rows.Count; y++)
                {
                    rd[y] = all.Rows[y][5].ToString();
                    string[] lines = Regex.Split(rd[y], "%");
                    aa[y] = Convert.ToDouble(lines[0]);
                }
                double r = 0;
                for (int y = 0; y < aa.Length; y++)
                {
                    r = r + aa[y];
                }
                double qq = aa.Length;
                panel13.Visible = true;
                double faf = r / qq;
                if(faf > 100)
                {
                    faf = 100;
                }
                circularProgressBar1.Value = Convert.ToInt32( faf );
                label130.Text = (r / qq).ToString("0.##") + " %";
                
                
                
                for (int y = 0; y < all.Rows.Count; y++)
                {
                    rd2[y] = all.Rows[y][4].ToString();
                    string[] lines = Regex.Split(rd2[y], "%");
                    aa2[y] = Convert.ToDouble(lines[0]);
                }
                double r2 = 0;
                for (int y = 0; y < aa2.Length; y++)
                {
                    r2 = r2 + aa2[y];
                }
                panel14.Visible = true;
                double qq2 = aa2.Length;

                double faf2 = r2 / qq2;
                if (faf2 > 100)
                {
                    faf2 = 100;
                }
                circularProgressBar2.Value = Convert.ToInt32(faf2 );
                label135.Text = (r2 / qq2).ToString("0.##") + " %";




                foreach (var ser in chart1.Series)
                {
                    ser.Points.Clear();
                }
                for (int ch = 0; ch < all.Rows.Count; ch++)
                {
                    chart1.Series["Maintain Hours"].Points.AddXY(all.Rows[ch][0].ToString(), all.Rows[ch][1].ToString());
                    chart1.Series["Available Hours"].Points.AddXY(all.Rows[ch][0].ToString(), all.Rows[ch][2].ToString());
                    chart1.Series["Worked Hours"].Points.AddXY(all.Rows[ch][0].ToString(), all.Rows[ch][3].ToString());
                }
                ChartArea CA = chart1.ChartAreas[0];  // quick reference
                CA.AxisX.ScaleView.Zoomable = true;
                CA.CursorX.AutoScroll = true;
                CA.CursorX.IsUserSelectionEnabled = true;
                //chart1.EnableAxisXScrolling = true;
                //chart1.EnableAxisYScrolling = true;
            }
            else
            {
                panel13.Visible = false; panel14.Visible = false;
                dataGridView5.DataSource = new DataTable();
                dataGridView5.Visible = false;
            }
        }
        private void check_id_CheckedChanged(object sender, EventArgs e)
        {
            if (check_id.Checked)
            { com_report.Enabled = true; }
            else { com_report.Enabled = false; com_report.SelectedIndex =-1; }
            dataGridView1.DataSource = new DataTable(); panel9.Visible = false; panel11.Visible = false; panel11.Enabled = false;
        }
        private void check_date_CheckedChanged(object sender, EventArgs e)
        {
            if (check_date.Checked)
            { date_old.Enabled = true; date_new.Enabled = true; }
            else { date_old.Enabled = false; date_new.Enabled = false; }
            dataGridView1.DataSource = new DataTable(); panel9.Visible = false; panel11.Visible = false; panel11.Enabled = false;
        }
        private void check_state_CheckedChanged(object sender, EventArgs e)
        {
            if (check_state.Checked)
            { radio_done.Enabled = true; radio_not.Enabled = true; }
            else { radio_done.Enabled = false; radio_not.Enabled = false; }
            dataGridView1.DataSource = new DataTable(); panel9.Visible = false; panel11.Visible = false; panel11.Enabled = false;
        }
        private void check_cost_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cost.Checked)
            { chk_cost3.Checked = false; txt_cost1.Enabled = true; txt_cost2.Enabled = true; pnl_totalCost.Enabled = true; }
            else { chk_cost3.Checked = false; txt_cost1.Enabled = false; txt_cost2.Enabled = false; pnl_totalCost.Enabled = false; }
            dataGridView1.DataSource = new DataTable(); panel9.Visible = false; panel11.Visible = false; panel11.Enabled = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_type.Checked)
            { check_prev.Enabled = true; check_corr.Enabled = true; check_daily.Enabled = true; }
            else { check_prev.Enabled = false; check_prev.Checked = true;
                check_corr.Enabled = false; check_corr.Checked = true;
                check_daily.Enabled = false; check_daily.Checked = true;
            }
            dataGridView1.DataSource = new DataTable(); panel9.Visible = false; panel11.Visible = false; panel11.Enabled = false;
        }
        private void button2_Click_3(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this report?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //DialogResult dialogResult2 = MessageBox.Show("Delete (Technicians),(Oils),(Fuel) Connected to this maintenance Report ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                //if (dialogResult2 == DialogResult.Yes)
                //{
                    string del_lab; string del_oil; string del_fuel; string del_dail; string del_filt; string xsa2;
                    int a = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["main_id"].Value);
                    try {  del_lab = worksal.del_all_work_reprot(a); } catch { del_lab = ""; }
                    try{del_oil = oi.deloilrep(a);} catch { del_oil = ""; }
                    try { del_fuel = fu.delfuelrep(a);} catch { del_fuel = ""; }
                    try{del_dail = ma.delete_dai_ch(a);} catch { del_dail = ""; }
                try { del_filt = fl.delfilterrep(a); } catch { del_filt = ""; }
                try {xsa2 = ma.del_main(a);} catch { xsa2 = ""; }
                    if (del_lab != "Success")
                    {
                        MessageBox.Show("Technicians Report Deletion: " + del_lab + " Please Try Again" + "\n" + "Error Code: V4"); 
                    }
                    if (del_oil != "Success")
                    {
                        MessageBox.Show("Oil Report Deletion: " + del_oil + " Please Try Again" + "\n" + "Error Code: V5"); 
                    }
                    if (del_fuel != "Success") 
                    {
                        MessageBox.Show("Fuel Report Deletion: " + del_fuel + " Please Try Again" + "\n" + "Error Code: V6"); 
                    }
                    if (del_dail != "Success")
                    {
                        MessageBox.Show("DailyCeck Report Deletion: " + del_dail + " Please Try Again" + "\n" + "Error Code: V8");
                    }
                    if (xsa2 != "Success")
                    {
                        MessageBox.Show("Maintenance Report Deletion: " + xsa2 + " Please Try Again" + "\n" + "Error Code: V9");
                    }
                if (del_filt != "Success")
                {
                    MessageBox.Show("Filter Report Deletion: " + del_filt + " Please Try Again" + "\n" + "Error Code: V10");
                }

                MessageBox.Show("Success");





                if (dataGridView1.Rows.Count > 0)
                {
                    btn_report_Click(sender, e);
                }
                if (dataGridView2.Rows.Count > 0)
                {
                    btn_report_lp_Click(sender, e);
                }
                if (dataGridView4.Rows.Count > 0)
                {
                    pictureBox12_Click(sender, e);
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    pictureBox6_Click(sender, e);
                }
                if (dataGridView7.Rows.Count > 0)
                {
                    pictureBox7_Click(sender, e);
                }



                //}
                //if (dialogResult2 == DialogResult.No)
                //{
                //    int a = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["main_id"].Value);
                //    string dail = ma.delete_dai_ch(a);
                //    if (dail == "Success")
                //    {
                //        MessageBox.Show("Maintenance Report Deletion: " + ma.del_main(a));
                //    }
                //    else
                //    {
                //        MessageBox.Show("Daily Check List Report Deletion: " + dail + " Please Try Again" + "\n" + "Error Code: V6"); return;
                //    }

                //    btn_report_Click(sender, e);
                //}
            }
            if (dialogResult == DialogResult.No)
            { }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["main_id"].Value);
            string b = dataGridView1.Rows[dataGridView1.SelectedCells[10].RowIndex].Cells["main_type_name"].Value.ToString();
            string na = dataGridView1.Rows[dataGridView1.SelectedCells[1].RowIndex].Cells["equ_id"].Value.ToString();
            int c = eq.Search_equ_by_name(na);
            tabControl1.SelectedIndex = 4;
            if (b == "Periodic Maintenance")
            {
                //panel2.Enabled = true;
                tabControl7.SelectedIndex = 0;     
                string[] arrx = new string[14];
                arrx = ma.bring_prev(a); 
                comb_prev_main1.SelectedIndexChanged -= new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                comb_prev_main1.SelectedValue = arrx[13];
                comb_prev_main1.SelectedIndexChanged += new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                txt_pre_1_id.Text = arrx[0];// id
                label226.Text = arrx[1];// stage numper
                txt_pre_2_type_number.Text = arrx[1];// stage numper
                txt_pre_3_hours.Text =Convert.ToString( ma.find_prev_hours(Convert.ToInt32(arrx[13]), Convert.ToInt32(arrx[1])));
                txt_pre_0_now_hours.Text = arrx[2];// hours when done
                txt_pre_4_parts.Text = arrx[3];//parts
                lbl_hours_ins2.Text =Convert.ToString(ma.Find_work_hours_int(Convert.ToInt32(arrx[13])));
                txt_pre_6_cost.Text = arrx[5];//cost
                date_prv.Value = Convert.ToDateTime(arrx[6]);//date
                txt_pre_7_det.Text = arrx[7];//details
                txt_pre_8_user.Text = arrx[8];//user id
                txt_pre_9_type_name.Text = arrx[9];//name
                txt_pre_10_stat_2.Text = arrx[10];//state details

                string num = arrx[9];
                string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                label225.Text = part2[1];// real stage num

                txt_duration.Text = arrx[11];//time needed
                //label102.Text = arrx[12];//labor cost
                List<string> ss = ma.get_for_report(a, c, Convert.ToInt32(arrx[1]), Convert.ToInt32(txt_pre_0_now_hours.Text));
                
                lbl_lastH.Text = ss[1];// last hours
                lbl_interval.Text = ss[2];// interval

                panel12.Enabled = true; btn_Corr_main_ins_upd.Enabled = true;
                btn_Corr_main_ins_upd.Enabled = true;
                //label102.Visible = true;
                //label101.Visible = true;
                DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_pre_1_id.Text));
                int x = xx.Rows.Count;
                int total = 0;
                if (x > 0)
                {
                    flow_labor.Controls.Clear();
                    lbl_prv_after.Visible = true;
                    lowww_prv.Visible = true;
                   // lbl_prv_hrs_stage3.Visible = true;
                   // lbl_prv_hrs_stage4.Visible = true;
                    int sw = 0; dea = 0;
                    report_iid = new int[x];
                    for (int w = 0; w < x; w++)
                    {
                        btn_del_labor.Visible = true;
                        btn_del_labor.Enabled = true;
                        pnl_labor.Visible = true;

                        ComboBox comb = new ComboBox();
                        TextBox txt = new TextBox();
                        TextBox txtd = new TextBox();
                        CheckBox lp = new CheckBox();
                        Panel pp = new Panel();

                        pp.Name = "p" + dea;
                        pp.Size = new Size(500, 30);

                        comb.Name = "c" + dea;
                        comb.Size = new Size(150, 21);
                        comb.Location = new Point(27, 4);
                        report_iid[w] = Convert.ToInt32(xx.Rows[w][0].ToString());
                        comb.SelectedText = xx.Rows[w][3].ToString();
                        comb.SelectedValue = xx.Rows[w][2].ToString();
                        comb.Enabled = false;

                        txt.Name = "t1__" + dea;
                        txt.Size = new Size(60, 20);
                        txt.Location = new Point(184, 4);
                        txt.Text = xx.Rows[w][5].ToString();
                        txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);

                        sw = dea + 1;
                        lp.Name = "lp" + dea;
                        lp.Text = sw + " -";
                        lp.Size = new Size(20, 20);
                        lp.Location = new Point(6, 4);


                        txtd.Name = "t2__" + dea;
                        txtd.Text = xx.Rows[w][8].ToString();
                        txtd.Size = new Size(245, 20);
                        txtd.Location = new Point(251, 4);

                        pp.Controls.Add(comb);
                        pp.Controls.Add(txt);
                        pp.Controls.Add(txtd);
                        pp.Controls.Add(lp);
                        flow_labor.Controls.Add(pp);
                        total = total + Convert.ToInt32(xx.Rows[w][9].ToString());
                        dea++;
                    }
                }
                else
                {
                    pnl_labor.Visible = false;
                    flow_labor.Controls.Clear();
                    btn_del_labor.Visible = false;
                    btn_del_labor.Enabled = false;
                }
                lbl_state_prev.Text = "Report";
                btn_pre_sho_Click(sender, e);
                panel2.Enabled = true;
                //txt_pre_3_hours.Visible = true;
                //lbl_prv2.Visible = true;
            }
            else if (b == "Corrective Maintenance")
            {

                tabControl7.SelectedIndex = 1;
                pnl_cor.Enabled = true;
                string[] arrx = new string[15];
                arrx = ma.bring_prev(a);
                combo_cor_equ.SelectedValue = arrx[13];
                lbl_dai_corr_state1.Text = "Report";
                txt_main_id1.Text = arrx[0];// id
                //txt_main_ins2.Text = arrx[1];// stage numper
                txt_main_ins31.Text = arrx[2];// hours when done
                txt_cor_parts.Text = arrx[3];//parts
                                             //state
                txt_cor_cost.Text = arrx[5];//cost
                date_cor.Value = Convert.ToDateTime(arrx[6]);//date
                txt_cor_deta.Text = arrx[7];//details
                txt_main_ins81.Text = arrx[8];//user id
                                              // txt_main_ins22.Text = arrx[9];//name
                txt_cor_state.Text = arrx[10];//state details
                txt_cor_dura.Text = arrx[11];//time needed
                //lbl_cor_labor_cost.Text = arrx[12];//labor cost
                //lbl_cor_labor_cost.Visible = true;
                //label157.Visible = true;
                DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_main_id1.Text));
                int total = 0;
                int x = xx.Rows.Count;
                if (x > 0)
                {
                    flow_cor_labors.Controls.Clear();
                    int sw = 0; dea = 0;
                    btn_cor_del_lapor.Visible = true; btn_cor_del_lapor.Enabled = true;
                    pnl_cor_names.Visible = true; 
                    for (int w = 0; w < x; w++)
                    {
                        ComboBox comb = new ComboBox();
                        TextBox txt = new TextBox();
                        TextBox txtd = new TextBox();
                        CheckBox lp = new CheckBox();
                        Panel pp = new Panel();
                        pp.Name = "p" + dea;
                        pp.Size = new Size(500, 30);
                        comb.Name = "c" + dea;
                        comb.Size = new Size(150, 21);
                        comb.Location = new Point(27, 4);
                        comb.SelectedText = xx.Rows[w][3].ToString();
                        comb.SelectedValue = Convert.ToInt32(xx.Rows[w][2].ToString());
                        comb.Enabled = false;
                        txt.Name = "t1__" + dea;
                        txt.Size = new Size(60, 20);
                        txt.Location = new Point(184, 4);
                        txt.Text = xx.Rows[w][5].ToString();
                        txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);
                        sw = dea + 1;
                        lp.Name = "lp" + dea;
                        lp.Text = sw + " -";
                        lp.Size = new Size(20, 20);
                        lp.Location = new Point(6, 4);
                        txtd.Name = "t2__" + dea;
                        txtd.Text = xx.Rows[w][8].ToString();
                        txtd.Size = new Size(245, 20);
                        txtd.Location = new Point(251, 4);
                        pp.Controls.Add(comb);
                        pp.Controls.Add(txt);
                        pp.Controls.Add(txtd);
                        pp.Controls.Add(lp);
                        flow_cor_labors.Controls.Add(pp);
                        total = total + Convert.ToInt32(xx.Rows[w][9].ToString());
                        dea++;
                    }
                }  //add labors
                else
                {
                    pnl_cor_names.Visible = false;
                    flow_cor_labors.Controls.Clear();
                    btn_cor_del_lapor.Visible = false;
                    btn_cor_del_lapor.Enabled = false;
                }   //add labors

            }
            else if (b == "Daily Maintenance")
            {

                tabControl7.SelectedIndex = 2;
                panel12.Enabled = true; btn_Corr_main_ins_upd.Enabled = true;
                txt_main_ins4.Enabled = true;
                txt_main_ins5.Enabled = true;
                txt_main_ins6.Enabled = true;
                txt_main_ins7.Enabled = true;
                txt_duration2.Enabled = true;
                date_main_ins.Enabled = true;
                radio_corr_dai_done.Enabled = true;
                radio_corr_dai_Not_done.Enabled = true;
                string[] arrx = new string[15];
                arrx = ma.bring_prev(a);
                comb_CP_main_equ.SelectedValue = arrx[13];
                lbl_dai_corr_state.Text = "Report";
                txt_main_id.Text = arrx[0];// id
                //txt_main_ins2.Text = arrx[1];// stage numper
                txt_main_ins3.Text = arrx[2];// hours when done
                txt_main_ins4.Text = arrx[3];//parts
                                             //state
                txt_main_ins6.Text = arrx[5];//cost
                date_main_ins.Value = Convert.ToDateTime(arrx[6]);//date
                txt_main_ins7.Text = arrx[7];//details
                txt_main_ins8.Text = arrx[8];//user id
                                             // txt_main_ins22.Text = arrx[9];//name
                txt_main_stg_det_corr.Text = arrx[10];//state details
                txt_duration2.Text = arrx[11];//time needed
                //label1072.Text = arrx[12];//labor cost
                //label1072.Visible = true;
                //label114.Visible = true;
                DataTable xx = worksal.Find_worker_reprot(Convert.ToInt32(txt_main_id.Text));
                int total = 0;
                int x = xx.Rows.Count;
                if (x > 0)
                {
                    flow_labor2.Controls.Clear(); btn_del_labor2.Enabled = true;
                    int sw = 0; dea = 0;
                    btn_del_labor2.Visible = true;
                    pnl_labor2.Visible = true;
                    for (int w = 0; w < x; w++)
                    {
                        ComboBox comb = new ComboBox();
                        TextBox txt = new TextBox();
                        TextBox txtd = new TextBox();
                        CheckBox lp = new CheckBox();
                        Panel pp = new Panel();
                        pp.Name = "p" + dea;
                        pp.Size = new Size(500, 30);
                        comb.Name = "c" + dea;
                        comb.Size = new Size(150, 21);
                        comb.Location = new Point(27, 4);
                        comb.SelectedText = xx.Rows[w][3].ToString();
                        comb.SelectedValue = Convert.ToInt32(xx.Rows[w][2].ToString());
                        comb.Enabled = false;
                        txt.Name = "t1__" + dea;
                        txt.Size = new Size(60, 20);
                        txt.Location = new Point(184, 4);
                        txt.Text = xx.Rows[w][5].ToString();
                        txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);
                        sw = dea + 1;
                        lp.Name = "lp" + dea;
                        lp.Text = sw + " -";
                        lp.Size = new Size(20, 20);
                        lp.Location = new Point(6, 4);
                        txtd.Name = "t2__" + dea;
                        txtd.Text = xx.Rows[w][8].ToString();
                        txtd.Size = new Size(245, 20);
                        txtd.Location = new Point(251, 4);
                        pp.Controls.Add(comb);
                        pp.Controls.Add(txt);
                        pp.Controls.Add(txtd);
                        pp.Controls.Add(lp);
                        flow_labor2.Controls.Add(pp);
                        total = total + Convert.ToInt32(xx.Rows[w][9].ToString());
                        dea++;
                    }
                }  //add labors
                else
                {
                    pnl_labor2.Visible = false;
                    flow_labor2.Controls.Clear();
                    btn_add_labor2.Visible = true;
                    btn_add_labor2.Enabled = true;
                    btn_del_labor2.Visible = false;
                    btn_del_labor2.Enabled = false;
                }   //add labors
                if (ma.check_daily_bring(Convert.ToInt32(txt_main_id.Text)))
                {
                    linkLabel2.Visible = true; 
                    //panel16.Visible = true;
                    lbl_check_id.Text = ma.table.Rows[0][0].ToString();
                    //comb_eng_name.SelectedValue = ma.table.Rows[0][8].ToString();
                    CheckBoxes.Clear();
                    string parts = ma.table.Rows[0][4].ToString();
                    string states = ma.table.Rows[0][11].ToString();
                    string[] part2 = Regex.Split(parts, "<##>");
                    string[] part = Regex.Split(part2[0], "<#>");
                    string[] state = Regex.Split(states, "<#>");
                    int n = part.Length - 1;
                    CheckBox[] checkBoxB = new CheckBox[n];
                    Label[] label = new Label[n];
                    Panel[] pp = new Panel[n];
                    for (int i = 0; i < n; i++)
                    {
                        checkBoxB[i] = new CheckBox();
                        checkBoxB[i].Name = "c" + i;

                        if (state[i] == "Done")
                        {
                            checkBoxB[i].Text = "Checked";
                            checkBoxB[i].Checked = true;
                            checkBoxB[i].BackColor = lbl_main_name.ForeColor;
                        }
                        else
                        {
                            checkBoxB[i].Text = "Not Checked";
                        }
                        checkBoxB[i].TextAlign = ContentAlignment.MiddleRight;
                        checkBoxB[i].Size = new Size(80, 25);
                        checkBoxB[i].Top = 30;
                        checkBoxB[i].Left = 50;

                        label[i] = new Label();
                        label[i].Name = "l" + i;
                        label[i].Text = part[i];
                        label[i].Top = 50;
                        label[i].Left = 50;
                        label[i].TextAlign = ContentAlignment.MiddleLeft;
                        label[i].Size = new Size(630, 28);
                        CheckBoxes.Add(checkBoxB[i]);
                        pp[i] = new Panel();
                        pp[i].Name = "p" + i;
                        pp[i].Size = new Size(715, 5);
                        pp[i].Top = 30;
                        pp[i].Left = 50;
                        pp[i].BackColor = lbl_main_name.ForeColor;
                        if (lbl_main_name.ForeColor == System.Drawing.Color.DodgerBlue)
                        {
                            checkBoxB[i].ForeColor = System.Drawing.Color.White;
                            label[i].ForeColor = System.Drawing.Color.White;
                        }
                    }
                    panel15.Visible = true;
                    for (int i = 0; i < n; i++)
                    {
                        flow_dai.Controls.Add(label[i]);
                        flow_dai.Controls.Add(checkBoxB[i]);
                        flow_dai.Controls.Add(pp[i]);
                    }
                }
            }
        }
        private void chk_cost3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cost3.Checked)
            {
                txt_cost1.Enabled = false; txt_cost1.Text = "";
                txt_cost2.Enabled = false; txt_cost2.Text = "";
                txt_cost3.Enabled = true; txt_cost3.Text = "";
            }
            else
            {
                txt_cost1.Enabled = true; txt_cost1.Text = "";
                txt_cost2.Enabled = true; txt_cost2.Text = "";
                txt_cost3.Enabled = false; txt_cost3.Text = "";
            }
        }
      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable ee = new DataTable();
                ee = ma.get_them_all(comboBox2.Text);
                dataGridView3.DataSource = ee;
                comboBox5.DataSource= ma.get_them_all("equ");
                comboBox5.DisplayMember = "equ_type_id";
                comboBox5.ValueMember = "equ_id";
            }
            catch { dataGridView3.DataSource = new DataTable(); }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flow_dai.Controls.Clear(); linkLabel2.Visible = false; panel15.Visible = false; 
            //panel16.Visible = false;
        }
        private void combo_cor_equ_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_main_id1.Text = ""; lbl_dai_state1.Text = "a";
            flow_cor_labors.Controls.Clear(); //pnl_cor.Enabled = false;
            //btn_cor_step2.Enabled = false;
            txt_cor_cost.Text = "";
            txt_cor_dura.Text = "";
            txt_cor_parts.Text = ""; 
            txt_cor_deta.Text = "";
            //lbl_cor_labor_cost.Text = "";
            btn_cor_del_lapor.Visible = false;
            //btn_cor_del_lapor.Enabled = false;
            //pnl_cor_names.Visible = false;
            btn_cor_add_lapor.Visible = true;
            if (btn_cor_del_lapor.Visible == false)
            {
                btn_cor_add_lapor_Click(sender, e);
            }
            if (ma.Find_work_hours(Convert.ToInt32(combo_cor_equ.SelectedValue)))
            {
                txt_main_ins31.Text = ma.main_periodnum.ToString();
            }
            else
            {
                txt_main_ins31.Text = "0";
            }
            pnl_cor.Enabled = true; //btn_Corr_main_ins_upd.Enabled = true; btn_cor_step2.Enabled = true;
            try
            {
                ma.check_all_undone_main(Convert.ToInt32(combo_cor_equ.SelectedValue), -1);
                DataTable sss = ma.table.Clone();
                sss.Columns[1].DataType = typeof(string);
                foreach (DataRow row in ma.table.Rows)
                {
                    sss.ImportRow(row);
                }
                for (int i = 0; i < ma.table.Rows.Count; i++)
                {
                    int xe = Convert.ToInt32(sss.Rows[i][1].ToString());
                    string aa = eq.Searchequ(xe);
                    sss.Rows[i][1] = aa;
                }
                int qx = sss.Rows.Count;
                if (qx > 0)
                {
                    lbl_cor_not_done.Visible = true;
                    datagrid_cor_notdone.DataSource = sss;
                    datagrid_cor_notdone.Visible = true;
                    btn_cor_bring.Visible = true;
                    btn_cor_bring.Enabled = true;
                    datagrid_cor_notdone.Columns[0].Visible = false;
                    datagrid_cor_notdone.Columns[2].Visible = false;
                    datagrid_cor_notdone.Columns[9].Visible = false;
                    datagrid_cor_notdone.Columns[11].Visible = false;
                    datagrid_cor_notdone.Columns[1].HeaderText = "Maintain Type";
                    datagrid_cor_notdone.Columns[3].HeaderText = "Total Work Hours";
                    datagrid_cor_notdone.Columns[4].HeaderText = "Maintain Parts";
                    datagrid_cor_notdone.Columns[5].HeaderText = "Maintain State";
                    datagrid_cor_notdone.Columns[6].HeaderText = "Maintain Cost";
                    datagrid_cor_notdone.Columns[7].HeaderText = "Maintain Date";
                    datagrid_cor_notdone.Columns[8].HeaderText = "Details";
                    datagrid_cor_notdone.Columns[10].HeaderText = "Maintain Type";
                    datagrid_cor_notdone.Columns[12].HeaderText = "Maintain duration";
                    datagrid_cor_notdone.Columns[13].Visible = false;
                }
                else
                {
                    lbl_cor_not_done.Visible = false;
                    datagrid_cor_notdone.DataSource = new DataTable();
                    datagrid_cor_notdone.Visible = false;
                    btn_cor_bring.Visible = false;
                    btn_cor_bring.Enabled = false;
                }
            }
            catch
            {
                lbl_cor_not_done.Visible = false;
                datagrid_cor_notdone.DataSource = new DataTable();
                datagrid_cor_notdone.Visible = false;
                btn_cor_bring.Visible = false;
                btn_cor_bring.Enabled = false;
            }
        }
        private void btn_cor_add_lapor_Click(object sender, EventArgs e)
        {
            int io = 0;
            foreach (Panel pan in flow_cor_labors.Controls)
            {
                io++;
            }
            dea = io;
            lb_mod_5.Text = "yes";
            flow_cor_labors.Visible = true;
            btn_cor_del_lapor.Visible = true;
            btn_cor_del_lapor.Enabled = true;
            pnl_cor_names.Visible = true;

            ComboBox comb = new ComboBox();
            TextBox txt = new TextBox();
            TextBox txtd = new TextBox();
            CheckBox lp = new CheckBox();
            Panel pp = new Panel();

            pp.Name = "p" + dea;
            pp.Size = new Size(500, 30);

            comb.Name = "c" + dea;
            comb.Size = new Size(150, 21);
            comb.Location = new Point(27, 4);
            DataTable asdq = wo.bring_labor_names();
            comb.DataSource = asdq;

            comb.ValueMember = "worker_id";
            comb.DisplayMember = "worker_name";
            comb.SelectedIndex = -1;

            txt.Name = "t1__" + dea;
            txt.Size = new Size(60, 20);
            txt.Location = new Point(184, 4);
            txt.KeyPress += new KeyPressEventHandler(txt_salary_KeyPress);

            int sw = dea + 1;
            lp.Name = "lp" + dea;
            lp.Text = sw + " -";
            lp.Size = new Size(20, 20);
            lp.Location = new Point(6, 7);

            txtd.Name = "t2__" + dea;
            txtd.Size = new Size(245, 20);
            txtd.Location = new Point(251, 4);

            pp.Controls.Add(comb);
            pp.Controls.Add(txt);
            pp.Controls.Add(txtd);
            pp.Controls.Add(lp);
            flow_cor_labors.Controls.Add(pp);
            dea++;
        }
        private void btn_cor_del_lapor_Click(object sender, EventArgs e)
        {
            if (lbl_dai_corr_state1.Text != "Report")
            {
                int io = 0;
                foreach (Panel pan in flow_cor_labors.Controls)
                {
                    io++;
                }
                io--;
                for (int y = 0; y <= io; y++)
                {
                    foreach (Panel pan in flow_cor_labors.Controls)
                    {
                        string qwee = "p" + io;
                        if (pan.Name == qwee)
                        { flow_cor_labors.Controls.Remove(pan); dea--; }
                    }
                }
                if (io == 0)
                {
                    btn_cor_del_lapor.Visible = false;
                    btn_cor_del_lapor.Enabled = false;
                    pnl_cor_names.Visible = false;
                }
            }
            else
            {
                int io = 0; int x = 0;
                foreach (Panel pan in flow_cor_labors.Controls)
                {
                    io++;
                }
                x = io;
                string aaaqwe = "no";
                for (int i = 0; i <= io; i++)
                {
                    foreach (Panel con2 in flow_cor_labors.Controls)
                    {
                        foreach (Control con in con2.Controls)
                        {
                            if (con is CheckBox)
                            {
                                if (((CheckBox)con).Checked)
                                {
                                    aaaqwe = "yes";
                                }
                            }
                        }
                    }
                }
                if (aaaqwe == "yes")
                {
                    DialogResult dialogResult = MessageBox.Show("Erase All Selected Technicians from this maintenance", "Alert", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Please Make Sure to press update to save changes once Finished");
                        dea = 0;
                        for (int i = 0; i <= io; i++)
                        {
                            foreach (Panel con2 in flow_cor_labors.Controls)
                            {
                                foreach (Control con in con2.Controls)
                                {
                                    if (con is CheckBox)
                                    {
                                        if (((CheckBox)con).Checked)
                                        {
                                            string aaa = con.Name;
                                            string[] part = Regex.Split(aaa, "lp");
                                            try
                                            {
                                                worksal.del_work_reprot(report_iid[Convert.ToInt32(part[1])]);
                                                con2.Dispose();
                                                dea--;
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                                con2.Dispose();
                                                dea--;
                                            }
                                            x--;
                                            if (x == 0)
                                            {
                                                pnl_cor_names.Visible = false;
                                                btn_cor_del_lapor.Visible = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Please Check Data to Erase");
                    }
                }
                else { MessageBox.Show("Please Mark CheckBox to Erase"); }
            }

            
        }
   
        private void btn_notf_Click(object sender, EventArgs e)
        {
            //eq.mac();
            try
            {
                
                panel19.Visible = false;
                tableLayoutPanel3.SuspendLayout();
                while (tableLayoutPanel3.RowCount > 1)
                {
                    int row = tableLayoutPanel3.RowCount - 1;
                    for (int i = 0; i < tableLayoutPanel3.ColumnCount; i++)
                    {
                        Control c = tableLayoutPanel3.GetControlFromPosition(i, row);
                        tableLayoutPanel3.Controls.Remove(c);
                        //c.Dispose();
                    }
                    tableLayoutPanel3.RowStyles.RemoveAt(row);
                    tableLayoutPanel3.RowCount--;
                }

                tableLayoutPanel3.ResumeLayout(false);
                tableLayoutPanel3.PerformLayout();

                //flow_report.Controls.Clear();
                List<string> x = ma.main_test();
                List<string> y = oi.bring_data_for_auto();
                data = new List<string>();
                int xc = 0;
                string state_oil = "Green";

                for (int i = 0; i < y.Count; i ++)
                {
                    if (y[i] != "END")
                    {
                        data.Insert(xc, y[i]); xc++;
                    }
                    else
                    {
                        data.Insert(xc, y[i]); xc++;
                        data.Insert(xc, null); xc++;
                        data.Insert(xc, null); xc++;
                        data.Insert(xc, null); xc++;
                        data.Insert(xc, null); xc++;
                        data.Insert(xc, null); xc++;
                    }
                }//oil test copy data
                for (int z2 = 0; z2 < data.Count; z2++)
                {
                    for (int i = 0; i < x.Count; i = i + 4)
                    {
                        if (data[z2] == x[i])
                        {
                            for (int fin = 0; fin < data.Count; fin++)
                            {
                                if (data[z2 + fin] == "END")
                                {
                                    //data[z2 + fin] = "#END";
                                    data[z2 + fin + 1] = x[i + 1];
                                    data[z2 + fin + 2] = x[i + 2];
                                    data[z2 + fin + 3] = x[i + 3];
                                    break;
                                }
                            }
                        }
                    }
                }//main test copy data
                for (int counter = 1; counter < data.Count; counter++)
                {
                    string statt = data[counter];
                    string[] partr = Regex.Split(statt, "<#>");
                    if(partr.Length > 0)
                    {
                        if (partr[0] == "Red")
                        {
                            state_oil = "Red";
                        }
                        else if (partr[0] == "Yellow" || partr[0] == "Black")
                        {
                            if (state_oil == "Red")
                            {

                            }
                            else
                            {
                                state_oil = "Yellow";
                            }
                        }
                    }
                    if (statt == "END")
                    {
                        data[counter + 4]= state_oil; xc++;
                        state_oil = "Green";
                        counter = counter + 5;
                    }
                } //oil test copy data
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] == "END")
                    {
                        if (data[i + 1] == null)
                        {
                            data[i] = "Gray";
                            data[i + 1] = "This Equipment Does not have Hours Counter";
                            data[i + 2] = "";
                        }
                    }

                } //Maintain test copy data null data gray

                tableLayoutPanel3.Size = new System.Drawing.Size(340, 60 + (((data.Count / 11) - 1) * 70));
                panel27.Size = new Size(113, 45);
                panel26.Size = new Size(50, 50);
                panel20.Size = new Size(87, 50);
                string name = "";string nn = "";
                if (data.Count > 0)
                {
                    name = data[0]; nn = "0";
                }
                for (int eeq = 0; eeq < data.Count; eeq++)
                {
                    if (data[eeq] == "END")
                    {
                        PictureBox oil_pic = new PictureBox();
                        PictureBox main_pic2 = new PictureBox();
                        Label labe = new Label();
                        string oil_color = data[eeq + 4];
                        string main_color = data[eeq + 1];      
                        labe.Name = "l_"+ nn;
                        oil_pic.Name = "p_" + nn;
                        main_pic2.Name = "p2_" + nn;
                        labe.Text = name;
                        labe.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
                        labe.TextAlign = ContentAlignment.MiddleLeft;
                        labe.Size = new Size(175, 45);
                        if(label144.ForeColor == Color.Green)
                        {
                            labe.ForeColor = Color.Black;
                        }
                        else
                        {
                            labe.ForeColor = Color.White;
                        }
                        

                        oil_pic.Size = new Size(40, 40);

                        main_pic2.Size = new Size(40, 40);


                        if (oil_color == "Red")
                        {
                            oil_pic.Image = Properties.Resources.RED;
                        }
                        else if (oil_color == "Yellow")
                        {
                            oil_pic.Image = Properties.Resources.Yellow;
                        }
                        else
                        {
                            oil_pic.Image = Properties.Resources.Green;
                        }

                        if (main_color == "Red")
                        {
                            main_pic2.Image = Properties.Resources.RED;
                        }
                        else if (main_color == "yellow")
                        {
                            main_pic2.Image = Properties.Resources.Yellow;
                        }
                        else if (main_color == "Green")
                        {
                            main_pic2.Image = Properties.Resources.Green;
                        }
                        else if (main_color == "Gray")
                        {
                            main_pic2.Image = Properties.Resources.Green;
                        }
                        else
                        {
                            main_pic2.Image = Properties.Resources.RED;
                        }

                        //Label lab = new Label();
                        //lab.Size = new Size(18, 40);
                        //tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));


                        // //flow_report.Controls.Add(labe);
                        labe.Click -= new System.EventHandler(LB_Click);
                        labe.Click += new System.EventHandler(LB_Click);

                        // //flow_report.Controls.Add(pic);
                        oil_pic.Click -= new System.EventHandler(pic1_Click);
                        oil_pic.Click += new System.EventHandler(pic1_Click);

                        ////flow_report.Controls.Add(lab);

                        ////flow_report.Controls.Add(pic2);
                        main_pic2.Click -= new System.EventHandler(pic2_Click);
                        main_pic2.Click += new System.EventHandler(pic2_Click);
                        AddItem(tableLayoutPanel3, labe, oil_pic, main_pic2);
                        if (eeq + 6 < data.Count)
                        {
                            name = data[eeq + 6]; 
                            nn =Convert.ToString(eeq + 6);
                        }
                    }
                }
                panel19.Visible = true;
            }
            catch //(Exception ex)
            {
               // MessageBox.Show(ex.Message);
                data = new List<string>(); panel19.Visible = false;
            }
        }

        private void AddItem(TableLayoutPanel table, Control address, Control contactNum, Control email)
        {
            //get a reference to the previous existent 
            RowStyle temp = table.RowStyles[table.RowCount - 1];
            //increase panel rows count by one
            table.RowCount++;
            //add a new RowStyle as a copy of the previous one
            table.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three controls
            if (label91.ForeColor == Color.Green)
            {
                address.ForeColor = Color.Black;
                contactNum.ForeColor = Color.Black;
                email.ForeColor = Color.Black;
            }
            else
            {
                address.ForeColor = Color.White;
                contactNum.ForeColor = Color.White;
                email.ForeColor = Color.White;
            }
            table.Controls.Add(address, 0, table.RowCount - 1);
            table.Controls.Add(contactNum, 1, table.RowCount - 1);
            table.Controls.Add(email, 2, table.RowCount - 1);

            address.Anchor= AnchorStyles.None;
            address.Invalidate(true);
            contactNum.Anchor = AnchorStyles.None;
            contactNum.Invalidate(true);
            email.Anchor = AnchorStyles.None;
            email.Invalidate(true);
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(true)
            {
                return;
            }
            if (modifiedddd())
            {
                //DialogResult dialogResult = MessageBox.Show("Clear Data?", "Clear Data Confirmation", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    cleaar();
                //}
                //else if (dialogResult == DialogResult.No)
                //{
                //    if (tabControl1.SelectedIndex == 4)
                //    {
                //        lb_mod_4.Text = "yes";
                //    }
                //}
            }

            if (tabControl1.SelectedIndex == 0)
            {
                btn_notf_Click(sender, e);
            }
            if (tabControl1.SelectedIndex == 1)
            {
                if (lb_mod_1.Text == "no")
                {
                    lb_mod_1.Text = "no";
                    combo_equ_show.SelectedIndexChanged -= new System.EventHandler(combo_equ_show_SelectedIndexChanged);
                    combo_equ_show.SelectedIndex = -1;
                    combo_equ_show.SelectedIndexChanged += new System.EventHandler(combo_equ_show_SelectedIndexChanged);
                    lbl_sn.Text = "";
                    lbl_id.Text = "";
                    lbl_arr.Text = "";
                    label88.Text = "";
                    lbl_lng.Text = "";
                    lbl_high.Text = "";
                    lbl_width.Text = "";
                    lbl_wiegt.Text = "";
                    lbl_engsn.Text = "";
                    lbl_engp.Text = "";
                    lbl_highidle.Text = "";
                    lbl_lowidle.Text = "";
                    lbl_transn.Text = "";
                    lbl_tiersize.Text = "";
                    lbl_eng_size.Text = "";
                    lbl_ac_size.Text = "";
                    lbl_mg_size.Text = "";
                    dataGridequ4.DataSource = new DataTable();
                    dataGridequ2.DataSource = new DataTable();
                    dataGridequ3.DataSource = new DataTable();
                    comb_prv_sq.SelectedIndexChanged -= new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                    comb_prv_sq.SelectedIndex = -1;
                    comb_prv_sq.SelectedIndexChanged += new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                    tableLayoutPanel1.Visible = false;
                    panel3.Enabled = false;
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                if (lb_mod_2.Text == "no")
                {
                    comb_add_hours.SelectedIndexChanged -= new System.EventHandler(comb_add_hours_SelectedIndexChanged);
                    comb_add_hours.SelectedIndex = -1;
                    comb_add_hours.SelectedIndexChanged += new System.EventHandler(comb_add_hours_SelectedIndexChanged);
                    lbl_after.Text = "";
                    lbl_prv_hrs_stage2.Text = "";
                    lbl_prv_hrs_part2.Text = "";
                    lb_mod_2.Text = "no";
                    txt_input_hours.Text = "";
                    txt_add_hours_total.Text = "";
                    date_add_hours.Value = DateTime.Now;
                    lbl_main_id.Text = "";
                    lbl_hours2.Text = "";
                    panel7.Enabled = false;
                    panel28.Enabled = false;
                }
            }
            if (tabControl1.SelectedIndex == 3)
            {
                if (lb_mod_31.Text == "no")
                {
                    com_report.SelectedIndex = -1;
                }
                if (lb_mod_32.Text == "no")
                {
                    combo_labor_report.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                }
                if (lb_mod_33.Text == "no")
                {
                    combo_use.SelectedIndex = -1;
                    circularProgressBar1.Value = 75;
                    label135.Text = "75 %";
                    circularProgressBar2.Value = 75;
                    label130.Text = "75 %";
                }
            }
            if (tabControl1.SelectedIndex == -90)
            {
                if (lb_mod_31.Text == "no")
                {
                    label120.Text = "0";
                    label119.Text = "0";
                    label94.Text = "0";
                    label138.Text = "0";
                    label122.Text = "0";
                    lb_mod_31.Text = "no";
                    textBox1.Text = "";
                    check_id.Checked = false;
                    check_state.Checked = false;
                    check_cost.Checked = false;
                    check_type.Checked = false;
                    check_prev.Checked = false;
                    check_corr.Checked = false;
                    check_daily.Checked = false;
                    chk_cost3.Checked = false;
                    panel11.Visible = false;
                    panel11.Enabled = false;
                    dataGridView1.DataSource = new DataTable();
                    date_old.Value = DateTime.Now;
                    date_new.Value = DateTime.Now;
                    label128.Text = "0";
                    chk_id.Checked = false;
                    chk_equ.Checked = false;
                    chk_date.Checked = false;
                    combo_use.SelectedIndex = -1;
                    com_report.SelectedIndex = -1;
                    combo_labor_report.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    panel6.Visible = false;
                    dataGridView2.DataSource = new DataTable();
                    date_rep_old.Value = DateTime.Now;
                    date_rep_new.Value = DateTime.Now;
                    date_use_old.Value = DateTime.Now;
                    date_use_new.Value = DateTime.Now;
                    dataGridView5.DataSource = new DataTable();
                    circularProgressBar1.Value = 75;
                    circularProgressBar2.Value = 75;
                    label135.Text = "75 %";
                    label130.Text = "75 %";
                }
            }
            if (tabControl1.SelectedIndex == 4)
            {
                if (lb_mod_4.Text == "no")
                {
                    lb_mod_4.Text = "no";
                    comb_prev_main1.SelectedIndexChanged -= new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                    comb_prev_main1.SelectedIndex = -1;
                    comb_prev_main1.SelectedIndexChanged += new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                    lbl_hours_ins2.Text = "No Data Yet";
                    lbl_prv_hrs_stage4.Text = "0";
                    lbl_prv_after.Text = "0";
                    //label102.Text = "0";
                    txt_pre_4_parts.Text = "";
                    txt_pre_1_id.Text = "";
                    txt_pre_2_type_number.Text = "";
                    txt_pre_10_stat_2.Text = "";
                    txt_pre_5_stat_1.Text = "";
                    //panel2.Enabled = false;
                    btn_del_labor.Visible = false;
                    txt_duration.Text = "";
                    txt_pre_6_cost.Text = "";
                    txt_pre_7_det.Text = "";
                    date_prv.Value = DateTime.Now;
                    txt_pre_3_hours.Text = "";
                    pnl_labor.Visible = false;
                    flow_labor.Controls.Clear();
                    label100.Visible = false;
                    dat_grid_prev1.DataSource = new DataTable();
                    dat_grid_prev1.Visible = false;
                    flowLayoutPanel2.Controls.Clear();
                    panel1.Visible = false;
                    btn_bring_to_upd.Visible = false;
                  
                }
                if (lb_mod_5.Text == "no")
                {
                    lb_mod_5.Text = "no";
                    combo_cor_equ.SelectedIndexChanged -= new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
                    combo_cor_equ.SelectedIndex = -1;
                    combo_cor_equ.SelectedIndexChanged += new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
                    pnl_cor.Enabled = false;
                    txt_cor_parts.Text = "";
                    txt_cor_dura.Text = "";
                    txt_cor_cost.Text = "";
                    txt_cor_deta.Text = "";
                    date_cor.Value = DateTime.Now;
                    btn_cor_del_lapor.Visible = false;
                    pnl_cor_names.Visible = false;
                    flow_cor_labors.Controls.Clear();
                    lbl_cor_not_done.Visible = false;
                    datagrid_cor_notdone.DataSource = new DataTable();
                    datagrid_cor_notdone.Visible = false;
                    txt_main_id1.Text = "";
                    txt_cor_state.Text = "";
                    txt_main_ins31.Text = "0";
                    btn_cor_bring.Visible = false;

                }
                if (lb_mod_6.Text == "no")
                {
                    lb_mod_6.Text = "no";
                    comb_CP_main_equ.SelectedIndexChanged -= new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
                    comb_CP_main_equ.SelectedIndex = -1;
                    comb_CP_main_equ.SelectedIndexChanged += new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
                    panel12.Enabled = false;
                    btn_del_labor2.Visible = false;
                    //panel16.Visible = false;
                    linkLabel2.Visible = false;
                    //label1072.Text = "";
                    txt_main_ins4.Text = "";
                    txt_duration2.Text = "";
                    txt_main_ins6.Text = "";
                    txt_main_ins7.Text = "";
                    date_main_ins.Value = DateTime.Now;
                    pnl_labor2.Visible = false;
                    flow_labor2.Controls.Clear();
                    label107.Visible = false;
                    dataGrid_cor_dai.DataSource = new DataTable();
                    dataGrid_cor_dai.Visible = false;
                    btn_bring_to_upd2.Visible = false;
                    flow_dai.Controls.Clear();
                    panel_dai.Visible = false;
                    txt_main_id.Text = "";
                    txt_main_stg_det_corr.Text = "";
                    txt_main_ins5.Text = "";
                    txt_main_ins3.Text = "";

                }
            }
            if (tabControl1.SelectedIndex == 5)
            {
                combo_oil_ins.SelectedIndex = -1;
                comb_oil_del_equ.SelectedIndex = -1;

                comb_fuel_ins_equ.SelectedIndex = -1;
                comb_fuel_del_equ.SelectedIndex = -1;
                comb_fuel_del.SelectedIndex = -1;

                combo_laboe_upd.SelectedIndex = -1;

                combo_filter_equ_ins.SelectedIndex = -1;
                comb_flt_del_equ.SelectedIndex = -1;
                comb_flt_del.SelectedIndex = -1;
            }
        }

        public bool modifiedddd()
        {
            bool stt = false;
            if (previou == 1)
            {
                if (lb_mod_1.Text == "yes")
                { stt = true; }
                else { }
            }
            if (previou == 2)
            {
                if (lb_mod_2.Text == "yes")
                { stt = true; }
                else { }
            }
            if (previou == -90)
            {
                if (lb_mod_31.Text == "yes")
                { stt = true; }
                else { }
            }
            if (previou == 4)
            {
                if (lb_mod_4.Text == "yes" || txt_duration.Text != "" || txt_pre_6_cost.Text != "" || txt_pre_7_det.Text != "" || date_prv.Value.Date != DateTime.Now.Date)
                { stt = true; }
                else { }
                if (lb_mod_5.Text == "yes" || txt_cor_parts.Text != "" || txt_cor_dura.Text != "" || txt_cor_cost.Text != "" || txt_cor_deta.Text != "" || date_cor.Value.Date != DateTime.Now.Date)
                { stt = true; }
                else { }
                if (lb_mod_6.Text == "yes" || txt_main_ins4.Text != "" || txt_duration2.Text != "" || txt_main_ins6.Text != "" || txt_main_ins7.Text != "" || date_main_ins.Value.Date != DateTime.Now.Date)
                { stt = true; }
                else { }
            }
            if (previou == 5)
            {
                combo_oil_ins.SelectedIndex = -1;
                comb_oil_del_equ.SelectedIndex = -1;

                comb_fuel_ins_equ.SelectedIndex = -1;
                comb_fuel_del_equ.SelectedIndex = -1;
                comb_fuel_del.SelectedIndex = -1;

                combo_laboe_upd.SelectedIndex = -1;

                combo_filter_equ_ins.SelectedIndex = -1;
                comb_flt_del_equ.SelectedIndex = -1;
                comb_flt_del.SelectedIndex = -1;
            }
            return stt;
        }
        public void cleaar()
        {
            try
            {
                if (previou == 1)
                {
                    lb_mod_1.Text = "no";
                    combo_equ_show.SelectedIndexChanged -= new System.EventHandler(combo_equ_show_SelectedIndexChanged);
                    combo_equ_show.SelectedIndex = -1;
                    combo_equ_show.SelectedIndexChanged += new System.EventHandler(combo_equ_show_SelectedIndexChanged);
                    lbl_sn.Text = "";
                    lbl_id.Text = "";
                    lbl_arr.Text = "";
                    label88.Text = "";
                    lbl_lng.Text = "";
                    lbl_high.Text = "";
                    lbl_width.Text = "";
                    lbl_wiegt.Text = "";
                    lbl_engsn.Text = "";
                    lbl_engp.Text = "";
                    lbl_highidle.Text = "";
                    lbl_lowidle.Text = "";
                    lbl_transn.Text = "";
                    lbl_tiersize.Text = "";
                    lbl_eng_size.Text = "";
                    lbl_ac_size.Text = "";
                    lbl_mg_size.Text = "";
                    dataGridequ4.DataSource = new DataTable();
                    dataGridequ2.DataSource = new DataTable();
                    dataGridequ3.DataSource = new DataTable();
                    comb_prv_sq.SelectedIndexChanged -= new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                    comb_prv_sq.SelectedIndex = -1;
                    comb_prv_sq.SelectedIndexChanged += new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
                    tableLayoutPanel1.Visible = false;
                    panel3.Enabled = false;
                }
                if (previou == 2)
                {
                    comb_add_hours.SelectedIndexChanged -= new System.EventHandler(comb_add_hours_SelectedIndexChanged);
                    comb_add_hours.SelectedIndex = -1;
                    comb_add_hours.SelectedIndexChanged += new System.EventHandler(comb_add_hours_SelectedIndexChanged);
                    lbl_after.Text = "";
                    lbl_prv_hrs_stage2.Text = "";
                    lbl_prv_hrs_part2.Text = "";
                    lb_mod_2.Text = "no";
                    txt_input_hours.Text = "";
                    txt_add_hours_total.Text = "";
                    date_add_hours.Value = DateTime.Now;
                    lbl_main_id.Text = "";
                    lbl_hours2.Text = "";
                    panel7.Enabled = false;
                    panel28.Enabled = false;         
                }
                if (previou == -90)
                {
                    label120.Text = "0";
                    label119.Text = "0";
                    label94.Text = "0";
                    label138.Text = "0";
                    label122.Text = "0";
                    lb_mod_31.Text = "no";
                    txt_rep_word.Text = "";
                    check_id.Checked = false;
                    check_state.Checked = false;
                    check_cost.Checked = false;
                    check_type.Checked = false;
                    check_prev.Checked = false;
                    check_corr.Checked = false;
                    check_daily.Checked = false;
                    chk_cost3.Checked = false;               
                    panel11.Visible = false;
                    panel11.Enabled = false;
                    dataGridView1.DataSource = new DataTable();
                    date_old.Value = DateTime.Now;
                    date_new.Value = DateTime.Now;
                    label128.Text = "0";
                    chk_id.Checked = false;
                    chk_equ.Checked = false;
                    chk_date.Checked = false;
                    combo_use.SelectedIndex = -1;
                    com_report.SelectedIndex = -1;
                    combo_labor_report.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    panel6.Visible = false;
                    dataGridView2.DataSource = new DataTable();
                    date_rep_old.Value = DateTime.Now;
                    date_rep_new.Value = DateTime.Now;                   
                    date_use_old.Value = DateTime.Now;
                    date_use_new.Value = DateTime.Now;
                    dataGridView5.DataSource = new DataTable();
                    circularProgressBar1.Value = 75;
                    circularProgressBar2.Value = 75;
                    label135.Text = "75 %";
                    label130.Text = "75 %";
                }
                if (previou == 4) 
                {
                    lb_mod_4.Text = "no";
                    comb_prev_main1.SelectedIndexChanged -= new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                    comb_prev_main1.SelectedIndex = -1;
                    comb_prev_main1.SelectedIndexChanged += new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                    lbl_hours_ins2.Text = "No Data Yet";
                    lbl_prv_hrs_stage4.Text = "0";
                    lbl_prv_after.Text = "0";
                    //label102.Text = "0";
                    txt_pre_4_parts.Text = "";
                    txt_pre_1_id.Text = "";
                    txt_pre_2_type_number.Text = "";
                    txt_pre_10_stat_2.Text = ""; txt_main_ins8.Text = id_string;
                    txt_pre_5_stat_1.Text = "";
                    //panel2.Enabled = false;
                    btn_del_labor.Visible = false;
                    txt_duration.Text = "";
                    txt_pre_6_cost.Text = "";
                    txt_pre_7_det.Text = "";
                    date_prv.Value = DateTime.Now;
                    txt_pre_3_hours.Text = "";
                    pnl_labor.Visible = false;
                    flow_labor.Controls.Clear();
                    label100.Visible = false;
                    dat_grid_prev1.DataSource = new DataTable();
                    dat_grid_prev1.Visible = false;
                    flowLayoutPanel2.Controls.Clear();
                    panel1.Visible = false;
                    btn_bring_to_upd.Visible = false;
                     

                    lb_mod_5.Text = "no";
                    combo_cor_equ.SelectedIndexChanged -= new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
                    combo_cor_equ.SelectedIndex = -1;
                    combo_cor_equ.SelectedIndexChanged += new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
                    pnl_cor.Enabled = false;
                    txt_cor_parts.Text = "";
                    txt_cor_dura.Text = "";
                    txt_cor_cost.Text = "";
                    txt_cor_deta.Text = "";
                    date_cor.Value = DateTime.Now;
                    btn_cor_del_lapor.Visible = false;
                    pnl_cor_names.Visible = false;
                    flow_cor_labors.Controls.Clear();
                    lbl_cor_not_done.Visible = false;
                    datagrid_cor_notdone.DataSource = new DataTable();
                    datagrid_cor_notdone.Visible = false;
                    txt_main_id1.Text = "";
                    txt_cor_state.Text = "";
                    txt_main_ins31.Text = "0";
                    btn_cor_bring.Visible = false;

                    lb_mod_6.Text = "no";
                    comb_CP_main_equ.SelectedIndexChanged -= new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
                    comb_CP_main_equ.SelectedIndex = -1;
                    comb_CP_main_equ.SelectedIndexChanged += new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
                    panel12.Enabled = false; lbl_dai_parts.Text = "a";
                    btn_del_labor2.Visible = false;
                   // panel16.Visible = false;
                    linkLabel2.Visible = false;
                    //label1072.Text = "";
                    txt_main_ins4.Text = "";
                    txt_duration2.Text = "";
                    txt_main_ins6.Text = "";
                    txt_main_ins7.Text = "";
                    date_main_ins.Value = DateTime.Now;
                    pnl_labor2.Visible = false;
                    flow_labor2.Controls.Clear();
                    label107.Visible = false;
                    dataGrid_cor_dai.DataSource = new DataTable();
                    dataGrid_cor_dai.Visible = false;
                    btn_bring_to_upd2.Visible = false;
                    flow_dai.Controls.Clear();
                    panel_dai.Visible = false;
                    txt_main_id.Text = "";
                    txt_main_stg_det_corr.Text = "";
                    txt_main_ins5.Text = "";
                    txt_main_ins3.Text = "";
                }
                if (previou == 5)
                {
                    combo_oil_ins.SelectedIndex = -1;
                    comb_oil_del_equ.SelectedIndex = -1;

                    comb_fuel_ins_equ.SelectedIndex = -1;
                    comb_fuel_del_equ.SelectedIndex = -1;
                    comb_fuel_del.SelectedIndex = -1;

                    combo_laboe_upd.SelectedIndex = -1;

                    combo_filter_equ_ins.SelectedIndex = -1;
                    comb_flt_del_equ.SelectedIndex = -1;
                    comb_flt_del.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int previou = 0;
        int sub_previou = 0;
        int old = 0;
        int sub_old = 0;
        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            old = previou;
            sub_old = sub_previou;
            previou = tabControl1.SelectedIndex;
            if(previou == 3)
            {
                sub_previou = tabControl6.SelectedIndex;
            }
            if (previou == 4)
            {
                sub_previou = tabControl7.SelectedIndex;
            }
            if (previou == 5)
            {
                sub_previou = tabControl8.SelectedIndex;
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = previou;
            if (previou == 3)
            {
                tabControl6.SelectedIndex = sub_previou;
            }
            if (previou == 4)
            {
                tabControl7.SelectedIndex = sub_previou;
            }
            if (previou == 5)
            {
                tabControl8.SelectedIndex = sub_previou;
            }
        }
        #region main_&_up_ins
        private void button4_Click(object sender, EventArgs e)
        {
            pnl_posting.Visible = true;
            pnl_posting.BringToFront();
            pnl_maint.Visible = false;
            pnl_report.Visible = false;
            pnl_posting.BringToFront();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            pnl_posting.Visible = false;
            pnl_maint.Visible = true;
            pnl_report.Visible = false;
            pnl_maint.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pnl_posting.Visible = false;
            pnl_maint.Visible = false;
            pnl_report.Visible = true; pnl_report.BringToFront();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comb_oil_types.SelectedIndex = -1;
            comb_oil_types.DataSource = new DataTable();
            combo_oil_ins.SelectedIndex = -1;
            comb_oil_del_equ.SelectedIndex = -1;
            pnl_oil_ins.Enabled = false;
            if (radioButton3.Checked)
            {
                panel41.Enabled = true; panel37.Enabled = false;
            }
            else
            {
                panel41.Enabled = false; panel37.Enabled = true;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            combo_oil_ins.SelectedIndex = -1;
            comb_oil_del_equ.SelectedIndex = -1;
            comb_oil_types.SelectedIndex = -1;
            comb_oil_types.DataSource = new DataTable();
            comb_oil_del.SelectedIndex = -1;
            comb_oil_del.DataSource = new DataTable();
            if (radioButton4.Checked)
            {
                panel37.Enabled = true; panel41.Enabled = false;
            }
            else
            {
                panel37.Enabled = false; panel41.Enabled = true;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comb_fuel_ins_equ.SelectedIndex = -1;
            comb_fuel_del_equ.SelectedIndex = -1;
            comb_fuel_del.SelectedIndex = -1;
            if (radioButton2.Checked)
            {
                pnl_fue_ins.Enabled = true; pnl_fue_edi.Enabled = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comb_fuel_ins_equ.SelectedIndex = -1;
            comb_fuel_del_equ.SelectedIndex = -1;
            comb_fuel_del.SelectedIndex = -1;
            if (radioButton1.Checked)
            {
                pnl_fue_edi.Enabled = true; pnl_fue_ins.Enabled = false;
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            combo_laboe_upd.SelectedIndex = -1;
            combo_laboe_upd_SelectedIndexChanged(sender, e);
            txt_wrker_name.Text = "";
            txt_salary.Text = "";
            txt_wrk_hrs_ins.Text = "";
            if (radioButton6.Checked)
            {
                pnl_tech_ins.Enabled = true; pnl_tech_ed.Enabled = false;
            }
            else
            {
                pnl_tech_ed.Enabled = false; pnl_tech_ins.Enabled = true;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            combo_laboe_upd.SelectedIndex = -1;
            combo_laboe_upd_SelectedIndexChanged(sender, e);
            txt_wrker_name.Text = "";
            txt_salary.Text = "";
            txt_wrk_hrs_ins.Text = "";
            if (radioButton5.Checked)
            {
                pnl_tech_ed.Enabled = true; pnl_tech_ins.Enabled = false;
            }
            else
            {
                pnl_tech_ins.Enabled = false; pnl_tech_ed.Enabled = true;
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            combo_filter_equ_ins.SelectedIndex = -1;
            comb_flt_del_equ.SelectedIndex = -1;
            comb_flt_del.SelectedIndex = -1;
            combo_filter_equ_ins_SelectedIndexChanged(sender,e);
            comb_flt_del_equ_SelectedIndexChanged(sender, e);
            if (radioButton8.Checked)
            {
                pnl_filt_ins.Enabled = true; pnl_filt_ed.Enabled = false;
            }
            else
            {
                pnl_filt_ed.Enabled = false; pnl_filt_ins.Enabled = true;
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            combo_filter_equ_ins.SelectedIndex = -1;
            comb_flt_del_equ.SelectedIndex = -1;
            comb_flt_del.SelectedIndex = -1;
            if (radioButton7.Checked)
            {
                pnl_filt_ed.Enabled = true; pnl_filt_ins.Enabled = false;
            }
            else
            {
                pnl_filt_ins.Enabled = false; pnl_filt_ed.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1; combo_equ_show_SelectedIndexChanged(sender, e);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
          
        } 
        #endregion
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
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "SQL SERVER database backup files|*.bak";
                dlg.Title = "Restore Database";
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
                    btn_notf_Click(sender,e);
                    combo_equ_show.SelectedIndexChanged -= new System.EventHandler(combo_equ_show_SelectedIndexChanged);
                    comb_add_hours.SelectedIndexChanged -= new System.EventHandler(comb_add_hours_SelectedIndexChanged);
                    comb_prev_main1.SelectedIndexChanged -= new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                    comb_CP_main_equ.SelectedIndexChanged -= new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
                    combo_cor_equ.SelectedIndexChanged -= new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
                    combo_oil_ins.SelectedIndexChanged -= new System.EventHandler(combo_oil_ins_SelectedIndexChanged);
                    comb_oil_del_equ.SelectedIndexChanged -= new System.EventHandler(comb_oil_del_equ_SelectedIndexChanged);
                    comb_fuel_ins_equ.SelectedIndexChanged -= new System.EventHandler(comb_fuel_ins_equ_SelectedIndexChanged);
                    comb_fuel_del_equ.SelectedIndexChanged -= new System.EventHandler(comb_fuel_del_equ_SelectedIndexChanged);
                    
                    comb_flt_del_equ.SelectedIndexChanged -= new System.EventHandler(comb_flt_del_equ_SelectedIndexChanged);
                    combo_filter_equ_ins.SelectedIndexChanged -= new System.EventHandler(combo_filter_equ_ins_SelectedIndexChanged);
                    combo_oil_rep.SelectedIndexChanged -= new System.EventHandler(combo_oil_rep_SelectedIndexChanged);
                    combo_oil_rep.SelectedIndexChanged -= new System.EventHandler(comboBox4_SelectedIndexChanged);
                    comboBox6.SelectedIndexChanged -= new System.EventHandler(comboBox6_SelectedIndexChanged);
                    comboBox9.SelectedIndexChanged -= new System.EventHandler(comboBox9_SelectedIndexChanged);
                    comboBox4.SelectedIndexChanged -= new System.EventHandler(comboBox4_SelectedIndexChanged);
                    refre(combo_equ_show);
                    refre(combo_equ_show);
                    refre(comb_add_hours);
                    refre(comb_prev_main1);
                    refre(comb_CP_main_equ);
                    refre(combo_cor_equ);
                    refre(combo_oil_ins);
                    refre(comb_oil_del_equ);
                    refre(comb_fuel_ins_equ);
                    refre(comb_fuel_del_equ);
                   
                    refre(comb_flt_del_equ);
                    refre(combo_filter_equ_ins);
                    refre(com_report);
                    refre(comboBox1);
                    refre(combo_use);
                    refre(combo_oil_rep);
                    refre(comboBox4);
                    refre(comboBox9);
                    comboBox4.SelectedIndexChanged += new System.EventHandler(comboBox4_SelectedIndexChanged);
                    comboBox9.SelectedIndexChanged += new System.EventHandler(comboBox9_SelectedIndexChanged);
                    comboBox6.SelectedIndexChanged += new System.EventHandler(comboBox6_SelectedIndexChanged);
                    combo_oil_rep.SelectedIndexChanged += new System.EventHandler(comboBox4_SelectedIndexChanged);
                    combo_oil_rep.SelectedIndexChanged += new System.EventHandler(combo_oil_rep_SelectedIndexChanged);
                    combo_equ_show.SelectedIndexChanged += new System.EventHandler(combo_equ_show_SelectedIndexChanged);
                    comb_add_hours.SelectedIndexChanged += new System.EventHandler(comb_add_hours_SelectedIndexChanged);
                    comb_prev_main1.SelectedIndexChanged += new System.EventHandler(comb_prev_main1_SelectedIndexChanged);
                    comb_CP_main_equ.SelectedIndexChanged += new System.EventHandler(comb_CP_main_equ_SelectedIndexChanged);
                    combo_cor_equ.SelectedIndexChanged += new System.EventHandler(combo_cor_equ_SelectedIndexChanged);
                    combo_oil_ins.SelectedIndexChanged += new System.EventHandler(combo_oil_ins_SelectedIndexChanged);
                    comb_oil_del_equ.SelectedIndexChanged += new System.EventHandler(comb_oil_del_equ_SelectedIndexChanged);
                    comb_fuel_ins_equ.SelectedIndexChanged += new System.EventHandler(comb_fuel_ins_equ_SelectedIndexChanged);
                    comb_fuel_del_equ.SelectedIndexChanged += new System.EventHandler(comb_fuel_del_equ_SelectedIndexChanged);
                    
                    comb_flt_del_equ.SelectedIndexChanged += new System.EventHandler(comb_flt_del_equ_SelectedIndexChanged);
                    combo_filter_equ_ins.SelectedIndexChanged += new System.EventHandler(combo_filter_equ_ins_SelectedIndexChanged);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #region tabControl select 
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_notf_Click(sender, e);
            pictureBox8.BringToFront();
            pictureBox8.BringToFront();
            pictureBox8.BringToFront();
            pictureBox8.BringToFront();
            pictureBox8.BringToFront();
            tabControl1.SelectedIndex = 0;
        }
        private void equipmentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            try
            {
                if (label22.Text == "info")
                {
                    combo_equ_show.SelectedValue = combo_filter_equ_ins.SelectedValue;
                    combo_equ_show_SelectedIndexChanged(sender, e);
                }
            }
            catch
            {

            }
            
            
        }
        private void addWorkHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void maintenanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 0; tabControl1.SelectedIndex = 3;          
        }
        private void technicianReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 4; tabControl1.SelectedIndex = 3;          
        }
        private void availabilityAndUtilizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 5; tabControl1.SelectedIndex = 3;           
        }
        private void periodicMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
             tabControl7.SelectedIndex = 0; tabControl1.SelectedIndex = 4;
        if (btn_del_labor.Visible!=true)
            {
                btn_add_labor_Click( sender,  e);
            }
        }
        private void periodicMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl7.SelectedIndex = 1; tabControl1.SelectedIndex = 4;
            if (btn_cor_del_lapor.Visible == false)
            {
                btn_cor_add_lapor_Click(sender, e);
            }
        }
        private void periodicMaintenanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl7.SelectedIndex = 2; tabControl1.SelectedIndex = 4;
            if (btn_del_labor2.Visible == false)
            {
                btn_add_labor2_Click(sender, e);
            }
        }
        #endregion
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb_mod_6.Text = "no";
            //label1072.Text = "";
            txt_main_ins4.Text = "";
            txt_duration2.Text = "";
            txt_main_ins6.Text = "";
            txt_main_ins7.Text = "";
            date_main_ins.Value = DateTime.Now;
            pnl_labor2.Visible = false;
            flow_labor2.Controls.Clear();
            btn_bring_to_upd2.Visible = false;
            flow_dai.Controls.Clear();
            txt_main_id.Text = "";
            txt_main_stg_det_corr.Text = "";
            txt_main_ins5.Text = "";
            txt_main_ins3.Text = "";
            if (linkLabel2.Visible == true)
            {
                linkLabel1_LinkClicked(sender, e);
            }
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb_mod_5.Text = "no";
            txt_cor_parts.Text = "";
            txt_cor_dura.Text = "";
            txt_cor_cost.Text = "";
            txt_cor_deta.Text = "";
            date_cor.Value = DateTime.Now;
            btn_cor_del_lapor.Visible = false;
            pnl_cor_names.Visible = false;
            flow_cor_labors.Controls.Clear();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb_mod_4.Text = "no";
            btn_del_labor.Visible = false;
            txt_duration.Text = "";
            txt_pre_6_cost.Text = "";
            txt_pre_7_det.Text = "";
            date_prv.Value = DateTime.Now;
            pnl_labor.Visible = false;
            flow_labor.Controls.Clear();
            label100.Visible = false;
            btn_pre_upd_Click(sender, e);
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comb_add_hours.SelectedIndexChanged -= new System.EventHandler(comb_add_hours_SelectedIndexChanged);
            comb_add_hours.SelectedIndex = -1;
            comb_add_hours.SelectedIndexChanged += new System.EventHandler(comb_add_hours_SelectedIndexChanged);
            lbl_after.Text = "";
            lbl_prv_hrs_stage2.Text = "";
            lbl_prv_hrs_part2.Text = "";
            lb_mod_2.Text = "no";
            txt_input_hours.Text = "";
            txt_add_hours_total.Text = "";
            date_add_hours.Value = DateTime.Now;
            lbl_main_id.Text = "";
            lbl_hours2.Text = "";
           // panel7.Enabled = false;
           // panel28.Enabled = false;
           //lbl_hours1.ForeColor = Color.White;
        }
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lb_mod_1.Text = "no";
            combo_equ_show.SelectedIndexChanged -= new System.EventHandler(combo_equ_show_SelectedIndexChanged);
            combo_equ_show.SelectedIndex = -1;
            combo_equ_show.SelectedIndexChanged += new System.EventHandler(combo_equ_show_SelectedIndexChanged);
            lbl_sn.Text = "";
            textBox15.Text = "";
            textBox15.Enabled = false;
            lbl_id.Text = "";
            lbl_arr.Text = "";
            label88.Text = "";
            lbl_lng.Text = "";
            lbl_high.Text = "";
            lbl_width.Text = "";
            lbl_wiegt.Text = "";
            lbl_engsn.Text = "";
            lbl_engp.Text = "";
            lbl_highidle.Text = "";
            lbl_lowidle.Text = "";
            lbl_transn.Text = "";
            lbl_tiersize.Text = "";
            lbl_eng_size.Text = "";
            lbl_ac_size.Text = "";
            lbl_mg_size.Text = "";
            dataGridequ4.DataSource = new DataTable();
            dataGridequ2.DataSource = new DataTable();
            dataGridequ3.DataSource = new DataTable();
            comb_prv_sq.SelectedIndexChanged -= new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
            comb_prv_sq.SelectedIndex = -1;
            comb_prv_sq.SelectedIndexChanged += new System.EventHandler(comb_prv_sq_SelectedIndexChanged);
            tableLayoutPanel1.Visible = false;
            panel3.Enabled = false;
        }
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            radioButton3.Checked = true;
            radioButton3_CheckedChanged(sender, e);
        }
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            radioButton2.Checked = true;
            radioButton2_CheckedChanged(sender, e);
        }
     
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            radioButton6.Checked = true;
            radioButton6_CheckedChanged(sender, e);
        }
        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            radioButton8.Checked = true;
            radioButton8_CheckedChanged(sender, e);
        }
        private void chk_rep_word_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chk_rep_word.Checked)
            { txt_rep_word.Enabled = true;}
            else
            {
                txt_rep_word.Enabled = false;
            }
            dataGridView1.DataSource = new DataTable(); panel9.Visible = false; panel11.Visible = false; panel11.Enabled = false;

        }
        private void button10_Click(object sender, EventArgs e)
        {
            string b = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[1].RowIndex].Cells["equ_id"].Value);

            ControlID22.idd = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["main_id"].Value);
            ControlID22.hours = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[3].RowIndex].Cells["main_periodnum"].Value);
            ControlID22.TextData22 = eq.Search_equ_by_name(b);
            linkLabel1_LinkClicked(); btn_report_Click(sender, e);
        }

        #region Filter_tabs
        private void changeUsedFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true; 
            combo_filter_equ_ins.SelectedIndex = -1; 
            combo_filter_equ_ins.Enabled = true;
            rdio_filt_new.CheckedChanged -= new System.EventHandler(rdio_filt_new_CheckedChanged);
            rdio_filt_change.CheckedChanged -= new System.EventHandler(rdio_filt_change_CheckedChanged);
            rdio_filt_change.Checked = true;
            rdio_filt_change.CheckedChanged += new System.EventHandler(rdio_filt_change_CheckedChanged);
            rdio_filt_new.CheckedChanged += new System.EventHandler(rdio_filt_new_CheckedChanged);
            label46.Text = "Change Used Filter";
            combo_change_filter.Location = new Point(104, 42);
            panel23.Visible = false;
            panel50.Location = new Point(0, 186);
            panel50.Visible = true;
            combo_change_filter.Visible = true; txtfilter1.Visible = false; btn_ins_filt.Enabled = false;
            tabControl8.SelectedIndex = 3; tabControl1.SelectedIndex = 5;
        }
        private void newFilterTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            radioButton8.Checked = true; combo_filter_equ_ins.Enabled = true;
            combo_filter_equ_ins.SelectedIndex = -1;
            rdio_filt_new.CheckedChanged -= new System.EventHandler(rdio_filt_new_CheckedChanged);
            rdio_filt_change.CheckedChanged -= new System.EventHandler(rdio_filt_change_CheckedChanged);
            rdio_filt_new.Checked = true;
            rdio_filt_change.CheckedChanged += new System.EventHandler(rdio_filt_change_CheckedChanged);
            rdio_filt_new.CheckedChanged += new System.EventHandler(rdio_filt_new_CheckedChanged);
            label46.Text = "New Catalogue Filter";
            combo_change_filter.Location = new Point(104, 42);
            panel50.Location = new Point(0, 186);
            panel50.Visible = false;
            panel23.Visible = true;
            combo_change_filter.Visible = false; txtfilter1.Visible = true;
            tabControl8.SelectedIndex = 3; tabControl1.SelectedIndex = 5;
        }
        private void combo_filter_equ_ins_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilter1.Text = ""; 
            txtfilter2.Text = "";
            txtfilter3.Text = ""; 
            txtfilter4.Text = "";
            txt_fil_rep1.Text = ""; 
            txt_fil_rep2.Text = ""; 
            txt_fil_rep3.Text = "";
            combo_change_filter.DataSource = new DataTable();
            datefilter1.Value = DateTime.Now;
            if (combo_filter_equ_ins.SelectedIndex == -1|| combo_filter_equ_ins.SelectedValue.ToString() == "{System.Data.DataRowView}") 
            {
                combo_change_filter.SelectedIndexChanged -= new System.EventHandler(combo_change_filter_SelectedIndexChanged);
               // combo_change_filter.Enabled = false;
                combo_change_filter.DataSource = null;
                combo_change_filter.SelectedIndex = -1;
                combo_change_filter.SelectedIndexChanged += new System.EventHandler(combo_change_filter_SelectedIndexChanged);
                panel42.Enabled = false;
                return;
            }
            DataTable tbl = fl.Find_filt_show_data_equ(Convert.ToInt32((combo_filter_equ_ins.SelectedValue)));
            if (tbl.Rows.Count > 0)
            {
               // combo_change_filter.Enabled = true;
                combo_change_filter.SelectedIndexChanged -= new System.EventHandler(combo_change_filter_SelectedIndexChanged);
                combo_change_filter.DataSource = tbl;
                combo_change_filter.ValueMember = "filt_id";
                combo_change_filter.DisplayMember = "filt_type";
                combo_change_filter.SelectedIndex = -1;
                combo_change_filter.SelectedIndexChanged += new System.EventHandler(combo_change_filter_SelectedIndexChanged);
            }
            else
            {
                if (rdio_filt_new.Checked == false)
                {
                    //MessageBox.Show("" + "\n" + "");
                    DialogResult dialogResult = MessageBox.Show("No Catalogue Filter Data For This Equipment"+"\n"+"Register Catalogue Data Now ?", "No Data Registered", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        combo_change_filter.SelectedIndexChanged -= new System.EventHandler(combo_change_filter_SelectedIndexChanged);
                        //combo_change_filter.Enabled = false;
                        combo_change_filter.DataSource = null;
                        combo_change_filter.SelectedIndex = -1;
                        combo_change_filter.SelectedIndexChanged += new System.EventHandler(combo_change_filter_SelectedIndexChanged);
                        rdio_filt_new.CheckedChanged -= new System.EventHandler(rdio_filt_new_CheckedChanged);
                        rdio_filt_change.CheckedChanged -= new System.EventHandler(rdio_filt_change_CheckedChanged);
                        rdio_filt_new.Checked = true; 
                        rdio_filt_change.CheckedChanged += new System.EventHandler(rdio_filt_change_CheckedChanged);
                        rdio_filt_new.CheckedChanged += new System.EventHandler(rdio_filt_new_CheckedChanged);
                        rdio_filt_new_CheckedChanged(sender, e);
                        combo_change_filter.Visible = false;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    rdio_filt_new_CheckedChanged(sender, e);
                }
            }
            panel42.Enabled = true;
        }
        private void combo_change_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fl.Findfilt(Convert.ToInt32(combo_change_filter.SelectedValue)))
            {
                txt_filt_upd1.Text = fl.filt_id.ToString();
                txtfilter2.Text = fl.filt_name.ToString();
                txtfilter3.Text = fl.filt_cap.ToString();
                txtfilter4.Text = fl.filt_cost.ToString();
                datefilter1.Value = DateTime.Now;
                txtfilter5.Text = fl.user_id.ToString();
                label21.Text = fl.filt_replacements.ToString(); btn_ins_filt.Enabled = true;
            }
            else
            {
                txt_filt_upd1.Text = "";
                txtfilter2.Text = "";
                txtfilter3.Text = "";
                txtfilter4.Text = "";
                txtfilter5.Text = "";
                btn_ins_filt.Enabled = false;
            }
        }
        private void btn_ins_filt_Click(object sender, EventArgs e)
        {
            if (datefilter1.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (combo_filter_equ_ins.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }
            try
            {
                string w = "";
                if (Convert.ToInt32(combo_filter_equ_ins.SelectedValue) != 0)
                {
                    if (rdio_filt_new.Checked == true)
                    {
                        if(fl.Find_dup_cat(Convert.ToInt32(combo_filter_equ_ins.SelectedValue), txtfilter1.Text))
                        {
                            DialogResult dialogResult = MessageBox.Show("Same Filter With Same Type Already Exist" + "\n" + "Update Data ?", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                string wwwq = txt_fil_rep0.Text + "<#>" + txt_fil_rep1.Text + "<#>" + txt_fil_rep2.Text + "<#>" + txt_fil_rep3.Text;
                                w = fl.updatefilt(Convert.ToInt32(fl.filt_id), Convert.ToInt32(combo_filter_equ_ins.SelectedValue), txtfilter1.Text,
                                   txtfilter2.Text, Convert.ToInt32(txtfilter3.Text), Convert.ToInt32(txtfilter4.Text),
                                   datefilter1.Value, id, wwwq, Convert.ToDecimal(fl.main_hours), "Catalogue", Convert.ToInt32(fl.main_id));
                            }
                            if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("Please Change Filter Type");
                                return;
                            }
                        }
                        else
                        {
                            int ii = ma.Find_work_hours_int(Convert.ToInt32(combo_filter_equ_ins.SelectedValue));
                            string wwwq = txt_fil_rep0.Text + "<#>" + txt_fil_rep1.Text + "<#>" + txt_fil_rep2.Text + "<#>" + txt_fil_rep3.Text;
                            w = fl.Addfilt(Convert.ToInt32(combo_filter_equ_ins.SelectedValue), txtfilter1.Text,
                               txtfilter2.Text, Convert.ToInt32(txtfilter3.Text), Convert.ToInt32(txtfilter4.Text),
                               datefilter1.Value, id, wwwq, ii, "Catalogue", 0);

                            DataTable er2 = fl.get_all_cata2222();
                            var qd2 = new AutoCompleteStringCollection();
                            for (int i = 0; i < er2.Rows.Count; i++)
                            {
                                qd2.Add(er2.Rows[i][2].ToString());
                            }
                            txtfilter1.AutoCompleteCustomSource = qd2;
                            txtfilter1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        }
                        //if (label46.Text == "Change Used Filter" || label46.Text == "New Filter Type")
                        //{
                        //    if(txt_filt_upd1.Text=="")
                        //    {
                        //        rdio_filt_new.Checked = true;
                        //    }
                        //    else
                        //    {
                        //        rdio_filt_change.Checked = true;
                        //    }
                        //}
                    }
                    if (rdio_filt_change.Checked == true)
                    {
                        int ii = ma.Find_work_hours_int(Convert.ToInt32(combo_filter_equ_ins.SelectedValue));
                        w = fl.Addfilt(Convert.ToInt32(combo_filter_equ_ins.SelectedValue), combo_change_filter.Text,
                            txtfilter2.Text,Convert.ToInt32(txtfilter3.Text), Convert.ToInt32(txtfilter4.Text), 
                            datefilter1.Value, id, label21.Text, ii, "Active", 0);
                    }
                    if (w == "Success")
                    {
                        if (panel50.Visible == true)
                        {

                            int ide = Convert.ToInt32(comboBox12.SelectedValue);
                            string nameee = comboBox12.Text;
                            int eq_id = Convert.ToInt32(combo_filter_equ_ins.SelectedValue);
                            string oil_id = oi.get_last_id("filt_id", "filter");
                            string work = worksal.Add_job_reprot(ide, nameee, eq_id,
                            Convert.ToInt32(textBox17.Text), datefilter1.Value.Date, "Add Filter", oil_id);
                        }
                        combo_filter_equ_ins.Enabled = true;
                        MessageBox.Show(w);
                        txtfilter1.Text = "";
                        txtfilter2.Text = "";
                        txtfilter3.Text = "";
                        txtfilter4.Text = "";
                        txt_fil_rep1.Text = "";
                        txt_fil_rep0.Text = "";
                        txt_fil_rep2.Text = "";
                        txt_fil_rep3.Text = "";
                        rdio_filt_new.Checked = false;
                        rdio_filt_change.Checked = false;
                        //label46.Text = "";
                        if (label22.Text == "info")
                        {
                            label22.Text = "";
                            tabControl1.SelectedIndex = 1;
                            combo_equ_show_SelectedIndexChanged(sender, e); 
                            return;
                        }
                        if (label46.Text == "Change Used Filter")
                        {
                            changeUsedFilterToolStripMenuItem_Click( sender,  e);
                        }
                        if (label46.Text == "New Filter Type")
                        {
                            newFilterTypeToolStripMenuItem_Click(sender, e);
                        }
                        //label46.Text = "";

                    }
                    else { MessageBox.Show("Please Recheck your inputs V29"); }
                }
                else { MessageBox.Show("Please choose Equipment"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ " \n Please Recheck your inputs V30");
            }
        }
        private void editActiveFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            radioButton7.Checked = true;
            rdio_filt_new.Checked = true;
            comb_flt_del_equ.Enabled = true;
            comb_flt_del_equ.SelectedIndex = -1;
            lbl_what_filter.Text = "Edit Filter";
            label188.Text = "Edit Filter";
            //panel25.Visible = false;
            tabControl8.SelectedIndex = 3; tabControl1.SelectedIndex = 5;
        }
        private void comb_flt_del_equ_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Text = "";
            txt_filt_upd4.Text = "";
            txt_filt_upd5.Text = "";
            txt_filt_upd6.Text = ""; txt_fil_rep_up0.Text = "";
            txt_fil_rep_up1.Text = "";
            txt_fil_rep_up2.Text = "";
            dat_filt_upd1.Value = DateTime.Now;
            txt_fil_rep_up3.Text = "";
            if (comb_flt_del_equ.SelectedIndex == -1 || comb_flt_del_equ.SelectedValue == "{System.Data.DataRowView}")
            { 
                comb_flt_del.SelectedIndexChanged -= new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                comb_flt_del.Enabled = false;
                comb_flt_del.DataSource = null;
                comb_flt_del.SelectedIndex = -1;
                comb_flt_del.SelectedIndexChanged += new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                panel44.Enabled = false;
                return;
            }
            try
            {
                DataTable x = fl.Find_filt_show_data_equ(Convert.ToInt32((comb_flt_del_equ.SelectedValue)));
                if (x.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Edit Please Add Data First");
                    comb_flt_del.SelectedIndexChanged -= new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                    comb_flt_del.Enabled = false;
                    comb_flt_del.DataSource = null;
                    comb_flt_del.SelectedIndex = -1;
                    panel44.Enabled = false;
                    comb_flt_del.SelectedIndexChanged += new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                }
                else
                {
                    comb_flt_del.Enabled = true;
                    comb_flt_del.SelectedIndexChanged -= new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                    comb_flt_del.DataSource = x;
                    comb_flt_del.ValueMember = "filt_id";
                    comb_flt_del.DisplayMember = "filt_type";
                    comb_flt_del.SelectedIndex = -1;
                    panel44.Enabled = true;
                    comb_flt_del.SelectedIndexChanged += new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comb_flt_del_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btn_flt_sho_Click(sender, e);
            }
            catch
            {
                txt_filt_upd1.Text = "";
                txt_filt_upd2.Text = "";
                txt_filt_upd4.Text = "";
                txt_filt_upd5.Text = "";
                txt_filt_upd6.Text = "";
                txt_fil_rep_up1.Text = ""; txt_fil_rep_up0.Text = "";
                txt_fil_rep_up2.Text = "";
                txt_fil_rep_up3.Text = "";
            }
        }
        private void btn_flt_sho_Click(object sender, EventArgs e)
        {
            if (comb_flt_del.SelectedIndex != -1 && comb_flt_del.SelectedIndex != -1)
            {
                fl.Findfilt(Convert.ToInt32(comb_flt_del.SelectedValue));
                textBox9.Text = fl.filt_id.ToString();
                txt_filt_upd4.Text = fl.filt_name.ToString();
                txt_filt_upd5.Text = fl.filt_cap.ToString();
                txt_filt_upd6.Text = fl.filt_cost.ToString();
                txt_filt_upd8.Text = fl.user_id.ToString();
                txt_filt_upd2.Text = fl.filt_replacements.ToString();
                //panel25.Visible = true;
                btn_flt_upd.Enabled = true;
                btn_del_filt.Enabled = true;
                string[] lines = Regex.Split(txt_filt_upd2.Text, "<#>");
                txt_fil_rep_up0.Text = lines[0];
                txt_fil_rep_up1.Text = lines[1];
                txt_fil_rep_up2.Text = lines[2];
                txt_fil_rep_up3.Text = lines[3];
            }
            else
            {
                MessageBox.Show("Please Choose Filter First");
            }
        }
        private void btn_del_filt_Click(object sender, EventArgs e)
        {
            if (comb_flt_del.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose Filter Type First"); return;
            }
            DialogResult dialogResult = MessageBox.Show("Delete this Filter?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(fl.delflt(Convert.ToInt32(comb_flt_del.SelectedValue)));
                comb_flt_del_equ_SelectedIndexChanged(sender, e);
            }
            if (dialogResult == DialogResult.No) { }
        }
        private void btn_flt_upd_Click(object sender, EventArgs e)
        {
            if (dat_filt_upd1.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comb_flt_del_equ.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }
            if (comb_flt_del.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose valid Filter Type"); return;
            }
            if (txt_filt_upd4.Text != "")
            {
                int ii = ma.Find_work_hours_int(Convert.ToInt32(comb_flt_del_equ.SelectedValue));
                string wwwq = txt_fil_rep_up0.Text + "<#>" + txt_fil_rep_up1.Text + "<#>" + txt_fil_rep_up2.Text + "<#>" + txt_fil_rep_up3.Text;
                string w = fl.updatefilt(Convert.ToInt32(comb_flt_del.SelectedValue), Convert.ToInt32(comb_flt_del_equ.SelectedValue),
                        comb_flt_del.Text, txt_filt_upd4.Text, Convert.ToInt32(txt_filt_upd5.Text), Convert.ToInt32(txt_filt_upd6.Text),
                        dat_filt_upd1.Value, id, wwwq, ii, "Catalogue", 0);


                if (w == "Success")
                {
                    MessageBox.Show(w);
                    comb_flt_del.SelectedIndexChanged -= new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                    comb_flt_del.DataSource = null;
                    comb_flt_del.SelectedIndexChanged += new System.EventHandler(comb_flt_del_SelectedIndexChanged);
                    if (label22.Text == "info")
                    {
                        //combo_equ_show.SelectedIndex = comb_flt_del_equ.SelectedIndex;
                        label22.Text = "";
                        tabControl1.SelectedIndex = 1;
                        combo_equ_show_SelectedIndexChanged(sender, e); 
                        return;
                    }
                    comb_flt_del_equ_SelectedIndexChanged(sender, e);
                }
                else { MessageBox.Show("Please Recheck your inputs V31"); }
            }
            else { MessageBox.Show("Please Enter Filter Name First"); }
        }
        #endregion

        #region oils_tabs
        private void addAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo_oil_ins.SelectedIndex = -1;
            radioButton3.Checked = true;
            lbl_oil_what.Text = "Add Amount";
            rdio_oil_add.Checked = true;
            //panel43.Visible = false;
            pnl_oil_ins.Enabled = false;
            tabControl8.SelectedIndex = 0; tabControl1.SelectedIndex = 5;
        }
        private void totalRefillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo_oil_ins.SelectedIndex = -1;
           
            radioButton3.Checked = true;
            lbl_oil_what.Text = "totally Refill";
            rdio_oil_new.Checked = true;
            //panel43.Visible = false;
            pnl_oil_ins.Enabled = false;
            tabControl8.SelectedIndex = 0; tabControl1.SelectedIndex = 5;
        }
        private void rdio_oil_add_CheckedChanged(object sender, EventArgs e)
        {
            if (combo_oil_ins.SelectedIndex > -1)
            {
                if (rdio_oil_add.Checked == true || rdio_oil_new.Checked == true)
                {
                    DataTable x = oi.Find_oil_show_Catalogue_Equivalent(Convert.ToInt32(combo_oil_ins.SelectedValue));
                    if (x.Rows.Count == 0 && combo_oil_ins.SelectedIndex >= 0)
                    {

                        if (x.Rows.Count == 0)
                        {
                            comb_oil_types.SelectedIndexChanged -= new System.EventHandler(comb_oil_types_SelectedIndexChanged);
                            comb_oil_types.DataSource = new DataTable();
                            comb_oil_types.SelectedIndex = -1;
                            comb_oil_types.SelectedIndexChanged += new System.EventHandler(comb_oil_types_SelectedIndexChanged);
                            //pnl_oil_ins.Enabled = false;
                            //pnl_oil.Enabled = false;
                            MessageBox.Show("There is No Oils Catalogue Data PLease Edit Catalogue Data First Then Refill Oil");
                            rdio_oil_cata.Checked = true; btn_oil_ins.Enabled =true;
                        }
                    }
                    else
                    {
                        comb_oil_types.SelectedIndexChanged -= new System.EventHandler(comb_oil_types_SelectedIndexChanged);
                        comb_oil_types.DataSource = x;
                        comb_oil_types.ValueMember = "oil_id";
                        comb_oil_types.DisplayMember = "oil_type";
                        comb_oil_types.SelectedIndex = -1;
                        comb_oil_types.SelectedIndexChanged += new System.EventHandler(comb_oil_types_SelectedIndexChanged);
                        btn_oil_ins.Enabled = false;
                        //pnl_oil.Enabled = true;
                    }
                    DataTable asdq = wo.bring_labor_names();
                    if (asdq.Rows.Count == 0)
                    {
                        comboBox10.DataSource = null;
                        comboBox10.SelectedIndex = -1;
                        comboBox10.SelectedValue = 0;
                        comboBox10.Text = "No Data";
                    }
                    else
                    {
                        comboBox10.DataSource = asdq;
                        comboBox10.ValueMember = "worker_id";
                        comboBox10.DisplayMember = "worker_name";
                        comboBox10.SelectedIndex = -1;
                    }
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox10.Text = "";
                    txt_oil_rep_ins0.Text = "";
                    txt_oil_ins2.Text = "";
                    txt_oil_ins3.Text = "";

                    panel43.Location = new Point(0, 189);
                    panel38.Location = new Point(0, 189);
                    panel43.Visible = false;
                    panel38.Visible = true;

                    comb_oil_types.Visible = true;
                    if (comb_oil_types.SelectedIndex<0)
                    {
                        btn_oil_ins.Enabled = false;
                    }
                    else
                    {
                        btn_oil_ins.Enabled = true;
                    }
                    textBox4.Text = "";
                    txt_oil_ins4.Text = "";
                    txt_oil_rep_ins1.Text = "";
                    txt_oil_rep_ins2.Text = "";
                    txt_oil_rep_ins3.Text = ""; 
                    pnl_oil_ins.Enabled = true; 
                    pnl_oil.Enabled = true;
                    date_oil_ins1.Value = DateTime.Now;
                    if (rdio_oil_new.Checked)
                    {
                        txt_oi_state.Text = "ReFill";
                    }
                    else if (rdio_oil_add.Checked)
                    {
                        txt_oi_state.Text = "Add";
                    }
                    else
                    {
                        txt_oi_state.Text = "Catalogue";
                        //txt_oil_ins2.Text = "";
                        //txt_oil_ins3.Text = ""; 
                        //textBox4.Text = "";
                        //txt_oil_ins4.Text = "";
                        //txt_oil_rep_ins1.Text = "";
                        //txt_oil_rep_ins2.Text = "";
                        //txt_oil_rep_ins3.Text = "";
                        //date_oil_ins1.Value = DateTime.Now;
                    }
                }
            }
            else
            {
                pnl_oil_ins.Enabled = false; pnl_oil.Enabled = false;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Tab))
            {
                //MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            if (keyData == (Keys.Control | Keys.PageDown))
            {
                //MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            if (keyData == (Keys.Control | Keys.PageUp))
            {
                //MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.Tab))
            {
                //MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.T))
            {
                //MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void combo_oil_ins_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_oil_ins.SelectedIndex > -1)
                {
                    pnl_oil.Enabled = true;
                    if(rdio_oil_add.Checked == true)
                    {
                        rdio_oil_add_CheckedChanged(sender, e);
                    }
                    else if(rdio_oil_new.Checked == true)
                    {
                        rdio_oil_add_CheckedChanged(sender, e);
                    }
                    else if (rdio_oil_cata.Checked == true)
                    {
                        rdio_oil_cata_CheckedChanged(sender, e);
                    }
                }
                else
                {
                    pnl_oil.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comb_oil_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comb_oil_types.SelectedIndex>-1)
                {
                    if (oi.Findoil(Convert.ToInt32(comb_oil_types.SelectedValue)))
                    {
                        pnl_oil_ins.Enabled = true;
                        txt_oil_ins2.Text = oi.oil_name.ToString();
                        txt_oil_ins3.Text = oi.oil_cap.ToString();
                        txt_oil_ins4.Text = oi.oil_cost.ToString();
                        date_oil_ins1.Value = DateTime.Now;
                        textBox4.Text = Convert.ToString(Convert.ToDecimal(txt_oil_ins4.Text) / Convert.ToDecimal(txt_oil_ins3.Text));

                        string h = oi.oil_replacements.ToString();
                        string[] lines = Regex.Split(h, "<#>");
                        if (lines.Length == 3)
                        {
                            txt_oil_rep_ins1.Text = lines[0];
                            txt_oil_rep_ins2.Text = lines[1];
                            txt_oil_rep_ins3.Text = lines[2];
                        }
                        else if (lines.Length == 2)
                        {
                            txt_oil_rep_ins1.Text = lines[0];
                            txt_oil_rep_ins2.Text = lines[1];
                            txt_oil_rep_ins3.Text = "";
                        }
                        else if (lines.Length == 1)
                        {
                            txt_oil_rep_ins1.Text = lines[0];
                            txt_oil_rep_ins2.Text = "";
                            txt_oil_rep_ins3.Text = "";
                        }
                        else
                        {
                            txt_oil_rep_ins1.Text = "";
                            txt_oil_rep_ins2.Text = "";
                            txt_oil_rep_ins3.Text = "";
                        }
                        btn_oil_ins.Enabled = true;
                    }
                }
                else
                {
                    txt_oil_ins2.Text = "";
                    txt_oil_ins3.Text = "";
                    txt_oil_ins4.Text = "";
                    textBox4.Text = "";
                    txt_oil_rep_ins1.Text = "";
                    txt_oil_rep_ins2.Text = "";
                    txt_oil_rep_ins3.Text = "";
                    btn_oil_ins.Enabled = false;
                }
            }
            catch
            {
                txt_oil_ins2.Text = "";
                txt_oil_ins3.Text = "";
                txt_oil_ins4.Text = "";
                textBox4.Text = "";
                txt_oil_rep_ins1.Text = "";
                txt_oil_rep_ins2.Text = "";
                txt_oil_rep_ins3.Text = "";
            }
        }
        private void btn_oil_ins_Click(object sender, EventArgs e)
        {
            if (date_oil_ins1.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (combo_oil_ins.SelectedIndex == -1&& radioButton3.Checked==true)
            {
                MessageBox.Show("Please choose Equipment"); return;
            }
            if (comb_oil_types.SelectedIndex == -1 && radioButton4.Checked == true)
            {
                MessageBox.Show("Please choose Equipment"); return;
            }
            if (rdio_oil_add.Checked == false && rdio_oil_new.Checked == false && rdio_oil_cata.Checked == false)
            {
                MessageBox.Show("Please Choose New Type Or Add Amount First"); return;
            }
            try
            {
                if(comb_oil_types.Visible == false && txt_oil_ins2.Text == "")
                {
                   return;
                }
                decimal ae = Convert.ToDecimal(txt_oil_ins4.Text);
                int dae = Decimal.ToInt32(ae);
                int ho = ma.Find_work_hours_int(Convert.ToInt32(combo_oil_ins.SelectedValue));
                string wwwq = txt_oil_rep_ins0.Text + "<#>" + txt_oil_rep_ins1.Text + "<#>" + txt_oil_rep_ins2.Text + "<#>" + txt_oil_rep_ins3.Text + "<#>" + textBox10.Text + "<#>" + textBox8.Text;
                string trrr = "";
                if(comb_oil_types.Visible==true)
                {
                    trrr = comb_oil_types.Text;
                }
                else
                {
                    trrr = textBox7.Text;
                }
                string w = oi.Addoil(Convert.ToInt32(combo_oil_ins.SelectedValue), trrr, txt_oil_ins2.Text,
                   Convert.ToDecimal(txt_oil_ins3.Text), dae, date_oil_ins1.Value,
                    id, wwwq, txt_oi_state.Text, ho ,"", 0);
                
                if (w == "Success")
                {
                    if(panel38.Visible == true)
                    {
                        
                        int ide = Convert.ToInt32(comboBox10.SelectedValue);
                        string nameee = comboBox10.Text;
                        int eq_id = Convert.ToInt32(combo_oil_ins.SelectedValue);
                        string oil_id = oi.get_last_id("oil_id", "oil");
                        string work = worksal.Add_job_reprot(ide,nameee , eq_id,
                        Convert.ToInt32(textBox14.Text), date_oil_ins1.Value.Date, "Add Oil", oil_id);
                    }
                    MessageBox.Show(w);
                    txt_oil_ins2.Text = "";
                    txt_oil_ins3.Text = "";
                    txt_oil_ins4.Text = "";
                    txt_oil_rep_ins1.Text = "";
                    txt_oil_rep_ins2.Text = "";
                    txt_oil_rep_ins3.Text = "";
                    textBox4.Text = "0";
                    textBox8.Text = "";
                    textBox10.Text = "";
                    textBox7.Text = "";
                    if (rdio_oil_add.Checked)
                    {
                        rdio_oil_add_CheckedChanged(sender, e);
                    }
                    else if (rdio_oil_new.Checked)
                    {
                        rdio_oil_add_CheckedChanged(sender, e);
                    }
                    else
                    {
                        rdio_oil_cata_CheckedChanged(sender, e);

                        DataTable er = oi.Find_oil_show_Catalogue_Equivalent(-99);
                        var qd = new AutoCompleteStringCollection();
                        for (int i = 0; i < er.Rows.Count; i++)
                        {
                            qd.Add(er.Rows[i][2].ToString());
                        }
                        textBox7.AutoCompleteCustomSource = qd;
                        textBox7.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    }
                    comb_oil_del_equ.SelectedIndex = -1;
                    if (where.Text == "info")
                    {
                        where.Text = "";
                        combo_equ_show.SelectedValue = combo_oil_ins.SelectedValue;
                        combo_equ_show_SelectedIndexChanged(sender, e);
                        tabControl1.SelectedIndex = 1;
                    }
                   
                }
                else { MessageBox.Show("Please Recheck your inputs V32"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ " \n Please Recheck your inputs V33");
            }
        }
        private void editMainOilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comb_oil_del_equ.SelectedIndex = -1;
            radioButton4.Checked = true;
            //panel45.Visible = false;
            pnl_oil_up_del.Enabled = false;
            tabControl8.SelectedIndex = 0; tabControl1.SelectedIndex = 5;
        }
        private void comb_oil_del_equ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_oil_del_equ.SelectedValue != null)
            {
                try
                {
                    DataTable x = new DataTable();

                        x = oi.Find_oil_show_Catalogue_Equivalent(Convert.ToInt32(comb_oil_del_equ.SelectedValue));
                        //txt_oil_upd5.Enabled = false;
                    
                    if (x.Rows.Count == 0)
                    {
                        comb_oil_del.SelectedIndexChanged -= new System.EventHandler(comb_oil_del_SelectedIndexChanged);
                        comb_oil_del.DataSource = new DataTable();
                        comb_oil_del.SelectedIndex = -1;
                        comb_oil_del.SelectedIndexChanged += new System.EventHandler(comb_oil_del_SelectedIndexChanged);
                            MessageBox.Show("There is No Catalogue Data PLease Add Catalogue Data First");
                        
                    }
                    else
                    {
                        comb_oil_del.Enabled = true;
                        pnl_oil_up_del.Enabled = true;
                        comb_oil_del.Enabled = true;
                        comb_oil_del.SelectedIndexChanged -= new System.EventHandler(comb_oil_del_SelectedIndexChanged);
                        comb_oil_del.DataSource = x;
                        comb_oil_del.ValueMember = "oil_id";
                        comb_oil_del.DisplayMember = "oil_type";
                        comb_oil_del.SelectedIndex = -1;
                        comb_oil_del.SelectedIndexChanged += new System.EventHandler(comb_oil_del_SelectedIndexChanged);
                    }
                    textBox3.Text = "";
                    txt_oil_upd1.Text = "";
                    txt_oil_upd2.Text = "";
                    txt_oil_upd4.Text = "";
                    txt_oil_upd5.Text = "";
                    txt_oil_upd6.Text = "";
                    txt_oil_rep_up1.Text = "";
                    txt_oil_rep_up2.Text = "";
                    txt_oil_rep_up3.Text = "";
                    //pnl_oil_up_del.Visible = false;
                    //pnl_oil_up_del.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBox3.Text = "";
                txt_oil_upd1.Text = "";
                txt_oil_upd2.Text = "";
                txt_oil_upd4.Text = "";
                txt_oil_upd5.Text = "";
                txt_oil_upd6.Text = "";
                txt_oil_rep_up1.Text = "";
                txt_oil_rep_up2.Text = "";
                txt_oil_rep_up3.Text = "";
                pnl_oil_up_del.Enabled = false;
            }
        }
        private void comb_oil_del_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_oil_upd1.Text = "";
                txt_oil_upd2.Text = "";
                txt_oil_upd4.Text = "";
                txt_oil_upd5.Text = "";
                txt_oil_upd6.Text = "";
                txt_oil_rep_up1.Text = "";
                txt_oil_rep_up2.Text = "";
                txt_oil_rep_up3.Text = "";
                btn_oil_sho_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txt_oil_upd1.Text = "";
                txt_oil_upd2.Text = "";
                txt_oil_upd4.Text = "";
                txt_oil_upd5.Text = "";
                txt_oil_upd6.Text = "";
                txt_oil_rep_up1.Text = "";
                txt_oil_rep_up2.Text = "";
                txt_oil_rep_up3.Text = "";
                pnl_oil_up_del.Enabled = false;
            }
        }
        private void btn_oil_sho_Click(object sender, EventArgs e)
        {
            if ((comb_oil_del.SelectedValue != null && comb_oil_del_equ.SelectedIndex != -1) || txt_oil_upd1.Text != "")
            {
                pnl_oil_up_del.Enabled = true;
                //btn_oil_del.Enabled = true;
                if (comb_oil_del.SelectedValue == null)
                {
                    oi.Findoil(Convert.ToInt32(txt_oil_upd1.Text));
                }
                else
                {
                    oi.Findoil(Convert.ToInt32(comb_oil_del.SelectedValue));
                }

                txt_oil_upd1.Text = oi.oil_id.ToString();
                txt_oil_upd2.Text = oi.equ_id.ToString();
                //combo_upd_oil_boss.Text = oi.oil_type.ToString();
                txt_oil_upd4.Text = oi.oil_name.ToString();
                txt_oil_upd5.Text = oi.oil_cap.ToString();
                txt_oil_upd6.Text = oi.oil_cost.ToString();
                date_oil_upd1.Value = oi.oil_date;
                txt_oil_upd8.Text = oi.user_id.ToString();
                txt_oil_upd_main_type.Text = oi.main_type.ToString();
                txt_oil_upd_main_state.Text = oi.oil_state.ToString();
                txt_oil_upd_main_alert.Text = oi.oil_alert.ToString();
                main_iiid.Text = oi.main_id.ToString();
                textBox3.Text = Convert.ToString(Convert.ToDecimal(txt_oil_upd6.Text) / Convert.ToDecimal(txt_oil_upd5.Text));

                string h = oi.oil_replacements.ToString();
                string[] lines = Regex.Split(h, "<#>");
                txt_oil_rep_up0.Text = lines[0];
                txt_oil_rep_up1.Text = lines[1];
                txt_oil_rep_up2.Text = lines[2];
                txt_oil_rep_up3.Text = lines[3];
                textBox12.Text = lines[4];
                textBox11.Text = lines[5];
            }
            else
            {
                txt_oil_upd1.Text = "";
                txt_oil_upd2.Text = "";
                txt_oil_upd4.Text = "";
                txt_oil_upd5.Text = "";
                txt_oil_upd6.Text = "";
                txt_oil_rep_up1.Text = "";
                txt_oil_rep_up2.Text = "";
                txt_oil_rep_up3.Text = "";
                main_iiid.Text = "0";
                txt_oil_upd1.Text = "";
                txt_oil_upd2.Text = "";
                txt_oil_upd4.Text = "";
                txt_oil_upd5.Text = "";
                txt_oil_upd6.Text = "";
                pnl_oil_up_del.Enabled = false;
            }
        }
        private void btn_oil_del_Click(object sender, EventArgs e)
        {
            if (comb_oil_del.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose oil Type First"); return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Oil Type ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(oi.deloil(Convert.ToInt32(txt_oil_upd1.Text)));
                comb_oil_del_equ_SelectedIndexChanged(sender, e);
            }
            if (dialogResult == DialogResult.No) { }
        }
        private void btn_oil_upd_Click(object sender, EventArgs e)
        {
            if (date_oil_upd1.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comb_oil_del_equ.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }
            if (comb_oil_del.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose valid Oil Type"); return;
            }

            if (txt_oil_upd4.Text != "")
            {
                
                decimal ae =Convert.ToDecimal( txt_oil_upd6.Text);
                int dae = Decimal.ToInt32(ae);
                //int.TryParse(txt_oil_upd6.Text, out dae);
                   
                string wwwq = txt_oil_rep_up0.Text + "<#>" + txt_oil_rep_up1.Text + "<#>" + txt_oil_rep_up2.Text + "<#>" + txt_oil_rep_up3.Text + "<#>" + textBox12.Text + "<#>" + textBox11.Text;
                string w = oi.updateoil(Convert.ToInt32(txt_oil_upd1.Text), Convert.ToInt32(comb_oil_del_equ.SelectedValue),
                comb_oil_del.Text, txt_oil_upd4.Text, Convert.ToDecimal(txt_oil_upd5.Text), dae, date_oil_upd1.Value,
                id, wwwq, txt_oil_upd_main_type.Text, txt_oil_upd_main_type.Text, txt_oil_upd_main_state.Text, txt_oil_upd_main_alert.Text, 
                Convert.ToInt32(main_iiid.Text));
                if (w == "Success")
                {
                    MessageBox.Show(w);
                    comb_oil_del.SelectedIndexChanged -= new System.EventHandler(comb_oil_del_SelectedIndexChanged);
                    comb_oil_del.DataSource = null;
                    comb_oil_del.SelectedIndexChanged += new System.EventHandler(comb_oil_del_SelectedIndexChanged);
                    comb_oil_del_equ_SelectedIndexChanged(sender, e);
                }
                else { MessageBox.Show("Please Recheck your inputs V34"); }
            }
            else { MessageBox.Show("Please Recheck your inputs V35"); }
            if (where.Text == "info")
            {
                where.Text = "";
                //int x = comb_oil_del_equ.SelectedIndex;
                tabControl1.SelectedIndex = 1;
                //combo_equ_show.SelectedIndex = x;
                combo_equ_show_SelectedIndexChanged(sender, e);
                //combo_equ_show_SelectedIndexChanged(sender, e);
            }
            else if (where.Text == "report")
            {
                tabControl6.SelectedIndex = 3; tabControl1.SelectedIndex = 3;
                pictureBox6_Click(sender, e);
            }
        }
        #endregion

        #region fuel_tabs
        private void newCatalogueDataToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            comb_fuel_ins_equ.SelectedIndex = -1;
            radioButton2.Checked = true;
            radioButton11.CheckedChanged -= new System.EventHandler(this.radioButton11_CheckedChanged);
            radioButton11.Checked = true;
            radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            panel49.Enabled = false;
            tabControl8.SelectedIndex = 1;
            tabControl1.SelectedIndex = 5;
        }
        private void comb_fuel_ins_equ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comb_fuel_ins_equ.SelectedIndex!= -1)
            {
                panel21.Enabled = true;
                if (radioButton12.Checked == true)
                {
                    radioButton12_CheckedChanged(sender, e);
                }
                else
                {
                    radioButton11_CheckedChanged(sender, e);
                }
            }
            else
            {
                panel21.Enabled = false;
                panel49.Enabled = false;
                txt_fuel_ins1.Text = "";
                txt_fuel_ins3.Text = "";
                textBox5.Text = "";
                txt_fuel_ins4.Text = "";
                panel45.Visible = false;
            }
        }
        private void btn_fuel_ins_Click(object sender, EventArgs e)
        {
            if (date_fuel_ins.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comb_fuel_ins_equ.SelectedValue == null)
            {
                MessageBox.Show("Please choose Equipment"); return;
            }
            if (radioButton11.Checked == true && txt_fuel_ins1.Text == "" )
            {
                MessageBox.Show("Please Enter Fuel Type"); return;
            }
            try
            {

                string act = "";
                string typ = "";
                if (radioButton12.Checked == true)
                {
                    act = "Add";
                    typ = comboBox3.Text;
                }
                else
                {
                    typ = txt_fuel_ins1.Text;
                    act = "Catalogue";
                }
                int ii = ma.Find_work_hours_int(Convert.ToInt32(comb_fuel_ins_equ.SelectedValue));
                string w = fu.Addfuel(Convert.ToInt32(comb_fuel_ins_equ.SelectedValue), typ,
            "0", Convert.ToDecimal(txt_fuel_ins3.Text),
            Convert.ToInt32(txt_fuel_ins4.Text), date_fuel_ins.Value, id,ii, act,0);
                if (w == "Success")
                {
                    if (panel45.Visible == true)
                    {

                        int ide = Convert.ToInt32(comboBox11.SelectedValue);
                        string nameee = comboBox11.Text;
                        int eq_id = Convert.ToInt32(comb_fuel_ins_equ.SelectedValue);
                        string oil_id = oi.get_last_id("fuel_id", "fuel");
                        string work = worksal.Add_job_reprot(ide, nameee, eq_id,
                        Convert.ToInt32(textBox16.Text), date_fuel_ins.Value.Date, "Add Fuel", oil_id);
                    }
                    MessageBox.Show(w);
                    txt_fuel_ins1.Text = "";
                    txt_fuel_ins2.Text = ""; comboBox3.SelectedIndex = -1;
                    txt_fuel_ins3.Text = ""; date_fuel_ins.Value = DateTime.Now;
                    txt_fuel_ins4.Text = "";
                    comb_fuel_del_equ.SelectedIndex = -1;
                    if (label26.Text == "info")
                    {
                        //combo_equ_show.SelectedIndex = comb_fuel_del_equ.SelectedIndex;
                        label26.Text = "";
                        tabControl1.SelectedIndex = 1;
                        combo_equ_show_SelectedIndexChanged(sender, e);
                    }
                }
                else { MessageBox.Show("Please Recheck your inputs V36"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n Please Recheck your inputs V37");
            }
        }

        private void newCatalogueDataToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            comb_fuel_del_equ.SelectedIndex = -1;
            radioButton1.Checked = true;
            pnl_filer_fuel_del.Enabled = false;
            tabControl8.SelectedIndex = 1;
            tabControl1.SelectedIndex = 5;
        }
        private void newCatalogueDataToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            comb_fuel_del_equ.SelectedIndex = -1;
            radioButton1.Checked = true;
            pnl_filer_fuel_del.Enabled = false;
            tabControl8.SelectedIndex = 1;
            tabControl1.SelectedIndex = 5;
        }
        private void editLiterCostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comb_fuel_del_equ.SelectedIndex = -1;
            radioButton1.Checked = true;
            pnl_filer_fuel_del.Enabled = false;
            tabControl8.SelectedIndex = 1;
            tabControl1.SelectedIndex = 5;
            radioButton11.Checked = true;
        }
        private void comb_fuel_del_equ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_fuel_del_equ.SelectedIndex == -1)
            {
                comb_fuel_del.SelectedIndexChanged -= new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
                comb_fuel_del.Enabled = false;
                comb_fuel_del.DataSource = null;
                comb_fuel_del.SelectedIndex = -1;
                pnl_filer_fuel_del.Enabled = false;
                comb_fuel_del.SelectedIndexChanged += new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
            }
            else
            {
                try
                {
                    DataTable x = fu.Find_fuel_show_data(Convert.ToInt32((comb_fuel_del_equ.SelectedValue)));
                    if (x.Rows.Count == 0)
                    {
                        MessageBox.Show("No Catalogue Data Please Add Catalogue Data First");
                        comb_fuel_del.SelectedIndexChanged -= new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
                        comb_fuel_del.Enabled = false;
                        comb_fuel_del.DataSource = null;
                        comb_fuel_del.SelectedIndex = -1;
                        pnl_filer_fuel_del.Enabled = false;
                        comb_fuel_del.SelectedIndexChanged += new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
                    }
                    else
                    {
                        comb_fuel_del.Enabled = true;
                        comb_fuel_del.SelectedIndexChanged -= new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
                        comb_fuel_del.DataSource = x;
                        comb_fuel_del.ValueMember = "fuel_id";
                        comb_fuel_del.DisplayMember = "fuel_type";
                        comb_fuel_del.SelectedIndex = -1;
                        pnl_filer_fuel_del.Enabled = true;
                        comb_fuel_del.SelectedIndexChanged += new System.EventHandler(comb_fuel_del_SelectedIndexChanged);
                    }
                    txt_fuel_upd1.Text = "";
                    txt_fuel_upd2.Text = "";
                    comb_fuel_del.SelectedIndex = -1;
                    txt_fuel_upd4.Text = "";
                    textBox6.Text = "";
                    txt_fuel_upd5.Text = "";
                    txt_fuel_upd6.Text = "";
                    date_fuel_upd.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region tech_tabs
        private void insertToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
            tabControl8.SelectedIndex = 2; tabControl1.SelectedIndex = 5;
        }

        private void editDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            tabControl8.SelectedIndex = 2; tabControl1.SelectedIndex = 5;
        }

        private void deleteTechnicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            tabControl8.SelectedIndex = 2; tabControl1.SelectedIndex = 5;
        }


        #endregion
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged_1(sender, e);
            oil_rep_CheckedChanged(sender, e);
            combo_oil_rep.SelectedIndex = -1;
            if (checkBox2.Checked)
            { combo_oil_rep.Enabled = true; /*panel40.Visible = true;*/ }
            else { combo_oil_rep.Enabled = false; /*panel40.Visible = false;*/ }
            dataGridView6.DataSource = new DataTable();
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
            if (checkBox1.Checked)
            {
                flowLayoutPanel3.Enabled = true;
                int tt = -99;
                if (checkBox2.Checked == true)
                {
                    tt = Convert.ToInt32(combo_oil_rep.SelectedValue);
                }
                DataTable all2 = oi.Find_oil_show_Catalogue_Equivalent2222(tt);
                flowLayoutPanel3.Controls.Clear();
                DataTable all = all2.DefaultView.ToTable(true, "oil_type");
                for (int i = 0; i < all.Rows.Count; i++)
                {
                    CheckBox ch = new CheckBox();
                    ch.Text = all.Rows[i][0].ToString();
                    ch.Name = "ch" + i.ToString();
                    ch.Size = new Size(125, 17);
                    ch.CheckedChanged += new System.EventHandler(oil_rep_CheckedChanged);
                    if(label27.ForeColor == Color.Green)
                    {
                        ch.ForeColor = Color.Black;
                    }
                    else
                    {
                        ch.ForeColor = Color.White;
                    }
                    
                    flowLayoutPanel3.Controls.Add(ch);
                }
            }
            else
            {
                flowLayoutPanel3.Controls.Clear(); label189.Text = "";
                label76.Text = "";
            }

            dataGridView6.DataSource = new DataTable();
        }
        private void oil_rep_CheckedChanged(object sender,EventArgs e)
        {
            List<string> lis = new List<string>();
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        lis.Add(control.Text);
                    }
                }
            }
            string with = "";
            if (checkBox2.Checked == true && combo_oil_rep.SelectedIndex>-1)
            {
                with = combo_oil_rep.SelectedValue.ToString();
            }
            else
            {
                with ="-99";
            }
            if (lis.Count > 0)
            {
                label189.Text = lis[0];
                label76.Text = oi.cal_cos2(with, lis[0], dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                for(int i=1;i<lis.Count;i++)
                {
                    label189.Text = label189.Text+"\n"+lis[i];
                    label76.Text = label76.Text +"\n"+ oi.cal_cos2(with, lis[i], dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                }
                if (label27.ForeColor == Color.Green)
                {
                    label189.ForeColor = Color.Green;
                    label76.ForeColor = Color.Black;
                }
                else
                {
                    label189.ForeColor = Color.DodgerBlue;
                    label76.ForeColor = Color.White;
                }

            }
            else
            {
                label189.Text = "";
                label76.Text = "";
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                combo_oil_rep_SelectedIndexChanged(sender, e);
            }
            bool id;  //done
            int idd; //done
            bool state; //done
            string[] type_name1; //done
            bool date; //done
            string[] type_name; //done
            if (checkBox2.Checked)
            {
                if (combo_oil_rep.SelectedValue == null || combo_oil_rep.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Choose Equipment");
                    return;
                }
                id = true;
                idd = Convert.ToInt32(combo_oil_rep.SelectedValue);
            }
            else { id = false; idd = 0; }

            List<string> lis = new List<string>();
            if (checkBox1.Checked)
            {
                state = true;
                if (checkBox2.Checked == true)
                {
                    lis.Add(combo_oil_rep.SelectedValue.ToString());
                }
                else
                {
                    lis.Add("-99");
                }
                foreach (Control control in flowLayoutPanel3.Controls)
                {
                    if (control is CheckBox)
                    {
                        if (((CheckBox)control).Checked == true)
                        {
                            lis.Add(control.Text);
                        }
                    }
                }
            }
            else { state = false; type_name1 = new string[0]; }



            if (checkBox3.Checked)
            {
                int t = 0; string gg = "false";
                if (checkBox14.Checked) { t++; gg = "true"; }
                if (checkBox15.Checked) { t++; gg = "true"; }
                if (checkBox16.Checked) { t++; gg = "true"; }
                if (checkBox4.Checked) { t++; t++; gg = "true"; }
                
                int qq = 0;
                if (gg == "false")
                {
                    date = false; type_name = new string[0];
                }
                else
                {
                    type_name = new string[t];
                    if (checkBox15.Checked) { type_name[qq] = "Add"; qq++; }
                    if (checkBox4.Checked) { type_name[qq] = "Changed"; qq++; type_name[qq] = "ReFill"; qq++; }
                    date = true;
                }     
            }
            else { date = false; type_name = new string[0]; }
            DataTable dt = oi.Find_oil_show_search(id, idd, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, state, lis, date, type_name);
            DataTable sss = dt.Clone();
            sss.Columns[1].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                sss.ImportRow(row);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string aa = eq.Searchequ(Convert.ToInt32(sss.Rows[i][1].ToString()));
                sss.Rows[i][1] = aa;
                if(sss.Rows[i][9].ToString() == "Active" || sss.Rows[i][9].ToString()=="Changed" )
                {
                     sss.Rows[i][9] = "ReFill";
                }
            }
            dataGridView6.Columns.Clear();
            dataGridView6.DataSource = sss;
            dataGridView6.Columns[0].Visible = false;
            dataGridView6.Columns[1].HeaderText = "Equipment ID";
            dataGridView6.Columns[2].HeaderText = "Oil Type";
            dataGridView6.Columns[3].HeaderText = "Oil Name";
            dataGridView6.Columns[4].HeaderText = "Oil Refill Capacity";
            dataGridView6.Columns[5].HeaderText = "Oil Cost";
            dataGridView6.Columns[6].HeaderText = "Posting Date";
            dataGridView6.Columns[7].Visible = false;
            dataGridView6.Columns[8].Visible = false;
            dataGridView6.Columns[9].HeaderText = "Oil State";
            dataGridView6.Columns[10].Visible = true;
            dataGridView6.Columns[10].HeaderText = "Counter";
            dataGridView6.Columns[11].Visible = false;
            dataGridView6.Columns[12].Visible = false;
            dataGridView6.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView6.ColumnHeadersHeight = 40;
            dataGridView6.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if(sss.Rows.Count>0)
            {
                panel18.Visible = true; panel18.Enabled = true;
            }
            else
            {
                panel18.Visible = false; panel18.Enabled = false;
            }
            int oil = 0;
            if (sss.Rows.Count > 0)
            {
                for (int r = 0; r < sss.Rows.Count; r++)
                {
                    oil = oil + Convert.ToInt32(sss.Rows[r][5].ToString());
                }
            }
            else
            {
                oil = 0;
            }
            //total = parts + lap + Convert.ToInt32(fuwew) + oii;
            label207.Text = oil + " $";
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            { panel39.Enabled = true; }
            else { panel39.Enabled = false; }
            dataGridView6.DataSource = new DataTable();  
        }
        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete This Oil Data?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = Convert.ToString(dataGridView6.Rows[dataGridView6.SelectedCells[0].RowIndex].Cells["oil_id"].Value);
                MessageBox.Show(oi.deloil(Convert.ToInt32(a)));
                if(checkBox2.Checked==true)
                {
                    combo_oil_rep_SelectedIndexChanged(sender, e);
                }
                if (dataGridView4.Rows.Count > 0)
                {
                    pictureBox12_Click(sender, e);
                }
                if (dataGridView7.Rows.Count > 0)
                {
                    pictureBox7_Click(sender, e);
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    pictureBox6_Click(sender, e);
                }
                if (dataGridView2.Rows.Count > 0)
                {
                    btn_report_lp_Click(sender, e);
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    btn_report_Click(sender, e);
                }
                //dataGridView6.DataSource = oi.Find_oil_show_data(Convert.ToInt32((combo_equ_show.SelectedValue)));
                // combo_equ_show_SelectedIndexChanged(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                ControlID22.TextData22 = Convert.ToInt32(dataGridView6.Rows[dataGridView6.SelectedCells[0].RowIndex].Cells["oil_id"].Value);
                ControlID22.info = "Update Oil";
                using (pop1 uu = new pop1())
                {
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = this.Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();
                    formBackground.Dispose();
                    pictureBox6_Click(sender, e);
                    if(dataGridView1.Rows.Count > 0)
                    {
                        btn_report_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
        private void oilReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 1; tabControl1.SelectedIndex = 3;
        }
        private void fuelReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 2; tabControl1.SelectedIndex = 3;
        }
        private void combo_oil_rep_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged_1(sender, e);
            oil_rep_CheckedChanged(sender, e);
            //label76.Text= oi.cal_cost_per(Convert.ToInt32(combo_oil_rep.SelectedValue));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_oil_ins4.TextChanged -= new System.EventHandler(txt_oil_ins4_TextChanged);
                if (txt_oil_ins3.Text == "")
                { txt_oil_ins3.Text = "0"; }
                if (textBox4.Text == "")
                { textBox4.Text = "0"; }
                txt_oil_ins4.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txt_oil_ins3.Text) * Convert.ToDecimal(textBox4.Text)));
                txt_oil_ins4.TextChanged += new System.EventHandler(txt_oil_ins4_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }
        private void txt_oil_ins3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_oil_ins4.TextChanged -= new System.EventHandler(txt_oil_ins4_TextChanged);
                if (txt_oil_ins3.Text == "")
                { txt_oil_ins3.Text = "0"; }
                if (textBox4.Text == "")
                { textBox4.Text = "0"; }
                txt_oil_ins4.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txt_oil_ins3.Text) * Convert.ToDecimal(textBox4.Text)));
                txt_oil_ins4.TextChanged += new System.EventHandler(txt_oil_ins4_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }
        private void txt_oil_ins4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox4.TextChanged -= new System.EventHandler(textBox4_TextChanged);
                if (txt_oil_ins3.Text == "")
                { txt_oil_ins3.Text = "1"; }
                if (textBox4.Text == "")
                { textBox4.Text = "0"; }
                textBox4.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txt_oil_ins4.Text) / Convert.ToDecimal(txt_oil_ins3.Text)));
                textBox4.TextChanged += new System.EventHandler(textBox4_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }
        private void txt_oil_upd5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_oil_upd6.TextChanged -= new System.EventHandler(txt_oil_upd6_TextChanged);
                if (txt_oil_upd5.Text == "")
                { txt_oil_upd5.Text = "0"; }
                if (textBox3.Text == "")
                { textBox3.Text = "0"; }
                txt_oil_upd6.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txt_oil_upd5.Text) * Convert.ToDecimal(textBox3.Text)));
                txt_oil_upd6.TextChanged += new System.EventHandler(txt_oil_upd6_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_oil_upd6.TextChanged -= new System.EventHandler(txt_oil_upd6_TextChanged);
                if (txt_oil_upd5.Text == "")
                { txt_oil_upd5.Text = "0"; }
                if (textBox3.Text == "")
                { textBox3.Text = "0"; }
                txt_oil_upd6.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txt_oil_upd5.Text) * Convert.ToDecimal(textBox3.Text)));
                txt_oil_upd6.TextChanged += new System.EventHandler(txt_oil_upd6_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }
        private void txt_oil_upd6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.TextChanged -= new System.EventHandler(textBox3_TextChanged);
                if (txt_oil_upd5.Text == "")
                { txt_oil_upd5.Text = "1"; }
                if (textBox3.Text == "")
                { textBox3.Text = "0"; }
                textBox3.Text = Convert.ToString(Convert.ToDecimal(Convert.ToDecimal(txt_oil_upd6.Text) / Convert.ToDecimal(txt_oil_upd5.Text)));
                textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 3; tabControl1.SelectedIndex = 3;
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 4; tabControl1.SelectedIndex = 3;
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                comboBox3.Location = new Point(104, 6);
                comboBox3.Visible = true;
                txt_fuel_ins1.Visible = false;
                DataTable ee= fu.Find_fuel_show_data(Convert.ToInt32((comb_fuel_ins_equ.SelectedValue)));
                if(ee.Rows.Count > 0)
                {
                    comboBox3.SelectedIndexChanged -= new System.EventHandler(comboBox3_SelectedIndexChanged);
                    comboBox3.DataSource = ee;
                    comboBox3.ValueMember = "fuel_id";
                    comboBox3.DisplayMember = "fuel_type";
                    comboBox3.SelectedIndex = -1;
                    comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_SelectedIndexChanged);
                    btn_fuel_ins.Enabled = false;
                    panel49.Enabled = true; 
                    btn_fuel_ins.Enabled = false;
                    panel45.Visible = true;
                    DataTable asdq = wo.bring_labor_names();
                    if (asdq.Rows.Count == 0)
                    {
                        comboBox11.DataSource = null;
                        comboBox11.SelectedIndex = -1;
                        comboBox11.SelectedValue = 0;
                        comboBox11.Text = "No Data";
                    }
                    else
                    {
                        comboBox11.DataSource = asdq;
                        comboBox11.ValueMember = "worker_id";
                        comboBox11.DisplayMember = "worker_name";
                        comboBox11.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("No Catalogue Fuel Data For This Equipment" + "\n" + "Register Catalogue Data First");
                    comboBox3.SelectedIndexChanged -= new System.EventHandler(comboBox3_SelectedIndexChanged);
                    comboBox3.DataSource = null;
                    comboBox3.SelectedIndex = -1;
                    comboBox3.SelectedIndexChanged += new System.EventHandler(comboBox3_SelectedIndexChanged);
                    radioButton11.Checked = true;
                    btn_fuel_ins.Enabled = true;
                    comboBox3.Visible = false;
                    panel45.Visible = false;
                }
                txt_fuel_ins1.Text = "";
                txt_fuel_ins3.Text = "";
                textBox5.Text = "";
                txt_fuel_ins4.Text = "";
                date_fuel_ins.Value = DateTime.Now;
            }
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                btn_fuel_ins.Enabled = true;
                panel49.Enabled = true;
                panel45.Visible = false;
                comboBox3.SelectedIndex = -1;
                comboBox3.Visible = false;
                txt_fuel_ins1.Visible = true;
                txt_fuel_ins1.Text = "";
                txt_fuel_ins3.Text = "";
                textBox5.Text = "";
                txt_fuel_ins4.Text = "";
                date_fuel_ins.Value = DateTime.Now;
            }
        }
        private void txt_fuel_ins3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_fuel_ins3.Text == "")
                { txt_fuel_ins3.Text = "0"; }
                if (textBox5.Text == "")
                { textBox5.Text = "0"; }
                decimal gg = Convert.ToDecimal(Convert.ToDecimal(txt_fuel_ins3.Text) * Convert.ToDecimal(textBox5.Text));
                txt_fuel_ins4.Text = gg.ToString("0.##");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }
        private void txt_fuel_ins4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_fuel_ins3.Text == "" || txt_fuel_ins3.Text == "0")
                { txt_fuel_ins3.Text = "1"; }
                if (txt_fuel_ins4.Text == "")
                { txt_fuel_ins4.Text = "1"; }
                decimal gg = Convert.ToDecimal(Convert.ToDecimal(txt_fuel_ins4.Text) / Convert.ToDecimal(txt_fuel_ins3.Text));
                textBox5.Text = gg.ToString("0.##");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }

        private void txt_fuel_upd5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_fuel_upd5.Text == "")
                { txt_fuel_upd5.Text = "0"; }
                if (textBox6.Text == "")
                { textBox6.Text = "0"; }
                decimal gg = Convert.ToDecimal(txt_fuel_upd5.Text) * Convert.ToDecimal(textBox6.Text);
                txt_fuel_upd6.Text = gg.ToString("0.##");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }
        private void txt_fuel_upd6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_fuel_upd5.Text == "" || txt_fuel_upd5.Text == "0")
                { txt_fuel_upd5.Text = "1"; }
                if (txt_fuel_upd6.Text == "")
                { txt_fuel_upd6.Text = "1"; }
                decimal gg = Convert.ToDecimal(txt_fuel_upd6.Text) / Convert.ToDecimal(txt_fuel_upd5.Text);
                textBox6.Text = gg.ToString("0.##");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " \n Please Enter valid number"); return;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = -1;
            if (checkBox8.Checked)
            { comboBox4.Enabled = true; panel24.Visible = true; }
            else { comboBox4.Enabled = false; panel24.Visible = false; }
            dataGridView7.DataSource = new DataTable();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.SelectedIndex >-1 && comboBox4.SelectedValue.ToString() != "{System.Data.DataRowView}")
            {
                label198.Text = fu.cal_cost_per(Convert.ToInt32(comboBox4.SelectedValue));

            }
            else
            {
                label198.Text = "";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bool id;  //done
            int idd; //done

            if (checkBox8.Checked)
            {
                if (comboBox4.SelectedValue == null || comboBox4.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Choose Equipment");
                    return;
                }
                id = true;
                idd = Convert.ToInt32(comboBox4.SelectedValue);
            }
            else { id = false; idd = 0; }

            DataTable dt = fu.Find_fuel_show_search(id, idd, dateTimePicker3.Value.Date, dateTimePicker4.Value.Date);
            DataTable sss = dt.Clone();
            sss.Columns[1].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                sss.ImportRow(row);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string aa = eq.Searchequ(Convert.ToInt32(sss.Rows[i][1].ToString()));
                sss.Rows[i][1] = aa;
                if(sss.Rows[i][10].ToString() == "0")
                {
                    sss.Rows[i][10]= DBNull.Value;
                }
            }
            dataGridView7.Columns.Clear();
            dataGridView7.DataSource = sss;
            dataGridView7.Columns[0].Visible = false;
            dataGridView7.Columns[1].HeaderText = "Equipment ID";
            dataGridView7.Columns[2].HeaderText = "Fuel Type";
            dataGridView7.Columns[3].Visible = false;
            dataGridView7.Columns[4].HeaderText = "Fuel Refill Capacity";
            dataGridView7.Columns[5].HeaderText = "Fuel Cost";
            dataGridView7.Columns[6].HeaderText = "Posting Date";
            dataGridView7.Columns[7].Visible = false;
            dataGridView7.Columns[8].HeaderText = "Counter";
            dataGridView7.Columns[9].Visible = false;
            dataGridView7.Columns[10].Visible = false;
            dataGridView7.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView7.ColumnHeadersHeight = 40;
            dataGridView7.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (sss.Rows.Count > 0)
            {
                panel22.Visible = true; panel22.Enabled = true;
            }
            else
            {
                panel22.Visible = false; panel22.Enabled = false;
            }
            int fuel = 0;
            if (sss.Rows.Count > 0)
            {
                for (int r = 0; r < sss.Rows.Count; r++)
                {
                    fuel = fuel + Convert.ToInt32(sss.Rows[r][5].ToString());
                }
            }
            else
            {
                fuel = 0;
            }
            //total = parts + lap + Convert.ToInt32(fuwew) + oii;
            label214.Text = fuel + " $";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete This Fuel Data?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = Convert.ToString(dataGridView7.Rows[dataGridView7.SelectedCells[0].RowIndex].Cells["fuel_id"].Value);
                MessageBox.Show(fu.delfuel(Convert.ToInt32(a)));
                //dataGridView6.DataSource = oi.Find_oil_show_data(Convert.ToInt32((combo_equ_show.SelectedValue)));
                // combo_equ_show_SelectedIndexChanged(sender, e);
                if (checkBox8.Checked == true)
                {
                    comboBox4_SelectedIndexChanged(sender, e);
                }
                if (dataGridView4.Rows.Count > 0)
                {
                    pictureBox12_Click(sender, e);
                }
                if (dataGridView7.Rows.Count > 0)
                {
                    pictureBox7_Click(sender, e);
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    pictureBox6_Click(sender, e);
                }
                if (dataGridView2.Rows.Count > 0)
                {
                    btn_report_lp_Click(sender, e);
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    btn_report_Click(sender, e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                ControlID22.TextData22 = Convert.ToInt32(dataGridView7.Rows[dataGridView7.SelectedCells[0].RowIndex].Cells["fuel_id"].Value);
                ControlID22.info = "Update Fuel";
                using (pop1 uu = new pop1())
                {
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = this.Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();
                    formBackground.Dispose();
                    pictureBox7_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }


        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void insertToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            comb_fuel_ins_equ.SelectedIndex = -1;
            radioButton2.Checked = true;
            radioButton12.CheckedChanged -= new System.EventHandler(radioButton12_CheckedChanged);
            radioButton12.Checked = true;
            radioButton12.CheckedChanged += new System.EventHandler(radioButton12_CheckedChanged);
            panel49.Enabled = false;
            panel45.Visible = true;
            tabControl8.SelectedIndex = 1;
            tabControl1.SelectedIndex = 5;
        }

        private void newFuelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comb_fuel_ins_equ.SelectedIndex = -1;
            radioButton2.Checked = true;
            radioButton11.CheckedChanged -= new System.EventHandler(radioButton11_CheckedChanged);
            radioButton11.Checked = true;
            radioButton11.CheckedChanged += new System.EventHandler(radioButton11_CheckedChanged);
            panel49.Enabled = false;
            panel45.Visible = false;
            tabControl8.SelectedIndex = 1;
            tabControl1.SelectedIndex = 5;
        }

        private void rdio_oil_cata_CheckedChanged(object sender, EventArgs e)
        {
            if (combo_oil_ins.SelectedIndex > -1)
            {
                if (rdio_oil_cata.Checked == true)
                {
                    txt_oi_state.Text = "Catalogue";
                    comb_oil_types.Visible = false;
                    textBox7.Location = new Point(104, 12);
                    textBox7.Visible = true;
                    pnl_oil_ins.Enabled = true;
                    btn_oil_ins.Enabled = true;
                    
                    panel43.Location = new Point(0, 189);
                    panel38.Location = new Point(0, 189);
                    panel43.Visible = true;
                    panel38.Visible = false;
                    txt_oil_ins2.Text = "";
                    txt_oil_ins3.Text = "";
                    textBox4.Text = "";
                    date_oil_ins1.Value = DateTime.Now;
                    txt_oil_rep_ins0.Text = "";
                    textBox8.Text = "";
                    textBox10.Text = "";
                    textBox7.Text = "";
                    txt_oil_ins4.Text = "";
                    txt_oil_rep_ins1.Text = "";
                    txt_oil_rep_ins2.Text = "";
                    txt_oil_rep_ins3.Text = "";
                }
                else
                {
                    comb_oil_types.Visible = true; btn_oil_ins.Enabled = false;
                    textBox7.Visible = false; panel43.Visible = false;
                }
            }
        }

        private void newOilTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo_oil_ins.SelectedIndex = -1;
            radioButton3.Checked = true;
            lbl_oil_what.Text = "Add Amount";
            rdio_oil_cata.Checked = true;
            //panel43.Visible = false;
            pnl_oil_ins.Enabled = false;
            tabControl8.SelectedIndex = 0; tabControl1.SelectedIndex = 5;
        }

        private void rdio_filt_new_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_filt_new.Checked == true)
            {
                txtfilter1.Visible = true;
                panel23.Visible = true;
                combo_change_filter.Visible = false;
                btn_ins_filt.Enabled = true;
                panel50.Visible = false;
            }
            else
            {
                combo_change_filter.Location = new Point(104, 42);
                panel23.Visible = false;
                btn_ins_filt.Enabled = false;
                combo_change_filter.Visible = true;
                txtfilter1.Visible = false;
                panel50.Visible = true;
                panel50.Location = new Point(0, 186);
                DataTable asdq = wo.bring_labor_names();
                if (asdq.Rows.Count == 0)
                {
                    comboBox12.DataSource = null;
                    comboBox12.SelectedIndex = -1;
                    comboBox12.SelectedValue = 0;
                    comboBox12.Text = "No Data";
                }
                else
                {
                    comboBox12.DataSource = asdq;
                    comboBox12.ValueMember = "worker_id";
                    comboBox12.DisplayMember = "worker_name";
                    comboBox12.SelectedIndex = -1;
                }
            }
            txtfilter1.Text = "";
            txtfilter2.Text = "";
            txtfilter3.Text = "";
            txtfilter4.Text = "";
            txt_fil_rep1.Text = ""; 
            txt_fil_rep0.Text = "";
            txt_fil_rep2.Text = "";
            txt_fil_rep3.Text = ""; 
            combo_change_filter.SelectedIndex = -1;
            datefilter1.Value = DateTime.Now;
        }

        private void rdio_filt_change_CheckedChanged(object sender, EventArgs e)
        {
            if (combo_filter_equ_ins.SelectedIndex == -1)
            {
                if (rdio_filt_change.Checked == true)
                {
                    panel50.Location = new Point(0, 188);
                    panel23.Visible = false;
                    panel50.Visible = true;
                }
                else
                {
                    panel50.Visible = false;
                    panel50.Location = new Point(0, 188);
                    panel23.Visible = true;
                }
                return;
            }
            if (rdio_filt_change.Checked == true)
            {
                combo_change_filter.SelectedIndex = -1;
                txtfilter1.Text = "";
                txtfilter2.Text = "";
                txtfilter3.Text = "";
                txtfilter4.Text = "";
                txt_fil_rep1.Text = "";
                txt_fil_rep0.Text = "";
                txt_fil_rep2.Text = "";
                txt_fil_rep3.Text = "";
                DataTable asdq = wo.bring_labor_names();
                if (asdq.Rows.Count == 0)
                {
                    comboBox12.DataSource = null;
                    comboBox12.SelectedIndex = -1;
                    comboBox12.SelectedValue = 0;
                    comboBox12.Text = "No Data";
                }
                else
                {
                    comboBox12.DataSource = asdq;
                    comboBox12.ValueMember = "worker_id";
                    comboBox12.DisplayMember = "worker_name";
                    comboBox12.SelectedIndex = -1;
                }
                btn_ins_filt.Enabled = false;
                datefilter1.Value = DateTime.Now;
                if (combo_change_filter.Items.Count == 0)
                {
                    MessageBox.Show("No Catalogue Filter Data For This Equipment" + "\n" + "Register Catalogue Data First");
                    combo_change_filter.SelectedIndexChanged -= new System.EventHandler(combo_change_filter_SelectedIndexChanged);
                    // combo_change_filter.Enabled = false;
                    combo_change_filter.DataSource = null;
                    combo_change_filter.SelectedIndex = -1;
                    combo_change_filter.SelectedIndexChanged += new System.EventHandler(combo_change_filter_SelectedIndexChanged);
                    rdio_filt_new.Checked = true;
                    //rdio_filt_new_CheckedChanged(sender, e);
                    combo_change_filter.Visible = false;
                }
                else
                {
                    panel23.Visible = false;
                    panel50.Visible = true;
                    panel50.Location = new Point(0, 188);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex!=-1)
            {
                System.Data.DataTable tbl = (System.Data.DataTable)comboBox3.DataSource;
                btn_fuel_ins.Enabled = true;
                comboBox3.SelectedText = tbl.Rows[comboBox3.SelectedIndex][2].ToString();
                txt_fuel_ins3.Text = tbl.Rows[comboBox3.SelectedIndex][4].ToString();
                txt_fuel_ins4.Text = tbl.Rows[comboBox3.SelectedIndex][5].ToString();
                //date_fuel_ins.Value = Convert.ToDateTime(tbl.Rows[comboBox3.SelectedIndex][6].ToString());
            }
           
        }

        private void date_add_hours_ValueChanged(object sender, EventArgs e)
        {
         //   int hours = equ_work.get_behind_hours(Convert.ToInt32(comb_add_hours.SelectedValue), date_add_hours.Value.Date,Convert.ToInt32(lbl_hours2.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(dataGridView3.Rows[dataGridView3.SelectedCells[0].RowIndex].Cells["report_id"].Value);
            MessageBox.Show(worksal.del_work_reprot(Convert.ToInt32(a)));
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            comboBox6.SelectedIndex = -1;
            if (checkBox5.Checked == true)
            {
                comboBox6.Enabled = true;
                checkBox7.Checked = false;
            }
            else
            {
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                checkBox9.Checked = false;
            }
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == -1)
            {
                checkBox9.Enabled = false;
                comboBox7.DataSource = null;
                comboBox7.SelectedIndex = -1;
                return;
            }
            try
            {
                DataTable x = fl.Find_filt_show_data_equ(Convert.ToInt32(comboBox6.SelectedValue));
                if (x.Rows.Count == 0)
                {
                    checkBox9.Checked = false; checkBox9.Enabled = false;
                    comboBox7.DataSource = null;
                    comboBox7.SelectedIndex = -1;
                    comboBox7.Enabled = false;
                    MessageBox.Show("Note: That There is No Catalogue Fiters Data in this Equipment Please Add Data To Enable Search by type"+"\n"+"Note: Search Is Still Enable");
                }
                else
                {
                    checkBox9.Enabled = true;
                    comboBox7.DataSource = x;
                    comboBox7.ValueMember = "filt_id";
                    comboBox7.DisplayMember = "filt_type";
                    comboBox7.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox9.Checked==true)
            {
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
                comboBox7.SelectedIndex = -1;
            }
        }
        private void filterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 3; tabControl1.SelectedIndex = 3;
        }
        private void costReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl6.SelectedIndex = 6; tabControl1.SelectedIndex = 3;
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int eee1 = -1;
            string eee2 = "";
            string eee3 = "";
            if (checkBox5.Checked == true)
            {
                if(comboBox6.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Choose Equipment First"); return;
                }
                eee1 = Convert.ToInt32(comboBox6.SelectedValue);
            }
            if (checkBox9.Checked == true)
            {
                if (comboBox7.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Choose Oil Type First"); return;
                }
                eee2 = comboBox7.Text;
            }
            if (checkBox7.Checked == true)
            {
                if (comboBox8.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Choose Oil Type First"); return;
                }
                eee3 = comboBox8.Text;
            }
            DataTable dt = fl.filt_repotr(dateTimePicker6.Value.Date, dateTimePicker7.Value.Date, eee1, eee2, eee3);




            dataGridView4.Columns.Clear();
            dataGridView4.DataSource = dt;
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].HeaderText = "Equipment ID";
            dataGridView4.Columns[2].HeaderText = "Filter type";
            dataGridView4.Columns[3].HeaderText = "Filter Name";
            dataGridView4.Columns[4].HeaderText = "Quantity";
            dataGridView4.Columns[5].HeaderText = "Cost";
            dataGridView4.Columns[6].HeaderText = "Posting Date";
            dataGridView4.Columns[7].Visible = false;
            dataGridView4.Columns[8].Visible = false;
            dataGridView4.Columns[9].HeaderText = "Counter";
            dataGridView4.Columns[10].Visible = false;
            dataGridView4.Columns[11].HeaderText = "Maintenance Type";
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold);
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView4.ColumnHeadersHeight = 40;
            dataGridView4.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            if(dt.Rows.Count > 0)
            {
                panel31.Visible = true;
                panel31.Enabled = true;
            }
            else
            {
                panel31.Visible = false;
                panel31.Enabled = false;
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                comboBox8.Enabled = true;
                checkBox5.Checked = false;
                comboBox8.DataSource = fl.get_all_cata();
                comboBox8.ValueMember = "filt_type";
                comboBox8.DisplayMember = "filt_type";
                comboBox8.SelectedIndex = -1;
            }
            else
            {
                comboBox8.Enabled = false;
                comboBox8.SelectedIndex = -1;
            }
        }
        private void chc_3_fuel_CheckedChanged(object sender, EventArgs e)
        {
            List<string> type = new List<string>();
            if (chc_3_fuel.Checked == true)
            {
                if (chc_2_main.Checked == true)
                {
                    if (radioButton14.Checked == true)
                    {
                        type.Add("All");
                    }
                    if (radioButton15.Checked == true)
                    {
                        type.Add("None");
                    }
                }
                int x = -1;
                if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
                {
                    x = Convert.ToInt32(comboBox9.SelectedValue);
                }
                // Done
                lbl_3_fuel.Text = fu.rep_cost(x, type, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date);
            }
            else
            {
                lbl_3_fuel.Text = "";
            }
        }
        private void chc_2_main_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_1_lub.Checked == true)
            {
                lub_CheckedChanged(sender, e);
            }
            if (chc_3_fuel.Checked == true)
            {
                chc_3_fuel_CheckedChanged(sender, e);
            }
            if (chc_4_filters.Checked == true)
            {
                chc_4_filters_CheckedChanged(sender, e);
            }
            if (chc_5_parts.Checked == true)
            {
                chc_5_parts_CheckedChanged(sender, e);
            }
            if (chc_6_tech.Checked == true)
            {
                chc_6_tech_CheckedChanged(sender, e);
            }
            if (chc_2_main.Checked==true)
            {
                panel48.Enabled = true;
            }
            //{
            //    lbl_1_lubs.Text = "";
            //    lbl_3_fuel.Text = "";
            //    lbl_4_filter.Text = "";
            //    lbl_5_parts.Text = "";
            //    lbl_6_tech.Text = "";
            //    flowLayoutPanel1.Controls.Clear();
            //    chc_1_lub.Checked = false;
            //    chc_3_fuel.Checked = false;
            //    chc_4_filters.Checked = false;
            //    chc_5_parts.Checked = false;
            //    chc_6_tech.Checked = false;
            //    panel48.Enabled = true;
            //}
            else
            {
                panel48.Enabled = false;
            }
            //{
            //    lbl_1_lubs.Text = "";
            //    lbl_3_fuel.Text = "";
            //    lbl_4_filter.Text = "";
            //    lbl_5_parts.Text = "";
            //    lbl_6_tech.Text = "";
            //    flowLayoutPanel1.Controls.Clear();
            //    chc_1_lub.Checked = false;
            //    chc_3_fuel.Checked = false;
            //    chc_4_filters.Checked = false;
            //    chc_5_parts.Checked = false;
            //    chc_6_tech.Checked = false;
            //    panel48.Enabled = false;
            //}
        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_1_lub.Checked == true)
            {
                lub_CheckedChanged(sender, e);
            }
            if (chc_3_fuel.Checked == true)
            {
                chc_3_fuel_CheckedChanged(sender, e);
            }
            if (chc_4_filters.Checked == true)
            {
                chc_4_filters_CheckedChanged(sender, e);
            }
            if (chc_5_parts.Checked == true)
            {
                chc_5_parts_CheckedChanged(sender, e);
            }
            if (chc_6_tech.Checked == true)
            {
                chc_6_tech_CheckedChanged(sender, e);
            }
            //if (radioButton15.Checked == true && radioButton14.Checked == false)
            //{  
            //    chc_5_parts.Enabled = false;
            //}
            //else
            //{
            //    chc_5_parts.Enabled = true;
            //}
            //lbl_1_lubs.Text = "";
            //lbl_3_fuel.Text = "";
            //lbl_4_filter.Text = "";
            //lbl_5_parts.Text = "";
            //lbl_6_tech.Text = "";
            //flowLayoutPanel1.Controls.Clear();
            //chc_1_lub.Checked = false;
            //chc_3_fuel.Checked = false;
            //chc_4_filters.Checked = false;
            //chc_5_parts.Checked = false;
            //chc_6_tech.Checked = false;
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_1_lub.Checked == true)
            {
                lub_CheckedChanged(sender, e);
            }
            if (chc_3_fuel.Checked == true)
            {
                chc_3_fuel_CheckedChanged(sender, e);
            }
            if (chc_4_filters.Checked == true)
            {
                chc_4_filters_CheckedChanged(sender, e);
            }
            if (chc_5_parts.Checked == true)
            {
                chc_5_parts_CheckedChanged(sender, e);
            }
            if (chc_6_tech.Checked == true)
            {
                chc_6_tech_CheckedChanged(sender, e);
            }
            //if (radioButton15.Checked == true && radioButton14.Checked == false)
            //{
            //    chc_5_parts.Enabled = false;
            //}
            //else
            //{
            //    chc_5_parts.Enabled = true;
            //}
            //lbl_1_lubs.Text = "";
            //lbl_3_fuel.Text = "";
            //lbl_4_filter.Text = "";
            //lbl_5_parts.Text = "";
            //lbl_6_tech.Text = "";
            //flowLayoutPanel1.Controls.Clear();
            //chc_1_lub.Checked = false;
            //chc_3_fuel.Checked = false;
            //chc_4_filters.Checked = false;
            //chc_5_parts.Checked = false;
            //chc_6_tech.Checked = false;
        }
        private void chc_4_filters_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chc_4_filters.Checked == true)
            {
                List<string> type = new List<string>();
                if (chc_2_main.Checked == true)
                {
                    if (radioButton14.Checked == true)
                    {
                        type.Add("All");
                    }
                    if (radioButton15.Checked == true)
                    {
                        type.Add("None");
                    }
                }
                int x = -1;
                if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
                {
                    x = Convert.ToInt32(comboBox9.SelectedValue);
                }//Done
                lbl_4_filter.Text = fl.rep_cost(x, type, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date);
            }
            else
            {
                lbl_4_filter.Text = "";
            }
        }
        private void chc_6_tech_CheckedChanged(object sender, EventArgs e)
        {
            if(chc_6_tech.Checked == true)
            {
                List<string> type = new List<string>();
                if (chc_2_main.Checked == true)
                {
                    if (radioButton14.Checked == true)
                    {
                        type.Add("All");
                    }
                    if (radioButton15.Checked == true)
                    {
                        type.Add("None");
                    }
                }
                int x = -1;
                if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
                {
                    x = Convert.ToInt32(comboBox9.SelectedValue);
                }
                //Done
                lbl_6_tech.Text = worksal.rep_cost(x, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date, type);
            }
            else
            {
                lbl_6_tech.Text ="";
            }
        }
        private void chc_5_parts_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_5_parts.Checked == true)
            {
                int x = -1;
                if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
                {
                    x = Convert.ToInt32(comboBox9.SelectedValue);
                }//Done
                lbl_5_parts.Text = ma.rep_cost(x, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date);
            }
            else
            {
                lbl_5_parts.Text = "";
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ma.add_new_eq_hu(Convert.ToInt32(comboBox5.SelectedValue)));
            dataGridView1.DataSource = ma.get_all();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ma.gig(Convert.ToInt32(comboBox5.SelectedValue)));
        }
        private void chc_1_lub_CheckedChanged(object sender, EventArgs e)
        {
            lbl_1_lubs.Text = "0";
            if (chc_1_lub.Checked == true)
            {
                int x = -1;
                if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
                {
                    x = Convert.ToInt32(comboBox9.SelectedValue);
                }//Done
                DataTable all2 = oi.Find_oil_show_Catalogue_Equivalent(x);
                DataTable all = all2.DefaultView.ToTable(true, "oil_type");
                flowLayoutPanel1.Controls.Clear();
                if(all.Rows.Count > 0)
                {
                    dataGridView3.DataSource = all;
                    
                    for (int i = 0; i < all.Rows.Count; i++)
                    {
                        CheckBox ch = new CheckBox();
                        ch.Text = all.Rows[i][0].ToString();
                        ch.Name = "ch" + i.ToString();
                        ch.Size = new Size(125, 17);
                        ch.CheckedChanged += new System.EventHandler(lub_CheckedChanged);
                        if(label229.ForeColor == Color.Green)
                        {
                            ch.ForeColor = Color.Black;
                        }
                        else
                        {
                            ch.ForeColor = Color.White;
                        }
                        flowLayoutPanel1.Controls.Add(ch);
                    }
                }
                else
                {
                    Label lb = new Label();
                    lb.Text = "No Oils Inserted";
                    flowLayoutPanel1.Controls.Add(lb);
                }
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }
        private void lub_CheckedChanged(object sender, EventArgs e)
        {
            List<string> lis = new List<string>();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        lis.Add(control.Text);
                    }
                }
            }
            bool with=false;
            bool without=false;
            if(radioButton14.Checked==true)
            {
                with = true;
            }
            if (radioButton15.Checked == true)
            {
                without = true;
            }
            if (lis.Count>0)
            {
                int x = -1;
                if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
                {
                    x = Convert.ToInt32(comboBox9.SelectedValue);
                }//Done
                lbl_1_lubs.Text = oi.cal_cos(x, lis, with, without, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date);
            }
            else
            {
                lbl_1_lubs.Text = "0";
                //lbl_1_lubs.Visible = false;
            }
        }
        #region KeyDown
        private void txt_input_hours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnhours.PerformClick();
            }
        }
        private void com_report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_report_Click(sender, e);
            }
        }
        private void chk_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_report_lp_Click(sender, e);
            }
        }
        private void combo_use_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_use_Click(sender, e);
            }
        }
        private void checkBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox6_Click(sender, e);
            }
        }
        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox7_Click(sender, e);
            }
        }
        private void checkBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox12_Click(sender, e);
            }
        }

        private void comb_oil_types_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btn_oil_ins_Click(sender, e);
            }
        }
        private void comb_oil_del_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_oil_upd_Click(sender, e);
            }
        }
        private void txt_fuel_ins1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_fuel_ins_Click(sender, e);
            }
        }
        private void comb_fuel_del_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_fuel_upd_Click(sender, e);
            }
        }
        private void txt_wrker_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_labor_ins_Click(sender, e);
            }
        }
        private void txt_lp_up_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_labor_upd_Click(sender, e);
            }
        }
        private void txtfilter1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btn_ins_filt_Click(sender, e);///////////////////////////
            }
        }
        private void comb_flt_del_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_flt_upd_Click(sender, e);
            }
        }

        #endregion

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox10.Checked==true)
            {
                panel19.Visible = true;
            }
            else
            {
                panel19.Visible = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //string a = Convert.ToString(dataGridView3.Rows[dataGridView3.SelectedCells[0].RowIndex].Cells["equ_id"].Value);
            if(equ_work.dell(Convert.ToInt32(textBox13.Text)))
            {
                MessageBox.Show("Done");
                textBox13.Text = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            prpi po = new prpi();
            System.Data.DataTable dd = (System.Data.DataTable)dataGridView1.DataSource;
            DataTable q = new DataTable();
            q.Columns.Add("Equipment");// 1
            q.Columns.Add("Counter"); //3
            q.Columns.Add("Parts"); //4
            q.Columns.Add("State"); //5
            q.Columns.Add("Date"); //6
            q.Columns.Add("Details"); //7
            q.Columns.Add("Type"); //9
            q.Columns.Add("Duration"); //11 
            q.Columns.Add("Parts Cost"); //12
            q.Columns.Add("labor Cost");//13
            q.Columns.Add("Oil Cost");//14
            q.Columns.Add("Fuel Cost");//15
            q.Columns.Add("Filter Cost");//16
            q.Columns.Add("Total Cost");//17
            q.Columns.Add("Tolerance"); //18
            DataRow dr = null;
            for (int i = 0;i< dd.Rows.Count;i++)
            {
                dr = q.NewRow();
                dr["Equipment"] = dd.Rows[i][1].ToString();
                dr["Counter"] = dd.Rows[i][3].ToString();
                dr["Parts"] = dd.Rows[i][4].ToString();
                dr["State"] = dd.Rows[i][5].ToString();
                DateTime sd = Convert.ToDateTime(dd.Rows[i][6].ToString());
                dr["Date"] = sd.ToShortDateString();
                dr["Details"] = dd.Rows[i][7].ToString();
                dr["Type"] = dd.Rows[i][9].ToString();
                dr["Duration"] = dd.Rows[i][11].ToString();
                dr["Parts Cost"] = dd.Rows[i][12].ToString();
                dr["labor Cost"] = dd.Rows[i][14].ToString();
                dr["Oil Cost"] = dd.Rows[i][15].ToString();
                dr["Fuel Cost"] = dd.Rows[i][16].ToString();
                dr["Filter Cost"] = dd.Rows[i][17].ToString();
                dr["Total Cost"] = dd.Rows[i][18].ToString();
                dr["Tolerance"] = dd.Rows[i][19].ToString();
                q.Rows.Add(dr);
            }

            po.prrrint(q, "Maintenance Report");
        }
        private void button28_Click(object sender, EventArgs e)
        {
            prpi po = new prpi();
            System.Data.DataTable dd = (System.Data.DataTable)dataGridView2.DataSource;
            DataTable q = new DataTable();
            q.Columns.Add("Technician Name");// 3
            q.Columns.Add("Equipment"); //4
            q.Columns.Add("Duration"); //5
            q.Columns.Add("Date"); //6
            q.Columns.Add("Salary"); //6
            q.Columns.Add("Technician Cost"); //7
            q.Columns.Add("Job Type"); //9
            DataRow dr = null;
            for (int i = 0; i < dd.Rows.Count; i++)
            {
                dr = q.NewRow();
                dr["Technician Name"] = dd.Rows[i][3].ToString();
                dr["Equipment"] = dd.Rows[i][4].ToString();
                dr["Duration"] = dd.Rows[i][5].ToString();
                dr["Date"] = Convert.ToDateTime(dd.Rows[i][6].ToString()).Date.ToString("dd/MM/yyyy");
                dr["Salary"] = dd.Rows[i][7].ToString();
                dr["Technician Cost"] = dd.Rows[i][9].ToString();
                dr["Job Type"] = dd.Rows[i][10].ToString();
                q.Rows.Add(dr);
            }
            po.prrrint(q, "Technician Report");
        }   //tech

        private void button29_Click(object sender, EventArgs e)
        {
            prpi po = new prpi();
            System.Data.DataTable dd = (System.Data.DataTable)dataGridView5.DataSource;
            po.prrrint(dd, "Availability Report");
        }   //ava

        private void button30_Click(object sender, EventArgs e)
        {
            prpi po = new prpi();
            System.Data.DataTable dd = (System.Data.DataTable)dataGridView6.DataSource;
            DataTable q = new DataTable();
            q.Columns.Add("Equipment");// 1
            q.Columns.Add("Oil Type"); //2
            q.Columns.Add("Oil Name"); //3
            q.Columns.Add("Quantity"); //4
            q.Columns.Add("Cost"); //5
            q.Columns.Add("Date"); //6
            q.Columns.Add("Addtion Type"); //9
            q.Columns.Add("Counter"); //10
            q.Columns.Add("Maintenance Type"); //13

            DataRow dr = null;
            for (int i = 0; i < dd.Rows.Count; i++)
            {
                dr = q.NewRow();
                dr["Equipment"] = dd.Rows[i][1].ToString();
                dr["Oil Type"] = dd.Rows[i][2].ToString();
                dr["Oil Name"] = dd.Rows[i][3].ToString();
                dr["Quantity"] = dd.Rows[i][4].ToString();
                dr["Cost"] = dd.Rows[i][5].ToString();
                DateTime sd = Convert.ToDateTime(dd.Rows[i][6].ToString());
                dr["Date"] = sd.Date.ToString("dd/MM/yyyy");
                dr["Addtion Type"] = dd.Rows[i][9].ToString();
                dr["Counter"] = dd.Rows[i][10].ToString();
                dr["Maintenance Type"] = dd.Rows[i][13].ToString();
                //string all2 = dd.Rows[i][10].ToString();
                //string[] num2 = Regex.Split(all2, "<#>");
                //dr["Maintenance Type"] = num2[0];
                q.Rows.Add(dr);
            }
            po.prrrint(q, "Oil Report");
        }   //oil

        private void button31_Click(object sender, EventArgs e)
        {
            prpi po = new prpi();
            System.Data.DataTable dd = (System.Data.DataTable)dataGridView7.DataSource;
            DataTable q = new DataTable();
            q.Columns.Add("Equipment");// 1
            q.Columns.Add("Fuel Type"); //2
            q.Columns.Add("Quantity"); //4
            q.Columns.Add("Cost"); //5
            q.Columns.Add("Date"); //6
            q.Columns.Add("Counter"); //8
            q.Columns.Add("Maintenance Type"); //10

            DataRow dr = null;
            for (int i = 0; i < dd.Rows.Count; i++)
            {
                dr = q.NewRow();
                dr["Equipment"] = dd.Rows[i][1].ToString();
                dr["Fuel Type"] = dd.Rows[i][2].ToString();
                dr["Quantity"] = dd.Rows[i][4].ToString();
                dr["Cost"] = dd.Rows[i][5].ToString();
                DateTime sd = Convert.ToDateTime(dd.Rows[i][6].ToString());
                dr["Date"] = sd.Date.ToString("dd/MM/yyyy");
                dr["Counter"] = dd.Rows[i][8].ToString();
                string x = "";
                if(dd.Rows[i][10].ToString()!="0")
                {
                    x = dd.Rows[i][10].ToString();
                }
                dr["Maintenance Type"] = x;
                //string all2 = dd.Rows[i][10].ToString();
                //string[] num2 = Regex.Split(all2, "<#>");
                //dr["Maintenance Type"] = num2[0];
                q.Rows.Add(dr);
            }
            po.prrrint(q, "Fuel Report");
        }   //fuel

        private void button32_Click(object sender, EventArgs e)
        {
            prpi po = new prpi();
            System.Data.DataTable dd = (System.Data.DataTable)dataGridView4.DataSource;
            DataTable q = new DataTable();
            q.Columns.Add("Equipment");// 1
            q.Columns.Add("Filter Type"); //2
            q.Columns.Add("Filter Name"); //3
            q.Columns.Add("Quantity"); //4
            q.Columns.Add("Cost"); //5
            q.Columns.Add("Date"); //6
            q.Columns.Add("Counter"); //9
            q.Columns.Add("Maintenance Type"); //11

            DataRow dr = null;
            for (int i = 0; i < dd.Rows.Count; i++)
            {
                dr = q.NewRow();
                dr["Equipment"] = dd.Rows[i][1].ToString();
                dr["Filter Type"] = dd.Rows[i][2].ToString();
                dr["Filter Name"] = dd.Rows[i][3].ToString();
                dr["Quantity"] = dd.Rows[i][4].ToString();
                dr["Cost"] = dd.Rows[i][5].ToString();
                DateTime sd = Convert.ToDateTime(dd.Rows[i][6].ToString());
                dr["Date"] = sd.Date.ToString("dd/MM/yyyy");
                dr["Counter"] = dd.Rows[i][9].ToString();
                dr["Maintenance Type"] = dd.Rows[i][11].ToString();
                //string all2 = dd.Rows[i][10].ToString();
                //string[] num2 = Regex.Split(all2, "<#>");
                //dr["Maintenance Type"] = num2[0];
                q.Rows.Add(dr);
            }
            po.prrrint(q, "Filter Report");
        }   //filter

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox11.Checked == true)
            {
                comboBox9.Enabled = true;
                comboBox9.SelectedIndex = -1;
            }
            else
            {
                comboBox9.Enabled = false; 
                comboBox9.SelectedIndex = -1;
            }
        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {
            int x = -1;
            if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
            {
                x = Convert.ToInt32(comboBox9.SelectedValue);
            }
            label240.Text = oi.calcl(-1, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date);
            //Done
            if (comboBox9.SelectedIndex >= 0)
            {
                lbl_1_lubs.Text = "";
                lbl_3_fuel.Text = "";
                lbl_4_filter.Text = "";
                lbl_5_parts.Text = "";
                lbl_6_tech.Text = "";
                flowLayoutPanel1.Controls.Clear();
                //panel47.Enabled = true;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                chc_1_lub.Checked = false;
                chc_2_main.Checked = false;
                chc_3_fuel.Checked = false;
                chc_4_filters.Checked = false;
                chc_5_parts.Checked = false;
                chc_6_tech.Checked = false;
            }
            else
            {
                // panel47.Enabled = false;
            }

            if (chc_1_lub.Checked == true)
            {
                lub_CheckedChanged(sender, e);
            }
            if (chc_3_fuel.Checked == true)
            {
                chc_3_fuel_CheckedChanged(sender, e);
            }
            if (chc_4_filters.Checked == true)
            {
                chc_4_filters_CheckedChanged(sender, e);
            }
            if (chc_5_parts.Checked == true)
            {
                chc_5_parts_CheckedChanged(sender, e);
            }
            if (chc_6_tech.Checked == true)
            {
                chc_6_tech_CheckedChanged(sender, e);
            }


        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {
            int x = -1;
            if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
            {
                x = Convert.ToInt32(comboBox9.SelectedValue);
            }
            label240.Text = oi.calcl(x, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date);
            //Done
            if (comboBox9.SelectedIndex >= 0)
            {
                lbl_1_lubs.Text = "";
                lbl_3_fuel.Text = "";
                lbl_4_filter.Text = "";
                lbl_5_parts.Text = "";
                lbl_6_tech.Text = "";
                flowLayoutPanel1.Controls.Clear();
                //panel47.Enabled = true;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                chc_1_lub.Checked = false;
                chc_2_main.Checked = false;
                chc_3_fuel.Checked = false;
                chc_4_filters.Checked = false;
                chc_5_parts.Checked = false;
                chc_6_tech.Checked = false;
            }
            else
            {
                // panel47.Enabled = false;
            }
            if (chc_1_lub.Checked == true)
            {
                lub_CheckedChanged(sender, e);
            }
            if (chc_3_fuel.Checked == true)
            {
                chc_3_fuel_CheckedChanged(sender, e);
            }
            if (chc_4_filters.Checked == true)
            {
                chc_4_filters_CheckedChanged(sender, e);
            }
            if (chc_5_parts.Checked == true)
            {
                chc_5_parts_CheckedChanged(sender, e);
            }
            if (chc_6_tech.Checked == true)
            {
                chc_6_tech_CheckedChanged(sender, e);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete This Filter Data?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = Convert.ToString(dataGridView4.Rows[dataGridView4.SelectedCells[0].RowIndex].Cells["filt_id"].Value);
                MessageBox.Show(fl.delflt(Convert.ToInt32(a)));

                if (checkBox5.Checked == true)
                {
                    comboBox6_SelectedIndexChanged(sender, e);
                }

                if (dataGridView4.Rows.Count > 0)
                {
                    pictureBox12_Click(sender, e);
                }
                if (dataGridView7.Rows.Count > 0)
                {
                    pictureBox7_Click(sender, e);
                }
                if (dataGridView6.Rows.Count > 0)
                {
                    pictureBox6_Click(sender, e);
                }
                if (dataGridView2.Rows.Count > 0)
                {
                    btn_report_lp_Click(sender, e);
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    btn_report_Click(sender, e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void comboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (chc_1_lub.Checked == true)
            {
                chc_1_lub_CheckedChanged(sender, e);
            }
            if (chc_3_fuel.Checked == true)
            {
                chc_3_fuel_CheckedChanged(sender, e);
            }
            if (chc_4_filters.Checked == true)
            {
                chc_4_filters_CheckedChanged(sender, e);
            }
            if (chc_5_parts.Checked == true)
            {
                chc_5_parts_CheckedChanged(sender, e);
            }
            if (chc_6_tech.Checked == true)
            {
                chc_6_tech_CheckedChanged(sender, e);
            }
            if (comboBox9.SelectedIndex > -1 && checkBox11.Checked == true)
            {
                decimal lubs = 0;
                decimal fuelss = 0;
                decimal filte = 0;
                decimal partsss = 0;
                decimal techcc = 0;

                List<string> type = new List<string>();
                type.Add("All");
                type.Add("None");



                List<string> lis = new List<string>();
                DataTable all2 = oi.Find_oil_show_Catalogue_Equivalent(Convert.ToInt32(comboBox9.SelectedValue));
                DataTable all = all2.DefaultView.ToTable(true, "oil_type");
                if (all.Rows.Count > 0)
                {
                    for (int i = 0; i < all.Rows.Count; i++)
                    {
                        lis.Add(all.Rows[i][0].ToString());
                    }
                }
                bool with = true;
                bool without = true;


                fuelss = Convert.ToDecimal(fu.rep_cost(Convert.ToInt32(comboBox9.SelectedValue), type, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date));
                filte = Convert.ToDecimal(fl.rep_cost(Convert.ToInt32(comboBox9.SelectedValue), type, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date));
                partsss = Convert.ToDecimal(ma.rep_cost(Convert.ToInt32(comboBox9.SelectedValue), dateTimePicker8.Value.Date, dateTimePicker9.Value.Date));
                techcc = Convert.ToDecimal(worksal.rep_cost(Convert.ToInt32(comboBox9.SelectedValue), dateTimePicker8.Value.Date, dateTimePicker9.Value.Date, type));
                lubs = Convert.ToDecimal(oi.cal_cos(Convert.ToInt32(comboBox9.SelectedValue), lis, with, without, dateTimePicker8.Value.Date, dateTimePicker9.Value.Date));


                label255.Text = Convert.ToString(fuelss + filte + partsss + techcc + lubs);
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            try
            {
                ControlID22.TextData22 = Convert.ToInt32(dataGridView4.Rows[dataGridView4.SelectedCells[0].RowIndex].Cells["filt_id"].Value);
                ControlID22.info = "Update Filter";
                using (pop1 uu = new pop1())
                {
                    Form formBackground = new Form();
                    //formBackground.StartPosition = FormStartPosition.Manual;
                    //formBackground.FormBorderStyle = FormBorderStyle.None;
                    //formBackground.Opacity = .50d;
                    //formBackground.BackColor = Color.Black;
                    //formBackground.WindowState = FormWindowState.Maximized;
                    //formBackground.TopMost = true;
                    //formBackground.Location = this.Location;
                    //formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();
                    formBackground.Dispose();
                    pictureBox12_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kk(System.Drawing.Color.Gainsboro, 
                System.Drawing.Color.LightGray , System.Drawing.Color.Green, System.Drawing.Color.Green,
                System.Drawing.Color.Black,System.Drawing.Color.Green, System.Drawing.Color.Black, System.Drawing.Color.Black,
               Properties.Resources.watermark);
        } 
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kk(System.Drawing.Color.FromArgb(45,45,45),
                System.Drawing.Color.FromArgb(45,45,45), System.Drawing.Color.DodgerBlue, System.Drawing.Color.DodgerBlue,
                System.Drawing.Color.White, System.Drawing.Color.DodgerBlue, System.Drawing.Color.White, System.Drawing.Color.DodgerBlue,
                Properties.Resources.watermarkkk_2);
        }
        public void kk(
            System.Drawing.Color pnl_backg,
            System.Drawing.Color butt_backg, System.Drawing.Color butt_bord, System.Drawing.Color butt_font_color,
            System.Drawing.Color main_tabs, System.Drawing.Color lbl_main, System.Drawing.Color lbl_sub, System.Drawing.Color lbl_sub_sub
            ,System.Drawing.Image imageee)
        {
            #region pnl_backg
            var color = pnl_backg;
            this.BackColor = color;
            tabb0.BackColor = color;
            tabb1.BackColor = color;
            tabb2.BackColor = color;
            tabb3.BackColor = color;
            tabb4.BackColor = color;
            tabb5.BackColor = color;

            tabPage1.BackColor = color;
            tabPage2.BackColor = color;
            tabPage3.BackColor = color;
            tabPage4.BackColor = color;
            tabPage5.BackColor = color;
            tabPage8.BackColor = color;

            prvvv.BackColor = color;
            corr.BackColor = color;
            daii.BackColor = color;

            main_rep.BackColor = color;
            tabPage7.BackColor = color;
            filter_rep.BackColor = color;
            labor_rep.BackColor = color;
            usa_ava.BackColor = color;
            cos_rep.BackColor = color;



            tabControl1.BackColor = color;
            tabControl6.BackColor = color;
            tabControl7.BackColor = color;
            tabControl8.BackColor = color;
            #endregion
            #region butt
            var color2 = butt_backg;
            var color3 = butt_bord;
            var color4 = butt_font_color;
            #region butt_backg
            button22.BackColor = color2;
            button1.BackColor = color2;
            button4.BackColor = color2;
            button3.BackColor = color2;
            button23.BackColor = color2;
            button24.BackColor = color2;
            button25.BackColor = color2;

            btn_oil_ins_equ.BackColor = color2;
            btn_oil_upd_equ.BackColor = color2;
            btn_oil_dlt_equ2.BackColor = color2;

            btn_flt_ins_equ.BackColor = color2;
            btn_flt_upd_equ.BackColor = color2;
            btn_flt_dlt_equ.BackColor = color2;

            btn_fuel_ins_equ.BackColor = color2;
            btn_fuel_upd_equ.BackColor = color2;
            btn_fuel_dlt_equ.BackColor = color2;

            btnhours.BackColor = color2;
            btn_detais_hours.BackColor = color2;

            btn_add_labor.BackColor = color2;
            btn_del_labor.BackColor = color2;
            btn_prev_main_ins_upd.BackColor = color2;
            btn_bring_to_upd.BackColor = color2;

            btn_cor_add_lapor.BackColor = color2;
            btn_cor_del_lapor.BackColor = color2;
            btn_cor_step2.BackColor = color2;
            btn_cor_bring.BackColor = color2;

            btn_add_labor2.BackColor = color2;
            btn_del_labor2.BackColor = color2;
            btn_Corr_main_ins_upd.BackColor = color2;
            btn_bring_to_upd2.BackColor = color2;

            btn_oil_ins.BackColor = color2;
            btn_oil_upd.BackColor = color2;
            btn_oil_del.BackColor = color2;
            btn_fuel_ins.BackColor = color2;
            btn_fuel_upd.BackColor = color2;
            btn_fuel_del.BackColor = color2;
            btn_labor_ins.BackColor = color2;
            btn_labor_upd.BackColor = color2;
            btn_labor_del.BackColor = color2;
            btn_ins_filt.BackColor = color2;
            btn_flt_upd.BackColor = color2;
            btn_del_filt.BackColor = color2;

            button2.BackColor = color2;
            button5.BackColor = color2;
            button10.BackColor = color2;
            button21.BackColor = color2;

            button12.BackColor = color2;
            button13.BackColor = color2;
            button30.BackColor = color2;

            button15.BackColor = color2;
            button16.BackColor = color2;
            button31.BackColor = color2;

            button14.BackColor = color2;
            button17.BackColor = color2;
            button32.BackColor = color2;

            btn_rep_lb_del.BackColor = color2;
            btn_rep_lb_up.BackColor = color2;
            button28.BackColor = color2;

            btn_use.BackColor = color2;
            button29.BackColor = color2;
            #endregion
            #region butt_bord
            button22.FlatAppearance.BorderColor = color3;
            button1.FlatAppearance.BorderColor = color3;
            button4.FlatAppearance.BorderColor = color3;
            button3.FlatAppearance.BorderColor = color3;
            button23.FlatAppearance.BorderColor = color3;
            button24.FlatAppearance.BorderColor = color3;
            button25.FlatAppearance.BorderColor = color3;

            btn_oil_ins_equ.FlatAppearance.BorderColor = color3;
            btn_oil_upd_equ.FlatAppearance.BorderColor = color3;
            btn_oil_dlt_equ2.FlatAppearance.BorderColor = color3;

            btn_flt_ins_equ.FlatAppearance.BorderColor = color3;
            btn_flt_upd_equ.FlatAppearance.BorderColor = color3;
            btn_flt_dlt_equ.FlatAppearance.BorderColor = color3;

            btn_fuel_ins_equ.FlatAppearance.BorderColor = color3;
            btn_fuel_upd_equ.FlatAppearance.BorderColor = color3;
            btn_fuel_dlt_equ.FlatAppearance.BorderColor = color3;

            btnhours.FlatAppearance.BorderColor = color3;
            btn_detais_hours.FlatAppearance.BorderColor = color3;

            btn_add_labor.FlatAppearance.BorderColor = color3;
            btn_del_labor.FlatAppearance.BorderColor = color3;
            btn_prev_main_ins_upd.FlatAppearance.BorderColor = color3;
            btn_bring_to_upd.FlatAppearance.BorderColor = color3;

            btn_cor_add_lapor.FlatAppearance.BorderColor = color3;
            btn_cor_del_lapor.FlatAppearance.BorderColor = color3;
            btn_cor_step2.FlatAppearance.BorderColor = color3;
            btn_cor_bring.FlatAppearance.BorderColor = color3;

            btn_add_labor2.FlatAppearance.BorderColor = color3;
            btn_del_labor2.FlatAppearance.BorderColor = color3;
            btn_Corr_main_ins_upd.FlatAppearance.BorderColor = color3;
            btn_bring_to_upd2.FlatAppearance.BorderColor = color3;

            btn_oil_ins.FlatAppearance.BorderColor = color3;
            btn_oil_upd.FlatAppearance.BorderColor = color3;
            btn_oil_del.FlatAppearance.BorderColor = color3;
            btn_fuel_ins.FlatAppearance.BorderColor = color3;
            btn_fuel_upd.FlatAppearance.BorderColor = color3;
            btn_fuel_del.FlatAppearance.BorderColor = color3;
            btn_labor_ins.FlatAppearance.BorderColor = color3;
            btn_labor_upd.FlatAppearance.BorderColor = color3;
            btn_labor_del.FlatAppearance.BorderColor = color3;
            btn_ins_filt.FlatAppearance.BorderColor = color3;
            btn_flt_upd.FlatAppearance.BorderColor = color3;
            btn_del_filt.FlatAppearance.BorderColor = color3;

            button2.FlatAppearance.BorderColor = color3;
            button5.FlatAppearance.BorderColor = color3;
            button10.FlatAppearance.BorderColor = color3;
            button21.FlatAppearance.BorderColor = color3;

            button12.FlatAppearance.BorderColor = color3;
            button13.FlatAppearance.BorderColor = color3;
            button30.FlatAppearance.BorderColor = color3;

            button15.FlatAppearance.BorderColor = color3;
            button16.FlatAppearance.BorderColor = color3;
            button31.FlatAppearance.BorderColor = color3;

            button14.FlatAppearance.BorderColor = color3;
            button17.FlatAppearance.BorderColor = color3;
            button32.FlatAppearance.BorderColor = color3;

            btn_rep_lb_del.FlatAppearance.BorderColor = color3;
            btn_rep_lb_up.FlatAppearance.BorderColor = color3;
            button28.FlatAppearance.BorderColor = color3;

            btn_use.FlatAppearance.BorderColor = color3;
            button29.FlatAppearance.BorderColor = color3;

            #endregion
            #region butt_font_color
            button22.ForeColor = color4;
            button1.ForeColor = color4;
            button4.ForeColor = color4;
            button3.ForeColor = color4;
            button23.ForeColor = color4;
            button24.ForeColor = color4;
            button25.ForeColor = color4;

            btn_oil_ins_equ.ForeColor = color4;
            btn_oil_upd_equ.ForeColor = color4;
            btn_oil_dlt_equ2.ForeColor = color4;

            btn_flt_ins_equ.ForeColor = color4;
            btn_flt_upd_equ.ForeColor = color4;
            btn_flt_dlt_equ.ForeColor = color4;

            btn_fuel_ins_equ.ForeColor = color4;
            btn_fuel_upd_equ.ForeColor = color4;
            btn_fuel_dlt_equ.ForeColor = color4;

            btnhours.ForeColor = color4;
            btn_detais_hours.ForeColor = color4;

            btn_add_labor.ForeColor = color4;
            btn_del_labor.ForeColor = color4;
            btn_prev_main_ins_upd.ForeColor = color4;
            btn_bring_to_upd.ForeColor = color4;

            btn_cor_add_lapor.ForeColor = color4;
            btn_cor_del_lapor.ForeColor = color4;
            btn_cor_step2.ForeColor = color4;
            btn_cor_bring.ForeColor = color4;

            btn_add_labor2.ForeColor = color4;
            btn_del_labor2.ForeColor = color4;
            btn_Corr_main_ins_upd.ForeColor = color4;
            btn_bring_to_upd2.ForeColor = color4;

            btn_oil_ins.ForeColor = color4;
            btn_oil_upd.ForeColor = color4;
            btn_oil_del.ForeColor = color4;
            btn_fuel_ins.ForeColor = color4;
            btn_fuel_upd.ForeColor = color4;
            btn_fuel_del.ForeColor = color4;
            btn_labor_ins.ForeColor = color4;
            btn_labor_upd.ForeColor = color4;
            btn_labor_del.ForeColor = color4;
            btn_ins_filt.ForeColor = color4;
            btn_flt_upd.ForeColor = color4;
            btn_del_filt.ForeColor = color4;

            button2.ForeColor = color4;
            button5.ForeColor = color4;
            button10.ForeColor = color4;
            button21.ForeColor = color4;

            button12.ForeColor = color4;
            button13.ForeColor = color4;
            button30.ForeColor = color4;

            button15.ForeColor = color4;
            button16.ForeColor = color4;
            button31.ForeColor = color4;

            button14.ForeColor = color4;
            button17.ForeColor = color4;
            button32.ForeColor = color4;

            btn_rep_lb_del.ForeColor = color4;
            btn_rep_lb_up.ForeColor = color4;
            button28.ForeColor = color4;

            btn_use.ForeColor = color4;
            button29.ForeColor = color4;
            #endregion
            #endregion
            #region main_tabs
            var colorw = main_tabs;
            mainMenuToolStripMenuItem.ForeColor = colorw;
            equipmentInformationToolStripMenuItem.ForeColor = colorw;
            postingDataToolStripMenuItem.ForeColor = colorw;
            maintenanceToolStripMenuItem.ForeColor = colorw;
            reportsToolStripMenuItem.ForeColor = colorw;
            modeToolStripMenuItem.ForeColor = colorw;
            #endregion
            
            foreach (Control con in flowLayoutPanel2.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub;
                }
                if (con is Panel)
                {
                    con.BackColor = lbl_main;
                }
            }
            foreach (Control con in flow_dai.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub;
                }
                if (con is Panel)
                {
                    con.BackColor = lbl_main;
                }
            }
            foreach (Control con in panel53.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in panel2.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in panel51.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in panel5.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in pnl_labor.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in pnl_cor.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is RadioButton)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in pnl_cor_names.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in panel12.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is RadioButton)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in pnl_labor2.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in panel15.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in panel60.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel55.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in tableLayoutPanel3.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in tableLayoutPanel1.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel52.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel54.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel56.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel28.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel7.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel58.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in pnl_oil_ins.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is Panel)
                {
                    foreach (Control con2 in con.Controls)
                    {
                        if (con2 is Label)
                        {
                            con2.ForeColor = lbl_sub_sub;
                        }
                    }
                }
            }
            foreach (Control con in panel37.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is Panel)
                {
                    foreach (Control con2 in con.Controls)
                    {
                        if (con2 is Label)
                        {
                            con2.ForeColor = lbl_sub_sub;
                        }
                    }
                }
            }
            foreach (Control con in pnl_oil.Controls)
            {
                if (con is RadioButton)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in pnl_oil_up_del.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is Panel)
                {
                    foreach (Control con2 in con.Controls)
                    {
                        if (con2 is Label)
                        {
                            con2.ForeColor = lbl_sub_sub;
                        }
                    }
                }
            }
            foreach (Control con in pnl_filer_fuel_del.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
            }
            foreach (Control con in panel33.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
            }
            foreach (Control con in panel46.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
            }
            foreach (Control con in panel49.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is Panel)
                {
                    foreach (Control con2 in con.Controls)
                    {
                        if (con2 is Label)
                        {
                            con2.ForeColor = lbl_sub_sub;
                        }
                    }
                }
            }
            foreach (Control con in panel44.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is Panel)
                {
                    foreach (Control con2 in con.Controls)
                    {
                        if (con2 is Label)
                        {
                            con2.ForeColor = lbl_sub_sub;
                        }
                    }
                }
            }
            foreach (Control con in panel42.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is Panel)
                {
                    foreach (Control con2 in con.Controls)
                    {
                        if (con2 is Label)
                        {
                            con2.ForeColor = lbl_sub_sub;
                        }
                    }
                }
                if (con is RadioButton)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel21.Controls)
            {
                if (con is RadioButton)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel59.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel9.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_main;
                }
            }
            foreach (Control con in panel62.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            label255.ForeColor = lbl_sub;
            foreach (Control con in panel39.Controls)
            {
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in tabPage7.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub_sub;
                }
            }
            foreach (Control con in panel47.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub_sub;
                }
            }
            foreach (Control con in panel61.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub_sub;
                }
            }
            foreach (Control con in filter_rep.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub_sub;
                }
            }
            foreach (Control con in panel48.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in panel8.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub_sub;
                }
                if (con is Label)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in main_rep.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub;
                }
                if (con is RadioButton)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in flowLayoutPanel3.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            foreach (Control con in flowLayoutPanel1.Controls)
            {
                if (con is CheckBox)
                {
                    con.ForeColor = lbl_sub;
                }
            }
            
            label200.ForeColor = lbl_main; //select eq
            label192.ForeColor = lbl_main;
            label208.ForeColor = lbl_main;
            label209.ForeColor = lbl_main;
            label210.ForeColor = lbl_main;
            label190.ForeColor = lbl_main;
            label155.ForeColor = lbl_main;
            label155.ForeColor = lbl_main;
            label169.ForeColor = lbl_main;
            label173.ForeColor = lbl_main;
            label74.ForeColor = lbl_main;

            label152.ForeColor = lbl_sub_sub;
            label141.ForeColor = lbl_sub_sub;
            label8.ForeColor = lbl_sub_sub;
            label117.ForeColor = lbl_sub_sub;
            label147.ForeColor = lbl_sub_sub;
            label186.ForeColor = lbl_sub_sub;
            label142.ForeColor = lbl_sub_sub;
            label180.ForeColor = lbl_sub_sub;
            label176.ForeColor = lbl_sub_sub;
            label149.ForeColor = lbl_sub_sub;
            label151.ForeColor = lbl_sub_sub;
            label183.ForeColor = lbl_sub_sub;
            label181.ForeColor = lbl_sub_sub;
            label182.ForeColor = lbl_sub_sub;


            label92.ForeColor = lbl_main; //page name
            label90.ForeColor = lbl_main;
            label37.ForeColor = lbl_main;
            lbl_cor_name.ForeColor = lbl_main;
            lbl_main_name.ForeColor = lbl_main;


            label144.ForeColor = lbl_main;//info
            label91.ForeColor = lbl_main;
            label156.ForeColor = lbl_main;
            label114.ForeColor = lbl_main;
            groupBox2.BackColor = lbl_main;
            groupBox3.BackColor = lbl_main;
            groupBox4.BackColor = lbl_main;
            groupBox5.BackColor = lbl_main;


            lowww_prv.ForeColor = lbl_main; //prv
            lbl_prv_after.ForeColor = lbl_sub;
            lbl_hours_ins2.ForeColor = lbl_sub;
            label230.ForeColor = lbl_main;
            lbl_lastH.ForeColor = lbl_sub;
            label100.ForeColor = lbl_main;
            label236.ForeColor = lbl_main;
            label232.ForeColor = lbl_sub;
            label237.ForeColor = lbl_main;

            //cor
            lbl_cor_not_done.ForeColor = lbl_main;

            //dai
            //label140.ForeColor = lbl_sub_sub;
            label107.ForeColor = lbl_main;
            radio_corr_dai_done.ForeColor = lbl_sub;
            radio_corr_dai_Not_done.ForeColor = lbl_sub;

            label234.ForeColor = lbl_sub;  //table1
            label227.ForeColor = lbl_sub;
            label231.ForeColor = lbl_sub;

            label206.ForeColor = lbl_sub;  //table2
            label204.ForeColor = lbl_sub;
            label201.ForeColor = lbl_sub;
            label203.ForeColor = lbl_sub;
            label202.ForeColor = lbl_sub;


            radioButton3.ForeColor = lbl_main; //add oil
            radioButton4.ForeColor = lbl_main;
            label104.ForeColor = lbl_sub_sub;
            label140.ForeColor = lbl_main;

            label196.ForeColor = lbl_sub_sub;
            radioButton2.ForeColor = lbl_main;
            radioButton1.ForeColor = lbl_main;
            radioButton6.ForeColor = lbl_main;
            radioButton5.ForeColor = lbl_main;
            radioButton8.ForeColor = lbl_main;
            radioButton7.ForeColor = lbl_main;
            label75.ForeColor = lbl_main;
            label45.ForeColor = lbl_main;



            label213.ForeColor = lbl_main;
            label27.ForeColor = lbl_main;
            label113.ForeColor = lbl_main;
            label28.ForeColor = lbl_main;
            label199.ForeColor = lbl_main;
            label215.ForeColor = lbl_main;
            label179.ForeColor = lbl_main;
            label235.ForeColor = lbl_main;
            label125.ForeColor = lbl_main;
            label98.ForeColor = lbl_main;
            label123.ForeColor = lbl_main;
            label229.ForeColor = lbl_main;
            label246.ForeColor = lbl_main;

            label238.ForeColor = lbl_main;
            label207.ForeColor = lbl_sub;
            label198.ForeColor = lbl_sub;
            label214.ForeColor = lbl_sub;
            label178.ForeColor = lbl_sub;
            label128.ForeColor = lbl_sub;
            label247.ForeColor = lbl_sub;
            label248.ForeColor = lbl_sub;
            label145.ForeColor = lbl_sub_sub;
            label126.ForeColor = lbl_sub_sub;
            label127.ForeColor = lbl_sub_sub;
            checkBox8.ForeColor = lbl_sub_sub;
            chk_cost3.ForeColor = lbl_sub_sub;
            label189.ForeColor = lbl_main;
            label76.ForeColor = lbl_sub;

            pictureBox8.Image = imageee;
        }
        private void textBox15_Leave(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Save ("+ textBox15.Text+ ") as this Periodic Maintenance stage Cost?", "Save Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ma.update_new_cost(Convert.ToInt32(comb_prv_sq.SelectedValue), Convert.ToInt32(textBox15.Text)));
            }
            else
            {

            }
        }

    }
}
            
