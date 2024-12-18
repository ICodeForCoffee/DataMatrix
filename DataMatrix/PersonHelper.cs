using DataMatrix.Model;
using System;

namespace DataMatrix
{
    public class PersonHelper
    {
        Data DataCache { get; set; }

        public PersonHelper(Data dataCache)
        {
            DataCache = dataCache;
        }

        public Person GetRandomPerson()
        {
            BirthdayHelper birthdayHelper = new BirthdayHelper();
            var random = new Random();
            var key = random.Next(100000);
            var firstName = "";
            Gender? gender = null;
            if (random.Next(2) == 0)
            {
                firstName = DataCache.FirstNameMaleList[random.Next(DataCache.FirstNameMaleList.Count)];
                gender = Gender.Male;
            }
            else
            {
                firstName = DataCache.FirstNameFemaleList[random.Next(DataCache.FirstNameFemaleList.Count)];
                gender = Gender.Female;
            }

            //5% of the time, get a hyphenated last name, otherwise just get a random last name.
            string lastName = (random.Next(21)) switch
            {
                20 => GetHyphenatedLastName(),
                _ => DataCache.LastNameList[random.Next(DataCache.LastNameList.Count)]
            };

            var birthday = birthdayHelper.GetRandomBirthdayForAdult();

            return new Person(key, (Gender)gender, firstName, lastName, birthday);
        }

        public string GetHyphenatedLastName()
        {
            var random = new Random();
            var name1 = DataCache.LastNameList[random.Next(DataCache.FirstNameFemaleList.Count)];
            var name2 = name1;
            while (name1 == name2) {
                name2 = DataCache.LastNameList[random.Next(DataCache.FirstNameFemaleList.Count)];
            }

            return $"{name1}-{name2}";
        }
    }
}