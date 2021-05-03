using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee()
        {

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge)
        : base(name, hours, valuePerHours)
        {

            AdditionalCharge = additionalCharge;
        }
        // sobreposicao do metodo 
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }

}
