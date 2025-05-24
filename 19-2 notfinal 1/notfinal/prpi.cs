using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Windows.Forms;
using System.Data;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office;
using Excel = Microsoft.Office.Interop.Excel;

using System.IO;
using System.Data;
using System.Reflection;
using ClosedXML.Excel;


namespace notfinal
{
    class prpi : print_ecxel_report
    {

        public void prrrint1(DataTable datat , string namee)
        {
            try
            {
                int x = datat.Rows.Count;
                if(x==0)
                {
                    MessageBox.Show("No Data To Export");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("No Data To Export");
                return;
            }
            if (datat.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = namee + " " +DateTime.Now.Day.ToString()+"-"+ DateTime.Now.Month.ToString() + ".pdf";
                bool fileError = false;
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                            //sfd.FileName = sfd.FileName + "(1).pdf";
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It Wasn't Possible to Write The Data To The Disk Please Change Name And Location" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(datat.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE;
                            pdfTable.DefaultCell.BorderWidth = 1;

                            foreach (DataColumn column in datat.Columns)
                            {
                                
                                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.VerticalAlignment = Element.ALIGN_MIDDLE; 
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataRow row in datat.Rows)
                            {
                                for (int i = 0; i < datat.Columns.Count;i++)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(row[i].ToString()));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell);
                                }
                            }
                            Document pdfDoc = new Document(PageSize.A4, 30f, 30f, 50f, 50f);
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                var spacer = new iTextSharp.text.Paragraph("")
                                {
                                    SpacingBefore = 50f,
                                    SpacingAfter = 50f,
                                };


                                //pdfDoc.Add(spacer);

                                try
                                {
                                    var imagepath = @"C:\Users\OverLord\Desktop\logopng.png";
                                    using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                                    {
                                        var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), System.Drawing.Imaging.ImageFormat.Png);
                                        png.ScaleToFit(140f, 145f);
                                        //png.SpacingBefore = 50f;
                                        png.Alignment = Element.ALIGN_LEFT;
                                        //png.ScalePercent(20f);
                                        //png.ScaleToFit(pdfDoc.PageSize);
                                        //png.SetAbsolutePosition(pdfDoc.Left + 20, pdfDoc.Top - 70);
                                        pdfDoc.Add(png);
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("No Picture");
                                }  //pic



                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                iTextSharp.text.Font fontt = new iTextSharp.text.Font(bf, 15f, iTextSharp.text.Font.BOLD);
                                Chunk a1 = new Chunk(namee, fontt);
                                Phrase p = new Phrase();
                                p.Add(a1);
                               
                                var Report = new iTextSharp.text.Paragraph(p)
                                {
                                    Alignment = Element.ALIGN_CENTER,
                                    SpacingBefore = 20f,
                                    SpacingAfter = 20f,
                                }; // Name;

                                pdfDoc.Add(Report);
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
                MessageBox.Show("No Record To Export", "Info");
            }
        }//pdf

        public void prrrint(DataTable datat, string namee)
        {
            try
            {
                int x = datat.Rows.Count;
                if (x == 0)
                {
                    MessageBox.Show("No Data To Export");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("No Data To Export");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files|*.xlsx";
            sfd.Title = namee;// an Excel File";
            sfd.FileName = namee + " " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + ".xlsx";
            bool fileError = false;
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                        //sfd.FileName = sfd.FileName + "(1).pdf";
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It Wasn't Possible to Write The Data To The Disk Please Change Name And Location" + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        //string folderPath = "C:\\Excel\\";
                        //if (!Directory.Exists(folderPath))
                        //{
                        //    Directory.CreateDirectory(folderPath);
                        //}
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(datat, namee);
                            if (!String.IsNullOrWhiteSpace(sfd.FileName))
                            {
                                wb.SaveAs(sfd.FileName); 
                            }
                            else
                            {
                                MessageBox.Show("Please Change File Name");
                            }
                            //wb.SaveAs(sfd.FileName);// folderPath + namee + " " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + ".xlsx");
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
        public void prrrint2(DataTable datat, string namee)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets[namee];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < datat.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = datat.Columns[i - 1].ColumnName;
            }
            for (int i = 0; i < datat.Rows.Count - 1; i++)
            {
                for (int j = 0; j < datat.Columns.Count; j++)
                {
                    try
                    {
                        if (datat.Rows[i][j].ToString() != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = datat.Rows[i][j].ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                    catch
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        } //excel
       
    }
}
