using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notepad_
{
    
    public partial class Form1 : Form
    {    
       

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt";

            
            
            this.statusBarToolStripMenuItem.Enabled = false;

             this.viewHelpToolStripMenuItem.Enabled = false;

             
            this.Text = "DANIYAL";

            this.textBox1.ScrollBars = ScrollBars.Both;


            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;

            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;

            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;

            this.undoCtrlNToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;

            this.cutCtrlXToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;

            this.copyCtrlCToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;

            this.pasteCtrlDelToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;

            this.selectAllCtrlAToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;

            this.timeDateToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
           
          this.deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;

            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;

            this.timeDateToolStripMenuItem1.ShortcutKeys = Keys.F5;
            



        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
 {
     this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";

        DialogResult dr = this.saveFileDialog1.ShowDialog();
        if (dr == DialogResult.OK)
        {
           String fname = saveFileDialog1.FileName;
            File.WriteAllText(fname,this.textBox1.Text);    

        }



     }
         
     private void pasteCtrlDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.textBox1.Clear();

            /* 
             
              if (this.textBox1.Text=="")
             {
                 DialogResult dr = this.saveFileDialog1.ShowDialog();
                 if (dr == DialogResult.OK)
                 {
                     String fname = saveFileDialog1.FileName;
                     File.WriteAllText(fname, this.textBox1.Text);
                 } 

             } 
             
             */


        }
        private void undoCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void copyCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectedText="";
          
    
        }

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            if (wordToolStripMenuItem.Checked == true)
            {

                this.textBox1.WordWrap = false;
                wordToolStripMenuItem.Checked = false;

            }
            else
            {
                textBox1.WordWrap = true;
                wordToolStripMenuItem.Checked = true;
            }



        }

  

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String fname = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fname);
            }

            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
          this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";

        DialogResult dr = this.saveFileDialog1.ShowDialog();
        if (dr == DialogResult.OK)
        {
            String fname = saveFileDialog1.FileName;
            File.WriteAllText(fname, this.textBox1.Text);
       }
         
            
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = false;

            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            { this.textBox1.Font = this.fontDialog1.Font; }
        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor=true;

            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void selectAllCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
         

           
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
           
          
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog2.ShowDialog();
            DialogResult dr = this.colorDialog2.ShowDialog();
            if (dr == DialogResult.OK)
            {
               
                this.textBox1.ForeColor = this.colorDialog2.Color;
                
            }
        }

        private void Close(object sender, FormClosingEventArgs e)
        {

        }

    }
}
