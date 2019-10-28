namespace KararYapilari
{
    partial class Form4
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(12, 38);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(100, 23);
            this.btnOrnek.TabIndex = 0;
            this.btnOrnek.Text = "Örnek";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.BtnOrnek_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(12, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(100, 20);
            this.txtDeger.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 85);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.btnOrnek);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek;
        private System.Windows.Forms.TextBox txtDeger;
    }
}