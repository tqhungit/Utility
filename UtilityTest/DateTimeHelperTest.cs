using Utility.Helpers;

namespace UtilityTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StartDate_GreaterThan_EndDate_NoBusinessDay()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 01), new DateTime(2022, 08, 25));
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void StartDate_Equal_EndDate_NoBusinessDay()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 01), new DateTime(2022, 09,01));
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void StartDate_LessThan_EndDate_OneDay_NoBusinessDay()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 01), new DateTime(2022, 09, 02));
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void StartDate_LessThan_EndDate_TwoDays_Return1Days()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 01), new DateTime(2022, 09, 03));
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void StartDateFriday_EndDateMonday_WeekendOnly_NoBusinessDay()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 02), new DateTime(2022, 09, 05));
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void StartDateSunday_EndDateSaturday_InTwoWeeks_ReturnValidDays()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 04), new DateTime(2022, 09,10));
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void StartDateSaturday_EndDateSunday_InTwoWeeks_ReturnValidDays()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 03), new DateTime(2022, 09, 11));
            Assert.AreEqual(result, 5);
        }


        [Test]
        public void StartDate_EndDate_WeekdayOnly_ReturnValidDays()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2022, 09, 04), new DateTime(2022, 09, 10));
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void StartDate_EndDate_InTwoWeeks_ReturnValidDays()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(2021, 09, 04), new DateTime(2021, 09, 18));
            Assert.AreEqual(result, 10);
        }

        
        [Test]
        public void StartDate_EndDate_VeryLongPeriod_ReturnValidDays()
        {
            var result = DateTimeHelper.GetBusinessDays(new DateTime(1900, 01, 01), new DateTime(2022, 09, 01));
            Assert.AreEqual(result, 32002);
        }
    }
}