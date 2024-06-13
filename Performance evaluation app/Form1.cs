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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (Form2.ridio_Check1 == true)
            {
            label3.Visible = true;
            label3.Text = "객관식 1 : 정답";
            }
            
            if (Form2.ridio_Check2 == true)
            {
            label4.Visible = true;
            label4.Text = "객관식 2 : 정답";
            }
            
            if (Form2.ridio_Check3 == true)
            {
                label5.Visible = true;
                label5.Text = "객관식 3 : 정답";
            }
            
            if (Form3.score1 == true)
            {
                label6.Visible = true;
                label6.Text = "주관식 1 : 정답";
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        


    }
}
