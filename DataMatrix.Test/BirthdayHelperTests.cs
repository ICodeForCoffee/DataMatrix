using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMatrix.Test
{
    public class BirthdayHelperTests
    {
        [Fact]
        public void GetRandomBirthdayIsAdult()
        {
            var birthdayHelper = new BirthdayHelper();

            var today = DateOnly.FromDateTime(DateTime.Now);

            for (int i = 0; i < 1000; i++)
            {
                var birthday = birthdayHelper.GetRandomBirthdayForAdult();

                var daysSinceBirthday = today.DayNumber - birthday.DayNumber;
                bool isAdult = false;
                //Check to make sure over 18 years have passed
                if (daysSinceBirthday >= 6575)
                {
                    isAdult = true;
                }
                else if(daysSinceBirthday == 6574)
                {
                    if (today.Day == birthday.Day)
                    {
                        isAdult = true;
                    }
                }

                Assert.True(isAdult, $"{birthday.ToString()} is not an adult");
            }
        }

        [Fact]
        public void GetRandomBirthdayDoesNotExceedHumanLifespan()
        {
            //Oldest person in existance lived to 122. Assuming science advances, let's say 125 is the maximium age we can get.
            var birthdayHelper = new BirthdayHelper();

            var today = DateOnly.FromDateTime(DateTime.Now);

            for (int i = 0; i < 1000; i++)
            {
                var birthday = birthdayHelper.GetRandomBirthdayForAdult();

                var daysSinceBirthday = today.DayNumber - birthday.DayNumber;
                bool doesNotExceedHumanLifespan = false;
                //Check to make sure over 18 years have passed
                if (daysSinceBirthday <= 37256)
                {
                    doesNotExceedHumanLifespan = true;
                }

                Assert.True(doesNotExceedHumanLifespan, $"{birthday.ToString()} exceeds human lifespan");

            }
        }
    }
}
