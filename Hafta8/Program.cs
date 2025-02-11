using Hafta8;

namespace Hafta8{


    class Animal{
        public string name;


        public void Display(){
            Console.WriteLine(name);
        }
        public override string ToString(){
            return name;
        }
    }

    class Dog : Animal{
        public void getName(){
            Console.WriteLine(name);
        }
        

        
    }


    class CokGen{
        protected void AlanHesapla(int width, int Length){
            Console.WriteLine(width * Length);
        }
    }

    class Kare : CokGen{
        public int kenarUzunlugu;
        public void AlanHesapla(){
            
            
            base.AlanHesapla(kenarUzunlugu, kenarUzunlugu);
        }
    }

    class Dikdortgen : CokGen{
        public int genislik, yukseklik;

        void alanCevreHesapla(){
            int cevre = 2 * (genislik + yukseklik);
            Console.WriteLine("Cevre: " + cevre);
            AlanHesapla(genislik, yukseklik);
        }
    }


    public class Motor{
        public void MorotCalistir(){
            Console.WriteLine("Motor calisti");
        }

        public void MotorKapat(){
            Console.WriteLine("Motor kapandi");
        }


    }

    class Araba{
        Motor arabaninMotoru = new Motor();
        public void ArabayiCalistir(){
            arabaninMotoru.MorotCalistir();
            Console.WriteLine("Araba calisti");
        }

        public void ArabayiKapat(){
            arabaninMotoru.MotorKapat();
            Console.WriteLine("Araba durdu");
        }
    }


    class Anim{
        public virtual void yemekYeme(){
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("Yemek yedi");
        }
    }

    class Kedi : Anim{
        public override void yemekYeme(){
            Console.WriteLine(this.GetType().Name);
            base.yemekYeme();
        }
    }

    public abstract class Calisan{
        private string isim,soyisim,Unvan;
        private double maas;
        protected void SetBilgiler(string isim, string soyisim, string Unvan){
            this.isim = isim;
            this.soyisim = soyisim;
            this.Unvan = Unvan;
        }
        public double getMass(){
            return maas;
        }
        protected void setMaas(double maas){
            this.maas = maas;
        }
        public abstract void zamYap();
        public abstract void zamYap(double oran);

        public override string ToString(){
            string bilgiler = string.Format("Isim: {0}\nSoyisim: {1}\nUnvan: {2}\nMaas: {3}", isim, soyisim, Unvan, maas);
            return bilgiler ;
        }

    }

    class Memur: Calisan{
        public Memur(string isim, string soyisim, string Unvan, double maas){
            base.SetBilgiler(isim, soyisim, Unvan);
            base.setMaas(maas);
        }

        public override void zamYap()
        {
            base.setMaas(getMass() * 1.10);
        }

        public override void zamYap(double oran)
        {
            base.setMaas(getMass() * oran);
        }
    }


    class UstDuzeyYonetici: Calisan{
        public UstDuzeyYonetici(string isim, string soyisim, string Unvan, double maas){
            base.SetBilgiler(isim, soyisim, Unvan);
            base.setMaas(maas);
        }
        public override void zamYap()
        {
            setMaas(getMass() * 1.20);
        }

        public override void zamYap(double oran)
        {
            zamYap(getMass() * (oran+0.1));
        }
    }

    internal class Program{
        static void Main(){
            Kedi kedi = new Kedi();
            kedi.yemekYeme();

            // Memur memur = new Memur("Ali", "Veli", "Memur", 2000);
            // Console.WriteLine(memur.ToString());
            // Console.WriteLine("Zam yapiliyor");
            // memur.zamYap();
            // Console.WriteLine(memur.ToString());
            // Console.WriteLine("%15 Zam yapiliyor");
            // memur.zamYap(1.15);
            // Console.WriteLine(memur.ToString());


            // UstDuzeyYonetici yonetici = new UstDuzeyYonetici("Ahmet", "Mehmet", "Doc.Dr.", 5000.55);
            // Console.WriteLine(yonetici.ToString());
            // Console.WriteLine("Zam yapiliyor");
            // yonetici.zamYap();
            // Console.WriteLine(yonetici.ToString());
            // Console.WriteLine("%15 Zam yapiliyor");
            // yonetici.zamYap(1.15);
            // Console.WriteLine(yonetici.ToString());
        }
    }

}