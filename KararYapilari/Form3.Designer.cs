namespace KararYapilari
{
    partial class Form3
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
            this.btnOrnek = new System.Windows.Forms.Button();
            this.txtGelenDeger = new System.Windows.Forms.TextBox();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(12, 38);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(100, 23);
            this.btnOrnek.TabIndex = 0;
            this.btnOrnek.Text = "Örnek 1";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.BtnOrnek_Click);
            // 
            // txtGelenDeger
            // 
            this.txtGelenDeger.Location = new System.Drawing.Point(12, 12);
            this.txtGelenDeger.Name = "txtGelenDeger";
            this.txtGelenDeger.Size = new System.Drawing.Size(100, 20);
            this.txtGelenDeger.TabIndex = 1;
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(12, 119);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(100, 23);
            this.btnOrnek2.TabIndex = 2;
            this.btnOrnek2.Text = "Örnek 2";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.BtnOrnek2_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 67);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(12, 148);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(100, 23);
            this.btnOrnek3.TabIndex = 5;
            this.btnOrnek3.Text = "Örnek 3";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.BtnOrnek3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 208);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.txtGelenDeger);
            this.Controls.Add(this.btnOrnek);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek;
        private System.Windows.Forms.TextBox txtGelenDeger;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOrnek3;
    }
}