/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**		  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: AYSUN ÇAĞ YILMAZKULAŞ
**				ÖĞRENCİ NUMARASI.......: G191210373
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/
using System;
using System.Windows.Forms;

namespace NDP_Odev3_Calisma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LedTv Sony = new LedTv(Convert.ToInt32(numericUpDownTv.Value), Program.ledTvStokAdediRastgele);
            Buzdolabi Arcelik = new Buzdolabi(Convert.ToInt32(numericUpDownTv.Value), Program.buzdolabiStokAdediRastgele);
            Laptop Vaio = new Laptop(Convert.ToInt32(numericUpDownLaptop.Value), Program.laptopStokAdediRastgele);
            CepTel Xiaomi = new CepTel(Convert.ToInt32(numericUpDownTelefon.Value), Program.cepTelStokAdediRastgele);

            //----Asagidaki degerler random olarak Program.cs dosyasinda olusturuldu.---//
            lblTvStokAdedi.Text = Sony.stokAdedi.ToString();
            lblBuzdolabiStokAdedi.Text = Arcelik.stokAdedi.ToString();            
            lblLaptopStokAdedi.Text = Vaio.stokAdedi.ToString();
            lblCeptelStokAdedi.Text = Xiaomi.stokAdedi.ToString();
        }

        public class Urun                   //------Urun sinifi olusturuldu.------//
        {
            public string ad;
            public string marka;
            public string model;
            public string ozellik;
            public int hamFiyat;
            public int secilenAdet;
            public int stokAdedi;
        }
       
        public class LedTv : Urun           //------Urun sinifindan LedTv sinifi turetildi.------//
        {
            public int ekranBoyutu = 55;    //------Ozellikler tooltip olarak kullanildi.------//
            public string ekranCozunurlugu = "4K";
            public LedTv(int secilenAdetClick, int stokAdediRastgeleSayi)   //---Kurucu fonksiyon olusturuldu.---//
            {
                ad = "Televizyon";
                marka = "Sony";
                model = "2020";
                ozellik = "HD Kalite";
                hamFiyat = 4000;
                secilenAdet = secilenAdetClick;
                stokAdedi = stokAdediRastgeleSayi;
            }
            public double kdvUygula(int ledtvHamfiyat, int ledtvSecilenAdet)    //---Bu metod ile kdv'li fiyat hesaplandi.---//
            {
                double ledtvKdvliFiyat = ledtvHamfiyat * 1.18 * ledtvSecilenAdet;
                return Math.Round(ledtvKdvliFiyat, 1);
            }
        }

        public class Buzdolabi : Urun       //------Urun sinifindan Buzdolabi sinifi turetildi.------//
        {
            public int icHacim = 1400;      //------Ozellikler tooltip olarak kullanildi.------//
            public string enerjiSinifi = "A++";

            public Buzdolabi(int secilenAdetClick, int stokAdediRastgeleSayi)   //---Kurucu fonksiyon olusturuldu.---//
            {
                ad = "Buzdolabi";
                marka = "Arcelik";
                model = "2019";
                ozellik = "cift kapi";
                hamFiyat = 3500;
                secilenAdet = secilenAdetClick;
                stokAdedi = stokAdediRastgeleSayi;
            }
            public double kdvUygula(int buzdolabiHamFiyat, int buzdolabiSecilenAdet)    //---Bu metod ile kdv'li fiyat hesaplandi.---//
            {
                double buzdolabiKdvliFiyat = buzdolabiHamFiyat * 1.05 * buzdolabiSecilenAdet;
                return Math.Round(buzdolabiKdvliFiyat, 1);
            }
        }

        public class Laptop : Urun      //------Urun sinifindan Laptop sinifi turetildi.------//
        {
            public string ekranBoyutu = "15inc";        //------Ozellikler tooltip olarak kullanildi.------//
            public int ekranCozunurlugu = 1080;
            public string dahiliHafiza = "1TB";
            public string ramKapasitesi = "16GB";

            public Laptop(int secilenAdetClick, int stokAdediRastgeleSayi)      //---Kurucu fonksiyon olusturuldu.---//
            {
                ad = "Dizustu Bilgisayar";
                marka = "Vaio";
                model = "2018";
                ozellik = "5G WiFi Gucu";
                hamFiyat = 6000;
                secilenAdet = secilenAdetClick;
                stokAdedi = stokAdediRastgeleSayi;
            }
            public double kdvUygula(int laptopHamfiyat, int laptopSecilenadet)      //---Bu metod ile kdv'li fiyat hesaplandi.---//
            {
                double laptopKdvliFiyat = laptopHamfiyat * 1.15 * laptopSecilenadet;
                return Math.Round(laptopKdvliFiyat, 1);
            }
        }

        public class CepTel : Urun              //------Urun sinifindan Ceptel sinifi turetildi.------//
        {
            public string dahiliHafiza = "32GB";    //------Ozellikler tooltip olarak kullanildi.------//
            public string ramKapasitesi = "16GB";
            public string pilGucu = "4000mh";

            public CepTel(int secilenAdetClick, int stokAdediRastgeleSayi)  //---Kurucu fonksiyon olusturuldu.---//
            {
                ad = "Cep Telefonu";
                marka = "Xiaomi";
                model = "2018";
                ozellik = "Cift Hat Kullanimi";
                hamFiyat = 2500;
                secilenAdet = secilenAdetClick;
                stokAdedi = stokAdediRastgeleSayi;
            }
            public double kdvUygula(int ceptelHamfiyat, int ceptelSecilenadet)  //---Bu metod ile kdv'li fiyat hesaplandi.---//
            {
                double ceptelKdvliFiyat = ceptelHamfiyat * 1.2 * ceptelSecilenadet;
                return Math.Round(ceptelKdvliFiyat, 1);
            }
        }

        public class Sepet : Urun
        {
            public static double kdvliFiyatHesapla;
            public static double toplamFiyatHesapla;

            public static void SepeteUrunEkle(Urun urunler)     //---Bu metod ile Urun sinifindan turetilmis siniflarin kdvUygula metodu cagirildi.---//
            {                                                   
                urunler.GetType().GetMethod("kdvUygula");
            }
        }

        private void sepeteEkleButonu_Click(object sender, EventArgs e)
        { 
                //---Siniflardan objeler olusturuldu.---//
                //---NumerikUpDown degerleri secilen adet olarak belirtildi.---//
                //---StokAdediRastgele ifadeleri Program.cs'de Random fonksiyonu ile tanimlandi.---//

                LedTv Sony = new LedTv(Convert.ToInt32(numericUpDownTv.Value), Program.ledTvStokAdediRastgele);
                Sepet.SepeteUrunEkle(Sony);
            if (Sony.secilenAdet > Sony.stokAdedi)      //---Bu kosul ile stokadetinden fazla urun secilmesi engellendi.---//
                Sony.secilenAdet = Sony.stokAdedi;

                Buzdolabi Arcelik = new Buzdolabi(Convert.ToInt32(numericUpDownBuzdolabi.Value), Program.buzdolabiStokAdediRastgele);
                Sepet.SepeteUrunEkle(Arcelik);
            if (Arcelik.secilenAdet > Arcelik.stokAdedi)    //---Bu kosul ile stokadetinden fazla urun secilmesi engellendi.---//
                Arcelik.secilenAdet = Arcelik.stokAdedi;

                Laptop Vaio = new Laptop(Convert.ToInt32(numericUpDownLaptop.Value), Program.laptopStokAdediRastgele);
                Sepet.SepeteUrunEkle(Vaio);
            if (Vaio.secilenAdet > Vaio.stokAdedi)       //---Bu kosul ile stokadetinden fazla urun secilmesi engellendi.---//
                Vaio.secilenAdet = Vaio.stokAdedi;

                CepTel Xiaomi = new CepTel(Convert.ToInt32(numericUpDownTelefon.Value), Program.cepTelStokAdediRastgele);
                Sepet.SepeteUrunEkle(Xiaomi);
            if (Xiaomi.secilenAdet > Xiaomi.stokAdedi)      //---Bu kosul ile stokadetinden fazla urun secilmesi engellendi.---//
                Xiaomi.secilenAdet = Xiaomi.stokAdedi;

            //------Sepete ekle butonuna tiklandiginda SEPET BOS DEGILSE oncelikle temizlenmesi asagidaki kodlarla saglandi.------//

            //---Stok adetleri tekrar textlere eklendi.---//
            lblTvStokAdedi.Text = Sony.stokAdedi.ToString();
            lblBuzdolabiStokAdedi.Text = Arcelik.stokAdedi.ToString();
            lblLaptopStokAdedi.Text = Vaio.stokAdedi.ToString();
            lblCeptelStokAdedi.Text = Xiaomi.stokAdedi.ToString();

            //---KdvliToplamFiyat sifirlandi.---//
            labelKdvliToplamFiyat.Text = "0".ToString();

            //---NumerikUpDown degerleri sifirlandi.---//
            numericUpDownTv.Value = 0;
            numericUpDownBuzdolabi.Value = 0;
            numericUpDownLaptop.Value = 0;
            numericUpDownTelefon.Value = 0;

            //---ListBoxlar temizlendi.---//
            listBoxAdet.Items.Clear();
            listBoxUrun.Items.Clear();
            listBoxKdvlifiyat.Items.Clear();

            //------Sepete ekle butonuna tiklandiginda  SEPET BOS DEGILSE oncelikle temizlenmesi yukaridaki kodlarla saglandi.------//

            if (Sony.secilenAdet > 0)       //---Tv secildiyse asagidaki durumlar olusturuldu.---//
                {
                    listBoxAdet.Items.Add(Sony.secilenAdet);
                    listBoxUrun.Items.Add("Led TV");
                    listBoxKdvlifiyat.Items.Add(Sony.kdvUygula(Sony.hamFiyat, Sony.secilenAdet));
                    lblTvStokAdedi.Text = (Sony.stokAdedi - Sony.secilenAdet).ToString();
                }

                if (Arcelik.secilenAdet > 0)    //---Buzdolabi secildiyse asagidaki durumlar olusturuldu.---//
                {
                    listBoxAdet.Items.Add(Arcelik.secilenAdet);
                    listBoxUrun.Items.Add("Buzdolabi");
                    listBoxKdvlifiyat.Items.Add(Arcelik.kdvUygula(Arcelik.hamFiyat, Arcelik.secilenAdet));
                    lblBuzdolabiStokAdedi.Text = (Arcelik.stokAdedi - Arcelik.secilenAdet).ToString();
                }

                if (Vaio.secilenAdet > 0)       //---Bilgisayar secildiyse asagidaki durumlar olusturuldu.---//
                {
                    listBoxAdet.Items.Add(Vaio.secilenAdet);
                    listBoxUrun.Items.Add("Laptop");
                    listBoxKdvlifiyat.Items.Add(Vaio.kdvUygula(Vaio.hamFiyat, Vaio.secilenAdet));
                    lblLaptopStokAdedi.Text = (Vaio.stokAdedi - Vaio.secilenAdet).ToString();
                }

                if (Xiaomi.secilenAdet > 0)     //---Telefon secildiyse asagidaki durumlar olusturuldu.---//
                {
                    listBoxAdet.Items.Add(Xiaomi.secilenAdet);
                    listBoxUrun.Items.Add("Cep Telefonu");
                    listBoxKdvlifiyat.Items.Add(Xiaomi.kdvUygula(Xiaomi.hamFiyat, Xiaomi.secilenAdet));
                    lblCeptelStokAdedi.Text = (Xiaomi.stokAdedi - Xiaomi.secilenAdet).ToString();
                }

                //------Kdv'li fiyatlar toplanarak KdvliToplamFiyat labelina yazdirildi.------//
                labelKdvliToplamFiyat.Text = (Sony.kdvUygula(Sony.hamFiyat, Sony.secilenAdet) + Arcelik.kdvUygula(Arcelik.hamFiyat, Arcelik.secilenAdet) + Vaio.kdvUygula(Vaio.hamFiyat, Vaio.secilenAdet) + Xiaomi.kdvUygula(Xiaomi.hamFiyat, Xiaomi.secilenAdet) + " TL").ToString();
            }

        private void sepetiTemizleButonu_Click(object sender, EventArgs e)
        {
            //---Siniflardan objeler olusturuldu.---//
            LedTv Sony = new LedTv(Convert.ToInt32(numericUpDownTv.Value), Program.ledTvStokAdediRastgele);
            Buzdolabi Arcelik = new Buzdolabi(Convert.ToInt32(numericUpDownBuzdolabi.Value), Program.buzdolabiStokAdediRastgele);
            Laptop Vaio = new Laptop(Convert.ToInt32(numericUpDownLaptop.Value), Program.laptopStokAdediRastgele);
            CepTel Xiaomi = new CepTel(Convert.ToInt32(numericUpDownTelefon.Value), Program.cepTelStokAdediRastgele);

            //---Stok adetleri tekrar textlere eklendi.---//
            lblTvStokAdedi.Text = Sony.stokAdedi.ToString();
            lblBuzdolabiStokAdedi.Text = Arcelik.stokAdedi.ToString();
            lblLaptopStokAdedi.Text = Vaio.stokAdedi.ToString();
            lblCeptelStokAdedi.Text = Xiaomi.stokAdedi.ToString();

            //---KdvliToplamFiyat sifirlandi.---//
            labelKdvliToplamFiyat.Text = "0".ToString();

            //---NumerikUpDown degerleri sifirlandi.---//
            numericUpDownTv.Value = 0;
            numericUpDownBuzdolabi.Value = 0;
            numericUpDownLaptop.Value = 0;
            numericUpDownTelefon.Value = 0;
            
            //---ListBoxlar temizlendi.---//
            listBoxAdet.Items.Clear();
            listBoxUrun.Items.Clear();
            listBoxKdvlifiyat.Items.Clear();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            LedTv Sony = new LedTv(Convert.ToInt32(numericUpDownTv.Value), Program.ledTvStokAdediRastgele);

            ToolTip toolTip1 = new ToolTip();       //---Televizyon resmi uzerine mouse getirildiginde aciklama belirtecektir.---//
            toolTip1.Active = true;
            toolTip1.IsBalloon = true;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.pictureBox1, "Ekran Cozunurlugu=" + Sony.ekranCozunurlugu + " Ekran Boyutu=" + Sony.ekranBoyutu);
        }

        private void pictureBox2_MouseMove_1(object sender, MouseEventArgs e)
        {
            Buzdolabi Arcelik = new Buzdolabi(Convert.ToInt32(numericUpDownBuzdolabi.Value), Program.buzdolabiStokAdediRastgele);

            ToolTip toolTip2 = new ToolTip();       //---Buzdolabi resmi uzerine mouse getirildiginde aciklama belirtecektir.---//
            toolTip2.Active = true;
            toolTip2.IsBalloon = true;
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(this.pictureBox2, "Ic Hacim=" + Arcelik.icHacim + " Enerji Sinifi=" + Arcelik.enerjiSinifi);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Laptop Vaio = new Laptop(Convert.ToInt32(numericUpDownLaptop.Value), Program.laptopStokAdediRastgele);

            ToolTip toolTip3 = new ToolTip();       //---Laptop resmi uzerine mouse getirildiginde aciklama belirtecektir.---//
            toolTip3.Active = true;
            toolTip3.IsBalloon = true;
            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(this.pictureBox3, "Ekran Cozunurlugu=" + Vaio.ekranCozunurlugu + " Ekran Boyutu=" + Vaio.ekranBoyutu + " Dahili Hafiza=" + Vaio.dahiliHafiza + " Ram Kapasitesi=" + Vaio.ramKapasitesi);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            CepTel Xiaomi = new CepTel(Convert.ToInt32(numericUpDownTelefon.Value), Program.cepTelStokAdediRastgele);

            ToolTip toolTip4 = new ToolTip();       //---Telefon resmi uzerine mouse getirildiginde aciklama belirtecektir.---//
            toolTip4.Active = true;
            toolTip4.IsBalloon = true;
            toolTip4.ShowAlways = true;
            toolTip4.SetToolTip(this.pictureBox4, "Dahili Hafiza=" + Xiaomi.dahiliHafiza + " Pil Gucu=" + Xiaomi.pilGucu + " Ram Kapasitesi=" + Xiaomi.ramKapasitesi);
        }
    }
}
