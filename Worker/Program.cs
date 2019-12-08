using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Workplace = new Company();
            Worker Maks = new Worker("Maks", 0, 10,Workplace);
            Worker Maks2 = new Worker(Maks);
            int n,min,max;
            Console.Write("Введіть кількість працівників n =");
            n =Int32.Parse(Console.ReadLine());
            Worker[] mas = new Worker[n];
            mas = ReadWorkersArray(mas,n);
            SortWorkerByWorkExperience(mas, n);
            PrintWorkers(mas, n);
            PrintWorkers(Maks);
            GetWorkersInfo(mas,n,out max,out min);
           SortWorkerBySalary(mas, n);
        }

        static Worker[] ReadWorkersArray(Worker[] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                mas[i] = new Worker(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            }
            return mas;
        }
        static void PrintWorkers(Worker[] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Name = {mas[i].GetName()} Year = {mas[i].GetYear()} Month = {mas[i].GetMonth()} FirmName = {mas[i].GetFirmName()} Position = {mas[i].GetPosition()} Salary = {mas[i].GetSalary()}");
            }
        }
        static void PrintWorkers(Worker Maks)
        {
            
                Console.WriteLine($"Name = {Maks.GetName()} Year = {Maks.GetYear()} Month = {Maks.GetMonth()} FirmName = {Maks.GetFirmName()} Position = {Maks.GetPosition()} Salary = {Maks.GetSalary()}");
            
        }
        static void GetWorkersInfo(Worker[] mas, int n,out int max,out int min)
        {
            max = mas[0].GetSalary();
            min = mas[0].GetSalary();
            for (int i = 0; i < n; i++)
            {
               if(max>mas[i].GetSalary())
                {
                    max = mas[i].GetSalary();
                }
                if (min <mas[i].GetSalary())
                {
                    min = mas[i].GetSalary();
                }
            }
        }
        static Worker[] SortWorkerBySalary(Worker[] mas, int n)
        {
            int s,k=0;
            string m; 
            for (int i = 0; i < n-1; i++)
            {
                if(mas[i].GetSalary()<mas[i+1].GetSalary())
                {
                    m = mas[i + 1].GetName();
                    mas[i + 1].SetName(mas[i].GetName());
                    mas[i].SetName(m);
                    s = mas[i + 1].GetYear();
                    mas[i+1].SetYear(mas[i].GetYear());
                    mas[i].SetYear(s);
                    s = mas[i + 1].GetMonth();
                    mas[i + 1].SetMonth(mas[i].GetMonth());
                    mas[i].SetMonth(s);
                    m = mas[i + 1].GetFirmName();
                    mas[i + 1].SetFirmName(mas[i].GetFirmName());
                    mas[i].SetFirmName(m);
                    m = mas[i + 1].GetPosition();
                    mas[i + 1].SetPosition(mas[i].GetPosition());
                    mas[i].SetPosition(m);
                    s = mas[i + 1].GetSalary();
                    mas[i + 1].SetSalary(mas[i].GetSalary());
                    mas[i].SetSalary(s);
                }
                if(i==n-2)
                {
                    i = 0;
                    k++;
                    if (k == n - 1)
                        break;
                }
            }
            return mas;
        }
        static Worker[]  SortWorkerByWorkExperience(Worker[] mas, int n)
        {
            int s, k = 0;
            string m;
            for (int i = 0; i < n - 1; i++)
            {
                if (mas[i].GetWorkExperience() > mas[i + 1].GetWorkExperience())
                {
                    m = mas[i + 1].GetName();
                    mas[i + 1].SetName(mas[i].GetName());
                    mas[i].SetName(m);
                    s = mas[i + 1].GetYear();
                    mas[i + 1].SetYear(mas[i].GetYear());
                    mas[i].SetYear(s);
                    s = mas[i + 1].GetMonth();
                    mas[i + 1].SetMonth(mas[i].GetMonth());
                    mas[i].SetMonth(s);
                    m = mas[i + 1].GetFirmName();
                    mas[i + 1].SetFirmName(mas[i].GetFirmName());
                    mas[i].SetFirmName(m);
                    m = mas[i + 1].GetPosition();
                    mas[i + 1].SetPosition(mas[i].GetPosition());
                    mas[i].SetPosition(m);
                    s = mas[i + 1].GetSalary();
                    mas[i + 1].SetSalary(mas[i].GetSalary());
                    mas[i].SetSalary(s);
                }
                if (i == n - 2)
                {
                    i = 0;
                    k++;
                    if (k == n - 1)
                        break;
                }
            }
            return mas;
        }
    }
}
