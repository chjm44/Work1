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
        private Form1 form;
        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }
        
        public static string result;
        public static string true_num = "";
        public static string false_num ="";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            Form1 form1 = new Form1();

            form3.FormClosed += (s, args) => form1.Show();

        }

        private void radio()
        { 
            if (radioButton3.Checked)
            {
                true_num += "1 ";
            }
            else
            {
                false_num += "1 ";
            }
            if (radioButton9.Checked)
            {
                true_num += "2 "; 
            }
            else
            {
                false_num += "2 ";
            }
            if (radioButton9.Checked)
            {
                true_num += "3 "; 
            }
            else
            {
                false_num += "3 ";
            }

            

        }

    }

    }
