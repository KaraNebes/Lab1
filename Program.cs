using System;

namespace lab01
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Name = YourName();
            int Age = YourAge();
            Console.WriteLine("Привет, " + Name + ". Ваш возраст " + Age + " лет. Приятно познакомиться.");
            Console.ReadKey();
        }
        public static string YourName() {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            return (name);
        }
        public static int YourAge()
        {
            Console.WriteLine("Назовите Ваши день, месяц и год рождения через Enter");
            int day, month, year, y=0;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            if (month>12)
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
            y = leap_year(year);
            day_check(day, year, y);
            DateTime BDay;
            BDay = new DateTime();
            BDay = BDay.AddYears(year - 1);
            BDay = BDay.AddMonths(month - 1);
            BDay = BDay.AddDays(day - 1);
       

            int age = Convert.ToInt32(DateTime.Now.Year - BDay.Year);
            if ((DateTime.Now.Month < BDay.Month)||(DateTime.Now.Month == BDay.Month))
            {
                if (DateTime.Now.Day < BDay.Day)
                {
                    age--;
                }
            }
            return (age);
        }
        public static int leap_year (int year)
        {
            int y = 0;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        y = 1;
                        return (y);
                    }
                    else
                    {
                        y = 0;
                        return (y);
                    }
                }
                else
                {
                    y = 1;
                    return (y);
                }
            }
            else
            {
                y = 0;
                return (y);
            }
            
        }
        public static void day_check (int day, int month, int y)
        {
            if((month==1)||(month==3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
            {
                if (day >= 31)
                {
                    Console.WriteLine("Такого дня не существует.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else if((month == 4) || (month == 6) || (month == 9) || (month == 11))
            {
                if (day > 30)
                {
                    Console.WriteLine("Такого дня не существует.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else if((month == 2) && (y == 1))
            {
                if (day > 29)
                {
                    Console.WriteLine("Такого дня не существует.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else if ((month == 2) && (y == 0))
            {
                if (day > 28)
                {
                    Console.WriteLine("Такого дня не существует.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}
