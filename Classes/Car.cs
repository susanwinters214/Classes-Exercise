using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Classes
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
       
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
        }
}
