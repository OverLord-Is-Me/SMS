using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;

namespace notfinal
{
    class fuel : print_ecxel_report
    {
        #region MyRegion
        private int _fuel_id;
        private int _equ_id;
        private string _fuel_type;
        private string _fuel_name;
        private decimal _fuel_cap;
        private int _fuel_cost;
        private DateTime _fuel_date;
        private int _user_id;
        private int _main_hours;
        private string _fuel_active;
        private int _main_id;

        maintain ma = new maintain();
        public int main_id
        {
            get
            { return _main_id; }
            set
            { _main_id = value; }
        }
        public int main_hours
        {
            get
            { return _main_hours; }
            set
            { _main_hours = value; }
        }
        public string fuel_active
        {
            get
            { return _fuel_active; }
            set
            { _fuel_active = value; }
        }
        public int fuel_id
        {
            get
            { return _fuel_id; }
            set
            { _fuel_id = value; }
        }
        public int equ_id
        {
            get
            { return _equ_id; }
            set
            { _equ_id = value; }
        }
        public string fuel_type
        {
            get
            { return _fuel_type; }
            set
            { _fuel_type = value; }
        }
        public string fuel_name
        {
            get
            { return _fuel_name; }
            set
            { _fuel_name = value; }
        }
        public decimal fuel_cap
        {
            get
            { return _fuel_cap; }
            set
            { _fuel_cap = value; }
        }
        public int fuel_cost
        {
            get
            { return _fuel_cost; }
            set
            { _fuel_cost = value; }
        }
        public DateTime fuel_date
        {
            get
            { return _fuel_date; }
            set
            { _fuel_date = value; }
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
            SL.Add("fuel_id", fuel_id);
            SL.Add("equ_id", equ_id);
            SL.Add("fuel_type", fuel_type);
            SL.Add("fuel_name", fuel_name);
            SL.Add("fuel_cap", fuel_cap);
            SL.Add("fuel_cost", fuel_cost);
            SL.Add("fuel_date", fuel_date);
            SL.Add("user_id", user_id);
            SL.Add("main_hours", main_hours); 
            SL.Add("fuel_active", fuel_active);
            SL.Add("main_id", main_id);

            if (DB.RunProcrduer("profuel", SL) == 1)
            {
                return true;
            }
            else { return false; }
        }
        public string Addfuel(int equ_id,string fuel_type,string fuel_name,decimal fuel_cap,
         int fuel_cost,DateTime fuel_date, int user_id, int main_hours, string fuel_active,int main_id)
        {
            this.fuel_id = 2;
            this.equ_id = equ_id;
            this.fuel_type = fuel_type;
            this.fuel_name = fuel_name;
            this.fuel_cap = fuel_cap;
            this.fuel_cost = fuel_cost;
            this.fuel_date = fuel_date;
            this.user_id = user_id;
            this.main_hours = main_hours;
            this.fuel_active = fuel_active;
            this.main_id = main_id;
            if (a() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable Searchfuel(string query)
        {
            try
            {
                return DB.RunQury(query);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);  return new DataTable(); }
        }  
        public string delfuel(int fuel_id)
        {
            work_sal_mob ss = new work_sal_mob();
            if (!ss.del_job("Add Fuel", fuel_id.ToString()))
            {
                return "Failed";
            }
            this.fuel_id = fuel_id;
            if (q() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public string delfuelrep(int main_id)
        {
            string st = "Success";
            string query = "select fuel_id From fuel Where main_id ='" + main_id + "'";
            DataTable tbl = Searchfuel(query);
            if (tbl.Rows.Count == 0)
            {
                return st;
            }
            else
            {
                for (int x = 0; x < tbl.Rows.Count; x++)
                {
                    this.fuel_id = Convert.ToInt32(tbl.Rows[x][0].ToString());
                    if (q() == true)
                    {

                    }
                    else { st = "Failed"; }
                }
            }
            return st;
        }
        public bool Findfuel(int fuel_id)
        {
            string query = "select * From fuel WHERE fuel_id ='" + fuel_id + "'";
            DataTable tbl = Searchfuel(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.fuel_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.fuel_type = tbl.Rows[0][2].ToString();
                this.fuel_name = tbl.Rows[0][3].ToString();
                this.fuel_cap = Convert.ToDecimal(tbl.Rows[0][4].ToString());
                this.fuel_cost = Convert.ToInt32(tbl.Rows[0][5].ToString());
                this.fuel_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.main_hours = Convert.ToInt32(tbl.Rows[0][8].ToString());
                this.fuel_active = tbl.Rows[0][9].ToString();
                this.main_id = Convert.ToInt32(tbl.Rows[0][10].ToString());
                return true;
            }
        }
        public DataTable Find_fuel_with_main(string main_id)
        {
            string query = "select * From fuel Where main_id ='" + main_id + "'";
            DataTable tbl = Searchfuel(query);
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
        public string updatefuel(int fuel_id, int equ_id, string fuel_type, string fuel_name, decimal fuel_cap, int fuel_cost,
        DateTime fuel_date, int user_id, int main_hours, string fuel_active,int main_id)
        {
            this.fuel_id = fuel_id;
            this.equ_id = equ_id;
            this.fuel_type = fuel_type;
            this.fuel_name = fuel_name;
            this.fuel_cap = fuel_cap;
            this.fuel_cost = fuel_cost;
            this.fuel_date = fuel_date;
            this.user_id = user_id;
            this.main_hours = main_hours; 
            this.fuel_active = fuel_active;
            this.main_id = main_id;

            if (u() == true)
            {
                return "Success";
            }
            else { return "Failed"; }
        }
        public DataTable Find_fuel_show_data(int equ_id)
        {
            string ss = "Catalogue";
            string query = "select * From fuel Where equ_id= '" + equ_id + "' AND fuel_active = '" + ss + "'";
            DataTable tb3 = Search(query);
            int r = tb3.Rows.Count;
            return tb3;
        }
        public DataTable Find_fuel_show_data_equ(int equ_id)
        {
            string star = "Catalogue";
            string query = "select * From fuel Where equ_id= '" + equ_id + "'AND fuel_active = '" + star + "' ";
            DataTable tb3 = Search(query);
            int r = tb3.Rows.Count;
            return tb3;
        }
        public void ExportToPdf(DataTable datag,string file_name)
        {
            if (datag.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = file_name; 
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            try
                            {
                                sfd.FileName = file_name+" (1)";
                                if (File.Exists(sfd.FileName))
                                {
                                    sfd.FileName = file_name + " (2)";
                                    if (File.Exists(sfd.FileName))
                                    {
                                        sfd.FileName = file_name + " (3)";
                                    }
                                }
                                }
                            catch
                            {
                                File.Delete(sfd.FileName);
                            }
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk.Please try to change the name" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            iTextSharp.text.pdf.PdfPTable pdfTable = new iTextSharp.text.pdf.PdfPTable(datag.Columns.Count);
                            //pdfTable.DefaultCell.Padding = 3;
                            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            pdfTable.WidthPercentage = 75;
                            pdfTable.DefaultCell.MinimumHeight = 22f;
                            foreach (DataColumn column in datag.Columns)
                            {
                                iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell();
                                Paragraph p = new Paragraph(column.ColumnName);
                                p.Alignment = Element.ALIGN_CENTER;
                                var fodnt = FontFactory.GetFont("Courier", 14.0f, Font.BOLD);                              
                                p.Font = fodnt;
                                cell.AddElement(p);
                                pdfTable.AddCell(cell);
                            }
                            for (int z = 0; z < datag.Rows.Count;z++)
                            {
                                for (int i = 0; i < datag.Columns.Count; i++)
                                {
                                    var cellss = new iTextSharp.text.pdf.PdfPCell();
                                    Paragraph p = new Paragraph(datag.Rows[z][i].ToString());
                                    p.Alignment = Element.ALIGN_CENTER;
                                    
                                    cellss.AddElement(p);
                                    pdfTable.AddCell(cellss);
                                }
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 20f, 30f, 30f, 20f);
                                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                var imagepath = @"C:\Users\OverLord\Desktop\a222 (2).png";
                                using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                                {
                                    var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), System.Drawing.Imaging.ImageFormat.Png);
                                    png.ScalePercent(20f);
                                    //png.ScaleToFit(pdfDoc.PageSize);
                                    png.SetAbsolutePosition(pdfDoc.Left + 20, pdfDoc.Top - 70);
                                    pdfDoc.Add(png);
                                }
                                var spacer = new iTextSharp.text.Paragraph("")
                                {
                                    SpacingBefore = 50f,
                                    SpacingAfter = 50f,
                                };
                                pdfDoc.Add(spacer);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        public void round_pic(PictureBox picc)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picc.Width - 3, picc.Height - 3);
            System.Drawing.Region rg = new System.Drawing.Region(gp);
            picc.Region = rg;
        }
        public bool Find_Catalogue_fuel(int equ_id)
        {
            string star = "Catalogue";
            string query = "select * From fuel Where equ_id= '" + equ_id + "' AND fuel_active = '" + star + "'";/**/
            DataTable tbl = Search(query);
            int r = tbl.Rows.Count;
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.fuel_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.fuel_type = tbl.Rows[0][2].ToString();
                this.fuel_name = tbl.Rows[0][3].ToString();
                this.fuel_cap = Convert.ToDecimal(tbl.Rows[0][4].ToString());
                this.fuel_cost = Convert.ToInt32(tbl.Rows[0][5].ToString());
                this.fuel_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.main_hours = Convert.ToInt32(tbl.Rows[0][8].ToString());
                this.fuel_active = tbl.Rows[0][9].ToString();
                this.main_id = Convert.ToInt32(tbl.Rows[0][10].ToString());
                return true;
            }
        }
        public bool Findfuelforpop222(int main_id)
        {
            string star = "Add";
            string query = "select * From fuel Where main_id ='" + main_id + "' AND fuel_active = '" + star + "'";
            DataTable tbl = Searchfuel(query);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                this.fuel_id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                this.equ_id = Convert.ToInt32(tbl.Rows[0][1].ToString());
                this.fuel_type = tbl.Rows[0][2].ToString();
                this.fuel_name = tbl.Rows[0][3].ToString();
                this.fuel_cap = Convert.ToDecimal(tbl.Rows[0][4].ToString());
                this.fuel_cost = Convert.ToInt32(tbl.Rows[0][5].ToString());
                this.fuel_date = Convert.ToDateTime(tbl.Rows[0][6].ToString());
                this.user_id = Convert.ToInt32(tbl.Rows[0][7].ToString());
                this.main_hours = Convert.ToInt32(tbl.Rows[0][8].ToString());
                this.fuel_active = tbl.Rows[0][9].ToString();
                this.main_id = Convert.ToInt32(tbl.Rows[0][10].ToString());
                return true;
            }
        }

