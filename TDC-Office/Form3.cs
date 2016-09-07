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
    public partial class Form3 : Form
    {
        public Collection<Record> records = new Collection<Record>();
        StreamReader reader;
        StreamReader readerset;
        StreamReader readeruser;
        StreamReader readerizm;
        StreamReader readerfil;
        StreamWriter writer;
        public Form3()
        {
            InitializeComponent(); 
            ReadSet();
            Record record2;
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            readeruser = new StreamReader("User" + workfil + ".txt");
            while (!readeruser.EndOfStream)
            {
                record2 = new Record();
                record2.User = readeruser.ReadLine();
                records.Add(record2);
            }
            readeruser.Close();
            Record record3;
            readerizm = new StreamReader("Izmen" + workfil + ".txt");
            while (!readerizm.EndOfStream)
            {
                record3 = new Record();
                record3.Izm = readerizm.ReadLine();
                records.Add(record3);
            }
            readerizm.Close();
            textBox1.Text = records[1].Izm;
            textBox2.Text = records[0].User;
        }
        private void ReadSet()
        {
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            readerset = new StreamReader("Set.txt");
           //while (!readerset.EndOfStream)
            {
                for (int i = 0; i < Convert.ToInt32(workfil); i++)
                {
                    string NameFil = readerset.ReadLine();
                    string RukFil = readerset.ReadLine();
                    string TelFil = readerset.ReadLine();
                    string Per = readerset.ReadLine();
                    label1.Text = "Филиал №" + workfil + " - " + NameFil;
                    label2.Text = "Руководитель филиала - " + RukFil;
                    label3.Text = "Телефон - " + TelFil;
                }
                readerset.ReadLine();
                readerset.ReadLine();
                readerset.ReadLine();
                readerset.ReadLine();
                readerset.ReadLine();
                readerset.ReadLine();
                readerset.ReadLine();
                readerset.ReadLine();
                
            }
            readerset.Close();
            
        }
        private void SaveToFile()
        {
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            readerset = new StreamReader("Set.txt");
            for (int i = 0; i < Convert.ToInt32(workfil); i++)
            {
                string NameFil = readerset.ReadLine();
                string RukFil = readerset.ReadLine();
                string TelFil = readerset.ReadLine();
                string Per = readerset.ReadLine();
                //label1.Text = "Филиал №" + workfil + " - " + NameFil;
               // label2.Text = "Руководитель филиала - " + RukFil;
               // label3.Text = "Телефон - " + TelFil;
            }
            readerset = new StreamReader("Set.txt");
            string NameFil1 = readerset.ReadLine();
            string RukFil1 = readerset.ReadLine();
            string TelFil1 = readerset.ReadLine();
            readerset.ReadLine();
            string NameFil2 = readerset.ReadLine();
            string RukFil2 = readerset.ReadLine();
            string TelFil2 = readerset.ReadLine();
            readerset.ReadLine();
            string NameFil3 = readerset.ReadLine();
            string RukFil3 = readerset.ReadLine();
            string TelFil3 = readerset.ReadLine();
            readerset.ReadLine();
            readerset.Close();
            Stream fs = new FileStream(@"Data" + workfil + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            excel.SheetsInNewWorkbook = 2;
            excel.Workbooks.Add(Type.Missing);
            Excel.Workbook workbook = excel.Workbooks[1];
            Excel.Worksheet sheet = workbook.Worksheets.get_Item(1);
            string s62 = DateTime.Now.ToString("dd.MM.yyyy  HH:mm:ss");
            sheet.get_Range("A1", "D1").MergeCells = true;
            sheet.get_Range("A2", "D2").MergeCells = true;
            sheet.Cells[1, 1].Value = "Товары на доставку от " + s62;
            //string nf = String.Concat(NameFil, workfil);
            //string tf = String.Concat(TelFil, workfil);
            sheet.Cells[2, 1].Value = "Филиал № " + workfil;
            sheet.Cells[4, 1].Value = "№";
            sheet.Cells[4, 2].Value = "Название";
            sheet.Cells[4, 3].Value = "Штрих-Код";
            sheet.Cells[4, 4].Value = "Кол-во";
            int k = 1;
            while (sr.Peek() != -1)
            {
                string s1 = sr.ReadLine();
                string s2 = sr.ReadLine();
                string s3 = sr.ReadLine();
                string s4 = sr.ReadLine();
                string s5 = sr.ReadLine();
                string s6 = sr.ReadLine();
                if (Convert.ToInt32(s3) < Convert.ToInt32(s4))
                {
                    sheet.get_Range("C1", "D1000").NumberFormat = "0";

                    var cells = sheet.get_Range("B2", "F5");
                    sheet.Cells[k + 4, 1].Value = k;
                    sheet.Cells[k + 4, 2].Value = "    " + s1 + "    ";
                    sheet.Cells[k + 4, 3].Value = s2;
                    sheet.Cells[k + 4, 4].Value = Convert.ToInt32(s5) - Convert.ToInt32(s3);
                    sheet.Columns.AutoFit();
                    k++;
                }
            }
            sr.Close();
            if (k == 1)
            {
                workbook.Close(0);
                excel.Visible = false;
                MessageBox.Show("Нет товаров для доставки.", "Нет товаров", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sheet.Cells.get_Range("A4", "D" + (k + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                string dat = DateTime.Now.ToString("dd.MM.yyyy  HH.mm");
                workbook.SaveAs(@"C:\TDC\Доставка\Доставка для филиала " + workfil + " от " + dat + ".xlsx");
            }
        }

        private void LoadFromFile()
        {
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            Record record;
            reader = new StreamReader("Data" + workfil + ".txt");
            while (!reader.EndOfStream)
            {
                record = new Record();
                record.Name = reader.ReadLine();
                record.Sht = reader.ReadLine();
                record.Col = reader.ReadLine();
                record.Min = reader.ReadLine();
                record.Norm = reader.ReadLine();
                reader.ReadLine();
                records.Add(record);
            }
            reader.Close();
        }

        public class Record
        {
            public String Name, Sht, Col, Min, Norm, User, Izm;
        };

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frmAbout = new Form4();
            frmAbout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frmAbout = new Form5();
            frmAbout.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFromFile();
            SaveToFile();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form8 frmAbout = new Form8();
            frmAbout.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
