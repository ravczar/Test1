using MechanicSolution.Interfaces;
using System;

namespace MechanicSolution.Models
{
    public abstract class Item : IItem
    {
        private static uint Iterator;
        public uint Id { get; set; }
        public DateTime DateOfProduction { get; set; }

        public Item(DateTime DateOfProduction)
        {
            this.Id = Iterator++;
            this.DateOfProduction = DateOfProduction;
        }

        public abstract string Sound();

        public abstract void ExpressYourself();

        public override string ToString() => $"Object: {GetType().Name}, Id:{Id}, Date:{DateOfProduction}";

    }
}
