using System;
using Irpf.Entities;
using System.Collections.Generic;

namespace Irpf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter de number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();
            
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if ( ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(healthexpenditures, name, income));
                }
                else
                {
                    Console.WriteLine("Number of employees: ");
                    int numberofemployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(numberofemployees, name, income));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $"+ taxPayer.Tax());
            }
            Console.WriteLine();
            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                sum += taxPayer.Tax();
            }
            Console.WriteLine("Total taxes: $"+sum);

        }
    }
}
