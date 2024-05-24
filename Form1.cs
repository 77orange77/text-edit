using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_edit_Пыхтеев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void buttonPastr_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void buttonCleare_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }


        }

        private void ButtonCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text,
                    Encoding.GetEncoding(1251));
            
            
            }

        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
           
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                string fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fileName,
                    Encoding.GetEncoding(1251));
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void параметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
    } 
}
