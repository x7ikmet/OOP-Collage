
namespace OOP.Hafta2
{

    public ref struct Point{
        public int X {get; set;}
        public int Y {get; set;}
        public Point(int x, int y){
            X= x;
            Y= y;
        }

        public double DistanceTo(Point other){
            int deltaX = X-other.X;
            int deltaY = Y-other.Y;
            return Math.Sqrt(deltaY*deltaX + deltaY*deltaY);

        }
    }
}