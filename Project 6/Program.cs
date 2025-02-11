namespace Bank{
    class BankAccount{
        private double Bakiye;
        private double _FaizOrani;
        public string AccountNumber { get; private set; }
        public string AccountHolderName { get; private set; }
        
        public BankAccount(string isim, string num, double bakiye = 0){
            if(bakiye<0){
                Console.WriteLine("Bakiye neg. olmaz!.");
                return;
            }
            
            AccountHolderName = isim;
            AccountNumber = num;
            Bakiye = bakiye;
        }

        public double getBakiye(){
            return Bakiye;
        }

        public void ParaYatirma(double value){
            if (value>=0){
                this.Bakiye += value;
                Console.WriteLine($"Hesap Bakiyesi: {this.Bakiye}");    
            }else{
                Console.WriteLine("Value neg. !");
            }
            
        }
        public void ParaCekme(double value){
            if (value<=0){
                Console.WriteLine("neg. yada 0 yasak islem!");
                return;
            }
            if (this.Bakiye>=value){
                this.Bakiye -= value;
                Console.WriteLine($"Islem gerceklestirdi!, Kalan bakiye: {this.Bakiye}");
            }else{
                Console.WriteLine("Yetersiz  Bakiye!.");
            }
        }

        public double FaizOrani{
            get {return _FaizOrani;}

            set{
                if(value>=0){
                    _FaizOrani = value;
                }else{
                    Console.WriteLine("neg. olmaz!");
                }
            }
        }

    }



    class Program{
        static void Main(){
            BankAccount heasp = new BankAccount("Hikmet K.","B12",28834);
            heasp.ParaYatirma(15);
            heasp.ParaCekme(-5);

            Console.WriteLine(heasp.FaizOrani);
            Console.WriteLine(heasp.getBakiye());

        }
    }
}