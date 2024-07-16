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
        private Form1 form1_;
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1_ = form;
        }

        public Form2()
        {
        }

        private void CollectResults()
        {
            string ONum = "";
            string XNum = "";

            if (O1.Checked)
            {
                ONum += "1, ";
            }
            else
            {
                XNum += "1, ";
            }

            if (O2.Checked)
            {
                ONum += "2, ";
            }
            else
            {
                XNum += "2, ";
            }

            if (O3.Checked)
            {
                ONum += "3, ";
            }
            else 
            {
                XNum += "3, "; 
            }
            Form1.DataFormForm += ONum;
            Form1.DataFormForm1 += XNum;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CollectResults();
            this.Hide();
            Form3 form3 = new Form3(form1_, this);
            form3.Show();
        }
    }
}

