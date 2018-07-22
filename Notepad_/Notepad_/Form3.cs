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
    public partial class Form3 : Form
    {
        Form1 b;
        public Form3(Form1 c)
        {
            b = c;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.AcceptButton = this.button1;
            this.CancelButton = this.button2;


            this.Text = "Replace";
            this.button1.Text = "Find";


          
            this.button2.Text = "Cancel";
            this.label1.Text = "Find What:";
            this.label2.Text = "Replace With:";
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

           
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();


         f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);

            /* 
              
                 string st = f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text); 
             
              f1.textBox1.Text = st;
                 this.button1.Text = f1.textBox1.Text;
              
             
             
             */
        }

        

       

       
    }
}
