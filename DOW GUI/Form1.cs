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

namespace DOW_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/DOW GUI/DOW GUI/bin/Debug/run.bat");
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input Token");
            } 
            else
            {
                TextWriter txt = new StreamWriter("C:/DOW GUI/DOW GUI/bin/Debug/token.txt");
                txt.Write(textBox1.Text);
                txt.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
