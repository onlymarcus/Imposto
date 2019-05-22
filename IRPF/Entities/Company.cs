using System;
using System.Collections.Generic;
using System.Text;

namespace Irpf.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(int numberofemployees, string name, double income)
            : base(name, income)
        {
            NumberOfEmployees = numberofemployees;
        }
        public override double Tax()
        {
            if (NumberOfEmployees > 10.0)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}
