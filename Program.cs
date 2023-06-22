using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static cSharp_interface.SavingsAccount;

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

            /* Task 2
            Create an interface called IBankAccount that has methods called GetBalance(), Deposit(), and Withdraw(). 
            Create two classes, SavingsAccount and CheckingAccount, that implement the IBankAccount interface. 
            The SavingsAccount class should override the Deposit() and Withdraw() methods to add and subtract 
            money from the savings account balance. The CheckingAccount class should override the Deposit() and
            Withdraw() methods to add and subtract money from the checking account balance.*/

            SavingsAccount SA = new SavingsAccount(300);
            SA.GetBalance();
            SA.Deposit(30);
            SA.Withdraw(50);

            CheckingAccount CA = new CheckingAccount(200);
            CA.GetBalance();
            CA.Deposit(50);
            CA.Withdraw(50);


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
            return 2 * (l * w);
        }
    }
    // Task 1
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
            Console.WriteLine($"The motorcycle is accelerating {currentSpeed} km/h");
        }

        public void Brake()
        {
            Console.WriteLine("The motorcycle has stopped.");
        }

        public void Start()
        {
            Console.WriteLine("The motorcycle has started .");
        }
    }

    //Task 2
    internal class SavingsAccount : IBankAccount
    {
        private double balance;

        public SavingsAccount(double balance)
        {
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                // Add the amount to the balance
                balance += amount;
                // Print a confirmation message
                Console.WriteLine($"Deposited {amount} to saving account. New balance in the saving account is {balance}.");
            }
            else
            {
                // Print an error message
                Console.WriteLine("Invalid amount. Deposit failed.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                // Subtract the amount from the balance
                balance -= amount;
                // Print a confirmation message
                Console.WriteLine($"Withdrew {amount} successfully. Now balance is {balance}.");
            }
            else
            {
                // Print an error message
                Console.WriteLine("Invalid amount. Withdrawal failed.");
            }
        }
        internal class CheckingAccount : IBankAccount
        {
            private double balance;
            public CheckingAccount(double balance)
            {
                this.balance = balance;
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    // Add the amount to the balance
                    balance += amount;
                    // Print a confirmation message
                    Console.WriteLine($"Deposited {amount} to checking account. Balance is {balance}.");
                }
                else
                {
                    // Print an error message
                    Console.WriteLine("Invalid amount. Deposit failed.");
                }
            }

            public double GetBalance()
            {
                return balance;
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    // Subtract the amount from the balance
                    balance -= amount;
                    // Print a confirmation message
                    Console.WriteLine($"Withdrew {amount} successfully. Balance is {balance}.");
                }
                else
                {
                    // Print an error message
                    Console.WriteLine("Invalid amount. Withdrawal failed.");
                }
            }
        }

    }
}