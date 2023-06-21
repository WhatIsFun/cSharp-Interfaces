using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace cSharp_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IShape Example
            Circle crc = new Circle(5);
            Console.WriteLine($"The area of the circle is: {crc.CalculateArea()}, and the perimeter is: {crc.CalculaterPerimter()}");
            Console.WriteLine("_______________________________________________");
             
            Rectangle rec = new Rectangle(4, 6);
            Console.WriteLine($"The area of the rectangle is: {rec.CalculateArea()}, and the perimeter is: {rec.CalculaterPerimter()}");

            /* Task 1: IVehicle 
             * Create an interface IVehicle with the following methods:

                void Start()
                void Accelerate(int speed)
                void Brake()
                Create two classes Car and Motorcycle that implement the IVehicle interface. 
                Implement the methods according to the behavior of each vehicle type.
             */
            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();
            car.Start();
            car.Accelerate(120);
            car.Brake();
            
            motorcycle.Start();
            motorcycle.Accelerate(60);
            motorcycle.Brake();

        }
    }

    public class Circle : IShape   // Circle class (Child class)
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

        public Rectangle(double l, double w) // Rectangle class (Child class)
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
    public class Car : IVehicle // Car class (Child class)
    {
        private int currentSpeed;
         
        public void Accelerate(int speed)
        {
            currentSpeed = speed;
            Console.WriteLine($"The car is accelerating {currentSpeed} km/h");
        }

        public void Brake()
        {
            Console.WriteLine("The car has stopped.");
        }

        public void Start()
        {
            Console.WriteLine("The car has started .");
        }
    }

    public class Motorcycle : IVehicle  // Motorcycle class (Child class)
    {
        private int currentSpeed;
        public void Accelerate(int speed)
        {
            currentSpeed = speed;
            Console.WriteLine($"The car is accelerating {currentSpeed} km/h");
        }

        public void Brake()
        {
            Console.WriteLine("The car has stopped.");
        }

        public void Start()
        {
            Console.WriteLine("The car has started .");
        }
    }

}