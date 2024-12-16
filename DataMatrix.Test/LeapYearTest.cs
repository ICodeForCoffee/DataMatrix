using DataMatrix;

namespace DataMatrix.Test
{
    public class LeapYearTest
    {
        [Fact]
        public void NotLeapYear()
        {
            BirthdayHelper birthdayHelper = new BirthdayHelper();
            Assert.False(birthdayHelper.IsLeapYear(2001));
            Assert.False(birthdayHelper.IsLeapYear(1999));
            Assert.False(birthdayHelper.IsLeapYear(2003));
            Assert.False(birthdayHelper.IsLeapYear(2023));
            Assert.False(birthdayHelper.IsLeapYear(1847));
            Assert.False(birthdayHelper.IsLeapYear(1947));
            Assert.False(birthdayHelper.IsLeapYear(651));
        }

        [Fact]
        public void IsLeapYear()
        {
            BirthdayHelper birthdayHelper = new BirthdayHelper();
            Assert.True(birthdayHelper.IsLeapYear(2000));
            Assert.True(birthdayHelper.IsLeapYear(1984));
            Assert.True(birthdayHelper.IsLeapYear(2004));
            Assert.True(birthdayHelper.IsLeapYear(2024));
            Assert.True(birthdayHelper.IsLeapYear(1848));
            Assert.True(birthdayHelper.IsLeapYear(1948));
            Assert.True(birthdayHelper.IsLeapYear(652));
        }

        [Fact]
        public void SecondMilleniumIsLeapYear()
        {
            BirthdayHelper birthdayHelper = new BirthdayHelper();
            Assert.True(birthdayHelper.IsLeapYear(2000));
        }

        [Fact]
        public void YearsDividedBy400AreLeapYears()
        {
            BirthdayHelper birthdayHelper = new BirthdayHelper();
            Assert.True(birthdayHelper.IsLeapYear(2800));
            Assert.True(birthdayHelper.IsLeapYear(1600));
            Assert.True(birthdayHelper.IsLeapYear(2400));
            Assert.True(birthdayHelper.IsLeapYear(400));
        }

        [Fact]
        public void YearDiviedBy100ButNot400AreNotLeapYears()
        {
            BirthdayHelper birthdayHelper = new BirthdayHelper();
            Assert.False(birthdayHelper.IsLeapYear(1900));
            Assert.False(birthdayHelper.IsLeapYear(1700));
            Assert.False(birthdayHelper.IsLeapYear(2100));
            Assert.False(birthdayHelper.IsLeapYear(2700));
            Assert.False(birthdayHelper.IsLeapYear(300));

        }
    }
}
