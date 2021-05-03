using System;
using System.Collections.Generic;
using Empresa.Entities;
using System.Globalization;
namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter  the number of employees :");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data :");
                Console.WriteLine("Outsourced (y/n)? ");

                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours :");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value of hour : ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.WriteLine("Addicional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutSourcedEmployee(name, hours, valuePerHours, addicionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
            }
            Console.WriteLine("Payment:");
            foreach(Employee emp in list)
            {
                Console.WriteLine( emp.Name + "- $" + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