        public string cal_cost_per(int eqi_id)
        {
            decimal tot = 0;
            string query2 = "select * From Fuel Where equ_id= '" + eqi_id + "' AND fuel_active != 'Catalogue'";
            DataTable tb2 = Searchfuel(query2);
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                tot = tot + Convert.ToInt32(tb2.Rows[i][5].ToString());
            }
            int hoo = 0;
            string query1 = "select * From equ_work_h Where equ_id= '" + eqi_id + "'";
            DataTable tb1 = Searchfuel(query1);
            for (int i = 0; i < tb1.Rows.Count; i++)
            {
                hoo = hoo + Convert.ToInt32(tb1.Rows[i][2].ToString());
            }
            if (hoo == 0) { hoo = 1; }
            decimal gg = tot / hoo;
            return gg.ToString("0.##") + " L";
        }

        public DataTable Find_fuel_show_search(bool equ_state, int equ_id, DateTime main_date_old, DateTime main_date_new)
        {
            DataTable tbl = new DataTable();
            DataTable tb2 = new DataTable();
            bool date_state = true;
            string ss = "Catalogue";
            if (equ_state == true)
            {
                string query = "select * From fuel Where equ_id = '" + equ_id + "' AND fuel_active != '" + ss + "'";
                tbl = Search(query);
            }
            else
            {
                string query = "select * From fuel where fuel_active != '" + ss + "'";
                tbl = Search(query);
            }
            int x = tbl.Rows.Count;
            if (date_state == true)
            {
                DataRow[] resul = tbl.Select(" fuel_date >= #" + main_date_old + "# AND  fuel_date <= #" + main_date_new + "#");
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
                if (tbl.Rows[i]["main_id"].ToString() != "0" && tbl.Rows[i]["main_id"].ToString() != null && tbl.Rows[i]["main_id"].ToString() != "")
                {
                    int dd = Convert.ToInt32(tbl.Rows[i]["main_id"].ToString());
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


        public string rep_cost(int equ_id,List<string> lis,DateTime old,DateTime fut)
        {
            string liss="";
            if(lis.Count == 0 || lis.Count == 2)
            {
                liss = "";
            }
            else if (lis.Count == 1)
            {
                if(lis[0]== "All")
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
            string query2 = "select * From Fuel Where "+ ss +" fuel_active != 'Catalogue' AND fuel_date >= '" + old + "'AND fuel_date <= '" + fut + "' " + liss+ " ORDER BY fuel_date";
            DataTable tb2 = Searchfuel(query2);
            double dd = 0;
            for(int i=0;i<tb2.Rows.Count;i++)
            {
                dd = dd + Convert.ToDouble(tb2.Rows[i][5].ToString());
            }

            return dd.ToString();
        }
    }
}
