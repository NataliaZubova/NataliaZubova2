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
    public partial class Form7 : Form
    {
        public Collection<Record> records = new Collection<Record>();
        StreamReader reader;
        StreamWriter writer;
        public Form7()
        {
           // 
            Process.Start("zagrNom.bat");
            
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
          
            Process.Start("zagrNom.bat");
            LoadFromFile();
            FillListBox();
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
                reader.ReadLine();
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
        private void Form1_Shown(object sender, EventArgs e)
        {
            FillListBox();
        }
        private void FillListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < records.Count; i++)
            {
                listBox1.Items.Add(records[i].Name + " [" + records[i].Sht + "]");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            if (listBox1.SelectedIndex < records.Count)
            {
                textBox1.Text = records[listBox1.SelectedIndex].Name;
                textBox2.Text = records[listBox1.SelectedIndex].Sht;
                textBox3.Text = records[listBox1.SelectedIndex].Min;
                textBox4.Text = records[listBox1.SelectedIndex].Norm;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex == listBox1.Items.Count )
            {
                Record record = new Record();
                records[listBox1.SelectedIndex].Name = textBox1.Text;
                records[listBox1.SelectedIndex].Sht = textBox2.Text;
                records[listBox1.SelectedIndex].Min = textBox3.Text;
                records[listBox1.SelectedIndex].Norm = textBox4.Text;
                //record.Name = textBox3.Text;
                //record.Sht = textBox4.Text;
                //records.Add(record);
            }
            SaveToFile();
            FillListBox();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < records.Count)
                records.Remove(records[listBox1.SelectedIndex]);
            SaveToFile();
            FillListBox();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("vigr.bat");
            
        }

        private void выгрузитьИВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("vigr.bat");
            Close();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
