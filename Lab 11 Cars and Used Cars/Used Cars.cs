using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_Cars_and_Used_Cars
{
    class UsedCar : Car
    {

        public double Mileage { get; set; }
        public string Used { get; set; }

        //We want to make a constructor that passes values up to the parent and 
        //Adds in our additional one
        //We can use the base keyword here, but it takes a different form.

        public UsedCar(string make, string model, int year, decimal price, double mileage, string used) : base(make, model, year, price)
        {
            this.Mileage = mileage;
            this.Used = used;
        }
        public override string ToString()
        {
            return base.ToString() + " Mileage: " + Mileage + "__" + " Vehicle Type: " + Used;
        }




    }

}
