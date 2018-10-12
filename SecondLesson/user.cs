using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRent
{
    public class user
    {
        public string name { get; set; }
        public int id { get; private set; }
        public bool rentAvailibleStatus { get; private set; }
        public List<rent> rentHistory { get; private set; }
        public int idCurrentRentedCar { get; private set; }


        public void User(string name, int id, bool rentAvailibleStatus, List<rent> rentHistory, int idCurrentRentedCar)
        {
            this.name = name;
            this.id = id;
            this.rentAvailibleStatus = rentAvailibleStatus;
            this.rentHistory = rentHistory;
            this.idCurrentRentedCar = idCurrentRentedCar;
        }

        //public static void checkRentStatus(bool status)
        //{
        //    if (status == false)
        //    {
        //        Console.WriteLine("You have rented car already");
        //    }
        //}

        //public static void addUser()
        //{

        //}

        public static void addRentToHistory()
        {
            
        }

        public static void rentCar(bool rentAvailibleStatus)
        {
            if(rentAvailibleStatus)
            {
                Console.WriteLine("Input car id");
                int carId = Int16.Parse(Console.ReadLine());

                

            }
        }
    }
}
