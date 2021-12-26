
namespace burcHesaplama
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
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblDgum = new System.Windows.Forms.Label();
            this.lblYasiniz = new System.Windows.Forms.Label();
            this.lblYasadiginizGun = new System.Windows.Forms.Label();
            this.lblBurc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(131, 124);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(298, 30);
            this.dtpDogumTarihi.TabIndex = 0;
            // 
            // lblDgum
            // 
            this.lblDgum.AutoSize = true;
            this.lblDgum.Location = new System.Drawing.Point(131, 83);
            this.lblDgum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDgum.Name = "lblDgum";
            this.lblDgum.Size = new System.Drawing.Size(160, 25);
            this.lblDgum.TabIndex = 1;
            this.lblDgum.Text = "Doğum Tarihiniz:";
            // 
            // lblYasiniz
            // 
            this.lblYasiniz.AutoSize = true;
            this.lblYasiniz.Location = new System.Drawing.Point(131, 228);
            this.lblYasiniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYasiniz.Name = "lblYasiniz";
            this.lblYasiniz.Size = new System.Drawing.Size(81, 25);
            this.lblYasiniz.TabIndex = 1;
            this.lblYasiniz.Text = "Yaşınız:";
            // 
            // lblYasadiginizGun
            // 
            this.lblYasadiginizGun.AutoSize = true;
            this.lblYasadiginizGun.Location = new System.Drawing.Point(131, 286);
            this.lblYasadiginizGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYasadiginizGun.Name = "lblYasadiginizGun";
            this.lblYasadiginizGun.Size = new System.Drawing.Size(160, 25);
            this.lblYasadiginizGun.TabIndex = 1;
            this.lblYasadiginizGun.Text = "Yaşadığınız Gün:";
            // 
            // lblBurc
            // 
            this.lblBurc.AutoSize = true;
            this.lblBurc.Location = new System.Drawing.Point(131, 342);
            this.lblBurc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBurc.Name = "lblBurc";
            this.lblBurc.Size = new System.Drawing.Size(101, 25);
            this.lblBurc.TabIndex = 1;
            this.lblBurc.Text = "Burcunuz:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(131, 167);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(112, 36);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 473);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblBurc);
            this.Controls.Add(this.lblYasadiginizGun);
            this.Controls.Add(this.lblYasiniz);
            this.Controls.Add(this.lblDgum);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BurçGünYaş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label lblDgum;
        private System.Windows.Forms.Label lblYasiniz;
        private System.Windows.Forms.Label lblYasadiginizGun;
        private System.Windows.Forms.Label lblBurc;
        private System.Windows.Forms.Button btnHesapla;
    }
}

