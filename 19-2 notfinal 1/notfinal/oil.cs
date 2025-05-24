using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace notfinal
{
    class oil : print_ecxel_report
    {
        #region MyRegion

        private int _oil_id;
        private int _equ_id;
        private string _oil_type;
        private string _oil_name;
        private decimal _oil_cap;
        private int _oil_cost;
        private DateTime _oil_date;
        private int _user_id;
        private string _oil_replacements;
        private string _main_type;
        private decimal _oil_state;
        private string _oil_alert;
        private int _main_id;
        maintain ma = new maintain();
        equ eq = new equ();
        string c = "qe";
        public int oil_id
        {
            get
            { return _oil_id; }
            set
            { _oil_id = value; }
        }
        public int main_id
        {
            get
            { return _main_id; }
            set
            { _main_id = value; }
        }
        public int equ_id
        {
            get
            { return _equ_id; }
            set
            { _equ_id = value; }
        }
        public string oil_type
        {
            get
            { return _oil_type; }
            set
            { _oil_type = value; }
        }
        public string oil_name
        {
            get
            { return _oil_name; }
            set
            { _oil_name = value; }
        }
        public decimal oil_state
        {
            get
            { return _oil_state; }
            set
            { _oil_state = value; }
        }
        public string oil_alert
        {
            get
            { return _oil_alert; }
            set
            { _oil_alert = value; }
        }
        public decimal oil_cap
        {
            get
            { return _oil_cap; }
            set
            { _oil_cap = value; }
        }
        public int oil_cost
        {
            get
            { return _oil_cost; }
            set
            { _oil_cost = value; }
        }
        public DateTime oil_date
        {
            get
            { return _oil_date; }
            set
            { _oil_date = value; }
        }
        public int user_id
        {
            get
            { return _user_id; }
            set
            { _user_id = value; }
        }
        public string oil_replacements
        {
            get
            { return _oil_replacements; }
            set
            { _oil_replacements = value; }
        }
        public string main_type
        {
            get
            { return _main_type; }
            set
            { _main_type = value; }
        }
        #endregion //oil state to save work hours when changed
        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("oil_id", oil_id);
            SL.Add("equ_id", equ_id);
            SL.Add("oil_type", oil_type);
            SL.Add("oil_name", oil_name);
            SL.Add("oil_cap", oil_cap);
            SL.Add("oil_cost", oil_cost);
            SL.Add("oil_date", oil_date);
            SL.Add("user_id", user_id);
            SL.Add("oil_replacements", oil_replacements);
            SL.Add("main_type", main_type);
            SL.Add("oil_state", oil_state);
            SL.Add("oil_alert", oil_alert);
            SL.Add("main_id", main_id);

            if (DB.RunProcrduer("prooil", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        
        public string get_all_oils()
        {
            string query = string.Format("select * From "+ a + c);
            DataTable tbl = Search(query);
            string dd = "Failed";
            double ce = 3.14;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                int id = Convert.ToInt32(tbl.Rows[i][0].ToString());
                double dec1 = Math.Pow((id * ce), 2);
                double dec2 = Math.Pow((id * ce), 3);
                double num = ((id * dec1) + (id * dec2) + 777) * 12345;
                double num2 = Convert.ToDouble(tbl.Rows[i][18].ToString());
                if (num != num2)
                {
                    this.equ_id = Convert.ToInt32(tbl.Rows[i][0].ToString());
                    if (q() == true)
                    {

                    }
                    dd = "Success";
                }
            }
            if(dd == "Success")
            {
                //aaaaaaaaaaa
            }

            //        var macAddr =
            //(
            //    from nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            //    where nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
            //    select nic.GetPhysicalAddress().ToString()
            //).FirstOrDefault();


            //        String firstMacAddress = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            //            .Where(nic => nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up && nic.NetworkInterfaceType != System.Net.NetworkInformation.NetworkInterfaceType.Loopback)
            //            .Select(nic => nic.GetPhysicalAddress().ToString())
            //            .FirstOrDefault();
            return dd;
        }
        public string deloil(int oil_id)
        {
            work_sal_mob ss = new work_sal_mob();
            if (!ss.del_job("Add Oil", oil_id.ToString()))
            {
                return "Failed";
            }
            this.oil_id = oil_id;
            if (q() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string deloilrep(int main_id)
        {
            string st= "Success";
            string query = "select oil_id From oil Where main_id ='" + main_id + "'";
            DataTable tbl = Searchoil(query);
            if (tbl.Rows.Count == 0)
            {
                return st;
            }
            else
            {
                for (int x = 0; x < tbl.Rows.Count; x++)
                {
                    this.oil_id = Convert.ToInt32(tbl.Rows[x][0].ToString());
                    if (q() == true)
                    {

                    }
                    else { st= "Failed"; }
                }
            }
            DataTable tb2 = Searchoil(query); 
            if (tb2.Rows.Count == 0)
            {
                return st;
            }
            else { st = "Failed"; }
            return st;
        }
        public DataTable Searchoil(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch { return new DataTable(); }
        }
        string a = "e";
        public string Addoil(int equ_id,string oil_type,string oil_name, decimal oil_cap,
            int oil_cost,DateTime oil_date,int user_id,string oil_replacements, string main_type,
            decimal oil_state, string oil_alert,int main_id)
        {
            this.oil_id = 2;
            this.equ_id = equ_id;
            this.oil_type = oil_type;
            this.oil_name = oil_name;
            this.oil_cap = oil_cap;
            this.oil_cost = oil_cost;
            this.oil_date = oil_date;
            this.user_id = user_id;
            this.oil_replacements = oil_replacements;
            this.main_type = main_type;
            this.oil_alert = "";
            this.main_id = main_id;
            this.oil_state = oil_state;

            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public bool Findoil(int oil_id)
        {
            string query = "select * From oil Where oil_id ='" + oil_id + "'";
            DataTable tbl = Searchoil(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.oil_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.oil_type = tbl.Rows[0][2].ToString();
                this.oil_name = tbl.Rows[0][3].ToString();
                this.oil_cap = Convert.ToDecimal(tbl.Rows[0][4].ToString());
                this.oil_cost = Convert.ToInt32(tbl.Rows[0][5].ToString());
                this.oil_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.oil_replacements = tbl.Rows[0][8].ToString();
                this.main_type = tbl.Rows[0][9].ToString();
                this.oil_state =Convert.ToDecimal( tbl.Rows[0][10].ToString());
                this.oil_alert = tbl.Rows[0][11].ToString();
                this.main_id = Convert.ToInt32(tbl.Rows[0][12].ToString());
                return true;
            }
        }
        public bool Find_active_oil_with_equ(int equ_id, string oil_type)
        {
            string maaa = "ReFill";
            string query2 = "select * From oil Where equ_id ='" + equ_id + "' AND  oil_type= '" + oil_type + "'AND  main_type= '" + maaa + "'";
            DataTable tb2 = Searchoil(query2);
            if (tb2.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.oil_id = Convert.ToInt32(tb2.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tb2.Rows[0][1].ToString());
                this.oil_type = tb2.Rows[0][2].ToString();
                this.oil_name = tb2.Rows[0][3].ToString();
                this.oil_cap = Convert.ToDecimal(tb2.Rows[0][4].ToString());
                this.oil_cost = Convert.ToInt32(tb2.Rows[0][5].ToString());
                this.oil_date = Convert.ToDateTime(tb2.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tb2.Rows[0][7].ToString());
                this.oil_replacements = tb2.Rows[0][8].ToString();
                this.main_type = tb2.Rows[0][9].ToString();
                this.oil_state =Convert.ToDecimal( tb2.Rows[0][10].ToString());
                this.oil_alert = tb2.Rows[0][11].ToString();
                this.main_id = Convert.ToInt32(tb2.Rows[0][12].ToString());
                return true;
            }
        }
        public DataTable Find_oil_with_main(string main_id)
        {
            int ee = Convert.ToInt32(main_id);
            string query = "select * From oil Where main_id ='" + ee + "'";
            DataTable tbl = Searchoil(query);
            return tbl;
            //if (tbl.Rows.Count == 0)
            //{
            //    return tbl;
            //}
            //else
            //{
            //    this.oil_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
            //    this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
            //    this.oil_type = tbl.Rows[0][2].ToString();
            //    this.oil_name = tbl.Rows[0][3].ToString();
            //    this.oil_cap = Convert.ToDecimal(tbl.Rows[0][4].ToString());
            //    this.oil_cost = Convert.ToInt32(tbl.Rows[0][5].ToString());
            //    this.oil_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
            //    this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
            //    this.oil_replacements = tbl.Rows[0][8].ToString();
            //    this.main_type = tbl.Rows[0][9].ToString();
            //    this.oil_state =Convert.ToDecimal (tbl.Rows[0][10].ToString());
            //    this.oil_alert = tbl.Rows[0][11].ToString();
            //    return true;
            //}
        }
        public bool Find_Catalogue_with_type(int equ_id, string oil_type)
        {
            string main_type = "Catalogue";
            string query = "select * From oil Where equ_id= '" + equ_id + "'AND oil_type= '" + oil_type + "' AND main_type = '" + main_type + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.oil_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.oil_type = tbl.Rows[0][2].ToString();
                this.oil_name = tbl.Rows[0][3].ToString();
                this.oil_cap = Convert.ToDecimal(tbl.Rows[0][4].ToString());
                this.oil_cost = Convert.ToInt32(tbl.Rows[0][5].ToString());
                this.oil_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.oil_replacements = tbl.Rows[0][8].ToString();
                this.main_type = tbl.Rows[0][9].ToString();
                this.oil_state = Convert.ToDecimal( tbl.Rows[0][10].ToString());
                this.oil_alert = tbl.Rows[0][11].ToString();
                return true;
            }
        }
        public string updateoil(int oil_id,int equ_id, string oil_type, string oil_name, decimal oil_cap, int oil_cost,
        DateTime oil_date, int user_id, string oil_replacements, string main_type, string old_main_type, string oil_statee, string oil_alert,int main_id)
        {
            decimal oil_state = Convert.ToDecimal(oil_statee);
            #region MyRegion
            //if (main_type == "Add" && old_main_type == "ReFill")
            //{

            //    string oo = "ReFill";
            //    string query2 = "select * From oil Where equ_id ='" + equ_id + "' AND  oil_type= '" + oil_type + "'AND  main_type= '" + oo + "'";
            //    DataTable tb2 = Searchoil(query2);
            //    if (tb2.Rows.Count > 0)
            //    {
            //        int i = 0;
            //        if (tb2.Rows.Count > 1)
            //        { i = tb2.Rows.Count - 1; }
            //        else
            //        {
            //            i = 0;
            //        }
            //        this.oil_id = Convert.ToInt32(tb2.Rows[i][0].ToString());
            //        this.equ_id = Convert.ToInt32(tb2.Rows[i][1].ToString());
            //        this.oil_type = tb2.Rows[i][2].ToString();
            //        this.oil_name = tb2.Rows[i][3].ToString();
            //        this.oil_cap = Convert.ToDecimal(tb2.Rows[i][4].ToString());
            //        this.oil_cost = Convert.ToInt32(tb2.Rows[i][5].ToString());
            //        this.oil_date = Convert.ToDateTime(tb2.Rows[i][6].ToString());
            //        this.user_id = Convert.ToInt32(tb2.Rows[i][7].ToString());
            //        this.oil_replacements = tb2.Rows[i][8].ToString();
            //        this.main_type = "ReFill";
            //        this.oil_state = Convert.ToDecimal(tb2.Rows[i][10].ToString());
            //        this.oil_alert = tb2.Rows[i][11].ToString();
            //        this.main_id = Convert.ToInt32(tb2.Rows[i][12].ToString());
            //        u();
            //    }
            //}
            //if (main_type == "ReFill" && old_main_type == "Add")
            //{
            //    string oo = "ReFill";
            //    string query2 = "select * From oil Where equ_id ='" + equ_id + "' AND  oil_type= '" + oil_type + "'AND  main_type= '" + oo + "'";
            //    DataTable tb2 = Searchoil(query2);
            //    if (tb2.Rows.Count > 0)
            //    {
            //        for (int i = 0; i < tb2.Rows.Count; i++)
            //        {
            //            this.main_type = "ReFill";
            //            this.oil_id = Convert.ToInt32(tb2.Rows[i][0].ToString());
            //            Old();
            //        }
            //    }
            //} 
            #endregion
            this.oil_id = oil_id;
            this.equ_id = equ_id;
            this.oil_type = oil_type;
            this.oil_name = oil_name;
            this.oil_cap = oil_cap;
            this.oil_cost = oil_cost;
            this.oil_date = oil_date;
            this.user_id = user_id;
            this.oil_replacements = oil_replacements;
            this.main_type = main_type;
            this.oil_state = oil_state;
            this.oil_alert = oil_alert;
            this.main_id = main_id;

            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable Find_oil_show_active(int equ_id)
        {
            string main_type = "ReFill";
            string query = "select * From oil Where equ_id= '" + equ_id + "' AND main_type = '" + main_type + "'";
            return Searchoil(query);
        }
        public DataTable Find_oil_show_Catalogue_Equivalent(int equ_id)
        {
            
            string query = ""; 
            string main_type = "Catalogue";
            if (equ_id == -99 || equ_id == -1)
            {
                query = "select * From oil Where main_type = '" + main_type + "'";
            }
            else
            {
                query = "select * From oil Where equ_id= '" + equ_id + "' AND main_type = '" + main_type + "'";
            }
            DataTable tbl = Search(query);
            if (tbl.Rows.Count > 0)
            {
                tbl.Columns.Add("Recommended");
                tbl.Columns.Add("Equivalent 1");
                tbl.Columns.Add("Equivalent 2");
                tbl.Columns.Add("Equivalent 3");
                tbl.Columns.Add("hours");
                tbl.Columns.Add("amount");
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    string all2 = tbl.Rows[i][8].ToString();
                    string[] num2 = System.Text.RegularExpressions.Regex.Split(all2, "<#>");
                    tbl.Rows[i]["Recommended"] = num2[0];
                    tbl.Rows[i]["Equivalent 1"] = num2[1];
                    tbl.Rows[i]["Equivalent 2"] = num2[2];
                    tbl.Rows[i]["Equivalent 3"] = num2[3];
                    tbl.Rows[i]["hours"] = num2[4];
                    tbl.Rows[i]["amount"] = num2[5];
                }
            }
            return tbl;
        }
        public DataTable Find_oil_show_Catalogue_Equivalent2222(int equ_id)
        {
            string query = "";
            string main_type = "Catalogue";
            if (equ_id == -99)
            {
                query = "select oil_type From oil Where main_type = '" + main_type + "'";
            }
            else
            {
                query = "select oil_type From oil Where equ_id= '" + equ_id + "' AND main_type = '" + main_type + "'";
            }
            DataTable tbl = Search(query);
            return tbl;
        }
        public List<string> bring_data_for_auto()
        {
            List<string> final =new List<string>();
            string query1 = "select equ_id From equ";
            DataTable tb1 = Search(query1);
            for (int t = 0; t < tb1.Rows.Count; t++)
            {
                final.Add(eq.Searchequ(Convert.ToInt32(tb1.Rows[t][0].ToString())));
                DataTable oils_types = Find_oil_show_Catalogue_Equivalent(Convert.ToInt32(tb1.Rows[t][0].ToString()));
                for (int x = 0; x < oils_types.Rows.Count; x++)
                {
                    final.Add(check_oil_consum(Convert.ToInt32(tb1.Rows[t][0].ToString()), oils_types.Rows[x][2].ToString(), oils_types.Rows[x][17].ToString(), oils_types.Rows[x][18].ToString()));
                }
                final.Add("END");
            }
               
           
            
           
            return final;
        }
        public string check_oil_consum(int equ_id, string oil_type,string hours, string amount)
        {
            string main_type2 = "Add";
            string oil_aalert = "Ignore";
            if (ma.Find_work_hours(equ_id))
            {
                int hours_now2 = ma.main_periodnum;
                decimal hours_now = hours_now2 -Convert.ToDecimal(hours);
                string query2 = "select * From oil Where equ_id= '" + equ_id + "' AND oil_type= '" + oil_type + "'  AND main_type = '" + main_type2 + "' AND oil_alert != '" + oil_aalert + "'AND oil_state >= '" + hours_now + "'";
                DataTable tb_more = Searchoil(query2);
                if (tb_more.Rows.Count > 0)
                {
                    decimal tot = 0;
                    for (int a = 0; a < tb_more.Rows.Count; a++)
                    {
                        tot = tot + Convert.ToDecimal(tb_more.Rows[a][4].ToString());
                    }
                    string states = "";
                    if (tot >= Convert.ToDecimal(amount))
                    {
                        states = "Red<#>" + oil_type + ": " + tot + " L Added in the Last " + hours + " Working Hours"; return states;
                    }
                    else
                    {
                        states = "Green<#>"; return states;
                    }
                }
                else
                {
                    return "Green<#>";
                }
            }
            else
            {
                return "Black<#><##>This Equipment Does not have Hours Counter";
            }
        }
      
        public string ignore(string equ_id22)
        {
            int equ_id = eq.Search_equ_by_name(equ_id22);
            string xcw = "Success";
            string main_type2 = "Add";
            if (ma.Find_work_hours(equ_id))
            {
                int hours_now2 = ma.Find_work_hours_int(equ_id);
                decimal hours_now = hours_now2 - 50;
                string query2 = "select * From oil Where equ_id= '" + equ_id + "' AND main_type = '" + main_type2 + "'AND oil_state >= '" + hours_now + "'";
                DataTable tb2 = Searchoil(query2);
                
                for (int i = 0; i < tb2.Rows.Count; i++)
                {
                    this.oil_id = Convert.ToInt32(tb2.Rows[i][0].ToString());
                    this.equ_id = Convert.ToInt32(tb2.Rows[i][1].ToString());
                    this.oil_type = tb2.Rows[i][2].ToString();
                    this.oil_name = tb2.Rows[i][3].ToString();
                    this.oil_cap = Convert.ToDecimal(tb2.Rows[i][4].ToString());
                    this.oil_cost = Convert.ToInt32(tb2.Rows[i][5].ToString());
                    this.oil_date = Convert.ToDateTime(tb2.Rows[i][6].ToString());
                    this.user_id = Convert.ToInt32(tb2.Rows[i][7].ToString());
                    this.oil_replacements = tb2.Rows[i][8].ToString();
                    this.main_type = tb2.Rows[i][9].ToString();
                    this.oil_state = Convert.ToDecimal( tb2.Rows[i][10].ToString());
                    this.oil_alert = "Ignore";
                    this.main_id = Convert.ToInt32(tb2.Rows[i][12].ToString());
                    if (u() == true)
                    {
                    }
                    else { xcw = "Failed"; }
                }
            }
            return xcw;
        }
        public DataTable Find_oil_show_search(bool equ_state, int equ_id, DateTime main_date_old, DateTime main_date_new,
            bool typeee, List<string> types, bool stat,string[] states)
        {
            DataTable tbl = new DataTable();
            DataTable tb2 = new DataTable();
            bool date_state = true;
            string type1 = "Add";
            string type2 = "ReFill";

            if (equ_state == true)
            {
                string query = "SELECT * From oil Where (equ_id= '" + equ_id + "') AND (main_type ='" + type1 + "' or main_type ='" + type2 + "') ORDER BY oil_date";
                tbl = Search(query);
                int x = tbl.Rows.Count;
            }
            else
            {
                    string query = "select * From oil where main_type ='" + type1 + "' or main_type ='" + type2 + "' ORDER BY oil_date";
                    tbl = Search(query);
            }
            if (date_state == true)
            {
                DataRow[] resul = tbl.Select(" oil_date >= #" + main_date_old + "# AND  oil_date <= #" + main_date_new + "#");
                tb2 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb2.Rows.Add(row.ItemArray);
                }
                tbl = tb2;
            }
            if (typeee == true && types.Count>1)
            {
                string gd = " oil_type = '" + types[0] + "'";
                for (int i = 1; i < types.Count; i++)
                {
                    types[i] = " oil_type = '" + types[i] + "' ";
                }
                for (int i = 1; i < types.Count; i++)
                {
                    gd = gd +" OR "+ types[i];
                }
                DataRow[] resul = tbl.Select(gd);
                tb2 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb2.Rows.Add(row.ItemArray);
                }
                tbl = tb2;
            }
            if (stat == true)
            {
                string gd =  " main_type = '" + states[0] + "' ";
                for (int i = 0; i < states.Length; i++)
                {
                    states[i] = " main_type = '" + states[i] + "' ";
                }
                for (int i = 1; i < states.Length; i++)
                {
                    gd = gd + " OR " + states[i];
                }
                DataRow[] resul = tbl.Select(gd);
                tb2 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb2.Rows.Add(row.ItemArray);
                }
                tbl = tb2;
            }
            tbl.Columns.Add("Maintenance Type");
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i][12].ToString() != "0" && tbl.Rows[i][12].ToString() != null && tbl.Rows[i][12].ToString() != "")
                {
                    int dd = Convert.ToInt32(tbl.Rows[i][12].ToString());
                    string query55 = "select main_type_name From maintain Where main_id= '" + dd + "'";
                    DataTable tb55 = Search(query55);
                    if (tb55.Rows.Count > 0)
                    {
                        string typ = tb55.Rows[0][0].ToString();
                        if (typ.Contains("Periodic Maintenance"))
                        {
                            string num = tb55.Rows[0][0].ToString();
                            string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                            typ = part2[0];
                        }
                        tbl.Rows[i]["Maintenance Type"] = typ;
                    }
                    else
                    {
                        tbl.Rows[i]["Maintenance Type"] = "Not Found";
                    }
                }
                else
                {
                    tbl.Rows[i]["Maintenance Type"] = "";
                }
            }



            return tbl;
        }
        public string cal_cost_per(int eqi_id)
        {
            decimal tot = 0;
            string query2 = "select * From oil Where equ_id= '" + eqi_id + "' AND main_type != 'Catalogue'";
            DataTable tb2 = Searchoil(query2);
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                tot = tot + Convert.ToInt32(tb2.Rows[i][5].ToString());
            }
            int hoo = 0;
            string query1 = "select * From equ_work_h Where equ_id= '" + eqi_id + "'";
            DataTable tb1 = Searchoil(query1);
            for (int i = 0; i < tb1.Rows.Count; i++)
            {
                hoo = hoo + Convert.ToInt32(tb1.Rows[i][2].ToString());
            }
            if (hoo == 0) { hoo = 1; }
            decimal gg = tot / hoo;
            return gg.ToString("0.##") +" L";
        }
        public string cal_cos(int equ_id,List<string> ch,bool main_with, bool main_without, DateTime olddd , DateTime newww)
        {
            string ss = "";
            if (equ_id != -1)
            {
                ss = "equ_id= '" + equ_id + "' AND ";
            }
            decimal tot = 0;
            for (int i = 0; i < ch.Count; i++)
            {
                int dd = 0;
                string query2 = "select * From oil Where "+ ss +" main_type != 'Catalogue' AND oil_type= '" + ch[i] + "'AND oil_date >= '" + olddd + "' AND  oil_date <= '" + newww + "'";
                if (main_with == true && main_without == false)
                {
                    query2 = query2 + "And main_id >'"+ dd +"'";
                }
                else if (main_without == true && main_with == false)
                {
                    query2 = query2 + " AND main_id ='" + dd + "'";
                }
                DataTable tb2 = Searchoil(query2);
                for (int q = 0; q < tb2.Rows.Count; q++)
                {
                    tot = tot + Convert.ToInt32(tb2.Rows[q][5].ToString());
                }
            }
            return tot.ToString();
        }

        public string cal_cos2(string eqi_id,string oil_type, DateTime olddd, DateTime newww)
        {
            decimal tot_lit = 0; decimal hou = 0;
            decimal tot_cost = 0; DataTable hours;
            string query2 = "select oil_cap,oil_cost From oil Where main_type != 'Catalogue' AND oil_date >= '" + olddd + "' AND oil_date <= '" + newww + "'AND oil_type = '" + oil_type + "'";
           //     AND oil_type = '" + ch[i] + "'
            if (Convert.ToInt32(eqi_id) != -99)
            {
                query2 = query2 + " And equ_id= '" + Convert.ToInt32(eqi_id) + "'";
                string query1 = "select * From equ_work_h Where equ_id= '" + eqi_id + "' AND [date] >= '" + olddd + "' AND [date] <= '" + newww + "'";
                hours = Searchoil(query1);
                for (int i = 0; i < hours.Rows.Count; i++)
                {
                    hou = hou + Convert.ToInt32(hours.Rows[i][2].ToString());
                }
            }
            else
            {
                var dayss = (newww - olddd).Days;
                hou = Convert.ToInt32(dayss)*24;
            }
            DataTable tb2 = Searchoil(query2);
            for (int q = 0; q < tb2.Rows.Count; q++)
            {
                tot_lit = Convert.ToDecimal(tot_lit) + Convert.ToDecimal(tb2.Rows[q][0].ToString());
                //tot_cost = tot_cost + Convert.ToInt32(tb2.Rows[q][1].ToString());
            }
            if (hou == 0) { hou = 1; }
            decimal gg = tot_lit / hou;
            return gg.ToString("0.###")+" Li/H"/* +"<#>"+ tot_cost.ToString()*/;
        }
        public string calcl (int equ_id,DateTime old, DateTime now)
        {
            string ss = "";
            if(equ_id != -1)
            {
                ss = "equ_id= '" + equ_id + "' AND ";
            }
            string query1 = "select filt_cost From filter Where "+ss+" [filt_date] >= '" + old + "' AND [filt_date] <= '" + now + "'And filt_active != 'Catalogue'";
            DataTable filters = Search(query1);

            string query2 = "select fuel_cost From fuel Where " + ss + " [fuel_date] >= '" + old + "' AND [fuel_date] <= '" + now + "'And fuel_active != 'Catalogue'";
            DataTable fuels = Search(query2);

           
            string main_state1 = "new";
            string main_state2 = "All Work Hours";
            string main_state3 = "Daily Check";
            
            string query3 = "select main_cost,labors_cost From maintain Where " + ss + " [main_date] >= '" + old + "' AND [main_date] <= '" + now + "'" +
                " AND [main_state] != '" + main_state1 + "' AND [main_state] != '" + main_state2 + "' AND [main_state] != '" + main_state3 + "'";
            DataTable maintains = Search(query3);
            int i2o = maintains.Rows.Count;
            string query4 = "select oil_cost From oil Where " + ss + " [oil_date] >= '" + old.ToShortDateString() + "' AND [oil_date] <= '" + now.ToShortDateString() + "' And main_type != 'Catalogue'";
            DataTable oils = Search(query4);
            string query5 = "select labor_cost From worksalmob Where " + ss + " [date] >= '" + old.ToShortDateString() + "'AND [date] <= '" + now.ToShortDateString() + "'";
            DataTable tech = Search(query5);
            int total = 0;
            for (int q = 0; q < filters.Rows.Count; q++)
            {
                total = total + Convert.ToInt32(filters.Rows[q][0].ToString());
            }
            for (int q = 0; q < fuels.Rows.Count; q++)
            {
                total = total + Convert.ToInt32(fuels.Rows[q][0].ToString());
            }
            for (int q = 0; q < oils.Rows.Count; q++)
            {
                total = total + Convert.ToInt32(oils.Rows[q][0].ToString());
            }
            for (int q = 0; q < maintains.Rows.Count; q++)
            {
                total = total + Convert.ToInt32(maintains.Rows[q][0].ToString());
            }
            for (int q = 0; q < tech.Rows.Count; q++)
            {
                total = total + Convert.ToInt32(tech.Rows[q][0].ToString());
            }
            return total.ToString();
        }
        public string get_last_id(string oil_id,string name)
        {
            string query = " select Max("+ oil_id + ") from "+ name ;
            DataTable tbl = Search(query);

            return tbl.Rows[0][0].ToString();
        }
    }
}

