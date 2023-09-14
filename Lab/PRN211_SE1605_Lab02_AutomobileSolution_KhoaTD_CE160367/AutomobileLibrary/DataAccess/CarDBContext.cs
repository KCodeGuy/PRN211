using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext : BaseDAL
    {
       // Declare instance varibale by singlethon
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
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

        //-----------------------------
        public IEnumerable<Car> GerCarList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Cars";
            var cars = new List<Car>();
            try
            {
                dataReader = dataProvier.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while(dataReader.Read())
                {
                    cars.Add(new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName= dataReader.GetString(1),
                        Manufacture = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    });
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { dataReader.Close();
                CloseConnection();
            }
            return cars;
        }
        public Car GetCarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Cars where CarID = @CarID ";
            try
            {
                var param = dataProvier.CreateParameter("@CarID", 4, carID, DbType.Int32);
                dataReader = dataProvier.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    car = new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName= dataReader.GetString(1),
                        Manufacture = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    };
                }
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
            finally { 
                dataReader.Close();
                CloseConnection(); }
            return car;
        }

        //------------------------------

        //To add a new car into list.
        public void AddNew(Car car)
        {
         try
            {
                Car pro = GetCarByID(car.CarID);
                if (pro == null)
                {
                    String SQLInsert = "Insert Cars values(@CarID,@CarName,@Manufacturer,@Price,@ReleasedYear)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvier.CreateParameter("@CarID",4,car.CarID, DbType.Int32));
                    parameters.Add(dataProvier.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvier.CreateParameter("@Manufacturer", 50, car.Manufacture, DbType.String));
                    parameters.Add(dataProvier.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvier.CreateParameter("@ReleasedYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvier.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                } 
                else
                {
                    throw new Exception("The car is exist.");
                }
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }

        //To update a car informatino
        public void Update(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarID);
                if (c != null) {
                    string SQLUpdate = "Update Cars set CarName = @CarName, Manufactur = @Manufacturer," +
                        "Price = @Price, ReleaseYear = @ReleasedYear where CarID= @CarID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvier.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvier.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvier.CreateParameter("@Manufacturer", 50, car.Manufacture, DbType.String));
                    parameters.Add(dataProvier.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvier.CreateParameter("@ReleasedYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvier.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car dose not exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally{CloseConnection(); }
        }

        //Remove a car out of list by car's id
        public void Remove(int carID)
        {
         try
            {
                Car car = GetCarByID(carID);
                if (car != null) {
                    String SQLDelete = "Delete Cars where CarID = @CarID";
                    var param = dataProvier.CreateParameter("@CarID", 4, carID, DbType.Int32);
                    dataProvier.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The car does not exist");
                }


            }
            catch(Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }
    }
}
