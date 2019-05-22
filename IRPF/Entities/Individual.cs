using System;
using System.Collections.Generic;
using System.Text;
using Irpf.Entities;

namespace Irpf.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(double healthExpenditures, string name, double income)
            : base (name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Income < 20000 && HealthExpenditures > 0.0)
            {
                return (Income * 0.15) - (HealthExpenditures * 0.5);
            }
            else if (Income < 20000 && HealthExpenditures == 0.0)
            {
                return Income * 0.15;
            }
            else if (Income > 20000 && HealthExpenditures > 0.0)
            {
                return (Income * 0.25) - (HealthExpenditures * 0.5);
            }
            else if (Income > 20000 && HealthExpenditures == 0.0)
            {
                return Income * 0.25;
            }
            else
            {
                return 0.0;
            }

        }
    }
}
