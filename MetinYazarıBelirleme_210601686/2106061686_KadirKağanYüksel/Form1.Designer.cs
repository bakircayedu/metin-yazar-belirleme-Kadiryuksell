
namespace _2106061686_KadirKağanYüksel
{
    partial class frmOdev
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
            this.btnDosyaAl = new System.Windows.Forms.Button();
            this.btnStackeGonder = new System.Windows.Forms.Button();
            this.lblKelimeAnaliz = new System.Windows.Forms.Label();
            this.lstAnaliz = new System.Windows.Forms.ListBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.lblAranankelime = new System.Windows.Forms.Label();
            this.btnKelimeAra = new System.Windows.Forms.Button();
            this.btnAnalizAgacaAktar = new System.Windows.Forms.Button();
            this.btnTopKelime = new System.Windows.Forms.Button();
            this.btnHashTablo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDosyaAl
            // 
            this.btnDosyaAl.Location = new System.Drawing.Point(12, 27);
            this.btnDosyaAl.Name = "btnDosyaAl";
            this.btnDosyaAl.Size = new System.Drawing.Size(164, 111);
            this.btnDosyaAl.TabIndex = 0;
            this.btnDosyaAl.Text = "Txt dosyasını al";
            this.btnDosyaAl.UseVisualStyleBackColor = true;
            this.btnDosyaAl.Click += new System.EventHandler(this.btnDosyaAl_Click);
            // 
            // btnStackeGonder
            // 
            this.btnStackeGonder.Location = new System.Drawing.Point(11, 161);
            this.btnStackeGonder.Name = "btnStackeGonder";
            this.btnStackeGonder.Size = new System.Drawing.Size(164, 106);
            this.btnStackeGonder.TabIndex = 1;
            this.btnStackeGonder.Text = "Stack\'e oku";
            this.btnStackeGonder.UseVisualStyleBackColor = true;
            this.btnStackeGonder.Click += new System.EventHandler(this.btnStackeGonder_Click);
            // 
            // lblKelimeAnaliz
            // 
            this.lblKelimeAnaliz.AutoSize = true;
            this.lblKelimeAnaliz.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeAnaliz.Location = new System.Drawing.Point(353, 0);
            this.lblKelimeAnaliz.Name = "lblKelimeAnaliz";
            this.lblKelimeAnaliz.Size = new System.Drawing.Size(93, 32);
            this.lblKelimeAnaliz.TabIndex = 3;
            this.lblKelimeAnaliz.Text = "Analiz";
            // 
            // lstAnaliz
            // 
            this.lstAnaliz.FormattingEnabled = true;
            this.lstAnaliz.ItemHeight = 19;
            this.lstAnaliz.Location = new System.Drawing.Point(215, 35);
            this.lstAnaliz.Name = "lstAnaliz";
            this.lstAnaliz.Size = new System.Drawing.Size(385, 232);
            this.lstAnaliz.TabIndex = 4;
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(292, 346);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(218, 27);
            this.txtKelime.TabIndex = 5;
            // 
            // lblAranankelime
            // 
            this.lblAranankelime.AutoSize = true;
            this.lblAranankelime.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranankelime.Location = new System.Drawing.Point(286, 292);
            this.lblAranankelime.Name = "lblAranankelime";
            this.lblAranankelime.Size = new System.Drawing.Size(224, 32);
            this.lblAranankelime.TabIndex = 6;
            this.lblAranankelime.Text = "Aranacak Kelime";
            // 
            // btnKelimeAra
            // 
            this.btnKelimeAra.Location = new System.Drawing.Point(292, 387);
            this.btnKelimeAra.Name = "btnKelimeAra";
            this.btnKelimeAra.Size = new System.Drawing.Size(217, 89);
            this.btnKelimeAra.TabIndex = 7;
            this.btnKelimeAra.Text = "Metinde kelime ara";
            this.btnKelimeAra.UseVisualStyleBackColor = true;
            this.btnKelimeAra.Click += new System.EventHandler(this.btnKelimeAra_Click);
            // 
            // btnAnalizAgacaAktar
            // 
            this.btnAnalizAgacaAktar.Location = new System.Drawing.Point(12, 283);
            this.btnAnalizAgacaAktar.Name = "btnAnalizAgacaAktar";
            this.btnAnalizAgacaAktar.Size = new System.Drawing.Size(165, 106);
            this.btnAnalizAgacaAktar.TabIndex = 8;
            this.btnAnalizAgacaAktar.Text = "Analiz yap ve ağaca aktar";
            this.btnAnalizAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAnalizAgacaAktar.Click += new System.EventHandler(this.btnAnalizAgacaAktar_Click);
            // 
            // btnTopKelime
            // 
            this.btnTopKelime.Location = new System.Drawing.Point(11, 404);
            this.btnTopKelime.Name = "btnTopKelime";
            this.btnTopKelime.Size = new System.Drawing.Size(166, 106);
            this.btnTopKelime.TabIndex = 9;
            this.btnTopKelime.Text = "En çok kullanılan kelime";
            this.btnTopKelime.UseVisualStyleBackColor = true;
            this.btnTopKelime.Click += new System.EventHandler(this.btnTopKelime_Click);
            // 
            // btnHashTablo
            // 
            this.btnHashTablo.Location = new System.Drawing.Point(12, 528);
            this.btnHashTablo.Name = "btnHashTablo";
            this.btnHashTablo.Size = new System.Drawing.Size(168, 106);
            this.btnHashTablo.TabIndex = 10;
            this.btnHashTablo.Text = "Hash tablo oluştur";
            this.btnHashTablo.UseVisualStyleBackColor = true;
            this.btnHashTablo.Click += new System.EventHandler(this.btnHashTablo_Click);
            // 
            // frmOdev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 657);
            this.Controls.Add(this.btnHashTablo);
            this.Controls.Add(this.btnTopKelime);
            this.Controls.Add(this.btnAnalizAgacaAktar);
            this.Controls.Add(this.btnKelimeAra);
            this.Controls.Add(this.lblAranankelime);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.lstAnaliz);
            this.Controls.Add(this.lblKelimeAnaliz);
            this.Controls.Add(this.btnStackeGonder);
            this.Controls.Add(this.btnDosyaAl);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOdev";
            this.Text = "210601686_KadirKağanYüksel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaAl;
        private System.Windows.Forms.Button btnStackeGonder;
        private System.Windows.Forms.Label lblKelimeAnaliz;
        private System.Windows.Forms.ListBox lstAnaliz;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label lblAranankelime;
        private System.Windows.Forms.Button btnKelimeAra;
        private System.Windows.Forms.Button btnAnalizAgacaAktar;
        private System.Windows.Forms.Button btnTopKelime;
        private System.Windows.Forms.Button btnHashTablo;
    }
}

