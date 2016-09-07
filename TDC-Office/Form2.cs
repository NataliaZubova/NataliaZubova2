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
    public partial class Form2 : Form
    {
        public Collection<Record> records = new Collection<Record>();
        StreamReader reader;
        StreamWriter writer;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadFromFile();
        }
        private void SaveToFile()
        {
            Int32 Nol = 0;
            writer = new StreamWriter("Nomen.txt");
            for (int i = 0; i < records.Count; i++)
            {
                writer.WriteLine(records[i].Name);
                writer.WriteLine(records[i].Sht);
                writer.WriteLine(Nol);
                writer.WriteLine(records[i].Min);
                writer.WriteLine(records[i].Norm);
                writer.WriteLine("$$");
            }
            writer.Close();
        }
        private void LoadFromFile()
        {
            Record record;
            reader = new StreamReader("Nomen.txt");
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
            public String Name, Sht, Col, Min, Norm;
        };

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                Record record = new Record();
                record.Name = textBox1.Text;
                record.Sht = textBox2.Text;
                record.Min= textBox3.Text;
                record.Norm = textBox4.Text;
                records.Add(record);
            }
           SaveToFile();
           textBox1.Text="";
           textBox2.Text="";
           textBox3.Text="";
           textBox4.Text="";
           Process.Start("vigr.bat");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
