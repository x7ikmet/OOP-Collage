
using System.Runtime.CompilerServices;

class Program{
    static void Main(string[] args){
        
        Console.WriteLine("Hoşgeldiniz! Lütfen yaşınızı ve adınızı girin: ");
        
        try{
            int yas = Convert.ToInt32(Console.ReadLine());
            string? ad = Console.ReadLine();
            if (ad == null || ad == "" )
            {
                Console.WriteLine("Hatalı giriş! İsim boş olamaz!");
                Environment.Exit(1);
            }
            CheckAgeAndName(yas, ad);
        }
        catch(FormatException){
            Console.WriteLine("Hatalı giriş! Yaş alanı sayı olmalıdır.");
            Environment.Exit(1);
        }


    }
    static void CheckAgeAndName(int yas, string ad){
        
        switch(yas){
            case < 0:
                Console.WriteLine("Hatalı giriş! Yaşınız negatif olamaz.");
                break;  

            case <= 12 when ad.StartsWith("A"):
                Console.WriteLine($"Merhaba {ad}, genç bir çocuksunuz ve adınız A ile başlıyor.");
                break;
            default:
                Console.WriteLine($"Yaşınız: {yas}, Adınız: {ad}");
                break;
        }
    }
}

