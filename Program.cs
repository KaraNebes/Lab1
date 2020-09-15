using System;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            YourName();
            Console.WriteLine("Назовите Ваши день, месяц и год рождения через Enter");
            YourAge();
            Console.ReadKey();
        }
        static void YourName() {
            string str = Console.ReadLine();
        }
        static void YourAge()
        {
            int day, month, year;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            DateTime BDay;
            BDay = new DateTime();
            BDay = BDay.AddYears(year - 1);
            BDay = BDay.AddMonths(month - 1);
            BDay = BDay.AddDays(day - 1);
           
        }

    }
}
