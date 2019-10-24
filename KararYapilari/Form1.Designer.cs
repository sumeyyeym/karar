namespace KararYapilari
{
    partial class Form1
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
            this.btnAdminKontrol = new System.Windows.Forms.Button();
            this.btnNotKontrol = new System.Windows.Forms.Button();
            this.btnTekCift = new System.Windows.Forms.Button();
            this.btnDeger = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdminKontrol
            // 
            this.btnAdminKontrol.Location = new System.Drawing.Point(12, 38);
            this.btnAdminKontrol.Name = "btnAdminKontrol";
            this.btnAdminKontrol.Size = new System.Drawing.Size(100, 23);
            this.btnAdminKontrol.TabIndex = 0;
            this.btnAdminKontrol.Text = "Admin Kontrolü";
            this.btnAdminKontrol.UseVisualStyleBackColor = true;
            this.btnAdminKontrol.Click += new System.EventHandler(this.BtnAdminKontrol_Click);
            // 
            // btnNotKontrol
            // 
            this.btnNotKontrol.Location = new System.Drawing.Point(12, 67);
            this.btnNotKontrol.Name = "btnNotKontrol";
            this.btnNotKontrol.Size = new System.Drawing.Size(100, 23);
            this.btnNotKontrol.TabIndex = 1;
            this.btnNotKontrol.Text = "Not Kontrolü";
            this.btnNotKontrol.UseVisualStyleBackColor = true;
            this.btnNotKontrol.Click += new System.EventHandler(this.BtnNotKontrol_Click);
            // 
            // btnTekCift
            // 
            this.btnTekCift.Location = new System.Drawing.Point(12, 96);
            this.btnTekCift.Name = "btnTekCift";
            this.btnTekCift.Size = new System.Drawing.Size(100, 23);
            this.btnTekCift.TabIndex = 2;
            this.btnTekCift.Text = "Tek-Çift Kontrolü";
            this.btnTekCift.UseVisualStyleBackColor = true;
            this.btnTekCift.Click += new System.EventHandler(this.BtnTekCift_Click);
            // 
            // btnDeger
            // 
            this.btnDeger.Location = new System.Drawing.Point(12, 125);
            this.btnDeger.Name = "btnDeger";
            this.btnDeger.Size = new System.Drawing.Size(100, 23);
            this.btnDeger.TabIndex = 3;
            this.btnDeger.Text = "Değer Kontrolü";
            this.btnDeger.UseVisualStyleBackColor = true;
            this.btnDeger.Click += new System.EventHandler(this.BtnDeger_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 161);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDeger);
            this.Controls.Add(this.btnTekCift);
            this.Controls.Add(this.btnNotKontrol);
            this.Controls.Add(this.btnAdminKontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminKontrol;
        private System.Windows.Forms.Button btnNotKontrol;
        private System.Windows.Forms.Button btnTekCift;
        private System.Windows.Forms.Button btnDeger;
        private System.Windows.Forms.TextBox textBox1;
    }
}

