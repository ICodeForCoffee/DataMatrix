using DataMatrix.Model;

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
            var key = random.Next(99999);
            var firstName = "";
            var gender = "";
            if (random.Next(2) == 0)
            {
                firstName = DataCache.FirstNameMaleList[random.Next(DataCache.FirstNameMaleList.Count)];
                gender = "Male";
            }
            else
            {
                firstName = DataCache.FirstNameFemaleList[random.Next(DataCache.FirstNameFemaleList.Count)];
                gender = "Female";
            }
            var lastName = DataCache.LastNameList[random.Next(DataCache.LastNameList.Count)];
            var birthday = birthdayHelper.GetRandomBirthdayForAdult();

            return new Person(key, gender, firstName, lastName, birthday);
        }
    }
}