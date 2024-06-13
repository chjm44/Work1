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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("이름과 학번을 정확히 입력 해주세요.");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

                form2.FormClosed += (s, args) => this.Show();
            }

        }
       

    }
}
