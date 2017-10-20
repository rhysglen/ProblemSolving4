using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProblemSolving4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //screen click
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics wordString = CreateGraphics();
            Font wordPen = new Font("Arial", 14, FontStyle.Bold);
            SolidBrush wordBrush = new SolidBrush(Color.White);
            ContinueLabel.Visible = false;
            this.BackColor = Color.Black;
            this.Refresh();
            Thread.Sleep(3000);
            continueButton.Visible = true;
            wordString.DrawString("You", wordPen, wordBrush, 310, 250);
            continueButton.Visible = true;
        }
        // button click
        private void continueButton_Click(object sender, EventArgs e)
        {
            
            Graphics wordString = CreateGraphics();
            Font wordPen = new Font("Arial", 14, FontStyle.Bold);
            SolidBrush wordBrush = new SolidBrush(Color.White);
            wordString.Clear(Color.Black);
            continueButton.Visible = false;
            wordString.DrawString("you", wordPen, wordBrush, 100, 200);
            Thread.Sleep(1000);
            wordString.DrawString("should", wordPen, wordBrush, 150, 200);
            Thread.Sleep(1000);
            wordString.DrawString("not", wordPen, wordBrush, 230, 200);
            Thread.Sleep(1000);
            wordString.DrawString("have", wordPen, wordBrush, 280, 200);
            Thread.Sleep(1000);
            wordString.DrawString("done", wordPen, wordBrush, 340, 200);
            Thread.Sleep(1000);
            wordString.DrawString("that", wordPen, wordBrush, 400, 200);
            Thread.Sleep(2500);
            this.Close();
        }

    }
}
