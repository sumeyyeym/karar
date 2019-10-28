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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnOrnek_Click(object sender, EventArgs e)
        {
            // switch case sadece eşitlik durumlarını kontrol ediyor. sadece eşitlik üzerine çalışılıyorsa hızlı ve performanslı. çünkü girilen veriyi algılayıp ilgili case'i direkt olarak çalıştırır. ifteki gibi tek tek her adımı işlemez

            string username = txtGelenDeger.Text;
            switch(username)
            {
                case "admin":
                    MessageBox.Show("Admin Hoşgeldin");
                    break;
                case "ceo":
                    MessageBox.Show("CEO Hoşgeldin");
                    break;
                case "user":
                    MessageBox.Show("User niye buradasın?");
                    break;
            }
        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            /* kullanıcı dışarıdan kullanıcı adı ve şifresini girecek. 
             1) kullanıcı adını yanlış girerse "Kullanıcı adınız yanlış, şifrenizi kontrol edemedim."
             2) kullanıcı adını doğru girerse, şifresini kontrol et
             3) kullanıcı şifresini yanlış girerse "Kullanıcı adınız doğru fakat şifreniz yanlış."
             4) şifre de doğru ise "Tebrikler, hayata dair büyük bir başarı." */

            string  user = txtUser.Text, pass = txtPassword.Text;

            /*if (user == username)
            {
            string username = "admin", password = "123";
            
            if (pass == password)
                {
                    MessageBox.Show("Tebrikler, hayata dair büyük bir başarı.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız doğru fakat şifreniz yanlış.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız yanlış, şifrenizi kontrol edemedim.");
            }*/

            switch (user)
            {
                case "admin":
                    switch (pass)
                    {
                        case "123":
                            MessageBox.Show("Tebrikler, hayata dair büyük bir başarı.");
                            break;
                        default:
                            MessageBox.Show("Kullanıcı adınız doğru fakat şifreniz yanlış.");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Kullanıcı adınız yanlış, şifrenizi kontrol edemedim.");
                    break;
            }
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            /*
             dışarıdan admin, ceo, moderatör girilirse yönetim paneli
             user girilirse kullanıcı paneli
             default bir değer girilirse yetki hatası mesajı verin
             */

            switch (txtUser.Text)
            {
                case "admin" :                   
                case "ceo":
                case "moderator":
                    MessageBox.Show("Yönetim Paneline Yönlendiriliyorsunuz.");
                    break;
                case "user":
                    MessageBox.Show("Kullanıcı Paneline Yönlendiriliyorsunuz.");
                    break;
                default:
                    MessageBox.Show("Yetki Hatası!");
                    break;

            }
        }
    }
}
