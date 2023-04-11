using ConsoleApp9;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Введите число людей: ");
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                people[i] = new Person();
                people[i].Read();
            }
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(people[i].FirstName);
                Console.WriteLine(people[i].LastName);
                Console.WriteLine(people[i].Age(people[i].DateOfBirth));
                Console.WriteLine(people[i].Gender);
            }*/
            //Work Lenar = new Work("Lenar", "Saifullin", new DateTime(2005, 02, 19), 'М', 1000, 25);
            //Lenar.Read();
            //Console.WriteLine(Lenar.Salary());
            //Lenar.Print();
            double sum = 0;
            double tax = 0;
            double maxsum = -1000;
            HourPay[] workers = new HourPay[3];
            for (int i = 0; i < 4; i++)
            {
                workers[i] = new HourPay();
                workers[i].Read();
                sum += workers[i].Salary();
                tax += workers[i].Obrok();
                if (workers[i].Salary() > maxsum)
                {
                    maxsum = workers[i].Salary();
                }
            }


            Console.WriteLine($"Общая сумма налогов: {tax} Общая сумма начисленная работникам: {sum} Максимальная зарплата: {maxsum}");



        }
    }
}