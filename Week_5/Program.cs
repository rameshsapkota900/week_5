using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5.Task1;
using Week_5.Task2;
using Week_5.Task3;
using Week_5.Task4;
using Week_5.Task5;

namespace Week_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Task 1: Encapsulation -----");
            BankAccount account = new BankAccount("ACC12345", 1000);
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            account.Deposit(500);
            account.Withdraw(200);
            Console.WriteLine($"Remaining Balance: {account.Balance}");
            Console.WriteLine();





            Console.WriteLine("----- Task 2: Inheritance -----");
            Car myCar = new Car { Brand = "Toyota", Speed = 120, Seats = 5 };
            Motorcycle myBike = new Motorcycle { Brand = "Honda", Speed = 80, HasSidecar = false };

            Console.WriteLine("Car Info:");
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine("\nMotorcycle Info:");
            myBike.Start();
            myBike.DisplayInfo();
            myBike.Stop();
            Console.WriteLine();





            Console.WriteLine("----- Task 3: Polymorphism (Overloading) -----");
            Printer printer = new Printer();
            printer.Print("Hello World");
            printer.Print(100);
            printer.Print("Ramesh", 3);
            Console.WriteLine();

            Console.WriteLine("----- Task 3: Polymorphism (Overriding) -----");
            NepaliTeacher nepaliTeacher = new NepaliTeacher { Name = "Ram" };
            EnglishTeacher englishTeacher = new EnglishTeacher { Name = "John" };

            Console.WriteLine($"{nepaliTeacher.Name}:");
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();

            Console.WriteLine($"\n{englishTeacher.Name}:");
            englishTeacher.Teaching();
            englishTeacher.SalaryInfo();
            Console.WriteLine();






            Console.WriteLine("----- Task 4: Abstraction -----");
            AbsCar absCar = new AbsCar();
            AbsBike absBike = new AbsBike();

            Console.WriteLine("Abstract Car:");
            absCar.Display();
            absCar.StartEngine();
            absCar.StopEngine();

            Console.WriteLine("\nAbstract Bike:");
            absBike.Display();
            absBike.StartEngine();
            absBike.StopEngine();
            Console.WriteLine();







            Console.WriteLine("--- Task 5: OOP (Comprehensive) ---");
            ElectronicsStore store = new ElectronicsStore();
            Laptop laptop = new Laptop("Dell", 1200);
            Smartphone smartphone = new Smartphone("Samsung", 800);

            store.AddDevice(laptop);
            store.AddDevice(smartphone);

            Console.WriteLine("\nStore Inventory:");
            store.ShowAllDeviceDetails();

            Console.ReadLine(); 
        }
    }
}
