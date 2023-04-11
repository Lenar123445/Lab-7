using Lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Work : Person
    {
        public double Pay { get; set; }

        public double Prem { get; set; }
        public Work(string FirstName, string LastName, DateTime DateOfBirth, char Gender, double zp, double prem)
            : base(FirstName, LastName, DateOfBirth, Gender)
        {
            Pay = zp;
            Prem = prem / 100.0;
        }
        public Work() { }

        public Work(string firstName, string lastName, DateTime dateOfBirth, char gender) : base(firstName, lastName, dateOfBirth, gender)
        {
        }

        /*public override void Read()
        {
            base.Read();
            Console.WriteLine("Введите оклад: ");
            Pay = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер премии в %: ");
            Prem = double.Parse(Console.ReadLine()) / 100.0;            
        }*/
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Оклад: {Pay} Зарплата с премией: {Salary()} Итого на руки: {PayDay2()}");
        }
        public double Salary()
        {
            return this.Pay + this.Pay * this.Prem;
        }
        public double Obrok()
        {
            return Salary() * 0.13;
        }
        public double PayDay2()
        {
            return Salary() - Obrok();
        }
    }
}
