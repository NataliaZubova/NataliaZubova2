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
    public partial class Form6 : Form
    {
        public Collection<Record> records = new Collection<Record>();
        StreamReader reader;
        StreamWriter writer;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadFromFile1();
            LoadFromFile2();
            LoadFromFile3();
            SaveToFile();
            Stream fs = new FileStream(@"Data123.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Stream es = new FileStream(@"Nomen.txt", FileMode.Open, FileAccess.Read);
            StreamReader er = new StreamReader(es);
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Название");
            dt.Columns.Add("Штрих-Код");
            dt.Columns.Add("Общий остаток");
            dataGridView1.AutoResizeColumns();

            int count = 1;

            while (sr.Peek() != -1)
            {
                string s1 = er.ReadLine();
                string s2 = er.ReadLine();
                string s3 = sr.ReadLine();
                string s4 = er.ReadLine();
                string s5 = er.ReadLine();
                string s6 = er.ReadLine();
                string s7 = er.ReadLine();
                
                {
                    dt.Rows.Add(s1, s2, s3);
                    count++;
                }
            }
            dataGridView1.DataSource = dt;
        }
        public class Record
        {
            public String Name, Sht, Col, Min, Norm;
        };
        private void LoadFromFile1()
        {
            Record record;
            reader = new StreamReader("Data1.txt");
            while (!reader.EndOfStream)
            {
                record = new Record();
                reader.ReadLine();
                reader.ReadLine();
                record.Col = reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                records.Add(record);
            }
            reader.Close();
        }
        private void LoadFromFile2()
        {
            Record record;
            reader = new StreamReader("Data2.txt");
            while (!reader.EndOfStream)
            {
                record = new Record();
                reader.ReadLine();
                reader.ReadLine();
                record.Col = reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                records.Add(record);
            }
            reader.Close();
        }
        private void LoadFromFile3()
        {
            Record record;
            reader = new StreamReader("Data3.txt");
            while (!reader.EndOfStream)
            {
                record = new Record();
                reader.ReadLine();
                reader.ReadLine();
                record.Col = reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                records.Add(record);
            }
            reader.Close();
        }
        private void SaveToFile()
        {
            writer = new StreamWriter("Data123.txt");

            for (int k = 0; k < records.Count/3; k++)
            {
                int coll = 0;
                for (int i = k; i < records.Count; i = i + records.Count / 3)
                {
                    coll = coll + Convert.ToInt32(records[i].Col);
                }
                
                writer.WriteLine(coll);
            }     
            writer.Close();
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
            Stream fs = new FileStream(@"Data123.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Stream es = new FileStream(@"Nomen.txt", FileMode.Open, FileAccess.Read);
            StreamReader er = new StreamReader(es);
            sheet.Cells[1, 1].Value = "Отчет \"Общие остатки\" от " + s62;
            int k = 2;
            sheet.get_Range("B1", "C1000").NumberFormat = "0";
            sheet.Cells[3, 1].Value = "Название";
            sheet.Cells[3, 2].Value = "Штрих-Код";
            sheet.Cells[3, 3].Value = "Кол-во";
            while (sr.Peek() != -1)
            {

                string s1 = er.ReadLine();
                string s2 = er.ReadLine();
                string s3 = sr.ReadLine();
                string s4 = er.ReadLine();
                string s5 = er.ReadLine();
                string s6 = er.ReadLine();
                string s7 = er.ReadLine();
                sheet.Cells[k + 2, 1].Value = s1;
                sheet.Cells[k + 2, 2].Value = s2;
                sheet.Cells[k + 2, 3].Value = s3;
                sheet.Columns.AutoFit();
                k++;
            }
            sheet.Cells.get_Range("A3", "C" + (k + 1)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            string dat = DateTime.Now.ToString("dd.MM.yyyy  HH.mm");
            workbook.SaveAs(@"C:\TDC\Отчеты\Отчет общие остатки от " + dat + ".xlsx");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
                }
    }

