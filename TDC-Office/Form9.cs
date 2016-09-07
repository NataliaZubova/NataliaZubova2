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
    public partial class Form9 : Form
    {
        StreamReader readerset;
        StreamWriter writerset;
        StreamWriter writerfil;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            ReadSet(); 
        }
        private void ReadSet()
        {
            readerset = new StreamReader("Set.txt");
            while (!readerset.EndOfStream)
            {
                string NameFil1 = readerset.ReadLine();
                string RukFil1 = readerset.ReadLine();
                string TelFil1 = readerset.ReadLine();
                string ObnFil1 = readerset.ReadLine();
                string NameFil2 = readerset.ReadLine();
                string RukFil2 = readerset.ReadLine();
                string TelFil2 = readerset.ReadLine();
                string ObnFil2 = readerset.ReadLine();
                string NameFil3 = readerset.ReadLine();
                string RukFil3 = readerset.ReadLine();
                string TelFil3 = readerset.ReadLine();
                string ObnFil3 = readerset.ReadLine();
                textBox1.Text = NameFil1;
                textBox2.Text = RukFil1;
                textBox3.Text = TelFil1;
                textBox6.Text = NameFil2;
                textBox5.Text = RukFil2;
                textBox4.Text = TelFil2;
                textBox9.Text = NameFil3;
                textBox8.Text = RukFil3;
                textBox7.Text = TelFil3;
                comboBox1.SelectedIndex = Convert.ToInt32(ObnFil1);
                comboBox2.SelectedIndex = Convert.ToInt32(ObnFil2);
                comboBox3.SelectedIndex = Convert.ToInt32(ObnFil3);
            }

            readerset.Close();
        }

        private void WriteSet()
        {
                writerset = new StreamWriter("Set.txt");
                writerset.WriteLine(textBox1.Text);
                writerset.WriteLine(textBox2.Text); 
                writerset.WriteLine(textBox3.Text);
                writerset.WriteLine(comboBox1.SelectedIndex);
                writerset.WriteLine(textBox6.Text);
                writerset.WriteLine(textBox5.Text); 
                writerset.WriteLine(textBox4.Text);
                writerset.WriteLine(comboBox2.SelectedIndex);
                writerset.WriteLine(textBox9.Text);
                writerset.WriteLine(textBox8.Text);
                writerset.WriteLine(textBox7.Text);
                writerset.WriteLine(comboBox3.SelectedIndex);
                writerset.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WriteSet();
            Process.Start("vigr.bat");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("1");
            writerfil.Close();
            Form10 frmAbout = new Form10();
            frmAbout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("1");
            writerfil.Close();
            Form11 frmAbout = new Form11();
            frmAbout.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("2");
            writerfil.Close();
            Form10 frmAbout = new Form10();
            frmAbout.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("2");
            writerfil.Close();
            Form11 frmAbout = new Form11();
            frmAbout.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("3");
            writerfil.Close();
            Form10 frmAbout = new Form10();
            frmAbout.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            writerfil = new StreamWriter("workfil.txt");
            writerfil.WriteLine("3");
            writerfil.Close();
            Form11 frmAbout = new Form11();
            frmAbout.ShowDialog();
        }


    }
}
