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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateLabels()
        {
            label3.Text = "정답 문항 : " + Form2.true_num;
            label4.Text = "오답 문항 : " + Form2.false_num;
            label5.Text = "총점 : ";

            label3.Visible = label4.Visible = label5.Visible = Form3.a;
            button1.Enabled = Form3.b;
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
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        


    }
}
