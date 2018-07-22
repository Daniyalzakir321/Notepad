using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 A)
        {
             f1= A; 
            InitializeComponent();
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.Text = "Find";
            this.label1.Text="Find What: ";
            this.button1.Text = "Find";
            this.button2.Text = "Cancel";
            this.AcceptButton = this.button1;
            this.CancelButton = this.button2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            if (f1.textBox1.Text.Contains(this.textBox1.Text))
            { 
                MessageBox.Show("OK"); }
            else
            { MessageBox.Show("Cannot find"); }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
