namespace Hafta7{

    public class Hayvan{
        public string Ad { get; set; }
        public int Yas { get; set; }
        
        public Hayvan(string ad, int yas){
            Ad = ad;
            Yas = yas;
        }

        public virtual void SesCikar(){
            System.Console.WriteLine("Hayvan sesi");
        }
        public void BilgiYaz(){
            System.Console.WriteLine("Ad: " + Ad + " Yas: " + Yas);
        }

    }

    public class Kedi : Hayvan{
        public Kedi(string ad, int yas) : base(ad, yas){
        }

        public override void SesCikar(){
            System.Console.WriteLine("Miyav");
        }
    }





    public class Person{
        protected string name, surname;
        public void setName(string name, string surname){
            this.name = name;
            this.surname = surname;
        }
    }



    class Ogrenci : Person{
        public Person Baba;
        public Person Anne;
        public int No { get; set; }
        public string Bolum { get; set; }
        public void NameCharSize(){
            System.Console.WriteLine("Name char size: " + name.Length);
        }
    }



    class Kisi{
        readonly string Soyad = "Ates";
        string isim;


        public Kisi(string isim){
            this.isim = isim;
        } 

        public void BilgileriYazdir()
        {

            Console.WriteLine($"{isim} {Soyad}");
        }
    }

    class Insan{
        public string name, surname;

        public void ShowSurname(){
            System.Console.WriteLine(name);
            System.Console.WriteLine(surname);
        }

    }



    class MathClass{
        public static int StatikFaktoriyel(int sayi){
            int  sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        public int NesneFaktoriyel(int sayi){
            int  sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        public static void staticFaktoriyelGoster(int sayi){
            System.Console.WriteLine(sayi);
        }
    }


    public class Variable
    {
        public static int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine(i);
        }
    }


    public class Toplama{
        private static int _statikDegisken = 0;

        private int _normalDegisken = 0;
        public static void StatikDegerArtir(int miktar)
        {
            _statikDegisken += miktar;
        }


        public static int StatikDegeriAl()
        {
            return _statikDegisken;
        }


        public void NormalDegerArtir(int miktar)
        {
            _normalDegisken += miktar;
        }

        public int NormalDegeriAl()
        {
            return _normalDegisken;
        }
    }


    

    class Program{
        static void Main(){
            // Hayvan h = new Hayvan("Hayvan", 5);
            // Kedi k = new Kedi("Kedi", 3);

            // h.SesCikar();
            // k.SesCikar();
            // k.BilgiYaz();
        
            // Person p = new Person();
            // p.setName("Ali", "Veli");
            // p.getName();

            // Person baba = new Person();
            // Person anne = new Person();
            // baba.setName("Ahmer", "ali");
            // anne.setName("a", "b");

            // Ogrenci ogrenci = new Ogrenci();
            // ogrenci.setName("Ali", "Veli");
            // ogrenci.NameCharSize();
            // ogrenci.Baba = baba;
            // ogrenci.Anne = anne;

            // Kisi bebek = new Kisi("ahmet");
            
            // bebek.BilgileriYazdir();

            // Insan insan = new Insan{name = "Ali", surname ="Veli"};
            // insan.ShowSurname();

            // MathClass math = new MathClass();

            // int a = MathClass.StatikFaktoriyel(5);
            // Console.WriteLine(a);

            // Variable var1 = new Variable();
            // var1.test();
            
            Toplama.StatikDegerArtir(5);
            Console.WriteLine(Toplama.StatikDegeriAl());
            Toplama.StatikDegerArtir(10);
            Console.WriteLine(Toplama.StatikDegeriAl());

            Toplama obj1 = new Toplama();
            obj1.NormalDegerArtir(3);
            Console.WriteLine(obj1.NormalDegeriAl());
            Console.WriteLine(obj1.StatikDegeriAl());



        }
    }
}