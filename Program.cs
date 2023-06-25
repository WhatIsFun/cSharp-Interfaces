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
            Console.WriteLine("IShape Example");
            IShape crc = new Circle(5);
            Console.WriteLine($"The area of the circle is: {crc.CalculateArea()}, and the perimeter is: {crc.CalculaterPerimter()}");
            Console.WriteLine("*** **  *  ** ***");

            IShape rec = new Rectangle(4, 6);
            Console.WriteLine($"The area of the rectangle is: {rec.CalculateArea()}, and the perimeter is: {rec.CalculaterPerimter()}");

            /* Task 1: IVehicle 
             * Create an interface IVehicle with the following methods:

                void Start()
                void Accelerate(int speed)
                void Brake()
                Create two classes Car and Motorcycle that implement the IVehicle interface. 
                Implement the methods according to the behavior of each vehicle type.
             */
            Console.WriteLine("___________________________");
            Console.WriteLine("Task 1: IVehicle");
            IVehicle car = new Car();
            IVehicle motorcycle = new Motorcycle();
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
            Console.WriteLine("___________________________");
            Console.WriteLine("Task 2: IBankAccount ");
            IBankAccount SA = new SavingsAccount(300);
            Console.WriteLine("~~ ~ Saving Account ~ ~~");
            SA.GetBalance();
            SA.Deposit(30);
            SA.Withdraw(50);

            IBankAccount CA = new CheckingAccount(200);
            Console.WriteLine("~~ ~ Checking Account ~ ~~");

            CA.GetBalance();
            CA.Deposit(50);
            CA.Withdraw(50);

            Console.WriteLine("___________________________");
            //Task 3
            Console.WriteLine("Task 3: IPlayable");
            IPlayable musicPlayer = new MusicPlayer();
            IPlayable videoPlayer = new VideoPlayer();
            Console.WriteLine("🎵🎵 Music Player 🎵🎵");
            musicPlayer.Play();
            musicPlayer.Pause();
            musicPlayer.Stop();
            Console.WriteLine("📽️📽️ Video Player 📽️📽️");
            videoPlayer.Play();
            videoPlayer.Pause();
            videoPlayer.Stop();

            Console.WriteLine("___________________________");
            //Task 4
            Console.WriteLine("Task 4: IAnimal");
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();
            dog.Eat();
            dog.Sleep();
            cat.Eat();
            cat.Sleep();

            //Task 5
            ILogger fileLogger = new FileLogger();
            ILogger databaseLogger = new DatabaseLogger();

            fileLogger.LogInfo("Information message.");
            fileLogger.LogError("Error");

            databaseLogger.LogInfo("Information message.");
            databaseLogger.LogError("Error");
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
    internal class SavingsAccount : IBankAccount // Saving Account Class
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
    }
        internal class CheckingAccount : IBankAccount  // Checking Account class 
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
    /* Task 3: Create an interface IPlayable with the following methods:
        void Play()
        void Pause()
        void Stop()
        Create two classes MusicPlayer and VideoPlayer that implement the IPlayable interface.
        Implement the methods to control the playback of music and videos.
     */

    internal class MusicPlayer : IPlayable
    {
        public void Pause() 
        {
            Console.WriteLine("The music has paused");
        }

        public void Play()
        {
            Console.WriteLine("The music has played");
        }

        public void Stop()
        {
            Console.WriteLine("The music has stopped");
        }
    }


    internal class VideoPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("The video has paused");
        }

        public void Play()
        {
            Console.WriteLine("The video has played");
        }

        public void Stop()
        {
            Console.WriteLine("The video has stopped");
        }
    }

    // Task 4:
    /*Create an interface IAnimal with the following methods:
    void Eat()
    void Sleep()
    Create two classes Dog and Cat that implement the IAnimal interface. 
    Implement the methods according to the behavior of each animal.*/

    internal class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Cat food");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    internal class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog food");
        }

        public void Sleep()
        {
            Console.WriteLine("Shhh");
        }
    }

    internal class FileLogger : ILogger
    {
        public void LogError(string errorMessage)
        {
            Console.WriteLine("FileLogger Error: " + errorMessage);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("FileLogger: " + message);
        }
    }
    internal class DatabaseLogger : ILogger
    {
        public void LogError(string errorMessage)
        {
            Console.WriteLine("DatabaseLogger Error: " + errorMessage);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("DatabaseLogger: " + message);

        }
    }


}