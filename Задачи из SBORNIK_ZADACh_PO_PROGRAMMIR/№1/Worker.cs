using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    class Worker
    {
        string lastName;
        int salary;
        DateTime hireDate;  
        public Worker()
        {
            lastName = "Unknown";
            salary = 0;
            hireDate = DateTime.Now;
        }
        public Worker(string lastName, int salary, DateTime year)
        {
            this.lastName = lastName;
            this.salary = salary;
            this.hireDate = year;
        }
        public int HowLongWork() => DateTime.Now.Year - hireDate.Year;

        public int HowLongWorkInDays()
        {
            TimeSpan span = DateTime.Now - hireDate;
            return span.Days > 0 ? span.Days : 0;
        }
        public string GetInfo() => $"Сотрудник: {lastName}\nДата приема: {hireDate:dd.MM.yyyy}\nСтаж работы: {HowLongWork()} лет\nДней после года приема: {HowLongWorkInDays()}";

        ~Worker()
        {
            Console.WriteLine($"Объект {lastName} уничтожен");
        }
    }
}
