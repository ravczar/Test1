﻿using MechanicSolution.Interfaces;
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

            // Wyświetl za pomocą metody ToString()
            foreach(IItem item in ItemArray)
            {
                Console.WriteLine(item);
            }

            // Wyświetl za pomocą metody ExpressYourself()
            foreach (IItem item in ItemArray)
            {
                try
                {
                    item.ExpressYourself();
                }
                catch(NotImplementedException e)
                {
                    Console.WriteLine(e.Message);
                } 
            }

            Console.ReadKey();

        }
    }
}
