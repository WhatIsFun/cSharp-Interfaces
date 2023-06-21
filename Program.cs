using System.Runtime.InteropServices;

namespace cSharp_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle crc = new Circle(5);
            Console.WriteLine($"The area of the circle is: {crc.CalculateArea()}, and the perimeter is: {crc.CalculaterPerimter()}");
            Console.WriteLine("_______________________________________________");

            Rectangle rec = new Rectangle(4, 6);
            Console.WriteLine($"The area of the rectangle is: {rec.CalculateArea()}, and the perimeter is: {rec.CalculaterPerimter()}");

        }
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        
        public double CalculaterPerimter()
        {
            return 2 * Math.PI * radius;

        }
    }
    public class Rectangle : IShape
    {
        private double l;
        private double w;

        public Rectangle(double l, double w)
        {
            this.l = l;
            this.w = w;
        }
        public double CalculateArea()
        {
            return l * w;
        }

        public double CalculaterPerimter()
        {
            return 2*(l*w);
        }
    }
}