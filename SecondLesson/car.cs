using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRent
{
    public class car
    {
        public string model { get; set; }
        public int id { get; set; }
        public DateTime availabilityDate { get; set; }
        public bool availableStatus { get; set; }
        public int totalCountOfRents { get; set; }

        public void Car(string model, int id, DateTime availabilityDate, bool availableStatus, int totalCountOfRents)
        {
            this.model = model;
            this.id = id;
            this.availabilityDate = availabilityDate;
            this.availableStatus = availableStatus;
            this.totalCountOfRents = totalCountOfRents;
        }

        //public static void addCar()
        //{

        //}

        public static car addCountOfRents(car Car)
        {
            Car.totalCountOfRents++;
            checkСheckupNeed(Car);
            return Car;
        }

        public static car checkСheckupNeed(car Car)
        {
            if (Car.totalCountOfRents % 10 == 0)
            {
                Car.totalCountOfRents = 0;
                sendCarToCheckup(Car);
            }
            return Car;
        }

        public static car sendCarToCheckup(car Car)
        {
            Car.availabilityDate = Car.availabilityDate.AddDays(7);
            return Car;
        }

        public static bool checkAvailableStatus(car Car, DateTime expectedDate)
        {
            if (Car.availabilityDate <= expectedDate)
            {
                Car.availableStatus = true;
            }
            else
            {
                Car.availableStatus = false;
            }
            return Car.availableStatus;
        }
    }
}
