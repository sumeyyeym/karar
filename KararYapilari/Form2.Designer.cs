namespace KararYapilari
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSatıs = new System.Windows.Forms.Button();
            this.btnMarketKontrol = new System.Windows.Forms.Button();
            this.btnNotKontrol = new System.Windows.Forms.Button();
            this.btnGirisKontrol = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGiris2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnSatıs
            // 
            this.btnSatıs.Location = new System.Drawing.Point(12, 176);
            this.btnSatıs.Name = "btnSatıs";
            this.btnSatıs.Size = new System.Drawing.Size(100, 23);
            this.btnSatıs.TabIndex = 8;
            this.btnSatıs.Text = "Satış İşlemleri";
            this.btnSatıs.UseVisualStyleBackColor = true;
            this.btnSatıs.Click += new System.EventHandler(this.BtnSatıs_Click);
            // 
            // btnMarketKontrol
            // 
            this.btnMarketKontrol.Location = new System.Drawing.Point(12, 147);
            this.btnMarketKontrol.Name = "btnMarketKontrol";
            this.btnMarketKontrol.Size = new System.Drawing.Size(100, 23);
            this.btnMarketKontrol.TabIndex = 7;
            this.btnMarketKontrol.Text = "Market Kontrolü";
            this.btnMarketKontrol.UseVisualStyleBackColor = true;
            this.btnMarketKontrol.Click += new System.EventHandler(this.BtnMarketKontrol_Click);
            // 
            // btnNotKontrol
            // 
            this.btnNotKontrol.Location = new System.Drawing.Point(12, 118);
            this.btnNotKontrol.Name = "btnNotKontrol";
            this.btnNotKontrol.Size = new System.Drawing.Size(100, 23);
            this.btnNotKontrol.TabIndex = 6;
            this.btnNotKontrol.Text = "Not Kontrolü";
            this.btnNotKontrol.UseVisualStyleBackColor = true;
            this.btnNotKontrol.Click += new System.EventHandler(this.BtnNotKontrol_Click);
            // 
            // btnGirisKontrol
            // 
            this.btnGirisKontrol.Location = new System.Drawing.Point(12, 60);
            this.btnGirisKontrol.Name = "btnGirisKontrol";
            this.btnGirisKontrol.Size = new System.Drawing.Size(100, 23);
            this.btnGirisKontrol.TabIndex = 5;
            this.btnGirisKontrol.Text = "Giriş Bilgisi Kontrolü";
            this.btnGirisKontrol.UseVisualStyleBackColor = true;
            this.btnGirisKontrol.Click += new System.EventHandler(this.BtnGirisKontrol_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnGiris2
            // 
            this.btnGiris2.Location = new System.Drawing.Point(12, 89);
            this.btnGiris2.Name = "btnGiris2";
            this.btnGiris2.Size = new System.Drawing.Size(100, 23);
            this.btnGiris2.TabIndex = 11;
            this.btnGiris2.Text = "Giriş Bilgisi Kontrolü";
            this.btnGiris2.UseVisualStyleBackColor = true;
            this.btnGiris2.Click += new System.EventHandler(this.BtnGiris2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 211);
            this.Controls.Add(this.btnGiris2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSatıs);
            this.Controls.Add(this.btnMarketKontrol);
            this.Controls.Add(this.btnNotKontrol);
            this.Controls.Add(this.btnGirisKontrol);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSatıs;
        private System.Windows.Forms.Button btnMarketKontrol;
        private System.Windows.Forms.Button btnNotKontrol;
        private System.Windows.Forms.Button btnGirisKontrol;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGiris2;
    }
}