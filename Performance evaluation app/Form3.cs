using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performance_evaluation_app
{
    public partial class Form3 : Form
    {
        public static bool score1;
        public static bool score2;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "정답")
            {
                score1 = true;
            }
            if (textBox2.Text == "정답")
            {
                score2 = true;
            }

            Form1 form1 = new Form1();
            form1.Show(); 
            this.Hide();

           
        }
    }
}
