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
    public partial class Form11 : Form
    {
        public Collection<Record> records = new Collection<Record>();
        StreamReader reader;
        StreamWriter writer;
        StreamReader readerfil;
        public Form11()
        {
            InitializeComponent();
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            label1.Text = "Изменение учетных записей. Филиал №" + workfil;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            LoadFromFile();
            FillListBox();
        }
        private void LoadFromFile()
        {
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            Record record;
            reader = new StreamReader("Users" + workfil + ".txt");
            while (!reader.EndOfStream)
            {
                record = new Record();
                record.Name = reader.ReadLine();
                record.Pas = reader.ReadLine();
                reader.ReadLine();
                records.Add(record);
            }
            reader.Close();
        }
        private void FillListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < records.Count; i++)
            {
                listBox1.Items.Add(records[i].Name);
            }
            
        }
        
        public class Record
        {
            public String Name, Pas;
        };

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            if (listBox1.SelectedIndex < records.Count)
            {
                textBox1.Focus();
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;
                textBox1.Text = records[listBox1.SelectedIndex].Name;
                textBox4.Text = records[listBox1.SelectedIndex].Pas;
            }
            else
            {
                textBox1.Text = "";
                textBox4.Text = "";
            }
        }
        private void SaveToFile()
        {
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            writer = new StreamWriter("Users" + workfil + ".txt");
            for (int i = 0; i < records.Count; i++)
            {
                writer.WriteLine(records[i].Name);
                writer.WriteLine(records[i].Pas);
                writer.WriteLine("$");
            }
            writer.Close();
            Process.Start("vigrUsers" + workfil + ".bat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            records[listBox1.SelectedIndex].Name = textBox1.Text;
            records[listBox1.SelectedIndex].Pas = textBox4.Text;
            SaveToFile();
            FillListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < records.Count)
                records.Remove(records[listBox1.SelectedIndex]);
            SaveToFile();
            FillListBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
