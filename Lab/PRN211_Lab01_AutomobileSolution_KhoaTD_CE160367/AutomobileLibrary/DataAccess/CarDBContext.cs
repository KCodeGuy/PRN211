using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        // Create a list of car to load in data table UI.
        private static List<Car> CarList = new List<Car>()
        {
            new Car{CarID = 1, CarName="CRV", Manufacture="Honda", Price=30000, ReleaseYear=2021},
            new Car{CarID = 2, CarName="Ford Focus", Manufacture="Ford", Price=15000, ReleaseYear=2020}
        };

        // Initialize an static of object (siglethon aritheture)
        private static readonly object instanceLock = new object();
        private static CarDBContext instance = null;
        
        // Defaut constructor
        private CarDBContext() { }
       
        // Initilize instance 
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        // Get list of cars
        public List<Car> GetCarList => CarList;

        // Get a specified car by passed ID
        public Car GetCarByID(int carID)
        {
            // Using LINQ to return an object
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }


        // Add a new car into car list
        public void AddNew(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if (pro == null)
            {
                // add new car
                CarList.Add(car);
            }
            else
            {
                // throw exception message when car is exist!
                throw new Exception("Car is already exist!");
            }
        }

        // Update a car by passed  new car
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c != null)
            {
                var index = CarList.IndexOf(c);
                CarList[index] = car;
            }
            else
            {
                // throw exception message when car is not exist!
                throw new Exception("Car does not already exists!");
            }
        }

        //Remove a car by specified id
        public void Remove(int CarID)
        {
            Car p = GetCarByID(CarID);
            if (p != null)
            {
                CarList.Remove(p);
            }
            else
            {
                // throw exception message when car is not exist!
                throw new Exception("Car does not already exists!");
            }
        }
    }
}
