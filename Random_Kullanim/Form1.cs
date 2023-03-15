using System;
using System.Windows.Forms;

namespace Random_Kullanim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(1, 5);
            s2 = rnd.Next(1, 5);
            s3 = rnd.Next(1, 5);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();

            if (s1 == 3 && s2 == 3 && s3 ==3)
            {
                MessageBox.Show("Tebrikler Kazandınız!");
            }
        }
    }
}
