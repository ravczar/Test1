using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicSolution.Models
{
    public abstract class Item
    {
        private static uint Iterator;
        public uint Id { get; set; }
        public DateTime DateOfProduction { get; set; }

        public Item() => this.Id = Iterator++;

        public abstract void ExpressYourself();

    }
}
