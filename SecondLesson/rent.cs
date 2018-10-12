using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRent
{
    public class rent
    {
        public DateTime startRent { get; set; }
        public DateTime endRent { get; set; }
        public int idRentedCar { get; set; }
        public int userId { get; set; }
        public bool status { get; set; }

        public void Rent(DateTime startRent, DateTime endRent, int idRentedCar, int userId, bool status)
        {
            this.startRent = startRent;
            this.endRent = endRent;
            this.idRentedCar = idRentedCar;
            this.userId = userId;
            this.status = status;
        }

        public static bool checkRentStatus(rent Rent, DateTime expectedDate)
        {
            if(Rent.endRent <= expectedDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool availibleStatusToNextRent(rent Rent1, rent Rent2)
        {
            if(Rent1.endRent <= Rent2.startRent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public static void addRent()
        //{

        //}
    }
}
