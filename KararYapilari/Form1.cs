using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdminKontrol_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == "admin")
            {
                MessageBox.Show("Tebrikler, giriş yaptınız.");
            } //true
           else
            {
                MessageBox.Show("Ne kadar zor olabilir???");
            } //false
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNotKontrol_Click(object sender, EventArgs e)
        {
            //Eğer girilen not 0'dan küçükse "0'dan küçük bir not girişi yapamazsını!"; 100'den büyükse "100'den büyük bir not girişi yapamazsınız!"

            int not = int.Parse(textBox1.Text);

            if (not < 0)
            {
                MessageBox.Show("0'dan küçük bir not girişi yapamazsını!");
            }
            else if (not > 100)
            {
                MessageBox.Show("100'den büyük bir not girişi yapamazsınız!");
            }
            else
            {
                MessageBox.Show("Notunuz: " + not);
            }
        }

        private void BtnTekCift_Click(object sender, EventArgs e)
        {
            //texten girilen sayi çift ise "Sayı Çifttir" tek ise "Sayı Tektir" 

            int sayi = int.Parse(textBox1.Text);

            if ((sayi % 2) == 0)
            {
                MessageBox.Show("Sayı Çifttir");
            }
            else
            {
                MessageBox.Show("Sayı Tektir");
            }
        }

        private void BtnDeger_Click(object sender, EventArgs e)
        {
            //girilen kelimenin uzunluğu 8'den küçükse "Lütfen daha uzun bir parola giriniz" değilse "İşlem doğrulandı."

            if (textBox1.Text.Length >= 8)
            {
                MessageBox.Show("Tebrikler");
            }
            else
            {
                MessageBox.Show("Lütfen daha uzun bir parola giriniz.");
            }
        }
    }
}
