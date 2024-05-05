namespace biletdiyorum
{
    partial class bılet
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnSıl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbIller = new System.Windows.Forms.ListBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.lsbIller2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(262, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(95, 244);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(108, 23);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Seçilenleri Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnSıl
            // 
            this.btnSıl.Location = new System.Drawing.Point(229, 244);
            this.btnSıl.Name = "btnSıl";
            this.btnSıl.Size = new System.Drawing.Size(108, 23);
            this.btnSıl.TabIndex = 2;
            this.btnSıl.Text = "Seçilenleri Sil";
            this.btnSıl.UseVisualStyleBackColor = true;
            this.btnSıl.Click += new System.EventHandler(this.btnSıl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İller:";
            // 
            // lsbIller
            // 
            this.lsbIller.AllowDrop = true;
            this.lsbIller.FormattingEnabled = true;
            this.lsbIller.Items.AddRange(new object[] {
            "İzmir",
            "İstanbul",
            "Ankara",
            "Karaman",
            "Gümüşhane",
            "Niğde",
            "Londra"});
            this.lsbIller.Location = new System.Drawing.Point(142, 100);
            this.lsbIller.Name = "lsbIller";
            this.lsbIller.Size = new System.Drawing.Size(131, 95);
            this.lsbIller.TabIndex = 4;
            this.lsbIller.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsbIller2_DragDrop);
            this.lsbIller.DragEnter += new System.Windows.Forms.DragEventHandler(this.bılet_DragEnter);
            this.lsbIller.DragOver += new System.Windows.Forms.DragEventHandler(this.bılet_DragOver);
            this.lsbIller.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bılet_MouseDown);
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(142, 41);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(100, 20);
            this.txtIl.TabIndex = 5;
            this.txtIl.TextChanged += new System.EventHandler(this.txtIl_TextChanged);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(333, 117);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(75, 23);
            this.btnSag.TabIndex = 6;
            this.btnSag.Text = ">>";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(333, 146);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(75, 23);
            this.btnSol.TabIndex = 7;
            this.btnSol.Text = "<<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // lsbIller2
            // 
            this.lsbIller2.AllowDrop = true;
            this.lsbIller2.FormattingEnabled = true;
            this.lsbIller2.Location = new System.Drawing.Point(468, 100);
            this.lsbIller2.Name = "lsbIller2";
            this.lsbIller2.Size = new System.Drawing.Size(131, 95);
            this.lsbIller2.TabIndex = 8;
            this.lsbIller2.SelectedIndexChanged += new System.EventHandler(this.lsbIller2_SelectedIndexChanged);
            this.lsbIller2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsbIller2_DragDrop);
            this.lsbIller2.DragEnter += new System.Windows.Forms.DragEventHandler(this.bılet_DragEnter);
            this.lsbIller2.DragOver += new System.Windows.Forms.DragEventHandler(this.bılet_DragOver);
            this.lsbIller2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bılet_MouseDown);
            // 
            // bılet
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbIller2);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.lsbIller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSıl);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnEkle);
            this.Name = "bılet";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsbIller2_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.bılet_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.bılet_DragOver);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bılet_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnSıl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbIller;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.ListBox lsbIller2;
    }
}

