using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker: Worker
    {
        public double MoneyPerHour;
        public int Hours;
        public OperationalWorker(string name, string id, DateTime bDate, string pass, double MoneyPerHour, int hours)
            : base(name, id, bDate, pass)
        {
            this.MoneyPerHour = MoneyPerHour;
            this.Hours = hours;
        }

        public override double calcSalary()
        {
            return MoneyPerHour * Hours;
        }
    }
}
