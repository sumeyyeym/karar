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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnOrnek_Click(object sender, EventArgs e)
        {
            //Ternary Operatörü (?): kısa işlemlerde, true-false işlemlerinde kullanılması tercih ediliyor. Tek satırda karar verilmesi gereken bir durum ise kullanılıyor

            //kullanıcı text box içine bir değer girdiyse o değeri, girmediyse de default bir değer gösteriniz


            // MessageBox.Show(txtDeger.Text.Length > 0 ? txtDeger.Text : "Default"); --> boşluk girildiği ya da boş bırakılıp butona basıldığı zaman da çalışır

            // MessageBox.Show(!string.IsNullOrEmpty(txtDeger.Text) ? txtDeger.Text : "default"); --> boş bırakılıp butona basıldığında default verir ama boşluğa basıl girildiğinde yine çalışır

            MessageBox.Show(!string.IsNullOrWhiteSpace(txtDeger.Text) ? txtDeger.Text : "default");
            
            //hem boşluk girildiğinde hem de boş bırakıldığında default verir

        }
    }
}
