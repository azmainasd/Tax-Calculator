using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{ 
    class FullTimeEmployee : Employee
    {
        protected double grossBonus;

        public FullTimeEmployee(String id, String name, double[] salary, double[] bonus) : base(id, name, salary)
        {
           this.GrossBonus = TotalBonus(bonus);
        }
        internal double GrossBonus
        {
           get { return this.grossBonus; }
           set
           {
              if (value > 0)
                this.grossBonus = value;
              else
                this.grossBonus = 0;
           }
        }
        public double TotalBonus(double[] bonus)
        {
            byte count = 0;
            double totalBonus = 0;
            while (count < bonus.Length)
            {
               totalBonus += bonus[count];
               count++;
            }
            return totalBonus;
        }
        public  double TaxPayable()
        {
            return base.TaxPayable() + this.GrossBonus * .8;
        }
        public  void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Gross salary" + this.GrossBonus);

        }


    }
}
