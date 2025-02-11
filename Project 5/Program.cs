namespace Project{

    public delegate double MatematikselIslem(double n1, double n2);


    class HeaspMakinesi{
        public double topla(double n1, double n2){
            return n1+n2;
        }
        public double cikar(double n1, double n2){
            return n1-n2;
        }
        public double carp(double n1, double n2){
            return n1*n2;
        }
        public double bol(double n1, double n2){
            return n1/n2;
        }
    }

    class Program{
        static void Main(string[] args){
            HeaspMakinesi heaspMakinesi = new HeaspMakinesi();
            MatematikselIslem islem;
            Console.WriteLine("ilk sayiyi girin: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci sayiyi girin: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İşlem seçiniz: (1 = Toplama, 2 = Çıkarma, 3 = Çarpma, 4 = Bölme)");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch(secim){
                case 1:
                    islem = heaspMakinesi.topla;
                    break;
                case 2:
                    islem = heaspMakinesi.cikar;
                    break;
                case 3:
                    islem = heaspMakinesi.carp;
                    break;
                case 4:
                    islem = heaspMakinesi.bol;
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    return;
            }
            double sounc = islem(s1,s2);
            Console.WriteLine($"Sonuc: {sounc}");

        }
    }
}