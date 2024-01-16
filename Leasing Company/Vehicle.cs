using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasing_Company
{
    abstract public class Vehicle
    {
        public int ID { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public int YearOfManufacture { get; set; }
        public String Color { get; set; }
        public int Price { get; set; }
        public int RegistrationNumber { get; set; }



        public Vehicle(int id, string brand, string model, int yearOfManufacture, string color, int price, int registrationNumber)
        {
            ID = id;
            Brand = brand;
            Model = model;
            YearOfManufacture = yearOfManufacture;
            Color = color;
            Price = price;
            RegistrationNumber = registrationNumber;
        }
    }
}

