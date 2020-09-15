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
            if ((month > 12)||(month<1))
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
            day_check(day, year, y);
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
        public static int leap_year (int year, int y)
        {
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
            for (int i = 1; i <= month; i++)
            {
                if (i < 8)
                {
                    if (i % 2 == 1) //Проверка на январь, март, май и июль
                    {
                        if (day > 31)
                        {
                            Console.WriteLine("Такого дня не существует.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    else if((i % 2 == 0) && (i != 2)) //проверка на апрелб и июнь
                    {
                        if (day > 30)
                        {
                            Console.WriteLine("Такого дня не существует.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    else if((i==2)&&(y==1)) //проверка на февраль високосного года
                    {
                        if (day > 29)
                        {
                            Console.WriteLine("Такого дня не существует.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    else if(i==2)
                    {
                        if (day > 28) //проверка на февраль не високосного года
                        {
                            Console.WriteLine("Такого дня не существует.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                }
                else if (i >= 8)
                {
                    if (i % 2 == 1) //Проверка на сентябрь и ноябрь
                    {
                        if (day > 30)
                        {
                            Console.WriteLine("Такого дня не существует.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    else if (i % 2 == 0) //проверка на август, октябрь и декабрь
                    {
                        if (day > 31)
                        {
                            Console.WriteLine("Такого дня не существует.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
