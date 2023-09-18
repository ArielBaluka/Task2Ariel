using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        public double MoneyPerHour;
        public int Hours;
        public int SuccessfulMissions;
        public OperationManager(string name, string id, DateTime bDate, string pass, double MoneyPerHour, int hours)
            : base(name, id, bDate, pass)
        {
            this.MoneyPerHour = MoneyPerHour;
            this.Hours = hours;
            this.SuccessfulMissions = 0;
        }

        public OperationManager(string name, string id, DateTime bDate, string pass, double MoneyPerHour, int hours, int successfulMissions)
            : base(name, id, bDate, pass)
        {
            this.MoneyPerHour = MoneyPerHour;
            this.Hours = hours;
            this.SuccessfulMissions = successfulMissions;
        }

        public int GetHours() { return this.Hours; }
        public double GetMoneyPerHour() { return this.MoneyPerHour; }
        public double GetSuccessfulMissions() { return this.SuccessfulMissions; }
        public void SetHours(int Hours) { this.Hours = Hours; }
        public void SetMoneyPerHour(int MoneyPerHour) { this.MoneyPerHour = MoneyPerHour; }
        public void SetSuccessfulMissions(int SuccessfulMissions) { this.SuccessfulMissions = SuccessfulMissions; }

        public override double calcSalary()
        {
            double salary = MoneyPerHour * Hours;
            for (int i = 0; i < SuccessfulMissions; i++)
            {
                salary += salary * 0.03;
            }
            return salary;
        }
    }
}
