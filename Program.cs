namespace OOP{

    // using Hafta1;
    using Hafta2;

    internal class Program{
        public static void Main()
        {
            
            Point point1 = new Point(3,4);
            Point point2 = new Point(6,8);
            double dis = point1.DistanceTo(point2);
            Console.WriteLine($"value: {dis}");
        }
    }

}