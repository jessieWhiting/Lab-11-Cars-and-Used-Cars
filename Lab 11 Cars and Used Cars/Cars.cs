using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_Cars_and_Used_Cars
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

       
        public Car()
        {

        }
        public Car(string maKe, string model, int year, decimal price)
        {
            Make = maKe;
            Model = model;
            Year = year;
            Price = price;
        }
        public override string ToString()
        {
            string output = $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}";
            return output;
        }
    }

}
