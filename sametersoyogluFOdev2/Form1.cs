using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sametersoyogluFOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class agacDugumİkili
        {
            public int veriler;
            public agacDugumİkili sol;
            public agacDugumİkili sag;
        }

        agacDugumİkili agacKok = null;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            agacDugumİkili veri = new agacDugumİkili();
            veri.veriler = Convert.ToInt32(txtVeriEkle.Text);
            txtVeriEkle.Clear();

            if (agacKok == null)
            {
                agacKok = veri;
                agacKok.sag = null;
                agacKok.sol = null;
            }
            else
            {
                agacDugumİkili mevcut = agacKok;
                agacDugumİkili gecici = agacKok;

                while (true)
                {

                    mevcut = gecici;

                    if (mevcut.veriler <= veri.veriler)
                    {
                        gecici = gecici.sag;
                        if (gecici == null)
                        {
                            mevcut.sag = veri;
                            mevcut = mevcut.sag;
                            mevcut.sag = null;
                            mevcut.sol = null;
                            return;
                        }

                    }
                    else
                    {
                        gecici = gecici.sol;
                        if (gecici == null)
                        {
                            mevcut.sol = veri;
                            mevcut = mevcut.sol;
                            mevcut.sol = null;
                            mevcut.sag = null;
                            return;
                        }
                    }
                }
            }

        }

        public void dugumGoster(agacDugumİkili akok)
        {
            if (akok == null)
            {
                return;
            }

            dugumGoster(akok.sag);
            richTextBox_dugumGoster.Text += akok.veriler.ToString() + " <--->";
            dugumGoster(akok.sol);

        }


        private void btnDugumGoster_Click(object sender, EventArgs e)
        {
            richTextBox_dugumGoster.Text = null;
            dugumGoster(agacKok);

        }

        public void Preorder(agacDugumİkili akok)
        {
            //Preorder = Kök - Sol - Sağ
            if (akok == null)
                return;

            txtPreorderGoster.Text += akok.veriler.ToString() + " - ";
            Preorder(akok.sol);
            Preorder(akok.sag);
        }

        public void Inorder(agacDugumİkili akok)
        {
            // Inorder = Sol - Kök- Sağ
            if (akok == null)
                return;

            Inorder(akok.sol);
            txtInorderGoster.Text += akok.veriler.ToString() + " - ";
            Inorder(akok.sag);
        }

        public void Postorder(agacDugumİkili akok)
        {
            // Postorder = Sol - Sağ - Kök
            if (akok == null)
                return;

            Postorder(akok.sol);
            Postorder(akok.sag);
            txtPostorderGoster.Text += akok.veriler.ToString() + " - ";

        }

        private void btnAgacBilgiGoster_Click(object sender, EventArgs e)
        {
            Preorder(agacKok);
            Inorder(agacKok);
            Postorder(agacKok);
            agacDugumSayisi(agacKok);
            agacYaprakBul(agacKok);

        }

        public int agacDugumSayisi(agacDugumİkili akok)
        {
            int dugumSayi = 0;
            if (akok != null)
            {
                dugumSayi = 1;
                dugumSayi = dugumSayi + agacDugumSayisi(akok.sol);
                dugumSayi = dugumSayi + agacDugumSayisi(akok.sag);
            }
            txtDugumSayisi.Text = " " + dugumSayi.ToString();
            return dugumSayi;
        }

        public void agacYaprakBul(agacDugumİkili akok)
        {
            if (akok == null)
                return;

            if (akok.sol == null && akok.sag == null)
            {
                txtYaprakBul.Text += akok.veriler.ToString() + " - ";
                return;
            }
            agacYaprakBul(akok.sol);
            agacYaprakBul(akok.sag);

        }

        private agacDugumİkili SilDugum(agacDugumİkili akok, int veri)
        {
            // dugum bulma, arama
            if (akok == null)
                return akok;

            else if (veri < akok.veriler)
            {
                akok.sol = SilDugum(akok.sol, veri);
            }
            else if (veri > akok.veriler)
            {
                akok.sag = SilDugum(akok.sag, veri);
            }
            else // dugum bulunduktan sonra silme
            {
                if (akok.sol == null && akok.sag == null)
                {
                    akok = null;
                }
                else if (akok.sol == null)
                {
                    akok = akok.sag;
                }
                else if (akok.sag == null)
                {
                    akok = akok.sol;
                }
            }
            return akok;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtDugumSil.Text == "")
            {
                MessageBox.Show("Lütfen Silmek istediğiniz düğümü giriniz.", "Boş Girilemez!");
            }
            else
            {
                int veri = Convert.ToInt32(txtDugumSil.Text);
                txtDugumSil.Clear();
                agacKok = SilDugum(agacKok, veri);
            }
        }


        private void btnBul_Click(object sender, EventArgs e)
        {
            agacDugumİkili dugumDuzeyBul = agacKok;
            int girilenDugumDuzeyi = Convert.ToInt32(txtDugumDuzeyi.Text);
            int arananDuzey = 0;
            // aranan dugum duzeyini bulma kok dugum 0 a atayarak her alt dugumde düzey artacak şekilde
            while (true)
            {
                if (dugumDuzeyBul == null)
                {
                    //cevapları göstermek için MessageBox
                    MessageBox.Show("Aranan Düğüm Düzeyi Bulunamadı", "Düğüm Bulunamadı!");
                    return;
                }
                else if (dugumDuzeyBul.veriler == girilenDugumDuzeyi)
                {
                    MessageBox.Show(arananDuzey + " Düğüm Düzeyinde ", "Düğüm Bulundu!");
                    return;
                }
                else if (dugumDuzeyBul.veriler < girilenDugumDuzeyi)
                {
                    dugumDuzeyBul = dugumDuzeyBul.sag;
                    arananDuzey++;
                }
                else if (dugumDuzeyBul.veriler > girilenDugumDuzeyi)
                {
                    dugumDuzeyBul = dugumDuzeyBul.sol;
                    arananDuzey++;
                }
            }
        }

        private void txtVeriEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDugumSil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDugumDuzeyi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
