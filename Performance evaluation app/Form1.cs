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
        public static string DataFormForm = string.Empty;
        public static string DataFormForm1 = string.Empty;

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
                this.Hide();
                Form2 form2 = new Form2(this);
                form2.Show();
                form2.FormClosed += (s, args) => this.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }


        public void UpdateLabels()
        {
            string true_num = DataFormForm;
            string false_num = DataFormForm1;
            int scoreValue = true_num.Replace(", ", "").Length;

            if (false_num == ""){
                false_num = "0";
            }
            if (true_num == "")
            {
                true_num = "0";
            }


            Wow.Text = "맞은 번호: "+ true_num;
            Oops.Text = "틀린 번호: " + false_num;

            score.Text = "총점 " + scoreValue.ToString();
        }



    }
}
