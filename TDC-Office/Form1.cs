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
    public partial class Form1 : Form
    {
        public Collection<Record> records = new Collection<Record>();
        StreamReader readerset;
        StreamReader reader1;
        StreamReader reader2;
        StreamReader reader3;
        StreamWriter writerfil;
        StreamReader readerd1;
        StreamReader readerd1o;
        StreamReader readerd2;
        StreamReader readerd2o;
        StreamReader readerd3;
        StreamReader readerd3o;
        public Form1()
        {
            InitializeComponent();
        }
       private void ReadSet()
       {
            readerset = new StreamReader("Set.txt");
            while (!readerset.EndOfStream)
            {
               string NameFil1 = readerset.ReadLine();
               readerset.ReadLine();
               readerset.ReadLine();
               readerset.ReadLine();
               string NameFil2 = readerset.ReadLine();
               readerset.ReadLine();
               readerset.ReadLine();
               readerset.ReadLine();
               string NameFil3 = readerset.ReadLine();
               readerset.ReadLine();
               readerset.ReadLine();
               readerset.ReadLine();
            брянскToolStripMenuItem.Text = NameFil1;
           калугаToolStripMenuItem.Text = NameFil2;
           тверьToolStripMenuItem.Text = NameFil3;
            }
           readerset.Close();
       }

     
        private void брянскToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
            Form3 frmAbout = new Form3();
            frmAbout.ShowDialog();
        
        }

        private void просмотрОстатковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frmAbout = new Form6();
            frmAbout.ShowDialog();
        }
       
        private void ордерНаДоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("123.bat");
            Process.Start("Dostavka123.txt");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("old.bat");
            Process.Start("zagr.bat");
            ReadSet();
           // ObnovProv();
        }

        private void добавлениеНовойТоварнойПозицииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmAbout = new Form2();
            frmAbout.ShowDialog();
        }

        private void редактированиеНоменклатурыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frmAbout = new Form7();
            frmAbout.ShowDialog();
        }
        private void ObnovProv()
        {
            readerd1 = new StreamReader("Izmen1.txt");
            string izm1 = readerd1.ReadLine();
            readerd1.Close();
            readerd1o = new StreamReader("old1/Izmen1.txt");
            string izm1o = readerd1o.ReadLine();
            readerd1o.Close();
            readerd2 = new StreamReader("Izmen2.txt");
            string izm2 = readerd2.ReadLine();
            readerd2.Close();
            readerd2o = new StreamReader("old2/Izmen2.txt");
            string izm2o = readerd2o.ReadLine();
            readerd2o.Close();
            readerd3 = new StreamReader("Izmen3.txt");
            string izm3 = readerd3.ReadLine();
            readerd3.Close();
            readerd3o = new StreamReader("old3/Izmen3.txt");
            string izm3o = readerd3o.ReadLine();
            readerd3o.Close();
            if (izm1 != izm1o)
                label2.Text = "Филиал №1 - Новые данные на сервере";
            if (izm2 != izm2o)
                label3.Text = "Филиал №2 - Новые данные на сервере";
            if (izm3 != izm3o)
                label4.Text = "Филиал №3 - Новые данные на сервере";
        }

        private void брянскToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("1");
            writerfil.Close();
           // string wrkfil = "1";
            Form3 f = new Form3();
            f.ShowDialog();
            //this.wrkfil = f.wrkfil;

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frmAbout = new Form9();
            frmAbout.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ObnovProv();
          Close();
        }

        private void просмотрОстатковToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form6 frmAbout = new Form6();
            frmAbout.ShowDialog();
        }

        private void добавлениеНовойТоварнойПозицииToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 frmAbout = new Form2();
            frmAbout.ShowDialog();
        }

        private void редактированиеНоменклатурыТоваровToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            Form7 frmAbout = new Form7();
            frmAbout.ShowDialog();
        
        }
         public class Record
        {
            public String Name, Sht, Col, Min, Norm;
        };
        private void LoadFromFile1()
        {
            Record record;
            reader1 = new StreamReader("Data1.txt");
            while (!reader1.EndOfStream)
            {
                record = new Record();
                record.Name = reader1.ReadLine();
                record.Sht = reader1.ReadLine();
                record.Col = reader1.ReadLine();
                record.Min = reader1.ReadLine();
                record.Norm = reader1.ReadLine();
                reader1.ReadLine();
                records.Add(record);
            }
            reader1.Close();
        }
        private void LoadFromFile2()
        {
            Record record;
            reader1 = new StreamReader("Data1.txt");
            while (!reader1.EndOfStream)
            {
                record = new Record();
                record.Name = reader1.ReadLine();
                record.Sht = reader1.ReadLine();
                record.Col = reader1.ReadLine();
                record.Min = reader1.ReadLine();
                record.Norm = reader1.ReadLine();
                reader1.ReadLine();
                records.Add(record);
            }
            reader1.Close();
        }
        private void LoadFromFile3()
        {
            Record record;
            reader1 = new StreamReader("Data1.txt");
            while (!reader1.EndOfStream)
            {
                record = new Record();
                record.Name = reader1.ReadLine();
                record.Sht = reader1.ReadLine();
                record.Col = reader1.ReadLine();
                record.Min = reader1.ReadLine();
                record.Norm = reader1.ReadLine();
                reader1.ReadLine();
                records.Add(record);
            }
            reader1.Close();
        }
        private void SaveToFile()
        {
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
            Stream fs = new FileStream(@"Data1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Stream f2 = new FileStream(@"Data2.txt", FileMode.Open, FileAccess.Read);
            StreamReader ss2 = new StreamReader(f2);
            Stream f3 = new FileStream(@"Data3.txt", FileMode.Open, FileAccess.Read);
            StreamReader ss3 = new StreamReader(f3);
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            excel.SheetsInNewWorkbook = 2;
            excel.Workbooks.Add(Type.Missing);
            Excel.Workbook workbook = excel.Workbooks[1];
            Excel.Worksheet sheet = workbook.Worksheets.get_Item(1);
            string s62 = DateTime.Now.ToString("dd.MM.yyyy  HH:mm:ss");
            sheet.get_Range("A1", "D1").MergeCells = true;
            sheet.Cells[1, 1].Value = "Товары на доставку от " + s62;
            int k = 1;
            int k2 = 1;
            int k3 = 1;
            while (sr.Peek() != -1)
            {
                string s11 = sr.ReadLine();
                string s12 = sr.ReadLine();
                string s13 = sr.ReadLine();
                string s14 = sr.ReadLine();
                string s15 = sr.ReadLine();
                string s16 = sr.ReadLine();
                if (Convert.ToInt32(s13) < Convert.ToInt32(s14))
                {
                    sheet.get_Range("C1", "D1000").NumberFormat = "0";
                    var cells = sheet.get_Range("B2", "F5");
                    sheet.Cells[k + 4, 1].Value = k;
                    sheet.Cells[k + 4, 2].Value = "    " + s11 + "    ";
                    sheet.Cells[k + 4, 3].Value = s12;
                    sheet.Cells[k + 4, 4].Value = Convert.ToInt32(s15) - Convert.ToInt32(s13);
                    sheet.Columns.AutoFit();
                    k++;
                }
                if (k != 1)
                {
                    sheet.Cells[3, 1].Value = "Филиал №1. " + NameFil1 + "  Телефон(" + TelFil1 + ")";
                    sheet.Cells[4, 1].Value = "№";
                    sheet.Cells[4, 2].Value = "Название";
                    sheet.Cells[4, 3].Value = "Штрих-Код";
                    sheet.Cells[4, 4].Value = "Кол-во";
                    sheet.get_Range("A3", "D3").MergeCells = true;
                    sheet.Cells.get_Range("A4", "D" + (k + 3)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }
                else
                {
                    sheet.Cells[3, 1].Value = "Филиал №1. " + NameFil1 + ". Товаров для доставки нет.";
                    sheet.get_Range("A3", "D3").MergeCells = true;
                }
            }
            while (ss2.Peek() != -1)
            {
                string s21 = ss2.ReadLine();
                string s22 = ss2.ReadLine();
                string s23 = ss2.ReadLine();
                string s24 = ss2.ReadLine();
                string s25 = ss2.ReadLine();
                string s26 = ss2.ReadLine();
                if (Convert.ToInt32(s23) < Convert.ToInt32(s24))
                {
                    sheet.get_Range("C1", "D1000").NumberFormat = "0";
                    var cells = sheet.get_Range("B2", "F5");
                    sheet.Cells[k+k2 + 6, 1].Value = k2;
                    sheet.Cells[k+k2 + 6, 2].Value = "    " + s21 + "    ";
                    sheet.Cells[k+k2 + 6, 3].Value = s22;
                    sheet.Cells[k+k2 + 6, 4].Value = Convert.ToInt32(s25) - Convert.ToInt32(s23);
                    sheet.Columns.AutoFit();
                    k2++;
                }
                if (k2 != 1)
                {
                    sheet.Cells[k+5, 1].Value = "Филиал №2. " + NameFil2 + "  Телефон(" + TelFil2 + ")";
                    sheet.get_Range("A" + (k+5), "D" + (k+5)).MergeCells = true;
                    sheet.Cells[k+6, 1].Value = "№";
                    sheet.Cells[k+6, 2].Value = "Название";
                    sheet.Cells[k+6, 3].Value = "Штрих-Код";
                    sheet.Cells[k+6, 4].Value = "Кол-во";
                    sheet.Cells.get_Range("A" + (k+6), "D" + (k + k2 + 5)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }
                else
                {
                    sheet.Cells[k+5, 1].Value = "Филиал №2. " + NameFil2 + ". Товаров для доставки нет.";
                    sheet.get_Range("A" + (k + 5), "D" + (k + 5)).MergeCells = true;
                }
            }
            ss2.Close();
            while (ss3.Peek() != -1)
            {
                string s31 = ss3.ReadLine();
                string s32 = ss3.ReadLine();
                string s33 = ss3.ReadLine();
                string s34 = ss3.ReadLine();
                string s35 = ss3.ReadLine();
                string s36 = ss3.ReadLine();
                if (Convert.ToInt32(s33) < Convert.ToInt32(s34))
                {
                    sheet.get_Range("C1", "D1000").NumberFormat = "0";

                    var cells = sheet.get_Range("B2", "F5");
                    sheet.Cells[k + k2 + k3 + 8, 1].Value = k3;
                    sheet.Cells[k + k2 + k3 + 8, 2].Value = "    " + s31 + "    ";
                    sheet.Cells[k + k2 + k3 + 8, 3].Value = s32;
                    sheet.Cells[k + k2 + k3 + 8, 4].Value = Convert.ToInt32(s35) - Convert.ToInt32(s33);
                    sheet.Columns.AutoFit();
                    k3++;
                }
                if (k3 != 1)
                {
                    sheet.Cells[k + k2 + 7, 1].Value = "Филиал №3. " + NameFil3 + "  Телефон(" + TelFil3 + ")";
                    sheet.get_Range("A" + (k + k2 + 7), "D" + (k + k2 + 7)).MergeCells = true;
                    sheet.Cells[k + k2 + 8, 1].Value = "№";
                    sheet.Cells[k + k2 + 8, 2].Value = "Название";
                    sheet.Cells[k + k2 + 8, 3].Value = "Штрих-Код";
                    sheet.Cells[k + k2 + 8, 4].Value = "Кол-во";
                    sheet.Cells.get_Range("A" + (k + k2 + 8), "D" + (k + k2 + k3 + 7)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }
                else
                {
                    sheet.Cells[k + k2 + 7, 1].Value = "Филиал №3. " + NameFil3 + ". Товаров для доставки нет.";
                    sheet.get_Range("A" + (k + k2 + 7), "D" + (k + k2 + 7)).MergeCells = true;
                }
            }
            ss3.Close();
            if ((k == 1) && (k2==1) && (k3==1))
            {
                workbook.Close(0);
                excel.Visible = false;
                MessageBox.Show("Нет товаров для доставки.", "Нет товаров", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dat = DateTime.Now.ToString("dd.MM.yyyy  HH.mm");
                workbook.SaveAs(@"C:\TDC\Доставка\Доставка Общая от " + dat + ".xlsx");
            }
        }
        private void ордерНаДоставкуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadFromFile1();
            LoadFromFile2();
            LoadFromFile3();
            SaveToFile();
        }

        private void открытьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "C:\\TDC\\Доставка");
        }

        private void удалитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\TDC\\Доставка");

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
        }

        private void калугаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("2");
            writerfil.Close();
            Form3 frmAbout = new Form3();
            frmAbout.ShowDialog();
        }

        private void тверьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("3");
            writerfil.Close();
            Form3 frmAbout = new Form3();
            frmAbout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ObnovProv();
        }

        private void открытьПапкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "C:\\TDC\\Отчеты");
        }

        private void удалитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\TDC\\Отчеты");
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frmAbout = new Form12();
            frmAbout.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        }
    }
    
