namespace Rehber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ADI = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_ad = new TextBox();
            txt_adres = new TextBox();
            txt_soy = new TextBox();
            dataGridView1 = new DataGridView();
            msk_tc = new MaskedTextBox();
            msk_tel = new MaskedTextBox();
            btn_eke = new Button();
            btn_sil = new Button();
            btn_guncelle = new Button();
            btn_temizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ADI
            // 
            ADI.AutoSize = true;
            ADI.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            ADI.Location = new Point(57, 75);
            ADI.Name = "ADI";
            ADI.Size = new Size(56, 24);
            ADI.TabIndex = 0;
            ADI.Text = "ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label2.Location = new Point(57, 175);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 1;
            label2.Text = "SOYADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label3.Location = new Point(40, 266);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 2;
            label3.Text = "TC KİMLİK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label4.Location = new Point(57, 375);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 3;
            label4.Text = "TELEFON";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label5.Location = new Point(40, 504);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 4;
            label5.Text = "ADRES:";
            // 
            // txt_ad
            // 
            txt_ad.AccessibleRole = AccessibleRole.SplitButton;
            txt_ad.Location = new Point(164, 68);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(150, 31);
            txt_ad.TabIndex = 5;
            // 
            // txt_adres
            // 
            txt_adres.Location = new Point(132, 481);
            txt_adres.Multiline = true;
            txt_adres.Name = "txt_adres";
            txt_adres.Size = new Size(364, 183);
            txt_adres.TabIndex = 6;
            // 
            // txt_soy
            // 
            txt_soy.Location = new Point(164, 172);
            txt_soy.Name = "txt_soy";
            txt_soy.Size = new Size(150, 31);
            txt_soy.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(502, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(887, 872);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // msk_tc
            // 
            msk_tc.Location = new Point(164, 263);
            msk_tc.Mask = "00000000000";
            msk_tc.Name = "msk_tc";
            msk_tc.Size = new Size(150, 31);
            msk_tc.TabIndex = 9;
            msk_tc.ValidatingType = typeof(int);
            // 
            // msk_tel
            // 
            msk_tel.Location = new Point(164, 372);
            msk_tel.Mask = "(999) 000-0000";
            msk_tel.Name = "msk_tel";
            msk_tel.Size = new Size(150, 31);
            msk_tel.TabIndex = 10;
            // 
            // btn_eke
            // 
            btn_eke.Location = new Point(29, 717);
            btn_eke.Name = "btn_eke";
            btn_eke.Size = new Size(112, 67);
            btn_eke.TabIndex = 11;
            btn_eke.Text = "EKLE";
            btn_eke.UseVisualStyleBackColor = true;
            btn_eke.Click += btn_eke_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(202, 717);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(112, 67);
            btn_sil.TabIndex = 12;
            btn_sil.Text = "SİL";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(384, 717);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(112, 67);
            btn_guncelle.TabIndex = 13;
            btn_guncelle.Text = "GÜNCELLE";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_temizle
            // 
            btn_temizle.Location = new Point(202, 812);
            btn_temizle.Name = "btn_temizle";
            btn_temizle.Size = new Size(112, 72);
            btn_temizle.TabIndex = 14;
            btn_temizle.Text = "TEMİZLE";
            btn_temizle.UseVisualStyleBackColor = true;
            btn_temizle.Click += btn_temizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1389, 890);
            Controls.Add(btn_temizle);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_sil);
            Controls.Add(btn_eke);
            Controls.Add(msk_tel);
            Controls.Add(msk_tc);
            Controls.Add(dataGridView1);
            Controls.Add(txt_soy);
            Controls.Add(txt_adres);
            Controls.Add(txt_ad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ADI);
            MaximizeBox = false;
            MaximumSize = new Size(1411, 946);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1411, 0);
            Name = "Form1";
            Text = "REHBER";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ADI;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_ad;
        private TextBox txt_adres;
        private TextBox txt_soy;
        private DataGridView dataGridView1;
        private MaskedTextBox msk_tc;
        private MaskedTextBox msk_tel;
        private Button btn_eke;
        private Button btn_sil;
        private Button btn_guncelle;
        private Button btn_temizle;
    }
}
