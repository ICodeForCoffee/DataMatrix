using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMatrix
{
    public class BirthdayHelper
    {
        public DateOnly GetRandomBirthdayForAdult()
        {
            //The oldest person to ever live reached 122, but very, very few people make it past 100.
            Random random = new Random();
            //Using a max age right now of 102 since each age is currently an equal probability.
            int yearOffset = random.Next(84);
            int birthYear = DateTime.Now.Year - yearOffset - 18;
            int dayOffset = 0;
            if (birthYear + 18 == DateTime.Now.Year)
            {
                //This will cluster the dates to the part of the year that has already occured. I could shift this around if I redid the generation.
                dayOffset = random.Next(DateTime.Now.DayOfYear) - 1;
            }
            else if (IsLeapYear(birthYear))
            {
                dayOffset = random.Next(366);
            }
            else
            {
                dayOffset = random.Next(365);
            }

            var birthdayDateTime = new DateTime(birthYear, 1, 1).AddDays(dayOffset);
            DateOnly someDate = new DateOnly();
            someDate = DateOnly.FromDateTime(birthdayDateTime);
            return someDate;
        }

        public bool IsLeapYear(int year)
        {
            var isLeapYer = (year) switch
            {
                var x when x % 400 == 0 => true,
                var x when x % 100 == 0 => false,
                var x when x % 4 == 0 => true,
                _ => false,
            };

            return isLeapYer;
        }
    }
}
