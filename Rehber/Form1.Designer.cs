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
            ADI.Location = new Point(74, 96);
            ADI.Margin = new Padding(4, 0, 4, 0);
            ADI.Name = "ADI";
            ADI.Size = new Size(76, 33);
            ADI.TabIndex = 0;
            ADI.Text = "ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label2.Location = new Point(74, 224);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 33);
            label2.TabIndex = 1;
            label2.Text = "SOYADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label3.Location = new Point(52, 340);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 33);
            label3.TabIndex = 2;
            label3.Text = "TC KİMLİK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label4.Location = new Point(74, 480);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 33);
            label4.TabIndex = 3;
            label4.Text = "TELEFON";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label5.Location = new Point(52, 645);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 33);
            label5.TabIndex = 4;
            label5.Text = "ADRES:";
            // 
            // txt_ad
            // 
            txt_ad.AccessibleRole = AccessibleRole.SplitButton;
            txt_ad.Location = new Point(213, 87);
            txt_ad.Margin = new Padding(4);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(194, 39);
            txt_ad.TabIndex = 5;
            // 
            // txt_adres
            // 
            txt_adres.Location = new Point(172, 616);
            txt_adres.Margin = new Padding(4);
            txt_adres.Multiline = true;
            txt_adres.Name = "txt_adres";
            txt_adres.Size = new Size(472, 233);
            txt_adres.TabIndex = 6;
            // 
            // txt_soy
            // 
            txt_soy.Location = new Point(213, 220);
            txt_soy.Margin = new Padding(4);
            txt_soy.Name = "txt_soy";
            txt_soy.Size = new Size(194, 39);
            txt_soy.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(653, 15);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1153, 1116);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // msk_tc
            // 
            msk_tc.Location = new Point(213, 337);
            msk_tc.Margin = new Padding(4);
            msk_tc.Mask = "00000000000";
            msk_tc.Name = "msk_tc";
            msk_tc.Size = new Size(194, 39);
            msk_tc.TabIndex = 9;
            msk_tc.ValidatingType = typeof(int);
            // 
            // msk_tel
            // 
            msk_tel.Location = new Point(213, 476);
            msk_tel.Margin = new Padding(4);
            msk_tel.Mask = "(999) 000-0000";
            msk_tel.Name = "msk_tel";
            msk_tel.Size = new Size(194, 39);
            msk_tel.TabIndex = 10;
            // 
            // btn_eke
            // 
            btn_eke.Location = new Point(38, 918);
            btn_eke.Margin = new Padding(4);
            btn_eke.Name = "btn_eke";
            btn_eke.Size = new Size(146, 86);
            btn_eke.TabIndex = 11;
            btn_eke.Text = "EKLE";
            btn_eke.UseVisualStyleBackColor = true;
            btn_eke.Click += btn_eke_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(263, 918);
            btn_sil.Margin = new Padding(4);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(146, 86);
            btn_sil.TabIndex = 12;
            btn_sil.Text = "SİL";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(478, 906);
            btn_guncelle.Margin = new Padding(4);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(146, 86);
            btn_guncelle.TabIndex = 13;
            btn_guncelle.Text = "GÜNCELLE";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_temizle
            // 
            btn_temizle.Location = new Point(263, 1039);
            btn_temizle.Margin = new Padding(4);
            btn_temizle.Name = "btn_temizle";
            btn_temizle.Size = new Size(146, 92);
            btn_temizle.TabIndex = 14;
            btn_temizle.Text = "TEMİZLE";
            btn_temizle.UseVisualStyleBackColor = true;
            btn_temizle.Click += btn_temizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1800, 1120);
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
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1826, 1191);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1826, 71);
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
