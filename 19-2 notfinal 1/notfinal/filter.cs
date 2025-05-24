using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;


namespace notfinal
{
    class filter : print_ecxel_report
    {
        private int _filt_id;
        private int _equ_id;
        private string _filt_type;
        private string _filt_name;
        private int _filt_cap;
        private decimal _filt_cost;
        private DateTime _filt_date;
        private int _user_id;
        private string _filt_replacements;
        private decimal _main_hours;
        private string _filt_active;
        private int _main_id;
        equ eq = new equ();
        #region MyRegion
        public decimal main_hours
        {
            get
            { return _main_hours; }
            set
            { _main_hours = value; }
        }
        public string filt_active
        {
            get
            { return _filt_active; }
            set
            { _filt_active = value; }
        }
        public int main_id
        {
            get
            { return _main_id; }
            set
            { _main_id = value; }
        }
        public string filt_replacements
        {
            get
            { return _filt_replacements; }
            set
            { _filt_replacements = value; }
        }
        public int filt_id
        {
            get
            { return _filt_id; }
            set
            { _filt_id = value; }
        }
        public int equ_id
        {
            get
            { return _equ_id; }
            set
            { _equ_id = value; }
        }
        public string filt_type
        {
            get
            { return _filt_type; }
            set
            { _filt_type = value; }
        }
        public string filt_name
        {
            get
            { return _filt_name; }
            set
            { _filt_name = value; }
        }
        public int filt_cap
        {
            get
            { return _filt_cap; }
            set
            { _filt_cap = value; }
        }
        public decimal filt_cost
        {
            get
            { return _filt_cost; }
            set
            { _filt_cost = value; }
        }
        public DateTime filt_date
        {
            get
            { return _filt_date; }
            set
            { _filt_date = value; }
        }
        public int user_id
        {
            get
            { return _user_id; }
            set
            { _user_id = value; }
        }
        #endregion

        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("filt_id", filt_id);
            SL.Add("equ_id", equ_id);
            SL.Add("filt_type", filt_type);
            SL.Add("filt_name", filt_name);
            SL.Add("filt_cap", filt_cap);
            SL.Add("filt_cost", filt_cost);
            SL.Add("filt_date", filt_date);
            SL.Add("user_id", user_id);
            SL.Add("filt_replacements", filt_replacements);
            SL.Add("main_hours", main_hours);
            SL.Add("filt_active", filt_active);
            SL.Add("main_id", main_id);

