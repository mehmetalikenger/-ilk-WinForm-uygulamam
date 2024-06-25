namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {     
            InitializeComponent();
        }

        void EkraniSifirla()
        {
            maskedBaslangic.Text = "1";
            maskedBitis.Text = "10";
        }

        bool InputDogrula()
        {
            try
            {
                Convert.ToInt32(maskedBaslangic.Text);
                Convert.ToInt32(maskedBitis.Text);

                return true;
            
            }
            catch (Exception)
            {
                return false;
            }
        }

        int TekMi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        bool AsalMi(int sayi)
        {
            int i;

            for (i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            
            return true;
        }

        bool MukemmelMi(int sayi)
        {
            int toplam = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }

            if (toplam == sayi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int Topla(List<int> sayiListesi)
        {
            int toplam = 0;
            for (int i = 0; i < sayiListesi.Count; i++)
            {
                toplam += sayiListesi[i];
            }
            return toplam;
        }

        void ToplamYazdir(int toplam, string sayiTipi)
        {
            if(sayiTipi == "tek")
            {
                maskedTekToplam.Text = toplam.ToString();
            }

            else if (sayiTipi == "cift")
            {              
                maskedCiftToplam.Text = toplam.ToString();          
            }

            else if (sayiTipi == "asal")
            {
                maskedAsalToplam.Text = toplam.ToString();
            }

            else
            {
                maskedMukemmelToplam.Text = toplam.ToString();
            }              
        }

        long Carp(List<int> sayiListesi)
        {
            if (sayiListesi.Count != 0)
            {
                long carpim = 1;

                for (int i = 0; i < sayiListesi.Count; i++)
                {
                    carpim *= sayiListesi[i];
                }
                return carpim;
            }

            return 0;
        }

        void CarpimYazdir(long carpim, string sayiTipi)
        {
            if (sayiTipi == "tek")
            {
                maskedTekCarpim.Text = carpim.ToString();
            }

            else if (sayiTipi == "cift")
            {
                maskedCiftCarpim.Text = carpim.ToString();
            }

            else if (sayiTipi == "asal")
            {
                maskedAsalCarpim.Text = carpim.ToString();
            }

            else
            {
                maskedMukemmelCarpim.Text = carpim.ToString();
            }
        }

        void sayiListesiYazdir(List<int> sayiListesi, string sayiTipi)
        {
            ListViewItem item = new ListViewItem(sayiListesi.ToString());
            
            if (sayiTipi == "tek")
            {

                listViewTekSayilar.Items.Clear();

                for (int i = 0; i < sayiListesi.Count; i++)
                {
                    listViewTekSayilar.Items.Add(sayiListesi[i].ToString());
                }     
            }

            else if (sayiTipi == "cift")
            {
                listViewCiftSayilar.Items.Clear();

                for (int i = 0; i < sayiListesi.Count; i++)
                {
                    listViewCiftSayilar.Items.Add(sayiListesi[i].ToString());
                }
            }

            else if (sayiTipi == "asal")
            {
                listViewAsalSayilar.Items.Clear();

                for (int i = 0; i < sayiListesi.Count; i++)
                {
                    listViewAsalSayilar.Items.Add(sayiListesi[i].ToString());
                }
            }

            else
            {
                listViewMukemmelSayilar.Items.Clear();

                for (int i = 0; i < sayiListesi.Count; i++)
                {
                    listViewMukemmelSayilar.Items.Add(sayiListesi[i].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int baslangicDegeri, bitisDegeri, toplam;
            long carpim;
            var tekSayilar = new List<int>();
            var ciftSayilar = new List<int>();
            var asalSayilar = new List<int>();
            var mukemmelSayilar = new List<int>();

            if (!InputDogrula())
            {

                MessageBox.Show("Geçerli bir deðer giriniz.");
                EkraniSifirla();
            }
            else
            {
                baslangicDegeri = Convert.ToInt32(maskedBaslangic.Text);
                bitisDegeri = Convert.ToInt32(maskedBitis.Text);


                for (int i = baslangicDegeri+1; i < bitisDegeri; i++)
                {
                    if (TekMi(i) == 1)
                    {
                        tekSayilar.Add(i);
                    }
                    else
                    {
                        ciftSayilar.Add(i);
                    }

                    if (AsalMi(i) == true)
                    {
                        asalSayilar.Add(i);
                    }

                    if (MukemmelMi(i) == true)
                    {
                        mukemmelSayilar.Add(i);
                    }
                }

                    toplam = Topla(tekSayilar);
                    ToplamYazdir(toplam, "tek");
                    carpim = Carp(tekSayilar);
                    CarpimYazdir(carpim, "tek");
                    sayiListesiYazdir(tekSayilar, "tek");



                    toplam = Topla(ciftSayilar);
                    ToplamYazdir(toplam, "cift");
                    carpim = Carp(ciftSayilar);
                    CarpimYazdir(carpim, "cift");
                    sayiListesiYazdir(ciftSayilar, "cift");



                    toplam = Topla(asalSayilar);
                    ToplamYazdir(toplam, "asal");
                    carpim = Carp(asalSayilar);
                    CarpimYazdir(carpim, "asal");
                    sayiListesiYazdir(asalSayilar, "asal");



                    toplam = Topla(mukemmelSayilar);
                    ToplamYazdir(toplam, "mukemmel");
                    carpim = Carp(mukemmelSayilar);
                    CarpimYazdir(carpim, "mukemmel");
                    sayiListesiYazdir(mukemmelSayilar, "mukemmel");           
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            notifyIcon1.BalloonTipTitle = "Programa hoþ geldiniz!";
            notifyIcon1.BalloonTipText = "Nesne Yönelimli Programlama Ödev 1";
            notifyIcon1.ShowBalloonTip(1000);
            
            EkraniSifirla();
        }

        private void maskedTekToplam_MaskInputRejected(object sender, MaskInputRejectedEventArgs e){}
        private void maskedTekCarpim_MaskInputRejected(object sender, MaskInputRejectedEventArgs e){}

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount)
            {
                tabControl1.SelectedIndex++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 0)
            {
                tabControl1.SelectedIndex--;
            }
        }
    }
}

