using AracYonetim.BLL.Repository;
using AracYonetim.Entities.Enums;
using AracYonetim.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracYonetim.UI.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Marka yeniMarka = new Marka()
                {
                    MarkaAdi = txtMarkaAdi.Text,
                    Kurucusu = txtKurucu.Text,
                    KurulusYili = int.Parse(txtKurulus.Text),
                    Ulke = txtUlke.Text,
                    Logo = resimDosyasi

                };
                new MarkaRepo().insert(yeniMarka);
                resimDosyasi = null;
                pbMarkaLogo.Image = null;
                VerileriGetir();
                MessageBox.Show($"{yeniMarka.MarkaAdi} BAŞARIYLA EKLENDİ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { cmbVites.DataSource = Enum.GetNames(typeof(VitesTipleri));
                cmbYakit.DataSource = Enum.GetNames(typeof(Yakittipleri));
            VerileriGetir();

        }

        void VerileriGetir()
        {
            try
            {
                lstMarkalar.DataSource = new MarkaRepo().GetAll();
               
            }
            catch (Exception)
            {

                throw;
            }

        }
        private byte[] resimDosyasi;

        private void pbMarkaLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog()
            {
                Title = "bi resim seç",
                Multiselect = false,
                Filter = "JPG formatlı (*.jpg)|*.jpg;*.jpg;|PNG Formatlı | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memorystream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream filestream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (filestream.Read(buffer, 0, 64) != 0)
                {
                    memorystream.Write(buffer, 0, 64);
                }
                resimDosyasi = memorystream.ToArray();
                pbMarkaLogo.Image = new Bitmap(memorystream);
            }
        }

        private void lstMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarkalar.SelectedItem == null)
                return;
            var secili = lstMarkalar.SelectedItem as Marka;
            txtMarkaAdi.Text = secili.MarkaAdi;
            txtKurucu.Text = secili.Kurucusu;
            txtKurulus.Text = secili.KurulusYili.ToString();
            txtUlke.Text = secili.Ulke;
            if (secili.Logo != null)
            {
                try
                {
                    pbMarkaLogo.Image = new Bitmap(new MemoryStream(secili.Logo));

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                lstAraclar.DataSource = new MarkaRepo().GetById(secili.Id)?.Araclar;

            }
            //c# 7 ile gelen özellik
            //if (lstMarkalar.SelectedItem is Marka secili)
            //{
            //    txtMarkaAdi.Text = secili.MarkaAdi;
            //}
            //else 
            //pbMarkaLogo.Image = null;
            {

            }
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                var secili = lstMarkalar.SelectedItem as Marka;
                if (lstMarkalar.SelectedItem == null)
                    return;
                var yeniArac = new Arac()
                {
                    MarkaId = secili.Id,
                    Model = txtModel.Text,
                    UretimYili = int.Parse(txtYil.Text),
                    Vitestipi = (VitesTipleri)Enum.Parse(typeof(VitesTipleri), cmbVites.SelectedItem.ToString()),
                    Yakittipi = (Yakittipleri)Enum.Parse(typeof(Yakittipleri), cmbYakit.SelectedItem.ToString()),
                    Fotograf = resimDosyasi
                };

                new AracRepo().insert(yeniArac);
                pbAraclar.Image = null;
                resimDosyasi = null;
                VerileriGetir();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbAraclar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog()
            {
                Title = "bi resim seç",
                Multiselect = false,
                Filter = "JPG formatlı (*.jpg)|*.jpg;*.jpg;|PNG Formatlı | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memorystream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream filestream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (filestream.Read(buffer, 0, 64) != 0)
                {
                    memorystream.Write(buffer, 0, 64);
                }
                resimDosyasi = memorystream.ToArray();
                pbAraclar.Image = new Bitmap(memorystream);
            }
        }

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstAraclar.SelectedItem == null)
                return;
            var secili = lstAraclar.SelectedItem as Arac;
            txtModel.Text = secili.Model;
            txtYil.Text = secili.UretimYili.ToString();
            cmbVites.SelectedIndex = (short)secili.Vitestipi;
            cmbYakit.SelectedIndex = (short)secili.Yakittipi;
            if (secili.Fotograf != null)
            {
                try
                {
                    pbAraclar.Image = new Bitmap(new MemoryStream(secili.Fotograf));

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
                pbAraclar.Image = null;

        }
    }

}