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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGirisKontrol_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";
            string result = "";

            if (username == textBox1.Text)
            {
                if (password == textBox2.Text)
                {
                    result = "Tebrikler!";
                }
                else
                {
                    result = "Şifreniz Yanlış.\nAnne sütü önemli.";
                }
            }
            else
            {
                result = "Kullanıcı adın yanlış.\nYine hayal kırıklığısın.";
            }
            MessageBox.Show(result);
        }

        private void BtnNotKontrol_Click(object sender, EventArgs e)
        {
            //Girilen not 0-30 ise "FF" 30-50 "DD" 50-70 "BB" 70-100 "AA"

            int not = int.Parse(textBox1.Text);
            string result = "Harf Notunuz: ";

            if (not >= 0 && not <= 30)
                result += "FF"; //eğer kod tek satırsa süslü parantez olmasa da olur
            else if (not > 30 && not <= 50)
            {
                result += "DD"; // + işareti yukarıdaki result metnine ak metin yapmanı sağlıyo
            }
            else if (not > 50 && not <= 70)
            {
                result += "BB";
            }
            else if (not > 70 && not <= 100)
            {
                result += "AA";
            }
            else
            {
                result = "Geçerli bir aralık giriniz.";
            }
            MessageBox.Show(result);


            //KISA YOL:
            /*
            if (not >= 0 && not <= 100)
            {
                if (not <= 30) { result += "FF"; }
                else if (not <= 50) { result += "DD"; }
                else if (not <= 70) { result += "CC"; }
                else if (not <= 85) { result += "BB"; }
                else { result += "AA"; }
            }
            else
                result = "Geçerli bir aralık giriniz.";
            MessageBox.Show(result);
            */
        }

        private void BtnMarketKontrol_Click(object sender, EventArgs e)
        {
            /*Dışarıdan ürün adı girilecek, kasiyer bize ürünün hangi reyonda olduğunu söyleyecek.
             Domates, Biber, Patlıcan => Sebze Reyonu
             Diş Macunu, Parfüm, Şampuan => Kozmetik R
             Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji R
             Başka bir ürün girildiğinde "Bu ürün elimizde bulunmamaktadır."*/

            string ürün = textBox1.Text.ToLower(); // hepsini küçük harfe çevirir yazılanların
            string m = "";
            if (ürün == "domates" || ürün == "biber" || ürün == "patlıcan")
                m = "Sebze Reyonu";
            else if (ürün == "diş macunu" || ürün == "parfüm" || ürün == "şampuan")
                m = "Kozmetik Reyonu";
            else if (ürün == "cep Telefonu" || ürün == "bilgisayar" || ürün == "ses sistemi")
                m = "Teknoloji Reyonu";
            else
                m = "Bu ürün elimizde bulunmamaktadır.";
            MessageBox.Show(m);
        }

        private void BtnSatıs_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGiris2_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";
            string result = "";

            if(textBox1.Text == username && textBox2.Text == password)
            {
                result = "Tebriks kanki :)";
            }
            else
            {
                result = "Davar.";
            }
            MessageBox.Show(result);
        }
    }
}
