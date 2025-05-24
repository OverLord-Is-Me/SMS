using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace notfinal
{
    class userss : print_ecxel_report
    {
        private int _user_id;
        private string _username;
        private string _password;
        private string _type;

        public int user_id
        {
            get
            {
                return _user_id;
            }

            set
            {
                _user_id = value;
            }
        }
        public string username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }
        public string password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
        public string type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("user_id", user_id);
            SL.Add("username", username);
            SL.Add("password", password);
            SL.Add("type", type);

            if (DB.RunProcrduer("prouserss", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public string Adduser(string username, string password, string type)

        {   this.user_id = 2;
            this.username = username;
            this.password = password;
            this.type = type;
            if (a() == true)
            {return "Success";}
            else { return "Failed"; }
        }
        public string Updateuser(int user_id,string username, string password, string type)
        {
            this.user_id = user_id;
            this.username = username;
            this.password = password;
            this.type = type;

            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string deluser(int user_id)
        {
            this.user_id = user_id;
            if (q() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public bool Finduserdata(string username, string password)
        {
            string query = "select * From userss Where username ='" + username + "' AND  password= '" + password + "'";
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.user_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.username = tbl.Rows[0][1].ToString();
                this.password = tbl.Rows[0][2].ToString();
                this.type = tbl.Rows[0][3].ToString();
                return true;
            }
        }








    }
}
