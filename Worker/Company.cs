using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Company
    {
        protected string Name;
        protected string Position;
        protected int Salary;
        public Company(string name,string position,int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public Company()
        {
            Name = null;
            Position = null;
            Salary = 0 ;
        }
        public Company(string name, string position)
        {
            Name = name;
            Position = position;
        }
        public Company(Company workplace)
        {
            Name =workplace.Name;
            Position =workplace.Position;
            Salary =workplace.Salary;
        }
        public int GetSalary()
        {
            return Salary;
        }
        public string GetFirmName()
        {
            return Name;
        }
        public string GetPosition()
        {
            return Position;
        }
        public void SetSalary(int salary)
        {
            Salary =salary;
        }
        public void SetPosition(string position)
        {
            Position = position;
        }
        public void SetFirmName(string name)
        {
            Name = name;
        }
    }
}
