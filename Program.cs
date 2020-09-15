using System;

namespace lab01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            YourName();
            Console.WriteLine("Назовите Ваши день, месяц и год рождения через Enter");
            YourAge();
            Console.ReadKey();
        }
        public static void YourName() {
            string str = Console.ReadLine();
        }
        public static void YourAge()
        {
            int day, month, year, y=0;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            if ((month > 12)&&(month<1))
            {
                Console.WriteLine("Такого месяца не существует.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            year = Convert.ToInt32(Console.ReadLine());
            if (year < 1)
            {
                Console.WriteLine("Такого года не существует. Вы что родились до нашей эры?");
                Console.ReadKey();
                Environment.Exit(0);
            }
            leap_year(year, y);
            DateTime BDay;
            BDay = new DateTime();
            BDay = BDay.AddYears(year - 1);
            BDay = BDay.AddMonths(month - 1);
            BDay = BDay.AddDays(day - 1);
       

            int age = Convert.ToInt32(DateTime.Now.Year - BDay.Year);
            if ((DateTime.Now.Month > BDay.Month) && (DateTime.Now.Month == BDay.Month))
            {
                
            }
            Console.WriteLine(age);
            Console.ReadKey();
        }
        static int leap_year (int year, int y)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " - високосный год");
                        y = 1;
                        return (y);
                    }
                    else
                    {
                        Console.WriteLine(year + " - не високосный год");
                        y = 0;
                        return (y);
                    }
                }
                else
                {
                    Console.WriteLine(year + " - високосный год");
                    y = 1;
                    return (y);
                }
            }
            else
            {
                Console.WriteLine(year + " - не високосный год");
                y = 0;
                return (y);
            }
            
        }
      
    }
}
