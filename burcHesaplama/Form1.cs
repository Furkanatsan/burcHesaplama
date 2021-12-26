using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burcHesaplama
{
    public partial class Form1 : Form
    {
        DateTime dogumTarihi;
        public Form1()
        {
            InitializeComponent();
            Hesapla();
        }

        private void Hesapla()
        {
            dogumTarihi = dtpDogumTarihi.Value;
            lblYasiniz.Text = "Yaşınız:" + yasHesapla(dogumTarihi.Year);
            lblYasadiginizGun.Text = "Yaşadığınız Gün:" + gunHesapla(dogumTarihi);
            lblBurc.Text = "Burcunuz:" + burcHesaplama(dogumTarihi.Month, dogumTarihi.Day);
        }

        private string burcHesaplama(int month, int day)
        {
            string burc = "";
            if ((month == 1 && day >= 21) || (month==2&&day<=19))
            {
                burc = "Kova";
            }
            else if ((month == 2&& day >= 20) || (month == 3 && day <= 20))
            {
                burc = "Balık";
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
            {
                burc = "Koç";
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
            {
                burc = "Boğa";
            }
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
            {
                burc = "İkizler";
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 23))
            {
                burc = "Yengeç";
            }
            else if ((month == 7 && day >= 24) || (month == 8 && day <= 23))
            {
                burc = "Aslan";
            }
            else if ((month == 8 && day >= 24) || (month == 9 && day <= 23))
            {
                burc = "Başak";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
            {
                burc = "Terazi";
            }
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
            {
                burc = "Akrep";
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
            {
                burc = "Yay";
            }
            else
            {
                burc = "oğlak";
            }
            return burc;
        }

        private string gunHesapla(DateTime dogumTarihi)
        {
            TimeSpan gecenSure = DateTime.Now - dogumTarihi;
            int toplamGun = (int)gecenSure.TotalDays;
            return toplamGun.ToString();
        }

        private string yasHesapla(int year)
        {
            return (DateTime.Now.Year - year).ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
    }
}
