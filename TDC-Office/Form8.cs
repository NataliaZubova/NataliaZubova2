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

namespace TDC_Office
{
    public partial class Form8 : Form
    {
    
        public Collection<Record> records = new Collection<Record>();
        StreamReader readeruser;
        StreamReader readerizm;
        public Form8()
        {
            Process.Start("zagr.bat");
            InitializeComponent();
            this.Load += new EventHandler(Form8_Load);
            Record record2;
            readeruser = new StreamReader("old1/User1.txt");
            while (!readeruser.EndOfStream)
            {
                record2 = new Record();
                record2.User = readeruser.ReadLine();
                records.Add(record2);
            }
            readeruser.Close();
            Record record3;
            readerizm = new StreamReader("old1/Izmen1.txt");
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
        public class Record
        {
            public String User, Izm;
        };

        private void Form8_Load(object sender, EventArgs e)
        {
            Stream fs = new FileStream(@"old1/Data1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            DataTable dt = new DataTable();
            dt.Columns.Add("№");
            dt.Columns.Add("Название");
            dt.Columns.Add("Штрих-Код");
            dt.Columns.Add("Остаток");
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
               
                {
                    dt.Rows.Add(count, s1, s2, s3);
                    count++;
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
        }
    }

