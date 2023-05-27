namespace sametersoyogluFOdev2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVeriEkle = new System.Windows.Forms.TextBox();
            this.txtDugumSil = new System.Windows.Forms.TextBox();
            this.txtDugumDuzeyi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnDugumGoster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYaprakBul = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDugumSayisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPostorderGoster = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInorderGoster = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreorderGoster = new System.Windows.Forms.TextBox();
            this.richTextBox_dugumGoster = new System.Windows.Forms.RichTextBox();
            this.btnAgacBilgiGoster = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Düğüm Eklendi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Düğüm Silindi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Düğümün Düzeyi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preorder";
            // 
            // txtVeriEkle
            // 
            this.txtVeriEkle.Location = new System.Drawing.Point(140, 26);
            this.txtVeriEkle.Multiline = true;
            this.txtVeriEkle.Name = "txtVeriEkle";
            this.txtVeriEkle.Size = new System.Drawing.Size(89, 28);
            this.txtVeriEkle.TabIndex = 16;
            this.txtVeriEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVeriEkle_KeyPress);
            // 
            // txtDugumSil
            // 
            this.txtDugumSil.Location = new System.Drawing.Point(140, 70);
            this.txtDugumSil.Multiline = true;
            this.txtDugumSil.Name = "txtDugumSil";
            this.txtDugumSil.Size = new System.Drawing.Size(89, 28);
            this.txtDugumSil.TabIndex = 17;
            this.txtDugumSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDugumSil_KeyPress);
            // 
            // txtDugumDuzeyi
            // 
            this.txtDugumDuzeyi.Location = new System.Drawing.Point(140, 115);
            this.txtDugumDuzeyi.Multiline = true;
            this.txtDugumDuzeyi.Name = "txtDugumDuzeyi";
            this.txtDugumDuzeyi.Size = new System.Drawing.Size(89, 28);
            this.txtDugumDuzeyi.TabIndex = 18;
            this.txtDugumDuzeyi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDugumDuzeyi_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(250, 22);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 32);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Düğüm Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(251, 66);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 32);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Düğüm Silme";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(250, 111);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(92, 32);
            this.btnBul.TabIndex = 21;
            this.btnBul.Text = "Düğüm Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnDugumGoster
            // 
            this.btnDugumGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDugumGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDugumGoster.Location = new System.Drawing.Point(35, 176);
            this.btnDugumGoster.Name = "btnDugumGoster";
            this.btnDugumGoster.Size = new System.Drawing.Size(262, 35);
            this.btnDugumGoster.TabIndex = 22;
            this.btnDugumGoster.Text = "AĞAÇTAKİ DÜĞÜMLERİ GÖSTER";
            this.btnDugumGoster.UseVisualStyleBackColor = false;
            this.btnDugumGoster.Click += new System.EventHandler(this.btnDugumGoster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYaprakBul);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDugumSayisi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPostorderGoster);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInorderGoster);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPreorderGoster);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(509, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 352);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağaç Bilgileri";
            // 
            // txtYaprakBul
            // 
            this.txtYaprakBul.Location = new System.Drawing.Point(75, 289);
            this.txtYaprakBul.Multiline = true;
            this.txtYaprakBul.Name = "txtYaprakBul";
            this.txtYaprakBul.Size = new System.Drawing.Size(215, 22);
            this.txtYaprakBul.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Yapraklar";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(195, 231);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(95, 27);
            this.textBox8.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ağaçın Yüksekliği        -------->";
            // 
            // txtDugumSayisi
            // 
            this.txtDugumSayisi.Location = new System.Drawing.Point(195, 181);
            this.txtDugumSayisi.Multiline = true;
            this.txtDugumSayisi.Name = "txtDugumSayisi";
            this.txtDugumSayisi.Size = new System.Drawing.Size(95, 27);
            this.txtDugumSayisi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ağaçtaki Toplam Düğüm Sayısı";
            // 
            // txtPostorderGoster
            // 
            this.txtPostorderGoster.Location = new System.Drawing.Point(75, 106);
            this.txtPostorderGoster.Multiline = true;
            this.txtPostorderGoster.Name = "txtPostorderGoster";
            this.txtPostorderGoster.Size = new System.Drawing.Size(215, 22);
            this.txtPostorderGoster.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Postorder";
            // 
            // txtInorderGoster
            // 
            this.txtInorderGoster.Location = new System.Drawing.Point(75, 68);
            this.txtInorderGoster.Multiline = true;
            this.txtInorderGoster.Name = "txtInorderGoster";
            this.txtInorderGoster.Size = new System.Drawing.Size(215, 22);
            this.txtInorderGoster.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Inorder";
            // 
            // txtPreorderGoster
            // 
            this.txtPreorderGoster.Location = new System.Drawing.Point(75, 31);
            this.txtPreorderGoster.Multiline = true;
            this.txtPreorderGoster.Name = "txtPreorderGoster";
            this.txtPreorderGoster.Size = new System.Drawing.Size(215, 22);
            this.txtPreorderGoster.TabIndex = 4;
            // 
            // richTextBox_dugumGoster
            // 
            this.richTextBox_dugumGoster.Location = new System.Drawing.Point(35, 237);
            this.richTextBox_dugumGoster.Name = "richTextBox_dugumGoster";
            this.richTextBox_dugumGoster.Size = new System.Drawing.Size(263, 199);
            this.richTextBox_dugumGoster.TabIndex = 26;
            this.richTextBox_dugumGoster.Text = "";
            // 
            // btnAgacBilgiGoster
            // 
            this.btnAgacBilgiGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgacBilgiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAgacBilgiGoster.Location = new System.Drawing.Point(535, 22);
            this.btnAgacBilgiGoster.Name = "btnAgacBilgiGoster";
            this.btnAgacBilgiGoster.Size = new System.Drawing.Size(264, 35);
            this.btnAgacBilgiGoster.TabIndex = 27;
            this.btnAgacBilgiGoster.Text = "AĞAÇTAKİ DÜĞÜMLERİ GÖSTER";
            this.btnAgacBilgiGoster.UseVisualStyleBackColor = false;
            this.btnAgacBilgiGoster.Click += new System.EventHandler(this.btnAgacBilgiGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(835, 448);
            this.Controls.Add(this.btnAgacBilgiGoster);
            this.Controls.Add(this.richTextBox_dugumGoster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDugumGoster);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDugumDuzeyi);
            this.Controls.Add(this.txtDugumSil);
            this.Controls.Add(this.txtVeriEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVeriEkle;
        private System.Windows.Forms.TextBox txtDugumSil;
        private System.Windows.Forms.TextBox txtDugumDuzeyi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnDugumGoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYaprakBul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDugumSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPostorderGoster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInorderGoster;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreorderGoster;
        private System.Windows.Forms.RichTextBox richTextBox_dugumGoster;
        private System.Windows.Forms.Button btnAgacBilgiGoster;
    }
}

