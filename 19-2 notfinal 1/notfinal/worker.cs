using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace notfinal
{
    class worker : print_ecxel_report
    {
        #region MyRegion
        private int _worker_id;
        private string _worker_name;
        private int _salary;
        private int _work_hours_per_m;
        private int _workers_count;
        public int workers_count
        {
            get
            { return _workers_count; }
            set
            { _workers_count = value; }
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
        public int salary
        {
            get
            { return _salary; }
            set
            { _salary = value; }
        }
        public int work_hours_per_m
        {
            get
            { return _work_hours_per_m; }
            set
            { _work_hours_per_m = value; }
        }
        #endregion

        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("worker_id", worker_id);
            SL.Add("worker_name", worker_name);
            SL.Add("salary", salary);
            SL.Add("work_hours_per_m", work_hours_per_m);

            if (DB.RunProcrduer("proworker", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public DataTable Search_worker(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch { return new DataTable(); }
        }
        public string Add_worker(string worker_name, int salary, int work_hours_per_m)
        {
            this.worker_id = 2;
            this.worker_name = worker_name;
            this.salary = salary;
            this.work_hours_per_m = work_hours_per_m;

            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string update_worker(int worker_id, string worker_name, int salary, int work_hours_per_m)
        {
            this.worker_id = worker_id;
            this.worker_name = worker_name;
            this.salary = salary;
            this.work_hours_per_m = work_hours_per_m;

            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string del_worker(int worker_id)
        {
            this.worker_id = worker_id;
            if (q() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }    
        public DataTable Find_worker(int salary_low, int salary_high)
        {
            string query = "select * From worker Where salary >= '" + salary_low + "'AND  salary <= '" + salary_high + "'";
            return Search_worker(query);
        }
        public int bring_worker_id(string worker_name)
        {
            string query = "select * From worker Where worker_name = N'" + worker_name + "'";
            DataTable tbl = Search(query);
            int x = 0;
            if (tbl.Rows.Count == 0)
            {
            }
            else
            {
                 x = Convert.ToInt32(tbl.Rows[0][0].ToString());
            }
                
            return x;
        }
        public bool bring_labor_data(int worker_id)
        {
            string query = "select * From worker Where worker_id ='" + worker_id + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.worker_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.worker_name = tbl.Rows[0][1].ToString();
                this.salary = Convert.ToInt32(tbl.Rows[0][2].ToString());
                this.work_hours_per_m = Convert.ToInt32(tbl.Rows[0][3].ToString());
                return true;
            }
        }
        public DataTable bring_labor_names()
        {
            string query = "select worker_id,worker_name From worker";
            DataTable tbl = Search(query);
            this.workers_count = tbl.Rows.Count;
            return tbl;
        }
        public int bring_labor_salary(int worker_id ,string worker_name)
        {
            if (worker_id == 0 && worker_name != "")
            {
                worker_id = bring_worker_id(worker_name);
                this.worker_id = worker_id;
            }
            string query = " select salary from worker where worker_id ='" + worker_id + "'";
            DataTable tbl = Search(query);
            int x = Convert.ToInt32(tbl.Rows[0][0].ToString());
            return x;
        }
    }
}
