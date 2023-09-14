using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.BussinessObject
{
    // specified class car for tranfers data by CarDBcontext
    public class Car
    {
        // id of car to indentify a car
        public int CarID { get; set; }
        // store name of car
        public string CarName { get; set; }
        // store a factory/manufacture to operation a car
        public string Manufacture { get; set; }
        // store export price of car
        public decimal Price { get; set; }
        // store start year of public a car
        public int ReleaseYear { get; set; }

    }
}
