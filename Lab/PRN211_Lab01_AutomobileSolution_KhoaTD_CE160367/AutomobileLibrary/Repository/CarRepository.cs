using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        // Call funtions in CarDBContext by singlethon.
        // Delete a cart by passed car id
        public void DeleteCar(int carID) => CarDBContext.Instance.Remove(carID);
        // Load a cart by passed car id
        public Car GetCarByID(int carID) => CarDBContext.Instance.GetCarByID(carID);
        // Get list of cars
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;
        // Add new car by passed new object car
        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);
        // Update car's information by passed new object car
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
