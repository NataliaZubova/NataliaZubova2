using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace TDC_Office
{
    public partial class Form4 : Form
    {
        StreamReader readerfil;
        public Form4()
        {
            Process.Start("zagr.bat");
            InitializeComponent();
            this.Load += new EventHandler(Form4_Load);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            Stream fs = new FileStream(@"Data" + workfil + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Stream fe = new FileStream(@"old" + workfil + "/Data" + workfil + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader se = new StreamReader(fe);
            DataTable dt = new DataTable();
            dt.Columns.Add("№");
            dt.Columns.Add("Название");
            dt.Columns.Add("Штрих-Код");
            dt.Columns.Add("Остаток");
            dt.Columns.Add("Продано");
            dataGridView1.AutoResizeColumns();

            int count = 1;

            while (sr.Peek() != -1)
            {
                string s1 = sr.ReadLine();
                string s2 = sr.ReadLine();
                string s3 = sr.ReadLine();
                string s4 = sr.ReadLine();
                string s5 = sr.ReadLine();
                string s6 = sr.ReadLine();
                string s11 = se.ReadLine();
                string s12 = se.ReadLine();
                string s13 = se.ReadLine();
                string s14 = se.ReadLine();
                string s15 = se.ReadLine();
                string s16 = se.ReadLine();
               
                {
                    Int32 pr = 0;
                    if (Convert.ToInt32(s13) < Convert.ToInt32(s14))
                    pr=Convert.ToInt32(s5)-Convert.ToInt32(s3);
                    if (Convert.ToInt32(s13) >= Convert.ToInt32(s14))
                    pr = Convert.ToInt32(s13) - Convert.ToInt32(s3);
                    dt.Rows.Add(count, s1, s2, s3, pr);
                    count++;
                }
            }
            dataGridView1.DataSource = dt;
        }
              
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void отчетВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            excel.SheetsInNewWorkbook = 2;
            excel.Workbooks.Add(Type.Missing);
            Excel.Workbook workbook = excel.Workbooks[1];
            Excel.Worksheet sheet = workbook.Worksheets.get_Item(1);
            string s62 = DateTime.Now.ToString("dd.MM.yyyy  HH:mm:ss");
            sheet.get_Range("A1", "D1").MergeCells = true;
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            Stream fs = new FileStream(@"Data" + workfil + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sheet.Cells[1, 1].Value = "Филиал" + workfil + ". Отчет по остаткам от " + s62;
            int k = 2;
            sheet.get_Range("B1", "C1000").NumberFormat = "0";
            sheet.Cells[3, 1].Value = "Название";
            sheet.Cells[3, 2].Value = "Штрих-Код";
            sheet.Cells[3, 3].Value = "Кол-во";
           
            while (sr.Peek() != -1)
            {

                string s1 = sr.ReadLine();
                string s2 = sr.ReadLine();
                string s3 = sr.ReadLine();
                string s4 = sr.ReadLine();
                string s5 = sr.ReadLine();
                string s6 = sr.ReadLine();
                sheet.Cells[k + 2, 1].Value = s1;
                sheet.Cells[k + 2, 2].Value = s2;
                sheet.Cells[k + 2, 3].Value = s3;
                sheet.Columns.AutoFit();
                k++;
            }
            sheet.Cells.get_Range("A3", "C" + (k + 1)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            string dat = DateTime.Now.ToString("dd.MM.yyyy  HH.mm");
            workbook.SaveAs(@"C:\TDC\Отчеты\Филиал" + workfil + ". Отчет по остаткам от " + dat + ".xlsx");
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
                }
        }

      
