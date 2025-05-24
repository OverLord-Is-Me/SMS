using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace notfinal
{
    class equ : print_ecxel_report
    {
        #region MyRegion
        private int _equ_id;
        private string _equ_sn;
        private string _equ_type_id;
        private string _equ_arr;
        private decimal _equ_lenght;
        private decimal _equ_hight;
        private decimal _equ_width;
        private decimal _equ_weight;
        private string _eng_sn;
        private string _eng_power;
        private string _eng_highidle;
        private string _eng_lowidle;
        private string _eng_belt_size;
        private string _ac_belt_size;
        private string _mag_belt_size;
        private string _tier_size;
        private string _trans_sn;
        private int _user_id;
        private string _max_size_by_gram;
        private string _password;

        public string max_size_by_gram
        {
            get
            {
                return _max_size_by_gram;
            }
            set
            { _max_size_by_gram = value; }
        }
        public string password
        {
            get
            {
                return _password;
            }
            set
            { _password = value; }
        }
        public int equ_id
        {
            get { return _equ_id; }
            set { _equ_id = value; }
        }
        public string equ_sn
        {
            get
            {
                return _equ_sn;
            }
            set
            { _equ_sn = value; }
        }
        public string equ_arr
        {
            get
            {
                return _equ_arr;
            }
            set
            { _equ_arr = value; }
        }
        public decimal equ_lenght
        {
            get
            {
                return _equ_lenght;
            }
            set
            { _equ_lenght = value; }
        }
        public decimal equ_hight
        {
            get
            {
                return _equ_hight;
            }
            set
            { _equ_hight = value; }
        }
        public decimal equ_width
        {
            get
            {
                return _equ_width;
            }
            set
            { _equ_width = value; }
        }
        public decimal equ_weight
        {
            get
            {
                return _equ_weight;
            }
            set
            { _equ_weight = value; }
        }

       

        public string equ_type_id
        {
            get
            {
                return _equ_type_id;
            }
            set
            { _equ_type_id = value; }
        }
        public string eng_sn
        {
            get
            {
                return _eng_sn;
            }
            set
            { _eng_sn = value; }
        }
        public string eng_power
        {
            get
            {
                return _eng_power;
            }
            set
            { _eng_power = value; }
        }
        public string eng_highidle
        {
            get
            {
                return _eng_highidle;
            }
            set
            { _eng_highidle = value; }
        }
        public string eng_lowidle
        {
            get
            {
                return _eng_lowidle;
            }
            set
            { _eng_lowidle = value; }
        }
        public string trans_sn
        {
            get
            {
                return _trans_sn;
            }
            set
            { _trans_sn = value; }
        }
        public string tier_size
        {
            get
            {
                return _tier_size;
            }
            set
            { _tier_size = value; }
        }
        public string eng_belt_size
        {
            get
            {
                return _eng_belt_size;
            }
            set
            { _eng_belt_size = value; }
        }
        public string ac_belt_size
        {
            get
            {
                return _ac_belt_size;
            }
            set
            { _ac_belt_size = value; }
        }
        public string mag_belt_size
        {
            get
            {
                return _mag_belt_size;
            }
            set
            { _mag_belt_size = value; }
        }
        public int user_id
        {
            get
            {
                return _user_id;
            }
            set
            { _user_id = value; }
        }

        #endregion

        protected override bool lsl(char op)
        {
            SortedList SL = new SortedList();
            SL.Add("Check", op);
            SL.Add("equ_id", equ_id);
            SL.Add("equ_sn", equ_sn);
            SL.Add("equ_type_id", equ_type_id);
            SL.Add("equ_arr", equ_arr);
            SL.Add("equ_lenght", equ_lenght);
            SL.Add("equ_hight", equ_hight);
            SL.Add("equ_width", equ_width);
            SL.Add("equ_weight", equ_weight);
            SL.Add("eng_sn", eng_sn);
            SL.Add("eng_power", eng_power);
            SL.Add("eng_highidle", eng_highidle);
            SL.Add("eng_lowidle", eng_lowidle);
            SL.Add("eng_belt_size", eng_belt_size);
            SL.Add("ac_belt_size", ac_belt_size);
            SL.Add("mag_belt_size", mag_belt_size);
            SL.Add("tier_size", tier_size);
            SL.Add("trans_sn", trans_sn);
            SL.Add("user_id", user_id);
            SL.Add("max_size_by_gram", max_size_by_gram);
            SL.Add("password", password);

            if (DB.RunProcrduer("proequ", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        
        public string mac()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {

                string tempMac = nic.GetPhysicalAddress().ToString();
                System.Windows.Forms.MessageBox.Show(tempMac);
            }

            return macAddress;
        }
        public string Addequ(string equ_sn,string equ_type_id, string equ_arr,string equ_lenght, string equ_hight, string equ_width,
            string equ_weight,string eng_sn, string eng_power, string eng_highidle,string eng_lowidle,string eng_belt_size, string ac_belt_size
            , string mag_belt_size,string tier_size, string trans_sn)
        {
            this.equ_id = 2;
            this.equ_sn = equ_sn;
            this.equ_type_id = equ_type_id;
            this.equ_arr = equ_arr;
            this.equ_lenght =Convert.ToDecimal( equ_lenght);
            this.equ_hight = Convert.ToDecimal(equ_hight);
            this.equ_width = Convert.ToDecimal(equ_width);
            this.equ_weight = Convert.ToDecimal(equ_weight);
            this.eng_sn = eng_sn;
            this.eng_power = eng_power;
            this.eng_highidle = eng_highidle;
            this.eng_lowidle = eng_lowidle;
            this.eng_belt_size = eng_belt_size;
            this.ac_belt_size = ac_belt_size;
            this.mag_belt_size = mag_belt_size;
            this.tier_size = tier_size;
            this.trans_sn = trans_sn;
            this.user_id = 1 ;

            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable get_all()
        {
            string query = string.Format("select * From equ");
            return Search(query);
        }
        public DataTable Searchequ22(int equ_id)
        {
            string query = string.Format("select * From equ Where equ_id= '" + equ_id + "'");
            return Searchequ(query);
        }
        public string Searchequ(int equ_id)
        {
            string query = string.Format("select equ_type_id From equ Where equ_id= '" + equ_id + "'");
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return "";
            }
            else
            {
                this.equ_type_id = tbl.Rows[0][0].ToString();               
                return equ_type_id;
            }
        }
        public int Search_equ_by_name(string equ_type_id)
        {
            string query = string.Format("select equ_id From equ Where equ_type_id= '" + equ_type_id + "'");
            DataTable tbl = Search(query);
            if (tbl.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                this.equ_id =Convert.ToInt32(tbl.Rows[0][0].ToString());
                return equ_id;
            }
        }
        public DataTable bring_names_id()
        {
            string query = string.Format("select equ_id,equ_type_id From equ");
            return Searchequ(query);
        }
        public DataTable Searchequ(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch { return new DataTable(); }

        }

        public DataTable gettt2()
        {
            string query = string.Format("select equ_id,equ_type_id From equ");
            return Searchequ(query);
        }


    }

}
