using System;
using System.Collections.Generic;
using System.Text;

namespace Irpf.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public TaxPayer()
        {

        }

        public TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();

    }
}