            if (DB.RunProcrduer("profilter", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public DataTable Searchfilter(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch { return new DataTable(); }
        }

        public string Addfilt( int equ_id,string filt_type, string filt_name, int filt_cap, decimal filt_cost, DateTime filt_date,
            int user_id,string filt_replacements, decimal main_hours, string filt_active, int main_id)
        {
           //DataTable x= Finddup(equ_id,filt_type);
           // for(int i=0;i<x.Rows.Count;i++)
           // {
           //     old(Convert.ToInt32(x.Rows[i][0].ToString()));
           // }
            
            this.filt_id = 2;
            this.equ_id = equ_id;
            this.filt_type = filt_type;
            this.filt_name = filt_name;
            this.filt_cap = filt_cap;
            this.filt_cost = filt_cost;
            this.filt_date = filt_date;
            this.user_id = user_id;
            this.filt_replacements = filt_replacements;
            this.main_hours = main_hours;
            this.filt_active = filt_active;
            this.main_id = main_id;
            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string delflt(int filt_id)
        {
            work_sal_mob ss = new work_sal_mob();
            if (!ss.del_job("Add Filter",filt_id.ToString()))
            {
                return "Failed";
            }
            this.filt_id = filt_id;
            if (q() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable Find_filt_show_data(int equ_id)
        {
            string filt_active = "Active";
            string query = "select * From filter Where equ_id= '" + equ_id + "'AND  filt_active= '" + filt_active + "'";
            return Searchfilter(query);
        }
        public DataTable Find_filt_show_data_equ(int equ_id)
        {
            string filt_active = "Catalogue";
            string query = "select * From filter Where equ_id= '" + equ_id + "' AND  filt_active= '" + filt_active + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count>0)
            {
                tbl.Columns.Add("Recommended");
                tbl.Columns.Add("Equivalent 1");
                tbl.Columns.Add("Equivalent 2");
                tbl.Columns.Add("Equivalent 3");
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    string all2 = tbl.Rows[i][8].ToString();
                    string[] num2 = System.Text.RegularExpressions.Regex.Split(all2, "<#>");
                    tbl.Rows[i]["Recommended"] = num2[0];
                    tbl.Rows[i]["Equivalent 1"] = num2[1];
                    tbl.Rows[i]["Equivalent 2"] = num2[2];
                    tbl.Rows[i]["Equivalent 3"] = num2[3];
                }
            }
            return tbl;
        }

        public DataTable Find_filter_with_main(string sta)
        {
            int main_id = Convert.ToInt32(sta);
            string query = "select * From filter Where main_id ='" + main_id + "'";
            DataTable tbl = Search(query);
            return tbl;
        }

        public bool Findfilt(int filt_id)
        {  
            string query = "select * From filter Where filt_id ='" + filt_id + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.filt_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.filt_type = tbl.Rows[0][2].ToString();
                this.filt_name = tbl.Rows[0][3].ToString();
                this.filt_cap = Convert.ToInt32(tbl.Rows[0][4].ToString());
                this.filt_cost = Convert.ToDecimal(tbl.Rows[0][5].ToString());
                this.filt_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.filt_replacements = tbl.Rows[0][8].ToString();
                this.main_hours = Convert.ToDecimal(tbl.Rows[0][9].ToString()); ;
                this.filt_active = tbl.Rows[0][10].ToString();
                this.main_id = Convert.ToInt32(tbl.Rows[0][11].ToString());
                return true;
            }
        }
        public DataTable Finddup(int equ_id,string filt_type)
        {
            string filt_active = "Active";
            string query = "select * From filter Where equ_id ='" + equ_id + "' And filt_type ='" + filt_type + "'And filt_active ='" + filt_active + "'";
            DataTable tbl = Search(query);
            return tbl;
        }
        public bool Find_dup_cat(int equ_id, string filt_type)
        {
            string filt_active = "Catalogue";
            string query = "select * From filter Where equ_id ='" + equ_id + "' And filt_type ='" + filt_type + "'And filt_active ='" + filt_active + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.filt_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.filt_type = tbl.Rows[0][2].ToString();
                this.filt_name = tbl.Rows[0][3].ToString();
                this.filt_cap = Convert.ToInt32(tbl.Rows[0][4].ToString());
                this.filt_cost = Convert.ToDecimal(tbl.Rows[0][5].ToString());
                this.filt_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.filt_replacements = tbl.Rows[0][8].ToString();
                this.main_hours = Convert.ToDecimal(tbl.Rows[0][9].ToString()); ;
                this.filt_active = tbl.Rows[0][10].ToString();
                this.main_id = Convert.ToInt32(tbl.Rows[0][11].ToString());
                return true;
            }
        }
        public bool old(int filt_id)
        {
            string query = "select * From filter Where filt_id ='" + filt_id + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                this.filt_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.filt_type = tbl.Rows[0][2].ToString();
                this.filt_name = tbl.Rows[0][3].ToString();
                this.filt_cap = Convert.ToInt32(tbl.Rows[0][4].ToString());
                this.filt_cost = Convert.ToDecimal(tbl.Rows[0][5].ToString());
                this.filt_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.filt_replacements = tbl.Rows[0][8].ToString(); 
                this.main_hours = Convert.ToDecimal(tbl.Rows[0][9].ToString()); 
                this.filt_active = "Active";
                this.main_id = Convert.ToInt32(tbl.Rows[0][11].ToString());

                if (u() == true)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public string updatefilt(int filt_id,
        int equ_id, string filt_type, string filt_name, int filt_cap, decimal filt_cost,
        DateTime filt_date, int user_id, string filt_replacements, decimal main_hours, string filt_active, int main_id)
        {
            this.filt_id = filt_id;
            this.equ_id = equ_id;
            this.filt_type = filt_type;
            this.filt_name = filt_name;
            this.filt_cap = filt_cap;
            this.filt_cost = filt_cost;
            this.filt_date = filt_date;
            this.user_id = user_id;
            this.filt_replacements = filt_replacements;
            this.main_hours = main_hours;
            this.filt_active = filt_active;
            this.main_id = main_id;

            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string delfilterrep(int main_id)
        {
            string st = "Success";
            string query = "select filt_id From filter Where main_id ='" + main_id + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return st;
            }
            else
            {
                for (int x = 0; x < tbl.Rows.Count; x++)
                {
                    this.filt_id = Convert.ToInt32(tbl.Rows[x][0].ToString());
                    if (q() == true)
                    {

                    }
                    else { st = "Failed"; }
                }
            }
            return st;
        }

        public DataTable filt_repotr(DateTime date1, DateTime date2, int equ_id, string oil_type_equ , string oil_type)
        {
            string s1 = "";
            string s2 = "";
            string s3 = "";
            if (equ_id != -1)
            {
                s1 = " And equ_id = '" + equ_id + "' ";
            }
            if (oil_type_equ != "")
            {
                s2 = " And filt_type = '" + oil_type_equ + "' ";
            }

            

            string all = "";
           
            if (equ_id != -1)
            {
                all = s1 + s2;
            }else
            {
                all = s3;
            }
            string filt_active = "Active";
            string query = "select * From filter Where filt_date >='"+ date1 + "'And filt_date <='" + date2 + "' and filt_active ='" + filt_active + "'"+all+ " ORDER BY filt_date";

            if (oil_type != "")
            {
                query = " select * From filter Where filt_active ='" + filt_active + "' And filt_type = '" + oil_type + "' ORDER BY filt_date";
            }



            DataTable dt = Search(query);
            DataTable sss = dt.Clone();
            sss.Columns[1].DataType = typeof(string);
            sss.Columns[11].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                sss.ImportRow(row);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string aa = eq.Searchequ(Convert.ToInt32(sss.Rows[i][1].ToString()));
                sss.Rows[i][1] = aa;
                //string[] part = System.Text.RegularExpressions.Regex.Split(sss.Rows[i][4].ToString(), "<##>");
                //sss.Rows[i][4] = part[0];
            }



            for (int i = 0; i < sss.Rows.Count; i++)
            {
                if (sss.Rows[i]["main_id"].ToString() != "0" && sss.Rows[i]["main_id"].ToString() != null && sss.Rows[i]["main_id"].ToString() != "")
                {
                    int dd = Convert.ToInt32(sss.Rows[i]["main_id"].ToString());
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
                        sss.Rows[i]["main_id"] = typ;
                    }
                    else
                    {
                        sss.Rows[i]["main_id"] = "Not Found";
                    }
                }
                else
                {
                    sss.Rows[i]["main_id"] = "";
                }
            }
            return sss;



        }

        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }
        public DataTable get_all_cata()
        {
            string filt_active = "Catalogue";
            string query = "select * From filter Where filt_active ='" + filt_active + "'";
            DataTable tbl = Search(query);
            return RemoveDuplicateRows(tbl, "filt_type");
        }
        public DataTable get_all_cata2222()
        {
            string filt_active = "Catalogue";
            string query = "select * From filter Where filt_active ='" + filt_active + "'";
            return Search(query);
        }
        public string rep_cost(int equ_id, List<string> lis, DateTime old, DateTime fut)
        {
            string liss = "";
            if (lis.Count == 0 || lis.Count == 2)
            {
                liss = "";
            }
            else if (lis.Count == 1)
            {
                if (lis[0] == "All")
                {
                    liss = " And main_id >'0'";
                }
                else
                {
                    liss = " And main_id ='0'";
                }
            }
            string ss = "";
            if (equ_id != -1)
            {
                ss = "equ_id= '" + equ_id + "' AND ";
            }
            string query2 = "select * From filter Where "+ ss +" filt_active != 'Catalogue' AND filt_date >= '" + old + "'AND filt_date <= '" + fut + "' " + liss;
            DataTable tb2 = Searchfilter(query2);
            double dd = 0;
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                dd = dd + Convert.ToDouble(tb2.Rows[i][5].ToString());
            }
            return dd.ToString();
        }
    }
}







