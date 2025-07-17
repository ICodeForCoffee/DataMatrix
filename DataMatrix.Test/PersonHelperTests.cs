namespace DataMatrix.Test
{
    public class PersonHelperTests
    {
        [Fact] 
        public void GetRandomPersonTest()
        {
            //So this might need to use a fake or mock DAta, because when I break this into files, I don't want to load the files every test.
            var personHelper = new PersonHelper(new Data());
            var newPerson = personHelper.GetRandomPerson();

            Assert.NotEmpty(newPerson.FirstName);
            Assert.NotEmpty(newPerson.LastName);
            Assert.InRange(newPerson.Id, 1, Int32.MaxValue);
            Assert.IsType<Gender>(newPerson.Gender);
            Assert.NotEmpty(newPerson.Birthday.ToString());
        }

        [Fact]
        public void GetHyphenatedLastNameMustHaveHyphen()
        {
            var personHelper = new PersonHelper(new Data());
            var lastName = personHelper.GetHyphenatedLastName();

            Assert.Contains("-", lastName);
        }

        [Fact]
        public void GetHyphenatedLastNameMustBeTwoSeperateNames()
        {
            var personHelper = new PersonHelper(new Data());
            var lastname = personHelper.GetHyphenatedLastName();

            var nameParts = lastname.Split('-');
            Assert.NotEmpty(nameParts);
            Assert.Equal(2, nameParts.Length);
            Assert.NotEmpty(nameParts[0]);
            Assert.NotEmpty(nameParts[1]);
            Assert.NotEqual(nameParts[0], nameParts[1]);
        }
    }
}