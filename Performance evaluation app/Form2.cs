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
        public static bool ridio_Check1;
        public static bool ridio_Check2;
        public static bool ridio_Check3;

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
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ridio_Check1 = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ridio_Check2 = true;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            ridio_Check3 = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
