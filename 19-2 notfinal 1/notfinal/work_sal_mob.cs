using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace notfinal
{
    class work_sal_mob : print_ecxel_report
    {
        #region MyRegion
        private int _report_id;
        private int _main_id;
        private int _worker_id;
        private string _worker_name;
        private int _equ_id;
        private int _hours;
        private DateTime _date;
        private int _salary;
        private string _details;
        private int _labor_cost;
        private string _job_type;
        private string _job_id;

        worker wo = new worker();
        maintain ma = new maintain();
        public string job_type
        {
            get
            { return _job_type; }
            set
            { _job_type = value; }
        }
        public string job_id
        {
            get
            { return _job_id; }
            set
            { _job_id = value; }
        }
        public int labor_cost
        {
            get
            { return _labor_cost; }
            set
            { _labor_cost = value; }
        }
        public int report_id
        {
            get
            { return _report_id; }
            set
            { _report_id = value; }
        }
        public int main_id
        {
            get
            { return _main_id; }
            set
            { _main_id = value; }
        }
        public int worker_id
        {
            get
            { return _worker_id; }
            set
            { _worker_id = value; }
        }
        public string worker_name
        {
            get
            { return _worker_name; }
            set
            { _worker_name = value; }
        }
        public int equ_id
        {
            get
            { return _equ_id; }
            set
            { _equ_id = value; }
        }
        public int hours
        {
            get
            { return _hours; }
            set
            { _hours = value; }
        }
        public DateTime date
        {
            get
            { return _date; }
            set
            { _date = value; }
        }
        public int salary
        {
            get
            { return _salary; }
            set
            { _salary = value; }
        }
        public string details
        {
            get
            { return _details; }
            set
            { _details = value; }
        }
        #endregion
        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("report_id", report_id);
            SL.Add("main_id", main_id);
            SL.Add("worker_id", worker_id);
            SL.Add("worker_name", worker_name);
            SL.Add("equ_id", equ_id);
            SL.Add("hours", hours);
            SL.Add("date", date);
            SL.Add("salary", salary);
            SL.Add("details", details);
            SL.Add("labor_cost", labor_cost);
            SL.Add("job_type", job_type);
            SL.Add("job_id", job_id);

            if (DB.RunProcrduer("proworksalmob", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public string Add_work_reprot(int main_id,int worker_id,string worker_name, int equ_id, int hours, DateTime date, int salary,
            string details, string job_type, string job_id)
        {

            if (worker_id==0 && worker_name!="")
            {
                worker_id =wo.bring_worker_id(worker_name);
            }
            this.report_id = 2;
            this.main_id = main_id;
            this.worker_id = worker_id;
            this.worker_name = worker_name;
            this.equ_id = equ_id;
            this.hours = hours;
            this.date = date;
            this.salary = salary;
            this.details = details;
            this.job_type = job_type;
            this.job_id = job_id;

            int all_hous = all_hours(worker_id);
            decimal all_hou = Convert.ToDecimal(all_hous);
            decimal salar = Convert.ToDecimal(salary);
            decimal hour = Convert.ToDecimal(hours);

            decimal lar_cost = (salar / all_hou) * hour;


            this.labor_cost = Convert.ToInt32(Math.Round(lar_cost, 0, MidpointRounding.AwayFromZero));
            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string Add_job_reprot(int worker_id, string worker_name, int equ_id, int hours, DateTime date,
            string job_type, string job_id)
        {
            this.report_id = 2;
            this.main_id = -1;
            this.worker_id = worker_id;
            this.worker_name = worker_name;
            this.equ_id = equ_id;
            this.hours = hours;
            this.date = date;
            this.details = "No Data";
            this.job_type = job_type;
            this.job_id = job_id;

            int all_hous = all_hours(worker_id);
            decimal all_hou = Convert.ToDecimal(all_hous);
            decimal salar = Convert.ToDecimal(this.salary);
            decimal hour = Convert.ToDecimal(hours);

            decimal lar_cost = (salar / all_hou) * hour;

            this.labor_cost = Convert.ToInt32(Math.Round(lar_cost, 0, MidpointRounding.AwayFromZero));
            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public int all_hours(int worker_id)
        {
            string query = "select work_hours_per_m,salary From worker Where worker_id = '" + worker_id + "'";
            int x = 0;
            DataTable tbl = new DataTable();
            tbl = Search(query);
            this.salary = 0;
            if (tbl.Rows.Count>0)
            {
                x = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.salary = Convert.ToInt32(tbl.Rows[0][1].ToString());
            }
            return x;
        }
        public int sala(int worker_id)
        {
            string query = "select salary From worker Where worker_id = '" + worker_id + "'";
            int x = 0;
            DataTable tbl = new DataTable();
            tbl = Search(query);
            x = Convert.ToInt32(tbl.Rows[0][0].ToString());
            return x;
        }
        public string update_work_reprot(int report_id,int main_id, int worker_id, string worker_name, 
            int equ_id, int hours, DateTime date,int salary, string details, string job_type, string job_id)
        {
            if (main_id != -1)
            {
                string query = "select main_hours_repair From maintain Where main_id = '" + main_id + "'";
                DataTable tbl = Search(query);
                int x = Convert.ToInt32(tbl.Rows[0][0].ToString());
                if (hours > x)
                {
                    return "Can Not Insert Hours Higher Than Maintenance Duration" + "\n" + "Maintenance Duration = " + x.ToString();
                }
            }
            this.report_id = report_id;
            this.main_id = main_id;
            this.worker_id = worker_id;
            this.worker_name = worker_name;
            this.equ_id = equ_id;
            this.hours = hours;
            this.date = date;
            this.salary = salary;
            this.details = details;
            this.job_type = job_type;
            this.job_id = job_id;

            int all_hous = all_hours(worker_id);
            decimal all_hou = Convert.ToDecimal(all_hous);
            decimal salar = Convert.ToDecimal(salary);
            decimal hour = Convert.ToDecimal(hours);

            decimal lar_cost = (salar / all_hou) * hour;


            this.labor_cost = Convert.ToInt32(Math.Round(lar_cost, 0, MidpointRounding.AwayFromZero));
            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string Update_work_reprot(int report_id, string worker_name)
        {
            this.report_id = report_id;
            this.worker_name = worker_name;

            if (m() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable update_work_reprot(int worker_id)
        {
            string query = "select report_id From worksalmob Where worker_id = '" + worker_id + "'";
            return Searchh(query);
        }
        public string del_work_reprot(int report_id)
        {
            string query = "select main_id,labor_cost From worksalmob Where report_id = '" + report_id + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count > 0)
            {
                string query2 = "select * From maintain Where main_id = '" + Convert.ToInt32(tbl.Rows[0][0].ToString()) + "'";
                DataTable tb2 = Search(query2);
                if(tb2.Rows.Count >0)
                {
                    int main_id =           Convert.ToInt32(tb2.Rows[0][0].ToString());
                    int equ_id =            Convert.ToInt32(tb2.Rows[0][1].ToString());
                    int main_type =         Convert.ToInt32(tb2.Rows[0][2].ToString());
                    int main_periodnum =    Convert.ToInt32(tb2.Rows[0][3].ToString());
                    string main_part =                      tb2.Rows[0][4].ToString();
                    string main_state =                     tb2.Rows[0][5].ToString();
                    int main_cost =         Convert.ToInt32(tb2.Rows[0][6].ToString());
                    DateTime main_date = Convert.ToDateTime(tb2.Rows[0][7].ToString());
                    string details =                        tb2.Rows[0][8].ToString();
                    int user_id =           Convert.ToInt32(tb2.Rows[0][9].ToString());
                    string main_type_name =                 tb2.Rows[0][10].ToString();
                    string main_state_details =             tb2.Rows[0][11].ToString();
                    int main_hours_repair = Convert.ToInt32(tb2.Rows[0][12].ToString());
                    int labors_cost8 =      Convert.ToInt32(tb2.Rows[0][13].ToString()) - Convert.ToInt32(tbl.Rows[0][1].ToString());
                    ma.update_main(main_id, equ_id, main_type, main_periodnum, main_part, main_state, main_cost,
                        main_date, details, user_id, main_type_name, main_state_details, main_hours_repair, labors_cost8, "");
                }
            }
            this.report_id = report_id;
            if (q() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string del_all_work_reprot(int main_id)
        {
            try
            {
                DataTable sa = Find_worker_reprot(main_id);
                for (int e = 0; e < sa.Rows.Count; e++)
                {
                    del_work_reprot(Convert.ToInt32(sa.Rows[e][0].ToString()));
                }
                DataTable sa2 = Find_worker_reprot(main_id);
                if (sa2.Rows.Count > 0)
                {
                    for (int e = 0; e < sa2.Rows.Count; e++)
                    {
                        del_work_reprot(Convert.ToInt32(sa.Rows[e][0].ToString()));
                    }
                }
                if (sa2.Rows.Count == 0)
                {
                    return "Success";
                }
                else { return "Failed"; }
            }
            catch { return "Failed"; }
        }
        public bool del_job(string job_type, string job_id)
        {
            try
            {
                string query = "select report_id From worksalmob Where job_type ='" + job_type + "' AND job_id ='" + job_id + "'";
                DataTable sa = Searchh(query);
                for (int e = 0; e < sa.Rows.Count; e++)
                {
                    del_work_reprot(Convert.ToInt32(sa.Rows[e][0].ToString()));
                }
                DataTable sa2 = Searchh(query);
                if (sa2.Rows.Count > 0)
                {
                    for (int e = 0; e < sa2.Rows.Count; e++)
                    {
                        del_work_reprot(Convert.ToInt32(sa.Rows[e][0].ToString()));
                    }
                }
                if (sa2.Rows.Count == 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch { return false; }
        }
        public DataTable Find_worker_reprot(int main_id)
        {
            string query = "select * From worksalmob Where main_id ='" + main_id + "'";
            return Searchh(query);
        }
        public DataTable Find_worsal(int report_id)
        {
            string query = "select * From worksalmob Where report_id ='" + report_id + "'";
            return Searchh(query);
        }
        public DataTable Searchh(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch { return new DataTable(); }

        }
        public DataTable search_lapor /*report page*/(bool lapor_state, int worker_id, bool equ_state, int equ_id,
            bool date_state, DateTime date_old, DateTime date_new)
        {
            DataTable tbl = new DataTable();
            DataTable tb2 = new DataTable();

            if (equ_state == true)
            {
                string query = "select * From worksalmob Where equ_id = '" + equ_id + "'ORDER BY date";
                tbl = Search(query);
            }
            if (lapor_state == true)
            {
                if (equ_state == true)
                {
                    DataRow[] resul = tbl.Select(" worker_id = '" + worker_id + "'");
                    tb2 = tbl.Clone();
                    foreach (DataRow row in resul)
                    {
                        tb2.Rows.Add(row.ItemArray);
                    }
                    tbl = tb2;
                    int x = tbl.Rows.Count;
                }
                else 
                {
                    string query = "select * From worksalmob Where worker_id = '" + worker_id + "'ORDER BY date";
                    tbl = Search(query);
                }
            }
            if (date_state == true)
            {
                if (equ_state == true || lapor_state == true)
                {
                    DataRow[] resul = tbl.Select(" date >= #" + date_old + "# AND  date <= #" + date_new + "#");
                    tb2 = tbl.Clone();
                    foreach (DataRow row in resul)
                    {
                        tb2.Rows.Add(row.ItemArray);
                    }
                    tbl = tb2;
                    int x = tbl.Rows.Count;
                }
                if (equ_state == false && lapor_state == false)
                {
                    string query = "select * From worksalmob Where date >= '" + date_old + "'AND  date <= '" + date_new + "'ORDER BY date";
                    tbl = Search(query);
                    int x = tbl.Rows.Count;
                }

            }

            if (equ_state == false && lapor_state == false && date_state == false)
            {
                string query = "select * From worksalmob ORDER BY date";
                tbl = Search(query);
            }

            int y = tb2.Rows.Count;
            return tbl;
        }
        public string rep_cost(int equ_id, DateTime old, DateTime fut, List<string> lis)
        {
            string ss = "";
            if (equ_id != -1)
            {
                ss = "equ_id= '" + equ_id + "' AND ";
            }
            string typed = "";
            if (lis.Count == 0 || lis.Count == 2)
            {
                typed = "";
            }
            else if (lis.Count == 1)
            {
                if (lis[0] == "All")
                {
                    typed = " And main_id >'-1'";
                }
                else
                {
                    typed = " And main_id ='-1'";
                }
            }
            string query2 = "select * From worksalmob Where "+ ss +" date >= '" + old + "'AND date <= '" + fut + "' "+ typed;
            DataTable tb2 = Searchh(query2);
            double dd = 0;
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                dd = dd + Convert.ToDouble(tb2.Rows[i][9].ToString());
            }
            return dd.ToString();
        }
    }
}
