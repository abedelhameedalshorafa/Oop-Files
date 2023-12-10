using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTask6
{
    class Car
    {
        public string make;
        public int year;
        public string type;
        public decimal price;
        public string color;

        public Car(string make, int year, string type, decimal price, string color)
        {
            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.color = color;
        }

        public void start()
        {
            Console.WriteLine("Engine Started");
        }

        public void stop()
        {
            Console.WriteLine("Engine stopped");
        }

        public virtual string getCarDetails()
        {
            return $"{year} {make} {type} - Color: {color}, Price: {price:C}";
        }
    }

    class Camry : Car
    {
        public string model;
        public string palletNo;

        public Camry(string make, int year, string type, decimal price, string color, string model, string palletNo)
            : base(make, year, type, price, color)
        {
            this.model = model;
            this.palletNo = palletNo;
        }

        public override string getCarDetails()
        {
            return base.getCarDetails() + $", Model: {model}, Pallet No: {palletNo}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Camry("Toyota", 2022, "Sedan", 25000.50m, "Blue", "Camry", "123ABC");

            myCar.start();
            Console.WriteLine(myCar.getCarDetails());
            myCar.stop();
        }
    }
}
