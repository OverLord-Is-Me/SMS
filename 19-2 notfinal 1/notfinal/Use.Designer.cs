namespace notfinal
{
    partial class Use
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        DBC sssw = new DBC();
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                combo_cor_equ.SelectedIndexChanged -= new System.EventHandler(this.combo_cor_equ_SelectedIndexChanged);
                combo_laboe_upd.SelectedIndexChanged -= new System.EventHandler(this.combo_laboe_upd_SelectedIndexChanged);
                combo_equ_show.SelectedIndexChanged -= new System.EventHandler(this.combo_equ_show_SelectedIndexChanged);
                comb_add_hours.SelectedIndexChanged -= new System.EventHandler(this.comb_add_hours_SelectedIndexChanged);
                comb_prev_main1.SelectedIndexChanged -= new System.EventHandler(this.comb_prev_main1_SelectedIndexChanged);
                comb_CP_main_equ.SelectedIndexChanged -= new System.EventHandler(this.comb_CP_main_equ_SelectedIndexChanged);
                comb_flt_del_equ.SelectedIndexChanged -= new System.EventHandler(this.comb_flt_del_equ_SelectedIndexChanged);
                combo_filter_equ_ins.SelectedIndexChanged -= new System.EventHandler(this.combo_filter_equ_ins_SelectedIndexChanged);
                comb_oil_del_equ.SelectedIndexChanged -= new System.EventHandler(this.comb_oil_del_equ_SelectedIndexChanged);
                combo_oil_ins.SelectedIndexChanged -= new System.EventHandler(this.combo_oil_ins_SelectedIndexChanged);
                comb_fuel_del_equ.SelectedIndexChanged -= new System.EventHandler(this.comb_fuel_del_equ_SelectedIndexChanged);


                //System.Data.SqlClient.SqlConnection.ClearPool(sssw.conn);
                components.Dispose(); 
            }
            //System.Data.SqlClient.SqlConnection.ClearPool(sssw.conn);
            base.Dispose(disposing); 
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Use));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hopeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hopeDataSet = new notfinal.hopeDataSet();
            this.tabb3 = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.main_rep = new System.Windows.Forms.TabPage();
            this.label253 = new System.Windows.Forms.Label();
            this.label254 = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.PictureBox();
            this.lb_mod_31 = new System.Windows.Forms.Label();
            this.txt_rep_word = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cost2 = new System.Windows.Forms.TextBox();
            this.txt_cost1 = new System.Windows.Forms.TextBox();
            this.pnl_totalCost = new System.Windows.Forms.Panel();
            this.chk_cost3 = new System.Windows.Forms.CheckBox();
            this.txt_cost3 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel60 = new System.Windows.Forms.Panel();
            this.label217 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label216 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.com_report = new System.Windows.Forms.ComboBox();
            this.check_daily = new System.Windows.Forms.CheckBox();
            this.date_old = new System.Windows.Forms.DateTimePicker();
            this.check_corr = new System.Windows.Forms.CheckBox();
            this.date_new = new System.Windows.Forms.DateTimePicker();
            this.check_prev = new System.Windows.Forms.CheckBox();
            this.radio_done = new System.Windows.Forms.RadioButton();
            this.radio_not = new System.Windows.Forms.RadioButton();
            this.panel61 = new System.Windows.Forms.Panel();
            this.chk_rep_word = new System.Windows.Forms.CheckBox();
            this.check_type = new System.Windows.Forms.CheckBox();
            this.check_date = new System.Windows.Forms.CheckBox();
            this.check_cost = new System.Windows.Forms.CheckBox();
            this.check_state = new System.Windows.Forms.CheckBox();
            this.check_id = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label251 = new System.Windows.Forms.Label();
            this.label252 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label207 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.label76 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.panel39 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.combo_oil_rep = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label249 = new System.Windows.Forms.Label();
            this.label250 = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label198 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.button31 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.filter_rep = new System.Windows.Forms.TabPage();
            this.label244 = new System.Windows.Forms.Label();
            this.label245 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label178 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panel31 = new System.Windows.Forms.Panel();
            this.button32 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label235 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.labor_rep = new System.Windows.Forms.TabPage();
            this.lb_mod_32 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label125 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_report_lp = new System.Windows.Forms.PictureBox();
            this.label212 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.chk_date = new System.Windows.Forms.CheckBox();
            this.chk_id = new System.Windows.Forms.CheckBox();
            this.chk_equ = new System.Windows.Forms.CheckBox();
            this.date_rep_old = new System.Windows.Forms.DateTimePicker();
            this.combo_labor_report = new System.Windows.Forms.ComboBox();
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.date_rep_new = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button28 = new System.Windows.Forms.Button();
            this.btn_rep_lb_del = new System.Windows.Forms.Button();
            this.btn_rep_lb_up = new System.Windows.Forms.Button();
            this.label98 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label99 = new System.Windows.Forms.Label();
            this.usa_ava = new System.Windows.Forms.TabPage();
            this.button29 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_mod_33 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label130 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label127 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_use = new System.Windows.Forms.ComboBox();
            this.btn_use = new System.Windows.Forms.Button();
            this.date_use_new = new System.Windows.Forms.DateTimePicker();
            this.date_use_old = new System.Windows.Forms.DateTimePicker();
            this.label131 = new System.Windows.Forms.Label();
            this.cos_rep = new System.Windows.Forms.TabPage();
            this.label255 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel62 = new System.Windows.Forms.Panel();
            this.label240 = new System.Windows.Forms.Label();
            this.lbl_1_lubs = new System.Windows.Forms.Label();
            this.lbl_6_tech = new System.Windows.Forms.Label();
            this.lbl_5_parts = new System.Windows.Forms.Label();
            this.lbl_4_filter = new System.Windows.Forms.Label();
            this.lbl_3_fuel = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.panel48 = new System.Windows.Forms.Panel();
            this.radioButton15 = new System.Windows.Forms.CheckBox();
            this.radioButton14 = new System.Windows.Forms.CheckBox();
            this.label248 = new System.Windows.Forms.Label();
            this.label247 = new System.Windows.Forms.Label();
            this.label246 = new System.Windows.Forms.Label();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label229 = new System.Windows.Forms.Label();
            this.panel47 = new System.Windows.Forms.Panel();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.chc_2_main = new System.Windows.Forms.CheckBox();
            this.chc_1_lub = new System.Windows.Forms.CheckBox();
            this.chc_3_fuel = new System.Windows.Forms.CheckBox();
            this.chc_4_filters = new System.Windows.Forms.CheckBox();
            this.chc_5_parts = new System.Windows.Forms.CheckBox();
            this.chc_6_tech = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label256 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.oilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabb2 = new System.Windows.Forms.TabPage();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.txt_add_hours_total = new System.Windows.Forms.TextBox();
            this.lbl_prv_hrs_stage2 = new System.Windows.Forms.Label();
            this.lbl_prv_hrs_stage1 = new System.Windows.Forms.Label();
            this.lbl_prv_hrs_part2 = new System.Windows.Forms.Label();
            this.lbl_prv_hrs_part1 = new System.Windows.Forms.Label();
            this.lbl_after = new System.Windows.Forms.Label();
            this.lowww = new System.Windows.Forms.Label();
            this.lbl_main_id = new System.Windows.Forms.Label();
            this.lbl_hours2 = new System.Windows.Forms.Label();
            this.lbl_hours1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.date_add_hours = new System.Windows.Forms.DateTimePicker();
            this.label67 = new System.Windows.Forms.Label();
            this.txt_input_hours = new System.Windows.Forms.TextBox();
            this.btnhours = new System.Windows.Forms.Button();
            this.btn_detais_hours = new System.Windows.Forms.Button();
            this.lb_mod_2 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.comb_add_hours = new System.Windows.Forms.ComboBox();
            this.tabb0 = new System.Windows.Forms.TabPage();
            this.btn_notf = new System.Windows.Forms.Button();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pnl_posting = new System.Windows.Forms.Panel();
            this.label140 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.picfilter = new System.Windows.Forms.PictureBox();
            this.label180 = new System.Windows.Forms.Label();
            this.picfuel = new System.Windows.Forms.PictureBox();
            this.label142 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pichours = new System.Windows.Forms.PictureBox();
            this.label151 = new System.Windows.Forms.Label();
            this.picoil = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnl_maint = new System.Windows.Forms.Panel();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.label182 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.label181 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.label183 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnl_report = new System.Windows.Forms.Panel();
            this.label186 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label117 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label152 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picreport = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label201 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label203 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label205 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabb1 = new System.Windows.Forms.TabPage();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.lb_mod_1 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel55 = new System.Windows.Forms.Panel();
            this.label82 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.panel52 = new System.Windows.Forms.Panel();
            this.lbl_lng = new System.Windows.Forms.Label();
            this.lbl_high = new System.Windows.Forms.Label();
            this.lbl_wiegt = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_highidle = new System.Windows.Forms.Label();
            this.lbl_lowidle = new System.Windows.Forms.Label();
            this.lbl_engp = new System.Windows.Forms.Label();
            this.panel56 = new System.Windows.Forms.Panel();
            this.lbl_sn = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.lbl_arr = new System.Windows.Forms.Label();
            this.lbl_engsn = new System.Windows.Forms.Label();
            this.lbl_transn = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel53 = new System.Windows.Forms.Panel();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.label227 = new System.Windows.Forms.Label();
            this.panel35 = new System.Windows.Forms.Panel();
            this.label231 = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.label233 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.comb_prv_sq = new System.Windows.Forms.ComboBox();
            this.dataGridequ3 = new System.Windows.Forms.DataGridView();
            this.dataGridequ2 = new System.Windows.Forms.DataGridView();
            this.dataGridequ4 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label91 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_fuel_ins_equ = new System.Windows.Forms.Button();
            this.btn_flt_ins_equ = new System.Windows.Forms.Button();
            this.btn_oil_ins_equ = new System.Windows.Forms.Button();
            this.btn_fuel_dlt_equ = new System.Windows.Forms.Button();
            this.btn_fuel_upd_equ = new System.Windows.Forms.Button();
            this.btn_flt_dlt_equ = new System.Windows.Forms.Button();
            this.btn_flt_upd_equ = new System.Windows.Forms.Button();
            this.btn_oil_dlt_equ2 = new System.Windows.Forms.Button();
            this.btn_oil_upd_equ = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.panel54 = new System.Windows.Forms.Panel();
            this.lbl_tiersize = new System.Windows.Forms.Label();
            this.lbl_eng_size = new System.Windows.Forms.Label();
            this.lbl_ac_size = new System.Windows.Forms.Label();
            this.lbl_mg_size = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.combo_equ_show = new System.Windows.Forms.ComboBox();
            this.dataGridequ1 = new System.Windows.Forms.DataGridView();
            this.tabb4 = new System.Windows.Forms.TabPage();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.prvvv = new System.Windows.Forms.TabPage();
            this.dat_grid_prev1 = new System.Windows.Forms.DataGridView();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.lb_mod_4 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.lbl_state_prev = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.btn_bring_to_upd = new System.Windows.Forms.Button();
            this.txt_pre_4_parts = new System.Windows.Forms.TextBox();
            this.btn_pre_sho = new System.Windows.Forms.Button();
            this.lbl_prv3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label95 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel59 = new System.Windows.Forms.Panel();
            this.label185 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.lbl_prv5 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.lbl_prv6 = new System.Windows.Forms.Label();
            this.panel58 = new System.Windows.Forms.Panel();
            this.txt_pre_3_hours = new System.Windows.Forms.Label();
            this.txt_pre_3_numm = new System.Windows.Forms.Label();
            this.lbl_interval = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.lbl_prv_hrs_stage4 = new System.Windows.Forms.Label();
            this.panel57 = new System.Windows.Forms.Panel();
            this.lbl_hours_ins2 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label237 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.label236 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.txt_pre_0_now_hours = new System.Windows.Forms.TextBox();
            this.btn_add_labor = new System.Windows.Forms.Button();
            this.btn_del_labor = new System.Windows.Forms.Button();
            this.btn_prev_main_ins_upd = new System.Windows.Forms.Button();
            this.date_prv = new System.Windows.Forms.DateTimePicker();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.pnl_labor = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.flow_labor = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_prv2 = new System.Windows.Forms.Label();
            this.txt_pre_7_det = new System.Windows.Forms.TextBox();
            this.txt_pre_6_cost = new System.Windows.Forms.TextBox();
            this.lbl_hours_ins1 = new System.Windows.Forms.Label();
            this.lbl_prv_hrs_stage3 = new System.Windows.Forms.Label();
            this.pnl_last_hours = new System.Windows.Forms.Panel();
            this.lbl_lastH = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_pre_5_stat_1 = new System.Windows.Forms.TextBox();
            this.txt_pre_2_type_number = new System.Windows.Forms.TextBox();
            this.txt_pre_8_user = new System.Windows.Forms.TextBox();
            this.txt_pre_10_stat_2 = new System.Windows.Forms.TextBox();
            this.txt_pre_9_type_name = new System.Windows.Forms.TextBox();
            this.txt_pre_1_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_prv_after = new System.Windows.Forms.Label();
            this.lowww_prv = new System.Windows.Forms.Label();
            this.btn_pre_upd = new System.Windows.Forms.Button();
            this.lbl_prv8 = new System.Windows.Forms.Label();
            this.lbl_prv4 = new System.Windows.Forms.Label();
            this.lbl_prv1 = new System.Windows.Forms.Label();
            this.comb_prev_main1 = new System.Windows.Forms.ComboBox();
            this.corr = new System.Windows.Forms.TabPage();
            this.btn_cor_bring = new System.Windows.Forms.Button();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.lb_mod_5 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.lbl_cor_name = new System.Windows.Forms.Label();
            this.lbl_dai_corr_state1 = new System.Windows.Forms.Label();
            this.lbl_dai_state1 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.txt_main_ins81 = new System.Windows.Forms.TextBox();
            this.txt_main_id1 = new System.Windows.Forms.TextBox();
            this.txt_cor_state = new System.Windows.Forms.TextBox();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.datagrid_cor_notdone = new System.Windows.Forms.DataGridView();
            this.combo_cor_equ = new System.Windows.Forms.ComboBox();
            this.lbl_cor_not_done = new System.Windows.Forms.Label();
            this.pnl_cor = new System.Windows.Forms.Panel();
            this.label175 = new System.Windows.Forms.Label();
            this.txt_cor_dura = new System.Windows.Forms.TextBox();
            this.label158 = new System.Windows.Forms.Label();
            this.btn_cor_del_lapor = new System.Windows.Forms.Button();
            this.btn_cor_add_lapor = new System.Windows.Forms.Button();
            this.radi_cor_notdone = new System.Windows.Forms.RadioButton();
            this.radi_cor_done = new System.Windows.Forms.RadioButton();
            this.txt_cor_deta = new System.Windows.Forms.TextBox();
            this.txt_cor_cost = new System.Windows.Forms.TextBox();
            this.txt_main_ins31 = new System.Windows.Forms.TextBox();
            this.txt_cor_parts = new System.Windows.Forms.TextBox();
            this.date_cor = new System.Windows.Forms.DateTimePicker();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.btn_cor_step2 = new System.Windows.Forms.Button();
            this.label161 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.flow_cor_labors = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_cor_names = new System.Windows.Forms.Panel();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.daii = new System.Windows.Forms.TabPage();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.lb_mod_6 = new System.Windows.Forms.Label();
            this.label210 = new System.Windows.Forms.Label();
            this.lbl_main_name = new System.Windows.Forms.Label();
            this.lbl_check_id = new System.Windows.Forms.Label();
            this.lbl_dai_state = new System.Windows.Forms.Label();
            this.lbl_dai_parts = new System.Windows.Forms.Label();
            this.panel_dai = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label96 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.flow_dai = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_dai_corr_state = new System.Windows.Forms.Label();
            this.dataGrid_cor_dai = new System.Windows.Forms.DataGridView();
            this.comb_CP_main_equ = new System.Windows.Forms.ComboBox();
            this.label107 = new System.Windows.Forms.Label();
            this.btn_bring_to_upd2 = new System.Windows.Forms.Button();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txt_main_ins8 = new System.Windows.Forms.TextBox();
            this.txt_main_id = new System.Windows.Forms.TextBox();
            this.txt_main_stg_det_corr = new System.Windows.Forms.TextBox();
            this.txt_main_ins5 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label177 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_duration2 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.btn_del_labor2 = new System.Windows.Forms.Button();
            this.btn_Corr_main_ins_upd = new System.Windows.Forms.Button();
            this.btn_add_labor2 = new System.Windows.Forms.Button();
            this.radio_corr_dai_Not_done = new System.Windows.Forms.RadioButton();
            this.radio_corr_dai_done = new System.Windows.Forms.RadioButton();
            this.txt_main_ins7 = new System.Windows.Forms.TextBox();
            this.flow_labor2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_main_ins6 = new System.Windows.Forms.TextBox();
            this.pnl_labor2 = new System.Windows.Forms.Panel();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.txt_main_ins4 = new System.Windows.Forms.TextBox();
            this.date_main_ins = new System.Windows.Forms.DateTimePicker();
            this.label58 = new System.Windows.Forms.Label();
            this.txt_main_ins3 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabb5 = new System.Windows.Forms.TabPage();
            this.tabControl8 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.where = new System.Windows.Forms.Label();
            this.main_iiid = new System.Windows.Forms.Label();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel37 = new System.Windows.Forms.Panel();
            this.label155 = new System.Windows.Forms.Label();
            this.comb_oil_del_equ = new System.Windows.Forms.ComboBox();
            this.btn_oil_sho = new System.Windows.Forms.Button();
            this.pnl_oil_up_del = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txt_oil_rep_up3 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txt_oil_rep_up2 = new System.Windows.Forms.TextBox();
            this.txt_oil_rep_up1 = new System.Windows.Forms.TextBox();
            this.txt_oil_rep_up0 = new System.Windows.Forms.TextBox();
            this.label194 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label218 = new System.Windows.Forms.Label();
            this.label222 = new System.Windows.Forms.Label();
            this.label223 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_oil_del = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comb_oil_del = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_oil_upd = new System.Windows.Forms.Button();
            this.date_oil_upd1 = new System.Windows.Forms.DateTimePicker();
            this.txt_oil_upd6 = new System.Windows.Forms.TextBox();
            this.txt_oil_upd5 = new System.Windows.Forms.TextBox();
            this.txt_oil_upd4 = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.lb_mod_7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_oil_upd_main_type = new System.Windows.Forms.TextBox();
            this.panel41 = new System.Windows.Forms.Panel();
            this.label190 = new System.Windows.Forms.Label();
            this.pnl_oil_ins = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label101 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel43 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txt_oil_rep_ins0 = new System.Windows.Forms.TextBox();
            this.label193 = new System.Windows.Forms.Label();
            this.label221 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.txt_oil_rep_ins3 = new System.Windows.Forms.TextBox();
            this.txt_oil_rep_ins2 = new System.Windows.Forms.TextBox();
            this.txt_oil_rep_ins1 = new System.Windows.Forms.TextBox();
            this.lbl_oil_what = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comb_oil_types = new System.Windows.Forms.ComboBox();
            this.label191 = new System.Windows.Forms.Label();
            this.txt_oil_ins2 = new System.Windows.Forms.TextBox();
            this.btn_oil_ins = new System.Windows.Forms.Button();
            this.txt_oil_ins3 = new System.Windows.Forms.TextBox();
            this.txt_oi_state = new System.Windows.Forms.TextBox();
            this.txt_oi_ma_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_oil_ins4 = new System.Windows.Forms.TextBox();
            this.date_oil_ins1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_oil_ins = new System.Windows.Forms.ComboBox();
            this.label104 = new System.Windows.Forms.Label();
            this.pnl_oil = new System.Windows.Forms.Panel();
            this.rdio_oil_cata = new System.Windows.Forms.RadioButton();
            this.rdio_oil_add = new System.Windows.Forms.RadioButton();
            this.rdio_oil_new = new System.Windows.Forms.RadioButton();
            this.txt_oil_upd_main_alert = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txt_oil_upd_main_state = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.txt_oil_upd8 = new System.Windows.Forms.TextBox();
            this.txt_oil_upd1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_oil_upd2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label55 = new System.Windows.Forms.Label();
            this.txt_fuel_upd1 = new System.Windows.Forms.TextBox();
            this.txt_fuel_ins2 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_fuel_ins5 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_fuel_upd8 = new System.Windows.Forms.TextBox();
            this.pnl_fue_edi = new System.Windows.Forms.Panel();
            this.pnl_filer_fuel_del = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label197 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btn_fuel_upd = new System.Windows.Forms.Button();
            this.date_fuel_upd = new System.Windows.Forms.DateTimePicker();
            this.txt_fuel_upd6 = new System.Windows.Forms.TextBox();
            this.txt_fuel_upd5 = new System.Windows.Forms.TextBox();
            this.btn_fuel_del = new System.Windows.Forms.Button();
            this.comb_fuel_del = new System.Windows.Forms.ComboBox();
            this.btn_fuel_sho = new System.Windows.Forms.Button();
            this.label173 = new System.Windows.Forms.Label();
            this.comb_fuel_del_equ = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.pnl_fue_ins = new System.Windows.Forms.Panel();
            this.label196 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.panel49 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label157 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label241 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label187 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txt_fuel_ins1 = new System.Windows.Forms.TextBox();
            this.date_fuel_ins = new System.Windows.Forms.DateTimePicker();
            this.txt_fuel_ins4 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txt_fuel_ins3 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.btn_fuel_ins = new System.Windows.Forms.Button();
            this.label169 = new System.Windows.Forms.Label();
            this.comb_fuel_ins_equ = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_fuel_upd2 = new System.Windows.Forms.TextBox();
            this.txt_fuel_upd4 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pnl_tech_ins = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.btn_labor_ins = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txt_wrk_hrs_ins = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.txt_wrker_name = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.pnl_tech_ed = new System.Windows.Forms.Panel();
            this.label74 = new System.Windows.Forms.Label();
            this.combo_laboe_upd = new System.Windows.Forms.ComboBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel46 = new System.Windows.Forms.Panel();
            this.label85 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.btn_labor_del = new System.Windows.Forms.Button();
            this.btn_labor_upd = new System.Windows.Forms.Button();
            this.txt_lp_up_name = new System.Windows.Forms.TextBox();
            this.txt_lp_up_hours = new System.Windows.Forms.TextBox();
            this.txt_lp_up_salary = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pnl_filt_ed = new System.Windows.Forms.Panel();
            this.label188 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label224 = new System.Windows.Forms.Label();
            this.txt_fil_rep_up0 = new System.Windows.Forms.TextBox();
            this.txt_fil_rep_up3 = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.txt_fil_rep_up2 = new System.Windows.Forms.TextBox();
            this.txt_fil_rep_up1 = new System.Windows.Forms.TextBox();
            this.lbl_what_filter = new System.Windows.Forms.Label();
            this.comb_flt_del = new System.Windows.Forms.ComboBox();
            this.btn_del_filt = new System.Windows.Forms.Button();
            this.label124 = new System.Windows.Forms.Label();
            this.btn_flt_upd = new System.Windows.Forms.Button();
            this.label154 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.dat_filt_upd1 = new System.Windows.Forms.DateTimePicker();
            this.txt_filt_upd6 = new System.Windows.Forms.TextBox();
            this.txt_filt_upd5 = new System.Windows.Forms.TextBox();
            this.txt_filt_upd4 = new System.Windows.Forms.TextBox();
            this.btn_flt_sho = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comb_flt_del_equ = new System.Windows.Forms.ComboBox();
            this.txt_filt_upd2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pnl_filt_ins = new System.Windows.Forms.Panel();
            this.label75 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.panel42 = new System.Windows.Forms.Panel();
            this.rdio_filt_new = new System.Windows.Forms.RadioButton();
            this.rdio_filt_change = new System.Windows.Forms.RadioButton();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label133 = new System.Windows.Forms.Label();
            this.txt_fil_rep0 = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_fil_rep3 = new System.Windows.Forms.TextBox();
            this.txt_fil_rep2 = new System.Windows.Forms.TextBox();
            this.txt_fil_rep1 = new System.Windows.Forms.TextBox();
            this.label146 = new System.Windows.Forms.Label();
            this.combo_change_filter = new System.Windows.Forms.ComboBox();
            this.btn_ins_filt = new System.Windows.Forms.Button();
            this.txtfilter2 = new System.Windows.Forms.TextBox();
            this.txtfilter3 = new System.Windows.Forms.TextBox();
            this.txtfilter4 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.datefilter1 = new System.Windows.Forms.DateTimePicker();
            this.label48 = new System.Windows.Forms.Label();
            this.txtfilter1 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.panel50 = new System.Windows.Forms.Panel();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label242 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label243 = new System.Windows.Forms.Label();
            this.combo_filter_equ_ins = new System.Windows.Forms.ComboBox();
            this.txtfilter5 = new System.Windows.Forms.TextBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_filt_upd1 = new System.Windows.Forms.TextBox();
            this.txt_filt_upd8 = new System.Windows.Forms.TextBox();
            this.equTableAdapter = new notfinal.hopeDataSetTableAdapters.equTableAdapter();
            this.workerTableAdapter = new notfinal.hopeDataSetTableAdapters.workerTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertOilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalRefillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOilTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMainOilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUsedFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFilterTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editActiveFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.newFuelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLiterCostToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicMaintenanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicMaintenanceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicianReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availabilityAndUtilizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oilTableAdapter = new notfinal.hopeDataSetTableAdapters.oilTableAdapter();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterTableAdapter = new notfinal.hopeDataSetTableAdapters.filterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hopeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopeDataSet)).BeginInit();
            this.tabb3.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.main_rep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_totalCost.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel60.SuspendLayout();
            this.panel61.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel39.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel22.SuspendLayout();
            this.filter_rep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel31.SuspendLayout();
            this.labor_rep.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_report_lp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.usa_ava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.cos_rep.SuspendLayout();
            this.panel62.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel47.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).BeginInit();
            this.tabb2.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabb0.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pnl_posting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picoil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pnl_maint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnl_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel19.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel27.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabb1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel55.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel56.SuspendLayout();
            this.panel53.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ4)).BeginInit();
            this.panel51.SuspendLayout();
            this.panel54.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ1)).BeginInit();
            this.tabb4.SuspendLayout();
            this.tabControl7.SuspendLayout();
            this.prvvv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_grid_prev1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel59.SuspendLayout();
            this.panel58.SuspendLayout();
            this.panel57.SuspendLayout();
            this.panel32.SuspendLayout();
            this.pnl_labor.SuspendLayout();
            this.pnl_last_hours.SuspendLayout();
            this.corr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_cor_notdone)).BeginInit();
            this.pnl_cor.SuspendLayout();
            this.pnl_cor_names.SuspendLayout();
            this.daii.SuspendLayout();
            this.panel_dai.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cor_dai)).BeginInit();
            this.panel12.SuspendLayout();
            this.pnl_labor2.SuspendLayout();
            this.tabb5.SuspendLayout();
            this.tabControl8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel37.SuspendLayout();
            this.pnl_oil_up_del.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel41.SuspendLayout();
            this.pnl_oil_ins.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel43.SuspendLayout();
            this.pnl_oil.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl_fue_edi.SuspendLayout();
            this.pnl_filer_fuel_del.SuspendLayout();
            this.pnl_fue_ins.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel45.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.pnl_tech_ins.SuspendLayout();
            this.panel33.SuspendLayout();
            this.pnl_tech_ed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.panel46.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.pnl_filt_ed.SuspendLayout();
            this.panel44.SuspendLayout();
            this.panel25.SuspendLayout();
            this.pnl_filt_ins.SuspendLayout();
            this.panel42.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel50.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hopeDataSetBindingSource
            // 
            this.hopeDataSetBindingSource.DataSource = this.hopeDataSet;
            this.hopeDataSetBindingSource.Position = 0;
            // 
            // hopeDataSet
            // 
            this.hopeDataSet.DataSetName = "hopeDataSet";
            this.hopeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabb3
            // 
            this.tabb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabb3.Controls.Add(this.tabControl6);
            resources.ApplyResources(this.tabb3, "tabb3");
            this.tabb3.Name = "tabb3";
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.main_rep);
            this.tabControl6.Controls.Add(this.tabPage7);
            this.tabControl6.Controls.Add(this.tabPage8);
            this.tabControl6.Controls.Add(this.filter_rep);
            this.tabControl6.Controls.Add(this.labor_rep);
            this.tabControl6.Controls.Add(this.usa_ava);
            this.tabControl6.Controls.Add(this.cos_rep);
            this.tabControl6.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControl6, "tabControl6");
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            // 
            // main_rep
            // 
            this.main_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.main_rep.Controls.Add(this.label253);
            this.main_rep.Controls.Add(this.label254);
            this.main_rep.Controls.Add(this.btn_report);
            this.main_rep.Controls.Add(this.lb_mod_31);
            this.main_rep.Controls.Add(this.txt_rep_word);
            this.main_rep.Controls.Add(this.dataGridView1);
            this.main_rep.Controls.Add(this.txt_cost2);
            this.main_rep.Controls.Add(this.txt_cost1);
            this.main_rep.Controls.Add(this.pnl_totalCost);
            this.main_rep.Controls.Add(this.panel11);
            this.main_rep.Controls.Add(this.panel9);
            this.main_rep.Controls.Add(this.label113);
            this.main_rep.Controls.Add(this.label110);
            this.main_rep.Controls.Add(this.com_report);
            this.main_rep.Controls.Add(this.check_daily);
            this.main_rep.Controls.Add(this.date_old);
            this.main_rep.Controls.Add(this.check_corr);
            this.main_rep.Controls.Add(this.date_new);
            this.main_rep.Controls.Add(this.check_prev);
            this.main_rep.Controls.Add(this.radio_done);
            this.main_rep.Controls.Add(this.radio_not);
            this.main_rep.Controls.Add(this.panel61);
            resources.ApplyResources(this.main_rep, "main_rep");
            this.main_rep.Name = "main_rep";
            // 
            // label253
            // 
            resources.ApplyResources(this.label253, "label253");
            this.label253.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label253.Name = "label253";
            // 
            // label254
            // 
            resources.ApplyResources(this.label254, "label254");
            this.label254.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label254.Name = "label254";
            // 
            // btn_report
            // 
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_report, "btn_report");
            this.btn_report.Name = "btn_report";
            this.btn_report.TabStop = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // lb_mod_31
            // 
            resources.ApplyResources(this.lb_mod_31, "lb_mod_31");
            this.lb_mod_31.Name = "lb_mod_31";
            // 
            // txt_rep_word
            // 
            this.txt_rep_word.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_rep_word, "txt_rep_word");
            this.txt_rep_word.Name = "txt_rep_word";
            this.txt_rep_word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column12,
            this.Column6,
            this.Column13,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column9,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.VirtualMode = true;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            resources.ApplyResources(this.Column10, "Column10");
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            resources.ApplyResources(this.Column12, "Column12");
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column13
            // 
            resources.ApplyResources(this.Column13, "Column13");
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column18
            // 
            resources.ApplyResources(this.Column18, "Column18");
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            resources.ApplyResources(this.Column19, "Column19");
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            resources.ApplyResources(this.Column20, "Column20");
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column9
            // 
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txt_cost2
            // 
            this.txt_cost2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_cost2, "txt_cost2");
            this.txt_cost2.Name = "txt_cost2";
            this.txt_cost2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            this.txt_cost2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_cost1
            // 
            this.txt_cost1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_cost1, "txt_cost1");
            this.txt_cost1.Name = "txt_cost1";
            this.txt_cost1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            this.txt_cost1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // pnl_totalCost
            // 
            this.pnl_totalCost.Controls.Add(this.chk_cost3);
            this.pnl_totalCost.Controls.Add(this.txt_cost3);
            resources.ApplyResources(this.pnl_totalCost, "pnl_totalCost");
            this.pnl_totalCost.Name = "pnl_totalCost";
            // 
            // chk_cost3
            // 
            resources.ApplyResources(this.chk_cost3, "chk_cost3");
            this.chk_cost3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chk_cost3.Name = "chk_cost3";
            this.chk_cost3.UseVisualStyleBackColor = true;
            this.chk_cost3.CheckedChanged += new System.EventHandler(this.chk_cost3_CheckedChanged);
            // 
            // txt_cost3
            // 
            this.txt_cost3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_cost3, "txt_cost3");
            this.txt_cost3.Name = "txt_cost3";
            this.txt_cost3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            this.txt_cost3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button21);
            this.panel11.Controls.Add(this.button10);
            this.panel11.Controls.Add(this.button2);
            this.panel11.Controls.Add(this.button5);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button21, "button21");
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Name = "button21";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button10, "button10");
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Name = "button10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel60);
            this.panel9.Controls.Add(this.label216);
            this.panel9.Controls.Add(this.label139);
            this.panel9.Controls.Add(this.label93);
            this.panel9.Controls.Add(this.label116);
            this.panel9.Controls.Add(this.label121);
            this.panel9.Controls.Add(this.label118);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel60
            // 
            this.panel60.Controls.Add(this.label217);
            this.panel60.Controls.Add(this.label138);
            this.panel60.Controls.Add(this.label94);
            this.panel60.Controls.Add(this.label122);
            this.panel60.Controls.Add(this.label120);
            this.panel60.Controls.Add(this.label119);
            resources.ApplyResources(this.panel60, "panel60");
            this.panel60.Name = "panel60";
            // 
            // label217
            // 
            resources.ApplyResources(this.label217, "label217");
            this.label217.ForeColor = System.Drawing.Color.White;
            this.label217.Name = "label217";
            // 
            // label138
            // 
            resources.ApplyResources(this.label138, "label138");
            this.label138.ForeColor = System.Drawing.Color.White;
            this.label138.Name = "label138";
            // 
            // label94
            // 
            resources.ApplyResources(this.label94, "label94");
            this.label94.ForeColor = System.Drawing.Color.White;
            this.label94.Name = "label94";
            // 
            // label122
            // 
            resources.ApplyResources(this.label122, "label122");
            this.label122.ForeColor = System.Drawing.Color.White;
            this.label122.Name = "label122";
            // 
            // label120
            // 
            resources.ApplyResources(this.label120, "label120");
            this.label120.ForeColor = System.Drawing.Color.White;
            this.label120.Name = "label120";
            // 
            // label119
            // 
            resources.ApplyResources(this.label119, "label119");
            this.label119.ForeColor = System.Drawing.Color.White;
            this.label119.Name = "label119";
            // 
            // label216
            // 
            resources.ApplyResources(this.label216, "label216");
            this.label216.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label216.Name = "label216";
            // 
            // label139
            // 
            resources.ApplyResources(this.label139, "label139");
            this.label139.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label139.Name = "label139";
            // 
            // label93
            // 
            resources.ApplyResources(this.label93, "label93");
            this.label93.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label93.Name = "label93";
            // 
            // label116
            // 
            resources.ApplyResources(this.label116, "label116");
            this.label116.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label116.Name = "label116";
            // 
            // label121
            // 
            resources.ApplyResources(this.label121, "label121");
            this.label121.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label121.Name = "label121";
            // 
            // label118
            // 
            resources.ApplyResources(this.label118, "label118");
            this.label118.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label118.Name = "label118";
            // 
            // label113
            // 
            resources.ApplyResources(this.label113, "label113");
            this.label113.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label113.Name = "label113";
            // 
            // label110
            // 
            resources.ApplyResources(this.label110, "label110");
            this.label110.ForeColor = System.Drawing.Color.Red;
            this.label110.Name = "label110";
            // 
            // com_report
            // 
            this.com_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.com_report.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.com_report, "com_report");
            this.com_report.FormattingEnabled = true;
            this.com_report.Name = "com_report";
            this.com_report.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_daily
            // 
            resources.ApplyResources(this.check_daily, "check_daily");
            this.check_daily.Checked = true;
            this.check_daily.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_daily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_daily.ForeColor = System.Drawing.Color.White;
            this.check_daily.Name = "check_daily";
            this.check_daily.UseVisualStyleBackColor = true;
            this.check_daily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // date_old
            // 
            this.date_old.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_old, "date_old");
            this.date_old.Name = "date_old";
            this.date_old.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_corr
            // 
            resources.ApplyResources(this.check_corr, "check_corr");
            this.check_corr.Checked = true;
            this.check_corr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_corr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_corr.ForeColor = System.Drawing.Color.White;
            this.check_corr.Name = "check_corr";
            this.check_corr.UseVisualStyleBackColor = true;
            this.check_corr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // date_new
            // 
            this.date_new.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_new, "date_new");
            this.date_new.Name = "date_new";
            this.date_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_prev
            // 
            resources.ApplyResources(this.check_prev, "check_prev");
            this.check_prev.Checked = true;
            this.check_prev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_prev.ForeColor = System.Drawing.Color.White;
            this.check_prev.Name = "check_prev";
            this.check_prev.UseVisualStyleBackColor = true;
            this.check_prev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // radio_done
            // 
            resources.ApplyResources(this.radio_done, "radio_done");
            this.radio_done.Checked = true;
            this.radio_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_done.ForeColor = System.Drawing.Color.White;
            this.radio_done.Name = "radio_done";
            this.radio_done.TabStop = true;
            this.radio_done.Tag = "1";
            this.radio_done.UseVisualStyleBackColor = true;
            this.radio_done.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // radio_not
            // 
            resources.ApplyResources(this.radio_not, "radio_not");
            this.radio_not.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_not.ForeColor = System.Drawing.Color.White;
            this.radio_not.Name = "radio_not";
            this.radio_not.Tag = "1";
            this.radio_not.UseVisualStyleBackColor = true;
            this.radio_not.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.chk_rep_word);
            this.panel61.Controls.Add(this.check_type);
            this.panel61.Controls.Add(this.check_date);
            this.panel61.Controls.Add(this.check_cost);
            this.panel61.Controls.Add(this.check_state);
            this.panel61.Controls.Add(this.check_id);
            resources.ApplyResources(this.panel61, "panel61");
            this.panel61.Name = "panel61";
            // 
            // chk_rep_word
            // 
            resources.ApplyResources(this.chk_rep_word, "chk_rep_word");
            this.chk_rep_word.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_rep_word.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chk_rep_word.Name = "chk_rep_word";
            this.chk_rep_word.UseVisualStyleBackColor = true;
            this.chk_rep_word.CheckedChanged += new System.EventHandler(this.chk_rep_word_CheckedChanged);
            this.chk_rep_word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_type
            // 
            resources.ApplyResources(this.check_type, "check_type");
            this.check_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_type.ForeColor = System.Drawing.Color.DodgerBlue;
            this.check_type.Name = "check_type";
            this.check_type.UseVisualStyleBackColor = true;
            this.check_type.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.check_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_date
            // 
            resources.ApplyResources(this.check_date, "check_date");
            this.check_date.Checked = true;
            this.check_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_date.ForeColor = System.Drawing.Color.DodgerBlue;
            this.check_date.Name = "check_date";
            this.check_date.UseVisualStyleBackColor = true;
            this.check_date.CheckedChanged += new System.EventHandler(this.check_date_CheckedChanged);
            this.check_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_cost
            // 
            resources.ApplyResources(this.check_cost, "check_cost");
            this.check_cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_cost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.check_cost.Name = "check_cost";
            this.check_cost.UseVisualStyleBackColor = true;
            this.check_cost.CheckedChanged += new System.EventHandler(this.check_cost_CheckedChanged);
            this.check_cost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_state
            // 
            resources.ApplyResources(this.check_state, "check_state");
            this.check_state.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_state.ForeColor = System.Drawing.Color.DodgerBlue;
            this.check_state.Name = "check_state";
            this.check_state.UseVisualStyleBackColor = true;
            this.check_state.CheckedChanged += new System.EventHandler(this.check_state_CheckedChanged);
            this.check_state.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // check_id
            // 
            resources.ApplyResources(this.check_id, "check_id");
            this.check_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.check_id.Name = "check_id";
            this.check_id.UseVisualStyleBackColor = true;
            this.check_id.CheckedChanged += new System.EventHandler(this.check_id_CheckedChanged);
            this.check_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_report_KeyDown);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage7.Controls.Add(this.label251);
            this.tabPage7.Controls.Add(this.label252);
            this.tabPage7.Controls.Add(this.flowLayoutPanel3);
            this.tabPage7.Controls.Add(this.label207);
            this.tabPage7.Controls.Add(this.label213);
            this.tabPage7.Controls.Add(this.panel40);
            this.tabPage7.Controls.Add(this.checkBox14);
            this.tabPage7.Controls.Add(this.panel39);
            this.tabPage7.Controls.Add(this.checkBox16);
            this.tabPage7.Controls.Add(this.checkBox3);
            this.tabPage7.Controls.Add(this.pictureBox6);
            this.tabPage7.Controls.Add(this.panel18);
            this.tabPage7.Controls.Add(this.label27);
            this.tabPage7.Controls.Add(this.checkBox1);
            this.tabPage7.Controls.Add(this.checkBox2);
            this.tabPage7.Controls.Add(this.combo_oil_rep);
            this.tabPage7.Controls.Add(this.dateTimePicker1);
            this.tabPage7.Controls.Add(this.dateTimePicker2);
            this.tabPage7.Controls.Add(this.checkBox6);
            this.tabPage7.Controls.Add(this.dataGridView6);
            this.tabPage7.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            // 
            // label251
            // 
            resources.ApplyResources(this.label251, "label251");
            this.label251.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label251.Name = "label251";
            // 
            // label252
            // 
            resources.ApplyResources(this.label252, "label252");
            this.label252.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label252.Name = "label252";
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // label207
            // 
            resources.ApplyResources(this.label207, "label207");
            this.label207.ForeColor = System.Drawing.Color.White;
            this.label207.Name = "label207";
            // 
            // label213
            // 
            resources.ApplyResources(this.label213, "label213");
            this.label213.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label213.Name = "label213";
            // 
            // panel40
            // 
            resources.ApplyResources(this.panel40, "panel40");
            this.panel40.Controls.Add(this.label76);
            this.panel40.Controls.Add(this.label189);
            this.panel40.Name = "panel40";
            // 
            // label76
            // 
            resources.ApplyResources(this.label76, "label76");
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Name = "label76";
            // 
            // label189
            // 
            resources.ApplyResources(this.label189, "label189");
            this.label189.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label189.Name = "label189";
            // 
            // checkBox14
            // 
            resources.ApplyResources(this.checkBox14, "checkBox14");
            this.checkBox14.ForeColor = System.Drawing.Color.White;
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.checkBox4);
            this.panel39.Controls.Add(this.checkBox15);
            resources.ApplyResources(this.panel39, "panel39");
            this.panel39.Name = "panel39";
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // checkBox15
            // 
            resources.ApplyResources(this.checkBox15, "checkBox15");
            this.checkBox15.Checked = true;
            this.checkBox15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox15.ForeColor = System.Drawing.Color.White;
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // checkBox16
            // 
            resources.ApplyResources(this.checkBox16, "checkBox16");
            this.checkBox16.ForeColor = System.Drawing.Color.White;
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            this.checkBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.button30);
            this.panel18.Controls.Add(this.button12);
            this.panel18.Controls.Add(this.button13);
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button30, "button30");
            this.button30.Name = "button30";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button12, "button12");
            this.button12.Name = "button12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label27.Name = "label27";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // combo_oil_rep
            // 
            this.combo_oil_rep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_oil_rep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combo_oil_rep, "combo_oil_rep");
            this.combo_oil_rep.FormattingEnabled = true;
            this.combo_oil_rep.Name = "combo_oil_rep";
            this.combo_oil_rep.SelectedIndexChanged += new System.EventHandler(this.combo_oil_rep_SelectedIndexChanged);
            this.combo_oil_rep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.oil_rep_CheckedChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.oil_rep_CheckedChanged);
            this.dateTimePicker2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.dataGridView6, "dataGridView6");
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30,
            this.Column31,
            this.Column32,
            this.Column33,
            this.Column34});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView6.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView6.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView6.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView6.RowTemplate.ReadOnly = true;
            this.dataGridView6.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.VirtualMode = true;
            // 
            // Column26
            // 
            resources.ApplyResources(this.Column26, "Column26");
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            // 
            // Column27
            // 
            resources.ApplyResources(this.Column27, "Column27");
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            // 
            // Column28
            // 
            resources.ApplyResources(this.Column28, "Column28");
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            // 
            // Column29
            // 
            resources.ApplyResources(this.Column29, "Column29");
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            // 
            // Column30
            // 
            resources.ApplyResources(this.Column30, "Column30");
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            // 
            // Column31
            // 
            resources.ApplyResources(this.Column31, "Column31");
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            // 
            // Column32
            // 
            resources.ApplyResources(this.Column32, "Column32");
            this.Column32.Name = "Column32";
            this.Column32.ReadOnly = true;
            // 
            // Column33
            // 
            resources.ApplyResources(this.Column33, "Column33");
            this.Column33.Name = "Column33";
            this.Column33.ReadOnly = true;
            // 
            // Column34
            // 
            resources.ApplyResources(this.Column34, "Column34");
            this.Column34.Name = "Column34";
            this.Column34.ReadOnly = true;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage8.Controls.Add(this.label249);
            this.tabPage8.Controls.Add(this.label250);
            this.tabPage8.Controls.Add(this.label214);
            this.tabPage8.Controls.Add(this.label215);
            this.tabPage8.Controls.Add(this.dataGridView7);
            this.tabPage8.Controls.Add(this.panel24);
            this.tabPage8.Controls.Add(this.pictureBox7);
            this.tabPage8.Controls.Add(this.panel22);
            this.tabPage8.Controls.Add(this.label28);
            this.tabPage8.Controls.Add(this.checkBox8);
            this.tabPage8.Controls.Add(this.comboBox4);
            this.tabPage8.Controls.Add(this.dateTimePicker3);
            this.tabPage8.Controls.Add(this.dateTimePicker4);
            this.tabPage8.Controls.Add(this.checkBox12);
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            // 
            // label249
            // 
            resources.ApplyResources(this.label249, "label249");
            this.label249.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label249.Name = "label249";
            // 
            // label250
            // 
            resources.ApplyResources(this.label250, "label250");
            this.label250.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label250.Name = "label250";
            // 
            // label214
            // 
            resources.ApplyResources(this.label214, "label214");
            this.label214.ForeColor = System.Drawing.Color.White;
            this.label214.Name = "label214";
            // 
            // label215
            // 
            resources.ApplyResources(this.label215, "label215");
            this.label215.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label215.Name = "label215";
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView7.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView7.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView7.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.dataGridView7, "dataGridView7");
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column35,
            this.Column36,
            this.Column37,
            this.Column38,
            this.Column39,
            this.Column40,
            this.Column41});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView7.MultiSelect = false;
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView7.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView7.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView7.RowTemplate.ReadOnly = true;
            this.dataGridView7.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.VirtualMode = true;
            // 
            // Column35
            // 
            resources.ApplyResources(this.Column35, "Column35");
            this.Column35.Name = "Column35";
            this.Column35.ReadOnly = true;
            // 
            // Column36
            // 
            resources.ApplyResources(this.Column36, "Column36");
            this.Column36.Name = "Column36";
            this.Column36.ReadOnly = true;
            // 
            // Column37
            // 
            resources.ApplyResources(this.Column37, "Column37");
            this.Column37.Name = "Column37";
            this.Column37.ReadOnly = true;
            // 
            // Column38
            // 
            resources.ApplyResources(this.Column38, "Column38");
            this.Column38.Name = "Column38";
            this.Column38.ReadOnly = true;
            // 
            // Column39
            // 
            resources.ApplyResources(this.Column39, "Column39");
            this.Column39.Name = "Column39";
            this.Column39.ReadOnly = true;
            // 
            // Column40
            // 
            resources.ApplyResources(this.Column40, "Column40");
            this.Column40.Name = "Column40";
            this.Column40.ReadOnly = true;
            // 
            // Column41
            // 
            resources.ApplyResources(this.Column41, "Column41");
            this.Column41.Name = "Column41";
            this.Column41.ReadOnly = true;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.label198);
            this.panel24.Controls.Add(this.label199);
            resources.ApplyResources(this.panel24, "panel24");
            this.panel24.Name = "panel24";
            // 
            // label198
            // 
            resources.ApplyResources(this.label198, "label198");
            this.label198.ForeColor = System.Drawing.Color.White;
            this.label198.Name = "label198";
            // 
            // label199
            // 
            resources.ApplyResources(this.label199, "label199");
            this.label199.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label199.Name = "label199";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.button31);
            this.panel22.Controls.Add(this.button15);
            this.panel22.Controls.Add(this.button16);
            resources.ApplyResources(this.panel22, "panel22");
            this.panel22.Name = "panel22";
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button31, "button31");
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Name = "button31";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button15, "button15");
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button16, "button16");
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Name = "button16";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label28.Name = "label28";
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            this.checkBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox4_KeyDown);
            // 
            // comboBox4
            // 
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox4, "comboBox4");
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox4_KeyDown);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker3, "dateTimePicker3");
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox4_KeyDown);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker4, "dateTimePicker4");
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox4_KeyDown);
            // 
            // checkBox12
            // 
            resources.ApplyResources(this.checkBox12, "checkBox12");
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // filter_rep
            // 
            this.filter_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.filter_rep.Controls.Add(this.label244);
            this.filter_rep.Controls.Add(this.label245);
            this.filter_rep.Controls.Add(this.checkBox7);
            this.filter_rep.Controls.Add(this.comboBox8);
            this.filter_rep.Controls.Add(this.checkBox9);
            this.filter_rep.Controls.Add(this.comboBox7);
            this.filter_rep.Controls.Add(this.dataGridView4);
            this.filter_rep.Controls.Add(this.panel30);
            this.filter_rep.Controls.Add(this.pictureBox12);
            this.filter_rep.Controls.Add(this.panel31);
            this.filter_rep.Controls.Add(this.label235);
            this.filter_rep.Controls.Add(this.checkBox5);
            this.filter_rep.Controls.Add(this.comboBox6);
            this.filter_rep.Controls.Add(this.dateTimePicker6);
            this.filter_rep.Controls.Add(this.dateTimePicker7);
            resources.ApplyResources(this.filter_rep, "filter_rep");
            this.filter_rep.Name = "filter_rep";
            // 
            // label244
            // 
            resources.ApplyResources(this.label244, "label244");
            this.label244.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label244.Name = "label244";
            // 
            // label245
            // 
            resources.ApplyResources(this.label245, "label245");
            this.label245.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label245.Name = "label245";
            // 
            // checkBox7
            // 
            resources.ApplyResources(this.checkBox7, "checkBox7");
            this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            this.checkBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // comboBox8
            // 
            this.comboBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox8, "comboBox8");
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // checkBox9
            // 
            resources.ApplyResources(this.checkBox9, "checkBox9");
            this.checkBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            this.checkBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // comboBox7
            // 
            this.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox7, "comboBox7");
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            resources.ApplyResources(this.dataGridView4, "dataGridView4");
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ss,
            this.Column42,
            this.Column43,
            this.Column44,
            this.Column45,
            this.Column46,
            this.Column47,
            this.Column48});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView4.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView4.RowTemplate.ReadOnly = true;
            this.dataGridView4.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.VirtualMode = true;
            // 
            // ss
            // 
            resources.ApplyResources(this.ss, "ss");
            this.ss.Name = "ss";
            this.ss.ReadOnly = true;
            // 
            // Column42
            // 
            resources.ApplyResources(this.Column42, "Column42");
            this.Column42.Name = "Column42";
            this.Column42.ReadOnly = true;
            // 
            // Column43
            // 
            resources.ApplyResources(this.Column43, "Column43");
            this.Column43.Name = "Column43";
            this.Column43.ReadOnly = true;
            // 
            // Column44
            // 
            resources.ApplyResources(this.Column44, "Column44");
            this.Column44.Name = "Column44";
            this.Column44.ReadOnly = true;
            // 
            // Column45
            // 
            resources.ApplyResources(this.Column45, "Column45");
            this.Column45.Name = "Column45";
            this.Column45.ReadOnly = true;
            // 
            // Column46
            // 
            resources.ApplyResources(this.Column46, "Column46");
            this.Column46.Name = "Column46";
            this.Column46.ReadOnly = true;
            // 
            // Column47
            // 
            resources.ApplyResources(this.Column47, "Column47");
            this.Column47.Name = "Column47";
            this.Column47.ReadOnly = true;
            // 
            // Column48
            // 
            resources.ApplyResources(this.Column48, "Column48");
            this.Column48.Name = "Column48";
            this.Column48.ReadOnly = true;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.label178);
            this.panel30.Controls.Add(this.label179);
            resources.ApplyResources(this.panel30, "panel30");
            this.panel30.Name = "panel30";
            // 
            // label178
            // 
            resources.ApplyResources(this.label178, "label178");
            this.label178.ForeColor = System.Drawing.Color.White;
            this.label178.Name = "label178";
            // 
            // label179
            // 
            resources.ApplyResources(this.label179, "label179");
            this.label179.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label179.Name = "label179";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox12, "pictureBox12");
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.button32);
            this.panel31.Controls.Add(this.button14);
            this.panel31.Controls.Add(this.button17);
            resources.ApplyResources(this.panel31, "panel31");
            this.panel31.Name = "panel31";
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button32, "button32");
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Name = "button32";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button14, "button14");
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button17, "button17");
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Name = "button17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label235
            // 
            resources.ApplyResources(this.label235, "label235");
            this.label235.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label235.Name = "label235";
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            this.checkBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // comboBox6
            // 
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox6, "comboBox6");
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            this.comboBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker6, "dateTimePicker6");
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker7, "dateTimePicker7");
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox5_KeyDown);
            // 
            // labor_rep
            // 
            this.labor_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labor_rep.Controls.Add(this.lb_mod_32);
            this.labor_rep.Controls.Add(this.panel10);
            this.labor_rep.Controls.Add(this.panel8);
            this.labor_rep.Controls.Add(this.panel6);
            this.labor_rep.Controls.Add(this.label98);
            this.labor_rep.Controls.Add(this.dataGridView2);
            this.labor_rep.Controls.Add(this.label99);
            resources.ApplyResources(this.labor_rep, "labor_rep");
            this.labor_rep.Name = "labor_rep";
            // 
            // lb_mod_32
            // 
            resources.ApplyResources(this.lb_mod_32, "lb_mod_32");
            this.lb_mod_32.Name = "lb_mod_32";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label125);
            this.panel10.Controls.Add(this.label128);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // label125
            // 
            resources.ApplyResources(this.label125, "label125");
            this.label125.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label125.Name = "label125";
            // 
            // label128
            // 
            resources.ApplyResources(this.label128, "label128");
            this.label128.ForeColor = System.Drawing.Color.White;
            this.label128.Name = "label128";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_report_lp);
            this.panel8.Controls.Add(this.label212);
            this.panel8.Controls.Add(this.label211);
            this.panel8.Controls.Add(this.chk_date);
            this.panel8.Controls.Add(this.chk_id);
            this.panel8.Controls.Add(this.chk_equ);
            this.panel8.Controls.Add(this.date_rep_old);
            this.panel8.Controls.Add(this.combo_labor_report);
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.date_rep_new);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // btn_report_lp
            // 
            this.btn_report_lp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report_lp.Image = global::notfinal.Properties.Resources._61_E5VfZdbL__AC_SL1000_;
            resources.ApplyResources(this.btn_report_lp, "btn_report_lp");
            this.btn_report_lp.Name = "btn_report_lp";
            this.btn_report_lp.TabStop = false;
            this.btn_report_lp.Click += new System.EventHandler(this.btn_report_lp_Click);
            // 
            // label212
            // 
            resources.ApplyResources(this.label212, "label212");
            this.label212.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label212.Name = "label212";
            // 
            // label211
            // 
            resources.ApplyResources(this.label211, "label211");
            this.label211.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label211.Name = "label211";
            // 
            // chk_date
            // 
            resources.ApplyResources(this.chk_date, "chk_date");
            this.chk_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_date.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chk_date.Name = "chk_date";
            this.chk_date.UseVisualStyleBackColor = true;
            this.chk_date.CheckedChanged += new System.EventHandler(this.chk_date_CheckedChanged);
            this.chk_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_date_KeyDown);
            // 
            // chk_id
            // 
            resources.ApplyResources(this.chk_id, "chk_id");
            this.chk_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chk_id.Name = "chk_id";
            this.chk_id.UseVisualStyleBackColor = true;
            this.chk_id.CheckedChanged += new System.EventHandler(this.chk_id_CheckedChanged);
            this.chk_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_date_KeyDown);
            // 
            // chk_equ
            // 
            resources.ApplyResources(this.chk_equ, "chk_equ");
            this.chk_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_equ.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chk_equ.Name = "chk_equ";
            this.chk_equ.UseVisualStyleBackColor = true;
            this.chk_equ.CheckedChanged += new System.EventHandler(this.chk_equ_CheckedChanged);
            this.chk_equ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_date_KeyDown);
            // 
            // date_rep_old
            // 
            this.date_rep_old.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_rep_old, "date_rep_old");
            this.date_rep_old.Name = "date_rep_old";
            this.date_rep_old.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_date_KeyDown);
            // 
            // combo_labor_report
            // 
            this.combo_labor_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_labor_report.DataSource = this.workerBindingSource1;
            this.combo_labor_report.DisplayMember = "worker_name";
            this.combo_labor_report.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combo_labor_report, "combo_labor_report");
            this.combo_labor_report.FormattingEnabled = true;
            this.combo_labor_report.Name = "combo_labor_report";
            this.combo_labor_report.ValueMember = "worker_id";
            this.combo_labor_report.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_date_KeyDown);
            // 
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataMember = "worker";
            this.workerBindingSource1.DataSource = this.hopeDataSetBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_date_KeyDown);
            // 
            // date_rep_new
            // 
            this.date_rep_new.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_rep_new, "date_rep_new");
            this.date_rep_new.Name = "date_rep_new";
            this.date_rep_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chk_date_KeyDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button28);
            this.panel6.Controls.Add(this.btn_rep_lb_del);
            this.panel6.Controls.Add(this.btn_rep_lb_up);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button28, "button28");
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Name = "button28";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // btn_rep_lb_del
            // 
            this.btn_rep_lb_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rep_lb_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rep_lb_del.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_rep_lb_del, "btn_rep_lb_del");
            this.btn_rep_lb_del.ForeColor = System.Drawing.Color.White;
            this.btn_rep_lb_del.Name = "btn_rep_lb_del";
            this.btn_rep_lb_del.UseVisualStyleBackColor = false;
            this.btn_rep_lb_del.Click += new System.EventHandler(this.btn_rep_lb_del_Click);
            // 
            // btn_rep_lb_up
            // 
            this.btn_rep_lb_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rep_lb_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rep_lb_up.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_rep_lb_up, "btn_rep_lb_up");
            this.btn_rep_lb_up.ForeColor = System.Drawing.Color.White;
            this.btn_rep_lb_up.Name = "btn_rep_lb_up";
            this.btn_rep_lb_up.UseVisualStyleBackColor = false;
            this.btn_rep_lb_up.Click += new System.EventHandler(this.btn_rep_lb_up_Click);
            // 
            // label98
            // 
            resources.ApplyResources(this.label98, "label98");
            this.label98.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label98.Name = "label98";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aaa,
            this.Column11,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.VirtualMode = true;
            // 
            // aaa
            // 
            resources.ApplyResources(this.aaa, "aaa");
            this.aaa.Name = "aaa";
            this.aaa.ReadOnly = true;
            // 
            // Column11
            // 
            resources.ApplyResources(this.Column11, "Column11");
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column21
            // 
            resources.ApplyResources(this.Column21, "Column21");
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            resources.ApplyResources(this.Column22, "Column22");
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            resources.ApplyResources(this.Column23, "Column23");
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            resources.ApplyResources(this.Column24, "Column24");
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // Column25
            // 
            resources.ApplyResources(this.Column25, "Column25");
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            // 
            // label99
            // 
            resources.ApplyResources(this.label99, "label99");
            this.label99.ForeColor = System.Drawing.Color.Red;
            this.label99.Name = "label99";
            // 
            // usa_ava
            // 
            this.usa_ava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.usa_ava.Controls.Add(this.button29);
            this.usa_ava.Controls.Add(this.chart1);
            this.usa_ava.Controls.Add(this.lb_mod_33);
            this.usa_ava.Controls.Add(this.label145);
            this.usa_ava.Controls.Add(this.panel14);
            this.usa_ava.Controls.Add(this.panel13);
            this.usa_ava.Controls.Add(this.label127);
            this.usa_ava.Controls.Add(this.label126);
            this.usa_ava.Controls.Add(this.label123);
            this.usa_ava.Controls.Add(this.dataGridView5);
            this.usa_ava.Controls.Add(this.combo_use);
            this.usa_ava.Controls.Add(this.btn_use);
            this.usa_ava.Controls.Add(this.date_use_new);
            this.usa_ava.Controls.Add(this.date_use_old);
            this.usa_ava.Controls.Add(this.label131);
            resources.ApplyResources(this.usa_ava, "usa_ava");
            this.usa_ava.Name = "usa_ava";
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.button29, "button29");
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Name = "button29";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Maintain Hours";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Available Hours";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DarkGreen;
            series3.Legend = "Legend1";
            series3.Name = "Worked Hours";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            // 
            // lb_mod_33
            // 
            resources.ApplyResources(this.lb_mod_33, "lb_mod_33");
            this.lb_mod_33.Name = "lb_mod_33";
            // 
            // label145
            // 
            resources.ApplyResources(this.label145, "label145");
            this.label145.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label145.Name = "label145";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label135);
            this.panel14.Controls.Add(this.label136);
            this.panel14.Controls.Add(this.circularProgressBar2);
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // label135
            // 
            resources.ApplyResources(this.label135, "label135");
            this.label135.BackColor = System.Drawing.Color.Transparent;
            this.label135.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label135.Name = "label135";
            // 
            // label136
            // 
            resources.ApplyResources(this.label136, "label136");
            this.label136.BackColor = System.Drawing.Color.Transparent;
            this.label136.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label136.Name = "label136";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.ExponentialEaseIn;
            this.circularProgressBar2.AnimationSpeed = 250;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar2, "circularProgressBar2");
            this.circularProgressBar2.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.InnerMargin = -1;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.MarqueeAnimationSpeed = 1500;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Red;
            this.circularProgressBar2.OuterMargin = -20;
            this.circularProgressBar2.OuterWidth = 20;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar2.ProgressWidth = 20;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.StartAngle = 90;
            this.circularProgressBar2.Step = 3;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = ".23";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "°C";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label130);
            this.panel13.Controls.Add(this.label129);
            this.panel13.Controls.Add(this.circularProgressBar1);
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // label130
            // 
            resources.ApplyResources(this.label130, "label130");
            this.label130.BackColor = System.Drawing.Color.Transparent;
            this.label130.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label130.Name = "label130";
            // 
            // label129
            // 
            resources.ApplyResources(this.label129, "label129");
            this.label129.BackColor = System.Drawing.Color.Transparent;
            this.label129.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label129.Name = "label129";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.ExponentialEaseIn;
            this.circularProgressBar1.AnimationSpeed = 250;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar1, "circularProgressBar1");
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = -1;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.MarqueeAnimationSpeed = 1500;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Red;
            this.circularProgressBar1.OuterMargin = -20;
            this.circularProgressBar1.OuterWidth = 20;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar1.ProgressWidth = 20;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.StartAngle = 90;
            this.circularProgressBar1.Step = 3;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // label127
            // 
            resources.ApplyResources(this.label127, "label127");
            this.label127.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label127.Name = "label127";
            // 
            // label126
            // 
            resources.ApplyResources(this.label126, "label126");
            this.label126.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label126.Name = "label126";
            // 
            // label123
            // 
            resources.ApplyResources(this.label123, "label123");
            this.label123.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label123.Name = "label123";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle28;
            resources.ApplyResources(this.dataGridView5, "dataGridView5");
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView5.RowHeadersVisible = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView5.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView5.RowTemplate.ReadOnly = true;
            this.dataGridView5.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.VirtualMode = true;
            // 
            // Date
            // 
            resources.ApplyResources(this.Date, "Date");
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Column14
            // 
            resources.ApplyResources(this.Column14, "Column14");
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            resources.ApplyResources(this.Column15, "Column15");
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            resources.ApplyResources(this.Column16, "Column16");
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            resources.ApplyResources(this.Column17, "Column17");
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // combo_use
            // 
            this.combo_use.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_use.FormattingEnabled = true;
            resources.ApplyResources(this.combo_use, "combo_use");
            this.combo_use.Name = "combo_use";
            this.combo_use.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_use_KeyDown);
            // 
            // btn_use
            // 
            this.btn_use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_use.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_use.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_use, "btn_use");
            this.btn_use.ForeColor = System.Drawing.Color.White;
            this.btn_use.Name = "btn_use";
            this.btn_use.UseVisualStyleBackColor = false;
            this.btn_use.Click += new System.EventHandler(this.btn_use_Click);
            // 
            // date_use_new
            // 
            this.date_use_new.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_use_new, "date_use_new");
            this.date_use_new.Name = "date_use_new";
            this.date_use_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_use_KeyDown);
            // 
            // date_use_old
            // 
            this.date_use_old.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_use_old, "date_use_old");
            this.date_use_old.Name = "date_use_old";
            this.date_use_old.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_use_KeyDown);
            // 
            // label131
            // 
            resources.ApplyResources(this.label131, "label131");
            this.label131.ForeColor = System.Drawing.Color.Red;
            this.label131.Name = "label131";
            // 
            // cos_rep
            // 
            this.cos_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cos_rep.Controls.Add(this.label255);
            this.cos_rep.Controls.Add(this.flowLayoutPanel1);
            this.cos_rep.Controls.Add(this.panel62);
            this.cos_rep.Controls.Add(this.label238);
            this.cos_rep.Controls.Add(this.panel48);
            this.cos_rep.Controls.Add(this.label248);
            this.cos_rep.Controls.Add(this.label247);
            this.cos_rep.Controls.Add(this.label246);
            this.cos_rep.Controls.Add(this.dateTimePicker8);
            this.cos_rep.Controls.Add(this.dateTimePicker9);
            this.cos_rep.Controls.Add(this.comboBox9);
            this.cos_rep.Controls.Add(this.label229);
            this.cos_rep.Controls.Add(this.panel47);
            resources.ApplyResources(this.cos_rep, "cos_rep");
            this.cos_rep.Name = "cos_rep";
            // 
            // label255
            // 
            resources.ApplyResources(this.label255, "label255");
            this.label255.ForeColor = System.Drawing.Color.White;
            this.label255.Name = "label255";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel62
            // 
            this.panel62.Controls.Add(this.label240);
            this.panel62.Controls.Add(this.lbl_1_lubs);
            this.panel62.Controls.Add(this.lbl_6_tech);
            this.panel62.Controls.Add(this.lbl_5_parts);
            this.panel62.Controls.Add(this.lbl_4_filter);
            this.panel62.Controls.Add(this.lbl_3_fuel);
            resources.ApplyResources(this.panel62, "panel62");
            this.panel62.Name = "panel62";
            // 
            // label240
            // 
            resources.ApplyResources(this.label240, "label240");
            this.label240.ForeColor = System.Drawing.Color.White;
            this.label240.Name = "label240";
            // 
            // lbl_1_lubs
            // 
            resources.ApplyResources(this.lbl_1_lubs, "lbl_1_lubs");
            this.lbl_1_lubs.ForeColor = System.Drawing.Color.White;
            this.lbl_1_lubs.Name = "lbl_1_lubs";
            // 
            // lbl_6_tech
            // 
            resources.ApplyResources(this.lbl_6_tech, "lbl_6_tech");
            this.lbl_6_tech.ForeColor = System.Drawing.Color.White;
            this.lbl_6_tech.Name = "lbl_6_tech";
            // 
            // lbl_5_parts
            // 
            resources.ApplyResources(this.lbl_5_parts, "lbl_5_parts");
            this.lbl_5_parts.ForeColor = System.Drawing.Color.White;
            this.lbl_5_parts.Name = "lbl_5_parts";
            // 
            // lbl_4_filter
            // 
            resources.ApplyResources(this.lbl_4_filter, "lbl_4_filter");
            this.lbl_4_filter.ForeColor = System.Drawing.Color.White;
            this.lbl_4_filter.Name = "lbl_4_filter";
            // 
            // lbl_3_fuel
            // 
            resources.ApplyResources(this.lbl_3_fuel, "lbl_3_fuel");
            this.lbl_3_fuel.ForeColor = System.Drawing.Color.White;
            this.lbl_3_fuel.Name = "lbl_3_fuel";
            // 
            // label238
            // 
            resources.ApplyResources(this.label238, "label238");
            this.label238.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label238.Name = "label238";
            // 
            // panel48
            // 
            this.panel48.Controls.Add(this.radioButton15);
            this.panel48.Controls.Add(this.radioButton14);
            resources.ApplyResources(this.panel48, "panel48");
            this.panel48.Name = "panel48";
            // 
            // radioButton15
            // 
            resources.ApplyResources(this.radioButton15, "radioButton15");
            this.radioButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton15.ForeColor = System.Drawing.Color.White;
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton14
            // 
            resources.ApplyResources(this.radioButton14, "radioButton14");
            this.radioButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton14.ForeColor = System.Drawing.Color.White;
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // label248
            // 
            resources.ApplyResources(this.label248, "label248");
            this.label248.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label248.Name = "label248";
            // 
            // label247
            // 
            resources.ApplyResources(this.label247, "label247");
            this.label247.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label247.Name = "label247";
            // 
            // label246
            // 
            resources.ApplyResources(this.label246, "label246");
            this.label246.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label246.Name = "label246";
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker8, "dateTimePicker8");
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.ValueChanged += new System.EventHandler(this.dateTimePicker8_ValueChanged);
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dateTimePicker9, "dateTimePicker9");
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.ValueChanged += new System.EventHandler(this.dateTimePicker9_ValueChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox9, "comboBox9");
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged_1);
            // 
            // label229
            // 
            resources.ApplyResources(this.label229, "label229");
            this.label229.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label229.Name = "label229";
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.checkBox11);
            this.panel47.Controls.Add(this.chc_2_main);
            this.panel47.Controls.Add(this.chc_1_lub);
            this.panel47.Controls.Add(this.chc_3_fuel);
            this.panel47.Controls.Add(this.chc_4_filters);
            this.panel47.Controls.Add(this.chc_5_parts);
            this.panel47.Controls.Add(this.chc_6_tech);
            resources.ApplyResources(this.panel47, "panel47");
            this.panel47.Name = "panel47";
            // 
            // checkBox11
            // 
            resources.ApplyResources(this.checkBox11, "checkBox11");
            this.checkBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // chc_2_main
            // 
            resources.ApplyResources(this.chc_2_main, "chc_2_main");
            this.chc_2_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chc_2_main.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chc_2_main.Name = "chc_2_main";
            this.chc_2_main.UseVisualStyleBackColor = true;
            this.chc_2_main.CheckedChanged += new System.EventHandler(this.chc_2_main_CheckedChanged);
            // 
            // chc_1_lub
            // 
            resources.ApplyResources(this.chc_1_lub, "chc_1_lub");
            this.chc_1_lub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chc_1_lub.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chc_1_lub.Name = "chc_1_lub";
            this.chc_1_lub.UseVisualStyleBackColor = true;
            this.chc_1_lub.CheckedChanged += new System.EventHandler(this.chc_1_lub_CheckedChanged);
            // 
            // chc_3_fuel
            // 
            resources.ApplyResources(this.chc_3_fuel, "chc_3_fuel");
            this.chc_3_fuel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chc_3_fuel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chc_3_fuel.Name = "chc_3_fuel";
            this.chc_3_fuel.UseVisualStyleBackColor = true;
            this.chc_3_fuel.CheckedChanged += new System.EventHandler(this.chc_3_fuel_CheckedChanged);
            // 
            // chc_4_filters
            // 
            resources.ApplyResources(this.chc_4_filters, "chc_4_filters");
            this.chc_4_filters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chc_4_filters.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chc_4_filters.Name = "chc_4_filters";
            this.chc_4_filters.UseVisualStyleBackColor = true;
            this.chc_4_filters.CheckedChanged += new System.EventHandler(this.chc_4_filters_CheckedChanged);
            // 
            // chc_5_parts
            // 
            resources.ApplyResources(this.chc_5_parts, "chc_5_parts");
            this.chc_5_parts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chc_5_parts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chc_5_parts.Name = "chc_5_parts";
            this.chc_5_parts.UseVisualStyleBackColor = true;
            this.chc_5_parts.CheckedChanged += new System.EventHandler(this.chc_5_parts_CheckedChanged);
            // 
            // chc_6_tech
            // 
            resources.ApplyResources(this.chc_6_tech, "chc_6_tech");
            this.chc_6_tech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chc_6_tech.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chc_6_tech.Name = "chc_6_tech";
            this.chc_6_tech.UseVisualStyleBackColor = true;
            this.chc_6_tech.CheckedChanged += new System.EventHandler(this.chc_6_tech_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label256);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Controls.Add(this.button18);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.dateTimePicker5);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.dataGridView3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label256
            // 
            resources.ApplyResources(this.label256, "label256");
            this.label256.Name = "label256";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            // 
            // button20
            // 
            resources.ApplyResources(this.button20, "button20");
            this.button20.Name = "button20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            resources.ApplyResources(this.button19, "button19");
            this.button19.Name = "button19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            resources.ApplyResources(this.button18, "button18");
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DisplayMember = "equ_id";
            this.comboBox5.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox5, "comboBox5");
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.ValueMember = "equ_id";
            // 
            // dateTimePicker5
            // 
            resources.ApplyResources(this.dateTimePicker5, "dateTimePicker5");
            this.dateTimePicker5.Name = "dateTimePicker5";
            // 
            // button11
            // 
            resources.ApplyResources(this.button11, "button11");
            this.button11.Name = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4"),
            resources.GetString("comboBox2.Items5"),
            resources.GetString("comboBox2.Items6"),
            resources.GetString("comboBox2.Items7"),
            resources.GetString("comboBox2.Items8")});
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView3, "dataGridView3");
            this.dataGridView3.Name = "dataGridView3";
            // 
            // oilBindingSource
            // 
            this.oilBindingSource.DataMember = "oil";
            this.oilBindingSource.DataSource = this.hopeDataSetBindingSource;
            // 
            // workerBindingSource2
            // 
            this.workerBindingSource2.DataMember = "worker";
            this.workerBindingSource2.DataSource = this.hopeDataSetBindingSource;
            // 
            // tabb2
            // 
            this.tabb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabb2.Controls.Add(this.linkLabel6);
            this.tabb2.Controls.Add(this.panel28);
            this.tabb2.Controls.Add(this.panel7);
            this.tabb2.Controls.Add(this.lb_mod_2);
            this.tabb2.Controls.Add(this.label200);
            this.tabb2.Controls.Add(this.label92);
            this.tabb2.Controls.Add(this.comb_add_hours);
            resources.ApplyResources(this.tabb2, "tabb2");
            this.tabb2.Name = "tabb2";
            // 
            // linkLabel6
            // 
            resources.ApplyResources(this.linkLabel6, "linkLabel6");
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel6.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel6.ForeColor = System.Drawing.Color.Red;
            this.linkLabel6.LinkColor = System.Drawing.Color.Red;
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.TabStop = true;
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // panel28
            // 
            resources.ApplyResources(this.panel28, "panel28");
            this.panel28.Controls.Add(this.txt_add_hours_total);
            this.panel28.Controls.Add(this.lbl_prv_hrs_stage2);
            this.panel28.Controls.Add(this.lbl_prv_hrs_stage1);
            this.panel28.Controls.Add(this.lbl_prv_hrs_part2);
            this.panel28.Controls.Add(this.lbl_prv_hrs_part1);
            this.panel28.Controls.Add(this.lbl_after);
            this.panel28.Controls.Add(this.lowww);
            this.panel28.Controls.Add(this.lbl_main_id);
            this.panel28.Controls.Add(this.lbl_hours2);
            this.panel28.Controls.Add(this.lbl_hours1);
            this.panel28.Name = "panel28";
            // 
            // txt_add_hours_total
            // 
            this.txt_add_hours_total.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txt_add_hours_total, "txt_add_hours_total");
            this.txt_add_hours_total.Name = "txt_add_hours_total";
            // 
            // lbl_prv_hrs_stage2
            // 
            resources.ApplyResources(this.lbl_prv_hrs_stage2, "lbl_prv_hrs_stage2");
            this.lbl_prv_hrs_stage2.ForeColor = System.Drawing.Color.White;
            this.lbl_prv_hrs_stage2.Name = "lbl_prv_hrs_stage2";
            // 
            // lbl_prv_hrs_stage1
            // 
            resources.ApplyResources(this.lbl_prv_hrs_stage1, "lbl_prv_hrs_stage1");
            this.lbl_prv_hrs_stage1.ForeColor = System.Drawing.Color.White;
            this.lbl_prv_hrs_stage1.Name = "lbl_prv_hrs_stage1";
            // 
            // lbl_prv_hrs_part2
            // 
            resources.ApplyResources(this.lbl_prv_hrs_part2, "lbl_prv_hrs_part2");
            this.lbl_prv_hrs_part2.ForeColor = System.Drawing.Color.White;
            this.lbl_prv_hrs_part2.Name = "lbl_prv_hrs_part2";
            // 
            // lbl_prv_hrs_part1
            // 
            resources.ApplyResources(this.lbl_prv_hrs_part1, "lbl_prv_hrs_part1");
            this.lbl_prv_hrs_part1.ForeColor = System.Drawing.Color.White;
            this.lbl_prv_hrs_part1.Name = "lbl_prv_hrs_part1";
            // 
            // lbl_after
            // 
            resources.ApplyResources(this.lbl_after, "lbl_after");
            this.lbl_after.ForeColor = System.Drawing.Color.White;
            this.lbl_after.Name = "lbl_after";
            // 
            // lowww
            // 
            resources.ApplyResources(this.lowww, "lowww");
            this.lowww.ForeColor = System.Drawing.Color.White;
            this.lowww.Name = "lowww";
            // 
            // lbl_main_id
            // 
            resources.ApplyResources(this.lbl_main_id, "lbl_main_id");
            this.lbl_main_id.ForeColor = System.Drawing.Color.White;
            this.lbl_main_id.Name = "lbl_main_id";
            // 
            // lbl_hours2
            // 
            resources.ApplyResources(this.lbl_hours2, "lbl_hours2");
            this.lbl_hours2.ForeColor = System.Drawing.Color.White;
            this.lbl_hours2.Name = "lbl_hours2";
            // 
            // lbl_hours1
            // 
            resources.ApplyResources(this.lbl_hours1, "lbl_hours1");
            this.lbl_hours1.ForeColor = System.Drawing.Color.White;
            this.lbl_hours1.Name = "lbl_hours1";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label61);
            this.panel7.Controls.Add(this.date_add_hours);
            this.panel7.Controls.Add(this.label67);
            this.panel7.Controls.Add(this.txt_input_hours);
            this.panel7.Controls.Add(this.btnhours);
            this.panel7.Controls.Add(this.btn_detais_hours);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // label61
            // 
            resources.ApplyResources(this.label61, "label61");
            this.label61.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label61.Name = "label61";
            // 
            // date_add_hours
            // 
            resources.ApplyResources(this.date_add_hours, "date_add_hours");
            this.date_add_hours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_add_hours.Name = "date_add_hours";
            this.date_add_hours.ValueChanged += new System.EventHandler(this.date_add_hours_ValueChanged);
            this.date_add_hours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_hours_KeyDown);
            // 
            // label67
            // 
            resources.ApplyResources(this.label67, "label67");
            this.label67.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label67.Name = "label67";
            // 
            // txt_input_hours
            // 
            resources.ApplyResources(this.txt_input_hours, "txt_input_hours");
            this.txt_input_hours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_input_hours.Name = "txt_input_hours";
            this.txt_input_hours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_hours_KeyDown);
            this.txt_input_hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // btnhours
            // 
            resources.ApplyResources(this.btnhours, "btnhours");
            this.btnhours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhours.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnhours.ForeColor = System.Drawing.Color.White;
            this.btnhours.Name = "btnhours";
            this.btnhours.UseVisualStyleBackColor = false;
            this.btnhours.Click += new System.EventHandler(this.btnhours_Click);
            // 
            // btn_detais_hours
            // 
            resources.ApplyResources(this.btn_detais_hours, "btn_detais_hours");
            this.btn_detais_hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_detais_hours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detais_hours.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_detais_hours.ForeColor = System.Drawing.Color.White;
            this.btn_detais_hours.Name = "btn_detais_hours";
            this.btn_detais_hours.UseVisualStyleBackColor = false;
            this.btn_detais_hours.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // lb_mod_2
            // 
            resources.ApplyResources(this.lb_mod_2, "lb_mod_2");
            this.lb_mod_2.Name = "lb_mod_2";
            // 
            // label200
            // 
            resources.ApplyResources(this.label200, "label200");
            this.label200.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label200.Name = "label200";
            // 
            // label92
            // 
            resources.ApplyResources(this.label92, "label92");
            this.label92.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label92.Name = "label92";
            // 
            // comb_add_hours
            // 
            resources.ApplyResources(this.comb_add_hours, "comb_add_hours");
            this.comb_add_hours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_add_hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_add_hours.FormattingEnabled = true;
            this.comb_add_hours.Name = "comb_add_hours";
            this.comb_add_hours.SelectedIndexChanged += new System.EventHandler(this.comb_add_hours_SelectedIndexChanged);
            // 
            // tabb0
            // 
            this.tabb0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.tabb0, "tabb0");
            this.tabb0.Controls.Add(this.btn_notf);
            this.tabb0.Controls.Add(this.checkBox10);
            this.tabb0.Controls.Add(this.panel17);
            this.tabb0.Controls.Add(this.panel19);
            this.tabb0.Name = "tabb0";
            // 
            // btn_notf
            // 
            this.btn_notf.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_notf, "btn_notf");
            this.btn_notf.Name = "btn_notf";
            this.btn_notf.UseVisualStyleBackColor = false;
            this.btn_notf.Click += new System.EventHandler(this.btn_notf_Click);
            // 
            // checkBox10
            // 
            resources.ApplyResources(this.checkBox10, "checkBox10");
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // panel17
            // 
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.button22);
            this.panel17.Controls.Add(this.button1);
            this.panel17.Controls.Add(this.button4);
            this.panel17.Controls.Add(this.button25);
            this.panel17.Controls.Add(this.button24);
            this.panel17.Controls.Add(this.button23);
            this.panel17.Controls.Add(this.button3);
            this.panel17.Controls.Add(this.pictureBox8);
            this.panel17.Controls.Add(this.pnl_maint);
            this.panel17.Controls.Add(this.pnl_report);
            this.panel17.Controls.Add(this.pnl_posting);
            this.panel17.Name = "panel17";
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button22, "button22");
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button22.Name = "button22";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button25, "button25");
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button25.Name = "button25";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button7_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button24, "button24");
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button24.Name = "button24";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button8_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button23, "button23");
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button23.Name = "button23";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox8
            // 
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Image = global::notfinal.Properties.Resources.watermarkkk_2;
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pnl_posting
            // 
            resources.ApplyResources(this.pnl_posting, "pnl_posting");
            this.pnl_posting.Controls.Add(this.label140);
            this.pnl_posting.Controls.Add(this.label149);
            this.pnl_posting.Controls.Add(this.label176);
            this.pnl_posting.Controls.Add(this.picfilter);
            this.pnl_posting.Controls.Add(this.label180);
            this.pnl_posting.Controls.Add(this.picfuel);
            this.pnl_posting.Controls.Add(this.label142);
            this.pnl_posting.Controls.Add(this.pictureBox1);
            this.pnl_posting.Controls.Add(this.pichours);
            this.pnl_posting.Controls.Add(this.label151);
            this.pnl_posting.Controls.Add(this.picoil);
            this.pnl_posting.Controls.Add(this.pictureBox9);
            this.pnl_posting.Name = "pnl_posting";
            // 
            // label140
            // 
            resources.ApplyResources(this.label140, "label140");
            this.label140.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label140.Name = "label140";
            // 
            // label149
            // 
            resources.ApplyResources(this.label149, "label149");
            this.label149.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label149.Name = "label149";
            // 
            // label176
            // 
            resources.ApplyResources(this.label176, "label176");
            this.label176.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label176.Name = "label176";
            // 
            // picfilter
            // 
            resources.ApplyResources(this.picfilter, "picfilter");
            this.picfilter.BackColor = System.Drawing.Color.White;
            this.picfilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picfilter.Name = "picfilter";
            this.picfilter.TabStop = false;
            this.picfilter.Click += new System.EventHandler(this.picfilter_Click);
            // 
            // label180
            // 
            resources.ApplyResources(this.label180, "label180");
            this.label180.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label180.Name = "label180";
            // 
            // picfuel
            // 
            resources.ApplyResources(this.picfuel, "picfuel");
            this.picfuel.BackColor = System.Drawing.Color.White;
            this.picfuel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picfuel.Name = "picfuel";
            this.picfuel.TabStop = false;
            this.picfuel.Click += new System.EventHandler(this.picfuel_Click);
            // 
            // label142
            // 
            resources.ApplyResources(this.label142, "label142");
            this.label142.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label142.Name = "label142";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::notfinal.Properties.Resources.lapor;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pichours
            // 
            resources.ApplyResources(this.pichours, "pichours");
            this.pichours.BackColor = System.Drawing.Color.White;
            this.pichours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pichours.Name = "pichours";
            this.pichours.TabStop = false;
            this.pichours.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label151
            // 
            resources.ApplyResources(this.label151, "label151");
            this.label151.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label151.Name = "label151";
            // 
            // picoil
            // 
            resources.ApplyResources(this.picoil, "picoil");
            this.picoil.BackColor = System.Drawing.Color.White;
            this.picoil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picoil.Image = global::notfinal.Properties.Resources._33333333333;
            this.picoil.Name = "picoil";
            this.picoil.TabStop = false;
            this.picoil.Click += new System.EventHandler(this.picoil_Click);
            // 
            // pictureBox9
            // 
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // pnl_maint
            // 
            resources.ApplyResources(this.pnl_maint, "pnl_maint");
            this.pnl_maint.Controls.Add(this.pictureBox23);
            this.pnl_maint.Controls.Add(this.label182);
            this.pnl_maint.Controls.Add(this.pictureBox22);
            this.pnl_maint.Controls.Add(this.label181);
            this.pnl_maint.Controls.Add(this.pictureBox24);
            this.pnl_maint.Controls.Add(this.label183);
            this.pnl_maint.Controls.Add(this.pictureBox5);
            this.pnl_maint.Name = "pnl_maint";
            // 
            // pictureBox23
            // 
            resources.ApplyResources(this.pictureBox23, "pictureBox23");
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Click += new System.EventHandler(this.pictureBox23_Click);
            // 
            // label182
            // 
            resources.ApplyResources(this.label182, "label182");
            this.label182.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label182.Name = "label182";
            // 
            // pictureBox22
            // 
            resources.ApplyResources(this.pictureBox22, "pictureBox22");
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            // 
            // label181
            // 
            resources.ApplyResources(this.label181, "label181");
            this.label181.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label181.Name = "label181";
            // 
            // pictureBox24
            // 
            resources.ApplyResources(this.pictureBox24, "pictureBox24");
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Click += new System.EventHandler(this.pictureBox24_Click);
            // 
            // label183
            // 
            resources.ApplyResources(this.label183, "label183");
            this.label183.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label183.Name = "label183";
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pnl_report
            // 
            resources.ApplyResources(this.pnl_report, "pnl_report");
            this.pnl_report.Controls.Add(this.label186);
            this.pnl_report.Controls.Add(this.label147);
            this.pnl_report.Controls.Add(this.pictureBox11);
            this.pnl_report.Controls.Add(this.pictureBox10);
            this.pnl_report.Controls.Add(this.label117);
            this.pnl_report.Controls.Add(this.label141);
            this.pnl_report.Controls.Add(this.label8);
            this.pnl_report.Controls.Add(this.pictureBox2);
            this.pnl_report.Controls.Add(this.label152);
            this.pnl_report.Controls.Add(this.pictureBox3);
            this.pnl_report.Controls.Add(this.picreport);
            this.pnl_report.Controls.Add(this.pictureBox4);
            this.pnl_report.Name = "pnl_report";
            // 
            // label186
            // 
            resources.ApplyResources(this.label186, "label186");
            this.label186.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label186.Name = "label186";
            // 
            // label147
            // 
            resources.ApplyResources(this.label147, "label147");
            this.label147.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label147.Name = "label147";
            // 
            // pictureBox11
            // 
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.BackColor = System.Drawing.Color.White;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::notfinal.Properties.Resources._1;
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            resources.ApplyResources(this.pictureBox10, "pictureBox10");
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::notfinal.Properties.Resources._33333333333;
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // label117
            // 
            resources.ApplyResources(this.label117, "label117");
            this.label117.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label117.Name = "label117";
            // 
            // label141
            // 
            resources.ApplyResources(this.label141, "label141");
            this.label141.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label141.Name = "label141";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Name = "label8";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label152
            // 
            resources.ApplyResources(this.label152, "label152");
            this.label152.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label152.Name = "label152";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::notfinal.Properties.Resources._4;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picreport
            // 
            resources.ApplyResources(this.picreport, "picreport");
            this.picreport.BackColor = System.Drawing.Color.White;
            this.picreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreport.Name = "picreport";
            this.picreport.TabStop = false;
            this.picreport.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // panel19
            // 
            resources.ApplyResources(this.panel19, "panel19");
            this.panel19.Controls.Add(this.tableLayoutPanel3);
            this.panel19.Controls.Add(this.label144);
            this.panel19.Name = "panel19";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.panel26, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel20, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel27, 0, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // panel26
            // 
            resources.ApplyResources(this.panel26, "panel26");
            this.panel26.Controls.Add(this.label201);
            this.panel26.Controls.Add(this.label204);
            this.panel26.Name = "panel26";
            // 
            // label201
            // 
            resources.ApplyResources(this.label201, "label201");
            this.label201.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label201.Name = "label201";
            // 
            // label204
            // 
            resources.ApplyResources(this.label204, "label204");
            this.label204.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label204.Name = "label204";
            // 
            // panel20
            // 
            resources.ApplyResources(this.panel20, "panel20");
            this.panel20.Controls.Add(this.label203);
            this.panel20.Controls.Add(this.label202);
            this.panel20.Name = "panel20";
            // 
            // label203
            // 
            resources.ApplyResources(this.label203, "label203");
            this.label203.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label203.Name = "label203";
            // 
            // label202
            // 
            resources.ApplyResources(this.label202, "label202");
            this.label202.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label202.Name = "label202";
            // 
            // panel27
            // 
            resources.ApplyResources(this.panel27, "panel27");
            this.panel27.Controls.Add(this.label205);
            this.panel27.Controls.Add(this.label206);
            this.panel27.Name = "panel27";
            // 
            // label205
            // 
            resources.ApplyResources(this.label205, "label205");
            this.label205.Name = "label205";
            // 
            // label206
            // 
            resources.ApplyResources(this.label206, "label206");
            this.label206.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label206.Name = "label206";
            // 
            // label144
            // 
            resources.ApplyResources(this.label144, "label144");
            this.label144.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label144.Name = "label144";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabb0);
            this.tabControl1.Controls.Add(this.tabb1);
            this.tabControl1.Controls.Add(this.tabb2);
            this.tabControl1.Controls.Add(this.tabb3);
            this.tabControl1.Controls.Add(this.tabb4);
            this.tabControl1.Controls.Add(this.tabb5);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            // 
            // tabb1
            // 
            this.tabb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabb1.Controls.Add(this.linkLabel7);
            this.tabb1.Controls.Add(this.lb_mod_1);
            this.tabb1.Controls.Add(this.label192);
            this.tabb1.Controls.Add(this.label90);
            this.tabb1.Controls.Add(this.panel3);
            this.tabb1.Controls.Add(this.panel4);
            this.tabb1.Controls.Add(this.combo_equ_show);
            this.tabb1.Controls.Add(this.dataGridequ1);
            resources.ApplyResources(this.tabb1, "tabb1");
            this.tabb1.Name = "tabb1";
            // 
            // linkLabel7
            // 
            resources.ApplyResources(this.linkLabel7, "linkLabel7");
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel7.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel7.ForeColor = System.Drawing.Color.Red;
            this.linkLabel7.LinkColor = System.Drawing.Color.Red;
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.TabStop = true;
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // lb_mod_1
            // 
            resources.ApplyResources(this.lb_mod_1, "lb_mod_1");
            this.lb_mod_1.Name = "lb_mod_1";
            // 
            // label192
            // 
            resources.ApplyResources(this.label192, "label192");
            this.label192.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label192.Name = "label192";
            // 
            // label90
            // 
            resources.ApplyResources(this.label90, "label90");
            this.label90.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label90.Name = "label90";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel55);
            this.panel3.Controls.Add(this.panel52);
            this.panel3.Controls.Add(this.panel56);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.panel53);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.textBox15);
            this.panel3.Controls.Add(this.label114);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.label156);
            this.panel3.Controls.Add(this.comb_prv_sq);
            this.panel3.Controls.Add(this.dataGridequ3);
            this.panel3.Controls.Add(this.dataGridequ2);
            this.panel3.Controls.Add(this.dataGridequ4);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Controls.Add(this.label91);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.btn_fuel_ins_equ);
            this.panel3.Controls.Add(this.btn_flt_ins_equ);
            this.panel3.Controls.Add(this.btn_oil_ins_equ);
            this.panel3.Controls.Add(this.btn_fuel_dlt_equ);
            this.panel3.Controls.Add(this.btn_fuel_upd_equ);
            this.panel3.Controls.Add(this.btn_flt_dlt_equ);
            this.panel3.Controls.Add(this.btn_flt_upd_equ);
            this.panel3.Controls.Add(this.btn_oil_dlt_equ2);
            this.panel3.Controls.Add(this.btn_oil_upd_equ);
            this.panel3.Controls.Add(this.panel51);
            this.panel3.Controls.Add(this.panel54);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.label82);
            this.panel55.Controls.Add(this.label42);
            this.panel55.Controls.Add(this.label68);
            this.panel55.Controls.Add(this.label89);
            this.panel55.Controls.Add(this.label65);
            this.panel55.Controls.Add(this.label60);
            resources.ApplyResources(this.panel55, "panel55");
            this.panel55.Name = "panel55";
            // 
            // label82
            // 
            resources.ApplyResources(this.label82, "label82");
            this.label82.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label82.Name = "label82";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label42.Name = "label42";
            // 
            // label68
            // 
            resources.ApplyResources(this.label68, "label68");
            this.label68.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label68.Name = "label68";
            // 
            // label89
            // 
            resources.ApplyResources(this.label89, "label89");
            this.label89.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label89.Name = "label89";
            // 
            // label65
            // 
            resources.ApplyResources(this.label65, "label65");
            this.label65.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label65.Name = "label65";
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label60.Name = "label60";
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.lbl_lng);
            this.panel52.Controls.Add(this.lbl_high);
            this.panel52.Controls.Add(this.lbl_wiegt);
            this.panel52.Controls.Add(this.lbl_width);
            this.panel52.Controls.Add(this.lbl_highidle);
            this.panel52.Controls.Add(this.lbl_lowidle);
            this.panel52.Controls.Add(this.lbl_engp);
            resources.ApplyResources(this.panel52, "panel52");
            this.panel52.Name = "panel52";
            // 
            // lbl_lng
            // 
            resources.ApplyResources(this.lbl_lng, "lbl_lng");
            this.lbl_lng.ForeColor = System.Drawing.Color.White;
            this.lbl_lng.Name = "lbl_lng";
            // 
            // lbl_high
            // 
            resources.ApplyResources(this.lbl_high, "lbl_high");
            this.lbl_high.ForeColor = System.Drawing.Color.White;
            this.lbl_high.Name = "lbl_high";
            // 
            // lbl_wiegt
            // 
            resources.ApplyResources(this.lbl_wiegt, "lbl_wiegt");
            this.lbl_wiegt.ForeColor = System.Drawing.Color.White;
            this.lbl_wiegt.Name = "lbl_wiegt";
            // 
            // lbl_width
            // 
            resources.ApplyResources(this.lbl_width, "lbl_width");
            this.lbl_width.ForeColor = System.Drawing.Color.White;
            this.lbl_width.Name = "lbl_width";
            // 
            // lbl_highidle
            // 
            resources.ApplyResources(this.lbl_highidle, "lbl_highidle");
            this.lbl_highidle.ForeColor = System.Drawing.Color.White;
            this.lbl_highidle.Name = "lbl_highidle";
            // 
            // lbl_lowidle
            // 
            resources.ApplyResources(this.lbl_lowidle, "lbl_lowidle");
            this.lbl_lowidle.ForeColor = System.Drawing.Color.White;
            this.lbl_lowidle.Name = "lbl_lowidle";
            // 
            // lbl_engp
            // 
            resources.ApplyResources(this.lbl_engp, "lbl_engp");
            this.lbl_engp.ForeColor = System.Drawing.Color.White;
            this.lbl_engp.Name = "lbl_engp";
            // 
            // panel56
            // 
            this.panel56.Controls.Add(this.lbl_sn);
            this.panel56.Controls.Add(this.lbl_id);
            this.panel56.Controls.Add(this.label88);
            this.panel56.Controls.Add(this.lbl_arr);
            this.panel56.Controls.Add(this.lbl_engsn);
            this.panel56.Controls.Add(this.lbl_transn);
            resources.ApplyResources(this.panel56, "panel56");
            this.panel56.Name = "panel56";
            // 
            // lbl_sn
            // 
            resources.ApplyResources(this.lbl_sn, "lbl_sn");
            this.lbl_sn.ForeColor = System.Drawing.Color.White;
            this.lbl_sn.Name = "lbl_sn";
            // 
            // lbl_id
            // 
            resources.ApplyResources(this.lbl_id, "lbl_id");
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Name = "lbl_id";
            // 
            // label88
            // 
            resources.ApplyResources(this.label88, "label88");
            this.label88.ForeColor = System.Drawing.Color.White;
            this.label88.Name = "label88";
            // 
            // lbl_arr
            // 
            resources.ApplyResources(this.lbl_arr, "lbl_arr");
            this.lbl_arr.ForeColor = System.Drawing.Color.White;
            this.lbl_arr.Name = "lbl_arr";
            // 
            // lbl_engsn
            // 
            resources.ApplyResources(this.lbl_engsn, "lbl_engsn");
            this.lbl_engsn.ForeColor = System.Drawing.Color.White;
            this.lbl_engsn.Name = "lbl_engsn";
            // 
            // lbl_transn
            // 
            resources.ApplyResources(this.lbl_transn, "lbl_transn");
            this.lbl_transn.ForeColor = System.Drawing.Color.White;
            this.lbl_transn.Name = "lbl_transn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.label87);
            this.panel53.Controls.Add(this.label86);
            this.panel53.Controls.Add(this.label84);
            this.panel53.Controls.Add(this.label72);
            resources.ApplyResources(this.panel53, "panel53");
            this.panel53.Name = "panel53";
            // 
            // label87
            // 
            resources.ApplyResources(this.label87, "label87");
            this.label87.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label87.Name = "label87";
            // 
            // label86
            // 
            resources.ApplyResources(this.label86, "label86");
            this.label86.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label86.Name = "label86";
            // 
            // label84
            // 
            resources.ApplyResources(this.label84, "label84");
            this.label84.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label84.Name = "label84";
            // 
            // label72
            // 
            resources.ApplyResources(this.label72, "label72");
            this.label72.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label72.Name = "label72";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            this.textBox15.Leave += new System.EventHandler(this.textBox15_Leave);
            // 
            // label114
            // 
            resources.ApplyResources(this.label114, "label114");
            this.label114.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label114.Name = "label114";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel34, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel35, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel36, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel34
            // 
            resources.ApplyResources(this.panel34, "panel34");
            this.panel34.Controls.Add(this.label227);
            this.panel34.Name = "panel34";
            // 
            // label227
            // 
            resources.ApplyResources(this.label227, "label227");
            this.label227.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label227.Name = "label227";
            // 
            // panel35
            // 
            resources.ApplyResources(this.panel35, "panel35");
            this.panel35.Controls.Add(this.label231);
            this.panel35.Name = "panel35";
            // 
            // label231
            // 
            resources.ApplyResources(this.label231, "label231");
            this.label231.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label231.Name = "label231";
            // 
            // panel36
            // 
            resources.ApplyResources(this.panel36, "panel36");
            this.panel36.Controls.Add(this.label233);
            this.panel36.Controls.Add(this.label234);
            this.panel36.Name = "panel36";
            // 
            // label233
            // 
            resources.ApplyResources(this.label233, "label233");
            this.label233.Name = "label233";
            // 
            // label234
            // 
            resources.ApplyResources(this.label234, "label234");
            this.label234.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label234.Name = "label234";
            // 
            // label156
            // 
            resources.ApplyResources(this.label156, "label156");
            this.label156.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label156.Name = "label156";
            // 
            // comb_prv_sq
            // 
            this.comb_prv_sq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_prv_sq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_prv_sq, "comb_prv_sq");
            this.comb_prv_sq.FormattingEnabled = true;
            this.comb_prv_sq.Name = "comb_prv_sq";
            this.comb_prv_sq.SelectedIndexChanged += new System.EventHandler(this.comb_prv_sq_SelectedIndexChanged);
            // 
            // dataGridequ3
            // 
            this.dataGridequ3.AllowUserToAddRows = false;
            this.dataGridequ3.AllowUserToDeleteRows = false;
            this.dataGridequ3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridequ3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridequ3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridequ3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridequ3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridequ3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridequ3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridequ3.DefaultCellStyle = dataGridViewCellStyle32;
            resources.ApplyResources(this.dataGridequ3, "dataGridequ3");
            this.dataGridequ3.MultiSelect = false;
            this.dataGridequ3.Name = "dataGridequ3";
            this.dataGridequ3.ReadOnly = true;
            this.dataGridequ3.RowHeadersVisible = false;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridequ3.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridequ3.RowTemplate.ReadOnly = true;
            this.dataGridequ3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridequ3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridequ3.VirtualMode = true;
            // 
            // dataGridequ2
            // 
            this.dataGridequ2.AllowUserToAddRows = false;
            this.dataGridequ2.AllowUserToDeleteRows = false;
            this.dataGridequ2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridequ2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridequ2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridequ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridequ2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridequ2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridequ2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridequ2.DefaultCellStyle = dataGridViewCellStyle35;
            resources.ApplyResources(this.dataGridequ2, "dataGridequ2");
            this.dataGridequ2.MultiSelect = false;
            this.dataGridequ2.Name = "dataGridequ2";
            this.dataGridequ2.ReadOnly = true;
            this.dataGridequ2.RowHeadersVisible = false;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridequ2.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridequ2.RowTemplate.ReadOnly = true;
            this.dataGridequ2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridequ2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridequ2.VirtualMode = true;
            // 
            // dataGridequ4
            // 
            this.dataGridequ4.AllowUserToAddRows = false;
            this.dataGridequ4.AllowUserToDeleteRows = false;
            this.dataGridequ4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridequ4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridequ4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridequ4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridequ4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridequ4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridequ4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridequ4.DefaultCellStyle = dataGridViewCellStyle38;
            resources.ApplyResources(this.dataGridequ4, "dataGridequ4");
            this.dataGridequ4.MultiSelect = false;
            this.dataGridequ4.Name = "dataGridequ4";
            this.dataGridequ4.ReadOnly = true;
            this.dataGridequ4.RowHeadersVisible = false;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridequ4.RowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridequ4.RowTemplate.ReadOnly = true;
            this.dataGridequ4.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridequ4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridequ4.VirtualMode = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // label91
            // 
            resources.ApplyResources(this.label91, "label91");
            this.label91.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label91.Name = "label91";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btn_fuel_ins_equ
            // 
            this.btn_fuel_ins_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fuel_ins_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_fuel_ins_equ, "btn_fuel_ins_equ");
            this.btn_fuel_ins_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_fuel_ins_equ.ForeColor = System.Drawing.Color.White;
            this.btn_fuel_ins_equ.Name = "btn_fuel_ins_equ";
            this.btn_fuel_ins_equ.UseVisualStyleBackColor = false;
            this.btn_fuel_ins_equ.Click += new System.EventHandler(this.btn_fuel_ins_equ_Click);
            // 
            // btn_flt_ins_equ
            // 
            this.btn_flt_ins_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_flt_ins_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_flt_ins_equ, "btn_flt_ins_equ");
            this.btn_flt_ins_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_flt_ins_equ.ForeColor = System.Drawing.Color.White;
            this.btn_flt_ins_equ.Name = "btn_flt_ins_equ";
            this.btn_flt_ins_equ.UseVisualStyleBackColor = false;
            this.btn_flt_ins_equ.Click += new System.EventHandler(this.btn_flt_ins_equ_Click);
            // 
            // btn_oil_ins_equ
            // 
            this.btn_oil_ins_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_oil_ins_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_oil_ins_equ, "btn_oil_ins_equ");
            this.btn_oil_ins_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_oil_ins_equ.ForeColor = System.Drawing.Color.White;
            this.btn_oil_ins_equ.Name = "btn_oil_ins_equ";
            this.btn_oil_ins_equ.UseVisualStyleBackColor = false;
            this.btn_oil_ins_equ.Click += new System.EventHandler(this.btn_oil_ins_equ_Click);
            // 
            // btn_fuel_dlt_equ
            // 
            this.btn_fuel_dlt_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fuel_dlt_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_fuel_dlt_equ, "btn_fuel_dlt_equ");
            this.btn_fuel_dlt_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_fuel_dlt_equ.ForeColor = System.Drawing.Color.White;
            this.btn_fuel_dlt_equ.Name = "btn_fuel_dlt_equ";
            this.btn_fuel_dlt_equ.UseVisualStyleBackColor = false;
            this.btn_fuel_dlt_equ.Click += new System.EventHandler(this.btn_fuel_dlt_equ_Click);
            // 
            // btn_fuel_upd_equ
            // 
            this.btn_fuel_upd_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fuel_upd_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_fuel_upd_equ, "btn_fuel_upd_equ");
            this.btn_fuel_upd_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_fuel_upd_equ.ForeColor = System.Drawing.Color.White;
            this.btn_fuel_upd_equ.Name = "btn_fuel_upd_equ";
            this.btn_fuel_upd_equ.UseVisualStyleBackColor = false;
            this.btn_fuel_upd_equ.Click += new System.EventHandler(this.btn_fuel_upd_equ_Click);
            // 
            // btn_flt_dlt_equ
            // 
            this.btn_flt_dlt_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_flt_dlt_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_flt_dlt_equ, "btn_flt_dlt_equ");
            this.btn_flt_dlt_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_flt_dlt_equ.ForeColor = System.Drawing.Color.White;
            this.btn_flt_dlt_equ.Name = "btn_flt_dlt_equ";
            this.btn_flt_dlt_equ.UseVisualStyleBackColor = false;
            this.btn_flt_dlt_equ.Click += new System.EventHandler(this.btn_flt_dlt_equ_Click);
            // 
            // btn_flt_upd_equ
            // 
            this.btn_flt_upd_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_flt_upd_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_flt_upd_equ, "btn_flt_upd_equ");
            this.btn_flt_upd_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_flt_upd_equ.ForeColor = System.Drawing.Color.White;
            this.btn_flt_upd_equ.Name = "btn_flt_upd_equ";
            this.btn_flt_upd_equ.UseVisualStyleBackColor = false;
            this.btn_flt_upd_equ.Click += new System.EventHandler(this.btn_flt_upd_equ_Click);
            // 
            // btn_oil_dlt_equ2
            // 
            this.btn_oil_dlt_equ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_oil_dlt_equ2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_oil_dlt_equ2, "btn_oil_dlt_equ2");
            this.btn_oil_dlt_equ2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_oil_dlt_equ2.ForeColor = System.Drawing.Color.White;
            this.btn_oil_dlt_equ2.Name = "btn_oil_dlt_equ2";
            this.btn_oil_dlt_equ2.UseVisualStyleBackColor = false;
            this.btn_oil_dlt_equ2.Click += new System.EventHandler(this.btn_oil_dlt_equ2_Click);
            // 
            // btn_oil_upd_equ
            // 
            this.btn_oil_upd_equ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_oil_upd_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_oil_upd_equ, "btn_oil_upd_equ");
            this.btn_oil_upd_equ.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_oil_upd_equ.ForeColor = System.Drawing.Color.White;
            this.btn_oil_upd_equ.Name = "btn_oil_upd_equ";
            this.btn_oil_upd_equ.UseVisualStyleBackColor = false;
            this.btn_oil_upd_equ.Click += new System.EventHandler(this.btn_oil_upd_equ_Click);
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.label43);
            this.panel51.Controls.Add(this.label44);
            this.panel51.Controls.Add(this.label62);
            this.panel51.Controls.Add(this.label66);
            this.panel51.Controls.Add(this.label64);
            this.panel51.Controls.Add(this.label63);
            this.panel51.Controls.Add(this.label69);
            resources.ApplyResources(this.panel51, "panel51");
            this.panel51.Name = "panel51";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label43.Name = "label43";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label44.Name = "label44";
            // 
            // label62
            // 
            resources.ApplyResources(this.label62, "label62");
            this.label62.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label62.Name = "label62";
            // 
            // label66
            // 
            resources.ApplyResources(this.label66, "label66");
            this.label66.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label66.Name = "label66";
            // 
            // label64
            // 
            resources.ApplyResources(this.label64, "label64");
            this.label64.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label64.Name = "label64";
            // 
            // label63
            // 
            resources.ApplyResources(this.label63, "label63");
            this.label63.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label63.Name = "label63";
            // 
            // label69
            // 
            resources.ApplyResources(this.label69, "label69");
            this.label69.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label69.Name = "label69";
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.lbl_tiersize);
            this.panel54.Controls.Add(this.lbl_eng_size);
            this.panel54.Controls.Add(this.lbl_ac_size);
            this.panel54.Controls.Add(this.lbl_mg_size);
            resources.ApplyResources(this.panel54, "panel54");
            this.panel54.Name = "panel54";
            // 
            // lbl_tiersize
            // 
            resources.ApplyResources(this.lbl_tiersize, "lbl_tiersize");
            this.lbl_tiersize.ForeColor = System.Drawing.Color.White;
            this.lbl_tiersize.Name = "lbl_tiersize";
            // 
            // lbl_eng_size
            // 
            resources.ApplyResources(this.lbl_eng_size, "lbl_eng_size");
            this.lbl_eng_size.ForeColor = System.Drawing.Color.White;
            this.lbl_eng_size.Name = "lbl_eng_size";
            // 
            // lbl_ac_size
            // 
            resources.ApplyResources(this.lbl_ac_size, "lbl_ac_size");
            this.lbl_ac_size.ForeColor = System.Drawing.Color.White;
            this.lbl_ac_size.Name = "lbl_ac_size";
            // 
            // lbl_mg_size
            // 
            resources.ApplyResources(this.lbl_mg_size, "lbl_mg_size");
            this.lbl_mg_size.ForeColor = System.Drawing.Color.White;
            this.lbl_mg_size.Name = "lbl_mg_size";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // combo_equ_show
            // 
            this.combo_equ_show.BackColor = System.Drawing.Color.White;
            this.combo_equ_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_equ_show.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_equ_show.FormattingEnabled = true;
            resources.ApplyResources(this.combo_equ_show, "combo_equ_show");
            this.combo_equ_show.Name = "combo_equ_show";
            this.combo_equ_show.SelectedIndexChanged += new System.EventHandler(this.combo_equ_show_SelectedIndexChanged);
            // 
            // dataGridequ1
            // 
            this.dataGridequ1.AllowUserToAddRows = false;
            this.dataGridequ1.AllowUserToDeleteRows = false;
            this.dataGridequ1.AllowUserToOrderColumns = true;
            this.dataGridequ1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridequ1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridequ1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridequ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridequ1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            resources.ApplyResources(this.dataGridequ1, "dataGridequ1");
            this.dataGridequ1.Name = "dataGridequ1";
            this.dataGridequ1.ReadOnly = true;
            this.dataGridequ1.VirtualMode = true;
            // 
            // tabb4
            // 
            this.tabb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabb4.Controls.Add(this.tabControl7);
            resources.ApplyResources(this.tabb4, "tabb4");
            this.tabb4.Name = "tabb4";
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.prvvv);
            this.tabControl7.Controls.Add(this.corr);
            this.tabControl7.Controls.Add(this.daii);
            resources.ApplyResources(this.tabControl7, "tabControl7");
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            // 
            // prvvv
            // 
            this.prvvv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.prvvv.Controls.Add(this.dat_grid_prev1);
            this.prvvv.Controls.Add(this.linkLabel3);
            this.prvvv.Controls.Add(this.lb_mod_4);
            this.prvvv.Controls.Add(this.label208);
            this.prvvv.Controls.Add(this.lbl_state_prev);
            this.prvvv.Controls.Add(this.label37);
            this.prvvv.Controls.Add(this.label100);
            this.prvvv.Controls.Add(this.btn_bring_to_upd);
            this.prvvv.Controls.Add(this.txt_pre_4_parts);
            this.prvvv.Controls.Add(this.btn_pre_sho);
            this.prvvv.Controls.Add(this.lbl_prv3);
            this.prvvv.Controls.Add(this.panel1);
            this.prvvv.Controls.Add(this.panel2);
            this.prvvv.Controls.Add(this.label40);
            this.prvvv.Controls.Add(this.label39);
            this.prvvv.Controls.Add(this.txt_pre_5_stat_1);
            this.prvvv.Controls.Add(this.txt_pre_2_type_number);
            this.prvvv.Controls.Add(this.txt_pre_8_user);
            this.prvvv.Controls.Add(this.txt_pre_10_stat_2);
            this.prvvv.Controls.Add(this.txt_pre_9_type_name);
            this.prvvv.Controls.Add(this.txt_pre_1_id);
            this.prvvv.Controls.Add(this.label7);
            this.prvvv.Controls.Add(this.lbl_prv_after);
            this.prvvv.Controls.Add(this.lowww_prv);
            this.prvvv.Controls.Add(this.btn_pre_upd);
            this.prvvv.Controls.Add(this.lbl_prv8);
            this.prvvv.Controls.Add(this.lbl_prv4);
            this.prvvv.Controls.Add(this.lbl_prv1);
            this.prvvv.Controls.Add(this.comb_prev_main1);
            resources.ApplyResources(this.prvvv, "prvvv");
            this.prvvv.Name = "prvvv";
            // 
            // dat_grid_prev1
            // 
            this.dat_grid_prev1.AllowUserToAddRows = false;
            this.dat_grid_prev1.AllowUserToDeleteRows = false;
            this.dat_grid_prev1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_grid_prev1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dat_grid_prev1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dat_grid_prev1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dat_grid_prev1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_grid_prev1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dat_grid_prev1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dat_grid_prev1.DefaultCellStyle = dataGridViewCellStyle41;
            resources.ApplyResources(this.dat_grid_prev1, "dat_grid_prev1");
            this.dat_grid_prev1.MultiSelect = false;
            this.dat_grid_prev1.Name = "dat_grid_prev1";
            this.dat_grid_prev1.ReadOnly = true;
            this.dat_grid_prev1.RowHeadersVisible = false;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.Green;
            this.dat_grid_prev1.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dat_grid_prev1.RowTemplate.ReadOnly = true;
            this.dat_grid_prev1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_grid_prev1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dat_grid_prev1.VirtualMode = true;
            // 
            // linkLabel3
            // 
            resources.ApplyResources(this.linkLabel3, "linkLabel3");
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel3.ForeColor = System.Drawing.Color.Red;
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.TabStop = true;
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // lb_mod_4
            // 
            resources.ApplyResources(this.lb_mod_4, "lb_mod_4");
            this.lb_mod_4.Name = "lb_mod_4";
            // 
            // label208
            // 
            resources.ApplyResources(this.label208, "label208");
            this.label208.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label208.Name = "label208";
            // 
            // lbl_state_prev
            // 
            resources.ApplyResources(this.lbl_state_prev, "lbl_state_prev");
            this.lbl_state_prev.Name = "lbl_state_prev";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label37.Name = "label37";
            // 
            // label100
            // 
            resources.ApplyResources(this.label100, "label100");
            this.label100.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label100.Name = "label100";
            // 
            // btn_bring_to_upd
            // 
            resources.ApplyResources(this.btn_bring_to_upd, "btn_bring_to_upd");
            this.btn_bring_to_upd.Name = "btn_bring_to_upd";
            this.btn_bring_to_upd.UseVisualStyleBackColor = true;
            this.btn_bring_to_upd.Click += new System.EventHandler(this.btn_bring_to_upd_Click);
            // 
            // txt_pre_4_parts
            // 
            resources.ApplyResources(this.txt_pre_4_parts, "txt_pre_4_parts");
            this.txt_pre_4_parts.Name = "txt_pre_4_parts";
            // 
            // btn_pre_sho
            // 
            resources.ApplyResources(this.btn_pre_sho, "btn_pre_sho");
            this.btn_pre_sho.Name = "btn_pre_sho";
            this.btn_pre_sho.UseVisualStyleBackColor = true;
            this.btn_pre_sho.Click += new System.EventHandler(this.btn_pre_sho_Click);
            // 
            // lbl_prv3
            // 
            resources.ApplyResources(this.lbl_prv3, "lbl_prv3");
            this.lbl_prv3.Name = "lbl_prv3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label95);
            this.panel5.Controls.Add(this.label97);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label95
            // 
            resources.ApplyResources(this.label95, "label95");
            this.label95.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label95.Name = "label95";
            // 
            // label97
            // 
            resources.ApplyResources(this.label97, "label97");
            this.label97.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label97.Name = "label97";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel59);
            this.panel2.Controls.Add(this.panel58);
            this.panel2.Controls.Add(this.panel57);
            this.panel2.Controls.Add(this.label239);
            this.panel2.Controls.Add(this.panel32);
            this.panel2.Controls.Add(this.label228);
            this.panel2.Controls.Add(this.label226);
            this.panel2.Controls.Add(this.txt_pre_0_now_hours);
            this.panel2.Controls.Add(this.btn_add_labor);
            this.panel2.Controls.Add(this.btn_del_labor);
            this.panel2.Controls.Add(this.btn_prev_main_ins_upd);
            this.panel2.Controls.Add(this.date_prv);
            this.panel2.Controls.Add(this.txt_duration);
            this.panel2.Controls.Add(this.pnl_labor);
            this.panel2.Controls.Add(this.flow_labor);
            this.panel2.Controls.Add(this.lbl_prv2);
            this.panel2.Controls.Add(this.txt_pre_7_det);
            this.panel2.Controls.Add(this.txt_pre_6_cost);
            this.panel2.Controls.Add(this.lbl_hours_ins1);
            this.panel2.Controls.Add(this.lbl_prv_hrs_stage3);
            this.panel2.Controls.Add(this.pnl_last_hours);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Name = "panel2";
            // 
            // panel59
            // 
            this.panel59.Controls.Add(this.label185);
            this.panel59.Controls.Add(this.label153);
            this.panel59.Controls.Add(this.lbl_prv5);
            this.panel59.Controls.Add(this.label111);
            this.panel59.Controls.Add(this.lbl_prv6);
            resources.ApplyResources(this.panel59, "panel59");
            this.panel59.Name = "panel59";
            // 
            // label185
            // 
            resources.ApplyResources(this.label185, "label185");
            this.label185.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label185.Name = "label185";
            // 
            // label153
            // 
            resources.ApplyResources(this.label153, "label153");
            this.label153.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label153.Name = "label153";
            // 
            // lbl_prv5
            // 
            resources.ApplyResources(this.lbl_prv5, "lbl_prv5");
            this.lbl_prv5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_prv5.Name = "lbl_prv5";
            // 
            // label111
            // 
            resources.ApplyResources(this.label111, "label111");
            this.label111.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label111.Name = "label111";
            // 
            // lbl_prv6
            // 
            resources.ApplyResources(this.lbl_prv6, "lbl_prv6");
            this.lbl_prv6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_prv6.Name = "lbl_prv6";
            // 
            // panel58
            // 
            this.panel58.Controls.Add(this.txt_pre_3_hours);
            this.panel58.Controls.Add(this.txt_pre_3_numm);
            this.panel58.Controls.Add(this.lbl_interval);
            this.panel58.Controls.Add(this.label225);
            this.panel58.Controls.Add(this.lbl_prv_hrs_stage4);
            resources.ApplyResources(this.panel58, "panel58");
            this.panel58.Name = "panel58";
            // 
            // txt_pre_3_hours
            // 
            resources.ApplyResources(this.txt_pre_3_hours, "txt_pre_3_hours");
            this.txt_pre_3_hours.ForeColor = System.Drawing.Color.White;
            this.txt_pre_3_hours.Name = "txt_pre_3_hours";
            // 
            // txt_pre_3_numm
            // 
            resources.ApplyResources(this.txt_pre_3_numm, "txt_pre_3_numm");
            this.txt_pre_3_numm.ForeColor = System.Drawing.Color.White;
            this.txt_pre_3_numm.Name = "txt_pre_3_numm";
            // 
            // lbl_interval
            // 
            resources.ApplyResources(this.lbl_interval, "lbl_interval");
            this.lbl_interval.ForeColor = System.Drawing.Color.White;
            this.lbl_interval.Name = "lbl_interval";
            // 
            // label225
            // 
            resources.ApplyResources(this.label225, "label225");
            this.label225.ForeColor = System.Drawing.Color.White;
            this.label225.Name = "label225";
            // 
            // lbl_prv_hrs_stage4
            // 
            resources.ApplyResources(this.lbl_prv_hrs_stage4, "lbl_prv_hrs_stage4");
            this.lbl_prv_hrs_stage4.ForeColor = System.Drawing.Color.White;
            this.lbl_prv_hrs_stage4.Name = "lbl_prv_hrs_stage4";
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.lbl_hours_ins2);
            resources.ApplyResources(this.panel57, "panel57");
            this.panel57.Name = "panel57";
            // 
            // lbl_hours_ins2
            // 
            resources.ApplyResources(this.lbl_hours_ins2, "lbl_hours_ins2");
            this.lbl_hours_ins2.ForeColor = System.Drawing.Color.White;
            this.lbl_hours_ins2.Name = "lbl_hours_ins2";
            // 
            // label239
            // 
            resources.ApplyResources(this.label239, "label239");
            this.label239.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label239.Name = "label239";
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.label237);
            this.panel32.Controls.Add(this.label232);
            this.panel32.Controls.Add(this.label236);
            resources.ApplyResources(this.panel32, "panel32");
            this.panel32.Name = "panel32";
            // 
            // label237
            // 
            resources.ApplyResources(this.label237, "label237");
            this.label237.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label237.Name = "label237";
            // 
            // label232
            // 
            resources.ApplyResources(this.label232, "label232");
            this.label232.ForeColor = System.Drawing.Color.White;
            this.label232.Name = "label232";
            // 
            // label236
            // 
            resources.ApplyResources(this.label236, "label236");
            this.label236.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label236.Name = "label236";
            // 
            // label228
            // 
            resources.ApplyResources(this.label228, "label228");
            this.label228.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label228.Name = "label228";
            // 
            // label226
            // 
            resources.ApplyResources(this.label226, "label226");
            this.label226.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label226.Name = "label226";
            // 
            // txt_pre_0_now_hours
            // 
            this.txt_pre_0_now_hours.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_pre_0_now_hours, "txt_pre_0_now_hours");
            this.txt_pre_0_now_hours.Name = "txt_pre_0_now_hours";
            this.txt_pre_0_now_hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // btn_add_labor
            // 
            this.btn_add_labor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add_labor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_labor.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_add_labor, "btn_add_labor");
            this.btn_add_labor.ForeColor = System.Drawing.Color.White;
            this.btn_add_labor.Name = "btn_add_labor";
            this.btn_add_labor.UseVisualStyleBackColor = false;
            this.btn_add_labor.Click += new System.EventHandler(this.btn_add_labor_Click);
            // 
            // btn_del_labor
            // 
            this.btn_del_labor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_del_labor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_del_labor, "btn_del_labor");
            this.btn_del_labor.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_del_labor.ForeColor = System.Drawing.Color.White;
            this.btn_del_labor.Name = "btn_del_labor";
            this.btn_del_labor.UseVisualStyleBackColor = false;
            this.btn_del_labor.Click += new System.EventHandler(this.btn_del_labor_Click);
            // 
            // btn_prev_main_ins_upd
            // 
            this.btn_prev_main_ins_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev_main_ins_upd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_prev_main_ins_upd, "btn_prev_main_ins_upd");
            this.btn_prev_main_ins_upd.ForeColor = System.Drawing.Color.White;
            this.btn_prev_main_ins_upd.Name = "btn_prev_main_ins_upd";
            this.btn_prev_main_ins_upd.UseVisualStyleBackColor = true;
            this.btn_prev_main_ins_upd.Click += new System.EventHandler(this.btn_prev_main_ins_upd_Click);
            // 
            // date_prv
            // 
            this.date_prv.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_prv, "date_prv");
            this.date_prv.Name = "date_prv";
            // 
            // txt_duration
            // 
            this.txt_duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_duration, "txt_duration");
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // pnl_labor
            // 
            this.pnl_labor.Controls.Add(this.label23);
            this.pnl_labor.Controls.Add(this.label79);
            this.pnl_labor.Controls.Add(this.label78);
            this.pnl_labor.Controls.Add(this.label77);
            resources.ApplyResources(this.pnl_labor, "pnl_labor");
            this.pnl_labor.Name = "pnl_labor";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label23.Name = "label23";
            // 
            // label79
            // 
            resources.ApplyResources(this.label79, "label79");
            this.label79.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label79.Name = "label79";
            // 
            // label78
            // 
            resources.ApplyResources(this.label78, "label78");
            this.label78.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label78.Name = "label78";
            // 
            // label77
            // 
            resources.ApplyResources(this.label77, "label77");
            this.label77.Name = "label77";
            // 
            // flow_labor
            // 
            this.flow_labor.AllowDrop = true;
            resources.ApplyResources(this.flow_labor, "flow_labor");
            this.flow_labor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flow_labor.Name = "flow_labor";
            // 
            // lbl_prv2
            // 
            resources.ApplyResources(this.lbl_prv2, "lbl_prv2");
            this.lbl_prv2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_prv2.Name = "lbl_prv2";
            // 
            // txt_pre_7_det
            // 
            this.txt_pre_7_det.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_pre_7_det, "txt_pre_7_det");
            this.txt_pre_7_det.Name = "txt_pre_7_det";
            // 
            // txt_pre_6_cost
            // 
            this.txt_pre_6_cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_pre_6_cost, "txt_pre_6_cost");
            this.txt_pre_6_cost.Name = "txt_pre_6_cost";
            this.txt_pre_6_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // lbl_hours_ins1
            // 
            resources.ApplyResources(this.lbl_hours_ins1, "lbl_hours_ins1");
            this.lbl_hours_ins1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_hours_ins1.Name = "lbl_hours_ins1";
            // 
            // lbl_prv_hrs_stage3
            // 
            resources.ApplyResources(this.lbl_prv_hrs_stage3, "lbl_prv_hrs_stage3");
            this.lbl_prv_hrs_stage3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_prv_hrs_stage3.Name = "lbl_prv_hrs_stage3";
            // 
            // pnl_last_hours
            // 
            this.pnl_last_hours.Controls.Add(this.lbl_lastH);
            this.pnl_last_hours.Controls.Add(this.label230);
            resources.ApplyResources(this.pnl_last_hours, "pnl_last_hours");
            this.pnl_last_hours.Name = "pnl_last_hours";
            // 
            // lbl_lastH
            // 
            resources.ApplyResources(this.lbl_lastH, "lbl_lastH");
            this.lbl_lastH.ForeColor = System.Drawing.Color.White;
            this.lbl_lastH.Name = "lbl_lastH";
            // 
            // label230
            // 
            resources.ApplyResources(this.label230, "label230");
            this.label230.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label230.Name = "label230";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // txt_pre_5_stat_1
            // 
            resources.ApplyResources(this.txt_pre_5_stat_1, "txt_pre_5_stat_1");
            this.txt_pre_5_stat_1.Name = "txt_pre_5_stat_1";
            // 
            // txt_pre_2_type_number
            // 
            resources.ApplyResources(this.txt_pre_2_type_number, "txt_pre_2_type_number");
            this.txt_pre_2_type_number.Name = "txt_pre_2_type_number";
            // 
            // txt_pre_8_user
            // 
            resources.ApplyResources(this.txt_pre_8_user, "txt_pre_8_user");
            this.txt_pre_8_user.Name = "txt_pre_8_user";
            // 
            // txt_pre_10_stat_2
            // 
            resources.ApplyResources(this.txt_pre_10_stat_2, "txt_pre_10_stat_2");
            this.txt_pre_10_stat_2.Name = "txt_pre_10_stat_2";
            // 
            // txt_pre_9_type_name
            // 
            resources.ApplyResources(this.txt_pre_9_type_name, "txt_pre_9_type_name");
            this.txt_pre_9_type_name.Name = "txt_pre_9_type_name";
            // 
            // txt_pre_1_id
            // 
            resources.ApplyResources(this.txt_pre_1_id, "txt_pre_1_id");
            this.txt_pre_1_id.Name = "txt_pre_1_id";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lbl_prv_after
            // 
            resources.ApplyResources(this.lbl_prv_after, "lbl_prv_after");
            this.lbl_prv_after.ForeColor = System.Drawing.Color.White;
            this.lbl_prv_after.Name = "lbl_prv_after";
            // 
            // lowww_prv
            // 
            resources.ApplyResources(this.lowww_prv, "lowww_prv");
            this.lowww_prv.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lowww_prv.Name = "lowww_prv";
            // 
            // btn_pre_upd
            // 
            resources.ApplyResources(this.btn_pre_upd, "btn_pre_upd");
            this.btn_pre_upd.Name = "btn_pre_upd";
            this.btn_pre_upd.UseVisualStyleBackColor = true;
            this.btn_pre_upd.Click += new System.EventHandler(this.btn_pre_upd_Click);
            // 
            // lbl_prv8
            // 
            resources.ApplyResources(this.lbl_prv8, "lbl_prv8");
            this.lbl_prv8.Name = "lbl_prv8";
            // 
            // lbl_prv4
            // 
            resources.ApplyResources(this.lbl_prv4, "lbl_prv4");
            this.lbl_prv4.Name = "lbl_prv4";
            // 
            // lbl_prv1
            // 
            resources.ApplyResources(this.lbl_prv1, "lbl_prv1");
            this.lbl_prv1.Name = "lbl_prv1";
            // 
            // comb_prev_main1
            // 
            this.comb_prev_main1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_prev_main1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_prev_main1.FormattingEnabled = true;
            resources.ApplyResources(this.comb_prev_main1, "comb_prev_main1");
            this.comb_prev_main1.Name = "comb_prev_main1";
            this.comb_prev_main1.SelectedIndexChanged += new System.EventHandler(this.comb_prev_main1_SelectedIndexChanged);
            // 
            // corr
            // 
            this.corr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.corr.Controls.Add(this.btn_cor_bring);
            this.corr.Controls.Add(this.linkLabel4);
            this.corr.Controls.Add(this.lb_mod_5);
            this.corr.Controls.Add(this.label209);
            this.corr.Controls.Add(this.lbl_cor_name);
            this.corr.Controls.Add(this.lbl_dai_corr_state1);
            this.corr.Controls.Add(this.lbl_dai_state1);
            this.corr.Controls.Add(this.label165);
            this.corr.Controls.Add(this.label170);
            this.corr.Controls.Add(this.txt_main_ins81);
            this.corr.Controls.Add(this.txt_main_id1);
            this.corr.Controls.Add(this.txt_cor_state);
            this.corr.Controls.Add(this.label171);
            this.corr.Controls.Add(this.label172);
            this.corr.Controls.Add(this.datagrid_cor_notdone);
            this.corr.Controls.Add(this.combo_cor_equ);
            this.corr.Controls.Add(this.lbl_cor_not_done);
            this.corr.Controls.Add(this.pnl_cor);
            resources.ApplyResources(this.corr, "corr");
            this.corr.Name = "corr";
            // 
            // btn_cor_bring
            // 
            this.btn_cor_bring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cor_bring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cor_bring.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_cor_bring, "btn_cor_bring");
            this.btn_cor_bring.ForeColor = System.Drawing.Color.White;
            this.btn_cor_bring.Name = "btn_cor_bring";
            this.btn_cor_bring.UseVisualStyleBackColor = false;
            // 
            // linkLabel4
            // 
            resources.ApplyResources(this.linkLabel4, "linkLabel4");
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel4.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel4.ForeColor = System.Drawing.Color.Red;
            this.linkLabel4.LinkColor = System.Drawing.Color.Red;
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.TabStop = true;
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // lb_mod_5
            // 
            resources.ApplyResources(this.lb_mod_5, "lb_mod_5");
            this.lb_mod_5.Name = "lb_mod_5";
            // 
            // label209
            // 
            resources.ApplyResources(this.label209, "label209");
            this.label209.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label209.Name = "label209";
            // 
            // lbl_cor_name
            // 
            resources.ApplyResources(this.lbl_cor_name, "lbl_cor_name");
            this.lbl_cor_name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_cor_name.Name = "lbl_cor_name";
            // 
            // lbl_dai_corr_state1
            // 
            resources.ApplyResources(this.lbl_dai_corr_state1, "lbl_dai_corr_state1");
            this.lbl_dai_corr_state1.Name = "lbl_dai_corr_state1";
            // 
            // lbl_dai_state1
            // 
            resources.ApplyResources(this.lbl_dai_state1, "lbl_dai_state1");
            this.lbl_dai_state1.Name = "lbl_dai_state1";
            // 
            // label165
            // 
            resources.ApplyResources(this.label165, "label165");
            this.label165.Name = "label165";
            // 
            // label170
            // 
            resources.ApplyResources(this.label170, "label170");
            this.label170.Name = "label170";
            // 
            // txt_main_ins81
            // 
            resources.ApplyResources(this.txt_main_ins81, "txt_main_ins81");
            this.txt_main_ins81.Name = "txt_main_ins81";
            // 
            // txt_main_id1
            // 
            resources.ApplyResources(this.txt_main_id1, "txt_main_id1");
            this.txt_main_id1.Name = "txt_main_id1";
            // 
            // txt_cor_state
            // 
            resources.ApplyResources(this.txt_cor_state, "txt_cor_state");
            this.txt_cor_state.Name = "txt_cor_state";
            // 
            // label171
            // 
            resources.ApplyResources(this.label171, "label171");
            this.label171.Name = "label171";
            // 
            // label172
            // 
            resources.ApplyResources(this.label172, "label172");
            this.label172.Name = "label172";
            // 
            // datagrid_cor_notdone
            // 
            this.datagrid_cor_notdone.AllowUserToAddRows = false;
            this.datagrid_cor_notdone.AllowUserToDeleteRows = false;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.datagrid_cor_notdone.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            this.datagrid_cor_notdone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_cor_notdone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_cor_notdone.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datagrid_cor_notdone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_cor_notdone.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_cor_notdone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.datagrid_cor_notdone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_cor_notdone.DefaultCellStyle = dataGridViewCellStyle45;
            resources.ApplyResources(this.datagrid_cor_notdone, "datagrid_cor_notdone");
            this.datagrid_cor_notdone.MultiSelect = false;
            this.datagrid_cor_notdone.Name = "datagrid_cor_notdone";
            this.datagrid_cor_notdone.ReadOnly = true;
            this.datagrid_cor_notdone.RowHeadersVisible = false;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.Green;
            this.datagrid_cor_notdone.RowsDefaultCellStyle = dataGridViewCellStyle46;
            this.datagrid_cor_notdone.RowTemplate.ReadOnly = true;
            this.datagrid_cor_notdone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_cor_notdone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_cor_notdone.VirtualMode = true;
            // 
            // combo_cor_equ
            // 
            this.combo_cor_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_cor_equ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cor_equ.FormattingEnabled = true;
            resources.ApplyResources(this.combo_cor_equ, "combo_cor_equ");
            this.combo_cor_equ.Name = "combo_cor_equ";
            this.combo_cor_equ.SelectedIndexChanged += new System.EventHandler(this.combo_cor_equ_SelectedIndexChanged);
            // 
            // lbl_cor_not_done
            // 
            resources.ApplyResources(this.lbl_cor_not_done, "lbl_cor_not_done");
            this.lbl_cor_not_done.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_cor_not_done.Name = "lbl_cor_not_done";
            // 
            // pnl_cor
            // 
            this.pnl_cor.Controls.Add(this.label175);
            this.pnl_cor.Controls.Add(this.txt_cor_dura);
            this.pnl_cor.Controls.Add(this.label158);
            this.pnl_cor.Controls.Add(this.btn_cor_del_lapor);
            this.pnl_cor.Controls.Add(this.btn_cor_add_lapor);
            this.pnl_cor.Controls.Add(this.radi_cor_notdone);
            this.pnl_cor.Controls.Add(this.radi_cor_done);
            this.pnl_cor.Controls.Add(this.txt_cor_deta);
            this.pnl_cor.Controls.Add(this.txt_cor_cost);
            this.pnl_cor.Controls.Add(this.txt_main_ins31);
            this.pnl_cor.Controls.Add(this.txt_cor_parts);
            this.pnl_cor.Controls.Add(this.date_cor);
            this.pnl_cor.Controls.Add(this.label159);
            this.pnl_cor.Controls.Add(this.label160);
            this.pnl_cor.Controls.Add(this.btn_cor_step2);
            this.pnl_cor.Controls.Add(this.label161);
            this.pnl_cor.Controls.Add(this.label162);
            this.pnl_cor.Controls.Add(this.label163);
            this.pnl_cor.Controls.Add(this.flow_cor_labors);
            this.pnl_cor.Controls.Add(this.pnl_cor_names);
            resources.ApplyResources(this.pnl_cor, "pnl_cor");
            this.pnl_cor.Name = "pnl_cor";
            // 
            // label175
            // 
            resources.ApplyResources(this.label175, "label175");
            this.label175.ForeColor = System.Drawing.Color.White;
            this.label175.Name = "label175";
            // 
            // txt_cor_dura
            // 
            this.txt_cor_dura.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_cor_dura, "txt_cor_dura");
            this.txt_cor_dura.Name = "txt_cor_dura";
            this.txt_cor_dura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // label158
            // 
            resources.ApplyResources(this.label158, "label158");
            this.label158.ForeColor = System.Drawing.Color.White;
            this.label158.Name = "label158";
            // 
            // btn_cor_del_lapor
            // 
            this.btn_cor_del_lapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cor_del_lapor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_cor_del_lapor, "btn_cor_del_lapor");
            this.btn_cor_del_lapor.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_cor_del_lapor.ForeColor = System.Drawing.Color.White;
            this.btn_cor_del_lapor.Name = "btn_cor_del_lapor";
            this.btn_cor_del_lapor.UseVisualStyleBackColor = false;
            this.btn_cor_del_lapor.Click += new System.EventHandler(this.btn_cor_del_lapor_Click);
            // 
            // btn_cor_add_lapor
            // 
            this.btn_cor_add_lapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cor_add_lapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cor_add_lapor.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_cor_add_lapor, "btn_cor_add_lapor");
            this.btn_cor_add_lapor.ForeColor = System.Drawing.Color.White;
            this.btn_cor_add_lapor.Name = "btn_cor_add_lapor";
            this.btn_cor_add_lapor.UseVisualStyleBackColor = false;
            this.btn_cor_add_lapor.Click += new System.EventHandler(this.btn_cor_add_lapor_Click);
            // 
            // radi_cor_notdone
            // 
            resources.ApplyResources(this.radi_cor_notdone, "radi_cor_notdone");
            this.radi_cor_notdone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radi_cor_notdone.ForeColor = System.Drawing.Color.White;
            this.radi_cor_notdone.Name = "radi_cor_notdone";
            this.radi_cor_notdone.Tag = "1";
            this.radi_cor_notdone.UseVisualStyleBackColor = true;
            // 
            // radi_cor_done
            // 
            resources.ApplyResources(this.radi_cor_done, "radi_cor_done");
            this.radi_cor_done.Checked = true;
            this.radi_cor_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radi_cor_done.ForeColor = System.Drawing.Color.White;
            this.radi_cor_done.Name = "radi_cor_done";
            this.radi_cor_done.TabStop = true;
            this.radi_cor_done.Tag = "1";
            this.radi_cor_done.UseVisualStyleBackColor = true;
            // 
            // txt_cor_deta
            // 
            this.txt_cor_deta.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_cor_deta, "txt_cor_deta");
            this.txt_cor_deta.Name = "txt_cor_deta";
            // 
            // txt_cor_cost
            // 
            this.txt_cor_cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_cor_cost, "txt_cor_cost");
            this.txt_cor_cost.Name = "txt_cor_cost";
            this.txt_cor_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_main_ins31
            // 
            this.txt_main_ins31.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_main_ins31, "txt_main_ins31");
            this.txt_main_ins31.Name = "txt_main_ins31";
            // 
            // txt_cor_parts
            // 
            this.txt_cor_parts.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_cor_parts, "txt_cor_parts");
            this.txt_cor_parts.Name = "txt_cor_parts";
            // 
            // date_cor
            // 
            this.date_cor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_cor, "date_cor");
            this.date_cor.Name = "date_cor";
            // 
            // label159
            // 
            resources.ApplyResources(this.label159, "label159");
            this.label159.ForeColor = System.Drawing.Color.White;
            this.label159.Name = "label159";
            // 
            // label160
            // 
            resources.ApplyResources(this.label160, "label160");
            this.label160.ForeColor = System.Drawing.Color.White;
            this.label160.Name = "label160";
            // 
            // btn_cor_step2
            // 
            this.btn_cor_step2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cor_step2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cor_step2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_cor_step2, "btn_cor_step2");
            this.btn_cor_step2.ForeColor = System.Drawing.Color.White;
            this.btn_cor_step2.Name = "btn_cor_step2";
            this.btn_cor_step2.UseVisualStyleBackColor = false;
            this.btn_cor_step2.Click += new System.EventHandler(this.btn_cor_step2_Click);
            // 
            // label161
            // 
            resources.ApplyResources(this.label161, "label161");
            this.label161.ForeColor = System.Drawing.Color.White;
            this.label161.Name = "label161";
            // 
            // label162
            // 
            resources.ApplyResources(this.label162, "label162");
            this.label162.ForeColor = System.Drawing.Color.White;
            this.label162.Name = "label162";
            // 
            // label163
            // 
            resources.ApplyResources(this.label163, "label163");
            this.label163.ForeColor = System.Drawing.Color.White;
            this.label163.Name = "label163";
            // 
            // flow_cor_labors
            // 
            this.flow_cor_labors.AllowDrop = true;
            resources.ApplyResources(this.flow_cor_labors, "flow_cor_labors");
            this.flow_cor_labors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flow_cor_labors.Name = "flow_cor_labors";
            // 
            // pnl_cor_names
            // 
            this.pnl_cor_names.Controls.Add(this.label166);
            this.pnl_cor_names.Controls.Add(this.label167);
            this.pnl_cor_names.Controls.Add(this.label168);
            resources.ApplyResources(this.pnl_cor_names, "pnl_cor_names");
            this.pnl_cor_names.Name = "pnl_cor_names";
            // 
            // label166
            // 
            resources.ApplyResources(this.label166, "label166");
            this.label166.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label166.Name = "label166";
            // 
            // label167
            // 
            resources.ApplyResources(this.label167, "label167");
            this.label167.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label167.Name = "label167";
            // 
            // label168
            // 
            resources.ApplyResources(this.label168, "label168");
            this.label168.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label168.Name = "label168";
            // 
            // daii
            // 
            this.daii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.daii.Controls.Add(this.linkLabel5);
            this.daii.Controls.Add(this.lb_mod_6);
            this.daii.Controls.Add(this.label210);
            this.daii.Controls.Add(this.lbl_main_name);
            this.daii.Controls.Add(this.lbl_check_id);
            this.daii.Controls.Add(this.lbl_dai_state);
            this.daii.Controls.Add(this.lbl_dai_parts);
            this.daii.Controls.Add(this.panel_dai);
            this.daii.Controls.Add(this.lbl_dai_corr_state);
            this.daii.Controls.Add(this.dataGrid_cor_dai);
            this.daii.Controls.Add(this.comb_CP_main_equ);
            this.daii.Controls.Add(this.label107);
            this.daii.Controls.Add(this.btn_bring_to_upd2);
            this.daii.Controls.Add(this.label108);
            this.daii.Controls.Add(this.label109);
            this.daii.Controls.Add(this.label41);
            this.daii.Controls.Add(this.txt_main_ins8);
            this.daii.Controls.Add(this.txt_main_id);
            this.daii.Controls.Add(this.txt_main_stg_det_corr);
            this.daii.Controls.Add(this.txt_main_ins5);
            this.daii.Controls.Add(this.label59);
            this.daii.Controls.Add(this.label9);
            this.daii.Controls.Add(this.panel12);
            resources.ApplyResources(this.daii, "daii");
            this.daii.Name = "daii";
            // 
            // linkLabel5
            // 
            resources.ApplyResources(this.linkLabel5, "linkLabel5");
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel5.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel5.ForeColor = System.Drawing.Color.Red;
            this.linkLabel5.LinkColor = System.Drawing.Color.Red;
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.TabStop = true;
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // lb_mod_6
            // 
            resources.ApplyResources(this.lb_mod_6, "lb_mod_6");
            this.lb_mod_6.Name = "lb_mod_6";
            // 
            // label210
            // 
            resources.ApplyResources(this.label210, "label210");
            this.label210.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label210.Name = "label210";
            // 
            // lbl_main_name
            // 
            resources.ApplyResources(this.lbl_main_name, "lbl_main_name");
            this.lbl_main_name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_main_name.Name = "lbl_main_name";
            // 
            // lbl_check_id
            // 
            resources.ApplyResources(this.lbl_check_id, "lbl_check_id");
            this.lbl_check_id.Name = "lbl_check_id";
            // 
            // lbl_dai_state
            // 
            resources.ApplyResources(this.lbl_dai_state, "lbl_dai_state");
            this.lbl_dai_state.Name = "lbl_dai_state";
            // 
            // lbl_dai_parts
            // 
            resources.ApplyResources(this.lbl_dai_parts, "lbl_dai_parts");
            this.lbl_dai_parts.Name = "lbl_dai_parts";
            // 
            // panel_dai
            // 
            this.panel_dai.Controls.Add(this.panel15);
            this.panel_dai.Controls.Add(this.flow_dai);
            resources.ApplyResources(this.panel_dai, "panel_dai");
            this.panel_dai.Name = "panel_dai";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label96);
            this.panel15.Controls.Add(this.label137);
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // label96
            // 
            resources.ApplyResources(this.label96, "label96");
            this.label96.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label96.Name = "label96";
            // 
            // label137
            // 
            resources.ApplyResources(this.label137, "label137");
            this.label137.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label137.Name = "label137";
            // 
            // flow_dai
            // 
            this.flow_dai.AllowDrop = true;
            resources.ApplyResources(this.flow_dai, "flow_dai");
            this.flow_dai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flow_dai.Name = "flow_dai";
            // 
            // lbl_dai_corr_state
            // 
            resources.ApplyResources(this.lbl_dai_corr_state, "lbl_dai_corr_state");
            this.lbl_dai_corr_state.Name = "lbl_dai_corr_state";
            // 
            // dataGrid_cor_dai
            // 
            this.dataGrid_cor_dai.AllowUserToAddRows = false;
            this.dataGrid_cor_dai.AllowUserToDeleteRows = false;
            this.dataGrid_cor_dai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_cor_dai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_cor_dai.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrid_cor_dai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_cor_dai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_cor_dai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dataGrid_cor_dai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_cor_dai.DefaultCellStyle = dataGridViewCellStyle48;
            resources.ApplyResources(this.dataGrid_cor_dai, "dataGrid_cor_dai");
            this.dataGrid_cor_dai.MultiSelect = false;
            this.dataGrid_cor_dai.Name = "dataGrid_cor_dai";
            this.dataGrid_cor_dai.ReadOnly = true;
            this.dataGrid_cor_dai.RowHeadersVisible = false;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.Green;
            this.dataGrid_cor_dai.RowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dataGrid_cor_dai.RowTemplate.ReadOnly = true;
            this.dataGrid_cor_dai.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_cor_dai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_cor_dai.VirtualMode = true;
            // 
            // comb_CP_main_equ
            // 
            this.comb_CP_main_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_CP_main_equ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_CP_main_equ.FormattingEnabled = true;
            resources.ApplyResources(this.comb_CP_main_equ, "comb_CP_main_equ");
            this.comb_CP_main_equ.Name = "comb_CP_main_equ";
            this.comb_CP_main_equ.SelectedIndexChanged += new System.EventHandler(this.comb_CP_main_equ_SelectedIndexChanged);
            // 
            // label107
            // 
            resources.ApplyResources(this.label107, "label107");
            this.label107.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label107.Name = "label107";
            // 
            // btn_bring_to_upd2
            // 
            this.btn_bring_to_upd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_bring_to_upd2, "btn_bring_to_upd2");
            this.btn_bring_to_upd2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_bring_to_upd2.ForeColor = System.Drawing.Color.White;
            this.btn_bring_to_upd2.Name = "btn_bring_to_upd2";
            this.btn_bring_to_upd2.UseVisualStyleBackColor = false;
            this.btn_bring_to_upd2.Click += new System.EventHandler(this.btn_bring_to_upd2_Click);
            // 
            // label108
            // 
            resources.ApplyResources(this.label108, "label108");
            this.label108.Name = "label108";
            // 
            // label109
            // 
            resources.ApplyResources(this.label109, "label109");
            this.label109.Name = "label109";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // txt_main_ins8
            // 
            resources.ApplyResources(this.txt_main_ins8, "txt_main_ins8");
            this.txt_main_ins8.Name = "txt_main_ins8";
            // 
            // txt_main_id
            // 
            resources.ApplyResources(this.txt_main_id, "txt_main_id");
            this.txt_main_id.Name = "txt_main_id";
            // 
            // txt_main_stg_det_corr
            // 
            resources.ApplyResources(this.txt_main_stg_det_corr, "txt_main_stg_det_corr");
            this.txt_main_stg_det_corr.Name = "txt_main_stg_det_corr";
            // 
            // txt_main_ins5
            // 
            resources.ApplyResources(this.txt_main_ins5, "txt_main_ins5");
            this.txt_main_ins5.Name = "txt_main_ins5";
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.Name = "label59";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label177);
            this.panel12.Controls.Add(this.linkLabel2);
            this.panel12.Controls.Add(this.linkLabel1);
            this.panel12.Controls.Add(this.txt_duration2);
            this.panel12.Controls.Add(this.label112);
            this.panel12.Controls.Add(this.btn_del_labor2);
            this.panel12.Controls.Add(this.btn_Corr_main_ins_upd);
            this.panel12.Controls.Add(this.btn_add_labor2);
            this.panel12.Controls.Add(this.radio_corr_dai_Not_done);
            this.panel12.Controls.Add(this.radio_corr_dai_done);
            this.panel12.Controls.Add(this.txt_main_ins7);
            this.panel12.Controls.Add(this.flow_labor2);
            this.panel12.Controls.Add(this.txt_main_ins6);
            this.panel12.Controls.Add(this.pnl_labor2);
            this.panel12.Controls.Add(this.txt_main_ins4);
            this.panel12.Controls.Add(this.date_main_ins);
            this.panel12.Controls.Add(this.label58);
            this.panel12.Controls.Add(this.txt_main_ins3);
            this.panel12.Controls.Add(this.label57);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.label10);
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // label177
            // 
            resources.ApplyResources(this.label177, "label177");
            this.label177.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label177.Name = "label177";
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_duration2
            // 
            this.txt_duration2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_duration2, "txt_duration2");
            this.txt_duration2.Name = "txt_duration2";
            this.txt_duration2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // label112
            // 
            resources.ApplyResources(this.label112, "label112");
            this.label112.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label112.Name = "label112";
            // 
            // btn_del_labor2
            // 
            this.btn_del_labor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_del_labor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del_labor2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_del_labor2, "btn_del_labor2");
            this.btn_del_labor2.ForeColor = System.Drawing.Color.White;
            this.btn_del_labor2.Name = "btn_del_labor2";
            this.btn_del_labor2.UseVisualStyleBackColor = false;
            this.btn_del_labor2.Click += new System.EventHandler(this.btn_del_labor2_Click);
            // 
            // btn_Corr_main_ins_upd
            // 
            this.btn_Corr_main_ins_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Corr_main_ins_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Corr_main_ins_upd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_Corr_main_ins_upd, "btn_Corr_main_ins_upd");
            this.btn_Corr_main_ins_upd.ForeColor = System.Drawing.Color.White;
            this.btn_Corr_main_ins_upd.Name = "btn_Corr_main_ins_upd";
            this.btn_Corr_main_ins_upd.UseVisualStyleBackColor = false;
            this.btn_Corr_main_ins_upd.Click += new System.EventHandler(this.btn_Corr_main_ins_upd_Click);
            // 
            // btn_add_labor2
            // 
            this.btn_add_labor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add_labor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_labor2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_add_labor2, "btn_add_labor2");
            this.btn_add_labor2.ForeColor = System.Drawing.Color.White;
            this.btn_add_labor2.Name = "btn_add_labor2";
            this.btn_add_labor2.UseVisualStyleBackColor = false;
            this.btn_add_labor2.Click += new System.EventHandler(this.btn_add_labor2_Click);
            // 
            // radio_corr_dai_Not_done
            // 
            resources.ApplyResources(this.radio_corr_dai_Not_done, "radio_corr_dai_Not_done");
            this.radio_corr_dai_Not_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_corr_dai_Not_done.ForeColor = System.Drawing.Color.White;
            this.radio_corr_dai_Not_done.Name = "radio_corr_dai_Not_done";
            this.radio_corr_dai_Not_done.Tag = "1";
            this.radio_corr_dai_Not_done.UseVisualStyleBackColor = true;
            // 
            // radio_corr_dai_done
            // 
            resources.ApplyResources(this.radio_corr_dai_done, "radio_corr_dai_done");
            this.radio_corr_dai_done.Checked = true;
            this.radio_corr_dai_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_corr_dai_done.ForeColor = System.Drawing.Color.White;
            this.radio_corr_dai_done.Name = "radio_corr_dai_done";
            this.radio_corr_dai_done.TabStop = true;
            this.radio_corr_dai_done.Tag = "1";
            this.radio_corr_dai_done.UseVisualStyleBackColor = true;
            // 
            // txt_main_ins7
            // 
            this.txt_main_ins7.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_main_ins7, "txt_main_ins7");
            this.txt_main_ins7.Name = "txt_main_ins7";
            // 
            // flow_labor2
            // 
            this.flow_labor2.AllowDrop = true;
            resources.ApplyResources(this.flow_labor2, "flow_labor2");
            this.flow_labor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flow_labor2.Name = "flow_labor2";
            // 
            // txt_main_ins6
            // 
            this.txt_main_ins6.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_main_ins6, "txt_main_ins6");
            this.txt_main_ins6.Name = "txt_main_ins6";
            this.txt_main_ins6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // pnl_labor2
            // 
            this.pnl_labor2.Controls.Add(this.label80);
            this.pnl_labor2.Controls.Add(this.label81);
            this.pnl_labor2.Controls.Add(this.label83);
            resources.ApplyResources(this.pnl_labor2, "pnl_labor2");
            this.pnl_labor2.Name = "pnl_labor2";
            // 
            // label80
            // 
            resources.ApplyResources(this.label80, "label80");
            this.label80.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label80.Name = "label80";
            // 
            // label81
            // 
            resources.ApplyResources(this.label81, "label81");
            this.label81.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label81.Name = "label81";
            // 
            // label83
            // 
            resources.ApplyResources(this.label83, "label83");
            this.label83.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label83.Name = "label83";
            // 
            // txt_main_ins4
            // 
            this.txt_main_ins4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_main_ins4, "txt_main_ins4");
            this.txt_main_ins4.Name = "txt_main_ins4";
            // 
            // date_main_ins
            // 
            this.date_main_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_main_ins, "date_main_ins");
            this.date_main_ins.Name = "date_main_ins";
            // 
            // label58
            // 
            resources.ApplyResources(this.label58, "label58");
            this.label58.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label58.Name = "label58";
            // 
            // txt_main_ins3
            // 
            this.txt_main_ins3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_main_ins3, "txt_main_ins3");
            this.txt_main_ins3.Name = "txt_main_ins3";
            // 
            // label57
            // 
            resources.ApplyResources(this.label57, "label57");
            this.label57.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label57.Name = "label57";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Name = "label10";
            // 
            // tabb5
            // 
            this.tabb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabb5.Controls.Add(this.tabControl8);
            resources.ApplyResources(this.tabb5, "tabb5");
            this.tabb5.Name = "tabb5";
            // 
            // tabControl8
            // 
            this.tabControl8.Controls.Add(this.tabPage2);
            this.tabControl8.Controls.Add(this.tabPage3);
            this.tabControl8.Controls.Add(this.tabPage4);
            this.tabControl8.Controls.Add(this.tabPage5);
            resources.ApplyResources(this.tabControl8, "tabControl8");
            this.tabControl8.Name = "tabControl8";
            this.tabControl8.SelectedIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.where);
            this.tabPage2.Controls.Add(this.main_iiid);
            this.tabPage2.Controls.Add(this.linkLabel8);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.panel37);
            this.tabPage2.Controls.Add(this.label105);
            this.tabPage2.Controls.Add(this.lb_mod_7);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.txt_oil_upd_main_type);
            this.tabPage2.Controls.Add(this.panel41);
            this.tabPage2.Controls.Add(this.txt_oil_upd_main_alert);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.txt_oil_upd_main_state);
            this.tabPage2.Controls.Add(this.label106);
            this.tabPage2.Controls.Add(this.label134);
            this.tabPage2.Controls.Add(this.txt_oil_upd8);
            this.tabPage2.Controls.Add(this.txt_oil_upd1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_oil_upd2);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // where
            // 
            resources.ApplyResources(this.where, "where");
            this.where.Name = "where";
            // 
            // main_iiid
            // 
            resources.ApplyResources(this.main_iiid, "main_iiid");
            this.main_iiid.Name = "main_iiid";
            // 
            // linkLabel8
            // 
            resources.ApplyResources(this.linkLabel8, "linkLabel8");
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel8.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel8.ForeColor = System.Drawing.Color.Red;
            this.linkLabel8.LinkColor = System.Drawing.Color.Red;
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.TabStop = true;
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.label155);
            this.panel37.Controls.Add(this.comb_oil_del_equ);
            this.panel37.Controls.Add(this.btn_oil_sho);
            this.panel37.Controls.Add(this.pnl_oil_up_del);
            resources.ApplyResources(this.panel37, "panel37");
            this.panel37.Name = "panel37";
            // 
            // label155
            // 
            resources.ApplyResources(this.label155, "label155");
            this.label155.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label155.Name = "label155";
            // 
            // comb_oil_del_equ
            // 
            this.comb_oil_del_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_oil_del_equ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_oil_del_equ, "comb_oil_del_equ");
            this.comb_oil_del_equ.FormattingEnabled = true;
            this.comb_oil_del_equ.Name = "comb_oil_del_equ";
            this.comb_oil_del_equ.SelectedIndexChanged += new System.EventHandler(this.comb_oil_del_equ_SelectedIndexChanged);
            // 
            // btn_oil_sho
            // 
            resources.ApplyResources(this.btn_oil_sho, "btn_oil_sho");
            this.btn_oil_sho.Name = "btn_oil_sho";
            this.btn_oil_sho.UseVisualStyleBackColor = true;
            this.btn_oil_sho.Click += new System.EventHandler(this.btn_oil_sho_Click);
            // 
            // pnl_oil_up_del
            // 
            this.pnl_oil_up_del.Controls.Add(this.panel29);
            this.pnl_oil_up_del.Controls.Add(this.textBox3);
            this.pnl_oil_up_del.Controls.Add(this.label2);
            this.pnl_oil_up_del.Controls.Add(this.btn_oil_del);
            this.pnl_oil_up_del.Controls.Add(this.label13);
            this.pnl_oil_up_del.Controls.Add(this.comb_oil_del);
            this.pnl_oil_up_del.Controls.Add(this.label15);
            this.pnl_oil_up_del.Controls.Add(this.label16);
            this.pnl_oil_up_del.Controls.Add(this.label17);
            this.pnl_oil_up_del.Controls.Add(this.label18);
            this.pnl_oil_up_del.Controls.Add(this.btn_oil_upd);
            this.pnl_oil_up_del.Controls.Add(this.date_oil_upd1);
            this.pnl_oil_up_del.Controls.Add(this.txt_oil_upd6);
            this.pnl_oil_up_del.Controls.Add(this.txt_oil_upd5);
            this.pnl_oil_up_del.Controls.Add(this.txt_oil_upd4);
            resources.ApplyResources(this.pnl_oil_up_del, "pnl_oil_up_del");
            this.pnl_oil_up_del.Name = "pnl_oil_up_del";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.textBox11);
            this.panel29.Controls.Add(this.txt_oil_rep_up3);
            this.panel29.Controls.Add(this.textBox12);
            this.panel29.Controls.Add(this.txt_oil_rep_up2);
            this.panel29.Controls.Add(this.txt_oil_rep_up1);
            this.panel29.Controls.Add(this.txt_oil_rep_up0);
            this.panel29.Controls.Add(this.label194);
            this.panel29.Controls.Add(this.label195);
            this.panel29.Controls.Add(this.label218);
            this.panel29.Controls.Add(this.label222);
            this.panel29.Controls.Add(this.label223);
            this.panel29.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel29, "panel29");
            this.panel29.Name = "panel29";
            // 
            // textBox11
            // 
            this.textBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            this.textBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // txt_oil_rep_up3
            // 
            this.txt_oil_rep_up3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_up3, "txt_oil_rep_up3");
            this.txt_oil_rep_up3.Name = "txt_oil_rep_up3";
            this.txt_oil_rep_up3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // textBox12
            // 
            this.textBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            this.textBox12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // txt_oil_rep_up2
            // 
            this.txt_oil_rep_up2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_up2, "txt_oil_rep_up2");
            this.txt_oil_rep_up2.Name = "txt_oil_rep_up2";
            this.txt_oil_rep_up2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // txt_oil_rep_up1
            // 
            this.txt_oil_rep_up1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_up1, "txt_oil_rep_up1");
            this.txt_oil_rep_up1.Name = "txt_oil_rep_up1";
            this.txt_oil_rep_up1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // txt_oil_rep_up0
            // 
            this.txt_oil_rep_up0.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_up0, "txt_oil_rep_up0");
            this.txt_oil_rep_up0.Name = "txt_oil_rep_up0";
            this.txt_oil_rep_up0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // label194
            // 
            resources.ApplyResources(this.label194, "label194");
            this.label194.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label194.Name = "label194";
            // 
            // label195
            // 
            resources.ApplyResources(this.label195, "label195");
            this.label195.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label195.Name = "label195";
            // 
            // label218
            // 
            resources.ApplyResources(this.label218, "label218");
            this.label218.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label218.Name = "label218";
            // 
            // label222
            // 
            resources.ApplyResources(this.label222, "label222");
            this.label222.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label222.Name = "label222";
            // 
            // label223
            // 
            resources.ApplyResources(this.label223, "label223");
            this.label223.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label223.Name = "label223";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Name = "label2";
            // 
            // btn_oil_del
            // 
            this.btn_oil_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_oil_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oil_del.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_oil_del, "btn_oil_del");
            this.btn_oil_del.ForeColor = System.Drawing.Color.White;
            this.btn_oil_del.Name = "btn_oil_del";
            this.btn_oil_del.UseVisualStyleBackColor = false;
            this.btn_oil_del.Click += new System.EventHandler(this.btn_oil_del_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Name = "label13";
            // 
            // comb_oil_del
            // 
            this.comb_oil_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_oil_del.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_oil_del, "comb_oil_del");
            this.comb_oil_del.FormattingEnabled = true;
            this.comb_oil_del.Name = "comb_oil_del";
            this.comb_oil_del.SelectedIndexChanged += new System.EventHandler(this.comb_oil_del_SelectedIndexChanged);
            this.comb_oil_del.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Name = "label18";
            // 
            // btn_oil_upd
            // 
            this.btn_oil_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_oil_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oil_upd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_oil_upd, "btn_oil_upd");
            this.btn_oil_upd.ForeColor = System.Drawing.Color.White;
            this.btn_oil_upd.Name = "btn_oil_upd";
            this.btn_oil_upd.UseVisualStyleBackColor = false;
            this.btn_oil_upd.Click += new System.EventHandler(this.btn_oil_upd_Click);
            // 
            // date_oil_upd1
            // 
            this.date_oil_upd1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_oil_upd1, "date_oil_upd1");
            this.date_oil_upd1.Name = "date_oil_upd1";
            this.date_oil_upd1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // txt_oil_upd6
            // 
            this.txt_oil_upd6.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_upd6, "txt_oil_upd6");
            this.txt_oil_upd6.Name = "txt_oil_upd6";
            this.txt_oil_upd6.TextChanged += new System.EventHandler(this.txt_oil_upd6_TextChanged);
            this.txt_oil_upd6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            this.txt_oil_upd6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_oil_upd5
            // 
            this.txt_oil_upd5.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_upd5, "txt_oil_upd5");
            this.txt_oil_upd5.Name = "txt_oil_upd5";
            this.txt_oil_upd5.TextChanged += new System.EventHandler(this.txt_oil_upd5_TextChanged);
            this.txt_oil_upd5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            this.txt_oil_upd5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_oil_ins3_KeyPress);
            // 
            // txt_oil_upd4
            // 
            this.txt_oil_upd4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_upd4, "txt_oil_upd4");
            this.txt_oil_upd4.Name = "txt_oil_upd4";
            this.txt_oil_upd4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_del_KeyDown);
            // 
            // label105
            // 
            resources.ApplyResources(this.label105, "label105");
            this.label105.Name = "label105";
            // 
            // lb_mod_7
            // 
            resources.ApplyResources(this.lb_mod_7, "lb_mod_7");
            this.lb_mod_7.Name = "lb_mod_7";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // txt_oil_upd_main_type
            // 
            resources.ApplyResources(this.txt_oil_upd_main_type, "txt_oil_upd_main_type");
            this.txt_oil_upd_main_type.Name = "txt_oil_upd_main_type";
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.label190);
            this.panel41.Controls.Add(this.pnl_oil_ins);
            this.panel41.Controls.Add(this.combo_oil_ins);
            this.panel41.Controls.Add(this.label104);
            this.panel41.Controls.Add(this.pnl_oil);
            resources.ApplyResources(this.panel41, "panel41");
            this.panel41.Name = "panel41";
            // 
            // label190
            // 
            resources.ApplyResources(this.label190, "label190");
            this.label190.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label190.Name = "label190";
            // 
            // pnl_oil_ins
            // 
            this.pnl_oil_ins.Controls.Add(this.panel38);
            this.pnl_oil_ins.Controls.Add(this.textBox7);
            this.pnl_oil_ins.Controls.Add(this.panel43);
            this.pnl_oil_ins.Controls.Add(this.lbl_oil_what);
            this.pnl_oil_ins.Controls.Add(this.textBox4);
            this.pnl_oil_ins.Controls.Add(this.comb_oil_types);
            this.pnl_oil_ins.Controls.Add(this.label191);
            this.pnl_oil_ins.Controls.Add(this.txt_oil_ins2);
            this.pnl_oil_ins.Controls.Add(this.btn_oil_ins);
            this.pnl_oil_ins.Controls.Add(this.txt_oil_ins3);
            this.pnl_oil_ins.Controls.Add(this.txt_oi_state);
            this.pnl_oil_ins.Controls.Add(this.txt_oi_ma_type);
            this.pnl_oil_ins.Controls.Add(this.label1);
            this.pnl_oil_ins.Controls.Add(this.txt_oil_ins4);
            this.pnl_oil_ins.Controls.Add(this.date_oil_ins1);
            this.pnl_oil_ins.Controls.Add(this.label3);
            this.pnl_oil_ins.Controls.Add(this.label4);
            this.pnl_oil_ins.Controls.Add(this.label5);
            this.pnl_oil_ins.Controls.Add(this.label6);
            resources.ApplyResources(this.pnl_oil_ins, "pnl_oil_ins");
            this.pnl_oil_ins.Name = "pnl_oil_ins";
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.textBox14);
            this.panel38.Controls.Add(this.label102);
            this.panel38.Controls.Add(this.comboBox10);
            this.panel38.Controls.Add(this.label101);
            resources.ApplyResources(this.panel38, "panel38");
            this.panel38.Name = "panel38";
            // 
            // textBox14
            // 
            this.textBox14.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            // 
            // label102
            // 
            resources.ApplyResources(this.label102, "label102");
            this.label102.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label102.Name = "label102";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox10, "comboBox10");
            this.comboBox10.Name = "comboBox10";
            // 
            // label101
            // 
            resources.ApplyResources(this.label101, "label101");
            this.label101.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label101.Name = "label101";
            // 
            // textBox7
            // 
            this.textBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.textBox8);
            this.panel43.Controls.Add(this.textBox10);
            this.panel43.Controls.Add(this.txt_oil_rep_ins0);
            this.panel43.Controls.Add(this.label193);
            this.panel43.Controls.Add(this.label221);
            this.panel43.Controls.Add(this.label220);
            this.panel43.Controls.Add(this.label219);
            this.panel43.Controls.Add(this.label132);
            this.panel43.Controls.Add(this.txt_oil_rep_ins3);
            this.panel43.Controls.Add(this.txt_oil_rep_ins2);
            this.panel43.Controls.Add(this.txt_oil_rep_ins1);
            resources.ApplyResources(this.panel43, "panel43");
            this.panel43.Name = "panel43";
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // txt_oil_rep_ins0
            // 
            this.txt_oil_rep_ins0.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_ins0, "txt_oil_rep_ins0");
            this.txt_oil_rep_ins0.Name = "txt_oil_rep_ins0";
            this.txt_oil_rep_ins0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // label193
            // 
            resources.ApplyResources(this.label193, "label193");
            this.label193.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label193.Name = "label193";
            // 
            // label221
            // 
            resources.ApplyResources(this.label221, "label221");
            this.label221.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label221.Name = "label221";
            // 
            // label220
            // 
            resources.ApplyResources(this.label220, "label220");
            this.label220.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label220.Name = "label220";
            // 
            // label219
            // 
            resources.ApplyResources(this.label219, "label219");
            this.label219.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label219.Name = "label219";
            // 
            // label132
            // 
            resources.ApplyResources(this.label132, "label132");
            this.label132.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label132.Name = "label132";
            // 
            // txt_oil_rep_ins3
            // 
            this.txt_oil_rep_ins3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_ins3, "txt_oil_rep_ins3");
            this.txt_oil_rep_ins3.Name = "txt_oil_rep_ins3";
            this.txt_oil_rep_ins3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // txt_oil_rep_ins2
            // 
            this.txt_oil_rep_ins2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_ins2, "txt_oil_rep_ins2");
            this.txt_oil_rep_ins2.Name = "txt_oil_rep_ins2";
            this.txt_oil_rep_ins2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // txt_oil_rep_ins1
            // 
            this.txt_oil_rep_ins1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_rep_ins1, "txt_oil_rep_ins1");
            this.txt_oil_rep_ins1.Name = "txt_oil_rep_ins1";
            this.txt_oil_rep_ins1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // lbl_oil_what
            // 
            resources.ApplyResources(this.lbl_oil_what, "lbl_oil_what");
            this.lbl_oil_what.ForeColor = System.Drawing.Color.White;
            this.lbl_oil_what.Name = "lbl_oil_what";
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // comb_oil_types
            // 
            this.comb_oil_types.BackColor = System.Drawing.SystemColors.Window;
            this.comb_oil_types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_oil_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_oil_types, "comb_oil_types");
            this.comb_oil_types.FormattingEnabled = true;
            this.comb_oil_types.Name = "comb_oil_types";
            this.comb_oil_types.SelectedIndexChanged += new System.EventHandler(this.comb_oil_types_SelectedIndexChanged);
            this.comb_oil_types.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // label191
            // 
            resources.ApplyResources(this.label191, "label191");
            this.label191.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label191.Name = "label191";
            // 
            // txt_oil_ins2
            // 
            this.txt_oil_ins2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_ins2, "txt_oil_ins2");
            this.txt_oil_ins2.Name = "txt_oil_ins2";
            this.txt_oil_ins2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // btn_oil_ins
            // 
            this.btn_oil_ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_oil_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oil_ins.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_oil_ins, "btn_oil_ins");
            this.btn_oil_ins.ForeColor = System.Drawing.Color.White;
            this.btn_oil_ins.Name = "btn_oil_ins";
            this.btn_oil_ins.UseVisualStyleBackColor = false;
            this.btn_oil_ins.Click += new System.EventHandler(this.btn_oil_ins_Click);
            // 
            // txt_oil_ins3
            // 
            this.txt_oil_ins3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_ins3, "txt_oil_ins3");
            this.txt_oil_ins3.Name = "txt_oil_ins3";
            this.txt_oil_ins3.TextChanged += new System.EventHandler(this.txt_oil_ins3_TextChanged);
            this.txt_oil_ins3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            this.txt_oil_ins3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_oil_ins3_KeyPress);
            // 
            // txt_oi_state
            // 
            resources.ApplyResources(this.txt_oi_state, "txt_oi_state");
            this.txt_oi_state.Name = "txt_oi_state";
            // 
            // txt_oi_ma_type
            // 
            resources.ApplyResources(this.txt_oi_ma_type, "txt_oi_ma_type");
            this.txt_oi_ma_type.Name = "txt_oi_ma_type";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Name = "label1";
            // 
            // txt_oil_ins4
            // 
            this.txt_oil_ins4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_oil_ins4, "txt_oil_ins4");
            this.txt_oil_ins4.Name = "txt_oil_ins4";
            this.txt_oil_ins4.TextChanged += new System.EventHandler(this.txt_oil_ins4_TextChanged);
            this.txt_oil_ins4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            this.txt_oil_ins4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // date_oil_ins1
            // 
            this.date_oil_ins1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_oil_ins1, "date_oil_ins1");
            this.date_oil_ins1.Name = "date_oil_ins1";
            this.date_oil_ins1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_oil_types_KeyDown);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Name = "label6";
            // 
            // combo_oil_ins
            // 
            this.combo_oil_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_oil_ins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combo_oil_ins, "combo_oil_ins");
            this.combo_oil_ins.FormattingEnabled = true;
            this.combo_oil_ins.Name = "combo_oil_ins";
            this.combo_oil_ins.SelectedIndexChanged += new System.EventHandler(this.combo_oil_ins_SelectedIndexChanged);
            // 
            // label104
            // 
            resources.ApplyResources(this.label104, "label104");
            this.label104.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label104.Name = "label104";
            // 
            // pnl_oil
            // 
            this.pnl_oil.Controls.Add(this.rdio_oil_cata);
            this.pnl_oil.Controls.Add(this.rdio_oil_add);
            this.pnl_oil.Controls.Add(this.rdio_oil_new);
            resources.ApplyResources(this.pnl_oil, "pnl_oil");
            this.pnl_oil.Name = "pnl_oil";
            // 
            // rdio_oil_cata
            // 
            resources.ApplyResources(this.rdio_oil_cata, "rdio_oil_cata");
            this.rdio_oil_cata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdio_oil_cata.ForeColor = System.Drawing.Color.White;
            this.rdio_oil_cata.Name = "rdio_oil_cata";
            this.rdio_oil_cata.TabStop = true;
            this.rdio_oil_cata.UseVisualStyleBackColor = true;
            this.rdio_oil_cata.CheckedChanged += new System.EventHandler(this.rdio_oil_cata_CheckedChanged);
            // 
            // rdio_oil_add
            // 
            resources.ApplyResources(this.rdio_oil_add, "rdio_oil_add");
            this.rdio_oil_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdio_oil_add.ForeColor = System.Drawing.Color.White;
            this.rdio_oil_add.Name = "rdio_oil_add";
            this.rdio_oil_add.TabStop = true;
            this.rdio_oil_add.UseVisualStyleBackColor = true;
            this.rdio_oil_add.CheckedChanged += new System.EventHandler(this.rdio_oil_add_CheckedChanged);
            // 
            // rdio_oil_new
            // 
            resources.ApplyResources(this.rdio_oil_new, "rdio_oil_new");
            this.rdio_oil_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdio_oil_new.ForeColor = System.Drawing.Color.White;
            this.rdio_oil_new.Name = "rdio_oil_new";
            this.rdio_oil_new.TabStop = true;
            this.rdio_oil_new.UseVisualStyleBackColor = true;
            this.rdio_oil_new.CheckedChanged += new System.EventHandler(this.rdio_oil_add_CheckedChanged);
            // 
            // txt_oil_upd_main_alert
            // 
            resources.ApplyResources(this.txt_oil_upd_main_alert, "txt_oil_upd_main_alert");
            this.txt_oil_upd_main_alert.Name = "txt_oil_upd_main_alert";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Checked = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txt_oil_upd_main_state
            // 
            resources.ApplyResources(this.txt_oil_upd_main_state, "txt_oil_upd_main_state");
            this.txt_oil_upd_main_state.Name = "txt_oil_upd_main_state";
            // 
            // label106
            // 
            resources.ApplyResources(this.label106, "label106");
            this.label106.Name = "label106";
            // 
            // label134
            // 
            resources.ApplyResources(this.label134, "label134");
            this.label134.Name = "label134";
            // 
            // txt_oil_upd8
            // 
            resources.ApplyResources(this.txt_oil_upd8, "txt_oil_upd8");
            this.txt_oil_upd8.Name = "txt_oil_upd8";
            // 
            // txt_oil_upd1
            // 
            resources.ApplyResources(this.txt_oil_upd1, "txt_oil_upd1");
            this.txt_oil_upd1.Name = "txt_oil_upd1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txt_oil_upd2
            // 
            resources.ApplyResources(this.txt_oil_upd2, "txt_oil_upd2");
            this.txt_oil_upd2.Name = "txt_oil_upd2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.linkLabel9);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label52);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(this.label55);
            this.tabPage3.Controls.Add(this.txt_fuel_upd1);
            this.tabPage3.Controls.Add(this.txt_fuel_ins2);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.txt_fuel_ins5);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.txt_fuel_upd8);
            this.tabPage3.Controls.Add(this.pnl_fue_edi);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.pnl_fue_ins);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.txt_fuel_upd2);
            this.tabPage3.Controls.Add(this.txt_fuel_upd4);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // linkLabel9
            // 
            resources.ApplyResources(this.linkLabel9, "linkLabel9");
            this.linkLabel9.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel9.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel9.ForeColor = System.Drawing.Color.Red;
            this.linkLabel9.LinkColor = System.Drawing.Color.Red;
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.TabStop = true;
            this.linkLabel9.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox7.ForeColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.Name = "label52";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label55
            // 
            resources.ApplyResources(this.label55, "label55");
            this.label55.Name = "label55";
            // 
            // txt_fuel_upd1
            // 
            resources.ApplyResources(this.txt_fuel_upd1, "txt_fuel_upd1");
            this.txt_fuel_upd1.Name = "txt_fuel_upd1";
            // 
            // txt_fuel_ins2
            // 
            resources.ApplyResources(this.txt_fuel_ins2, "txt_fuel_ins2");
            this.txt_fuel_ins2.Name = "txt_fuel_ins2";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // txt_fuel_ins5
            // 
            resources.ApplyResources(this.txt_fuel_ins5, "txt_fuel_ins5");
            this.txt_fuel_ins5.Name = "txt_fuel_ins5";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Checked = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_fuel_upd8
            // 
            resources.ApplyResources(this.txt_fuel_upd8, "txt_fuel_upd8");
            this.txt_fuel_upd8.Name = "txt_fuel_upd8";
            // 
            // pnl_fue_edi
            // 
            this.pnl_fue_edi.Controls.Add(this.pnl_filer_fuel_del);
            this.pnl_fue_edi.Controls.Add(this.btn_fuel_sho);
            this.pnl_fue_edi.Controls.Add(this.label173);
            this.pnl_fue_edi.Controls.Add(this.comb_fuel_del_equ);
            resources.ApplyResources(this.pnl_fue_edi, "pnl_fue_edi");
            this.pnl_fue_edi.Name = "pnl_fue_edi";
            // 
            // pnl_filer_fuel_del
            // 
            this.pnl_filer_fuel_del.Controls.Add(this.textBox6);
            this.pnl_filer_fuel_del.Controls.Add(this.label197);
            this.pnl_filer_fuel_del.Controls.Add(this.label34);
            this.pnl_filer_fuel_del.Controls.Add(this.label31);
            this.pnl_filer_fuel_del.Controls.Add(this.label33);
            this.pnl_filer_fuel_del.Controls.Add(this.label36);
            this.pnl_filer_fuel_del.Controls.Add(this.btn_fuel_upd);
            this.pnl_filer_fuel_del.Controls.Add(this.date_fuel_upd);
            this.pnl_filer_fuel_del.Controls.Add(this.txt_fuel_upd6);
            this.pnl_filer_fuel_del.Controls.Add(this.txt_fuel_upd5);
            this.pnl_filer_fuel_del.Controls.Add(this.btn_fuel_del);
            this.pnl_filer_fuel_del.Controls.Add(this.comb_fuel_del);
            resources.ApplyResources(this.pnl_filer_fuel_del, "pnl_filer_fuel_del");
            this.pnl_filer_fuel_del.Name = "pnl_filer_fuel_del";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.TextChanged += new System.EventHandler(this.txt_fuel_upd5_TextChanged);
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_fuel_del_KeyDown);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_oil_ins3_KeyPress);
            // 
            // label197
            // 
            resources.ApplyResources(this.label197, "label197");
            this.label197.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label197.Name = "label197";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label34.Name = "label34";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label31.Name = "label31";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label33.Name = "label33";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label36.Name = "label36";
            // 
            // btn_fuel_upd
            // 
            this.btn_fuel_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fuel_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fuel_upd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_fuel_upd, "btn_fuel_upd");
            this.btn_fuel_upd.ForeColor = System.Drawing.Color.White;
            this.btn_fuel_upd.Name = "btn_fuel_upd";
            this.btn_fuel_upd.UseVisualStyleBackColor = false;
            this.btn_fuel_upd.Click += new System.EventHandler(this.btn_fuel_upd_Click);
            // 
            // date_fuel_upd
            // 
            this.date_fuel_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_fuel_upd, "date_fuel_upd");
            this.date_fuel_upd.Name = "date_fuel_upd";
            this.date_fuel_upd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_fuel_del_KeyDown);
            // 
            // txt_fuel_upd6
            // 
            this.txt_fuel_upd6.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fuel_upd6, "txt_fuel_upd6");
            this.txt_fuel_upd6.Name = "txt_fuel_upd6";
            this.txt_fuel_upd6.TextChanged += new System.EventHandler(this.txt_fuel_upd6_TextChanged);
            this.txt_fuel_upd6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_fuel_del_KeyDown);
            this.txt_fuel_upd6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_fuel_upd5
            // 
            this.txt_fuel_upd5.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fuel_upd5, "txt_fuel_upd5");
            this.txt_fuel_upd5.Name = "txt_fuel_upd5";
            this.txt_fuel_upd5.TextChanged += new System.EventHandler(this.txt_fuel_upd5_TextChanged);
            this.txt_fuel_upd5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_fuel_del_KeyDown);
            this.txt_fuel_upd5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // btn_fuel_del
            // 
            this.btn_fuel_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fuel_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fuel_del.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_fuel_del, "btn_fuel_del");
            this.btn_fuel_del.ForeColor = System.Drawing.Color.White;
            this.btn_fuel_del.Name = "btn_fuel_del";
            this.btn_fuel_del.UseVisualStyleBackColor = false;
            this.btn_fuel_del.Click += new System.EventHandler(this.btn_fuel_del_Click);
            // 
            // comb_fuel_del
            // 
            this.comb_fuel_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_fuel_del.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_fuel_del, "comb_fuel_del");
            this.comb_fuel_del.FormattingEnabled = true;
            this.comb_fuel_del.Name = "comb_fuel_del";
            this.comb_fuel_del.SelectedIndexChanged += new System.EventHandler(this.comb_fuel_del_SelectedIndexChanged);
            this.comb_fuel_del.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_fuel_del_KeyDown);
            // 
            // btn_fuel_sho
            // 
            this.btn_fuel_sho.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_fuel_sho, "btn_fuel_sho");
            this.btn_fuel_sho.Name = "btn_fuel_sho";
            this.btn_fuel_sho.UseVisualStyleBackColor = true;
            this.btn_fuel_sho.Click += new System.EventHandler(this.btn_fuel_sho_Click);
            // 
            // label173
            // 
            resources.ApplyResources(this.label173, "label173");
            this.label173.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label173.Name = "label173";
            // 
            // comb_fuel_del_equ
            // 
            this.comb_fuel_del_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_fuel_del_equ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_fuel_del_equ, "comb_fuel_del_equ");
            this.comb_fuel_del_equ.FormattingEnabled = true;
            this.comb_fuel_del_equ.Name = "comb_fuel_del_equ";
            this.comb_fuel_del_equ.SelectedIndexChanged += new System.EventHandler(this.comb_fuel_del_equ_SelectedIndexChanged);
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // pnl_fue_ins
            // 
            this.pnl_fue_ins.Controls.Add(this.label196);
            this.pnl_fue_ins.Controls.Add(this.panel21);
            this.pnl_fue_ins.Controls.Add(this.panel49);
            this.pnl_fue_ins.Controls.Add(this.label169);
            this.pnl_fue_ins.Controls.Add(this.comb_fuel_ins_equ);
            resources.ApplyResources(this.pnl_fue_ins, "pnl_fue_ins");
            this.pnl_fue_ins.Name = "pnl_fue_ins";
            // 
            // label196
            // 
            resources.ApplyResources(this.label196, "label196");
            this.label196.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label196.Name = "label196";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.radioButton11);
            this.panel21.Controls.Add(this.radioButton12);
            resources.ApplyResources(this.panel21, "panel21");
            this.panel21.Name = "panel21";
            // 
            // radioButton11
            // 
            resources.ApplyResources(this.radioButton11, "radioButton11");
            this.radioButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton11.ForeColor = System.Drawing.Color.White;
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.TabStop = true;
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            resources.ApplyResources(this.radioButton12, "radioButton12");
            this.radioButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton12.ForeColor = System.Drawing.Color.White;
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.panel45);
            this.panel49.Controls.Add(this.comboBox3);
            this.panel49.Controls.Add(this.textBox5);
            this.panel49.Controls.Add(this.label187);
            this.panel49.Controls.Add(this.label56);
            this.panel49.Controls.Add(this.label51);
            this.panel49.Controls.Add(this.txt_fuel_ins1);
            this.panel49.Controls.Add(this.date_fuel_ins);
            this.panel49.Controls.Add(this.txt_fuel_ins4);
            this.panel49.Controls.Add(this.label53);
            this.panel49.Controls.Add(this.txt_fuel_ins3);
            this.panel49.Controls.Add(this.label54);
            this.panel49.Controls.Add(this.btn_fuel_ins);
            resources.ApplyResources(this.panel49, "panel49");
            this.panel49.Name = "panel49";
            // 
            // panel45
            // 
            this.panel45.Controls.Add(this.textBox16);
            this.panel45.Controls.Add(this.label157);
            this.panel45.Controls.Add(this.comboBox11);
            this.panel45.Controls.Add(this.label241);
            resources.ApplyResources(this.panel45, "panel45");
            this.panel45.Name = "panel45";
            // 
            // textBox16
            // 
            this.textBox16.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            // 
            // label157
            // 
            resources.ApplyResources(this.label157, "label157");
            this.label157.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label157.Name = "label157";
            // 
            // comboBox11
            // 
            resources.ApplyResources(this.comboBox11, "comboBox11");
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Name = "comboBox11";
            // 
            // label241
            // 
            resources.ApplyResources(this.label241, "label241");
            this.label241.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label241.Name = "label241";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fuel_ins1_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.TextChanged += new System.EventHandler(this.txt_fuel_ins3_TextChanged);
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fuel_ins1_KeyDown);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_oil_ins3_KeyPress);
            // 
            // label187
            // 
            resources.ApplyResources(this.label187, "label187");
            this.label187.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label187.Name = "label187";
            // 
            // label56
            // 
            resources.ApplyResources(this.label56, "label56");
            this.label56.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label56.Name = "label56";
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label51.Name = "label51";
            // 
            // txt_fuel_ins1
            // 
            this.txt_fuel_ins1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fuel_ins1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fuel_ins1, "txt_fuel_ins1");
            this.txt_fuel_ins1.Name = "txt_fuel_ins1";
            this.txt_fuel_ins1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fuel_ins1_KeyDown);
            // 
            // date_fuel_ins
            // 
            this.date_fuel_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.date_fuel_ins, "date_fuel_ins");
            this.date_fuel_ins.Name = "date_fuel_ins";
            this.date_fuel_ins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fuel_ins1_KeyDown);
            // 
            // txt_fuel_ins4
            // 
            this.txt_fuel_ins4.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fuel_ins4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fuel_ins4, "txt_fuel_ins4");
            this.txt_fuel_ins4.Name = "txt_fuel_ins4";
            this.txt_fuel_ins4.TextChanged += new System.EventHandler(this.txt_fuel_ins4_TextChanged);
            this.txt_fuel_ins4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fuel_ins1_KeyDown);
            this.txt_fuel_ins4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label53.Name = "label53";
            // 
            // txt_fuel_ins3
            // 
            this.txt_fuel_ins3.BackColor = System.Drawing.SystemColors.Window;
            this.txt_fuel_ins3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fuel_ins3, "txt_fuel_ins3");
            this.txt_fuel_ins3.Name = "txt_fuel_ins3";
            this.txt_fuel_ins3.TextChanged += new System.EventHandler(this.txt_fuel_ins3_TextChanged);
            this.txt_fuel_ins3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fuel_ins1_KeyDown);
            this.txt_fuel_ins3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label54.Name = "label54";
            // 
            // btn_fuel_ins
            // 
            this.btn_fuel_ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fuel_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fuel_ins.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_fuel_ins, "btn_fuel_ins");
            this.btn_fuel_ins.ForeColor = System.Drawing.Color.White;
            this.btn_fuel_ins.Name = "btn_fuel_ins";
            this.btn_fuel_ins.UseVisualStyleBackColor = false;
            this.btn_fuel_ins.Click += new System.EventHandler(this.btn_fuel_ins_Click);
            // 
            // label169
            // 
            resources.ApplyResources(this.label169, "label169");
            this.label169.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label169.Name = "label169";
            // 
            // comb_fuel_ins_equ
            // 
            this.comb_fuel_ins_equ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comb_fuel_ins_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_fuel_ins_equ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_fuel_ins_equ, "comb_fuel_ins_equ");
            this.comb_fuel_ins_equ.FormattingEnabled = true;
            this.comb_fuel_ins_equ.Name = "comb_fuel_ins_equ";
            this.comb_fuel_ins_equ.SelectedIndexChanged += new System.EventHandler(this.comb_fuel_ins_equ_SelectedIndexChanged);
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // txt_fuel_upd2
            // 
            resources.ApplyResources(this.txt_fuel_upd2, "txt_fuel_upd2");
            this.txt_fuel_upd2.Name = "txt_fuel_upd2";
            // 
            // txt_fuel_upd4
            // 
            resources.ApplyResources(this.txt_fuel_upd4, "txt_fuel_upd4");
            this.txt_fuel_upd4.Name = "txt_fuel_upd4";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage4.Controls.Add(this.linkLabel10);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.pnl_tech_ins);
            this.tabPage4.Controls.Add(this.radioButton5);
            this.tabPage4.Controls.Add(this.radioButton6);
            this.tabPage4.Controls.Add(this.pnl_tech_ed);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // linkLabel10
            // 
            resources.ApplyResources(this.linkLabel10, "linkLabel10");
            this.linkLabel10.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel10.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel10.ForeColor = System.Drawing.Color.Red;
            this.linkLabel10.LinkColor = System.Drawing.Color.Red;
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.TabStop = true;
            this.linkLabel10.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // pnl_tech_ins
            // 
            this.pnl_tech_ins.Controls.Add(this.panel33);
            resources.ApplyResources(this.pnl_tech_ins, "pnl_tech_ins");
            this.pnl_tech_ins.Name = "pnl_tech_ins";
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.btn_labor_ins);
            this.panel33.Controls.Add(this.label71);
            this.panel33.Controls.Add(this.label70);
            this.panel33.Controls.Add(this.txt_wrk_hrs_ins);
            this.panel33.Controls.Add(this.txt_salary);
            this.panel33.Controls.Add(this.label73);
            this.panel33.Controls.Add(this.txt_wrker_name);
            resources.ApplyResources(this.panel33, "panel33");
            this.panel33.Name = "panel33";
            // 
            // btn_labor_ins
            // 
            this.btn_labor_ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_labor_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_labor_ins.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_labor_ins, "btn_labor_ins");
            this.btn_labor_ins.ForeColor = System.Drawing.Color.White;
            this.btn_labor_ins.Name = "btn_labor_ins";
            this.btn_labor_ins.UseVisualStyleBackColor = false;
            this.btn_labor_ins.Click += new System.EventHandler(this.btn_labor_ins_Click);
            // 
            // label71
            // 
            resources.ApplyResources(this.label71, "label71");
            this.label71.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label71.Name = "label71";
            // 
            // label70
            // 
            resources.ApplyResources(this.label70, "label70");
            this.label70.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label70.Name = "label70";
            // 
            // txt_wrk_hrs_ins
            // 
            this.txt_wrk_hrs_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.txt_wrk_hrs_ins, "txt_wrk_hrs_ins");
            this.txt_wrk_hrs_ins.Name = "txt_wrk_hrs_ins";
            this.txt_wrk_hrs_ins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_wrker_name_KeyDown);
            this.txt_wrk_hrs_ins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_salary
            // 
            this.txt_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.txt_salary, "txt_salary");
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_wrker_name_KeyDown);
            this.txt_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // label73
            // 
            resources.ApplyResources(this.label73, "label73");
            this.label73.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label73.Name = "label73";
            // 
            // txt_wrker_name
            // 
            this.txt_wrker_name.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.txt_wrker_name, "txt_wrker_name");
            this.txt_wrker_name.Name = "txt_wrker_name";
            this.txt_wrker_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_wrker_name_KeyDown);
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            resources.ApplyResources(this.radioButton6, "radioButton6");
            this.radioButton6.Checked = true;
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // pnl_tech_ed
            // 
            this.pnl_tech_ed.Controls.Add(this.label74);
            this.pnl_tech_ed.Controls.Add(this.combo_laboe_upd);
            this.pnl_tech_ed.Controls.Add(this.panel46);
            this.pnl_tech_ed.Controls.Add(this.label38);
            resources.ApplyResources(this.pnl_tech_ed, "pnl_tech_ed");
            this.pnl_tech_ed.Name = "pnl_tech_ed";
            // 
            // label74
            // 
            resources.ApplyResources(this.label74, "label74");
            this.label74.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label74.Name = "label74";
            // 
            // combo_laboe_upd
            // 
            this.combo_laboe_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_laboe_upd.DataSource = this.workerBindingSource;
            this.combo_laboe_upd.DisplayMember = "worker_name";
            this.combo_laboe_upd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combo_laboe_upd, "combo_laboe_upd");
            this.combo_laboe_upd.FormattingEnabled = true;
            this.combo_laboe_upd.Name = "combo_laboe_upd";
            this.combo_laboe_upd.ValueMember = "worker_id";
            this.combo_laboe_upd.SelectedIndexChanged += new System.EventHandler(this.combo_laboe_upd_SelectedIndexChanged);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "worker";
            this.workerBindingSource.DataSource = this.hopeDataSetBindingSource;
            // 
            // panel46
            // 
            this.panel46.Controls.Add(this.label85);
            this.panel46.Controls.Add(this.label143);
            this.panel46.Controls.Add(this.label148);
            this.panel46.Controls.Add(this.btn_labor_del);
            this.panel46.Controls.Add(this.btn_labor_upd);
            this.panel46.Controls.Add(this.txt_lp_up_name);
            this.panel46.Controls.Add(this.txt_lp_up_hours);
            this.panel46.Controls.Add(this.txt_lp_up_salary);
            resources.ApplyResources(this.panel46, "panel46");
            this.panel46.Name = "panel46";
            // 
            // label85
            // 
            resources.ApplyResources(this.label85, "label85");
            this.label85.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label85.Name = "label85";
            // 
            // label143
            // 
            resources.ApplyResources(this.label143, "label143");
            this.label143.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label143.Name = "label143";
            // 
            // label148
            // 
            resources.ApplyResources(this.label148, "label148");
            this.label148.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label148.Name = "label148";
            // 
            // btn_labor_del
            // 
            this.btn_labor_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_labor_del.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_labor_del, "btn_labor_del");
            this.btn_labor_del.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_labor_del.ForeColor = System.Drawing.Color.White;
            this.btn_labor_del.Name = "btn_labor_del";
            this.btn_labor_del.UseVisualStyleBackColor = false;
            this.btn_labor_del.Click += new System.EventHandler(this.btn_labor_del_Click);
            // 
            // btn_labor_upd
            // 
            this.btn_labor_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_labor_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_labor_upd, "btn_labor_upd");
            this.btn_labor_upd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_labor_upd.ForeColor = System.Drawing.Color.White;
            this.btn_labor_upd.Name = "btn_labor_upd";
            this.btn_labor_upd.UseVisualStyleBackColor = false;
            this.btn_labor_upd.Click += new System.EventHandler(this.btn_labor_upd_Click);
            // 
            // txt_lp_up_name
            // 
            this.txt_lp_up_name.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.txt_lp_up_name, "txt_lp_up_name");
            this.txt_lp_up_name.Name = "txt_lp_up_name";
            this.txt_lp_up_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_lp_up_name_KeyDown);
            // 
            // txt_lp_up_hours
            // 
            this.txt_lp_up_hours.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.txt_lp_up_hours, "txt_lp_up_hours");
            this.txt_lp_up_hours.Name = "txt_lp_up_hours";
            this.txt_lp_up_hours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_lp_up_name_KeyDown);
            this.txt_lp_up_hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_lp_up_salary
            // 
            this.txt_lp_up_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.txt_lp_up_salary, "txt_lp_up_salary");
            this.txt_lp_up_salary.Name = "txt_lp_up_salary";
            this.txt_lp_up_salary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_lp_up_name_KeyDown);
            this.txt_lp_up_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage5.Controls.Add(this.linkLabel11);
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.pnl_filt_ed);
            this.tabPage5.Controls.Add(this.pnl_filt_ins);
            this.tabPage5.Controls.Add(this.radioButton7);
            this.tabPage5.Controls.Add(this.radioButton8);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.txt_filt_upd1);
            this.tabPage5.Controls.Add(this.txt_filt_upd8);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            // 
            // linkLabel11
            // 
            resources.ApplyResources(this.linkLabel11, "linkLabel11");
            this.linkLabel11.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel11.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel11.ForeColor = System.Drawing.Color.Red;
            this.linkLabel11.LinkColor = System.Drawing.Color.Red;
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.TabStop = true;
            this.linkLabel11.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // pnl_filt_ed
            // 
            this.pnl_filt_ed.Controls.Add(this.label188);
            this.pnl_filt_ed.Controls.Add(this.label45);
            this.pnl_filt_ed.Controls.Add(this.panel44);
            this.pnl_filt_ed.Controls.Add(this.btn_flt_sho);
            this.pnl_filt_ed.Controls.Add(this.textBox9);
            this.pnl_filt_ed.Controls.Add(this.comb_flt_del_equ);
            this.pnl_filt_ed.Controls.Add(this.txt_filt_upd2);
            this.pnl_filt_ed.Controls.Add(this.label22);
            resources.ApplyResources(this.pnl_filt_ed, "pnl_filt_ed");
            this.pnl_filt_ed.Name = "pnl_filt_ed";
            // 
            // label188
            // 
            resources.ApplyResources(this.label188, "label188");
            this.label188.Name = "label188";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label45.Name = "label45";
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.panel25);
            this.panel44.Controls.Add(this.lbl_what_filter);
            this.panel44.Controls.Add(this.comb_flt_del);
            this.panel44.Controls.Add(this.btn_del_filt);
            this.panel44.Controls.Add(this.label124);
            this.panel44.Controls.Add(this.btn_flt_upd);
            this.panel44.Controls.Add(this.label154);
            this.panel44.Controls.Add(this.label164);
            this.panel44.Controls.Add(this.label174);
            this.panel44.Controls.Add(this.label184);
            this.panel44.Controls.Add(this.dat_filt_upd1);
            this.panel44.Controls.Add(this.txt_filt_upd6);
            this.panel44.Controls.Add(this.txt_filt_upd5);
            this.panel44.Controls.Add(this.txt_filt_upd4);
            resources.ApplyResources(this.panel44, "panel44");
            this.panel44.Name = "panel44";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.label224);
            this.panel25.Controls.Add(this.txt_fil_rep_up0);
            this.panel25.Controls.Add(this.txt_fil_rep_up3);
            this.panel25.Controls.Add(this.label115);
            this.panel25.Controls.Add(this.txt_fil_rep_up2);
            this.panel25.Controls.Add(this.txt_fil_rep_up1);
            resources.ApplyResources(this.panel25, "panel25");
            this.panel25.Name = "panel25";
            // 
            // label224
            // 
            resources.ApplyResources(this.label224, "label224");
            this.label224.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label224.Name = "label224";
            // 
            // txt_fil_rep_up0
            // 
            this.txt_fil_rep_up0.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep_up0, "txt_fil_rep_up0");
            this.txt_fil_rep_up0.Name = "txt_fil_rep_up0";
            this.txt_fil_rep_up0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            // 
            // txt_fil_rep_up3
            // 
            this.txt_fil_rep_up3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep_up3, "txt_fil_rep_up3");
            this.txt_fil_rep_up3.Name = "txt_fil_rep_up3";
            this.txt_fil_rep_up3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            // 
            // label115
            // 
            resources.ApplyResources(this.label115, "label115");
            this.label115.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label115.Name = "label115";
            // 
            // txt_fil_rep_up2
            // 
            this.txt_fil_rep_up2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep_up2, "txt_fil_rep_up2");
            this.txt_fil_rep_up2.Name = "txt_fil_rep_up2";
            this.txt_fil_rep_up2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            // 
            // txt_fil_rep_up1
            // 
            this.txt_fil_rep_up1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep_up1, "txt_fil_rep_up1");
            this.txt_fil_rep_up1.Name = "txt_fil_rep_up1";
            this.txt_fil_rep_up1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            // 
            // lbl_what_filter
            // 
            resources.ApplyResources(this.lbl_what_filter, "lbl_what_filter");
            this.lbl_what_filter.ForeColor = System.Drawing.Color.Green;
            this.lbl_what_filter.Name = "lbl_what_filter";
            // 
            // comb_flt_del
            // 
            this.comb_flt_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_flt_del.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_flt_del, "comb_flt_del");
            this.comb_flt_del.FormattingEnabled = true;
            this.comb_flt_del.Name = "comb_flt_del";
            this.comb_flt_del.SelectedIndexChanged += new System.EventHandler(this.comb_flt_del_SelectedIndexChanged);
            this.comb_flt_del.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            // 
            // btn_del_filt
            // 
            this.btn_del_filt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_del_filt.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_del_filt, "btn_del_filt");
            this.btn_del_filt.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_del_filt.ForeColor = System.Drawing.Color.White;
            this.btn_del_filt.Name = "btn_del_filt";
            this.btn_del_filt.UseVisualStyleBackColor = false;
            this.btn_del_filt.Click += new System.EventHandler(this.btn_del_filt_Click);
            // 
            // label124
            // 
            resources.ApplyResources(this.label124, "label124");
            this.label124.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label124.Name = "label124";
            // 
            // btn_flt_upd
            // 
            this.btn_flt_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_flt_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_flt_upd, "btn_flt_upd");
            this.btn_flt_upd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_flt_upd.ForeColor = System.Drawing.Color.White;
            this.btn_flt_upd.Name = "btn_flt_upd";
            this.btn_flt_upd.UseVisualStyleBackColor = false;
            this.btn_flt_upd.Click += new System.EventHandler(this.btn_flt_upd_Click);
            // 
            // label154
            // 
            resources.ApplyResources(this.label154, "label154");
            this.label154.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label154.Name = "label154";
            // 
            // label164
            // 
            resources.ApplyResources(this.label164, "label164");
            this.label164.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label164.Name = "label164";
            // 
            // label174
            // 
            resources.ApplyResources(this.label174, "label174");
            this.label174.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label174.Name = "label174";
            // 
            // label184
            // 
            resources.ApplyResources(this.label184, "label184");
            this.label184.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label184.Name = "label184";
            // 
            // dat_filt_upd1
            // 
            this.dat_filt_upd1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dat_filt_upd1, "dat_filt_upd1");
            this.dat_filt_upd1.Name = "dat_filt_upd1";
            this.dat_filt_upd1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            // 
            // txt_filt_upd6
            // 
            this.txt_filt_upd6.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_filt_upd6, "txt_filt_upd6");
            this.txt_filt_upd6.Name = "txt_filt_upd6";
            this.txt_filt_upd6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            this.txt_filt_upd6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_filt_upd5
            // 
            this.txt_filt_upd5.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_filt_upd5, "txt_filt_upd5");
            this.txt_filt_upd5.Name = "txt_filt_upd5";
            this.txt_filt_upd5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            this.txt_filt_upd5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txt_filt_upd4
            // 
            this.txt_filt_upd4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_filt_upd4, "txt_filt_upd4");
            this.txt_filt_upd4.Name = "txt_filt_upd4";
            this.txt_filt_upd4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_flt_del_KeyDown);
            // 
            // btn_flt_sho
            // 
            resources.ApplyResources(this.btn_flt_sho, "btn_flt_sho");
            this.btn_flt_sho.Name = "btn_flt_sho";
            this.btn_flt_sho.UseVisualStyleBackColor = true;
            this.btn_flt_sho.Click += new System.EventHandler(this.btn_flt_sho_Click);
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            // 
            // comb_flt_del_equ
            // 
            this.comb_flt_del_equ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comb_flt_del_equ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comb_flt_del_equ, "comb_flt_del_equ");
            this.comb_flt_del_equ.FormattingEnabled = true;
            this.comb_flt_del_equ.Name = "comb_flt_del_equ";
            this.comb_flt_del_equ.SelectedIndexChanged += new System.EventHandler(this.comb_flt_del_equ_SelectedIndexChanged);
            // 
            // txt_filt_upd2
            // 
            resources.ApplyResources(this.txt_filt_upd2, "txt_filt_upd2");
            this.txt_filt_upd2.Name = "txt_filt_upd2";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // pnl_filt_ins
            // 
            this.pnl_filt_ins.Controls.Add(this.label75);
            this.pnl_filt_ins.Controls.Add(this.label46);
            this.pnl_filt_ins.Controls.Add(this.panel42);
            this.pnl_filt_ins.Controls.Add(this.combo_filter_equ_ins);
            this.pnl_filt_ins.Controls.Add(this.txtfilter5);
            resources.ApplyResources(this.pnl_filt_ins, "pnl_filt_ins");
            this.pnl_filt_ins.Name = "pnl_filt_ins";
            // 
            // label75
            // 
            resources.ApplyResources(this.label75, "label75");
            this.label75.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label75.Name = "label75";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.rdio_filt_new);
            this.panel42.Controls.Add(this.rdio_filt_change);
            this.panel42.Controls.Add(this.panel23);
            this.panel42.Controls.Add(this.label146);
            this.panel42.Controls.Add(this.combo_change_filter);
            this.panel42.Controls.Add(this.btn_ins_filt);
            this.panel42.Controls.Add(this.txtfilter2);
            this.panel42.Controls.Add(this.txtfilter3);
            this.panel42.Controls.Add(this.txtfilter4);
            this.panel42.Controls.Add(this.label47);
            this.panel42.Controls.Add(this.datefilter1);
            this.panel42.Controls.Add(this.label48);
            this.panel42.Controls.Add(this.txtfilter1);
            this.panel42.Controls.Add(this.label49);
            this.panel42.Controls.Add(this.label150);
            this.panel42.Controls.Add(this.label50);
            this.panel42.Controls.Add(this.panel50);
            resources.ApplyResources(this.panel42, "panel42");
            this.panel42.Name = "panel42";
            // 
            // rdio_filt_new
            // 
            resources.ApplyResources(this.rdio_filt_new, "rdio_filt_new");
            this.rdio_filt_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdio_filt_new.ForeColor = System.Drawing.Color.White;
            this.rdio_filt_new.Name = "rdio_filt_new";
            this.rdio_filt_new.TabStop = true;
            this.rdio_filt_new.UseVisualStyleBackColor = true;
            this.rdio_filt_new.CheckedChanged += new System.EventHandler(this.rdio_filt_new_CheckedChanged);
            // 
            // rdio_filt_change
            // 
            resources.ApplyResources(this.rdio_filt_change, "rdio_filt_change");
            this.rdio_filt_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdio_filt_change.ForeColor = System.Drawing.Color.White;
            this.rdio_filt_change.Name = "rdio_filt_change";
            this.rdio_filt_change.TabStop = true;
            this.rdio_filt_change.UseVisualStyleBackColor = true;
            this.rdio_filt_change.CheckedChanged += new System.EventHandler(this.rdio_filt_change_CheckedChanged);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label133);
            this.panel23.Controls.Add(this.txt_fil_rep0);
            this.panel23.Controls.Add(this.label103);
            this.panel23.Controls.Add(this.txt_fil_rep3);
            this.panel23.Controls.Add(this.txt_fil_rep2);
            this.panel23.Controls.Add(this.txt_fil_rep1);
            resources.ApplyResources(this.panel23, "panel23");
            this.panel23.Name = "panel23";
            // 
            // label133
            // 
            resources.ApplyResources(this.label133, "label133");
            this.label133.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label133.Name = "label133";
            // 
            // txt_fil_rep0
            // 
            this.txt_fil_rep0.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep0, "txt_fil_rep0");
            this.txt_fil_rep0.Name = "txt_fil_rep0";
            this.txt_fil_rep0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            // 
            // label103
            // 
            resources.ApplyResources(this.label103, "label103");
            this.label103.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label103.Name = "label103";
            // 
            // txt_fil_rep3
            // 
            this.txt_fil_rep3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep3, "txt_fil_rep3");
            this.txt_fil_rep3.Name = "txt_fil_rep3";
            this.txt_fil_rep3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            // 
            // txt_fil_rep2
            // 
            this.txt_fil_rep2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep2, "txt_fil_rep2");
            this.txt_fil_rep2.Name = "txt_fil_rep2";
            this.txt_fil_rep2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            // 
            // txt_fil_rep1
            // 
            this.txt_fil_rep1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txt_fil_rep1, "txt_fil_rep1");
            this.txt_fil_rep1.Name = "txt_fil_rep1";
            this.txt_fil_rep1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            // 
            // label146
            // 
            resources.ApplyResources(this.label146, "label146");
            this.label146.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label146.Name = "label146";
            // 
            // combo_change_filter
            // 
            this.combo_change_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_change_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combo_change_filter, "combo_change_filter");
            this.combo_change_filter.FormattingEnabled = true;
            this.combo_change_filter.Name = "combo_change_filter";
            this.combo_change_filter.SelectedIndexChanged += new System.EventHandler(this.combo_change_filter_SelectedIndexChanged);
            this.combo_change_filter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            // 
            // btn_ins_filt
            // 
            this.btn_ins_filt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ins_filt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ins_filt.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.btn_ins_filt, "btn_ins_filt");
            this.btn_ins_filt.ForeColor = System.Drawing.Color.White;
            this.btn_ins_filt.Name = "btn_ins_filt";
            this.btn_ins_filt.UseVisualStyleBackColor = false;
            this.btn_ins_filt.Click += new System.EventHandler(this.btn_ins_filt_Click);
            // 
            // txtfilter2
            // 
            this.txtfilter2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtfilter2, "txtfilter2");
            this.txtfilter2.Name = "txtfilter2";
            this.txtfilter2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            // 
            // txtfilter3
            // 
            this.txtfilter3.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtfilter3, "txtfilter3");
            this.txtfilter3.Name = "txtfilter3";
            this.txtfilter3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            this.txtfilter3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // txtfilter4
            // 
            this.txtfilter4.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtfilter4, "txtfilter4");
            this.txtfilter4.Name = "txtfilter4";
            this.txtfilter4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            this.txtfilter4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label47.Name = "label47";
            // 
            // datefilter1
            // 
            this.datefilter1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.datefilter1, "datefilter1");
            this.datefilter1.Name = "datefilter1";
            this.datefilter1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfilter1_KeyDown);
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label48.Name = "label48";
            // 
            // txtfilter1
            // 
            this.txtfilter1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtfilter1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtfilter1, "txtfilter1");
            this.txtfilter1.Name = "txtfilter1";
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label49.Name = "label49";
            // 
            // label150
            // 
            resources.ApplyResources(this.label150, "label150");
            this.label150.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label150.Name = "label150";
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label50.Name = "label50";
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.textBox17);
            this.panel50.Controls.Add(this.label242);
            this.panel50.Controls.Add(this.comboBox12);
            this.panel50.Controls.Add(this.label243);
            resources.ApplyResources(this.panel50, "panel50");
            this.panel50.Name = "panel50";
            // 
            // textBox17
            // 
            this.textBox17.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            // 
            // label242
            // 
            resources.ApplyResources(this.label242, "label242");
            this.label242.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label242.Name = "label242";
            // 
            // comboBox12
            // 
            this.comboBox12.DataSource = this.workerBindingSource1;
            this.comboBox12.DisplayMember = "worker_name";
            this.comboBox12.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox12, "comboBox12");
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.ValueMember = "worker_id";
            // 
            // label243
            // 
            resources.ApplyResources(this.label243, "label243");
            this.label243.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label243.Name = "label243";
            // 
            // combo_filter_equ_ins
            // 
            this.combo_filter_equ_ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_filter_equ_ins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combo_filter_equ_ins, "combo_filter_equ_ins");
            this.combo_filter_equ_ins.FormattingEnabled = true;
            this.combo_filter_equ_ins.Name = "combo_filter_equ_ins";
            this.combo_filter_equ_ins.SelectedIndexChanged += new System.EventHandler(this.combo_filter_equ_ins_SelectedIndexChanged);
            // 
            // txtfilter5
            // 
            resources.ApplyResources(this.txtfilter5, "txtfilter5");
            this.txtfilter5.Name = "txtfilter5";
            // 
            // radioButton7
            // 
            resources.ApplyResources(this.radioButton7, "radioButton7");
            this.radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            resources.ApplyResources(this.radioButton8, "radioButton8");
            this.radioButton8.Checked = true;
            this.radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // txt_filt_upd1
            // 
            resources.ApplyResources(this.txt_filt_upd1, "txt_filt_upd1");
            this.txt_filt_upd1.Name = "txt_filt_upd1";
            // 
            // txt_filt_upd8
            // 
            resources.ApplyResources(this.txt_filt_upd8, "txt_filt_upd8");
            this.txt_filt_upd8.Name = "txt_filt_upd8";
            // 
            // equTableAdapter
            // 
            this.equTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.mainMenuToolStripMenuItem,
            this.equipmentInformationToolStripMenuItem,
            this.postingDataToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.BackgroundImage = global::notfinal.Properties.Resources.assss;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            resources.ApplyResources(this.mainMenuToolStripMenuItem, "mainMenuToolStripMenuItem");
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // equipmentInformationToolStripMenuItem
            // 
            this.equipmentInformationToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.equipmentInformationToolStripMenuItem.Name = "equipmentInformationToolStripMenuItem";
            resources.ApplyResources(this.equipmentInformationToolStripMenuItem, "equipmentInformationToolStripMenuItem");
            this.equipmentInformationToolStripMenuItem.Click += new System.EventHandler(this.equipmentInformationToolStripMenuItem_Click);
            // 
            // postingDataToolStripMenuItem
            // 
            this.postingDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.oilToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.fuelToolStripMenuItem,
            this.technicianToolStripMenuItem});
            this.postingDataToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.postingDataToolStripMenuItem.Name = "postingDataToolStripMenuItem";
            resources.ApplyResources(this.postingDataToolStripMenuItem, "postingDataToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // oilToolStripMenuItem
            // 
            this.oilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertOilToolStripMenuItem,
            this.editMainOilToolStripMenuItem});
            this.oilToolStripMenuItem.Name = "oilToolStripMenuItem";
            resources.ApplyResources(this.oilToolStripMenuItem, "oilToolStripMenuItem");
            // 
            // insertOilToolStripMenuItem
            // 
            this.insertOilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAmountToolStripMenuItem,
            this.totalRefillToolStripMenuItem,
            this.newOilTypeToolStripMenuItem});
            this.insertOilToolStripMenuItem.Name = "insertOilToolStripMenuItem";
            resources.ApplyResources(this.insertOilToolStripMenuItem, "insertOilToolStripMenuItem");
            // 
            // addAmountToolStripMenuItem
            // 
            this.addAmountToolStripMenuItem.Name = "addAmountToolStripMenuItem";
            resources.ApplyResources(this.addAmountToolStripMenuItem, "addAmountToolStripMenuItem");
            this.addAmountToolStripMenuItem.Click += new System.EventHandler(this.addAmountToolStripMenuItem_Click);
            // 
            // totalRefillToolStripMenuItem
            // 
            this.totalRefillToolStripMenuItem.Name = "totalRefillToolStripMenuItem";
            resources.ApplyResources(this.totalRefillToolStripMenuItem, "totalRefillToolStripMenuItem");
            this.totalRefillToolStripMenuItem.Click += new System.EventHandler(this.totalRefillToolStripMenuItem_Click);
            // 
            // newOilTypeToolStripMenuItem
            // 
            this.newOilTypeToolStripMenuItem.Name = "newOilTypeToolStripMenuItem";
            resources.ApplyResources(this.newOilTypeToolStripMenuItem, "newOilTypeToolStripMenuItem");
            this.newOilTypeToolStripMenuItem.Click += new System.EventHandler(this.newOilTypeToolStripMenuItem_Click);
            // 
            // editMainOilToolStripMenuItem
            // 
            this.editMainOilToolStripMenuItem.Name = "editMainOilToolStripMenuItem";
            resources.ApplyResources(this.editMainOilToolStripMenuItem, "editMainOilToolStripMenuItem");
            this.editMainOilToolStripMenuItem.Click += new System.EventHandler(this.editMainOilToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem1,
            this.editActiveFilterToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            resources.ApplyResources(this.filterToolStripMenuItem, "filterToolStripMenuItem");
            // 
            // insertToolStripMenuItem1
            // 
            this.insertToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsedFilterToolStripMenuItem,
            this.newFilterTypeToolStripMenuItem});
            this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
            resources.ApplyResources(this.insertToolStripMenuItem1, "insertToolStripMenuItem1");
            // 
            // changeUsedFilterToolStripMenuItem
            // 
            this.changeUsedFilterToolStripMenuItem.Name = "changeUsedFilterToolStripMenuItem";
            resources.ApplyResources(this.changeUsedFilterToolStripMenuItem, "changeUsedFilterToolStripMenuItem");
            this.changeUsedFilterToolStripMenuItem.Click += new System.EventHandler(this.changeUsedFilterToolStripMenuItem_Click);
            // 
            // newFilterTypeToolStripMenuItem
            // 
            this.newFilterTypeToolStripMenuItem.Name = "newFilterTypeToolStripMenuItem";
            resources.ApplyResources(this.newFilterTypeToolStripMenuItem, "newFilterTypeToolStripMenuItem");
            this.newFilterTypeToolStripMenuItem.Click += new System.EventHandler(this.newFilterTypeToolStripMenuItem_Click);
            // 
            // editActiveFilterToolStripMenuItem
            // 
            this.editActiveFilterToolStripMenuItem.Name = "editActiveFilterToolStripMenuItem";
            resources.ApplyResources(this.editActiveFilterToolStripMenuItem, "editActiveFilterToolStripMenuItem");
            this.editActiveFilterToolStripMenuItem.Click += new System.EventHandler(this.editActiveFilterToolStripMenuItem_Click);
            // 
            // fuelToolStripMenuItem
            // 
            this.fuelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.editLiterCostToolStripMenuItem1});
            this.fuelToolStripMenuItem.Name = "fuelToolStripMenuItem";
            resources.ApplyResources(this.fuelToolStripMenuItem, "fuelToolStripMenuItem");
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem3,
            this.newFuelTypeToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            resources.ApplyResources(this.insertToolStripMenuItem, "insertToolStripMenuItem");
            // 
            // insertToolStripMenuItem3
            // 
            this.insertToolStripMenuItem3.Name = "insertToolStripMenuItem3";
            resources.ApplyResources(this.insertToolStripMenuItem3, "insertToolStripMenuItem3");
            this.insertToolStripMenuItem3.Click += new System.EventHandler(this.insertToolStripMenuItem3_Click);
            // 
            // newFuelTypeToolStripMenuItem
            // 
            this.newFuelTypeToolStripMenuItem.Name = "newFuelTypeToolStripMenuItem";
            resources.ApplyResources(this.newFuelTypeToolStripMenuItem, "newFuelTypeToolStripMenuItem");
            this.newFuelTypeToolStripMenuItem.Click += new System.EventHandler(this.newFuelTypeToolStripMenuItem_Click);
            // 
            // editLiterCostToolStripMenuItem1
            // 
            this.editLiterCostToolStripMenuItem1.Name = "editLiterCostToolStripMenuItem1";
            resources.ApplyResources(this.editLiterCostToolStripMenuItem1, "editLiterCostToolStripMenuItem1");
            this.editLiterCostToolStripMenuItem1.Click += new System.EventHandler(this.editLiterCostToolStripMenuItem1_Click);
            // 
            // technicianToolStripMenuItem
            // 
            this.technicianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem2,
            this.editDataToolStripMenuItem});
            this.technicianToolStripMenuItem.Name = "technicianToolStripMenuItem";
            resources.ApplyResources(this.technicianToolStripMenuItem, "technicianToolStripMenuItem");
            // 
            // insertToolStripMenuItem2
            // 
            this.insertToolStripMenuItem2.Name = "insertToolStripMenuItem2";
            resources.ApplyResources(this.insertToolStripMenuItem2, "insertToolStripMenuItem2");
            this.insertToolStripMenuItem2.Click += new System.EventHandler(this.insertToolStripMenuItem2_Click);
            // 
            // editDataToolStripMenuItem
            // 
            this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            resources.ApplyResources(this.editDataToolStripMenuItem, "editDataToolStripMenuItem");
            this.editDataToolStripMenuItem.Click += new System.EventHandler(this.editDataToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periodicMaintenanceToolStripMenuItem,
            this.periodicMaintenanceToolStripMenuItem1,
            this.periodicMaintenanceToolStripMenuItem2});
            this.maintenanceToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            resources.ApplyResources(this.maintenanceToolStripMenuItem, "maintenanceToolStripMenuItem");
            // 
            // periodicMaintenanceToolStripMenuItem
            // 
            this.periodicMaintenanceToolStripMenuItem.Name = "periodicMaintenanceToolStripMenuItem";
            resources.ApplyResources(this.periodicMaintenanceToolStripMenuItem, "periodicMaintenanceToolStripMenuItem");
            this.periodicMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.periodicMaintenanceToolStripMenuItem_Click);
            // 
            // periodicMaintenanceToolStripMenuItem1
            // 
            this.periodicMaintenanceToolStripMenuItem1.Name = "periodicMaintenanceToolStripMenuItem1";
            resources.ApplyResources(this.periodicMaintenanceToolStripMenuItem1, "periodicMaintenanceToolStripMenuItem1");
            this.periodicMaintenanceToolStripMenuItem1.Click += new System.EventHandler(this.periodicMaintenanceToolStripMenuItem1_Click);
            // 
            // periodicMaintenanceToolStripMenuItem2
            // 
            this.periodicMaintenanceToolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.periodicMaintenanceToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.periodicMaintenanceToolStripMenuItem2.Name = "periodicMaintenanceToolStripMenuItem2";
            resources.ApplyResources(this.periodicMaintenanceToolStripMenuItem2, "periodicMaintenanceToolStripMenuItem2");
            this.periodicMaintenanceToolStripMenuItem2.Click += new System.EventHandler(this.periodicMaintenanceToolStripMenuItem2_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceReportToolStripMenuItem,
            this.oilReportToolStripMenuItem,
            this.fuelReportToolStripMenuItem,
            this.filterReportToolStripMenuItem,
            this.technicianReportToolStripMenuItem,
            this.availabilityAndUtilizationToolStripMenuItem,
            this.costReportToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20);
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            // 
            // maintenanceReportToolStripMenuItem
            // 
            this.maintenanceReportToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.maintenanceReportToolStripMenuItem.Name = "maintenanceReportToolStripMenuItem";
            resources.ApplyResources(this.maintenanceReportToolStripMenuItem, "maintenanceReportToolStripMenuItem");
            this.maintenanceReportToolStripMenuItem.Click += new System.EventHandler(this.maintenanceReportToolStripMenuItem_Click);
            // 
            // oilReportToolStripMenuItem
            // 
            this.oilReportToolStripMenuItem.Name = "oilReportToolStripMenuItem";
            resources.ApplyResources(this.oilReportToolStripMenuItem, "oilReportToolStripMenuItem");
            this.oilReportToolStripMenuItem.Click += new System.EventHandler(this.oilReportToolStripMenuItem_Click);
            // 
            // fuelReportToolStripMenuItem
            // 
            this.fuelReportToolStripMenuItem.Name = "fuelReportToolStripMenuItem";
            resources.ApplyResources(this.fuelReportToolStripMenuItem, "fuelReportToolStripMenuItem");
            this.fuelReportToolStripMenuItem.Click += new System.EventHandler(this.fuelReportToolStripMenuItem_Click);
            // 
            // filterReportToolStripMenuItem
            // 
            this.filterReportToolStripMenuItem.Name = "filterReportToolStripMenuItem";
            resources.ApplyResources(this.filterReportToolStripMenuItem, "filterReportToolStripMenuItem");
            this.filterReportToolStripMenuItem.Click += new System.EventHandler(this.filterReportToolStripMenuItem_Click);
            // 
            // technicianReportToolStripMenuItem
            // 
            this.technicianReportToolStripMenuItem.Name = "technicianReportToolStripMenuItem";
            resources.ApplyResources(this.technicianReportToolStripMenuItem, "technicianReportToolStripMenuItem");
            this.technicianReportToolStripMenuItem.Click += new System.EventHandler(this.technicianReportToolStripMenuItem_Click);
            // 
            // availabilityAndUtilizationToolStripMenuItem
            // 
            this.availabilityAndUtilizationToolStripMenuItem.Name = "availabilityAndUtilizationToolStripMenuItem";
            resources.ApplyResources(this.availabilityAndUtilizationToolStripMenuItem, "availabilityAndUtilizationToolStripMenuItem");
            this.availabilityAndUtilizationToolStripMenuItem.Click += new System.EventHandler(this.availabilityAndUtilizationToolStripMenuItem_Click);
            // 
            // costReportToolStripMenuItem
            // 
            this.costReportToolStripMenuItem.Name = "costReportToolStripMenuItem";
            resources.ApplyResources(this.costReportToolStripMenuItem, "costReportToolStripMenuItem");
            this.costReportToolStripMenuItem.Click += new System.EventHandler(this.costReportToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.modeToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            resources.ApplyResources(this.modeToolStripMenuItem, "modeToolStripMenuItem");
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            resources.ApplyResources(this.lightModeToolStripMenuItem, "lightModeToolStripMenuItem");
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            resources.ApplyResources(this.darkModeToolStripMenuItem, "darkModeToolStripMenuItem");
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // oilTableAdapter
            // 
            this.oilTableAdapter.ClearBeforeFill = true;
            // 
            // filterBindingSource
            // 
            this.filterBindingSource.DataMember = "filter";
            this.filterBindingSource.DataSource = this.hopeDataSetBindingSource;
            // 
            // filterTableAdapter
            // 
            this.filterTableAdapter.ClearBeforeFill = true;
            // 
            // Use
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Use";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Use_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hopeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopeDataSet)).EndInit();
            this.tabb3.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.main_rep.ResumeLayout(false);
            this.main_rep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_totalCost.ResumeLayout(false);
            this.pnl_totalCost.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel60.ResumeLayout(false);
            this.panel60.PerformLayout();
            this.panel61.ResumeLayout(false);
            this.panel61.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel22.ResumeLayout(false);
            this.filter_rep.ResumeLayout(false);
            this.filter_rep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel31.ResumeLayout(false);
            this.labor_rep.ResumeLayout(false);
            this.labor_rep.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_report_lp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.usa_ava.ResumeLayout(false);
            this.usa_ava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.cos_rep.ResumeLayout(false);
            this.cos_rep.PerformLayout();
            this.panel62.ResumeLayout(false);
            this.panel62.PerformLayout();
            this.panel48.ResumeLayout(false);
            this.panel48.PerformLayout();
            this.panel47.ResumeLayout(false);
            this.panel47.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).EndInit();
            this.tabb2.ResumeLayout(false);
            this.tabb2.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabb0.ResumeLayout(false);
            this.tabb0.PerformLayout();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pnl_posting.ResumeLayout(false);
            this.pnl_posting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picoil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnl_maint.ResumeLayout(false);
            this.pnl_maint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnl_report.ResumeLayout(false);
            this.pnl_report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel19.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabb1.ResumeLayout(false);
            this.tabb1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel55.ResumeLayout(false);
            this.panel55.PerformLayout();
            this.panel52.ResumeLayout(false);
            this.panel52.PerformLayout();
            this.panel56.ResumeLayout(false);
            this.panel56.PerformLayout();
            this.panel53.ResumeLayout(false);
            this.panel53.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel34.PerformLayout();
            this.panel35.ResumeLayout(false);
            this.panel35.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ4)).EndInit();
            this.panel51.ResumeLayout(false);
            this.panel51.PerformLayout();
            this.panel54.ResumeLayout(false);
            this.panel54.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridequ1)).EndInit();
            this.tabb4.ResumeLayout(false);
            this.tabControl7.ResumeLayout(false);
            this.prvvv.ResumeLayout(false);
            this.prvvv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_grid_prev1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel59.ResumeLayout(false);
            this.panel59.PerformLayout();
            this.panel58.ResumeLayout(false);
            this.panel58.PerformLayout();
            this.panel57.ResumeLayout(false);
            this.panel57.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.pnl_labor.ResumeLayout(false);
            this.pnl_labor.PerformLayout();
            this.pnl_last_hours.ResumeLayout(false);
            this.pnl_last_hours.PerformLayout();
            this.corr.ResumeLayout(false);
            this.corr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_cor_notdone)).EndInit();
            this.pnl_cor.ResumeLayout(false);
            this.pnl_cor.PerformLayout();
            this.pnl_cor_names.ResumeLayout(false);
            this.pnl_cor_names.PerformLayout();
            this.daii.ResumeLayout(false);
            this.daii.PerformLayout();
            this.panel_dai.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cor_dai)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.pnl_labor2.ResumeLayout(false);
            this.pnl_labor2.PerformLayout();
            this.tabb5.ResumeLayout(false);
            this.tabControl8.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.panel37.PerformLayout();
            this.pnl_oil_up_del.ResumeLayout(false);
            this.pnl_oil_up_del.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel41.ResumeLayout(false);
            this.panel41.PerformLayout();
            this.pnl_oil_ins.ResumeLayout(false);
            this.pnl_oil_ins.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.pnl_oil.ResumeLayout(false);
            this.pnl_oil.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnl_fue_edi.ResumeLayout(false);
            this.pnl_fue_edi.PerformLayout();
            this.pnl_filer_fuel_del.ResumeLayout(false);
            this.pnl_filer_fuel_del.PerformLayout();
            this.pnl_fue_ins.ResumeLayout(false);
            this.pnl_fue_ins.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel49.ResumeLayout(false);
            this.panel49.PerformLayout();
            this.panel45.ResumeLayout(false);
            this.panel45.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.pnl_tech_ins.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.pnl_tech_ed.ResumeLayout(false);
            this.pnl_tech_ed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.panel46.ResumeLayout(false);
            this.panel46.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.pnl_filt_ed.ResumeLayout(false);
            this.pnl_filt_ed.PerformLayout();
            this.panel44.ResumeLayout(false);
            this.panel44.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.pnl_filt_ins.ResumeLayout(false);
            this.pnl_filt_ins.PerformLayout();
            this.panel42.ResumeLayout(false);
            this.panel42.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel50.ResumeLayout(false);
            this.panel50.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabb3;
        private System.Windows.Forms.TabPage tabb2;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.DateTimePicker date_add_hours;
        private System.Windows.Forms.Label lbl_prv_hrs_stage2;
        private System.Windows.Forms.Label lbl_prv_hrs_stage1;
        private System.Windows.Forms.Label lbl_prv_hrs_part2;
        private System.Windows.Forms.Label lbl_prv_hrs_part1;
        private System.Windows.Forms.Label lbl_after;
        private System.Windows.Forms.Label lowww;
        private System.Windows.Forms.Label lbl_main_id;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label lbl_hours2;
        private System.Windows.Forms.Label lbl_hours1;
        private System.Windows.Forms.Button btnhours;
        private System.Windows.Forms.ComboBox comb_add_hours;
        private System.Windows.Forms.TextBox txt_input_hours;
        private System.Windows.Forms.TabPage tabb0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_notf;
        private System.Windows.Forms.PictureBox picfuel;
        private System.Windows.Forms.PictureBox picoil;
        private System.Windows.Forms.PictureBox picfilter;
        private System.Windows.Forms.PictureBox picreport;
        private System.Windows.Forms.PictureBox pichours;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_detais_hours;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.BindingSource hopeDataSetBindingSource;
        private hopeDataSet hopeDataSet;
        private hopeDataSetTableAdapters.equTableAdapter equTableAdapter;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private hopeDataSetTableAdapters.workerTableAdapter workerTableAdapter;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.BindingSource workerBindingSource2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.TabPage tabb4;
        private System.Windows.Forms.TabControl tabControl7;
        private System.Windows.Forms.TabPage prvvv;
        private System.Windows.Forms.TabPage daii;
        private System.Windows.Forms.TabPage corr;
        private System.Windows.Forms.Button btn_prev_main_ins_upd;
        private System.Windows.Forms.Label lbl_state_prev;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Panel pnl_labor;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button btn_del_labor;
        private System.Windows.Forms.Button btn_add_labor;
        private System.Windows.Forms.FlowLayoutPanel flow_labor;
        private System.Windows.Forms.Button btn_bring_to_upd;
        private System.Windows.Forms.TextBox txt_pre_4_parts;
        private System.Windows.Forms.Button btn_pre_sho;
        private System.Windows.Forms.Label lbl_prv3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker date_prv;
        private System.Windows.Forms.Label lbl_prv5;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label lbl_prv2;
        private System.Windows.Forms.Label lbl_prv6;
        private System.Windows.Forms.TextBox txt_pre_7_det;
        private System.Windows.Forms.TextBox txt_pre_6_cost;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txt_pre_5_stat_1;
        private System.Windows.Forms.TextBox txt_pre_2_type_number;
        private System.Windows.Forms.TextBox txt_pre_8_user;
        private System.Windows.Forms.TextBox txt_pre_10_stat_2;
        private System.Windows.Forms.TextBox txt_pre_9_type_name;
        private System.Windows.Forms.TextBox txt_pre_1_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_prv_hrs_stage4;
        private System.Windows.Forms.Label lbl_prv_hrs_stage3;
        private System.Windows.Forms.Label lbl_prv_after;
        private System.Windows.Forms.Label lowww_prv;
        private System.Windows.Forms.Label lbl_hours_ins2;
        private System.Windows.Forms.Label lbl_hours_ins1;
        private System.Windows.Forms.Button btn_pre_upd;
        private System.Windows.Forms.Label lbl_prv8;
        private System.Windows.Forms.Label lbl_prv4;
        private System.Windows.Forms.Label lbl_prv1;
        private System.Windows.Forms.ComboBox comb_prev_main1;
        private System.Windows.Forms.DataGridView dat_grid_prev1;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label lbl_check_id;
        private System.Windows.Forms.Label lbl_dai_state;
        private System.Windows.Forms.Label lbl_dai_parts;
        private System.Windows.Forms.Panel panel_dai;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.FlowLayoutPanel flow_dai;
        private System.Windows.Forms.Button btn_Corr_main_ins_upd;
        private System.Windows.Forms.Label lbl_dai_corr_state;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_duration2;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Button btn_del_labor2;
        private System.Windows.Forms.Button btn_add_labor2;
        private System.Windows.Forms.RadioButton radio_corr_dai_Not_done;
        private System.Windows.Forms.RadioButton radio_corr_dai_done;
        private System.Windows.Forms.TextBox txt_main_ins7;
        private System.Windows.Forms.TextBox txt_main_ins6;
        private System.Windows.Forms.TextBox txt_main_ins4;
        private System.Windows.Forms.DateTimePicker date_main_ins;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGrid_cor_dai;
        private System.Windows.Forms.ComboBox comb_CP_main_equ;
        private System.Windows.Forms.Label lbl_main_name;
        private System.Windows.Forms.Button btn_bring_to_upd2;
        private System.Windows.Forms.FlowLayoutPanel flow_labor2;
        private System.Windows.Forms.Panel pnl_labor2;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txt_main_ins8;
        private System.Windows.Forms.TextBox txt_main_id;
        private System.Windows.Forms.TextBox txt_main_stg_det_corr;
        private System.Windows.Forms.TextBox txt_main_ins5;
        private System.Windows.Forms.TextBox txt_main_ins3;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cor_step2;
        private System.Windows.Forms.Panel pnl_cor;
        private System.Windows.Forms.TextBox txt_cor_dura;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Button btn_cor_del_lapor;
        private System.Windows.Forms.Button btn_cor_add_lapor;
        private System.Windows.Forms.RadioButton radi_cor_notdone;
        private System.Windows.Forms.RadioButton radi_cor_done;
        private System.Windows.Forms.TextBox txt_cor_deta;
        private System.Windows.Forms.TextBox txt_cor_cost;
        private System.Windows.Forms.TextBox txt_cor_parts;
        private System.Windows.Forms.DateTimePicker date_cor;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.DataGridView datagrid_cor_notdone;
        private System.Windows.Forms.ComboBox combo_cor_equ;
        private System.Windows.Forms.Label lbl_cor_name;
        private System.Windows.Forms.Label lbl_cor_not_done;
        private System.Windows.Forms.FlowLayoutPanel flow_cor_labors;
        private System.Windows.Forms.Panel pnl_cor_names;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label lbl_dai_state1;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.TextBox txt_main_ins81;
        private System.Windows.Forms.TextBox txt_main_id1;
        private System.Windows.Forms.TextBox txt_cor_state;
        private System.Windows.Forms.TextBox txt_main_ins31;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label lbl_dai_corr_state1;
        private System.Windows.Forms.TabPage tabb5;
        private System.Windows.Forms.TabControl tabControl8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.TextBox txt_add_hours_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label label204;
        private System.Windows.Forms.Label label208;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.Panel pnl_oil_ins;
        private System.Windows.Forms.Panel pnl_oil;
        private System.Windows.Forms.RadioButton rdio_oil_add;
        private System.Windows.Forms.RadioButton rdio_oil_new;
        private System.Windows.Forms.ComboBox comb_oil_types;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.TextBox txt_oil_ins2;
        private System.Windows.Forms.Button btn_oil_ins;
        private System.Windows.Forms.TextBox txt_oil_ins3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_oil_ins4;
        private System.Windows.Forms.DateTimePicker date_oil_ins1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_oil_ins;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.TextBox txt_oil_upd_main_type;
        private System.Windows.Forms.TextBox txt_oil_upd_main_alert;
        private System.Windows.Forms.TextBox txt_oil_upd_main_state;
        private System.Windows.Forms.TextBox txt_oil_upd8;
        private System.Windows.Forms.TextBox txt_oil_upd2;
        private System.Windows.Forms.TextBox txt_oil_upd1;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Panel pnl_oil_up_del;
        private System.Windows.Forms.TextBox txt_oil_rep_up3;
        private System.Windows.Forms.TextBox txt_oil_rep_up2;
        private System.Windows.Forms.TextBox txt_oil_rep_up1;
        private System.Windows.Forms.Button btn_oil_del;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_oil_upd;
        private System.Windows.Forms.DateTimePicker date_oil_upd1;
        private System.Windows.Forms.TextBox txt_oil_upd6;
        private System.Windows.Forms.TextBox txt_oil_upd5;
        private System.Windows.Forms.TextBox txt_oil_upd4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_oil_sho;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comb_oil_del;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comb_oil_del_equ;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox comb_fuel_ins_equ;
        private System.Windows.Forms.TextBox txt_fuel_ins2;
        private System.Windows.Forms.Button btn_fuel_ins;
        private System.Windows.Forms.TextBox txt_fuel_ins3;
        private System.Windows.Forms.TextBox txt_fuel_ins4;
        private System.Windows.Forms.DateTimePicker date_fuel_ins;
        private System.Windows.Forms.TextBox txt_fuel_ins1;
        private System.Windows.Forms.TextBox txt_fuel_ins5;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Panel pnl_filer_fuel_del;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btn_fuel_upd;
        private System.Windows.Forms.DateTimePicker date_fuel_upd;
        private System.Windows.Forms.TextBox txt_fuel_upd6;
        private System.Windows.Forms.TextBox txt_fuel_upd5;
        private System.Windows.Forms.Button btn_fuel_del;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txt_fuel_upd8;
        private System.Windows.Forms.Button btn_fuel_sho;
        private System.Windows.Forms.TextBox txt_fuel_upd4;
        private System.Windows.Forms.TextBox txt_fuel_upd2;
        private System.Windows.Forms.TextBox txt_fuel_upd1;
        private System.Windows.Forms.ComboBox comb_fuel_del;
        private System.Windows.Forms.ComboBox comb_fuel_del_equ;
        private System.Windows.Forms.Button btn_labor_ins;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox txt_wrker_name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_wrk_hrs_ins;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btn_labor_del;
        private System.Windows.Forms.Button btn_labor_upd;
        private System.Windows.Forms.TextBox txt_lp_up_name;
        private System.Windows.Forms.TextBox txt_lp_up_salary;
        private System.Windows.Forms.TextBox txt_lp_up_hours;
        private System.Windows.Forms.ComboBox combo_laboe_upd;
        private System.Windows.Forms.TextBox txt_fil_rep3;
        private System.Windows.Forms.TextBox txt_fil_rep2;
        private System.Windows.Forms.TextBox txt_fil_rep1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox combo_filter_equ_ins;
        private System.Windows.Forms.Button btn_ins_filt;
        private System.Windows.Forms.TextBox txtfilter2;
        private System.Windows.Forms.TextBox txtfilter3;
        private System.Windows.Forms.TextBox txtfilter4;
        private System.Windows.Forms.DateTimePicker datefilter1;
        private System.Windows.Forms.TextBox txtfilter1;
        private System.Windows.Forms.TextBox txtfilter5;
        private System.Windows.Forms.TextBox txt_fil_rep_up3;
        private System.Windows.Forms.TextBox txt_fil_rep_up2;
        private System.Windows.Forms.TextBox txt_fil_rep_up1;
        private System.Windows.Forms.Button btn_del_filt;
        private System.Windows.Forms.Button btn_flt_upd;
        private System.Windows.Forms.DateTimePicker dat_filt_upd1;
        private System.Windows.Forms.TextBox txt_filt_upd6;
        private System.Windows.Forms.TextBox txt_filt_upd5;
        private System.Windows.Forms.TextBox txt_filt_upd4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_filt_upd8;
        private System.Windows.Forms.Button btn_flt_sho;
        private System.Windows.Forms.TextBox txt_filt_upd2;
        private System.Windows.Forms.TextBox txt_filt_upd1;
        private System.Windows.Forms.ComboBox comb_flt_del;
        private System.Windows.Forms.ComboBox comb_flt_del_equ;
        private System.Windows.Forms.TabPage tabb1;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.ComboBox comb_prv_sq;
        private System.Windows.Forms.DataGridView dataGridequ3;
        private System.Windows.Forms.DataGridView dataGridequ2;
        private System.Windows.Forms.DataGridView dataGridequ4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Button btn_fuel_ins_equ;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btn_flt_ins_equ;
        private System.Windows.Forms.Button btn_oil_ins_equ;
        private System.Windows.Forms.Button btn_fuel_dlt_equ;
        private System.Windows.Forms.Button btn_fuel_upd_equ;
        private System.Windows.Forms.Button btn_flt_dlt_equ;
        private System.Windows.Forms.Button btn_flt_upd_equ;
        private System.Windows.Forms.Button btn_oil_dlt_equ2;
        private System.Windows.Forms.Button btn_oil_upd_equ;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_lng;
        private System.Windows.Forms.Label lbl_high;
        private System.Windows.Forms.Label lbl_wiegt;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label lbl_arr;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_sn;
        private System.Windows.Forms.Label lbl_engsn;
        private System.Windows.Forms.Label lbl_transn;
        private System.Windows.Forms.Label lbl_highidle;
        private System.Windows.Forms.Label lbl_lowidle;
        private System.Windows.Forms.Label lbl_engp;
        private System.Windows.Forms.Label lbl_mg_size;
        private System.Windows.Forms.Label lbl_ac_size;
        private System.Windows.Forms.Label lbl_eng_size;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_tiersize;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox combo_equ_show;
        private System.Windows.Forms.DataGridView dataGridequ1;
        private System.Windows.Forms.Label lb_mod_1;
        private System.Windows.Forms.Label lb_mod_2;
        private System.Windows.Forms.Label lb_mod_4;
        private System.Windows.Forms.Label lb_mod_7;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lb_mod_5;
        private System.Windows.Forms.Label lb_mod_6;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Panel pnl_report;
        private System.Windows.Forms.Panel pnl_posting;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Panel pnl_maint;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Panel pnl_fue_edi;
        private System.Windows.Forms.Panel pnl_fue_ins;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel49;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel pnl_tech_ins;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Panel pnl_tech_ed;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Panel pnl_filt_ed;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel pnl_filt_ins;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicianReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availabilityAndUtilizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicMaintenanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem periodicMaintenanceToolStripMenuItem2;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.BindingSource oilBindingSource;
        private hopeDataSetTableAdapters.oilTableAdapter oilTableAdapter;
        private System.Windows.Forms.Label main_iiid;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem insertOilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMainOilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLiterCostToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeUsedFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFilterTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalRefillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
        private System.Windows.Forms.BindingSource filterBindingSource;
        private hopeDataSetTableAdapters.filterTableAdapter filterTableAdapter;
        private System.Windows.Forms.ComboBox combo_change_filter;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.ToolStripMenuItem editActiveFilterToolStripMenuItem;
        private System.Windows.Forms.Label lbl_what_filter;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label where;
        private System.Windows.Forms.ToolStripMenuItem oilReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuelReportToolStripMenuItem;
        private System.Windows.Forms.Label lbl_oil_what;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.TextBox txt_oi_ma_type;
        private System.Windows.Forms.TextBox txt_oi_state;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.TextBox txt_oil_rep_ins3;
        private System.Windows.Forms.TextBox txt_oil_rep_ins2;
        private System.Windows.Forms.TextBox txt_oil_rep_ins1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage main_rep;
        private System.Windows.Forms.CheckBox chk_rep_word;
        private System.Windows.Forms.PictureBox btn_report;
        private System.Windows.Forms.Label lb_mod_31;
        private System.Windows.Forms.TextBox txt_rep_word;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_cost2;
        private System.Windows.Forms.TextBox txt_cost1;
        private System.Windows.Forms.Panel pnl_totalCost;
        private System.Windows.Forms.CheckBox chk_cost3;
        private System.Windows.Forms.TextBox txt_cost3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.CheckBox check_type;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.CheckBox check_id;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.ComboBox com_report;
        private System.Windows.Forms.CheckBox check_daily;
        private System.Windows.Forms.DateTimePicker date_old;
        private System.Windows.Forms.CheckBox check_corr;
        private System.Windows.Forms.DateTimePicker date_new;
        private System.Windows.Forms.CheckBox check_prev;
        private System.Windows.Forms.CheckBox check_date;
        private System.Windows.Forms.RadioButton radio_done;
        private System.Windows.Forms.CheckBox check_cost;
        private System.Windows.Forms.RadioButton radio_not;
        private System.Windows.Forms.CheckBox check_state;
        private System.Windows.Forms.TabPage labor_rep;
        private System.Windows.Forms.Label lb_mod_32;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox btn_report_lp;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.CheckBox chk_date;
        private System.Windows.Forms.CheckBox chk_id;
        private System.Windows.Forms.CheckBox chk_equ;
        private System.Windows.Forms.DateTimePicker date_rep_old;
        private System.Windows.Forms.ComboBox combo_labor_report;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker date_rep_new;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_rep_lb_del;
        private System.Windows.Forms.Button btn_rep_lb_up;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TabPage usa_ava;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lb_mod_33;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label129;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.ComboBox combo_use;
        private System.Windows.Forms.Button btn_use;
        private System.Windows.Forms.DateTimePicker date_use_new;
        private System.Windows.Forms.DateTimePicker date_use_old;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox combo_oil_rep;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newOilTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem newFuelTypeToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdio_oil_cata;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label221;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.TextBox txt_oil_rep_ins0;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txt_oil_rep_up0;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label218;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.RadioButton rdio_filt_new;
        private System.Windows.Forms.RadioButton rdio_filt_change;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.TextBox txt_fil_rep0;
        private System.Windows.Forms.Label label224;
        private System.Windows.Forms.TextBox txt_fil_rep_up0;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.TextBox txt_pre_0_now_hours;
        private System.Windows.Forms.Label label225;
        private System.Windows.Forms.Label label226;
        private System.Windows.Forms.Label lbl_interval;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label lbl_lastH;
        private System.Windows.Forms.Label label230;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Label label227;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Label label231;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.TabPage filter_rep;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.TabPage cos_rep;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.ToolStripMenuItem filterReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costReportToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label229;
        private System.Windows.Forms.CheckBox chc_2_main;
        private System.Windows.Forms.CheckBox chc_4_filters;
        private System.Windows.Forms.CheckBox chc_3_fuel;
        private System.Windows.Forms.CheckBox chc_1_lub;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label lbl_6_tech;
        private System.Windows.Forms.Label lbl_5_parts;
        private System.Windows.Forms.Label lbl_4_filter;
        private System.Windows.Forms.Label lbl_3_fuel;
        private System.Windows.Forms.CheckBox chc_6_tech;
        private System.Windows.Forms.CheckBox chc_5_parts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_1_lubs;
        private System.Windows.Forms.Label label248;
        private System.Windows.Forms.Label label247;
        private System.Windows.Forms.Label label246;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.DateTimePicker dateTimePicker9;
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.CheckBox radioButton15;
        private System.Windows.Forms.CheckBox radioButton14;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label237;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Label label236;
        private System.Windows.Forms.Label txt_pre_3_hours;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label txt_pre_3_numm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Label label238;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_cor_bring;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Panel pnl_last_hours;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column37;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column38;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column39;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column40;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column41;
        private System.Windows.Forms.DataGridViewTextBoxColumn ss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column42;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column43;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column44;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column45;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column46;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column47;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column48;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Panel panel50;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.DataGridViewTextBoxColumn aaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Panel panel53;
        private System.Windows.Forms.Panel panel52;
        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Panel panel55;
        private System.Windows.Forms.Panel panel56;
        private System.Windows.Forms.Panel panel58;
        private System.Windows.Forms.Panel panel57;
        private System.Windows.Forms.Panel panel59;
        private System.Windows.Forms.Panel panel60;
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Panel panel62;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.Label label251;
        private System.Windows.Forms.Label label252;
        private System.Windows.Forms.Label label249;
        private System.Windows.Forms.Label label250;
        private System.Windows.Forms.Label label244;
        private System.Windows.Forms.Label label245;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.Button button6;
    }
}