using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        protected double monthlySalary;
        protected int WorkingRobots;
        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary)
            :base (name,id,bDate,pass)
        {
            this.monthlySalary = monthlySalary;
            WorkingRobots = 0;
        }

        public int GetWorkingRobots() { return this.WorkingRobots; }
        public double GetMonthlySalary() { return this.monthlySalary; }
        public void SetWorkingRobots(int workingRobots) { this.WorkingRobots = workingRobots; }
        public void SetMonthlySalary(double monthlySalary) { this.monthlySalary = monthlySalary; }

        public override double calcSalary()
        {
            if(WorkingRobots >= 15)
                return monthlySalary + monthlySalary*0.15;
            return monthlySalary;
        }
    }
}
