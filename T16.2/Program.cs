using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16._2
{
    internal class Program
    {
            static DateTime InputDate(string number)
            {
                WriteLine($"Enter {number} date: ");
                Write("Day (dd): ");
                int day = Convert.ToInt32(ReadLine());
                Write("Month (MM): ");
                int month = Convert.ToInt32(ReadLine());
                Write("Year (yyyy): ");
                int year = Convert.ToInt32(ReadLine());
                WriteLine();
                return new DateTime(year, month, day);
            }
        static void Main(string[] args)
        {
            try
            {

                //Task 1
                //Enter two dates and determine the number of days between them.

                /*DateTime date1 = new DateTime(2024, 01, 29);
                DateTime date2 = new DateTime(2005, 04, 27);
                TimeSpan delta = date1 - date2;
                WriteLine($"\nBetween {date1.ToString("dd MM yyyy")} and {date2.ToString("dd MM yyyy")} - {delta.Days} days\n");

                DateTime date_1 = InputDate("first");
                DateTime date_2 = InputDate("second");
                TimeSpan diff = date_1 - date_2;
                WriteLine($"Between {date_1.ToString("dd MM yyyy")} and {date_2.ToString("dd MM yyyy")} - {diff.Days} days\n");*/


                //Task 2
                //Determine how many days are left until the end of the month.

                /*DateTime date = InputDate("");
                WriteLine($"By the end of the month {DateTime.DaysInMonth(date.Year, date.Month) - date.Day} days");*/


                //Task 3
                //Ввести свою дату рождения. Определить:
                //a). день недели, в котором вы родились;
                //b). порядковый номер дня рождения в году;
                //c). является ли ваш год рождения високосным;
                //d). дату ближайшего дня рождения(формат вывода: среда, 11 января 2023);
                //e). количество полных лет;
                //f).  сколько дней осталось от сегодняшней даты до вашего ближайшего дня рождения(если день рождения сегодня, то вывести 0)

                DateTime birthday = InputDate("");
                WriteLine($"{birthday.ToString("dd MM yyyy")}\nDay of week: {birthday.ToString("dddd")}\nBirthday number: {birthday.DayOfYear}\nLeap or no: {DateTime.IsLeapYear(birthday.Year)}\nAge: {DateTime.Today.Year - birthday.Year}");
                DateTime next_bday = new DateTime(DateTime.Today.Year, birthday.Month, birthday.Day);
                if (next_bday < birthday) { next_bday = birthday.AddYears(1); }
                WriteLine($"Next birthday: {next_bday.ToString("dd.MM.yyyy")}");
                if (DateTime.Today == birthday) { WriteLine($"From today's date to your next birthday {0} days"); } 
                else { WriteLine($"From today's date to your next birthday {(next_bday - DateTime.Today).Days} days"); }


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
        
    }
}
