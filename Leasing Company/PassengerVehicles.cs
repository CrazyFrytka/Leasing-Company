using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leasing_Company
{
    public class PassengerVehicles : Vehicle
    {
        public PassengerVehicles(int id, string brand, string model, int yearOfManufacture, string color, int price, int registrationNumber) : base(id, brand, model, yearOfManufacture, color, price, registrationNumber)
        {
        }

        public void Rent(int time, int distance, int specific, int weight)
        {

        }
    }


}
