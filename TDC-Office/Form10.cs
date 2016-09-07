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
    public partial class Form10 : Form
    {
        StreamWriter writeruser;
        StreamReader readerfil;
        public Form10()
        {
            InitializeComponent();
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            label1.Text = "Добавление пользователя. Филиал №" + workfil;
        }
        private void AddUser()
      {
          readerfil = new StreamReader("workfil.txt");
          string workfil = readerfil.ReadLine();
          readerfil.Close();
                writeruser = new StreamWriter(@"Users" + workfil + ".txt", true);
                writeruser.WriteLine(textBox1.Text + " " + textBox2.Text + " (" + textBox3.Text + ")");
                writeruser.WriteLine(textBox4.Text);
                writeruser.WriteLine("$");
                writeruser.Close();
      }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            readerfil = new StreamReader("workfil.txt");
            string workfil = readerfil.ReadLine();
            readerfil.Close();
            Process.Start("vigrUsers" + workfil + ".bat");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

    }
}
