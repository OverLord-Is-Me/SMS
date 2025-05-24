using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace notfinal
{
    class equ_work_h : print_ecxel_report
    {
        #region MyRegion
        maintain ma = new maintain();
        private int _count_id;
        private int _equ_id;
        private int _hours;
        private DateTime _date;
        private int _counter;
        private DataTable _test;
        public DataTable test
        {
            get
            { return _test; }
            set
            { _test = value; }
        }
        public int count_id
        {
            get
            { return _count_id; }
            set
            { _count_id = value; }
        }
        public int counter
        {
            get
            { return _counter; }
            set
            { _counter = value; }
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
        #endregion

        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("count_id", count_id);
            SL.Add("equ_id", equ_id);
            SL.Add("hours", hours);
            SL.Add("date", date);
            SL.Add("counter", counter);

            if (DB.RunProcrduer("proequ_work_h", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public DataTable Search_equ_work_h(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch { return new DataTable(); }

        }
        public string Add_equ_work_h(int equ_id, int hours, DateTime date2, int counter)
        {
            string query1 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date >'" + date2.Date + "'ORDER BY date";
            DataTable tb1 = Search_equ_work_h(query1);
            if (tb1.Rows.Count > 0)
            {
                DataView dv = tb1.DefaultView;
                dv.Sort = "date asc";
                DataTable sortedDT = dv.ToTable();
                tb1 = sortedDT;
                int hiher = Convert.ToInt32(tb1.Rows[0][4].ToString());
                int hiher_hours = Convert.ToInt32(tb1.Rows[0][2].ToString());
                if (hours >= (hiher - hiher_hours))
                {
                    return "Can Not Insert Counter Higher Than A counter in Future Date";// + "\n" + "Please Write Lower Counter Than ( " + tb1.Rows[0][4].ToString() + " )";
                }
                if ((counter - hours) == 0)
                {
                    return "Can Not Insert Counter Higher Than A counter in Future Date"; //+ "\n" + "Please Write Lower Counter Than ( " + tb1.Rows[0][4].ToString() + " )";
                }
            } //higher
            string query2 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date <'" + date2.Date + "'ORDER BY date";
            DataTable tb2 = Search(query2);
            if (tb2.Rows.Count > 0)
            {
                DataView dv = tb2.DefaultView;
                dv.Sort = "date asc";
                DataTable sortedDT = dv.ToTable();
                tb2 = sortedDT; 
                int rr = tb2.Rows.Count - 1;
                int lower = Convert.ToInt32(tb2.Rows[rr][4].ToString());
                if (counter < lower)
                {
                    return "Can Not Insert Counter Lower Than A counter in Past Date" + "\n" + "Please Write Higher Counter Than ( " + tb2.Rows[tb2.Rows.Count - 1][4].ToString() + " )";
                }
            } //lower

            
            string query3 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date <='" + date2.Date + "'ORDER BY date";
            DataTable tb3 = Search(query3);
            //DataView dv2 = tb3.DefaultView;
            //dv2.Sort = "date DESC";
            //DataTable sortedDT2 = dv2.ToTable();
            //tb3 = sortedDT2;
            int days = 0;
            DateTime last = DateTime.Now;
            int avr = 0;
            int last_counter = 0;
            bool kmm = ma.if_km(equ_id);
            if (tb3.Rows.Count > 0)
            {
                test = tb3;
                last = Convert.ToDateTime(tb3.Rows[tb3.Rows.Count -1][3].ToString());
                last_counter = Convert.ToInt32(tb3.Rows[tb3.Rows.Count - 1][4].ToString());
                hours = counter - last_counter;
                days = Convert.ToInt32((date2 - last).Days);
                if (days == 0 || days == 1)
                {
                    string kk = "Hours";
                    int dw = 1;
                    int heq = 24;
                    if (kmm)
                    {
                        kk = "Kilometers"; 
                        dw = 83;
                        heq = 2000;
                    }


                    int av2 = ma.ava_hours(equ_id, Convert.ToDateTime(date2.Date));
                    int av = heq - (Convert.ToInt32(ma.main_hours_repair)* dw) ;


                    if (av < hours)
                    {
                        return "Failed: Inserted "+ kk + " is more than Available " + kk + " For this Day" + "\n" + "Available " + kk + " = " + av;
                    }
                    else
                    {
                        string query9= "select * From equ_work_h Where equ_id='" + equ_id + "' AND date ='" + date2.Date + "'";
                        DataTable tb9 = Search(query9);
                        for (int i = 0; i < tb9.Rows.Count; i++)
                        {
                            del_equ_work_h(Convert.ToInt32(tb9.Rows[i][0].ToString()));
                        }
                        this.equ_id = equ_id;
                        this.hours = hours;
                        this.date = date2;
                        this.counter = counter;
                        if (a() == true)
                        {
                            return "Success";
                        }
                        else { return "Failed"; }
                    }
                }   //if 1 day only
                else
                {
                    int av_last = ma.ava_hours(equ_id, Convert.ToDateTime(last.Date));
                    int all_av = 0;
                    for (int i = 1; i <= days; i++)
                    {
                        all_av = all_av + ma.ava_hours(equ_id, Convert.ToDateTime(last.Date.AddDays(i)));
                    }
                    if (hours > all_av)
                    {
                        string ho = "Hours";
                        string ho2 = "24";
                        if (kmm)
                        {
                            ho = "Kilometers";
                            ho2 = "2000";
                        }
                        string zeo = "\n" + "Note// You Have Available " + ho + " = " + av_last + " in Day " + last.ToShortDateString() + " You Can Edit it First";
                        if (av_last == 0)
                        {
                            zeo = "";
                        }
                        return "Failed: Inserted " + ho + " is more than Missing Days Available " + ho + "( " + ho2 + " per Day Without Maintenance hours )" + "\n" + "Available " + ho + " = " + all_av + zeo;
                    }
                }  //calc ava check multi days
            }
            else
            {
                days = -1;
                //if (kmm)
                //{
                //    days = hours / 2000;
                //    if ((days * 2000) < hours)
                //    {
                //        days = days + 1;
                //    }
                //}
                //else
                //{
                //    days = hours / 24;
                //    if ((days * 24) < hours)
                //    {
                //        days = days + 1;
                //    }
                //}
            } //no last day (-1)
            int hoors = 24;
            if (kmm)
            {
                hoors = 2000;
            }

                string st = "Success";
                if (days == -1)
                {
                    while (counter > 0)
                    {
                        int x = ma.ava_hours(equ_id, Convert.ToDateTime(date2.Date));
                        if(counter < hoors)
                        {
                            x = counter;
                        }
                        this.equ_id = equ_id;
                        this.hours = x;
                        this.date = date2;
                        this.counter = counter;
                        if (a() == false)
                        {
                            st = "Failed";
                        }
                        date2 = date2.AddDays(-1);
                        counter = counter - this.hours;
                    }
                }
                else
                {
                    if((days * hoors) > hours)
                    {
                        avr = hours / days;
                        int backy = hours - (avr * days);
                        while (days != 0)
                        {

                            this.equ_id = equ_id;
                            this.hours = avr;
                            this.date = date2;
                            this.counter = counter;
                            if (a() == false)
                            {
                                st = "Failed";
                            }
                            date2 = date2.AddDays(-1);
                            counter = counter - avr;
                            days = days - 1;
                            //hours = hours - avr;
                            if (days == 1 && backy > 0)
                            {
                                avr = avr + backy;
                            }
                        }
                    }
                }
            //int iF_baky = hours % days;

            //avr = hours / days;
            //if (iF_baky > 0)
            //{
            //    days--;
            //}
            //int backy = hours - (avr * days);
            //while (backy > 2000 && avr<2000)
            //{
            //    avr = avr + 1;
            //    backy = hours - (avr * days);
            //} 
            //while (backy > 2000)
            //{
            //    days = days + 1;
            //    avr = hours / days;
            //    backy = hours - (avr * days);
            //}

            //if (iF_baky > 0)
            //{
            //    days++;
            //}
            //while (days != 0)
            //{

            //    this.equ_id = equ_id;
            //    this.hours = avr;
            //    this.date = date2;
            //    this.counter = counter;
            //    if (Add() == true)
            //    {

            //    }
            //    else { st = "Failed"; }
            //    date2 = date2.AddDays(-1);
            //    counter = counter - avr;
            //    days = days - 1;
            //    hours = hours - avr;
            //    if (days == 1 && iF_baky > 0)
            //    {
            //        avr = backy;
            //    }
            //}
            return st;
            if (false)
            {  


            }
            else if (false)
            {
                #region hours

                int iF_baky = hours % days;

                avr = hours / days;
                if (iF_baky > 0)
                {
                    days--;
                }
                int backy = hours - (avr * days);
                while (backy > 24)
                {
                    avr = avr + 1;
                    backy = hours - (avr * days);
                } while (backy > 24)
                {
                    days = days + 1;
                    avr = hours / days;
                    backy = hours - (avr * days);
                }
                st = "Success";
                if (iF_baky > 0)
                {
                    days++;
                }
                while (days != 0)
                {

                    this.equ_id = equ_id;
                    this.hours = avr;
                    this.date = date2;
                    this.counter = counter;
                    if (a() == true)
                    {

                    }
                    else { st = "Failed"; }
                    date2 = date2.AddDays(-1);
                    counter = counter - avr;
                    days = days - 1;
                    hours = hours - avr;
                    if (days == 1 && iF_baky > 0)
                    {
                        avr = backy;
                    }
                }
                #endregion




                return st;
            }
        }
        public int get_lower_hours_counter(int equ_id, DateTime date2)
        {
            string query2 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date <'" + date2.Date + "' ORDER BY date";
            DataTable tb2 = Search(query2);
            if (tb2.Rows.Count > 0)
            {
                //tb2.DefaultView.Sort = "date asc";
                int rr = tb2.Rows.Count - 1;
                return Convert.ToInt32(tb2.Rows[rr][4].ToString());
            }
            else
            {
                return 0; /*ma.Find_work_hours_int(equ_id);*/
            }
        }
        public string update_equ_work_h(int equ_id, int hours, DateTime date2, int counter)
        {
            #region MyRegion
            //ma.ava_hours(equ_id, Convert.ToDateTime(date2.Date));
            //int av = 24 - ma.main_hours_repair;
            //if (av < hours)
            //{
            //    return "Failed: Inserted Hours is more than Available Hours For this Day"+"\n"+ "Available Hours= "+ av;
            //} 


            //string query1 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date >'" + date2.Date + "'";
            //DataTable tb1 = Search_equ_work_h(query1);
            //if (tb1.Rows.Count > 0)
            //{
            //    tb1.DefaultView.Sort = "date asc";
            //    int ee = Convert.ToInt32(tb1.Rows[0][4].ToString());
            //    if (now_counter > ee)
            //    {
            //        return "Can Not Insert Counter Higher Than A counter in Future Date" + "\n" + "Please Write Lower Counter Than ( " + tb1.Rows[0][4].ToString() + " )";
            //    }
            //}
            //string query2 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date <'" + date2.Date + "'";
            //DataTable tb2 = Search(query2);
            //if (tb2.Rows.Count > 0)
            //{
            //    tb2.DefaultView.Sort = "date asc";
            //    int rr = tb2.Rows.Count - 1;
            //    int ee = Convert.ToInt32(tb2.Rows[rr][4].ToString());
            //    if (now_counter < ee)
            //    {
            //        return "Can Not Insert Counter Lower Than A counter in Past Date" + "\n" + "Please Write Higher Counter Than ( " + tb2.Rows[tb2.Rows.Count - 1][4].ToString() + " )";
            //    }
            //}


            //int iid;
            //int total;
            //int final = counter_hours - counter;
            //if (ma.Find_work_hours(equ_id))
            //{
            //    //iid = ma.main_id;
            //    //total = ma.main_periodnum;
            //    //string sdf = ma.Modify_hours(iid, equ_id, total, final);
            //    //if (sdf == "Failed")
            //    //{
            //    //    return "Failed";
            //    //}
            //}
            //else
            //{
            //    return "Failed";
            //}
            #endregion


            string query3 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date ='" + date2.Date + "'";
            DataTable tb3 = Search(query3);
            for (int i = 0; i < tb3.Rows.Count; i++)
            {
                del_equ_work_h(Convert.ToInt32(tb3.Rows[i][0].ToString()));
            }
            return Add_equ_work_h(equ_id, hours, date2, counter);
        }
        public bool del_equ_work_h(int count_id)
        {
            this.count_id = count_id;
            if (q() == true)
            {
                return true;
            }
            else { return false; }
        }
        public string del_equ_work_h(DateTime date, int equ_id, int hours)
        {
            string query3 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date ='" + date.Date + "'";
            DataTable tb3 = Search(query3);
            string st = "";
            for (int i = 0; i < tb3.Rows.Count; i++)
            {  
                if (del_equ_work_h(Convert.ToInt32(tb3.Rows[i][0].ToString()))) 
                {

                } 
                else { st= "Failed"; }
            }
            if (st == "")
            {
                
                if (ma.Find_work_hours(equ_id))
                {
                    int iid = ma.main_id;
                    string sdf = ma.Modify_hours(iid, equ_id, date);
                    if (sdf == "Failed")
                    {
                        return "Failed";
                    }
                }
                else
                {
                    return "Failed";
                }
                return "Success";
            }
            else { return "Please Try Again"+"\n"+"If Still Geting This message Please Contact With Developer" + "\n" +"Error Code: V2"; }
        }
        public string del_equ_work_h()
        {
            string query = " select Max(count_id) from equ_work_h";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count != 0)
            {
                this.count_id = Convert.ToInt32(tbl.Rows[0][0].ToString());

                if (q() == true)
                {
                    return "Success";
                }
                else { return "Failed"; }
            }
            else { return "Failed"; }

        }
        public DataTable Find_equ_work_h(int equ_id)
        {
            string query = "select * From equ_work_h Where equ_id = '" + equ_id + "'";
            DataTable tbl = Search(query);
            return tbl;           
        }
        public DataTable Find_equ_work_h(int equ_id, DateTime date_old, DateTime date_new)
        {
            string query = "select * From equ_work_h Where equ_id= '" + equ_id + "' AND  date >= '" + date_old + "'AND  date <= '" + date_new + "'";
            return Search_equ_work_h(query);
        }   
        public int get_behind_hours(int equ_id,DateTime date_now,int hours_now)
        {
            string query = "select hours From equ_work_h Where equ_id = '" + equ_id + "' and date >'"+ date_now + "'";
            DataTable tbl = Search(query);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                hours_now = hours_now - Convert.ToInt32(tbl.Rows[i][0].ToString());
            }
            return hours_now;
        }
        public bool dell(int equ_id)
        {
            string query3 = "select * From equ_work_h Where equ_id='" + equ_id + "'";
            DataTable tb3 = Search(query3);
            for (int i = 0; i < tb3.Rows.Count; i++)
            {
                del_equ_work_h(Convert.ToInt32(tb3.Rows[i][0].ToString()));
            }
            ma.Find_work_hours(equ_id);
            int ss = ma.main_id;
            ma.Modify_hours(ss, equ_id, DateTime.Now);

            return true;
        }
        public DataTable available(int equ_id, DateTime main_date_old, DateTime main_date_new)
        {
            int main_typeew = -3;
            int main_typeew2 = -4; 
            int x = 24;
            string wo = "Hours";
            int cla = 1;
            if (ma.if_km(equ_id))
            {
                cla =83;
                x = 2000; 
                wo = "Km";
            }
            DataTable tbl = new DataTable();
            DataTable tb2 = new DataTable();
            DataTable tb3 = new DataTable();
            tb2.Columns.Add("Date");
            tb2.Columns.Add("Available " + wo);
            tb2.Columns.Add("Maintenance " + wo);
            tb2.Columns.Add("Availability %");
            DataRow dr = null;
            string main_state1 = "new";
            string main_state2 = "All Work Hours";
            string query = "select * From maintain Where equ_id = '" + equ_id + "' AND main_date >= '" + main_date_old + "'AND  main_date <= '" + main_date_new + "' AND  main_state != '" + main_state1 + "' AND  main_state != '" + main_state2 + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "' ORDER BY main_date";
            tbl = Search(query);
            var dayss = (main_date_new - main_date_old).Days;
            int days = Convert.ToInt32(dayss);
            for (int a = 0; a <= days; a++)
            {
                DateTime s = main_date_old.AddDays(a);
                DataRow[] resul = tbl.Select(" main_date = #" + s + "#");
                tb3 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb3.Rows.Add(row.ItemArray);
                }
                double tot = 0;
                for (int i = 0; i < tb3.Rows.Count; i++)
                {
                    tot = tot + Convert.ToDouble(tb3.Rows[i][12].ToString());
                }
                dr = tb2.NewRow();

                dr["Date"] = s.ToShortDateString();
                dr["Available " + wo] = x - (tot * cla);
                dr["Maintenance " + wo] = tot;
                dr["Availability %"] = ((x - (tot * cla)) / x) * 100;
                tb2.Rows.Add(dr);
            }
            return tb2;
        }
        public DataTable usability(int equ_id, DateTime main_date_old, DateTime main_date_new)
        {
            DataTable tbl = new DataTable();
            DataTable tb2 = new DataTable();
            DataTable tb3 = new DataTable();
            string wo = "Hours";
            int calc = 1;
            int x = 24;
            if (ma.if_km(equ_id))
            {
                calc = 83;
                x = 2000;
                wo = "Km";
            }
            tb2.Columns.Add("Date");
            tb2.Columns.Add("Used "+wo);
            tb2.Columns.Add("Counter");
            DataRow dr = null;
            string query = "select * From equ_work_h Where equ_id = '" + equ_id + "' AND [date] >= '" + main_date_old + "'AND  [date] <= '" + main_date_new + "' ORDER BY date";
            tbl = Search(query);
            var dayss = (main_date_new - main_date_old).Days;
            int days = Convert.ToInt32(dayss);
            for (int a = 0; a <= days; a++)
            {
                DateTime s = main_date_old.AddDays(a);
                DataRow[] resul = tbl.Select(" [date] = #" + s + "#");
                tb3 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb3.Rows.Add(row.ItemArray);
                }
                int tot = 0;
                for (int i = 0; i < tb3.Rows.Count; i++)
                {
                    tot = tot + Convert.ToInt32(tb3.Rows[i][2].ToString());
                }
                dr = tb2.NewRow();
                dr["Date"] = s.ToShortDateString();
                dr["Used "+wo] = tot;

                if (tb3.Rows.Count > 0)
                {
                    DataView dv = tb3.DefaultView;
                    dv.Sort = "date asc";
                    DataTable sortedDT = dv.ToTable();
                    tb3 = sortedDT;

                    dr["Counter"] = tb3.Rows[tb3.Rows.Count - 1][4].ToString();
                }
                else
                {
                    dr["Counter"] = "No Data";
                }
                tb2.Rows.Add(dr);
            }
            return tb2;
        }
        

        public DataTable ava_use(DataTable ava, DataTable use, int equ_id)
        {
            string wo = "Hours";
            int x = 24;
            if (ma.if_km(equ_id))
            {
                x = 2000;
                wo = "Km";
            }
            DataTable tb2 = new DataTable();
            tb2.Columns.Add("Date");
            tb2.Columns.Add("Maintenance Hours");
            tb2.Columns.Add("Availabile " + wo);
            tb2.Columns.Add("Worked " + wo);
            tb2.Columns.Add("Availability");
            tb2.Columns.Add("Utilization");
            tb2.Columns.Add("Counter");
            DataRow dr = null;
            for (int i = 0; i < ava.Rows.Count; i++)
            {
                dr = tb2.NewRow(); // have new row on each iteration
                dr["Date"] = ava.Rows[i][0].ToString();
                dr["Maintenance Hours"] = ava.Rows[i][2].ToString();
                dr["Availabile " + wo] = x - Convert.ToInt32(ava.Rows[i][2].ToString());
                dr["Worked " + wo] = use.Rows[i][1].ToString();
                dr["Availability"] = Math.Round(Convert.ToDouble(ava.Rows[i][3].ToString()), 2, MidpointRounding.ToEven) + "%";
                double w = Convert.ToDouble(use.Rows[i][1].ToString());
                double e = Convert.ToDouble(x - Convert.ToInt32(ava.Rows[i][2].ToString()));
                double gg = (w / e) * 100;
                gg = Math.Round(gg, 2, MidpointRounding.ToEven);
                string eee = gg.ToString();
                dr["Utilization"] = eee + "%";
                dr["Counter"] = use.Rows[i][2].ToString();
                //if (Convert.ToInt32(ava.Rows[i][3].ToString()) == 0/*Convert.ToInt32(ava.Rows[i][1].ToString()) == 24 && Convert.ToInt32(use.Rows[i][1].ToString()) == 0 && */)
                //{
                //    dr["Counter"] = "No Data";
                //}
                //else
                //{
                //}
                tb2.Rows.Add(dr);
            }
            //equ_work_h equ_work = new equ_work_h();
            //for (int i = 0; i < tb2.Rows.Count; i++)
            //{
            //    if (tb2.Rows[i]["Counter"].ToString() != "No Data")
            //    {
            //        int hours = ma.Find_work_hours_int(equ_id);
            //        int hou = equ_work.get_behind_hours(equ_id, Convert.ToDateTime(tb2.Rows[i]["Date"].ToString()), hours);
            //        tb2.Rows[i]["Counter"] = hou;
            //    }
            //}
            return tb2;
        }

    }


    
}