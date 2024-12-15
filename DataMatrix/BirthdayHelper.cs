﻿using System;
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
            if (IsLeapYear(birthYear))
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
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}