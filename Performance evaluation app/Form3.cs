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

namespace Performance_evaluation_app
{
    public partial class Form3 : Form
    {
        private Form1 form;
        public Form3(Form1 form)
        {
            InitializeComponent();
            this.form = form1;
        }

        public static bool a = false;
        public static bool b = true;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("정답을 입력해주십시오.");
            }
            else
            {
                a = true;
                b= false;
                form
            }

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
