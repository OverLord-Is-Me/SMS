using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace notfinal
{
    class maintain : print_ecxel_report
    {

        #region MyRegion
        equ eq22 = new equ();
        private int _main_id;
        private int _equ_id;
        private int _main_type;
        private int _main_periodnum;
        private string _main_part;
        private string _main_state;
        private int _main_cost;
        private DateTime _main_date;
        private string _details;
        private int _user_id;
        private DataTable _table;
        private string _main_type_name;
        private string _main_state_details;
        private int _main_hours_repair;
        private int _labors_cost;
        int max_hours;
        int max_main_type;
        int peroid_satge_number;
        int low_hours;

        public int main_id
        {
            get
            { return _main_id; }
            set
            { _main_id = value; }
        }
        public int main_hours_repair
        {
            get
            { return _main_hours_repair; }
            set
            { _main_hours_repair = value; }
        }
        public int labors_cost
        {
            get
            { return _labors_cost; }
            set
            { _labors_cost = value; }
        }
        public DataTable table
        {
            get
            { return _table; }
            set
            { _table = value; }
        }
        public int equ_id
        {
            get
            { return _equ_id; }
            set
            { _equ_id = value; }
        }
        public int main_type
        {
            get
            { return _main_type; }
            set
            { _main_type = value; }
        }
        public int main_periodnum
        {
            get
            {
                return _main_periodnum;
            }
            set
            {
                _main_periodnum = value;
            }
        }
        public string main_part
        {
            get
            { return _main_part; }
            set
            { _main_part = value; }
        }
        public string main_state
        {
            get
            { return _main_state; }
            set
            { _main_state = value; }
        }
        public int main_cost
        {
            get
            { return _main_cost; }
            set
            { _main_cost = value; }
        }
        public DateTime main_date
        {
            get
            { return _main_date; }
            set
            { _main_date = value; }
        }
        public string details
        {
            get
            { return _details; }
            set
            { _details = value; }
        }
        public int user_id
        {
            get
            { return _user_id; }
            set
            { _user_id = value; }
        }
        public string main_type_name
        {
            get
            { return _main_type_name; }
            set
            { _main_type_name = value; }
        }
        public string main_state_details
        {
            get
            { return _main_state_details; }
            set
            { _main_state_details = value; }
        }
        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("main_id", main_id);
            SL.Add("equ_id", equ_id);
            SL.Add("main_type", main_type);
            SL.Add("main_periodnum", main_periodnum);
            SL.Add("main_part", main_part);
            SL.Add("main_state", main_state);
            SL.Add("main_cost", main_cost);
            SL.Add("main_date", main_date);
            SL.Add("details", details);
            SL.Add("user_id", user_id);
            SL.Add("main_type_name", main_type_name);
            SL.Add("main_state_details", main_state_details);
            SL.Add("main_hours_repair", main_hours_repair);
            SL.Add("labors_cost", labors_cost);

            if (DB.RunProcrduer("promain", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        #endregion

        int main_typeew = -3;
        int main_typeew2 = -4;
        public string Addmain(int equ_id, int main_type, int main_periodnum, string main_part, string main_state,
            int main_cost, DateTime main_date, string details, int user_id, string main_type_name, string main_state_details,
            int main_hours_repair, int labors_cost,string num)
        {
            //int xe = ava_hours(equ_id, main_date.Date);
            //if (xe < main_hours_repair)
            //{ return "Failed: Inserted Hours is more than Available Hours For this Day" + "\n" + "Available Hours= " + xe; }
            this.main_id = 2;
            this.equ_id = equ_id;
            this.main_type = main_type;
            this.main_periodnum = main_periodnum;
            this.main_part = main_part;
            this.main_state = main_state;
            this.main_cost = main_cost;
            this.main_date = main_date;
            this.details = details;
            this.user_id = user_id;
            this.main_type_name = main_type_name;
            this.main_state_details = main_state_details;
            this.main_hours_repair = main_hours_repair;
            this.labors_cost = labors_cost;


            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string update_main(int main_id, int equ_id, int main_type, int main_periodnum, string main_part, string main_state,
            int main_cost, DateTime main_date, string details, int user_id, string main_type_name, string main_state_details, int main_hours_repair
            , int labors_cost, string num)
        {
            //string[] xef = bring_prev(main_id);
            //int ho = Convert.ToInt32(xef[11]);
            //int xe = ava_hours(equ_id, main_date.Date);

            //if (main_hours_repair > (ho + xe))
            //{ return "Failed: Inserted Hours is more than Available Hours For this Day" + "\n" + "Available Hours= " + xe; }
            //if(main_type_name == "Periodic Maintenance")
            //{
            //    main_type_name= main_type_name + "<#>" + num;
            //}
            this.main_id = main_id;
            this.equ_id = equ_id;
            this.main_type = Convert.ToInt32(main_type);
            this.main_periodnum = main_periodnum;
            this.main_part = main_part;
            this.main_state = main_state;
            this.main_cost = Convert.ToInt32(main_cost);
            this.main_date = Convert.ToDateTime(main_date);
            this.details = details;
            this.user_id = user_id;
            this.main_type_name = main_type_name;
            this.main_state_details = main_state_details;
            this.main_hours_repair = main_hours_repair;
            this.labors_cost = labors_cost;

            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        //public int find_lower_period_stage_hours2(int equ_id, int main_periodnum)
        //{
        //    if (main_periodnum != 0)
        //    {
        //        int main_periodnumafter = find_true_hours_now(equ_id, main_periodnum);
        //        main_state = "new";
        //        string query2 = "select * From maintain Where equ_id ='" + equ_id + "'AND  main_periodnum <= '" + main_periodnumafter + "' AND  main_state= '" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
        //        DataTable tb2 = Search(query2);
        //        int y2 = tb2.Rows.Count;
        //        if (y2 >= 1)
        //        {
        //            this.main_id = Convert.ToInt32(tb2.Rows[y2 - 1][0].ToString());
        //            this.main_type = Convert.ToInt32(tb2.Rows[y2 - 1][2].ToString());
        //            this.low_hours = Convert.ToInt32(tb2.Rows[y2 - 1][3].ToString());
        //            int qmain_periodnum = Convert.ToInt32(tb2.Rows[y2 - 1][3].ToString());
        //            this.main_part = tb2.Rows[y2 - 1][4].ToString();
        //            return qmain_periodnum;
        //        }
        //        else
        //        {
        //            main_state = "new";
        //            string query3 = "select * From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "'";
        //            DataTable tb3 = Search(query3);
        //            int y3 = tb3.Rows.Count;
        //            if (y3 >= 1)
        //            {
        //                this.low_hours = Convert.ToInt32(tb3.Rows[y3 - 1][3].ToString());
        //                this.main_id = Convert.ToInt32(tb3.Rows[y3 - 1][0].ToString());
        //                this.main_type = Convert.ToInt32(tb3.Rows[y3 - 1][2].ToString());
        //                int qmain_periodnum = Convert.ToInt32(tb3.Rows[y3 - 1][3].ToString());
        //                this.main_part = tb3.Rows[y3 - 1][4].ToString();
        //                if(peroid_satge_number==0)
        //                {
        //                    this.low_hours = Convert.ToInt32(tb3.Rows[0][3].ToString());
        //                    this.main_id = Convert.ToInt32(tb3.Rows[0][0].ToString());
        //                    this.main_type = Convert.ToInt32(tb3.Rows[0][2].ToString());
        //                    qmain_periodnum = Convert.ToInt32(tb3.Rows[0][3].ToString());
        //                    this.main_part = tb3.Rows[0][4].ToString();
        //                }
        //                return qmain_periodnum;
        //            }
        //            else { return 0; }
        //        }
        //    }
        //    else { return 0; }
        //}

        public int find_lower_period_stage_hours(int equ_id, int main_periodnum)
        {
            if (main_periodnum != 0)
            {
                int main_periodnumafter = find_true_hours_now(equ_id, main_periodnum);
                string main_state1 = "Done";
                string main_state2 = "Not All";
                int type = 1;
                string query2 = "select main_id,main_type_name From maintain Where equ_id ='" + equ_id + "'AND( main_state= '" + main_state1 + "'OR main_state ='" + main_state2 + "')AND main_type >='" + type + "'";
                DataTable tb2 = Search(query2);
                int y2 = tb2.Rows.Count;
                if (y2 >= 1)
                {
                    this.main_id = Convert.ToInt32(tb2.Rows[y2 - 1][0].ToString());
                    string num = tb2.Rows[y2 - 1][1].ToString();
                    string[] part1 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                    for (int i = 0; i < y2; i++)
                    {
                        num = tb2.Rows[i][1].ToString();
                        string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                        if (Convert.ToInt32(part2[1]) > Convert.ToInt32(part1[1]))
                        {
                            this.main_id = Convert.ToInt32(tb2.Rows[i ][0].ToString());
                            part1 = part2;
                        }
                    }
                    main_state = "new";
                    string query1 = "select main_id From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
                    DataTable tb1 = Search(query1);
                    int numm = tb1.Rows.Count;
                    int lower = (Convert.ToInt32(part1[1]))% numm;
                    if(lower==0)
                    {
                        lower = numm;
                    }
                   
                    string query5 = "select main_type,main_periodnum,main_part From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "'AND main_type ='" + lower + "'";
                    DataTable tb5 = Search(query5);
                    this.main_type = Convert.ToInt32(tb5.Rows[0][0].ToString());
                    this.low_hours = Convert.ToInt32(tb5.Rows[0][1].ToString());
                    int qmain_periodnum = Convert.ToInt32(tb5.Rows[0][1].ToString());
                    this.main_part = tb5.Rows[0][2].ToString();
                    return qmain_periodnum;
                }
                else
                {
                    int qmain_periodnum = 0;
                    main_state = "new";
                    string query3 = "select main_id,main_type,main_periodnum,main_part From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "' and main_periodnum <='" + main_periodnumafter + "'ORDER BY main_type";
                    DataTable tb3 = Search(query3);
                    int y3 = tb3.Rows.Count;
                    if (y3 >= 1)
                    {
                        int Lower = Convert.ToInt32(tb3.Rows[y3-1][1].ToString());
                        int Lower_index = y3 - 1;
                        for (int i = 0; i < y3; i++)
                        {
                            if (Convert.ToInt32(tb3.Rows[i][1].ToString()) > Lower)
                            {
                                Lower_index = i;
                            }
                        }
                        if (main_periodnum < Convert.ToInt32(tb3.Rows[0][2].ToString()) - 25)
                        {
                            this.low_hours = Convert.ToInt32(0);
                            this.main_id =0;
                            this.main_type = 0;
                            this.main_part = "0";
                            return 0;
                        }
                        this.low_hours = Convert.ToInt32(tb3.Rows[Lower_index][2].ToString());
                        this.main_id = Convert.ToInt32(tb3.Rows[Lower_index][0].ToString());
                        this.main_type = Convert.ToInt32(tb3.Rows[Lower_index][1].ToString());
                        qmain_periodnum = Convert.ToInt32(tb3.Rows[Lower_index][2].ToString());
                        this.main_part = tb3.Rows[Lower_index][3].ToString();
                    }
                    else 
                    {
                        main_state = "new";
                        string query313 = "select main_id,main_type,main_periodnum,main_part From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "'ORDER BY main_type ";
                        DataTable tb313 = Search(query313);
                        int y313 = tb313.Rows.Count;
                        if (y313 >= 1)
                        {
                            int Lower_index = y313 - 1;
                            if (main_periodnum > Convert.ToInt32(tb313.Rows[y313 - 1][1].ToString()))
                            {
                                Lower_index = 0;
                            }
                            if (main_periodnum < Convert.ToInt32(tb313.Rows[0][2].ToString()) - 25)
                            {
                                this.low_hours = Convert.ToInt32(0);
                                this.main_id = 0;
                                this.main_type = 0;
                                this.main_part = "0";
                                return 0;
                            }
                            this.low_hours = Convert.ToInt32(tb313.Rows[Lower_index][2].ToString());
                            this.main_id = Convert.ToInt32(tb313.Rows[Lower_index][0].ToString());
                            this.main_type = Convert.ToInt32(tb313.Rows[Lower_index][1].ToString());
                            qmain_periodnum = Convert.ToInt32(tb313.Rows[Lower_index][2].ToString());
                            this.main_part = tb313.Rows[Lower_index][3].ToString();
                        }
                    }
                    return qmain_periodnum;
                }
            }
            else { return 0; }
        }
        public int find_higher_period_stage_hours(int equ_id, int main_periodnum)
        {
            if (main_periodnum != 0)
            {
                int main_periodnumafter = find_true_hours_now(equ_id, main_periodnum);
                string main_state1 = "Done";
                string main_state2 = "Not All";
                int type = 1;
                string query2 = "select * From maintain Where equ_id ='" + equ_id + "'AND ( main_state= '" + main_state1 + "'OR main_state ='" + main_state2 + "')AND main_type >='" + type + "'ORDER BY main_periodnum";
                DataTable tb2 = Search(query2);
                int y2 = tb2.Rows.Count;
                if (y2 >= 1)
                {
                    string num = tb2.Rows[y2 - 1][10].ToString();
                    string[] part1 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                    for (int i = 0; i < y2; i++)
                    {
                        num = tb2.Rows[i][10].ToString();
                        string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                        if (Convert.ToInt32(part2[1]) > Convert.ToInt32(part1[1]))
                        {
                            part1 = part2;
                        }
                    }
                    int last_hours = (Convert.ToInt32(tb2.Rows[tb2.Rows.Count -1][3].ToString()));
                    main_state = "new";
                    int main_types = 1;
                    string query1 = "select * From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "'AND main_type >='" + main_types + "'ORDER BY main_type";
                    DataTable tb1 = Search(query1);
                    int numm = tb1.Rows.Count;
                    int higher = (Convert.ToInt32(part1[1]) + 1) % numm;
                    if (higher == 0)
                    {
                        higher = numm;
                    }
                    string query5 = "select * From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "'AND main_type ='" + higher + "'";
                    DataTable tb5 = Search(query5);
                    this.main_type = Convert.ToInt32(tb5.Rows[0][2].ToString());
                    this.low_hours = Convert.ToInt32(tb5.Rows[0][3].ToString());
                    
                    this.main_part = tb5.Rows[0][4].ToString();
                    this.main_state_details = tb5.Rows[0][11].ToString();
                    int qmain_periodnum = last_hours + Convert.ToInt32(this.main_state_details);// Convert.ToInt32(tb5.Rows[0][3].ToString());
                    return qmain_periodnum;
                }
                else
                {
                    int qmain_periodnum = 0;
                    main_state = "new";
                    string query3 = "select * From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "' and main_periodnum >'" + main_periodnumafter + "'ORDER BY main_type";
                    DataTable tb3 = Search(query3);
                    int y3 = tb3.Rows.Count;
                    if (y3 >= 1)
                    {
                        int higher_index = 0;
                        this.low_hours = Convert.ToInt32(tb3.Rows[higher_index][3].ToString());
                        this.main_id = Convert.ToInt32(tb3.Rows[higher_index][0].ToString());
                        this.main_type = Convert.ToInt32(tb3.Rows[higher_index][2].ToString());
                        qmain_periodnum = Convert.ToInt32(tb3.Rows[higher_index][3].ToString());
                        this.main_part = tb3.Rows[higher_index][4].ToString();
                        this.main_state_details = tb3.Rows[higher_index][11].ToString();
                    }
                    else
                    {
                        main_state = "new";
                        string query313 = "select * From maintain Where equ_id ='" + equ_id + "'AND  main_state= '" + main_state + "'ORDER BY main_type";
                        DataTable tb313 = Search(query313);
                        int y313 = 1 ;
                        if (tb313.Rows.Count >= 1)
                        {
                            this.low_hours = Convert.ToInt32(tb313.Rows[y313 - 1][3].ToString());
                            this.main_id = Convert.ToInt32(tb313.Rows[y313 - 1][0].ToString());
                            this.main_type = Convert.ToInt32(tb313.Rows[y313 - 1][2].ToString());
                            qmain_periodnum = Convert.ToInt32(tb313.Rows[y313 - 1][3].ToString());
                            this.main_part = tb313.Rows[y313 - 1][4].ToString();
                            this.main_state_details = tb313.Rows[y313 - 1][11].ToString();
                        }
                    }
                    return qmain_periodnum;
                }
            }
            else { return 0; }
        }
        public int get_last_main_counter(int equ_id)
        {
            string main_state1 = "Done";
            string main_state2 = "Not All";
            int type = 1;
            string query2 = "select main_id,main_periodnum,main_type_name From maintain Where equ_id ='" + equ_id + "'AND( main_state= '" + main_state1 + "'OR main_state ='" + main_state2 + "')AND main_type >='" + type + "'";
            DataTable tb2 = Search(query2);
            int y2 = tb2.Rows.Count;
            int lowest = 0;
            if (y2 >= 1)
            {
                lowest = Convert.ToInt32(tb2.Rows[y2 - 1][1].ToString());
                string num = tb2.Rows[y2 - 1][2].ToString();
                string[] part1 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                for (int i = 0; i < y2; i++)
                {
                    num = tb2.Rows[i][2].ToString();
                    string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                    //test = Convert.ToInt32(part2[1]);
                    if (Convert.ToInt32(part2[1]) > Convert.ToInt32(part1[1]))
                    {
                        this.main_id = Convert.ToInt32(tb2.Rows[i][0].ToString());
                        lowest = Convert.ToInt32(tb2.Rows[i][1].ToString());
                        part1 = part2;
                    }
                }
            }
            return lowest;
        }
        public bool Find_work_hours(int equ_id)
        {
            main_state = "All Work Hours";
            string query = "select main_id,main_periodnum From maintain Where equ_id ='" + equ_id + "' AND  main_state= '" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.main_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.main_periodnum = Convert.ToInt32(tbl.Rows[0][1].ToString());
                return true;
            }
        }
        public int Find_work_hours_int(int equ_id)
        {
            main_state = "All Work Hours";
            string query = "select main_periodnum From maintain Where equ_id ='" + equ_id + "' AND main_state= '" + main_state + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(tbl.Rows[0][0].ToString());
            }
        }

        public int find_prev_hours(int equ_id,int main_types)
        {
            main_state = "new";
            string query = "select main_periodnum From maintain Where equ_id ='" + equ_id + "' AND main_state= '" + main_state + "'AND main_type= '" + main_types + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(tbl.Rows[0][0].ToString());
            }
        }
        public string Modify_hours(int main_id, int equ_id,DateTime dd)
        {
            string query1 = "select * From equ_work_h Where equ_id='" + equ_id + "' AND date >= '" + dd + "' ORDER BY date";
            DataTable tb1 = Search(query1);
            //DataTable tb1 = new DataTable();
            int coun = 0;
            if (tb1.Rows.Count > 0)
            { 
                coun = Convert.ToInt32(tb1.Rows[tb1.Rows.Count - 1][4].ToString());
            }
            else
            {
                query1 = "select * From equ_work_h Where equ_id='" + equ_id + "' ORDER BY date";
                tb1 = Search(query1);
                coun = 0;
                if (tb1.Rows.Count > 0)
                {
                    coun = Convert.ToInt32(tb1.Rows[tb1.Rows.Count - 1][4].ToString());
                }
            }
            if(if_km(equ_id))
            { details = "KM"; }
            table = tb1;
            this.main_id = main_id;
            this.equ_id = equ_id;
            this.main_type = Convert.ToInt32(null);
            this.main_periodnum = coun;
            this.main_part = Convert.ToString(null);
            this.main_state = "All Work Hours";
            this.main_cost = Convert.ToInt32(null);
            this.main_date = Convert.ToDateTime(DateTime.Now);
            this.details = details;
            this.user_id = 1;
            this.main_type_name = null;
            this.main_state_details = null;
            this.main_hours_repair = Convert.ToInt32(null);
            this.labors_cost = Convert.ToInt32(null);
            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public int find_true_hours_now(int equ_id, int main_periodnum)
        {
            main_state = "new";
            string query  = "select main_type,main_periodnum From maintain Where equ_id ='" + equ_id + "' AND  main_state= '" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tbl = Search(query);
            int y1 = tbl.Rows.Count;
            if (y1 == 0)
            {
                return y1;
            }
            else
            {
                int max_hours = Convert.ToInt32(tbl.Rows[y1 - 1][1].ToString());
                this.max_hours = max_hours;
                this.max_main_type = Convert.ToInt32(tbl.Rows[y1 - 1][0].ToString());
                peroid_satge_number =Convert.ToInt32( main_periodnum / max_hours);
                if(main_periodnum == max_hours)
                {
                    peroid_satge_number = 0;
                }
                int main_periodnumafter = main_periodnum - (peroid_satge_number * max_hours);
                if (main_periodnumafter == 0)
                {
                    main_periodnumafter = max_hours;
                }
                return main_periodnumafter;
            }
        }
        //public bool check_all_undone_prev_all(int equ_id)
        //{

        //    string sc = "Done";
        //    string typ = "Periodic Maintenance"; 
        //    string query2 = "select "*" From maintain Where equ_id= '" + equ_id + "' AND main_type_name ='" + typ + "'AND main_state !='" + sc + "'";
        //    DataTable tb1 = Search(query2);

        //    if (tb1.Rows.Count >= 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public bool check_all_undone_prev(int equ_id)
        {
            main_state = "Not All";
            int main_type = 0;
            string query2 = "select main_id,main_type_name,main_periodnum,main_part,main_state,main_cost,main_date,details,main_hours_repair,labors_cost From maintain Where main_state= '" + main_state + "' and equ_id= '" + equ_id + "' AND  main_type > '" + main_type + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tb2 = Search(query2);
            this.table = tb2;
            int y2 = tb2.Rows.Count;
            if (y2 >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool check_all_undone_main(int equ_id, int main_type)
        {
            main_state = "Not All";
            string query2 = "select * From maintain Where main_state= '" + main_state + "' and equ_id= '" + equ_id + "' AND  main_type = '" + main_type + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tb2 = Search(query2);
            this.table = tb2;
            int y2 = tb2.Rows.Count;
            if (y2 >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int true_type(int stage, int max, int type_req)
        {
            int x = (stage * max) + type_req;
            return x;
        }    
        public List<string> main_test()
        {
            main_state = "All Work Hours";
            string query = "select equ_id,main_periodnum From maintain Where main_state = '" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tbl = Search(query);
            int y1 = tbl.Rows.Count;
            List<string> final = new List<string>();
            List<string> final2 =new List<string>();
            if (y1 != 0)
            {
                for (int x = 0; x < y1; x++)
                {
                    try
                    {
                        eq22.Searchequ(Convert.ToInt32(tbl.Rows[x][0].ToString()));
                        string name = eq22.equ_type_id;
                        final2= alert(Convert.ToInt32(tbl.Rows[x][0].ToString()), Convert.ToInt32(tbl.Rows[x][1].ToString()));
                        final.Add( name);
                        final.Add(final2[0]);
                        final.Add(final2[1]);
                        final.Add(final2[2]);
                    }
                    catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
                }
            }
            return final;
        }
        #region alert Region
        // call asshole for public use

        public int last(int equ_id)
        {
            string main_state1 = "new";
            string main_state2 = "All Work Hours";
            int main_typse = 1;
            string query2 = "select main_periodnum From maintain Where equ_id ='" + equ_id + "' AND  main_state != '" + main_state1 + "' AND main_state != '" + main_state2 + "' AND  main_type >= '" + main_typse + "' ORDER BY main_periodnum";
            DataTable tb1 = Search(query2);
            if(tb1.Rows.Count > 0)
            {
                return Convert.ToInt32(tb1.Rows[tb1.Rows.Count - 1][0].ToString());
            }
            else
            {
                return 0;
            }
        }

        public bool if_km(int equ_id)
        {
            string main_state2 = "All Work Hours";
            string query2 = "select details From maintain Where equ_id ='" + equ_id + "' AND  main_state = '" + main_state2 + "'";
            DataTable tb2 = Search(query2);
            if (tb2.Rows[0][0].ToString() == "KM")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string[] hole(int equ_id, int main_periodnum)
        {
            #region MyRegion
            string[] state = new string[22];
            int true_hours = find_true_hours_now(equ_id, main_periodnum);
            if (main_periodnum > 0)
            {
                int higher_main_hours = find_higher_period_stage_hours(equ_id, main_periodnum);
                if (higher_main_hours != 0)
                {
                    int higher_main_type = this.main_type;
                    string higher_main_parts = this.main_part;
                    int interval = Convert.ToInt32(this.main_state_details);
                    int lower_main_hours = find_lower_period_stage_hours(equ_id, main_periodnum);
                    string lower_main_parts = this.main_part;
                    int lower_main_type = this.main_type;
                    //if (higher_main_hours == true_hours)
                    //{
                    //    higher_main_hours = find_higher_period_stage_hours(equ_id, main_periodnum + 1);
                    //    higher_main_type = this.main_type;
                    //    higher_main_parts = this.main_part;
                    //    interval = Convert.ToInt32(this.main_state_details);
                    //}
                    string main_state1 = "new";
                    string main_state2 = "All Work Hours";
                    int main_typse = 1;
                    string query2 = "select * From maintain Where equ_id ='" + equ_id + "' AND  main_state != '" + main_state1 + "' AND main_state != '" + main_state2 + "' AND  main_type >= '" + main_typse + "' ORDER BY main_periodnum";
                    DataTable tb1 = Search(query2);
                    int y2 = tb1.Rows.Count;
                    int True_lower_main_type = true_type(peroid_satge_number, max_main_type, lower_main_type);
                    //int stpn = peroid_satge_number;
                    //if (lower_main_type == max_main_type && higher_main_type == 1)
                    //{
                    //    stpn++;
                    //}
                    //int True_higher_main_type = true_type(stpn, max_main_type, higher_main_type);
                    int limits = 25; string kmm = " Hours";
                    if (if_km(equ_id))
                    {
                        kmm = " Kilometers";
                        limits = limits * 50;
                    }
                    if (y2 >= 1)
                    {
                        y2 = y2 - 1;

                        int last_main_type = Convert.ToInt32(tb1.Rows[y2][2].ToString());
                        string num = tb1.Rows[y2][10].ToString();

                        string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                        int True_last_main_type = Convert.ToInt32(part2[1]);

                        int last_main_hours = Convert.ToInt32(tb1.Rows[y2][3].ToString());
                        string last_main_state = tb1.Rows[y2][5].ToString();

                        string query6 = "select main_periodnum From maintain Where equ_id ='" + equ_id + "' AND  main_state = '" + main_state1 + "'AND  main_type = '" + last_main_type + "'";
                        DataTable tb6 = Search(query6);
                        
                        if (last_main_state == "Done")
                        {
                            if ((main_periodnum - last_main_hours)>= interval - limits)
                            {
                                if(((main_periodnum - last_main_hours) <= interval + limits))
                                {
                                    state[0] = "27";
                                }
                                else
                                {
                                    state[0] = "270";
                                }
                                int stilll = main_periodnum - (last_main_hours + interval) ;
                                state[1] = "ADD New Periodic Maintenance " + " (" + (higher_main_type * interval) + " hours Stage)";
                                state[2] = "Note // This Equipment is " + stilll.ToString() + kmm + " Behind Requsted Service Counter";
                                state[3] = Convert.ToString(higher_main_type);
                                state[4] = Convert.ToString(last_main_hours + interval);
                                state[5] = higher_main_parts;
                                state[6] = Convert.ToString(True_last_main_type + 1);
                                state[7] = Convert.ToString(last_main_hours);
                                state[8] = Convert.ToString(interval);
                                state[9] = "end";
                            }
                            if ((main_periodnum - last_main_hours) < interval - limits)
                            {
                                int stilll = (last_main_hours + interval) - main_periodnum;
                                
                                state[0] = "26";
                                state[1] = "Last Periodic Maintenance is Done";
                                state[2] = "Note // This Equipment Has " + stilll.ToString()+ kmm + " Left Until Next Maintenance";
                                state[3] = "end";
                            }
                        }
                        else
                        {
                            int needed = last_main_type - 1;
                            if(last_main_type == 1 && last_main_hours > max_hours)
                            {
                                needed = max_main_type;
                            }
                            if(needed == 0)
                            {
                                last_main_hours = 0;
                            }
                            else
                            {
                                string query8 = "select main_periodnum From maintain Where equ_id ='" + equ_id + "' AND  main_state != '" + main_state1 + "'AND  main_type = '" + needed + "'";
                                DataTable tb8 = Search(query8);
                                if (tb8.Rows.Count > 0)
                                {
                                    last_main_hours = Convert.ToInt32(tb8.Rows[0][0].ToString());
                                }
                                else
                                {
                                    last_main_hours = 0;
                                }
                            }
                            state[0] = "25";
                            state[1] = "Last Periodic Maintenance Is Not Complete";
                            state[2] = "Please Complete it First";
                            state[3] = tb1.Rows[y2][0].ToString();
                            state[4] = tb1.Rows[y2][2].ToString();
                            state[5] = tb1.Rows[y2][3].ToString();
                            state[6] = tb1.Rows[y2][4].ToString();
                            state[7] = tb1.Rows[y2][6].ToString();
                            state[8] = tb1.Rows[y2][7].ToString();
                            state[9] = tb1.Rows[y2][8].ToString();
                            state[10] = tb1.Rows[y2][9].ToString();
                            state[11] = tb1.Rows[y2][11].ToString();
                            state[12] = tb1.Rows[y2][12].ToString();
                            state[13] = tb1.Rows[y2][13].ToString();
                            state[14] = True_last_main_type.ToString();
                            state[15] = tb6.Rows[0][0].ToString();
                            state[16] = Convert.ToString(last_main_hours);
                            state[17] = Convert.ToString(interval);
                            state[18] = "end";
                        }


                        #endregion
                        if (state[18]=="Never -_- ")
                        {
                            if (True_lower_main_type > True_last_main_type + 1 & true_hours < higher_main_hours - 25)
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "1";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "ALERT: Many Periodic Maintenance missing";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = Convert.ToString(lower_main_hours);
                                    state[5] = lower_main_parts;
                                    state[6] = "end";
                                }  // RED many prev main missing   //add new low
                                else
                                {
                                    state[0] = "2";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)"; ;
                                    state[2] = "ALERT: Many Periodic Maintenance missing" + "\n" + "Notice: Last Periodic Maintenance is not Complete";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = lower_main_parts;
                                    state[5] = tb1.Rows[y2][0].ToString();
                                    state[6] = tb1.Rows[y2][2].ToString();
                                    state[7] = tb1.Rows[y2][3].ToString();
                                    state[8] = tb1.Rows[y2][4].ToString();
                                    state[9] = tb1.Rows[y2][6].ToString();
                                    state[10] = tb1.Rows[y2][7].ToString();
                                    state[11] = tb1.Rows[y2][8].ToString();
                                    state[12] = tb1.Rows[y2][9].ToString();
                                    state[13] = tb1.Rows[y2][11].ToString();
                                    state[14] = tb1.Rows[y2][12].ToString();
                                    state[15] = tb1.Rows[y2][13].ToString();
                                    state[16] = "end";
                                } // RED many prev main missing     // last is not Done
                            }
                            else if (True_lower_main_type > True_last_main_type + 1 & true_hours > higher_main_hours - 25)
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "3";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "ALERT: Many Periodic Maintenance missing" + "\n" + "Notice: There is Another Periodic Maintenance Soon";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = Convert.ToString(lower_main_hours);
                                    state[5] = lower_main_parts;
                                    state[6] = "end";
                                } // RED many prev main missing + // Yellow prev main soon
                                else
                                {
                                    state[0] = "4";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "ALERT: Many Periodic Maintenance missing" + "\n" + "Notice: Last Periodic Maintenance is not Complete" + "\n" + "Notice: There is Another Periodic Maintenance Soon";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = lower_main_parts;
                                    state[5] = tb1.Rows[y2][0].ToString();
                                    state[6] = tb1.Rows[y2][2].ToString();
                                    state[7] = tb1.Rows[y2][3].ToString();
                                    state[8] = tb1.Rows[y2][4].ToString();
                                    state[9] = tb1.Rows[y2][6].ToString();
                                    state[10] = tb1.Rows[y2][7].ToString();
                                    state[11] = tb1.Rows[y2][8].ToString();
                                    state[12] = tb1.Rows[y2][9].ToString();
                                    state[13] = tb1.Rows[y2][11].ToString();
                                    state[14] = tb1.Rows[y2][12].ToString();
                                    state[15] = tb1.Rows[y2][13].ToString();
                                    state[16] = "end";
                                }  // RED many prev main missing // last is not Done  // Yellow prev main soon
                            }
                            else if (True_lower_main_type == True_last_main_type + 1 & true_hours < lower_main_hours + 25)
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "5";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = Convert.ToString(lower_main_hours);
                                    state[5] = lower_main_parts;
                                    state[6] = "end";
                                } // Yellow prev main now
                                else
                                {
                                    state[0] = "6";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "Notice: Last Periodic Maintenance is not Complete" + "\n" + "Notice: There is Another Periodic Maintenance Soon";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = lower_main_parts;
                                    state[5] = tb1.Rows[y2][0].ToString();
                                    state[6] = tb1.Rows[y2][2].ToString();
                                    state[7] = tb1.Rows[y2][3].ToString();
                                    state[8] = tb1.Rows[y2][4].ToString();
                                    state[9] = tb1.Rows[y2][6].ToString();
                                    state[10] = tb1.Rows[y2][7].ToString();
                                    state[11] = tb1.Rows[y2][8].ToString();
                                    state[12] = tb1.Rows[y2][9].ToString();
                                    state[13] = tb1.Rows[y2][11].ToString();
                                    state[14] = tb1.Rows[y2][12].ToString();
                                    state[15] = tb1.Rows[y2][13].ToString();
                                    state[16] = "end";
                                }// Yellow prev main now & last is not Done
                            }
                            else if (True_lower_main_type == True_last_main_type + 1 & true_hours > lower_main_hours + 25 & true_hours < higher_main_hours - 25)
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "7";
                                    state[1] = "ADD New Periodic Maintenance (" + lower_main_hours + " hours Stage)";
                                    state[2] = "";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = Convert.ToString(lower_main_hours);
                                    state[5] = lower_main_parts;
                                    state[6] = "end";
                                }// RED prev main now
                                else
                                {
                                    state[0] = "8";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "Notice: Last Periodic Maintenance is not Complete";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = lower_main_parts;
                                    state[5] = tb1.Rows[y2][0].ToString();//main id
                                    state[6] = tb1.Rows[y2][2].ToString();//type
                                    state[7] = tb1.Rows[y2][3].ToString();//hours
                                    state[8] = tb1.Rows[y2][4].ToString();//parts
                                    state[9] = tb1.Rows[y2][6].ToString();//cost
                                    state[10] = tb1.Rows[y2][7].ToString();//date
                                    state[11] = tb1.Rows[y2][8].ToString();//details
                                    state[12] = tb1.Rows[y2][9].ToString();//user
                                    state[13] = tb1.Rows[y2][11].ToString();//state details
                                    state[14] = tb1.Rows[y2][12].ToString();
                                    state[15] = tb1.Rows[y2][13].ToString();
                                    state[16] = "end";
                                }// RED prev main now & last is not Done
                            }
                            else if (True_lower_main_type == True_last_main_type + 1 & true_hours > higher_main_hours - 25)
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "9";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "Notice: There is Another Periodic Maintenance Soon";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = Convert.ToString(lower_main_hours);
                                    state[5] = lower_main_parts;
                                    state[6] = "end";
                                }// RED prev main missing + // Yellow prev main soon
                                else
                                {
                                    state[0] = "10";
                                    state[1] = "ADD New Periodic Maintenance " + " (" + lower_main_hours + " hours Stage)";
                                    state[2] = "Notice: Last Periodic Maintenance is not Complete" + "\n" + "Notice: There is Another Periodic Maintenance Soon";
                                    state[3] = Convert.ToString(lower_main_type);
                                    state[4] = lower_main_parts;
                                    state[5] = tb1.Rows[y2][0].ToString();
                                    state[6] = tb1.Rows[y2][2].ToString();
                                    state[7] = tb1.Rows[y2][3].ToString();
                                    state[8] = tb1.Rows[y2][4].ToString();
                                    state[9] = tb1.Rows[y2][6].ToString();
                                    state[10] = tb1.Rows[y2][7].ToString();
                                    state[11] = tb1.Rows[y2][8].ToString();
                                    state[12] = tb1.Rows[y2][9].ToString();
                                    state[13] = tb1.Rows[y2][11].ToString();
                                    state[14] = tb1.Rows[y2][12].ToString();
                                    state[15] = tb1.Rows[y2][13].ToString();
                                    state[16] = "end";
                                }// RED prev main missing & last is not Done + // Yellow prev main soon
                            }
                            else if (True_lower_main_type == True_last_main_type & (true_hours < higher_main_hours - 25 || true_hours == max_hours))
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "11";
                                    state[1] = "Last Periodic Maintenance is Done";
                                    state[2] = "";
                                    state[3] = "end";
                                }// Green All is Done
                                else
                                {
                                    state[0] = "12";
                                    state[1] = "Notice: Last Periodic Maintenance is not Complete";
                                    state[2] = "";
                                    state[3] = tb1.Rows[y2][0].ToString();//id
                                    state[4] = tb1.Rows[y2][2].ToString();//stage type
                                    state[5] = tb1.Rows[y2][3].ToString();//hours
                                    state[6] = tb1.Rows[y2][4].ToString();//parts
                                    state[7] = tb1.Rows[y2][6].ToString();//cost
                                    state[8] = tb1.Rows[y2][7].ToString();//date
                                    state[9] = tb1.Rows[y2][8].ToString();//details
                                    state[10] = tb1.Rows[y2][9].ToString();//user
                                    state[11] = tb1.Rows[y2][11].ToString();//state details
                                    state[12] = tb1.Rows[y2][12].ToString();
                                    state[13] = tb1.Rows[y2][13].ToString();
                                    state[14] = "end";
                                }// Yellow last is not Done
                            }
                            else if (True_lower_main_type == True_last_main_type & true_hours > higher_main_hours - 25 & true_hours != max_hours)
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "13";
                                    state[1] = "Notice: There is Periodic Maintenance Soon";
                                    state[2] = "";
                                    state[3] = Convert.ToString(higher_main_type);
                                    state[4] = Convert.ToString(higher_main_hours);
                                    state[5] = higher_main_parts;
                                    state[6] = "end";
                                }// Yellow prev main soon
                                else
                                {
                                    state[0] = "14";
                                    state[1] = "Notice: There is Periodic Maintenance Soon";
                                    state[2] = "Notice: Last Periodic Maintenance is not Complete";
                                    state[3] = Convert.ToString(higher_main_type);
                                    state[4] = higher_main_hours.ToString();
                                    state[5] = tb1.Rows[y2][0].ToString();
                                    state[6] = tb1.Rows[y2][2].ToString();
                                    state[7] = tb1.Rows[y2][3].ToString();
                                    state[8] = tb1.Rows[y2][4].ToString();
                                    state[9] = tb1.Rows[y2][6].ToString();
                                    state[10] = tb1.Rows[y2][7].ToString();
                                    state[11] = tb1.Rows[y2][8].ToString();
                                    state[12] = tb1.Rows[y2][9].ToString();
                                    state[13] = tb1.Rows[y2][11].ToString();
                                    state[14] = tb1.Rows[y2][12].ToString();
                                    state[15] = tb1.Rows[y2][13].ToString();
                                    state[16] = "end";
                                }// Yellow prev main soon & last is not Done
                            }
                            else if (True_lower_main_type < True_last_main_type)
                            {
                                if (last_main_state == "Done")
                                {
                                    state[0] = "15";
                                    state[1] = "Last Periodic Maintenance is Done";
                                    state[2] = "Notice: The Last Periodic Maintenance (IS BEFORE) its time";
                                    state[3] = "end";
                                }// Black Database Error Future prev main
                                else
                                {
                                    state[0] = "16";
                                    state[1] = "Notice: Last Periodic Maintenance is not Complete";
                                    state[2] = "Notice: The Last Periodic Maintenance (IS BEFORE) its time";
                                    state[3] = tb1.Rows[y2][0].ToString();//id
                                    state[4] = tb1.Rows[y2][2].ToString();//stage type
                                    state[5] = tb1.Rows[y2][3].ToString();//hours
                                    state[6] = tb1.Rows[y2][4].ToString();//parts
                                    state[7] = tb1.Rows[y2][6].ToString();//cost
                                    state[8] = tb1.Rows[y2][7].ToString();//date
                                    state[9] = tb1.Rows[y2][8].ToString();//details
                                    state[10] = tb1.Rows[y2][9].ToString();//user
                                    state[11] = tb1.Rows[y2][11].ToString();//state details
                                    state[12] = tb1.Rows[y2][12].ToString();
                                    state[13] = tb1.Rows[y2][13].ToString();
                                    state[14] = "end";
                                }// Black Database Error Future prev main & last is not Done
                            }
                        }
                    }
                    else
                    {
                        if ((lower_main_hours == 0) && ((/*higher_main_hours -*/ true_hours) < higher_main_hours - limits))
                        {
                            state[0] = "-1";
                            state[1] = "Note // This Equipment Has "+ Convert.ToString(higher_main_hours - true_hours) + kmm + " Left Until Next Maintenance";
                            state[2] = "";
                            state[3] = "end";
                        }  //green no past Periodic for this equ 
                        else  
                        {
                            state[0] = "17";
                            state[1] = "Notice: NO past Periodic Maintenance for this equipment ";
                            state[2] = "ADD New Periodic Maintenance" + " (" + lower_main_hours + " hours Stage)";
                            state[3] = Convert.ToString(lower_main_type);
                            state[4] = Convert.ToString(lower_main_hours);
                            state[5] = lower_main_parts;
                            state[6] = Convert.ToString(True_lower_main_type);
                            state[7] = Convert.ToString(0);
                            state[8] = Convert.ToString(interval);
                            state[9] = "end";
                        }
                    } //Red no past Periodic for this equ 
                }
                else
                {
                    state[0] = "18";
                    state[1] = "This Equipment Does not have Periodic Maintenance Schedule";
                    state[2] = "";
                    state[3] = "end";
                } //Black no Periodic for this equ 
            }
            else
            {
                state[0] = "19";
                state[1] = "This Equipment Does not have Hours Counter";
                state[2] = "";
                state[3] = "end";
            } //Green no hours counter 
            return state;
        }  // reportes green yellow red black // with ifo new   
           //Dont>>>alert
        #endregion
        public List<string> get_for_report(int main_id,int equ_id,int main_type,int main_periodnum)
        {
            List<string> ll = new List<string>();
            string main_state1 = "new";
            string query1 = "select main_state_details From maintain Where equ_id ='" + equ_id + "' AND  main_state = '" + main_state1 + "' AND main_type = '" + main_type + "'";
            DataTable interval = Search(query1);
            main_state = "new";
            string query3 = "select main_type,main_periodnum From maintain Where equ_id ='" + equ_id + "' AND  main_state= '" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable max = Search(query3);
            int y1 = max.Rows.Count;
            this.max_hours = Convert.ToInt32(max.Rows[y1 - 1][1].ToString());
            this.max_main_type = Convert.ToInt32(max.Rows[y1 - 1][0].ToString());
            string main_state2 = "All Work Hours";
            int main_typse = 1;
            string query2 = "select main_type,main_periodnum,main_type_name From maintain Where equ_id ='" + equ_id + "' AND  main_state != '" + main_state1 + "' AND main_state != '" + main_state2 + "' AND main_type >= '" + main_typse + "'AND main_periodnum < '" + main_periodnum + "' ORDER BY main_periodnum";
            DataTable last_hours = Search(query2);
            int y2 = last_hours.Rows.Count;
            int last_main_hours = 0;
            string True_last_main_type = "0";
            if (y2 > 0)
            {
                y2--;
                int last_main_type = Convert.ToInt32(last_hours.Rows[y2][0].ToString());
                last_main_hours = Convert.ToInt32(last_hours.Rows[y2][1].ToString());
                int needed = last_main_type - 1;
                if (last_main_type == 1 && last_main_hours > max_hours)
                {
                    needed = max_main_type;
                }
                if (needed != 0)
                {
                    string query8 = "select main_periodnum From maintain Where equ_id ='" + equ_id + "' AND  main_state != '" + main_state1 + "'AND  main_type = '" + needed + "'";
                    DataTable tb8 = Search(query8);
                    if (tb8.Rows.Count > 0)
                    {
                        last_main_hours = Convert.ToInt32(tb8.Rows[0][0].ToString());
                    }
                }
                string num = last_hours.Rows[y2][2].ToString();
                string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                True_last_main_type = part2[1];
            }
            ll.Add(True_last_main_type);
            ll.Add(last_main_hours.ToString());
            ll.Add(interval.Rows[0][0].ToString());
            return ll;
        }
        #region MyRegion
        public DataTable search_main(bool equ_state, int equ_id, List<string> main_type_name,
           DateTime main_date_old, DateTime main_date_new, bool state_state,
           string main_state, bool cost_state, decimal main_cost1, decimal main_cost2, bool word, string words)
        {
            DataTable tbl = new DataTable();
            DataTable tb2 = new DataTable();
            DataTable fue = new DataTable();
            DataTable fue2 = new DataTable();
            DataTable oii = new DataTable();
            DataTable oii2 = new DataTable();
            DataTable hor = new DataTable();
            DataTable hor2 = new DataTable();
            DataTable eq = new DataTable();
            DataTable wor = new DataTable();
            string main_state1 = "new";
            string main_state2 = "All Work Hours";
            int main_typeee = -3;
            int main_typee2 = -4;

            if (equ_state == true)
            {
                string query = "select * From maintain Where equ_id = '" + equ_id + "'AND main_date >= '" + main_date_old.Date + "' AND main_date <= '" + main_date_new.Date + "' AND  main_state != '" + main_state1 + "' AND main_state != '" + main_state2 + "' AND main_type != '" + main_typeee + "' AND main_type != '" + main_typee2 + "'ORDER BY main_date";
                tbl = Search(query);
            }
            else
            {
                string query = "select * From maintain Where main_state != '" + main_state1 + "'AND main_date >= '" + main_date_old.Date + "' AND main_date <= '" + main_date_new.Date + "' AND main_state != '" + main_state2 + "' AND main_type != '" + main_typeee + "' AND main_type != '" + main_typee2 + "'ORDER BY main_date";
                tbl = Search(query);
            }

            if (main_type_name.Count >= 1)
            {
                string ssd = "";
                for (int i = 0; i < main_type_name.Count; i++)
                {
                    if (main_type_name[i] == "Corrective Maintenance")
                    {
                        if (ssd == "")
                        {
                            ssd = "main_type = '-1'";
                        }
                        else
                        {
                            ssd = ssd + "or main_type = '-1'";
                        }
                    }
                    if (main_type_name[i] == "Daily Maintenance")
                    {
                        if (ssd == "")
                        {
                            ssd = "main_type = '-2'";
                        }
                        else
                        {
                            ssd = ssd + "or main_type = '-2'";
                        }
                    }
                    if (main_type_name[i] == "Periodic Maintenance")
                    {
                        if (ssd == "")
                        {
                            ssd = "main_type >= '1'";
                        }
                        else
                        {
                            ssd = ssd + "or main_type >= '1'";
                        }
                        //ssd = ssd + "AND main_type >= '1'";
                    }

                }
                DataRow[] resul = tbl.Select(ssd, "main_date ASC");
                tb2 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb2.Rows.Add(row.ItemArray);
                }
                tbl = tb2;
                int x = tbl.Rows.Count;
            }
            if (state_state == true)
            {
                DataRow[] resul = tbl.Select(" main_state = '" + main_state + "'", "main_date ASC");
                tb2 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb2.Rows.Add(row.ItemArray);
                }
                tbl = tb2;
                int x = tbl.Rows.Count;
            }
            
            if (word == true)
            {
                DataRow[] resul = tbl.Select("details like '%" + words + "%'", "main_date ASC");
                tb2 = tbl.Clone();
                foreach (DataRow row in resul)
                {
                    tb2.Rows.Add(row.ItemArray);
                }
                tbl = tb2;
                int x = tbl.Rows.Count;
            }

            tbl.Columns.Add("Oil Cost");
            tbl.Columns.Add("Fuel Cost");
            tbl.Columns.Add("Filters Cost");
            tbl.Columns.Add("Total Cost",typeof(System.Decimal));
            tbl.Columns.Add("Tolerance");
            tbl.Columns.Add("Labors Cost");
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                int fu_cost = 0; int oi_cost = 0; decimal fl_cost = 0; int labor_cost = 0;
                string query13 = "select oil_cost From oil Where main_id ='" + Convert.ToInt32(tbl.Rows[i][0].ToString()) + "'";
                DataTable too = Search(query13);
                for (int z = 0; z < too.Rows.Count; z++)
                {
                    oi_cost = oi_cost + Convert.ToInt32(too.Rows[z][0].ToString());
                }
                string sss = "Add";
                string query14 = "select fuel_cost From fuel Where main_id ='" + tbl.Rows[i][0].ToString() + "' and fuel_active='" + sss + "'";
                DataTable too2 = Search(query14);
                for (int w = 0; w < too2.Rows.Count; w++)
                {
                    fu_cost = fu_cost + Convert.ToInt32(too2.Rows[w][0].ToString());
                }
                string query77 = "select labor_cost From worksalmob Where main_id ='" + tbl.Rows[i][0].ToString() + "'";
                DataTable too7 = Search(query77);
                for (int w = 0; w < too7.Rows.Count; w++)
                {
                    labor_cost = labor_cost + Convert.ToInt32(too7.Rows[w][0].ToString());
                }
                string fll = "Active";
                int ddd = Convert.ToInt32(tbl.Rows[i][0].ToString());
                string query15 = "select filt_cost From filter Where main_id ='" + ddd + "' and filt_active='" + fll + "'";
                DataTable too5 = Search(query15);
                for (int w = 0; w < too5.Rows.Count; w++)
                {
                    fl_cost = fl_cost + Convert.ToDecimal(too5.Rows[w][0].ToString());
                }

                tbl.Rows[i]["Oil Cost"] = oi_cost.ToString();
                tbl.Rows[i]["Fuel Cost"] = fu_cost.ToString();
                tbl.Rows[i]["Filters Cost"] = fl_cost.ToString();
                tbl.Rows[i]["Labors Cost"] = labor_cost.ToString();
            }
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                try
                {
                    tbl.Rows[i]["Total Cost"] = Convert.ToDecimal(tbl.Rows[i]["main_cost"]) + Convert.ToDecimal(tbl.Rows[i]["Labors Cost"]) + Convert.ToDecimal(tbl.Rows[i]["Oil Cost"]) + Convert.ToDecimal(tbl.Rows[i]["Fuel Cost"]) + Convert.ToDecimal(tbl.Rows[i]["Filters Cost"]);
                }
                catch
                {
                   // tbl.Rows[i]["Total Cost"] = "";
                }
            }
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tbl.Rows[i][10].ToString().Contains("Periodic Maintenance"))
                {
                    string num = tbl.Rows[i][10].ToString();
                    string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                    tbl.Rows[i]["Tolerance"] = part2[2];
                    tbl.Rows[i]["main_type_name"] = "Periodic Maintenance";
                }
            }
            int t = tbl.Rows.Count;

            if (cost_state == true)
            {
                if (main_cost2 != -1010101)
                {
                    DataRow[] resul = tbl.Select(" [Total Cost] >= '" + main_cost1 + "' AND [Total Cost] <= '" + main_cost2 + "'", "main_date ASC");
                    tb2 = tbl.Clone();
                    foreach (DataRow row in resul)
                    {
                        tb2.Rows.Add(row.ItemArray);
                    }
                    tbl = tb2;
                }
                else
                {
                    DataRow[] resul = tbl.Select("[Total Cost] >= '" + main_cost1 + "'", "main_date ASC");
                    tb2 = tbl.Clone();
                    foreach (DataRow row in resul)
                    {
                        tb2.Rows.Add(row.ItemArray);
                    }
                    tbl = tb2;
                }
                //DataTable dtt = tbl.Clone();
                //dtt.Columns["main_date"].DataType = typeof(DateTime);
                //foreach (DataRow row in tbl.Rows)
                //{
                //    dtt.Rows.Add(row.ItemArray);
                //}
                //dtt.DefaultView.Sort = "details ASC";
                //return dtt;
            }
           
            return tbl;
        }
        public int get_hours_by_id(int main_id)
        {
            string query = "select main_periodnum From maintain Where main_id ='" + main_id + "'";
            DataTable tbl = Search(query);
            return Convert.ToInt32(tbl.Rows[0][3].ToString());
        }
        public string[] bring_prev(int main_id)
        {
            string query2 = "select * From maintain Where main_id= '" + main_id + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tb2 = Search(query2);
            int y2 = tb2.Rows.Count;
            string[] state;
            if (y2 > 0)
            {
                y2 = 1;
                state = new string[14];
                state[0] = tb2.Rows[y2 - 1][0].ToString();
                state[1] = tb2.Rows[y2 - 1][2].ToString();
                state[2] = tb2.Rows[y2 - 1][3].ToString();
                state[3] = tb2.Rows[y2 - 1][4].ToString();
                state[4] = tb2.Rows[y2 - 1][5].ToString();
                state[5] = tb2.Rows[y2 - 1][6].ToString();
                state[6] = tb2.Rows[y2 - 1][7].ToString();
                state[7] = tb2.Rows[y2 - 1][8].ToString();
                state[8] = tb2.Rows[y2 - 1][9].ToString();
                state[9] = tb2.Rows[y2 - 1][10].ToString();
                state[10] = tb2.Rows[y2 - 1][11].ToString();
                state[11] = tb2.Rows[y2 - 1][12].ToString();
                state[12] = tb2.Rows[y2 - 1][13].ToString();
                state[13] = tb2.Rows[y2 - 1][1].ToString();
                return state;
            }
            return state = new string[0];
        }
        public int bring_new_main_id()
        {
            string query = " select Max(main_id) from maintain";
            DataTable tbl = Search(query);

            int x = Convert.ToInt32(tbl.Rows[0][0].ToString());
            string query2 = " select equ_id,main_type_name from maintain where main_id = '" + x + "'";
            DataTable tb2 = Search(query2);
            this.main_type_name = tb2.Rows[0][1].ToString();
            this.equ_id = Convert.ToInt32(tb2.Rows[0][0].ToString());
            return x;
        }
        public string del_last_main()
        {
            string query = " select Max(main_id) from maintain";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count != 0)
            {
                this.main_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                if (q() == true)
                {
                    return "Success";
                }
                else { return "Failed"; }
            }
            else { return "Failed"; }
        }
        public DataTable bring_all_prev_hours(int equ_id)
        {
            main_state = "new";
            string query2 = "select main_id,main_periodnum From maintain Where equ_id ='" + equ_id + "' and  main_state ='" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            return Searcheq(query2);
        }
        public string bring_all_prev_parts(int equ_id, int main_periodnum)
        {
            main_state = "new";
            string query2 = "select main_part,main_cost From maintain Where equ_id ='" + equ_id + "' AND  main_periodnum ='" + main_periodnum + "' AND  main_state ='" + main_state + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tbl = Search(query2);
            this.main_cost = Convert.ToInt32(tbl.Rows[0][1].ToString());
            return tbl.Rows[0][0].ToString();
        }
        public DataTable Searcheq(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch { return new DataTable(); }
        }
        public int update_cost(int main_id, DataTable dataa)
        {
            int total_cost = 0;
            if (main_id == 0)
            {
                main_id = bring_new_main_id();
            }
            for (int d = 0; d < dataa.Rows.Count; d++)
            {
                total_cost = total_cost + Convert.ToInt32(dataa.Rows[d][9].ToString());
            }
            this.main_id = main_id;
            this.labors_cost = total_cost;
            if (m2() == true)
            {
                return total_cost;
            }
            else { return total_cost; }
        }
        public int ava_hours(int equ_id, DateTime dateee)
        {
            int used_hours = 0;
            int xs = 0;

            string main_state1 = "new";
            string main_state2 = "All Work Hours";
            string query = "select main_hours_repair From maintain Where equ_id = '" + equ_id + "' AND main_date = '" + dateee + "' AND  main_state != '" + main_state1 + "' AND  main_state != '" + main_state2 + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
            DataTable tb1 = Search(query);
            for (int i = 0; i < tb1.Rows.Count; i++)
            {
                xs = xs + Convert.ToInt32(tb1.Rows[i][0].ToString());
            }

            string query2 = "select hours From equ_work_h Where equ_id='" + equ_id + "' AND date ='" + dateee + "'";
            DataTable tb2 = Search(query2);
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                used_hours = used_hours + Convert.ToInt32(tb2.Rows[i][0].ToString());
            }
            this.main_hours_repair = xs;
            int res;
            if(if_km(equ_id))
            {
                xs = xs * 83;
                res = (2000 - used_hours - xs);
            }
            else
            {
                res = (24 - used_hours - xs);
            }
            return res;
        }
        public DataTable main_hours(int equ_id, DateTime main_date_old, DateTime main_date_new)
        {
            DataTable tbl = new DataTable();
            DataTable tb2 = new DataTable();
            DataTable tb3 = new DataTable();
            tb2.Columns.Add("Date");
            tb2.Columns.Add("tot");
            DataRow dr = null;
            string main_state1 = "new";
            string main_state2 = "All Work Hours";
            string query = "select * From maintain Where equ_id = '" + equ_id + "' AND main_date >= '" + main_date_old + "'AND  main_date <= '" + main_date_new + "' AND  main_state != '" + main_state1 + "' AND  main_state != '" + main_state2 + "'AND main_type !='" + main_typeew + "'AND main_type !='" + main_typeew2 + "'";
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
                dr["tot"] = 24 - tot;
                tb2.Rows.Add(dr);
            }
            return tb2;
        }
        public string del_main(int main_id)
        {
            this.main_id = main_id;
            if (q() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable get_them_all(string type)
        {
            string query = "select * From " + type + " ";
            DataTable tbl = Search(query);
            int s = tbl.Rows.Count;
            return tbl;
        }
        public string get_new_check_list(int equ_id)
        {
            int main_type = -3;
            string query = "select main_part From maintain Where equ_id ='" + equ_id + "' AND main_type ='" + main_type + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count != 0)
            {
                return tbl.Rows[0][0].ToString();
            }
            return "a";
        }
        public string Addchecklist(int maiin_iid, string main_part, string main_state,
           DateTime main_date, string eng_name, int user_id, string main_state_details)
        {
            this.main_id = 2;
            this.equ_id = maiin_iid;
            this.main_type = -4;
            this.main_periodnum = 0;
            this.main_part = main_part;
            this.main_state = main_state;
            this.main_cost = 0;
            this.main_date = main_date;
            this.details = eng_name;
            this.user_id = user_id;
            this.main_type_name = "Daily Check";
            this.main_state_details = main_state_details;
            this.main_hours_repair = 0;
            this.labors_cost = 0;
            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public bool check_daily_bring(int main_id)
        {
            string vd = "Daily Check"; int ew = -4;
            DataTable tbl = new DataTable();
            string query = "select * From maintain Where equ_id = '" + main_id + "' AND  main_type_name = '" + vd + "' AND  main_type = '" + ew + "'";
            tbl = Search(query);
            if (tbl.Rows.Count >= 1)
            {
                this.table = tbl;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string delete_dai_ch(int main_id)
        {
            string vd = "Daily Check"; int ew = -4;
            string query = "select main_id From maintain Where equ_id = '" + main_id + "' AND  main_type_name = '" + vd + "' AND  main_type = '" + ew + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count >= 1)
            {
                this.table = tbl;
                int iddd = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.main_id = iddd;
                if (q() == true)
                {
                    return "Success";
                }
                else { return "Failed"; }
            }
            else
            {
                return "Success";
            }
        }
        public string update_checklist(int main_iddd, int maiin_iid, string main_part, string main_state,
         DateTime main_date, string eng_name, int user_id, string main_state_details)
        {
            this.main_id = main_iddd;
            this.equ_id = maiin_iid;
            this.main_type = -4;
            this.main_periodnum = 0;
            this.main_part = main_part;
            this.main_state = main_state;
            this.main_cost = 0;
            this.main_date = main_date;
            this.details = eng_name;
            this.user_id = user_id;
            this.main_type_name = "Daily Check";
            this.main_state_details = main_state_details;
            this.main_hours_repair = 0;
            this.labors_cost = 0;
            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable find_text(string word)
        {
            string query2 = "select main_id From maintain Where details collate Latin1_General_CI_AS like N'%" + word + "%' collate Latin1_General_CI_AS";
            DataTable tb2 = Search(query2);
            int rr = tb2.Rows.Count;
            return tb2;
        }
        public int Get_last_Done_periodic(int equ_id)
        {
            int main_typse = 1;
            string staa = "Done";
            string query2 = "select main_type,main_periodnum,main_type_name From maintain Where equ_id ='" + equ_id + "' AND  main_state = '" + staa + "' AND  main_type >= '" + main_typse + "'";
            DataTable tb1 = Search(query2);
            int last_done_main = 0;
            if (tb1.Rows.Count > 0)
            {
                for (int i = 0; i < tb1.Rows.Count; i++)
                {
                    string num = tb1.Rows[i][2].ToString();
                    string[] part2 = System.Text.RegularExpressions.Regex.Split(num, "<#>");
                    if (Convert.ToInt32(part2[1]) >= last_done_main)
                    {
                        last_done_main = Convert.ToInt32(part2[1]);                       //real stage num
                        this.main_type = Convert.ToInt32(tb1.Rows[i][0].ToString());      //stage num
                        this.main_periodnum = Convert.ToInt32(tb1.Rows[i][1].ToString());  //hours when done
                    }
                }
                this.main_state_details = Get_periodic_interval(equ_id, main_type);
            }
            return last_done_main;
        }
        public string Get_periodic_interval(int equ_id, int main_type)
        {
            main_state = "new";
            string query = "select main_state_details From maintain Where equ_id ='" + equ_id + "' AND  main_state= '" + main_state + "'AND main_type ='" + main_type + "'";
            DataTable tbl = Search(query);
            return tbl.Rows[0][0].ToString();
        } 
        #endregion
        public List<string> alert(int equ_id,int main_periodnum)
        {
            List<string> res = new List<string>();
            string[] state = hole(equ_id, main_periodnum);

            int last_stage = Get_last_Done_periodic(equ_id);
            if (state[0] == "-1")
            {
                res.Add("Green");
                res.Add(state[1]);
                res.Add("");
            }
            else if (state[0] == "26")
            {
                res.Add("Green");
                res.Add(state[1]);
                res.Add("");
            }
            else if (state[0] == "27")
            {
                res.Add("yellow");
                res.Add("Current Periodic Interval need to be Complete");
                res.Add("");
            }
            else if (state[0] == "19" || state[0] == "18" )
            {
                res.Add("Green");
                res.Add(state[1]);
                res.Add(state[2]);
            }
            else if (state[0] == "17" || state[0] == "270")
            {
                res.Add("Red");
                res.Add("Last Periodic Interval must be Completed");
                res.Add("No Past Periodic Maintenance");
            }
            else if (state[0] == "25")
            {
                res.Add("Red");
                res.Add("Last Periodic Interval must be Completed");
                res.Add("");
            }

            if (/*last_stage !=0*/ false)
            {
                int limits = 25;
                if (if_km(equ_id))
                {
                    limits = limits * 50;
                }
                int last_done_main_hours = this.main_periodnum;
                int interval = Convert.ToInt32(this.main_state_details);
                if ((main_periodnum - last_done_main_hours) < interval - limits)
                {
                    res.Add("Green");
                    res.Add("");
                    res.Add("");
                }
                else if (((main_periodnum - last_done_main_hours) >= interval - limits) && ((main_periodnum - last_done_main_hours) <= interval + limits))
                {
                    res.Add("yellow");
                    res.Add("Current Periodic Interval need to be Complete");
                    res.Add("");
                }
                else if ((main_periodnum - last_done_main_hours) > interval + limits)
                {
                    res.Add("Red");
                    res.Add("Last Periodic Interval must be Completed");
                    res.Add("");
                }
            }
            else if(false)
            {

                res.Add("Red");
                res.Add("Last Periodic Interval must be Completed");
                res.Add("No Past Periodic");
            }

            return res;
        }
        public string rep_cost(int equ_id, DateTime old, DateTime fut)
        {
            string ss = "";
            if (equ_id != -1)
            {
                ss = "equ_id= '" + equ_id + "' AND ";
            }
            string main_state1 = "new";
            string main_state2 = "All Work Hours"; 
            int ew = -2;
            string query2 = "select main_cost From maintain Where " + ss+" main_date >= '" + old + "'AND main_date <= '" + fut + "'AND  main_state != '" + main_state1 + "' AND  main_state != '" + main_state2 + "'AND main_type >='" + ew + "'";
            DataTable tb2 = Search(query2);
            double dd = 0;
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                dd = dd + Convert.ToDouble(tb2.Rows[i][0].ToString());
            }
            return dd.ToString();
        }
        public string add_new_eq_hu(int equ_id)
        {
            this.main_id = 2;
            this.equ_id = equ_id;
            this.main_type = 0;
            this.main_periodnum = 0;
            this.main_part = "";
            this.main_state = "All Work Hours";
            this.main_cost = 0;
            this.main_date = DateTime.Now.Date;
            this.details = "";
            this.user_id = 1;
            this.main_type_name = "";
            this.main_state_details = "";
            this.main_hours_repair = 0;
            this.labors_cost = 0;


            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string add_new_eq_chk(int equ_id)
        {
            this.main_id = 2;
            this.equ_id = equ_id;
            this.main_type = -3;
            this.main_periodnum = 0;
           
            this.main_part = "الكشف على الإطارات<#>الكشف على المحرك<#>الكشف على مستوى الزيوت<#>الكشف على العدادات<#>الكشف على الكهرباء<#>الكشف على مستوى الوقود<#>";
            this.main_state = "Daily Check";
            this.main_cost = 0;
            this.main_date = DateTime.Now.Date;
            this.details = "";
            this.user_id = 1;
            this.main_type_name = "Daily Check";
            this.main_state_details = "";
            this.main_hours_repair = 0;
            this.labors_cost = 0;


            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string add_new_eq_per(int equ_id,int oldd)
        {
            main_state = "new";
            string query313 = "select * From maintain Where equ_id ='" + oldd + "' AND main_state = '" + main_state + "' ORDER BY main_type";
            DataTable tb2 = Search(query313);
            int y313 = tb2.Rows.Count;

            for (int y2 = 0; y2 < y313; y2++)
            {
                this.main_id = 2;
                this.equ_id= equ_id;
                this.main_type = Convert.ToInt32(tb2.Rows[y2][2].ToString());
                this.main_periodnum = Convert.ToInt32(tb2.Rows[y2][3].ToString());
                this.main_part = tb2.Rows[y2][4].ToString();
                this.main_state = tb2.Rows[y2][5].ToString();
                this.main_cost = 0;
                this.main_date = Convert.ToDateTime(tb2.Rows[y2][7].ToString());
                this.details= tb2.Rows[y2][8].ToString();
                this.user_id = Convert.ToInt32(tb2.Rows[y2][9].ToString());
                this.main_type_name = tb2.Rows[y2][10].ToString();
                this.main_state_details = tb2.Rows[y2][11].ToString();
                this.main_hours_repair = 0;
                this.labors_cost = 0 ;
                a();
            }
            return "";
        }
        public DataTable get_all()
        {
            string query = string.Format("select * From maintain");
            return Search(query);
        }
        public string gig(int equ_id)
        {
            main_state = "new";
            string query313 = "select * From maintain Where equ_id ='" + equ_id + "' AND main_state = '" + main_state + "' ORDER BY main_type";
            DataTable tb2 = Search(query313);
            int y313 = tb2.Rows.Count;

            for (int y2 = 0; y2 < y313; y2++)
            {
                this.main_id = Convert.ToInt32(tb2.Rows[y2][0].ToString());
                this.equ_id = equ_id;
                this.main_type = Convert.ToInt32(tb2.Rows[y2][2].ToString());
                this.main_periodnum = Convert.ToInt32(tb2.Rows[y2][3].ToString()) * 50 ;
                this.main_part = tb2.Rows[y2][4].ToString();
                this.main_state = tb2.Rows[y2][5].ToString();
                this.main_cost = 0;
                this.main_date = Convert.ToDateTime(tb2.Rows[y2][7].ToString());
                this.details = tb2.Rows[y2][8].ToString();
                this.user_id = Convert.ToInt32(tb2.Rows[y2][9].ToString());
                this.main_type_name = tb2.Rows[y2][10].ToString();
                this.main_state_details =Convert.ToString(Convert.ToInt32( tb2.Rows[y2][11].ToString())*50);
                this.main_hours_repair = 0;
                this.labors_cost = 0;
                u();
            }
            return "";
        }

        public string update_new_cost(int main_id, int main_cost)
        {
            string query313 = "select * From maintain Where main_id ='" + main_id + "'";
            DataTable tb2 = Search(query313);
            int y2 = 0;
            this.main_id = main_id;
            try
            {

            }
            catch
            {

            }
            this.equ_id = Convert.ToInt32(tb2.Rows[y2][1].ToString());
            this.main_type = Convert.ToInt32(tb2.Rows[y2][2].ToString());
            this.main_periodnum = Convert.ToInt32(tb2.Rows[y2][3].ToString());
            this.main_part = tb2.Rows[y2][4].ToString();
            this.main_state = tb2.Rows[y2][5].ToString();
            this.main_cost = main_cost;
            this.main_date = Convert.ToDateTime(tb2.Rows[y2][7].ToString());
            this.details = tb2.Rows[y2][8].ToString();
            this.user_id = Convert.ToInt32(tb2.Rows[y2][9].ToString());
            this.main_type_name = tb2.Rows[y2][10].ToString();
            this.main_state_details = tb2.Rows[y2][11].ToString(); 
            if(tb2.Rows[y2][12].ToString() !="")
            {
                this.main_hours_repair = Convert.ToInt32(tb2.Rows[y2][12].ToString());
            }
            else
            {
                this.main_hours_repair = 0;
            }
            if (tb2.Rows[y2][13].ToString() != "")
            {
                this.labors_cost = Convert.ToInt32(tb2.Rows[y2][13].ToString());
            }
            else
            {
                this.labors_cost = 0;
            }

            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
    }
}
