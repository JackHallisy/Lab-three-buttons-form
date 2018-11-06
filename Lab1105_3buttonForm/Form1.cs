using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab1105_3buttonForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\CC6\SampleWriteToFile.text", true);
            sw.WriteLine(System.DateTime.Now.ToString());
            sw.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\CC6\SampleWriteToFile.text", true);

            string Line = sr.ReadLine();
            while (Line != null)
            {
                tbForResults.Text += Line;
                Line = sr.ReadLine();
            }
            sr.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbForResults.Text = string.Empty;
        }
    }
}
