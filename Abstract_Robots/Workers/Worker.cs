using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.birthDate = bDate;
            this.idNumber = id;
            this.password = pass;
        }
        public string GetFullName() { return fullName; }
        public string GetIdNumber() { return idNumber; }
        public DateTime GetBirthDate() { return birthDate; }
        public string GetPassword() { return password; }

        public void SetPassword(string password) { this.password = password; }

        public abstract double calcSalary();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
