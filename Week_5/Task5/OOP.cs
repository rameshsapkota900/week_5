using System;
using System.Collections.Generic;

namespace Week_5.Task5
{
    public abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        public abstract void ShowInfo();
    }


}
