using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Performance_evaluation_app
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        private Form2 form2;
        public Form3(Form1 form, Form2 _form2)
        {
            InitializeComponent();
            form1 = form;
            form2 = _form2;
        }

        public Form3()
        {
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" || textBox2.Text == "")
            {
                MessageBox.Show("정답을 입력해주시오.");
            }
            else
            {
                CollectResults();
                this.Close();
                form1.Show();
                form1.UpdateLabels();
            }

        }

        private void CollectResults()
        {
            string one = textBox1.Text;
            string two = textBox2.Text;

            string true_num = "";
            string false_num = "";

            if (one.Equals("dog"))
            {
                true_num += "4, ";
            }
            else
            {
                false_num += "4, ";
            }
            if (two.Equals("cat"))
            {
                true_num += "5";
            }
            else
            {
                false_num += "5";
            }
            Form1.DataFormForm += true_num;
            Form1.DataFormForm1 += false_num;

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            form1 = new Form1();
            form1.Show();
        }
    }
}
