namespace OOP.Hafta1
{
    internal class Program
    {
        public void Main()
        {
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("Hi {0}, Your age: {1}, {0} you are welecome to my program", name, age);    
        }

        public void ReadOnly()
        {
            Console.Write("Dogum yilrinizi girini: ");
            
        }

        public void Type()
        {
            var isim = "Hikmet";
            Console.WriteLine(isim.GetType().ToString());
            byte a = 1;
            string b = 2.5 + "";
            Console.WriteLine(a+b);

        }
    }
}
