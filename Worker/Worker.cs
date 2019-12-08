using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Worker
    {
        protected string Name;
        protected int Year;
        protected int Month;
        protected Company WorkPlace;
        public Worker()
        {
            string name=null;
            Name = name;
            Year = 0;
            Month = 0;
            //WorkPlace = workplace;
        }
        public Worker(string name,int year, int month, Company workplace)
        {
            Name = name;
            Year = year;
            Month = month;
            WorkPlace=workplace;
        }
        public Worker(string name, string year, int month,Company workplace)
        {
            Name = name;
            Year =Int32.Parse(year);
            Month = month;
        }
        public Worker(string name, int year, int month, string firmname, string position,int salary)
        {
            Name = name;
            Year = year;
            Month = month;
            WorkPlace = new Company(firmname, position, salary);/*
            WorkPlace.SetFirmName(firmname);
            WorkPlace.SetPosition(position);
            WorkPlace.SetSalary(salary);*/
        }
        public Worker(Worker maks)
        {
            Name =maks.Name;
            Year = maks.Year;
            Month = maks.Month;
            WorkPlace = maks.WorkPlace;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetSalary()
        {
            return WorkPlace.GetSalary();
        }
        public string GetFirmName()
        {
            return WorkPlace.GetFirmName();
        }
        public string GetPosition()
        {
            return WorkPlace.GetPosition();
        }
        public void SetMonth(int month)
        {
            Month=month;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetYear(int year)

        {
            Year = year;
        }
        public void SetSalary(int salary)
        {
            WorkPlace.SetSalary(salary);
        }
        public void SetPosition(string position)
        {
            WorkPlace.SetPosition(position);
        }
        public void SetFirmName(string name)
        {
            WorkPlace.SetFirmName(name);
        }
        public int GetWorkExperience()
        {
            
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month+(year*12)-(Year*12+Month);

            return month;
        }
        public int GetTotalMoney()
        {
            int salary = GetWorkExperience() * WorkPlace.GetSalary();
            return salary;
        }
    }
}
