using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter you birthday: DD.MM.YYYY");
        string birthDay = Console.ReadLine();
        string userYear = birthDay.Substring(6, 4);
        int userYearInt = int.Parse(userYear);
        string userMonth = birthDay.Substring(3, 2);
        int userMonthInt = int.Parse(userMonth);
        string userDay = birthDay.Substring(0, 2);
        int userDayInt = int.Parse(userDay);

        try
        {
            switch (userMonthInt)
            {
                case 01:
                    {
                        string userMonthStr = "January";
                        userMonth = userMonthStr;
                        break;
                    }
                case 02:
                    {
                        string userMonthStr = "February";
                        userMonth = userMonthStr;
                        break;
                    }
                case 03:
                    {
                        string userMonthStr = "March";
                        userMonth = userMonthStr;
                        break;
                    }
                case 04:
                    {
                        string userMonthStr = "April";
                        userMonth = userMonthStr;
                        break;
                    }
                case 05:
                    {
                        string userMonthStr = "May";
                        userMonth = userMonthStr;
                        break;
                    }
                case 06:
                    {
                        string userMonthStr = "June";
                        userMonth = userMonthStr;
                        break;
                    }
                case 07:
                    {
                        string userMonthStr = "July";
                        userMonth = userMonthStr;
                        break;
                    }
                case 08:
                    {
                        string userMonthStr = "August";
                        userMonth = userMonthStr;
                        break;
                    }
                case 09:
                    {
                        string userMonthStr = "September";
                        userMonth = userMonthStr;
                        break;
                    }
                case 10:
                    {
                        string userMonthStr = "October";
                        userMonth = userMonthStr;
                        break;
                    }
                case 11:
                    {
                        string userMonthStr = "November";
                        userMonth = userMonthStr;
                        break;
                    }
                case 12:
                    {
                        string userMonthStr = "December";
                        userMonth = userMonthStr;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong input.");
                        break;
                    }
            }
        }
        catch (Exception e)
        {
            throw e;
        }

        Console.WriteLine("User birthday:\nYear: {0}\nMonth: {1}\nDay: {2}", userYear, userMonth, userDay);

        int currentYearInt = DateTime.Now.Year;
        Console.WriteLine("Current year is: {0}", currentYearInt);
        int currentMonthInt = DateTime.Now.Month;
        Console.WriteLine("Current month is: {0}", currentMonthInt);
        int currentDayInt = DateTime.Now.Day;
        Console.WriteLine("Current day is: {0}", currentDayInt);


        int userAge = 0;
        userAge = currentYearInt - userYearInt;


        var test = DateTime.Today;

        if (test.Day >= userDayInt && test.Month >= userMonthInt)
        {
            Console.WriteLine("User age is: {0}", userAge);

            int ageAfterTenYears = 0;
            ageAfterTenYears = userAge + 10;
            Console.WriteLine("After ten years user will be {0} years old.", ageAfterTenYears);
        }
        else
        {
            Console.WriteLine("User age is: {0}", userAge - 1);

            int ageAfterTenYears = 0;
            ageAfterTenYears = userAge + 10;
            Console.WriteLine("After ten years user will be {0} years old.", ageAfterTenYears - 1);
        }
    }
}