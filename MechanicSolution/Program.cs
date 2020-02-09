using MechanicSolution.Interfaces;
using MechanicSolution.Models;
using System;
using System.Collections;


namespace MechanicSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(DateTime.Now, "Panda", "Fiat");
            Bike bike = new Bike(DateTime.Now.AddDays(3), "GS600", "Honda");

            ArrayList ItemArray = new ArrayList();
            ItemArray.Add(car);
            ItemArray.Add(bike);

            foreach(IItem item in ItemArray)
            {
                Console.WriteLine(item);
            }

            

            

        }
    }
}
