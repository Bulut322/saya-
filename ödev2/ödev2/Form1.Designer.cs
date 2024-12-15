namespace ödev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnbaşlat = new System.Windows.Forms.Button();
            this.btndur = new System.Windows.Forms.Button();
            this.btnsifirla = new System.Windows.Forms.Button();
            this.lbldakika = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsaniye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnbaşlat
            // 
            this.btnbaşlat.BackColor = System.Drawing.Color.Chartreuse;
            this.btnbaşlat.Location = new System.Drawing.Point(164, 245);
            this.btnbaşlat.Name = "btnbaşlat";
            this.btnbaşlat.Size = new System.Drawing.Size(111, 56);
            this.btnbaşlat.TabIndex = 0;
            this.btnbaşlat.Text = "Başlat";
            this.btnbaşlat.UseVisualStyleBackColor = false;
            this.btnbaşlat.Click += new System.EventHandler(this.btnbaşlat_Click);
            // 
            // btndur
            // 
            this.btndur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndur.Location = new System.Drawing.Point(307, 245);
            this.btndur.Name = "btndur";
            this.btndur.Size = new System.Drawing.Size(111, 56);
            this.btndur.TabIndex = 1;
            this.btndur.Text = "Durdur";
            this.btndur.UseVisualStyleBackColor = false;
            this.btndur.Click += new System.EventHandler(this.btndur_Click);
            // 
            // btnsifirla
            // 
            this.btnsifirla.BackColor = System.Drawing.Color.Red;
            this.btnsifirla.Location = new System.Drawing.Point(477, 245);
            this.btnsifirla.Name = "btnsifirla";
            this.btnsifirla.Size = new System.Drawing.Size(111, 56);
            this.btnsifirla.TabIndex = 2;
            this.btnsifirla.Text = "sıfırla";
            this.btnsifirla.UseVisualStyleBackColor = false;
            this.btnsifirla.Click += new System.EventHandler(this.btnsifirla_Click);
            // 
            // lbldakika
            // 
            this.lbldakika.AutoSize = true;
            this.lbldakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldakika.Location = new System.Drawing.Point(207, 147);
            this.lbldakika.Name = "lbldakika";
            this.lbldakika.Size = new System.Drawing.Size(36, 39);
            this.lbldakika.TabIndex = 3;
            this.lbldakika.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(345, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // lblsaniye
            // 
            this.lblsaniye.AutoSize = true;
            this.lblsaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsaniye.Location = new System.Drawing.Point(479, 147);
            this.lblsaniye.Name = "lblsaniye";
            this.lblsaniye.Size = new System.Drawing.Size(36, 39);
            this.lblsaniye.TabIndex = 5;
            this.lblsaniye.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsaniye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldakika);
            this.Controls.Add(this.btnsifirla);
            this.Controls.Add(this.btndur);
            this.Controls.Add(this.btnbaşlat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnbaşlat;
        private System.Windows.Forms.Button btndur;
        private System.Windows.Forms.Button btnsifirla;
        private System.Windows.Forms.Label lbldakika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsaniye;
    }
}

