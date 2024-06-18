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

        public Form2()
        {
            InitializeComponent();
        }


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

        private void d()
        {
            string true_num = "";

            if (radioButton3.Checked)
            {
                true_num += "1 ";
            }
        }

    }
}
