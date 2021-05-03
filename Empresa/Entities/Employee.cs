using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }

        public double ValuePerHours { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        // sobreposicao do metodo 
        public virtual double Payment()
        {
            return Hours * ValuePerHours;
        }
    }
}
