using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Performance_evaluation_app
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }
        public Form2()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectResults();
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            Form1 form1 = new Form1();

            form3.FormClosed += (s, args) => form1.Show();

        }

        private void CollectResults()
        {
            string correctNum = "";
            string incorrectNum = "";

            if (O1.Checked)
            {
                correctNum += "1 ";
            }
            else
            {
                incorrectNum += "1 ";
            }

            if (O2.Checked)
            {
                correctNum += "2 ";
            }
            else
            {
                incorrectNum += "2 ";
            }

            if (O3.Checked)
            {
                correctNum += "3 ";
            }
            else 
            { 
                incorrectNum += "3 "; 
            }
            Form1.DataFormForm += correctNum;
            Form1.DataFormForm1 += incorrectNum;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

