using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        float out_ilkSayi = 0, out_ikinciSayi = 0;
        string islem = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "";
            maskedtxtilk.Clear();
            maskedtxtiki.Clear();
            out_ilkSayi = 0;
            out_ikinciSayi = 0;
            islem = "";
            toolStripStatusLabel1.Text = "  ";

        }

        public float Toplam(float sayi1, float sayi2)
        {
            return sayi1 + sayi2;
        }
        public float Cıkar(float sayi1, float sayi2)
        {
            return sayi1 - sayi2;
        }
        public float Carp(float sayi1, float sayi2)
        {
            return sayi1 * sayi2;
        }
        public float Bolum(float sayi1, float sayi2)
        {
            return sayi1 / sayi2;
        }

       
        /// <param name="op"></param>
        private void Operator_Click(string op ="+")
        {
            {
                //giridyi int e çevirdiik
                if (float.TryParse(maskedtxtilk.Text, out out_ilkSayi) && float.TryParse(maskedtxtiki.Text, out out_ikinciSayi))
                {
                    try
                    {
                        float result = 0;
                        if (op == "+")
                            result = Toplam(out_ilkSayi, out_ikinciSayi);
                        else if (op == "-")
                            result = Cıkar(out_ilkSayi, out_ikinciSayi);
                        else if (op == "*")
                            result = Carp(out_ilkSayi, out_ikinciSayi);
                        else if (op == "/")
                            result = Bolum(out_ilkSayi, out_ikinciSayi);

                        txtsonuc.Text = result.ToString();
                        toolStripStatusLabel1.Text = "  ";
                    }
                    catch (DivideByZeroException ex)
                    {
                        string msg = txtsonuc.Text = ex.Message;
                        toolStripStatusLabel1.Text = $"{msg}";
                        toolStripStatusLabel1.ForeColor = Color.Red;
                        timer1.Interval = 1000; // 1 saniye
                        timer1.Start();

                    }
                    catch (Exception ex2)
                    {
                        string msg2= txtsonuc.Text = ex2.Message;
                        toolStripStatusLabel1.Text = $"{msg2}";
                        toolStripStatusLabel1.ForeColor = Color.Red;
                        timer1.Interval = 1000; 
                        timer1.Start();
                    }
                }
                else
                {
                    toolStripStatusLabel1.Text = "Geçerli sayılar giriniz!";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    timer1.Interval = 1000;
                    timer1.Start();

                }
            }
        }

        private void btn_mlt_Click(object sender, EventArgs e)
        {
            Operator_Click("*");

        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            Operator_Click("/");
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            Operator_Click("-");
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            Operator_Click("+");
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void maskedtxtilk_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedtxtiki_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSonuc_TextChanged(object sender, EventArgs e)
        {

        }



    }

}
