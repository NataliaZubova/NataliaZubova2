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
    public partial class Form5 : Form
    {
        StreamReader readerfil;
        public Form5()
        {
            Process.Start("zagr.bat");
            InitializeComponent();
            this.Load += new EventHandler(Form5_Load);
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            Stream fs = new FileStream(@"Data" + workfil + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            DataTable dt = new DataTable();
            dt.Columns.Add("№");
            dt.Columns.Add("Название");
            dt.Columns.Add("Штрих-Код");
            dt.Columns.Add("Остаток");
            dt.Columns.Add("Остаток критический");
            dt.Columns.Add("Остаток нормальный");
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
                if (Convert.ToInt32(s3) < Convert.ToInt32(s4))
                {
                    dt.Rows.Add(count, s1, s2, s3, s4, s5);
                    count++;
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Process.Start("zagr.bat");
            InitializeComponent();
            this.Load += new EventHandler(Form5_Load);*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }


       /* private void Form5_Load(object sender, EventArgs e)
        {
            LoadFromFile();
        }*/

       

       
    }
}
