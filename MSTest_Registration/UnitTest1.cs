using UserRegistration;
namespace MSTest_Registration
{
    [TestClass]
    public class UnitTest1
    {

        //UC1

        [TestMethod]
        public void FirstName()
        {
            //Arrange

            REGEX_Registration obj = new REGEX_Registration();

            bool expected = true;
            string FirstName = "Hemant";

            //Act
            bool var = obj.ValidateFirstName(FirstName);

            //Assert
            Assert.AreEqual(expected, var);
        }
        //UC2

        [TestMethod]
        public void LastName()
        {
            //Arrange

            REGEX_Registration obj = new REGEX_Registration();

            bool expected = true;
            string LastName = "Dhurve";

            //Act
            bool var = obj.ValidateFirstName(LastName);

            //Assert
            Assert.AreEqual(expected, var);
        }
    }
}