using System;

namespace Week_5.Task4
{
    public abstract class AbstractVehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();

        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }

}
