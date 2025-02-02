using Rehber.Models;

namespace Rehber
{
    public partial class Form1 : Form
    {
        public MyDbContex db;
        public Kisi secilenkisi;
        public void yazd�r(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
        public void TextBoxSil(params string[] name)
        {
            foreach (var item in Controls)
            {
                if (item is TextBox && !name.Contains(((TextBox)item).Name))
                {
                    ((TextBox)item).Clear();
                }
            }

        }
        public void MuskTemizle(params string[] namess)
        {
            foreach (var item in Controls)
            {
                if(item is MaskedTextBox && !namess.Contains(((MaskedTextBox)item).Name))
                {
                    ((MaskedTextBox)item).Clear();
                }
            }
        }
        public void KisiListele()
        {
            var Listele = (from k in db.Kisiler
                           join dt in db.KisiDetaylar on k.KisiId equals dt.KisiId
                           select new ModelRehber
                           {
                               KisiId = k.KisiId,
                               Ad = k.Adi,
                               Soyad = k.Soyadi,
                               TelefonNo = dt.TelNo,
                               adres = dt.Adres,
                               TcKimlik = dt.TcKimlik,
                               DetayId = dt.KisiDetayId,

                           }).ToList();
            dataGridView1.DataSource = Listele;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }
        public Form1()
        {
            db = new MyDbContex();
            InitializeComponent();
            KisiListele();
            TextBoxSil();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_eke_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ad.Text) || string.IsNullOrWhiteSpace(txt_soy.Text) || string.IsNullOrWhiteSpace(txt_adres.Text)
                || string.IsNullOrWhiteSpace(msk_tc.Text) || string.IsNullOrWhiteSpace(msk_tel.Text))
            {
                yazd�r("L�TFEN B�T�N ALANLARI DOLDURUNUZ");
                return;
            }
            Kisi Kisiler = new Kisi()
            {
                Adi = txt_ad.Text,
                Soyadi = txt_soy.Text,

            };

            db.Kisiler.Add(Kisiler);
            db.SaveChanges();
            MuskTemizle();
            TextBoxSil();


            KisiDetay kisidetaylar = new KisiDetay()
            {
                KisiId = Kisiler.KisiId,
                TcKimlik = msk_tc.Text,
                Adres = txt_adres.Text,
                TelNo = msk_tel.Text,

            };
            db.KisiDetaylar.Add(kisidetaylar);
            db.SaveChanges();
            yazd�r("Ki�i Ba�ar�yla Eklendi");
            KisiListele();


        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                yazd�r("L�tfen Ki�i Se�iniz");
                return;
            }

            int �d = (int)dataGridView1.SelectedRows[0].Cells["KisiId"].Value;

            var secim = db.Kisiler.Find(�d);

            if (secim != null)
            {
                db.Kisiler.Remove(secim);
                db.SaveChanges();
                yazd�r("Ki�i B�ar�yla Silinmi�tir");
                KisiListele();
            }
            else yazd�r("Silinecek Ki�i Bulunamad�");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




            if (e.RowIndex >= 0) // Kullan�c� ge�erli bir sat�ra t�klad�ysa
            {


                if (e.RowIndex >= 0) // Kullan�c� ge�erli bir sat�ra t�klad�ysa
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Di�er bilgileri TextBox'lara ata
                    txt_ad.Text = row.Cells["Ad"].Value.ToString();
                    txt_soy.Text = row.Cells["Soyad"].Value.ToString();

                    // KisiDetay tablosundan ek bilgileri getir
                    int kisiId = Convert.ToInt32(row.Cells["KisiId"].Value); // ID'yi burada ald�k
                    KisiDetay detay = db.KisiDetaylar.FirstOrDefault(k => k.KisiId == kisiId);

                    if (detay != null)
                    {
                        msk_tc.Text = detay.TcKimlik;
                        msk_tel.Text = detay.TelNo;
                        txt_adres.Text = detay.Adres;
                    }
                }
            }

        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                yazd�r("L�tfen g�ncellemek istedi�iniz ki�iyi se�in.");
                return;
            }

            // DataGridView'den se�ilen ki�inin ID'sini al
            int kisiId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KisiId"].Value);

            // Ki�iyi ID'ye g�re bul
            var kisi = db.Kisiler.FirstOrDefault(k => k.KisiId == kisiId);
            if (kisi == null)
            {
                yazd�r("Ki�i veritaban�nda bulunamad�.");
                return;
            }

            // TextBox'lardan yeni bilgileri al ve g�ncelle
            kisi.Adi = txt_ad.Text;
            kisi.Soyadi = txt_soy.Text;

            // KisiDetay bilgilerini de g�ncelle
            var detay = db.KisiDetaylar.FirstOrDefault(d => d.KisiId == kisiId);
            if (detay != null)
            {
                detay.TcKimlik = msk_tc.Text;
                detay.TelNo = msk_tel.Text;
                detay.Adres = txt_adres.Text;
            }

            db.SaveChanges(); // De�i�iklikleri veritaban�na kaydet
            KisiListele(); // Listeyi g�ncelle
            TextBoxSil();
            MuskTemizle();
            yazd�r("Ki�i ba�ar�yla g�ncellendi.");
       
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            TextBoxSil();
            MuskTemizle();
        }
    }
}






