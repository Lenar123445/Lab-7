using Lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class HourPay : Work
    {
        public double Hours { get; set; }
        public HourPay(string FirstName, string LastName, DateTime DateOfBirth, char Gender, double pay, double hours, double prem)
            : base(FirstName, LastName, DateOfBirth, Gender)
        {
            Hours = hours;
            Pay = pay;
            Prem = prem;
        }
        public HourPay() { }
        public new double Salary()
        {
            return (this.Pay * this.Hours) + (this.Pay * this.Hours * this.Prem);
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Введите зп в час: ");
            Pay = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество отработанных часов: ");
            Hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер премии в %: ");
            Prem = double.Parse(Console.ReadLine()) / 100.0;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Зп в час: {Pay} Зарплата за часы: {Salary()}");
        }
        public static void AllSum()
        {
            Console.WriteLine();
        }
    }
}
