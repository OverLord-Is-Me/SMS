using Microsoft.Office.Interop.Excel;
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


namespace notfinal
{
    public partial class pop1 : Form
    {
        filter fl = new filter();
        equ eq = new equ();
        fuel fu = new fuel();
        maintain ma = new maintain();
        oil oi = new oil();
        worker wo = new worker();
        work_sal_mob worksal = new work_sal_mob();
        equ_work_h equ_work = new equ_work_h(); 
        string sta = "";
        string id_sent = Convert.ToString(Login.ControlID.TextData);
        decimal hours = 0;


        public pop1()
        {
            InitializeComponent();
        }
        private void pop1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopeDataSet.oil' table. You can move, or remove it, as needed.
            this.oilTableAdapter.Fill(this.hopeDataSet.oil);
            // TODO: This line of code loads data into the 'hopeDataSet.equ' table. You can move, or remove it, as needed.
            this.equTableAdapter.Fill(this.hopeDataSet.equ);
            
            int adad = Use.ControlID22.TextData22;
            string sent_string = Convert.ToString(adad);
            try{ sta = Use.ControlID22.idd; }catch { sta = "0"; }
            if (Use.ControlID22.info == "Add oil")
            {
                Use.ControlID22.cancel = "cancel";
                try
                {
                    hours = Use.ControlID22.hours;
                }
                catch { }
                panel1.Visible = false;
                panel1.SendToBack();
                panel_lb_up.Visible = false;
                panel_lb_up.SendToBack();
                panel2.Visible = true;
                panel2.BringToFront();
                txt_equ_id.Text = sent_string;
                txt_oil_user_id.Text = id_sent; //btn_oil_ins.Enabled = true;
                System.Data.DataTable oils = oi.Find_oil_show_Catalogue_Equivalent(Convert.ToInt32(txt_equ_id.Text));
                System.Data.DataTable fuel = fu.Find_fuel_show_data(Convert.ToInt32(txt_equ_id.Text));
                System.Data.DataTable filters = fl.Find_filt_show_data_equ(Convert.ToInt32(txt_equ_id.Text));
                if (oils.Rows.Count == 0)
                {
                    lbl_alert0.Visible = true;
                }
                else
                {
                    lbl_alert0.Visible = false;
                }
                if (fuel.Rows.Count == 0)
                {
                    lbl_alert1.Visible = true;
                }
                else
                {
                    lbl_alert1.Visible = false;
                }
                if (lbl_alert0.Visible == true && lbl_alert1.Visible == true)
                {
                    comboBox3.Enabled = false;
                    button8.Enabled = false;
                }
                else
                {
                    comboBox3.Enabled = true;
                    button8.Enabled = true;
                }
                if (filters.Rows.Count == 0)
                {
                    lbl_alert2.Visible = true;
                    comboBox4.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    lbl_alert2.Visible = false;
                    comboBox4.Enabled = true;
                    button1.Enabled = true;
                }
                for (int i = 0; i < fuel.Rows.Count; i++)
                {
                    System.Data.DataRow dtd = oils.NewRow();
                    dtd["oil_id"] = Convert.ToInt32(fuel.Rows[i][0].ToString());
                    dtd["equ_id"] = Convert.ToInt32(fuel.Rows[i][1].ToString());
                    dtd["oil_type"] = fuel.Rows[i][2].ToString();
                    dtd["oil_name"] = "fuel";
                    dtd["oil_cap"] = Convert.ToDecimal(fuel.Rows[i][4].ToString());
                    dtd["oil_cost"] = Convert.ToInt32(fuel.Rows[i][5].ToString());
                    dtd["oil_date"] = Convert.ToDateTime(fuel.Rows[i][6].ToString());
                    dtd["user_id"] = Convert.ToInt32(fuel.Rows[i][7].ToString());
                    dtd["oil_replacements"] = "fuel";
                    dtd["main_type"] = fuel.Rows[i][9].ToString();
                    dtd["oil_state"] = Convert.ToInt32(fuel.Rows[i][8].ToString());
                    dtd["oil_alert"] = "fuel";
                    dtd["main_id"] = Convert.ToInt32(fuel.Rows[i][3].ToString());
                    oils.Rows.Add(dtd);
                }
                comboBox3.DataSource = oils;
                comboBox3.ValueMember = "oil_id";
                comboBox3.DisplayMember = "oil_type";
                comboBox3.SelectedIndex = -1;

                comboBox4.DataSource = filters;
                comboBox4.ValueMember = "filt_id";
                comboBox4.DisplayMember = "filt_type";
                comboBox4.SelectedIndex = -1;

                System.Data.DataTable there = oi.Find_oil_with_main(sta);
                System.Data.DataTable there_fuel = fu.Find_fuel_with_main(sta);
                System.Data.DataTable there_filters = fl.Find_filter_with_main(sta);
                for (int i = 0; i < there.Rows.Count; i++)
                {
                    add_panals(
                          there.Rows[i][0].ToString()
                        , there.Rows[i][2].ToString()
                        , there.Rows[i][3].ToString()
                        , there.Rows[i][4].ToString()
                        , there.Rows[i][5].ToString()
                        , Convert.ToDateTime(there.Rows[i][6].ToString())
                        , there.Rows[i][8].ToString()
                        , there.Rows[i][9].ToString()
                        , there.Rows[i][10].ToString()
                        , there.Rows[i][11].ToString()
                        , there.Rows[i][12].ToString());
                }
                for (int i = 0; i < there_fuel.Rows.Count; i++)
                {
                    add_panals(
                          there_fuel.Rows[i][0].ToString()
                        , there_fuel.Rows[i][2].ToString()
                        , "fuel"
                        , there_fuel.Rows[i][4].ToString()
                        , there_fuel.Rows[i][5].ToString()
                        , Convert.ToDateTime(there_fuel.Rows[i][6].ToString())
                        , ""
                        , there_fuel.Rows[i][9].ToString()
                        , there_fuel.Rows[i][8].ToString()
                        , "fuel"
                        , there.Rows[i][3].ToString());
                }
                for (int i = 0; i < there_filters.Rows.Count; i++)
                {
                    add_Filter_panals(
                          there_filters.Rows[i][0].ToString()
                        , there_filters.Rows[i][2].ToString()
                        , there_filters.Rows[i][3].ToString()
                        , there_filters.Rows[i][4].ToString()
                        , there_filters.Rows[i][5].ToString()
                        , Convert.ToDateTime(there_filters.Rows[i][6].ToString())
                        , there_filters.Rows[i][8].ToString()
                        , there_filters.Rows[i][9].ToString()
                        , there_filters.Rows[i][10].ToString());
                }

                //if (oi.Find_oil_with_main(sta, "Engine Oil"))            
                //{
                //    id1.Text = oi.oil_id.ToString();
                //    checkBox1.Checked = true;
                //}          else { id1.Text = "0"; }
                if (false)
                {
                    id2.Text = oi.oil_id.ToString();
                    checkBox2.Checked = true;
                }
                else { id2.Text = "0"; }
                if (false)
                {
                    id3.Text = oi.oil_id.ToString();
                    checkBox3.Checked = true;
                }
                else { id3.Text = "0"; }
                if (false)
                {
                    id4.Text = oi.oil_id.ToString();
                    checkBox4.Checked = true;
                }
                else { id4.Text = "0"; }
                if (false)
                {
                    id5.Text = oi.oil_id.ToString();
                    checkBox5.Checked = true;
                }
                else { id5.Text = "0"; }
                if (false)
                {
                    id6.Text = oi.oil_id.ToString();
                    checkBox6.Checked = true;
                }
                else { id6.Text = "0"; }
                if (fu.Findfuelforpop222(Convert.ToInt32(sta)))
                {
                    id7.Text = fu.fuel_id.ToString();
                    checkBox7.Checked = true;
                }
                else { id7.Text = "0"; }
            }
            else if (Use.ControlID22.info == "Hours Details")
            {
                panel_lb_up.Visible = false;
                panel_lb_up.SendToBack();
                panel2.Visible = false;
                panel2.SendToBack();
                panel1.Visible = true;
                panel1.BringToFront();
                this.Width = panel1.Width;
                this.Height = panel1.Height;
                txt_equ_id.Text = sent_string;
                txt_oil_user_id.Text = id_sent;
                lbl_hours2.Text = Convert.ToString(ma.Find_work_hours_int(Convert.ToInt32(txt_equ_id.Text)));
                combo_use.SelectedValue = Use.ControlID22.TextData22;
                if (ma.if_km(Convert.ToInt32(txt_equ_id.Text)))
                {
                    lbl_hours1.Text = "Current Worked Kilometers";
                    label96.Text = "Kilometers";
                }
                else
                {
                    lbl_hours1.Text = "Current Worked Hours";
                    label96.Text = "Hours";
                }
            }
            else
            {
                up_laap.BringToFront();
                up_laap.BringToFront();
                up_laap.BringToFront();
                up_laap.BringToFront();
                up_laap.BringToFront();
                panel1.Visible = false;
                panel1.SendToBack();
                panel2.Visible = false;
                panel2.SendToBack();
                panel_lb_up.Visible = true;
                panel_lb_up.BringToFront();
                this.Width = panel_lb_up.Width + 20;
                this.Height = panel_lb_up.Height + 40;
                this.CenterToScreen();
                panel_lb_up.Location = new System.Drawing.Point(0, 0);
                int a = Convert.ToInt32(sent_string);

                this.BackColor = Color.FromArgb(45, 45, 45);
                if (Use.ControlID22.info == "Update Labor")
                {
                    up_laap.BringToFront();
                    up_laap.BringToFront();
                    System.Data.DataTable tb1 = worksal.Find_worsal(a);
                    System.Data.DataTable labors = wo.bring_labor_names();
                    comboBox6.DataSource = labors;
                    comboBox6.DisplayMember = "worker_name";
                    comboBox6.ValueMember = "worker_id";
                    lbl1.Text = tb1.Rows[0][0].ToString();
                    lbl2.Text = tb1.Rows[0][1].ToString();
                    try 
                    { comboBox6.SelectedValue = tb1.Rows[0][2].ToString();
                        comboBox6.Text = tb1.Rows[0][3].ToString();} catch { }
                    lbl3.Text = tb1.Rows[0][4].ToString();
                    textBox40.Text = tb1.Rows[0][5].ToString();
                    dateTimePicker8.Value = Convert.ToDateTime(tb1.Rows[0][6].ToString());
                    lbl4.Text = tb1.Rows[0][7].ToString();
                    textBox39.Text = tb1.Rows[0][8].ToString();
                    lbl5.Text = tb1.Rows[0][10].ToString();
                    lbl6.Text = tb1.Rows[0][11].ToString();
                }
                else if (Use.ControlID22.info == "Update Oil")
                {
                    ud_oil.BringToFront();
                    ud_oil.BringToFront();

                    oi.Findoil(a);
                    llbl1.Text = oi.oil_id.ToString();
                    llbl2.Text = oi.equ_id.ToString();
                    textBox44.Text = oi.oil_type.ToString();
                    txt_rep_lb_hors.Text = oi.oil_name.ToString();
                    textBox41.Text = oi.oil_cap.ToString();
                    textBox43.Text = oi.oil_cost.ToString();
                    dateTimePicker5.Value =Convert.ToDateTime(oi.oil_date);
                    llbl3.Text = oi.user_id.ToString();
                    llbl4.Text = oi.oil_replacements.ToString();
                    if (oi.main_type.ToString() == "Refill")
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                        radioButton1.Checked = false;
                    }
                    llbl5.Text = oi.oil_state.ToString();
                    llbl6.Text = oi.oil_alert.ToString();
                    llbl7.Text = oi.main_id.ToString();

                }
                else if (Use.ControlID22.info == "Update Filter")
                {
                    ud_oil.BringToFront();
                    ud_oil.BringToFront();
                    panel14.Visible = false;

                    fl.Findfilt(a);
                    llbl1.Text = fl.filt_id.ToString();
                    llbl2.Text = fl.equ_id.ToString();
                    textBox44.Text = fl.filt_type.ToString();
                    txt_rep_lb_hors.Text = fl.filt_name.ToString();
                    textBox41.Text = fl.filt_cap.ToString();
                    textBox42.Text = "1";
                    textBox43.Text = fl.filt_cost.ToString();
                    dateTimePicker5.Value = Convert.ToDateTime(fl.filt_date);
                    llbl3.Text = fl.user_id.ToString();
                    llbl4.Text = fl.filt_replacements.ToString();
                    llbl5.Text = fl.main_hours.ToString();
                    llbl6.Text = fl.filt_active.ToString();
                    llbl7.Text = fl.main_id.ToString();

                    label3.Text = "Filter Type";
                    label104.Text = "Filter Name";
                    label105.Text = "Quantity";
                   
                    textBox42.Visible = false;
                    label6.Visible = false;
                    label106.Text = "Date";
                    dateTimePicker5.Location = new System.Drawing.Point(86, 127);

                }
                else if (Use.ControlID22.info == "Update Fuel")
                {
                    ud_oil.BringToFront();
                    ud_oil.BringToFront();
                    panel14.Visible = false;

                    fu.Findfuel(a);
                    llbl1.Text = fu.fuel_id.ToString();
                    llbl2.Text = fu.equ_id.ToString();
                    textBox44.Text = fu.fuel_type.ToString();
                    txt_rep_lb_hors.Text = fu.fuel_name.ToString();
                    textBox41.Text = fu.fuel_cap.ToString();
                    textBox43.Text = fu.fuel_cost.ToString();
                    dateTimePicker5.Value = Convert.ToDateTime(fu.fuel_date);
                    llbl3.Text = fu.user_id.ToString();
                    llbl4.Text = fu.main_hours.ToString();
                    llbl5.Text = fu.fuel_active.ToString();
                    llbl6.Text = fu.main_id.ToString();

                    txt_rep_lb_hors.Visible = false;
                    label104.Text = "Date";
                    label3.Text = "Fuel Type";
                    label6.Visible = false;
                    dateTimePicker5.Location = new System.Drawing.Point(86, 73);
                }

            }
        }
        #region old

        private void btn_oil_ins_Click(object sender, EventArgs e)
        {
            string state1 = "Success";
            string state2 = "Success";
            string state3 = "Success";
            string state4 = "Success";
            string state5 = "Success";
            string state6 = "Success";
            string state7 = "Success";
            string cond = "true";
            string www1 = "";
            //string www2 = ma.Find_work_hours_int(Convert.ToInt32(txt_equ_id.Text)).ToString();
            string www3 = "";
            int www4 = Convert.ToInt32(sta);

            if (checkBox1.Checked)
            {
                //if( radioButton1.Checked == false && radioButton2.Checked == false)
                //{
                //    MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Engine Oil");return;
                //}
                //if (date_oil_ins1.Value > DateTime.Now)
                //{
                //    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                //}
                //string tt = "Engine Oil";
                //if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) == 0 && radioButton2.Checked == false)
                //{
                //    MessageBox.Show("Please Insert Active "+ tt + " Data First Or Check (Active Oil Changed) To Save this Data As Active " + tt + " Data"); return;
                //} //000---Add
                //else if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt ) > 1 && radioButton2.Checked == true)
                //{
                //    MessageBox.Show("This Equipment has More Than (1) " + tt + " Type Please Check (Add Amount) To Continue"); return;
                //} //multi active
            }
            if (checkBox2.Checked)
            {
                if (radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Transmission Oil"); return;
                }
                if (dateTimePicker1.Value > DateTime.Now)
                {
                    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                }
                //string tt = "Transmission Oil";
                //if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) == 0 && radioButton4.Checked == false)
                //{
                //    MessageBox.Show("Please Insert Active " + tt + " Data First Or Check (Active Oil Changed) To Save this Data As Active " + tt + " Data"); return;
                //} //000---Add
                //else if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) > 1 && radioButton4.Checked == true)
                //{
                //    MessageBox.Show("This Equipment has More Than (1) " + tt + " Type Please Check (Add Amount) To Continue"); return;
                //} //multi active

            }
            if (checkBox3.Checked)
            {
                if (radioButton5.Checked == false && radioButton6.Checked == false)
                {
                    MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Hydrailic Oil"); return;
                }
                if (dateTimePicker2.Value > DateTime.Now)
                {
                    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                }
                //string tt = "Hydrailic Oil";
                //if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) == 0 && radioButton6.Checked == false)
                //{
                //    MessageBox.Show("Please Insert Active " + tt + " Data First Or Check (Active Oil Changed) To Save this Data As Active " + tt + " Data"); return;
                //} //000---Add
                //else if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) > 1 && radioButton6.Checked == true)
                //{
                //    MessageBox.Show("This Equipment has More Than (1) " + tt + " Type Please Check (Add Amount) To Continue"); return;
                //} //multi active
            }
            if (checkBox4.Checked)
            {
                if (radioButton7.Checked == false && radioButton8.Checked == false)
                {
                    MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Differential Oil"); return;
                }
                if (dateTimePicker3.Value > DateTime.Now)
                {
                    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                }
                //string tt = "Differential Oil";
                //if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) == 0 && radioButton8.Checked == false)
                //{
                //    MessageBox.Show("Please Insert Active " + tt + " Data First Or Check (Active Oil Changed) To Save this Data As Active " + tt + " Data"); return;
                //} //000---Add
                //else if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) > 1 && radioButton8.Checked == true)
                //{
                //    MessageBox.Show("This Equipment has More Than (1) " + tt + " Type Please Check (Add Amount) To Continue"); return;
                //} //multi active
            }
            if (checkBox5.Checked)
            {
                if (radioButton9.Checked == false && radioButton10.Checked == false)
                {
                    MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Final Drive Oil"); return;
                }
                if (dateTimePicker4.Value > DateTime.Now)
                {
                    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                }
                //string tt = "Final Drive Oil";
                //if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) == 0 && radioButton10.Checked == false)
                //{
                //    MessageBox.Show("Please Insert Active " + tt + " Data First Or Check (Active Oil Changed) To Save this Data As Active " + tt + " Data"); return;
                //} //000---Add
                //else if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) > 1 && radioButton10.Checked == true)
                //{
                //    MessageBox.Show("This Equipment has More Than (1) " + tt + " Type Please Check (Add Amount) To Continue"); return;
                //} //multi active
            }
            if (checkBox6.Checked)
            {
                if (radioButton11.Checked == false && radioButton12.Checked == false)
                {
                    MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Final Drive Oil"); return;
                }
                if (dateTimePicker6.Value > DateTime.Now)
                {
                    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                }
                //string tt = "Coolant Water";
                //if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) == 0 && radioButton12.Checked == false)
                //{
                //    MessageBox.Show("Please Insert Active " + tt + " Data First Or Check (Active Oil Changed) To Save this Data As Active " + tt + " Data"); return;
                //} //000---Add
                //else if (oi.baka(Convert.ToInt32(txt_equ_id.Text), tt) > 1 && radioButton12.Checked == true)
                //{
                //    MessageBox.Show("This Equipment has More Than (1) " + tt + " Type Please Check (Add Amount) To Continue"); return;
                //} //multi active
            }
            if (checkBox7.Checked)
            {
                if (dateTimePicker7.Value > DateTime.Now)
                {
                    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                }
            }
            try
            {
                //if (checkBox1.Checked)
                //{
                //    try
                //    {                       
                //        if(id1.Text == "0")
                //        {
                //            txt_oil_id1.Text = "";
                //            if (radioButton1.Checked)
                //            { 
                //                www1 = "Add"; 
                //            }
                //            else if (radioButton2.Checked)
                //            {
                //                www1 = "Active";
                //            }
                //            else
                //            {
                //                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                //            }
                //            string wwwq = txt_oil_rep_ins1.Text + "<#>" + txt_oil_rep_ins2.Text + "<#>" + txt_oil_rep_ins3.Text;
                //            state1 = oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label27.Text, txt_oil_ins2.Text
                //           , Convert.ToDecimal(txt_oil_ins3.Text), Convert.ToInt32(txt_oil_ins4.Text), date_oil_ins1.Value,
                //           Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, www3, www4);
                //            if (state1=="Success")
                //            {
                //                id1.Text = "0";
                //            }
                //        }
                //        else
                //        {
                //            if (radioButton1.Checked)
                //            {
                //                www1 = "Add";
                //            }
                //            else if (radioButton2.Checked)
                //            {
                //                www1 = "Active";
                //            }
                //            else
                //            {
                //                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                //            }
                //            string hours =Convert.ToString( ma.get_hours_by_id(Convert.ToInt32(sta)));
                //            string wwwq = txt_oil_rep_ins1.Text + "<#>" + txt_oil_rep_ins2.Text + "<#>" + txt_oil_rep_ins3.Text;
                //            state1 = oi.updateoil(Convert.ToInt32(id1.Text), Convert.ToInt32(txt_equ_id.Text), label27.Text, txt_oil_ins2.Text
                //           , Convert.ToDecimal(txt_oil_ins3.Text), Convert.ToInt32(txt_oil_ins4.Text), date_oil_ins1.Value,
                //           Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, lbl_type1.Text ,hours, www3, www4);
                //            if (state1 == "Success")
                //            {
                //                id1.Text = "0";
                //            }
                //        }
                //    }
                //    catch
                //    {
                //        state1 = "Fail";
                //    }
                //} else { if (id1.Text != "0") { try { string x = oi.deloil(Convert.ToInt32(Convert.ToInt32(id1.Text))); if (x == "Success") { id1.Text = "0"; } else { MessageBox.Show("Can Not Delete " + label27.Text + " Please Delete it (if Exist) From Equipment Info"); } } catch {  MessageBox.Show("Can Not Delete " + label27.Text + " Please Delete it (if Exist) From Equipment Info"); } }  }
                if (checkBox2.Checked)
                {
                    try
                    {
                        if (id2.Text == "0")
                        {
                            txt_oil_id2.Text = "";
                            if (radioButton3.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton4.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string wwwq = textBox4.Text + "<#>" + textBox5.Text + "<#>" + textBox6.Text;
                            //state2 = oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label28.Text, textBox1.Text
                            //, Convert.ToDecimal(textBox2.Text), Convert.ToInt32(textBox3.Text), dateTimePicker1.Value,
                            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, www3, www4);
                            if (state2 == "Success")
                            {
                                id2.Text = "0";
                            }
                        }
                        else
                        {
                            txt_oil_id2.Text = "";
                            if (radioButton3.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton4.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string hours = Convert.ToString(ma.get_hours_by_id(Convert.ToInt32(sta)));
                            string wwwq = textBox4.Text + "<#>" + textBox5.Text + "<#>" + textBox6.Text;
                            state2 = oi.updateoil(Convert.ToInt32(id2.Text), Convert.ToInt32(txt_equ_id.Text), label28.Text, textBox1.Text
                            , Convert.ToDecimal(textBox2.Text), Convert.ToInt32(textBox3.Text), dateTimePicker1.Value,
                            Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, lbl_type2.Text, hours, www3, www4);
                            if (state2 == "Success")
                            {
                                id2.Text = "0";
                            }
                        }
                    }
                    catch
                    {
                        state2 = "Fail";
                    }
                }
                else { if (id2.Text != "0") { try { string x = oi.deloil(Convert.ToInt32(Convert.ToInt32(id2.Text))); if (x == "Success") { id2.Text = "0"; } else { MessageBox.Show("Can Not Delete " + label28.Text + " Please Delete it (if Exist) From Equipment Info"); } } catch { MessageBox.Show("Can Not Delete " + label28.Text + " Please Delete it (if Exist) From Equipment Info"); } } }
                if (checkBox3.Checked)
                {
                    try
                    {
                        if (id3.Text == "0")
                        {
                            txt_oil_id3.Text = "";
                            if (radioButton5.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton6.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string wwwq = textBox10.Text + "<#>" + textBox11.Text + "<#>" + textBox12.Text;
                            //state3 = oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label29.Text, textBox7.Text
                            //, Convert.ToDecimal(textBox8.Text), Convert.ToInt32(textBox9.Text), dateTimePicker2.Value,
                            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, www3, www4);
                            if (state3 == "Success")
                            {
                                id3.Text = "0";
                            }
                        }
                        else
                        {
                            txt_oil_id3.Text = "";
                            //if (radioButton5.Checked)
                            //{
                            //    www1 = "Add";
                            //}
                            //else if (radioButton6.Checked)
                            //{
                            //    www1 = "Active";
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            //}
                            //string hours = Convert.ToString(ma.get_hours_by_id(Convert.ToInt32(sta)));
                            //string wwwq = textBox10.Text + "<#>" + textBox11.Text + "<#>" + textBox12.Text;
                            //state3 = oi.updateoil(Convert.ToInt32(id3.Text),Convert.ToInt32(txt_equ_id.Text), label29.Text, textBox7.Text
                            //, Convert.ToDecimal(textBox8.Text), Convert.ToInt32(textBox9.Text), dateTimePicker2.Value,
                            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, lbl_type1.Text, hours, www3, www4);
                            //if (state3 == "Success")
                            //{
                            //    id3.Text = "0";
                            //}
                        }
                    }
                    catch
                    {
                        state3 = "Fail";
                    }
                }
                else { if (id3.Text != "0") { try { string x = oi.deloil(Convert.ToInt32(Convert.ToInt32(id3.Text))); if (x == "Success") { id3.Text = "0"; } else { MessageBox.Show("Can Not Delete " + label29.Text + " Please Delete it (if Exist) From Equipment Info"); } } catch { MessageBox.Show("Can Not Delete " + label29.Text + " Please Delete it (if Exist) From Equipment Info"); } } }
                if (checkBox4.Checked)
                {
                    try
                    {
                        if (id4.Text == "0")
                        {
                            txt_oil_id4.Text = "";
                            if (radioButton7.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton8.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string wwwq = textBox16.Text + "<#>" + textBox17.Text + "<#>" + textBox18.Text;
                            //state4 = oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label30.Text, textBox13.Text
                            //, Convert.ToDecimal(textBox14.Text), Convert.ToInt32(textBox15.Text), dateTimePicker3.Value,
                            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, www3, www4);
                            if (state4 == "Success")
                            {
                                id4.Text = "0";
                            }
                        }
                        else
                        {
                            txt_oil_id4.Text = "";
                            if (radioButton7.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton8.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string hours = Convert.ToString(ma.get_hours_by_id(Convert.ToInt32(sta)));
                            string wwwq = textBox16.Text + "<#>" + textBox17.Text + "<#>" + textBox18.Text;
                            state4 = oi.updateoil(Convert.ToInt32(id4.Text), Convert.ToInt32(txt_equ_id.Text), label30.Text, textBox13.Text
                            , Convert.ToDecimal(textBox14.Text), Convert.ToInt32(textBox15.Text), dateTimePicker3.Value,
                            Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, lbl_type4.Text, hours, www3, www4);
                            if (state4 == "Success")
                            {
                                id4.Text = "0";
                            }
                        }
                    }
                    catch
                    {
                        state4 = "Fail";
                    }
                }
                else { if (id4.Text != "0") { try { string x = oi.deloil(Convert.ToInt32(Convert.ToInt32(id4.Text))); if (x == "Success") { id4.Text = "0"; } else { MessageBox.Show("Can Not Delete " + label30.Text + " Please Delete it (if Exist) From Equipment Info"); } } catch { MessageBox.Show("Can Not Delete " + label30.Text + " Please Delete it (if Exist) From Equipment Info"); } } }
                if (checkBox5.Checked)
                {
                    try
                    {
                        if (id5.Text == "0")
                        {
                            txt_oil_id5.Text = "";
                            if (radioButton9.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton10.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string wwwq = textBox22.Text + "<#>" + textBox23.Text + "<#>" + textBox24.Text;
                            //state5 = oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label37.Text, textBox19.Text
                            //, Convert.ToDecimal(textBox20.Text), Convert.ToInt32(textBox21.Text), dateTimePicker4.Value,
                            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, www3, www4);
                            if (state5 == "Success")
                            {
                                id5.Text = "0";
                            }
                        }
                        else
                        {
                            txt_oil_id5.Text = "";
                            if (radioButton9.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton10.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string hours = Convert.ToString(ma.get_hours_by_id(Convert.ToInt32(sta)));
                            string wwwq = textBox22.Text + "<#>" + textBox23.Text + "<#>" + textBox24.Text;
                            state5 = oi.updateoil(Convert.ToInt32(id5.Text), Convert.ToInt32(txt_equ_id.Text), label37.Text, textBox19.Text
                            , Convert.ToDecimal(textBox20.Text), Convert.ToInt32(textBox21.Text), dateTimePicker4.Value,
                            Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, lbl_type5.Text, hours, www3, www4);
                            if (state5 == "Success")
                            {
                                id5.Text = "0";
                            }
                        }
                    }
                    catch
                    {
                        state5 = "Fail";
                    }
                }
                else { if (id5.Text != "0") { try { string x = oi.deloil(Convert.ToInt32(Convert.ToInt32(id5.Text))); if (x == "Success") { id5.Text = "0"; } else { MessageBox.Show("Can Not Delete " + label37.Text + " Please Delete it (if Exist) From Equipment Info"); } } catch { MessageBox.Show("Can Not Delete " + label37.Text + " Please Delete it (if Exist) From Equipment Info"); } } }
                if (checkBox6.Checked)
                {
                    try
                    {
                        if (id6.Text == "0")
                        {
                            txt_oil_id6.Text = "";
                            if (radioButton11.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton12.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string wwwq = textBox29.Text + "<#>" + textBox30.Text + "<#>" + textBox31.Text;
                            //state6 = oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label13.Text, textBox26.Text
                            //, Convert.ToDecimal(textBox27.Text), Convert.ToInt32(textBox28.Text), dateTimePicker6.Value,
                            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, www3, www4);
                            if (state6 == "Success")
                            {
                                id6.Text = "0";
                            }
                        }
                        else
                        {
                            txt_oil_id6.Text = "";
                            if (radioButton11.Checked)
                            {
                                www1 = "Add";
                            }
                            else if (radioButton12.Checked)
                            {
                                www1 = "Active";
                            }
                            else
                            {
                                MessageBox.Show("Please Choose Add Amount or totaly Changed Condition For Modified Oil");
                            }
                            string hours = Convert.ToString(ma.get_hours_by_id(Convert.ToInt32(sta)));
                            string wwwq = textBox29.Text + "<#>" + textBox30.Text + "<#>" + textBox31.Text;
                            state6 = oi.updateoil(Convert.ToInt32(id6.Text), Convert.ToInt32(txt_equ_id.Text), label13.Text, textBox26.Text
                            , Convert.ToDecimal(textBox27.Text), Convert.ToInt32(textBox28.Text), dateTimePicker6.Value,
                            Convert.ToInt32(txt_oil_user_id.Text), wwwq, www1, lbl_type6.Text, hours, www3, www4);
                            if (state6 == "Success")
                            {
                                id6.Text = "0";
                            }
                        }
                    }
                    catch
                    {
                        state6 = "Fail";
                    }
                }
                else { if (id6.Text != "0") { try { string x = oi.deloil(Convert.ToInt32(Convert.ToInt32(id6.Text))); if (x == "Success") { id6.Text = "0"; } else { MessageBox.Show("Can Not Delete " + label13.Text + " Please Delete it (if Exist) From Equipment Info"); } } catch { MessageBox.Show("Can Not Delete " + label13.Text + " Please Delete it (if Exist) From Equipment Info"); } } }
                if (checkBox7.Checked)
                {
                    //try
                    //{
                    //    if (id7.Text == "0")
                    //    {                    
                    //        state7 = fu.Addfuel(Convert.ToInt32(txt_equ_id.Text), comboBox2.Text, sta,
                    //           Convert.ToInt32(textBox33.Text) , Convert.ToInt32(textBox34.Text),
                    //         dateTimePicker7.Value,
                    //        Convert.ToInt32(txt_oil_user_id.Text), "Add");
                    //    }
                    //    else
                    //    {
                    //        state7 = fu.updatefuel(Convert.ToInt32(id7.Text), Convert.ToInt32(txt_equ_id.Text), comboBox2.Text, sta,
                    //           Convert.ToInt32(textBox33.Text), Convert.ToInt32(textBox34.Text),
                    //         dateTimePicker7.Value,
                    //        Convert.ToInt32(txt_oil_user_id.Text), "Add");
                    //    }
                    //    if (state7 == "Success")
                    //    {
                    //        id7.Text = "0"; txt_oil_id7.Text = "";
                    //    }
                    //}
                    //catch
                    //{
                    //    state7 = "Fail";
                    //}
                }
                else { if (id7.Text != "0") { try { string x = fu.delfuel(Convert.ToInt32(Convert.ToInt32(id7.Text))); if (x == "Success") { id7.Text = "0"; } else { MessageBox.Show("Can Not Delete Fuel Data Please Try Again Or Restart Software"); } } catch { MessageBox.Show("Can Not Delete Fuel Data Please Try Again Or Restart Software"); } } }


                if (checkBox1.Checked)
                {
                    if (state1 != "Success") { MessageBox.Show("Please Recheck Engine Oil Data"); cond = "False"; }
                    //else 
                    //{ 
                    //    checkBox1.CheckedChanged -= new System.EventHandler(checkBox1_CheckedChanged); 
                    //    checkBox1.Checked = false;
                    //    radioButton1.Checked = false;
                    //    radioButton2.Checked = false;
                    //    date_oil_ins1.Value = DateTime.Now;
                    //    txt_oil_ins2.Text = "";
                    //    txt_oil_ins3.Text = "";
                    //    txt_oil_ins4.Text = "";
                    //    txt_oil_rep_ins1.Text = "";
                    //    txt_oil_rep_ins2.Text = "";
                    //    txt_oil_rep_ins3.Text = "";
                    //    panel3.Enabled = false;
                    //    checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
                    //}
                }
                if (checkBox2.Checked)
                {
                    if (state2 != "Success") { MessageBox.Show("Please Recheck Transmission Oil Data"); cond = "False"; }
                    else
                    {
                        checkBox2.CheckedChanged -= new System.EventHandler(checkBox2_CheckedChanged);
                        checkBox2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        dateTimePicker1.Value = DateTime.Now;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        panel4.Enabled = false;
                        checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
                    }
                }
                if (checkBox3.Checked)
                {
                    if (state3 != "Success") { MessageBox.Show("Please Recheck Hydrailic Oil Data"); cond = "False"; }
                    else
                    {
                        checkBox3.CheckedChanged -= new System.EventHandler(checkBox3_CheckedChanged);
                        checkBox3.Checked = false;
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        dateTimePicker2.Value = DateTime.Now;
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = ""; panel5.Enabled = false;
                        checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
                    }
                }
                if (checkBox4.Checked)
                {
                    if (state4 != "Success") { MessageBox.Show("Please Recheck Differential Oil Data"); cond = "False"; }
                    else
                    {
                        checkBox4.CheckedChanged -= new System.EventHandler(checkBox4_CheckedChanged);
                        checkBox4.Checked = false; radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        dateTimePicker3.Value = DateTime.Now;
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        textBox16.Text = "";
                        textBox17.Text = "";
                        textBox18.Text = "";
                        panel6.Enabled = false;
                        checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
                    }
                }
                if (checkBox5.Checked)
                {
                    if (state5 != "Success") { MessageBox.Show("Please Recheck Final Drive Oil Data"); cond = "False"; }
                    else
                    {
                        checkBox5.CheckedChanged -= new System.EventHandler(checkBox5_CheckedChanged);
                        checkBox5.Checked = false; radioButton9.Checked = false;
                        radioButton10.Checked = false;
                        textBox19.Text = "";
                        textBox20.Text = "";
                        textBox21.Text = "";
                        textBox22.Text = "";
                        textBox23.Text = "";
                        textBox24.Text = "";
                        dateTimePicker4.Value = DateTime.Now;
                        panel7.Enabled = false;
                        checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
                    }
                }
                if (checkBox6.Checked)
                {
                    if (state6 != "Success") { MessageBox.Show("Please Recheck Coolant Water Data"); cond = "False"; }
                    else
                    {
                        checkBox6.CheckedChanged -= new System.EventHandler(checkBox6_CheckedChanged);
                        checkBox6.Checked = false; radioButton11.Checked = false;
                        radioButton12.Checked = false;
                        textBox26.Text = "";
                        textBox27.Text = "";
                        textBox28.Text = "";
                        textBox29.Text = "";
                        textBox30.Text = "";
                        textBox31.Text = "";
                        dateTimePicker6.Value = DateTime.Now;
                        panel8.Enabled = false;
                        checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
                    }
                }

                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false)
                {
                    if (cond != "true")
                    {
                        MessageBox.Show("Please Recheck Remaining data and Press (Step 3) Again");
                        cond = "true";
                    }
                    else
                    {
                        //MessageBox.Show("Step 2 Finished" + "\n" + "All Data has been Saved"+"\n"+"Step 3 Will start once Oil Dialog Closed");
                        btn_oil_ins.Enabled = false;
                        this.Close();
                    }
                }
                else if (cond != "true")
                {
                    MessageBox.Show("Please Recheck Remaining data and Press (Step 3) Again");
                    cond = "true";
                }
            }
            catch
            {
                MessageBox.Show("Please Recheck your inputs");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    if (oi.Find_oil_with_main(sta, "Engine Oil"))
            //    {
            //        panel3.Enabled = true;
            //        txt_oil_id1.Text = oi.oil_id.ToString();
            //        txt_equ_id.Text = oi.equ_id.ToString();
            //        txt_oil_ins2.Text = oi.oil_name.ToString();
            //        txt_oil_ins3.Text = oi.oil_cap.ToString();
            //        txt_oil_ins4.Text = oi.oil_cost.ToString();
            //        lbl_type1.Text= oi.main_type.ToString();
            //        date_oil_ins1.Value = Convert.ToDateTime(oi.oil_date.ToString());
            //        if (oi.main_type == "Active")
            //        {
            //            radioButton2.Checked = true;
            //        }
            //        else if (oi.main_type == "Add")
            //        {
            //            radioButton1.Checked = true;
            //        }
            //        string h = oi.oil_replacements.ToString();
            //        string[] lines = Regex.Split(h, "<#>");
            //        if (lines.Length == 3)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = lines[1];
            //            txt_oil_rep_ins3.Text = lines[2];
            //        }
            //        else if (lines.Length == 2)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = lines[1];
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //        else if (lines.Length == 1)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = "";
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //        else
            //        {
            //            txt_oil_rep_ins1.Text = "";
            //            txt_oil_rep_ins2.Text = "";
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //    }
            //    else if (oi.Find_active_oil_with_equ(Convert.ToInt32(txt_equ_id.Text), label27.Text))
            //    {
            //        panel3.Enabled = true;
            //        txt_oil_id1.Text = oi.oil_id.ToString();
            //        txt_equ_id.Text = oi.equ_id.ToString();
            //        txt_oil_ins2.Text = oi.oil_name.ToString();
            //        txt_oil_ins3.Text = oi.oil_cap.ToString();
            //        txt_oil_ins4.Text = oi.oil_cost.ToString();
            //        date_oil_ins1.Value = DateTime.Now;
            //        string h = oi.oil_replacements.ToString();
            //        string[] lines = Regex.Split(h, "<#>");
            //        if (lines.Length == 3)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = lines[1];
            //            txt_oil_rep_ins3.Text = lines[2];
            //        }
            //        else if (lines.Length == 2)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = lines[1];
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //        else if (lines.Length == 1)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = "";
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //        else
            //        {
            //            txt_oil_rep_ins1.Text = "";
            //            txt_oil_rep_ins2.Text = "";
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //    }
            //    else if (oi.Find_Catalogue_with_type(Convert.ToInt32(txt_equ_id.Text), label27.Text))
            //    {
            //        panel3.Enabled = true;
            //        txt_oil_id1.Text = oi.oil_id.ToString();
            //        txt_equ_id.Text = oi.equ_id.ToString();
            //        txt_oil_ins2.Text = oi.oil_name.ToString();
            //        txt_oil_ins3.Text = oi.oil_cap.ToString();
            //        txt_oil_ins4.Text = oi.oil_cost.ToString();
            //        date_oil_ins1.Value = DateTime.Now;
            //        string h = oi.oil_replacements.ToString();
            //        string[] lines = Regex.Split(h, "<#>");
            //        if (lines.Length == 3)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = lines[1];
            //            txt_oil_rep_ins3.Text = lines[2];
            //        }
            //        else if (lines.Length == 2)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = lines[1];
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //        else if (lines.Length == 1)
            //        {
            //            txt_oil_rep_ins1.Text = lines[0];
            //            txt_oil_rep_ins2.Text = "";
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //        else
            //        {
            //            txt_oil_rep_ins1.Text = "";
            //            txt_oil_rep_ins2.Text = "";
            //            txt_oil_rep_ins3.Text = "";
            //        }
            //    }
            //    else
            //    {
            //        radioButton1.Checked = false;
            //        radioButton2.Checked = false;
            //        date_oil_ins1.Value = DateTime.Now;
            //        txt_oil_ins2.Text = "";
            //        txt_oil_ins3.Text = "";
            //        txt_oil_ins4.Text = "";
            //        txt_oil_rep_ins1.Text = "";
            //        txt_oil_rep_ins2.Text = "";
            //        txt_oil_rep_ins3.Text = "";
            //        panel3.Enabled = false;
            //        DialogResult dialogResult = MessageBox.Show("This Equipment Doesnt have this Oil Type" + "\n" + "Do You Want to Add New Oil Type?", "No Oil Data Yet", MessageBoxButtons.YesNo);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            panel3.Enabled = false;
            //            panel4.Enabled = false;
            //            panel5.Enabled = false;
            //            panel6.Enabled = false;
            //            panel7.Enabled = false;
            //            panel8.Enabled = false;
            //            panel11.Enabled = false;
            //            btn_oil_ins.Enabled = false;
            //            pnl11.Visible = false;
            //            pnl1.Visible = true;
            //            txt_oil_id1.Text = "new";
            //            panel3.Enabled = true;
            //            checkBox2.Enabled = false;
            //            checkBox3.Enabled = false;
            //            checkBox4.Enabled = false;
            //            checkBox5.Enabled = false;
            //            checkBox6.Enabled = false;
            //            checkBox7.Enabled = false;
            //            label4.Text = "Refill Amount";

            //        }
            //        if (dialogResult == DialogResult.No)
            //        {
            //            panel3.Enabled = false;
            //            checkBox1.CheckedChanged -= new System.EventHandler(checkBox1_CheckedChanged);
            //            checkBox1.Checked = false;
            //            checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
            //        }
            //    }
            //}
            //else
            //{
            //    if (id1.Text != "0")
            //    {
            //        DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Oil Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            radioButton1.Checked = false;
            //            radioButton2.Checked = false;
            //            date_oil_ins1.Value = DateTime.Now;
            //            txt_oil_ins2.Text = "";
            //            txt_oil_ins3.Text = "";
            //            txt_oil_ins4.Text = "";
            //            txt_oil_rep_ins1.Text = "";
            //            txt_oil_rep_ins2.Text = "";
            //            txt_oil_rep_ins3.Text = "";
            //            txt_oil_id1.Text = "";
            //            panel3.Enabled = false;
            //        }
            //        if (dialogResult == DialogResult.No)
            //        {
            //            checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
            //            checkBox1.Checked = true;
            //            checkBox1.CheckedChanged -= new System.EventHandler(checkBox1_CheckedChanged);
            //            return;
            //        }
            //    }
            //    else if (pnl1.Visible == true)
            //    {
            //        //panel3.Enabled = true;
            //        //panel4.Enabled = true;
            //        //panel5.Enabled = true;
            //        //panel6.Enabled = true;
            //        //panel7.Enabled = true;
            //        //panel8.Enabled = true;
            //        //panel11.Enabled = true;
            //        btn_oil_ins.Enabled = true;
            //        pnl11.Visible = true;
            //        pnl1.Visible = false;
            //        txt_oil_id1.Text = "new";
            //        panel3.Enabled = false;
            //        checkBox2.Enabled = true;
            //        checkBox3.Enabled = true;
            //        checkBox4.Enabled = true;
            //        checkBox5.Enabled = true;
            //        checkBox6.Enabled = true;
            //        checkBox7.Enabled = true; label4.Text = "Amount";
            //        if (checkBox1.Checked == true)
            //        {
            //            panel3.Enabled = true;
            //        }
            //        if (checkBox2.Checked == true)
            //        {
            //            panel4.Enabled = true;
            //        }
            //        if (checkBox3.Checked == true)
            //        {
            //            panel5.Enabled = true;
            //        }
            //        if (checkBox4.Checked == true)
            //        {
            //            panel6.Enabled = true;
            //        }
            //        if (checkBox5.Checked == true)
            //        {
            //            panel7.Enabled = true;
            //        }
            //        if (checkBox6.Checked == true)
            //        {
            //            panel8.Enabled = true;
            //        }
            //        if (checkBox7.Checked == true)
            //        {
            //            panel11.Enabled = true;
            //        }
            //    }
            //    else
            //    {
            //        radioButton1.Checked = false;
            //        radioButton2.Checked = false;
            //        date_oil_ins1.Value = DateTime.Now;
            //        txt_oil_ins2.Text = "";
            //        txt_oil_ins3.Text = "";
            //        txt_oil_ins4.Text = "";
            //        txt_oil_rep_ins1.Text = "";
            //        txt_oil_rep_ins2.Text = "";
            //        txt_oil_rep_ins3.Text = ""; txt_oil_id1.Text = "";
            //        panel3.Enabled = false;
            //    }
            //}
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (false)
                {
                    panel4.Enabled = true;
                    txt_oil_id2.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox1.Text = oi.oil_name.ToString();
                    textBox2.Text = oi.oil_cap.ToString();
                    textBox3.Text = oi.oil_cost.ToString();
                    lbl_type2.Text = oi.main_type.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(oi.oil_date.ToString());
                    if (oi.main_type == "Active")
                    {
                        radioButton4.Checked = true;
                    }
                    else if (oi.main_type == "Add")
                    {
                        radioButton3.Checked = true;
                    }
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = lines[1];
                        textBox6.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = lines[1];
                        textBox6.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                    else
                    {
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
                else if (oi.Find_active_oil_with_equ(Convert.ToInt32(txt_equ_id.Text), label28.Text))
                {
                    panel4.Enabled = true;
                    txt_oil_id2.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox1.Text = oi.oil_name.ToString();
                    textBox2.Text = oi.oil_cap.ToString();
                    textBox3.Text = oi.oil_cost.ToString();
                    dateTimePicker1.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = lines[1];
                        textBox6.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = lines[1];
                        textBox6.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                    else
                    {
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
                else if (oi.Find_Catalogue_with_type(Convert.ToInt32(txt_equ_id.Text), label28.Text))
                {
                    panel4.Enabled = true;
                    txt_oil_id2.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox1.Text = oi.oil_name.ToString();
                    textBox2.Text = oi.oil_cap.ToString();
                    textBox3.Text = oi.oil_cost.ToString();
                    dateTimePicker1.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = lines[1];
                        textBox6.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = lines[1];
                        textBox6.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox4.Text = lines[0];
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                    else
                    {
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = ""; radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    panel4.Enabled = false;
                    DialogResult dialogResult = MessageBox.Show("This Equipment Doesnt have this Oil Type" + "\n" + "Do You Want to Add New Oil Type?", "No Oil Data Yet", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // panel3.Enabled = false;
                        panel4.Enabled = true;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                        panel11.Enabled = false;
                        btn_oil_ins.Enabled = false;
                        pnl22.Visible = false;
                        pnl2.Visible = true;
                        panel4.Enabled = true;
                        pnl2.Visible = true;
                        txt_oil_id2.Text = "new";
                        checkBox1.Enabled = false;
                        checkBox3.Enabled = false;
                        checkBox4.Enabled = false;
                        checkBox5.Enabled = false;
                        checkBox6.Enabled = false;
                        checkBox7.Enabled = false; label12.Text = "Refill Amount";
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        panel4.Enabled = false;
                        checkBox2.CheckedChanged -= new System.EventHandler(checkBox2_CheckedChanged);
                        checkBox2.Checked = false;
                        checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
                    }
                }
            }
            else
            {
                if (id2.Text != "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Oil Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        dateTimePicker1.Value = DateTime.Now;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = ""; txt_oil_id2.Text = "";
                        panel4.Enabled = false;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        checkBox2.CheckedChanged -= new System.EventHandler(checkBox2_CheckedChanged);
                        checkBox2.Checked = true;
                        checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
                        return;
                    }
                }
                else if (pnl2.Visible == true)
                {
                    //panel3.Enabled = true;
                    //panel4.Enabled = false;
                    //panel5.Enabled = true;
                    //panel6.Enabled = true;
                    //panel7.Enabled = true;
                    //panel8.Enabled = true;
                    //panel11.Enabled = true;
                    btn_oil_ins.Enabled = true;
                    pnl22.Visible = true;
                    pnl2.Visible = false;
                    panel4.Enabled = false;
                    pnl2.Visible = false;
                    txt_oil_id2.Text = "new";
                    checkBox1.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox7.Enabled = true; label12.Text = "Amount";
                    //if (checkBox1.Checked == true)
                    //{
                    //    panel3.Enabled = true;
                    //}
                    if (checkBox2.Checked == true)
                    {
                        panel4.Enabled = true;
                    }
                    if (checkBox3.Checked == true)
                    {
                        panel5.Enabled = true;
                    }
                    if (checkBox4.Checked == true)
                    {
                        panel6.Enabled = true;
                    }
                    if (checkBox5.Checked == true)
                    {
                        panel7.Enabled = true;
                    }
                    if (checkBox6.Checked == true)
                    {
                        panel8.Enabled = true;
                    }
                    if (checkBox7.Checked == true)
                    {
                        panel11.Enabled = true;
                    }
                }
                else
                {
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    dateTimePicker1.Value = DateTime.Now;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = ""; txt_oil_id2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    panel4.Enabled = false;
                }
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (false)
                {
                    panel5.Enabled = true;
                    txt_oil_id3.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox7.Text = oi.oil_name.ToString();
                    textBox8.Text = oi.oil_cap.ToString();
                    textBox9.Text = oi.oil_cost.ToString();
                    lbl_type3.Text = oi.main_type.ToString();
                    dateTimePicker2.Value = Convert.ToDateTime(oi.oil_date.ToString());
                    if (oi.main_type == "Active")
                    {
                        radioButton6.Checked = true;
                    }
                    else if (oi.main_type == "Add")
                    {
                        radioButton5.Checked = true;
                    }
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = lines[1];
                        textBox12.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = lines[1];
                        textBox12.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = "";
                        textBox12.Text = "";
                    }
                    else
                    {
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                    }
                }
                else if (oi.Find_active_oil_with_equ(Convert.ToInt32(txt_equ_id.Text), label29.Text))
                {
                    panel5.Enabled = true;
                    txt_oil_id3.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox7.Text = oi.oil_name.ToString();
                    textBox8.Text = oi.oil_cap.ToString();
                    textBox9.Text = oi.oil_cost.ToString();
                    dateTimePicker2.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = lines[1];
                        textBox12.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = lines[1];
                        textBox12.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = "";
                        textBox12.Text = "";
                    }
                    else
                    {
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                    }
                }
                else if (oi.Find_Catalogue_with_type(Convert.ToInt32(txt_equ_id.Text), label29.Text))
                {
                    panel5.Enabled = true;
                    txt_oil_id3.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox7.Text = oi.oil_name.ToString();
                    textBox8.Text = oi.oil_cap.ToString();
                    textBox9.Text = oi.oil_cost.ToString();
                    dateTimePicker2.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = lines[1];
                        textBox12.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = lines[1];
                        textBox12.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox10.Text = lines[0];
                        textBox11.Text = "";
                        textBox12.Text = "";
                    }
                    else
                    {
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = "";
                    }
                }
                else
                {
                    dateTimePicker2.Value = DateTime.Now;
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    panel5.Enabled = false; radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    DialogResult dialogResult = MessageBox.Show("This Equipment Doesnt have this Oil Type" + "\n" + "Do You Want to Add New Oil Type?", "No Oil Data Yet", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                        panel11.Enabled = false;
                        btn_oil_ins.Enabled = false;
                        pnl33.Visible = false;
                        pnl3.Visible = true;
                        panel5.Enabled = true;
                        txt_oil_id3.Text = "new";
                        checkBox1.Enabled = false;
                        checkBox2.Enabled = false;
                        checkBox4.Enabled = false;
                        checkBox5.Enabled = false;
                        checkBox6.Enabled = false;
                        checkBox7.Enabled = false; label23.Text = "Refill Amount";
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        panel5.Enabled = false;
                        checkBox3.CheckedChanged -= new System.EventHandler(checkBox3_CheckedChanged);
                        checkBox3.Checked = false;
                        checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
                    }
                }
            }
            else
            {
                if (id3.Text != "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Oil Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        radioButton5.Checked = false;
                        radioButton6.Checked = false;
                        dateTimePicker2.Value = DateTime.Now;
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";
                        textBox11.Text = "";
                        textBox12.Text = ""; txt_oil_id3.Text = "";
                        panel5.Enabled = false;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        checkBox3.CheckedChanged -= new System.EventHandler(checkBox3_CheckedChanged);
                        checkBox3.Checked = true;
                        checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
                        return;
                    }
                }
                else if (pnl3.Visible == true)
                {
                    //panel3.Enabled = true;
                    //panel4.Enabled = true;
                    //panel5.Enabled = true;
                    //panel6.Enabled = true;
                    //panel7.Enabled = true;
                    //panel8.Enabled = true;
                    //panel11.Enabled = true;
                    btn_oil_ins.Enabled = true;
                    pnl33.Visible = true;
                    pnl3.Visible = false;
                    panel5.Enabled = false;
                    txt_oil_id3.Text = "new";
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true; label23.Text = "Amount";
                    checkBox7.Enabled = true;
                    //if (checkBox1.Checked == true)
                    //{
                    //    panel3.Enabled = true;
                    //}
                    if (checkBox2.Checked == true)
                    {
                        panel4.Enabled = true;
                    }
                    if (checkBox3.Checked == true)
                    {
                        panel5.Enabled = true;
                    }
                    if (checkBox4.Checked == true)
                    {
                        panel6.Enabled = true;
                    }
                    if (checkBox5.Checked == true)
                    {
                        panel7.Enabled = true;
                    }
                    if (checkBox6.Checked == true)
                    {
                        panel8.Enabled = true;
                    }
                    if (checkBox7.Checked == true)
                    {
                        panel11.Enabled = true;
                    }
                }
                else
                {
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    dateTimePicker2.Value = DateTime.Now;
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = ""; txt_oil_id3.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    panel5.Enabled = false;
                }
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (false)
                {
                    panel6.Enabled = true;
                    txt_oil_id4.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox13.Text = oi.oil_name.ToString();
                    textBox14.Text = oi.oil_cap.ToString();
                    textBox15.Text = oi.oil_cost.ToString();
                    lbl_type4.Text = oi.main_type.ToString();
                    dateTimePicker3.Value = Convert.ToDateTime(oi.oil_date.ToString());
                    if (oi.main_type == "Active")
                    {
                        radioButton8.Checked = true;
                    }
                    else if (oi.main_type == "Add")
                    {
                        radioButton7.Checked = true;
                    }
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = lines[1];
                        textBox18.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = lines[1];
                        textBox18.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = "";
                        textBox18.Text = "";
                    }
                    else
                    {
                        textBox16.Text = "";
                        textBox17.Text = "";
                        textBox18.Text = "";
                    }
                }
                else if (oi.Find_active_oil_with_equ(Convert.ToInt32(txt_equ_id.Text), label30.Text))
                {
                    panel6.Enabled = true;
                    txt_oil_id4.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox13.Text = oi.oil_name.ToString();
                    textBox14.Text = oi.oil_cap.ToString();
                    textBox15.Text = oi.oil_cost.ToString();
                    dateTimePicker3.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = lines[1];
                        textBox18.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = lines[1];
                        textBox18.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = "";
                        textBox18.Text = "";
                    }
                    else
                    {
                        textBox16.Text = "";
                        textBox17.Text = "";
                        textBox18.Text = "";
                    }
                }
                else if (oi.Find_Catalogue_with_type(Convert.ToInt32(txt_equ_id.Text), label30.Text))
                {
                    panel6.Enabled = true;
                    txt_oil_id4.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox13.Text = oi.oil_name.ToString();
                    textBox14.Text = oi.oil_cap.ToString();
                    textBox15.Text = oi.oil_cost.ToString();
                    dateTimePicker3.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = lines[1];
                        textBox18.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = lines[1];
                        textBox18.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox16.Text = lines[0];
                        textBox17.Text = "";
                        textBox18.Text = "";
                    }
                    else
                    {
                        textBox16.Text = "";
                        textBox17.Text = "";
                        textBox18.Text = "";
                    }
                }
                else
                {
                    dateTimePicker3.Value = DateTime.Now;
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox16.Text = "";
                    textBox17.Text = "";
                    textBox18.Text = "";
                    panel6.Enabled = false; radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    DialogResult dialogResult = MessageBox.Show("This Equipment Doesnt have this Oil Type" + "\n" + "Do You Want to Add New Oil Type?", "No Oil Data Yet", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                        panel11.Enabled = false;
                        btn_oil_ins.Enabled = false;
                        pnl4.Visible = true; pnl44.Visible = false;
                        panel6.Enabled = true;
                        txt_oil_id4.Text = "new";
                        checkBox1.Enabled = false;
                        checkBox2.Enabled = false;
                        checkBox3.Enabled = false;
                        checkBox5.Enabled = false;
                        checkBox6.Enabled = false;
                        checkBox7.Enabled = false; label33.Text = "Refill Amount";
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        panel6.Enabled = false;
                        checkBox4.CheckedChanged -= new System.EventHandler(checkBox4_CheckedChanged);
                        checkBox4.Checked = false;
                        checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
                    }
                }
            }
            else
            {
                if (id4.Text != "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Oil Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                        dateTimePicker3.Value = DateTime.Now;
                        textBox13.Text = "";
                        textBox14.Text = "";
                        textBox15.Text = "";
                        textBox16.Text = "";
                        textBox17.Text = "";
                        textBox18.Text = ""; txt_oil_id4.Text = "";
                        panel6.Enabled = false;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        checkBox4.CheckedChanged -= new System.EventHandler(checkBox4_CheckedChanged);
                        checkBox4.Checked = true;
                        checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
                        return;
                    }
                }
                else if (pnl4.Visible == true)
                {
                    //panel3.Enabled = true;
                    //panel4.Enabled = true;
                    //panel5.Enabled = true;
                    //panel6.Enabled = true;
                    //panel7.Enabled = true;
                    //panel8.Enabled = true;
                    //panel11.Enabled = true;
                    btn_oil_ins.Enabled = true;
                    pnl4.Visible = false; pnl44.Visible = true;
                    panel6.Enabled = false;
                    txt_oil_id4.Text = "new";
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox7.Enabled = true; label33.Text = "Amount";
                    //if (checkBox1.Checked == true)
                    //{
                    //    panel3.Enabled = true;
                    //}
                    if (checkBox2.Checked == true)
                    {
                        panel4.Enabled = true;
                    }
                    if (checkBox3.Checked == true)
                    {
                        panel5.Enabled = true;
                    }
                    if (checkBox4.Checked == true)
                    {
                        panel6.Enabled = true;
                    }
                    if (checkBox5.Checked == true)
                    {
                        panel7.Enabled = true;
                    }
                    if (checkBox6.Checked == true)
                    {
                        panel8.Enabled = true;
                    }
                    if (checkBox7.Checked == true)
                    {
                        panel11.Enabled = true;
                    }
                }
                else
                {
                    radioButton7.Checked = false;
                    radioButton8.Checked = false;
                    dateTimePicker3.Value = DateTime.Now;
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox16.Text = "";
                    textBox17.Text = "";
                    textBox18.Text = ""; txt_oil_id4.Text = "";
                    panel6.Enabled = false;
                }
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (false)
                {
                    panel7.Enabled = true;
                    txt_oil_id5.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox19.Text = oi.oil_name.ToString();
                    textBox20.Text = oi.oil_cap.ToString();
                    textBox21.Text = oi.oil_cost.ToString();
                    lbl_type5.Text = oi.main_type.ToString();
                    dateTimePicker4.Value = Convert.ToDateTime(oi.oil_date.ToString());
                    if (oi.main_type == "Active")
                    {
                        radioButton10.Checked = true;
                    }
                    else if (oi.main_type == "Add")
                    {
                        radioButton9.Checked = true;
                    }
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = lines[1];
                        textBox24.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = lines[1];
                        textBox24.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = "";
                        textBox24.Text = "";
                    }
                    else
                    {
                        textBox22.Text = "";
                        textBox23.Text = "";
                        textBox24.Text = "";
                    }
                }
                else if (oi.Find_active_oil_with_equ(Convert.ToInt32(txt_equ_id.Text), label37.Text))
                {
                    panel7.Enabled = true;
                    txt_oil_id5.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox19.Text = oi.oil_name.ToString();
                    textBox20.Text = oi.oil_cap.ToString();
                    textBox21.Text = oi.oil_cost.ToString();
                    dateTimePicker4.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = lines[1];
                        textBox24.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = lines[1];
                        textBox24.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = "";
                        textBox24.Text = "";
                    }
                    else
                    {
                        textBox22.Text = "";
                        textBox23.Text = "";
                        textBox24.Text = "";
                    }
                }
                else if (oi.Find_Catalogue_with_type(Convert.ToInt32(txt_equ_id.Text), label37.Text))
                {
                    panel7.Enabled = true;
                    txt_oil_id5.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox19.Text = oi.oil_name.ToString();
                    textBox20.Text = oi.oil_cap.ToString();
                    textBox21.Text = oi.oil_cost.ToString();
                    dateTimePicker4.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = lines[1];
                        textBox24.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = lines[1];
                        textBox24.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox22.Text = lines[0];
                        textBox23.Text = "";
                        textBox24.Text = "";
                    }
                    else
                    {
                        textBox22.Text = "";
                        textBox23.Text = "";
                        textBox24.Text = "";
                    }
                }
                else
                {
                    dateTimePicker4.Value = DateTime.Now;
                    textBox19.Text = "";
                    textBox20.Text = "";
                    textBox21.Text = "";
                    textBox22.Text = "";
                    textBox23.Text = "";
                    textBox24.Text = "";
                    panel7.Enabled = false; radioButton9.Checked = false;
                    radioButton10.Checked = false;
                    DialogResult dialogResult = MessageBox.Show("This Equipment Doesnt have this Oil Type" + "\n" + "Do You Want to Add New Oil Type?", "No Oil Data Yet", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                        panel11.Enabled = false;
                        btn_oil_ins.Enabled = false;
                        pnl5.Visible = true;
                        pnl55.Visible = false;
                        panel7.Enabled = true;
                        txt_oil_id5.Text = "new";
                        checkBox1.Enabled = false;
                        checkBox2.Enabled = false;
                        checkBox3.Enabled = false;
                        checkBox4.Enabled = false;
                        checkBox6.Enabled = false;
                        checkBox7.Enabled = false; label42.Text = "Refill Amount";
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        panel7.Enabled = false;
                        checkBox5.CheckedChanged -= new System.EventHandler(checkBox5_CheckedChanged);
                        checkBox5.Checked = false;
                        checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
                    }

                }
            }
            else
            {
                if (id5.Text != "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Oil Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        radioButton9.Checked = false;
                        radioButton10.Checked = false;
                        textBox19.Text = "";
                        textBox20.Text = "";
                        textBox21.Text = "";
                        textBox22.Text = "";
                        textBox23.Text = "";
                        textBox24.Text = ""; txt_oil_id5.Text = "";
                        dateTimePicker4.Value = DateTime.Now;
                        panel7.Enabled = false;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        checkBox5.CheckedChanged -= new System.EventHandler(checkBox5_CheckedChanged);
                        checkBox5.Checked = true;
                        checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
                        return;
                    }
                }
                else if (pnl5.Visible == true)
                {
                    //panel3.Enabled = true;
                    //panel4.Enabled = true;
                    //panel5.Enabled = true;
                    //panel6.Enabled = true;
                    //panel7.Enabled = true;
                    //panel8.Enabled = true;
                    //panel11.Enabled = true;
                    btn_oil_ins.Enabled = true;
                    pnl5.Visible = false;
                    pnl55.Visible = true;
                    panel7.Enabled = false;
                    txt_oil_id5.Text = "new";
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox7.Enabled = true; label42.Text = "Amount";
                    //if (checkBox1.Checked == true)
                    //{
                    //    panel3.Enabled = true;
                    //}
                    if (checkBox2.Checked == true)
                    {
                        panel4.Enabled = true;
                    }
                    if (checkBox3.Checked == true)
                    {
                        panel5.Enabled = true;
                    }
                    if (checkBox4.Checked == true)
                    {
                        panel6.Enabled = true;
                    }
                    if (checkBox5.Checked == true)
                    {
                        panel7.Enabled = true;
                    }
                    if (checkBox6.Checked == true)
                    {
                        panel8.Enabled = true;
                    }
                    if (checkBox7.Checked == true)
                    {
                        panel11.Enabled = true;
                    }
                }
                else
                {
                    radioButton9.Checked = false;
                    radioButton10.Checked = false;
                    textBox19.Text = "";
                    textBox20.Text = "";
                    textBox21.Text = "";
                    textBox22.Text = "";
                    textBox23.Text = "";
                    textBox24.Text = ""; txt_oil_id5.Text = "";
                    dateTimePicker4.Value = DateTime.Now;
                    panel7.Enabled = false;
                }
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (false)
                {
                    panel8.Enabled = true;
                    txt_oil_id6.Text = Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox26.Text = oi.oil_name.ToString();
                    textBox27.Text = oi.oil_cap.ToString();
                    textBox28.Text = oi.oil_cost.ToString();
                    lbl_type6.Text = oi.main_type.ToString();
                    dateTimePicker5.Value = Convert.ToDateTime(oi.oil_date.ToString());
                    if (oi.main_type == "Active")
                    {
                        radioButton12.Checked = true;
                    }
                    else if (oi.main_type == "Add")
                    {
                        radioButton11.Checked = true;
                    }
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = lines[1];
                        textBox31.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = lines[1];
                        textBox31.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = "";
                        textBox31.Text = "";
                    }
                    else
                    {
                        textBox29.Text = "";
                        textBox30.Text = "";
                        textBox31.Text = "";
                    }
                }
                else if (oi.Find_active_oil_with_equ(Convert.ToInt32(txt_equ_id.Text), label13.Text))
                {
                    panel8.Enabled = true;
                    txt_oil_id6.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox26.Text = oi.oil_name.ToString();
                    textBox27.Text = oi.oil_cap.ToString();
                    textBox28.Text = oi.oil_cost.ToString();
                    dateTimePicker5.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = lines[1];
                        textBox31.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = lines[1];
                        textBox31.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = "";
                        textBox31.Text = "";
                    }
                    else
                    {
                        textBox29.Text = "";
                        textBox30.Text = "";
                        textBox31.Text = "";
                    }
                }
                else if (oi.Find_Catalogue_with_type(Convert.ToInt32(txt_equ_id.Text), label13.Text))
                {
                    panel8.Enabled = true;
                    txt_oil_id6.Text = oi.oil_id.ToString();
                    txt_equ_id.Text = oi.equ_id.ToString();
                    textBox26.Text = oi.oil_name.ToString();
                    textBox27.Text = oi.oil_cap.ToString();
                    textBox28.Text = oi.oil_cost.ToString();
                    dateTimePicker5.Value = DateTime.Now;
                    string h = oi.oil_replacements.ToString();
                    string[] lines = Regex.Split(h, "<#>");
                    if (lines.Length == 3)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = lines[1];
                        textBox31.Text = lines[2];
                    }
                    else if (lines.Length == 2)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = lines[1];
                        textBox31.Text = "";
                    }
                    else if (lines.Length == 1)
                    {
                        textBox29.Text = lines[0];
                        textBox30.Text = "";
                        textBox31.Text = "";
                    }
                    else
                    {
                        textBox29.Text = "";
                        textBox30.Text = "";
                        textBox31.Text = "";
                    }
                }
                else
                {
                    dateTimePicker6.Value = DateTime.Now;
                    textBox26.Text = "";
                    textBox27.Text = "";
                    textBox28.Text = "";
                    textBox29.Text = "";
                    textBox30.Text = "";
                    textBox31.Text = "";
                    panel8.Enabled = false; radioButton11.Checked = false;
                    radioButton12.Checked = false;
                    DialogResult dialogResult = MessageBox.Show("This Equipment Doesnt have this Oil Type" + "\n" + "Do You Want to Add New Oil Type?", "No Oil Data Yet", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                        panel11.Enabled = false;
                        btn_oil_ins.Enabled = false;
                        pnl6.Visible = true;
                        panel8.Enabled = true;
                        pnl66.Visible = false;
                        txt_oil_id6.Text = "new";
                        checkBox1.Enabled = false;
                        checkBox2.Enabled = false;
                        checkBox3.Enabled = false;
                        checkBox4.Enabled = false;
                        checkBox5.Enabled = false;
                        checkBox7.Enabled = false; label48.Text = "Refill Amount";
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        panel8.Enabled = false;
                        checkBox6.CheckedChanged -= new System.EventHandler(checkBox6_CheckedChanged);
                        checkBox6.Checked = false;
                        checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
                    }

                }
            }
            else
            {
                if (id6.Text != "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Oil Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        radioButton11.Checked = false;
                        radioButton12.Checked = false;
                        textBox26.Text = "";
                        textBox27.Text = "";
                        textBox28.Text = "";
                        textBox29.Text = "";
                        textBox30.Text = "";
                        textBox31.Text = ""; txt_oil_id6.Text = "";
                        dateTimePicker6.Value = DateTime.Now;
                        panel8.Enabled = false;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        checkBox6.CheckedChanged -= new System.EventHandler(checkBox6_CheckedChanged);
                        checkBox6.Checked = true;
                        checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
                        return;
                    }
                }
                else if (pnl6.Visible == true)
                {
                    //panel3.Enabled = true;
                    //panel4.Enabled = true;
                    //panel5.Enabled = true;
                    //panel6.Enabled = true;
                    //panel7.Enabled = true;
                    //panel8.Enabled = true;
                    //panel11.Enabled = true;
                    btn_oil_ins.Enabled = true;
                    pnl6.Visible = false;
                    panel8.Enabled = false;
                    pnl66.Visible = true;
                    txt_oil_id6.Text = "new";
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true; label48.Text = "Amount";
                    checkBox7.Enabled = true;
                    //if (checkBox1.Checked == true)
                    //{
                    //    panel3.Enabled = true;
                    //}
                    if (checkBox2.Checked == true)
                    {
                        panel4.Enabled = true;
                    }
                    if (checkBox3.Checked == true)
                    {
                        panel5.Enabled = true;
                    }
                    if (checkBox4.Checked == true)
                    {
                        panel6.Enabled = true;
                    }
                    if (checkBox5.Checked == true)
                    {
                        panel7.Enabled = true;
                    }
                    if (checkBox6.Checked == true)
                    {
                        panel8.Enabled = true;
                    }
                    if (checkBox7.Checked == true)
                    {
                        panel11.Enabled = true;
                    }
                }
                else
                {
                    radioButton11.Checked = false;
                    radioButton12.Checked = false;
                    textBox26.Text = "";
                    textBox27.Text = "";
                    textBox28.Text = "";
                    textBox29.Text = "";
                    textBox30.Text = "";
                    textBox31.Text = ""; txt_oil_id6.Text = "";
                    dateTimePicker6.Value = DateTime.Now;
                    panel8.Enabled = false;
                }
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (fu.Findfuelforpop222(Convert.ToInt32(sta)))
                {
                    panel11.Enabled = true;
                    txt_oil_id7.Text = fu.fuel_id.ToString();
                    txt_equ_id.Text = fu.equ_id.ToString();
                    comboBox2.SelectedItem = fu.fuel_type.ToString();
                    comboBox2.Enabled = false;
                    textBox33.Text = fu.fuel_cap.ToString();
                    textBox34.Text = fu.fuel_cost.ToString();
                    dateTimePicker7.Value = DateTime.Now;
                }
                else if (fu.Find_Catalogue_fuel(Convert.ToInt32(txt_equ_id.Text)))
                {
                    panel11.Enabled = true;
                    txt_oil_id7.Text = fu.fuel_id.ToString();
                    txt_equ_id.Text = fu.equ_id.ToString();
                    comboBox2.SelectedItem = fu.fuel_type.ToString();
                    comboBox2.Enabled = false;
                    textBox33.Text = fu.fuel_cap.ToString();
                    textBox34.Text = fu.fuel_cost.ToString();
                    dateTimePicker7.Value = DateTime.Now;
                }
                else
                {
                    panel11.Enabled = true;
                    txt_oil_id7.Text = "";
                    comboBox2.SelectedIndex = -1;
                    textBox33.Text = "";
                    textBox34.Text = "";
                    dateTimePicker7.Value = DateTime.Now;
                    txt_fu1.Text = "";
                    txt_fu2.Text = ""; comboBox2.Enabled = true;
                    DialogResult dialogResult = MessageBox.Show("This Equipment Doesnt have Fuel Type" + "\n" + "Do You Want to Add New Fuel Type?", "No Fuel Data Yet", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //  panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                        btn_oil_ins.Enabled = false;
                        panel11.Enabled = true;
                        txt_oil_id7.Text = "new";
                        checkBox1.Enabled = false;
                        checkBox2.Enabled = false;
                        checkBox3.Enabled = false;
                        checkBox4.Enabled = false;
                        checkBox5.Enabled = false;
                        checkBox6.Enabled = false;
                        button7.Visible = true;
                        label44.Text = "Refill Amount";
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        panel11.Enabled = false;
                        checkBox7.CheckedChanged -= new System.EventHandler(checkBox7_CheckedChanged);
                        checkBox7.Checked = false;
                        checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
                    }
                }
            }
            else
            {
                if (id7.Text != "0")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Delete this Fuel Record ?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txt_oil_id7.Text = "";
                        comboBox2.SelectedIndex = -1;
                        textBox33.Text = "";
                        textBox34.Text = "";
                        dateTimePicker7.Value = DateTime.Now;
                        txt_fu1.Text = "";
                        txt_fu2.Text = ""; comboBox2.Enabled = true;
                        panel11.Enabled = false;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        checkBox7.CheckedChanged -= new System.EventHandler(checkBox7_CheckedChanged);
                        checkBox7.Checked = true;
                        checkBox7.CheckedChanged += new System.EventHandler(checkBox7_CheckedChanged);
                        return;
                    }
                }
                else if (label44.Text == "Refill Amount")
                {
                    btn_oil_ins.Enabled = true;
                    txt_oil_id7.Text = "new";
                    checkBox1.Enabled = true; comboBox2.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    label44.Text = "Amount";
                    panel11.Enabled = false;
                    button7.Visible = false;
                    //if (checkBox1.Checked == true)
                    //{
                    //    panel3.Enabled = true;
                    //}
                    if (checkBox2.Checked == true)
                    {
                        panel4.Enabled = true;
                    }
                    if (checkBox3.Checked == true)
                    {
                        panel5.Enabled = true;
                    }
                    if (checkBox4.Checked == true)
                    {
                        panel6.Enabled = true;
                    }
                    if (checkBox5.Checked == true)
                    {
                        panel7.Enabled = true;
                    }
                    if (checkBox6.Checked == true)
                    {
                        panel8.Enabled = true;
                    }
                    if (checkBox7.Checked == true)
                    {
                        panel11.Enabled = true;
                    }
                    else
                    {
                        txt_oil_id7.Text = "";
                        comboBox2.SelectedIndex = -1;
                        textBox33.Text = "";
                        textBox34.Text = ""; comboBox2.Enabled = true;
                        dateTimePicker7.Value = DateTime.Now;
                        txt_fu1.Text = "";
                        txt_fu2.Text = "";
                        panel11.Enabled = false;
                    }
                }
            }
        } 
        #endregion
        #region KeyPress
        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //If you want, you can allow decimal(decimal) numbers
            //if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //If you want, you can allow decimal(decimal) numbers
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txt_oil_ins3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //If you want, you can allow decimal(decimal) numbers
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
        private void btn_rep_lb_update_can_Click(object sender, EventArgs e)
        {
            //combo_rep_lb.Text = "--Select--";
            //txt_rep_lb_hors.Text = "";
            //txt_rep_lb_details.Text = "";
            //dateTimePicker5.Value = DateTime.Now;
            this.Dispose();
        }
        private void btn_rep_lb_update_Click(object sender, EventArgs e)
        {
            if (dateTimePicker5.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            
            if (textBox44.Text =="" || textBox43.Text == "" || textBox41.Text == "" || textBox43.Text == "" || txt_rep_lb_hors.Text == "")
            {
                MessageBox.Show("Please Insert Valid Data"); return;
            }
            

            if (label3.Text == "Oil Type")
            {
                if (radioButton1.Checked == true || radioButton2.Checked == true)
                { }
                else { 
                    MessageBox.Show("Please Choose Refill Or Add Amount First"); return;
                }
                string s = "";
                if (radioButton1.Checked == true)
                {
                    s = "ReFill";
                }
                else
                {
                    s = "Add";
                }

                string w = oi.updateoil(Convert.ToInt32(llbl1.Text), Convert.ToInt32(llbl2.Text),
                  textBox44.Text, txt_rep_lb_hors.Text, Convert.ToDecimal(textBox41.Text), Convert.ToInt32(textBox43.Text) , dateTimePicker5.Value,
                  Convert.ToInt32(llbl3.Text), llbl4.Text , s,s, llbl5.Text, llbl6.Text,
                  Convert.ToInt32(llbl7.Text));
                if(w == "Success")
                {
                    MessageBox.Show(w);
                    this.Dispose();
                }
                
            }
            else if(label3.Text == "Filter Type")
            {
                string w = fl.updatefilt(
                 Convert.ToInt32(llbl1.Text),
                 Convert.ToInt32(llbl2.Text),
                 textBox44.Text,
                 txt_rep_lb_hors.Text,
                 Convert.ToInt32(textBox41.Text), 
                 Convert.ToInt32(textBox43.Text),
                 dateTimePicker5.Value,
                 Convert.ToInt32(llbl3.Text),
                 llbl4.Text,
                 Convert.ToDecimal(llbl5.Text),
                 llbl6.Text,
                 Convert.ToInt32(llbl7.Text));

                if (w == "Success")
                {
                    MessageBox.Show(w);
                    this.Dispose();
                }
            }
            else if (label3.Text == "Fuel Type")
            {
                string w =  fu.updatefuel(
                    Convert.ToInt32(llbl1.Text),
                    Convert.ToInt32(llbl2.Text),
                    textBox44.Text,
             txt_rep_lb_hors.Text,
             Convert.ToDecimal(textBox41.Text),
             Convert.ToInt32(textBox43.Text), 
             dateTimePicker5.Value,
              Convert.ToInt32(llbl3.Text),
             Convert.ToInt32(llbl4.Text),
             llbl5.Text,
             Convert.ToInt32(llbl6.Text));

                if (w == "Success")
                {
                    MessageBox.Show(w);
                    this.Dispose();
                }
            }
        }
        private void btn_use_Click(object sender, EventArgs e)
        {
            if (combo_use.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Equipment"); return;
            }
            if (date_use_new.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            var dateAndTime = date_use_old.Value;
            var dateAndTime2 = date_use_new.Value;
            var date = dateAndTime.Date;
            var date2 = dateAndTime2.Date;
            System.Data.DataTable ava = equ_work.available(Convert.ToInt32(combo_use.SelectedValue), date, date2);
            System.Data.DataTable use = equ_work.usability(Convert.ToInt32(combo_use.SelectedValue), date, date2);
            System.Data.DataTable all = equ_work.ava_use(ava, use, Convert.ToInt32(combo_use.SelectedValue));
            if (all.Rows.Count > 0)
            {
                dataGridView5.DataSource = all;
                panel9.Visible = true;
                panel9.Enabled = true;
            }
            else
            {
                dataGridView5.DataSource = new System.Data.DataTable();
                panel9.Visible = false;
                panel9.Enabled = false;
            }
        }
        int indewx=0;
        private void btn_ho_up_Click(object sender, EventArgs e)
        {
            try
            { /* label95.Text =*/   /*textBox1.Text =*/
                btn_hours_upd.Enabled = true;
                btn_hours_upd.Visible = true;
                //panel8.Enabled = true;
                //panel8.Visible = true;
                dataGridView5.CurrentRow.Selected = true;
                indewx = dataGridView5.CurrentRow.Index;
                // int inde= dataGridView5.SelectedRows
                //dateTimePicker6.Value = Convert.ToDateTime(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells["Date"].Value);
                //string av= Convert.ToString(dataGridView5.Rows[dataGridView5.SelectedCells[1].RowIndex].Cells["Availabile Hours"].Value);
                string ho= Convert.ToString(dataGridView5.Rows[dataGridView5.SelectedCells[6].RowIndex].Cells["Counter"].Value);
                if(ho == "No Data Entered"|| ho == "No Data")
                {
                    ho = "0";
                }
                textBox25.Text = ho;
                dataGridView5.Enabled = false;
                panel9.Enabled = false;
                panel10.Enabled = false;
                dataGridView5.DefaultCellStyle.BackColor = Color.Cyan;
                groupBox1.Visible = true;
            }
            catch
            {
                dataGridView5.Rows[0].Selected = true;
                btn_hours_upd.Enabled = true;
                btn_hours_upd.Visible = true;
                //panel8.Enabled = true;
                //panel8.Visible = true;
                //dateTimePicker6.Value = Convert.ToDateTime(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells["Date"].Value);
                //string av = Convert.ToString(dataGridView5.Rows[dataGridView5.SelectedCells[1].RowIndex].Cells["Availabile Hours"].Value);
                string ho = Convert.ToString(dataGridView5.Rows[dataGridView5.SelectedCells[6].RowIndex].Cells["Counter"].Value);
                if (ho == "No Data Entered")
                {
                    ho = "0";
                }
                textBox25.Text = ho; 
                dataGridView5.Enabled = false;
                panel9.Enabled = false;
                panel10.Enabled = false;
                dataGridView5.DefaultCellStyle.BackColor = Color.Cyan;
                groupBox1.Visible = true;
            }
        }
        private void btn_hour_cancel_Click(object sender, EventArgs e)
        {
            panel10.Enabled = true;
            //dateTimePicker6.Value = DateTime.Now;
            dataGridView5.Enabled = true;
            dataGridView5.DefaultCellStyle.BackColor = Color.White;
            textBox25.Text = "";
            groupBox1.Visible = false;
            panel9.Enabled = true;
        }
        private void btn_hours_upd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dd = Convert.ToDateTime(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells["Date"].Value);

                if (combo_use.SelectedValue == null)
                {
                    MessageBox.Show("Please choose valid Equipment"); return;
                }
                if (dd > DateTime.Now)
                {
                    MessageBox.Show("You Can Not Insert Data In the Future"); return;
                }
                //int ho = Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[3].RowIndex].Cells["Work Hours"].Value);
                //string cou = dataGridView5.Rows[dataGridView5.SelectedCells[6].RowIndex - 1].Cells["Counter"].Value.ToString();
                int counter = 0;
                //if (cou == "No Data Entered")
                //{
                //    counter = equ_work.get_lower_hours_counter(Convert.ToInt32(combo_use.SelectedValue), (Convert.ToDateTime(dd)));
                //}
                //else
                //{
                //    counter = Convert.ToInt32(cou);
                //}
                counter = equ_work.get_lower_hours_counter(Convert.ToInt32(combo_use.SelectedValue), (Convert.ToDateTime(dd)));
                int hours = Convert.ToInt32(textBox25.Text) - counter;
                string asd = equ_work.update_equ_work_h(Convert.ToInt32(combo_use.SelectedValue), hours, Convert.ToDateTime(dd), Convert.ToInt32(textBox25.Text));
                if (asd == "Success")
                {
                    ma.Find_work_hours(Convert.ToInt32(combo_use.SelectedValue));
                    string ss2 = ma.Modify_hours(Convert.ToInt32(Use.ControlID22.cancel), Convert.ToInt32(combo_use.SelectedValue), dd.Date);
                    if (ss2 != "Failed")
                    {
                        panel10.Enabled = true;
                        textBox25.Text = "";
                        dataGridView5.DefaultCellStyle.BackColor = Color.White;
                        dataGridView5.Enabled = true;
                        MessageBox.Show(ss2);
                        btn_use_Click(sender, e);
                        groupBox1.Visible = false;
                        dataGridView5.Rows[indewx].Selected = true;
                        lbl_hours2.Text = Convert.ToString(ma.Find_work_hours_int(Convert.ToInt32(txt_equ_id.Text)));
                        //dataGridView5.DataSource = ma.table;
                    }
                    else
                    {
                        MessageBox.Show(ss2);
                    }
                }
                else
                {
                    MessageBox.Show(asd);
                }
            }
            catch
            {
                MessageBox.Show("Please Recheck your data");
            }
        }
        private void btn_ho_de_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Selected Record ?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int ho = 0;
                DateTime dd = Convert.ToDateTime(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells["Date"].Value);
                try
                {
                    ho = Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[3].RowIndex].Cells["Worked Hours"].Value);
                }
                catch
                {
                    ho = Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[3].RowIndex].Cells["Worked Km"].Value);
                }
                string asd = equ_work.del_equ_work_h(Convert.ToDateTime(dd), Convert.ToInt32(combo_use.SelectedValue), Convert.ToInt32(ho));
                indewx = dataGridView5.CurrentRow.Index;
                if (asd == "Success")
                {
                    MessageBox.Show(asd);
                    btn_use_Click(sender, e);
                    dataGridView5.Rows[indewx].Selected = true;
                }
                else
                {
                    MessageBox.Show(asd);
                }
                lbl_hours2.Text = Convert.ToString(ma.Find_work_hours_int(Convert.ToInt32(txt_equ_id.Text)));
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {

            prpi po = new prpi();
            System.Data.DataTable dd = (System.Data.DataTable)dataGridView5.DataSource;
            po.prrrint(dd, "Working Counter Report") ;
        }
        #region math
        public void calc_multi_1(System.Windows.Forms.TextBox txt1, System.Windows.Forms.TextBox txt2, System.Windows.Forms.TextBox total)
        {
            try
            {
                txt1.TextChanged -= new System.EventHandler(mult_TextChanged);
                txt2.TextChanged -= new System.EventHandler(mult_TextChanged);
                total.TextChanged -= new System.EventHandler(mult_TextChanged);
                if (txt1.Text == "")
                { txt1.Text = "0"; }
                if (txt2.Text == "")
                { txt2.Text = "0"; }
                decimal gg = Convert.ToDecimal(Convert.ToDecimal(txt1.Text) * Convert.ToDecimal(txt2.Text));
                total.Text = gg.ToString("0.##");
                txt1.TextChanged += new System.EventHandler(mult_TextChanged);
                txt2.TextChanged += new System.EventHandler(mult_TextChanged);
                total.TextChanged += new System.EventHandler(mult_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " /Please Enter valid number"); return;
            }
        }
        public void calc_dev_1(System.Windows.Forms.TextBox txt1, System.Windows.Forms.TextBox txt2, System.Windows.Forms.TextBox total)
        {
            try
            {
                txt1.TextChanged -= new System.EventHandler(mult_TextChanged);
                txt2.TextChanged -= new System.EventHandler(mult_TextChanged);
                total.TextChanged -= new System.EventHandler(mult_TextChanged);
                if (txt1.Text == "" || txt1.Text == "0")
                { txt1.Text = "1"; }
                if (total.Text == "")
                { total.Text = "1"; }
                decimal gg = Convert.ToDecimal(Convert.ToDecimal(total.Text) / Convert.ToDecimal(txt1.Text));
                txt2.Text = gg.ToString("0.##");
                txt1.TextChanged += new System.EventHandler(mult_TextChanged);
                txt2.TextChanged += new System.EventHandler(mult_TextChanged);
                total.TextChanged += new System.EventHandler(mult_TextChanged);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + " /Please Enter valid number"); return;
            }
        }    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calc_multi_1(textBox2, txt_cos_2, textBox3);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calc_dev_1(textBox2, txt_cos_2, textBox3);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            calc_multi_1(textBox8, txt_cos_3, textBox9);
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            calc_dev_1(textBox8, txt_cos_3, textBox9);
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            calc_multi_1(textBox14, txt_cos_4, textBox15);
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            calc_dev_1(textBox14, txt_cos_4, textBox15);
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            calc_multi_1(textBox20, txt_cos_5, textBox21);
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            calc_dev_1(textBox20, txt_cos_5, textBox21);
        }
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            calc_multi_1(textBox27, txt_cos_6, textBox28);
        }
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            calc_dev_1(textBox27, txt_cos_6, textBox28);
        }
        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            calc_multi_1(textBox33, textBox32, textBox34);
        }
        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            calc_dev_1(textBox33, textBox32, textBox34);
        }
        #endregion
        #region ins cataloge
        private void button1_Click(object sender, EventArgs e)
        {
           // string www3 = "";
           // int www4 = Convert.ToInt32(sta);
           // if (txt_oil_ins2.Text == "" || txt_oil_ins3.Text == "" || txt_oil_ins4.Text == "")
           // {
           //     MessageBox.Show("Please Enter Valid Data"); return;
           // }
           // if (date_oil_ins1.Value > DateTime.Now)
           // {
           //     MessageBox.Show("You Can Not Insert Data In the Future"); return;
           // }
           // string wwwq = txt_oil_rep_ins1.Text + "<#>" + txt_oil_rep_ins2.Text + "<#>" + txt_oil_rep_ins3.Text;
           // string state1 = oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label27.Text, txt_oil_ins2.Text
           //, Convert.ToDecimal(txt_oil_ins3.Text), Convert.ToInt32(txt_oil_ins4.Text), date_oil_ins1.Value,
           //Convert.ToInt32(txt_oil_user_id.Text), wwwq, "Catalogue", www3, www4);
           // if (state1 == "Success")
           // {
           //     checkBox1.Checked = false; checkBox1.Checked = true; MessageBox.Show("Done \n Please Enter Maintenance Data Now");
           // }
           // else
           // {
           //     MessageBox.Show("Please Recheck Oil Data");
           // }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string www3 = "";
            int www4 = Convert.ToInt32(sta);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data"); return;
            }
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            string wwwq = textBox4.Text + "<#>" + textBox5.Text + "<#>" + textBox6.Text;
            string state2 = "";
                //oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label28.Text, textBox1.Text
                  //          , Convert.ToDecimal(textBox2.Text), Convert.ToInt32(textBox3.Text), dateTimePicker1.Value,
                    //        Convert.ToInt32(txt_oil_user_id.Text), wwwq, "Catalogue", www3, www4);
            if (state2 == "Success")
            {
                checkBox2.Checked = false; checkBox2.Checked = true; MessageBox.Show("Done \n Please Enter Maintenance Data Now");
            }
            else
            {
                MessageBox.Show("Please Recheck Oil Data");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string www3 = "";
            int www4 = Convert.ToInt32(sta);
            if (textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data"); return;
            }
            if (dateTimePicker2.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            string wwwq = textBox10.Text + "<#>" + textBox11.Text + "<#>" + textBox12.Text;
            string state3 = "";// oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label29.Text, textBox7.Text
           // , Convert.ToDecimal(textBox8.Text), Convert.ToInt32(textBox9.Text), dateTimePicker2.Value,
            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, "Catalogue", www3, www4);
            if (state3 == "Success")
            {
                checkBox3.Checked = false; checkBox3.Checked = true; MessageBox.Show("Done \n Please Enter Maintenance Data Now");
            }
            else
            {
                MessageBox.Show("Please Recheck Oil Data");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string www3 = "";
            int www4 = Convert.ToInt32(sta);
            if (textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data"); return;
            }
            if (dateTimePicker3.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            string wwwq = textBox16.Text + "<#>" + textBox17.Text + "<#>" + textBox18.Text;
            string state4 = "";
            //oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label30.Text, textBox13.Text
            //, Convert.ToDecimal(textBox14.Text), Convert.ToInt32(textBox15.Text), dateTimePicker3.Value,
            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, "Catalogue", www3, www4);
            if (state4 == "Success")
            {
                checkBox4.Checked = false; checkBox4.Checked = true; MessageBox.Show("Done \n Please Enter Maintenance Data Now");
            }
            else
            {
                MessageBox.Show("Please Recheck Oil Data");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string www3 = "";
            int www4 = Convert.ToInt32(sta);
            if (textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data"); return;
            }
            if (dateTimePicker4.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            string wwwq = textBox22.Text + "<#>" + textBox23.Text + "<#>" + textBox24.Text;
            string state5 = "";
            //oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label37.Text, textBox19.Text
            //, Convert.ToDecimal(textBox20.Text), Convert.ToInt32(textBox21.Text), dateTimePicker4.Value,
            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, "Catalogue", www3, www4);
            if (state5 == "Success")
            {
                checkBox5.Checked = false; checkBox5.Checked = true; MessageBox.Show("Done \n Please Enter Maintenance Data Now");
            }
            else
            {
                MessageBox.Show("Please Recheck Oil Data");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string www3 = "";
            int www4 = Convert.ToInt32(sta);
            if (textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data"); return;
            }
            if (dateTimePicker6.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            string wwwq = textBox29.Text + "<#>" + textBox30.Text + "<#>" + textBox31.Text;
            string state6 = "";
                //oi.Addoil(Convert.ToInt32(txt_equ_id.Text), label13.Text, textBox26.Text
           // , Convert.ToDecimal(textBox27.Text), Convert.ToInt32(textBox28.Text), dateTimePicker6.Value,
            //Convert.ToInt32(txt_oil_user_id.Text), wwwq, "Catalogue", www3, www4);
            if (state6 == "Success")
            {
                checkBox6.Checked = false; checkBox6.Checked = true; MessageBox.Show("Done \n Please Enter Maintenance Data Now");
            }
            else
            {
                MessageBox.Show("Please Recheck Oil Data");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox33.Text == "" || textBox34.Text == "" || comboBox2.SelectedIndex > 0)
            {
                MessageBox.Show("Please Enter Valid Data"); return;
            }
            if (dateTimePicker7.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }string state7 = "";
            //string state7 = fu.Addfuel(Convert.ToInt32(txt_equ_id.Text), comboBox2.Text, "0",
            //                  Convert.ToInt32(textBox33.Text), Convert.ToInt32(textBox34.Text),
            //                dateTimePicker7.Value,
            //               Convert.ToInt32(txt_oil_user_id.Text), "Catalogue");
            if (state7 == "Success")
            {
                checkBox7.Checked = false; checkBox7.Checked = true; MessageBox.Show("Done \n Please Enter Maintenance Data Now");
            }
            else
            {
                MessageBox.Show("Please Recheck Fuel Data");
            }
        }

        #endregion
        private void button8_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex>=0)
            { }
            else
            {
                MessageBox.Show("Please Choose Lubricant Type");
                return;
            }
            foreach (System.Windows.Forms.GroupBox con2 in flowLayoutPanel2.Controls)
            {
                foreach (Control con in con2.Controls)
                {
                    if (con is System.Windows.Forms.Label)
                    {
                        if (con.Name == "l1")
                        {
                            if (con.Text == comboBox3.Text)
                            {
                                return;
                            }
                        }
                    }

                }
            }

            System.Data.DataTable dd = (System.Data.DataTable)comboBox3.DataSource;
            add_panals(
                         dd.Rows[comboBox3.SelectedIndex][0].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][2].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][3].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][4].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][5].ToString()
                       , Convert.ToDateTime(dd.Rows[comboBox3.SelectedIndex][6].ToString())
                       , dd.Rows[comboBox3.SelectedIndex][8].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][9].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][10].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][11].ToString()
                       , dd.Rows[comboBox3.SelectedIndex][12].ToString());
        }
        public void add_panals(string id, string type, string name, string cap, string cost,
            DateTime date, string rep, string active, string hours, string alert, string main_id)
        {

            System.Windows.Forms.GroupBox pp = new System.Windows.Forms.GroupBox();
            Panel pp2 = new Panel();
            pp.Size = new Size(280, 240);
            pp2.Size = new Size(128, 101);
            pp2.Location = new System.Drawing.Point(65, 80);

            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l3 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l4 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l5 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l6 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l7 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l8 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l9 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l10 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l11 = new System.Windows.Forms.Label();

            l1.AutoSize = true;
            l2.Size = new Size(65, 13);
            l3.Size = new Size(65, 13);
            l4.Size = new Size(65, 13);
            l5.Size = new Size(65, 13);
            l6.Size = new Size(65, 13);
            l7.Size = new Size(65, 13);
            l8.Size = new Size(65, 13);
            l9.Size = new Size(65, 13);
            l10.Size = new Size(65, 13);
            l11.Size = new Size(65, 13);

            l1.Location = new System.Drawing.Point(105, 13);
            l2.Location = new System.Drawing.Point(4, 84);
            l3.Location = new System.Drawing.Point(4, 109);
            l4.Location = new System.Drawing.Point(4, 134);
            l5.Location = new System.Drawing.Point(4, 159);
            l6.Location = new System.Drawing.Point(4, 185);
            l7.Location = new System.Drawing.Point(190, 83);
            l8.Location = new System.Drawing.Point(190, 110);
            l9.Location = new System.Drawing.Point(190, 120);
            l10.Location = new System.Drawing.Point(190, 130);
            l11.Location = new System.Drawing.Point(190, 140);

            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;

            l1.Text = type;
            l2.Text = "Name";
            l3.Text = "Amount";
            l4.Text = "Litre Cost";
            l5.Text = "Total Cost";
            l6.Text = "Date";
            l7.Text = id;
            l8.Text = rep;
            l9.Text = hours;//1
            l10.Text = alert;
            l11.Text = active;

            l1.Name = "l1";
            l2.Name = "l2";
            l3.Name = "l3";
            l4.Name = "l4";
            l5.Name = "l5";
            l6.Name = "l6";
            l7.Name = "l7";
            l8.Name = "l8";
            l9.Name = "l9";
            l10.Name = "l10";
            l11.Name = "l11";

            l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);

            l1.ForeColor = System.Drawing.Color.Green;
            int x = (pp.Size.Width - l1.Size.Width) / 2;
            l1.Location = new System.Drawing.Point(x, l1.Location.Y);

            pp.Controls.Add(l1);
            pp.Controls.Add(l2);
            pp.Controls.Add(l3);
            pp.Controls.Add(l4);
            pp.Controls.Add(l5);
            pp.Controls.Add(l6);
            pp.Controls.Add(l7);
            pp.Controls.Add(l8);
            pp.Controls.Add(l9);
            pp.Controls.Add(l10);
            pp.Controls.Add(l11);

            LinkLabel lk = new LinkLabel();
            lk.Name = "lk";
            lk.Text = "Delete";
            lk.Location = new System.Drawing.Point(237, 7);
            lk.Size = new System.Drawing.Size(38, 13);
            lk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            pp.Controls.Add(lk);

            RadioButton r1 = new RadioButton();
            RadioButton r2 = new RadioButton();

            r1.Size = new Size(63, 17);
            r2.Size = new Size(84, 17);

            r1.Name = "ReFill";
            r2.Name = "Add";

            r1.Text = "ReFill";
            r2.Text = "Add Amount";

            r1.Location = new System.Drawing.Point(69, 38);
            r2.Location = new System.Drawing.Point(69, 59);
            if (active == "Add")
            {
                r2.Checked = true;
            }
            else if (active == "Active")
            {
                r1.Checked = true;
            }
            else if (active == "ReFill")
            {
                r1.Checked = true;
            }
            else if (active == "Catalogue")
            {
                r1.Checked = false; 
                r2.Checked = false;
            }
            else if (active == "Changed")
            {
                r1.Checked = true;
            }
            if (name == "fuel")
            {
                r1.Visible = false;
                r2.Visible = false;
                r1.Checked = true;
                pp.Controls.Add(r1);
                pp.Controls.Add(r2);
            }
            else
            {
                pp.Controls.Add(r1);
                pp.Controls.Add(r2);
            }

            System.Windows.Forms.TextBox tx1 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox tx2 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox tx3 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox tx4 = new System.Windows.Forms.TextBox();

            tx1.Size = new Size(111, 20);
            tx2.Size = new Size(111, 20);
            tx3.Size = new Size(111, 20);
            tx4.Size = new Size(111, 20);

            tx1.Name = "tx1";
            tx2.Name = "tx2";
            tx3.Name = "tx3";
            tx4.Name = "tx4";

            tx1.Text = name;
            tx2.Text = cap;
            if(cap=="0"||cap=="")
            { cap = "1"; }
            decimal de = Convert.ToDecimal(cost) / Convert.ToDecimal(cap);
            tx3.Text = de.ToString("0.##");
            tx4.Text = cost;

            tx1.Location = new System.Drawing.Point(5, 1);
            tx2.Location = new System.Drawing.Point(5, 26);
            tx3.Location = new System.Drawing.Point(5, 51);
            tx4.Location = new System.Drawing.Point(5, 76);

            tx2.KeyPress += new KeyPressEventHandler(dec_KeyPress);
            tx3.KeyPress += new KeyPressEventHandler(dec_KeyPress);
            tx4.KeyPress += new KeyPressEventHandler(dec_KeyPress);

            tx2.TextChanged += new System.EventHandler(mult_TextChanged);
            tx3.TextChanged += new System.EventHandler(mult_TextChanged);
            tx4.TextChanged += new System.EventHandler(dev_TextChanged);

            pp2.Controls.Add(tx1);
            pp2.Controls.Add(tx2);
            pp2.Controls.Add(tx3);
            pp2.Controls.Add(tx4);
            pp.Controls.Add(pp2);

            if (name == "fuel")
            {
                l2.Visible = false;
                tx1.Visible = false;
            }

            DateTimePicker dt1 = new DateTimePicker();
            dt1.Size = new Size(183, 20);
            dt1.Location = new System.Drawing.Point(70, 181);
            if(active == "Catalogue")
            {
                dt1.Value = Convert.ToDateTime(DateTime.Now);
            }
            else
            {
                dt1.Value = Convert.ToDateTime(date);
            }
           
            pp.Controls.Add(dt1);

            flowLayoutPanel2.Controls.Add(pp);
        }
        private void intt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void dec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void dev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox tx1 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox tx2 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox tx3 = new System.Windows.Forms.TextBox();
                Control control = (Control)sender;
                Panel parentForm = (control.Parent as Panel);
                foreach (System.Windows.Forms.TextBox p in parentForm.Controls)
                {
                    if (p.Name == "tx2")
                    {
                        tx1 = p;
                    }
                    if (p.Name == "tx3")
                    {
                        tx2 = p;
                    }
                    if (p.Name == "tx4")
                    {
                        tx3 = p;
                    }
                }
                calc_dev_1(tx1, tx2, tx3);
            }
            catch
            {
                calc_dev_1(textBox41, textBox42, textBox43);
            }
            
        }
        private void mult_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox tx1 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox tx2 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox tx3 = new System.Windows.Forms.TextBox();
                Control control = (Control)sender;
                Panel parentForm = (control.Parent as Panel);
                foreach (System.Windows.Forms.TextBox p in parentForm.Controls)
                {
                    if (p.Name == "tx2")
                    {
                        tx1 = p;
                    }
                    if (p.Name == "tx3")
                    {
                        tx2 = p;
                    }
                    if (p.Name == "tx4")
                    {
                        tx3 = p;
                    }
                }
                calc_multi_1(tx1, tx2, tx3);
            }
            catch
            {
                calc_multi_1(textBox41, textBox42, textBox43);
            }

        }
        public void add_Filter_panals(string id, string type, string name, string cap, string cost,
           DateTime date, string rep,  string hours,string active)
        {
            System.Windows.Forms.GroupBox pp = new System.Windows.Forms.GroupBox();
            Panel pp2 = new Panel();
            pp.Size = new Size(280, 150);
            pp2.Size = new Size(195, 101);
            pp2.Location = new System.Drawing.Point(65, 35);

            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l3 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l4 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l5 = new System.Windows.Forms.Label();
            //System.Windows.Forms.Label l6 = new System.Windows.Forms.Label();
           
            System.Windows.Forms.Label l7 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l8 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l9 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label l10 = new System.Windows.Forms.Label();

            l1.AutoSize = true;
            l2.Size = new Size(65, 13);
            l3.Size = new Size(65, 13);
            l4.Size = new Size(65, 13);
            l5.Size = new Size(65, 13);
           // l6.Size = new Size(65, 13);
            l7.Size = new Size(65, 13);
            l8.Size = new Size(65, 13);
            l9.Size = new Size(65, 13);
            l10.Size = new Size(65, 13);

            l1.Location = new System.Drawing.Point(105, 13);
            l2.Location = new System.Drawing.Point(4, 40);
            l3.Location = new System.Drawing.Point(4, 65);
            l4.Location = new System.Drawing.Point(4, 90);
            l5.Location = new System.Drawing.Point(4, 115);
            //l6.Location = new System.Drawing.Point(4, 185);
            l7.Location = new System.Drawing.Point(190, 83);
            l8.Location = new System.Drawing.Point(190, 110);
            l9.Location = new System.Drawing.Point(190, 120);
            l10.Location = new System.Drawing.Point(190, 130);

            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;

            l1.Text = type;
            l2.Text = "Name";
            l3.Text = "Quantity";
            l4.Text = "Total Cost";
            l5.Text = "Date";
            //l6.Text = "";
            l7.Text = id;
            l8.Text = rep;
            l9.Text = hours;//2
            l10.Text = active;

            l1.Name = "l1";
            l2.Name = "l2";
            l3.Name = "l3";
            l4.Name = "l4";
            l5.Name = "l5";
           // l6.Name = "l6";
            l7.Name = "l7";
            l8.Name = "l8";
            l9.Name = "l9";
            l10.Name = "l10";

            l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
           // l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            l10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);


            LinkLabel lk = new LinkLabel();
            lk.Name = "lk";
            lk.Text = "Delete";
            lk.Location = new System.Drawing.Point(237, 7);
            lk.Size = new System.Drawing.Size(38, 13);
            lk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            pp.Controls.Add(lk);


            l1.ForeColor = System.Drawing.Color.Green;
            int x = (pp.Size.Width - l1.Size.Width) / 2;
            l1.Location = new System.Drawing.Point(x, l1.Location.Y);

            pp.Controls.Add(l1);
            pp.Controls.Add(l2);
            pp.Controls.Add(l3);
            pp.Controls.Add(l4);
            pp.Controls.Add(l5);
           // pp.Controls.Add(l6);
            pp.Controls.Add(l7);
            pp.Controls.Add(l8);
            pp.Controls.Add(l9);
            pp.Controls.Add(l10);


            System.Windows.Forms.TextBox tx1 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox tx2 = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox tx3 = new System.Windows.Forms.TextBox();

            tx1.Size = new Size(111, 20);
            tx2.Size = new Size(111, 20);
            tx3.Size = new Size(111, 20);

            tx1.Name = "tx1";
            tx2.Name = "tx2";
            tx3.Name = "tx3";
            //tx4.Name = "tx4";

            tx1.Text = name;
            tx2.Text = cap;
            tx3.Text = cost;

            tx1.Location = new System.Drawing.Point(5, 1);
            tx2.Location = new System.Drawing.Point(5, 26);
            tx3.Location = new System.Drawing.Point(5, 51);
            //  tx4.Location = new System.Drawing.Point(5, 76);
            DateTimePicker dt1 = new DateTimePicker();
            dt1.Size = new Size(188, 20);
            dt1.Location = new System.Drawing.Point(5, 76);
            //dt1.Value = Convert.ToDateTime(date);

            if (active == "Catalogue")
            {
                dt1.Value = Convert.ToDateTime(DateTime.Now);
            }
            else
            {
                dt1.Value = Convert.ToDateTime(date);
            }


            pp2.Controls.Add(dt1);
            pp2.Controls.Add(tx1);
            pp2.Controls.Add(tx2);
            pp2.Controls.Add(tx3);
            //pp2.Controls.Add(tx4);
            pp.Controls.Add(pp2);



            flowLayoutPanel3.Controls.Add(pp);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
            { }
            else
            {
                MessageBox.Show("Please Choose Lubricant Type");
                return;
            }
            foreach (System.Windows.Forms.GroupBox con2 in flowLayoutPanel3.Controls)
            {
                foreach (Control con in con2.Controls)
                {
                    if (con is System.Windows.Forms.Label)
                    {
                        if (con.Name == "l1")
                        {
                            if (con.Text == comboBox4.Text)
                            {
                                return;
                            }
                        }
                    }

                }
            }

            System.Data.DataTable dd = (System.Data.DataTable)comboBox4.DataSource;
            add_Filter_panals(
                         dd.Rows[comboBox4.SelectedIndex][0].ToString()
                       , dd.Rows[comboBox4.SelectedIndex][2].ToString()
                       , dd.Rows[comboBox4.SelectedIndex][3].ToString()
                       , dd.Rows[comboBox4.SelectedIndex][4].ToString()
                       , dd.Rows[comboBox4.SelectedIndex][5].ToString()
                       , Convert.ToDateTime(dd.Rows[comboBox4.SelectedIndex][6].ToString())
                       , dd.Rows[comboBox4.SelectedIndex][8].ToString()
                       , dd.Rows[comboBox4.SelectedIndex][9].ToString()
                       , dd.Rows[comboBox4.SelectedIndex][10].ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.GroupBox con2 in flowLayoutPanel2.Controls)
            {
                string fue = "";
                System.Windows.Forms.RadioButton r1 = new System.Windows.Forms.RadioButton();
                System.Windows.Forms.RadioButton r2 = new System.Windows.Forms.RadioButton();
                DateTimePicker dd = new DateTimePicker();
                foreach (Control con in con2.Controls)
                {
                    if (con is System.Windows.Forms.RadioButton)
                    {
                        if (con.Name == "ReFill")
                        {
                            r1 = (RadioButton)con;
                        }
                        if (con.Name == "Add")
                        {
                            r2 = (RadioButton)con;
                        }
                    }
                    if (con is System.Windows.Forms.Panel)
                    {
                        foreach (Control cone in con.Controls)
                        {
                            if (cone is System.Windows.Forms.TextBox)
                            {
                                if (cone.Text == "")
                                {
                                    MessageBox.Show("Please Fill All TextBoxes First");
                                    return;
                                }
                                if (cone.Text == "fuel")
                                {
                                    fue = "fuel";
                                }
                            }
                        }
                    }
                    if (con is System.Windows.Forms.DateTimePicker)
                    {
                        dd = (DateTimePicker)con;
                        if (dd.Value > DateTime.Now)
                        {
                            MessageBox.Show("Can Not Enter Date in Future");
                            return;
                        }
                    }
                }
                if (r1.Checked == true || r2.Checked == true|| fue == "fuel")
                {

                }
                else
                {
                    MessageBox.Show("Please Choose Add Amount or Refill First");
                    return;
                }
            }
            foreach (System.Windows.Forms.GroupBox con2 in flowLayoutPanel3.Controls)
            {
                DateTimePicker dd = new DateTimePicker();
                foreach (Control con in con2.Controls)
                {
                    if(con is System.Windows.Forms.Panel)
                    {
                        foreach (Control cone in con.Controls)
                        {
                            if (cone is System.Windows.Forms.TextBox)
                            {
                                if (cone.Text == "")
                                {
                                    MessageBox.Show("Please Fill All TextBoxes First");
                                    return;
                                }
                            }
                            if (cone is System.Windows.Forms.DateTimePicker)
                            {
                                dd = (DateTimePicker)cone;
                                if (dd.Value > DateTime.Now)
                                {
                                    MessageBox.Show("Can Not Enter Date in Future");
                                    return;
                                }
                            }
                        }
                    }
                }
            }





            string oii = oi.deloilrep(Convert.ToInt32(sta));
            string fuu = fu.delfuelrep(Convert.ToInt32(sta));
            string fll = fl.delfilterrep(Convert.ToInt32(sta));

            if (oii == "Success" && fuu == "Success" && fll == "Success")
            {
                string fe = "";
                string all = "";
                string ooo = "";
                string err = "";
                foreach (System.Windows.Forms.GroupBox con2 in flowLayoutPanel2.Controls)
                {
                    string[] arr = new string[9];
                    foreach (Control con in con2.Controls)
                    {
                        if (con is System.Windows.Forms.Label)
                        {
                            if(con.Name == "l1")
                            {
                                arr[0] = con.Text;
                            }
                            if (con.Name == "l8")
                            {
                                arr[5] = con.Text;
                            }
                            if (con.Name == "l9")
                            {
                                arr[7] = con.Text;
                            }
                            if (con.Name == "l10")
                            {
                                arr[8] = con.Text;
                            }
                        }
                        if (con is System.Windows.Forms.RadioButton)
                        {
                            System.Windows.Forms.RadioButton r1 = new System.Windows.Forms.RadioButton();
                            r1 = (RadioButton)con;
                            if(r1.Checked==true)
                            {
                                if (con.Name == "ReFill")
                                {
                                    arr[6] = "ReFill";
                                }
                                if (con.Name == "Add")
                                {
                                    arr[6] = "Add";
                                }
                            }
                        }
                        if (con is System.Windows.Forms.Panel)
                        {
                            foreach (Control cone in con.Controls)
                            {
                                if (cone is System.Windows.Forms.TextBox)
                                {
                                    if (cone.Name == "tx1")
                                    {
                                        arr[1] = cone.Text;
                                    }
                                    if (cone.Name == "tx2")
                                    {
                                        arr[2] = cone.Text;
                                    }
                                    if (cone.Name == "tx4")
                                    {
                                        arr[3] = cone.Text;
                                    }
                                }
                            }
                        }
                        if (con is System.Windows.Forms.DateTimePicker)
                        {
                            DateTimePicker dd = new DateTimePicker();
                            dd = (DateTimePicker)con;
                            arr[4] = dd.Value.ToString();
                        }
                    }
                    if(arr[1]=="fuel")
                    {
                        fe= fu.Addfuel(Convert.ToInt32(txt_equ_id.Text), arr[0], arr[1], Convert.ToDecimal(arr[2]), Convert.ToInt32(arr[3])
                            , Convert.ToDateTime(arr[4]), Convert.ToInt32(id_sent),Convert.ToInt32(hours), "Add",Convert.ToInt32(sta));
                        ooo = "Success";
                    }
                    else
                    {
                       ooo = oi.Addoil(Convert.ToInt32(txt_equ_id.Text),arr[0],arr[1],Convert.ToDecimal(arr[2]),Convert.ToInt32(arr[3]), 
                           Convert.ToDateTime(arr[4]),Convert.ToInt32(id_sent),arr[5],arr[6],hours,arr[8],Convert.ToInt32(sta));

                        fe = "Success";
                    }
                    if(fe== "Success" && ooo== "Success")
                    { }
                    else
                    {
                        all = "fail"; err = err + "<#>" + arr[0];
                    }
                }

                foreach (System.Windows.Forms.GroupBox con2 in flowLayoutPanel3.Controls)
                {
                    string[] arr = new string[8];
                    foreach (Control con in con2.Controls)
                    {
                        if (con is System.Windows.Forms.Label)
                        {
                            if (con.Name == "l1")
                            {
                                arr[0] = con.Text;
                            }
                            if (con.Name == "l8")
                            {
                                arr[5] = con.Text;
                            }
                            if (con.Name == "l9")
                            {
                                arr[6] = con.Text;
                            }
                            if (con.Name == "l10")
                            {
                                arr[7] = con.Text;
                            }
                        }
                        if (con is System.Windows.Forms.Panel)
                        {
                            foreach (Control cone in con.Controls)
                            {
                                if (cone is System.Windows.Forms.TextBox)
                                {
                                    if (cone.Name == "tx1")
                                    {
                                        arr[1] = cone.Text;
                                    }
                                    if (cone.Name == "tx2")
                                    {
                                        arr[2] = cone.Text;
                                    }
                                    if (cone.Name == "tx3")
                                    {
                                        arr[3] = cone.Text;
                                    }
                                }
                                if (cone is System.Windows.Forms.DateTimePicker)
                                {
                                    DateTimePicker dd = new DateTimePicker();
                                    dd = (DateTimePicker)cone;
                                    arr[4] = dd.Value.ToString();
                                }
                            }
                        }                      
                    }
                   string flll=fl.Addfilt(Convert.ToInt32(txt_equ_id.Text),arr[0],arr[1],Convert.ToInt32(arr[2]),Convert.ToDecimal(arr[3])
                           , Convert.ToDateTime(arr[4]),Convert.ToInt32(id_sent),arr[5],Convert.ToDecimal(hours),"Active",Convert.ToInt32(sta));
                    if (flll == "Success")
                    { }
                    else
                    {
                        all = "fail"; err = err + "<#>" + arr[0];
                    }

                }


                if (all=="")
                {
                    Use.ControlID22.cancel = "";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Recheck Entered Data");
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control control = (Control)sender;
            System.Windows.Forms.GroupBox parentForm = (control.Parent as System.Windows.Forms.GroupBox);
            parentForm.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Use.ControlID22.cancel = "cancel";
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dateTimePicker8.Value > DateTime.Now)
            {
                MessageBox.Show("You Can Not Insert Data In the Future"); return;
            }
            if (comboBox6.SelectedValue == null)
            {
                MessageBox.Show("Please choose valid Data"); return;
            }


            string d = worksal.update_work_reprot(Convert.ToInt32(lbl1.Text), Convert.ToInt32(lbl2.Text),
               Convert.ToInt32(comboBox6.SelectedValue), comboBox6.Text,
               Convert.ToInt32(lbl3.Text), Convert.ToInt32(textBox40.Text),
               dateTimePicker8.Value, Convert.ToInt32(lbl4.Text), textBox39.Text, lbl5.Text, llbl6.Text);


            
            MessageBox.Show(d);
            if (d == "Success")
            {
                this.Dispose();
            }
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ho_up_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
