using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicSolution.Models
{
    class Car : Item
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public Car ( DateTime DateOfProduction, string Model, string Brand ) : base( DateOfProduction )
        {
            this.Model = Model;
            this.Brand = Brand;
        } 

        public override void ExpressYourself()
        {
            throw new NotImplementedException("Not implemented method!");
        }

        public override string Sound() => "Car sound";

        public override string ToString() => base.ToString() + $", model:{Model}, brand:{Brand}, sound:{Sound()}.";
    }
}
