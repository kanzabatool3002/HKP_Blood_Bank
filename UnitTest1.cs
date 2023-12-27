using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using NUnit.Framework;


namespace BloodBankManagementSystem_test
{
    [TestFixture]
    public class LoginTests
    {
        [Test]
        public void LoginCheck_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            loginDAL dal = new loginDAL();
            loginBLL loginInfo = new loginBLL
            {
                username = "kanza",
                password = "kanza123"
            };

            // Act
            bool isSuccess = dal.loginCheck(loginInfo);

            // Assert
            Assert.IsTrue(isSuccess, "Login check should return true for valid credentials.");
        }

        [Test]
        public void LoginCheck_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            loginDAL dal = new loginDAL();
            loginBLL loginInfo = new loginBLL
            {
                username = "jia",
                password = "jia123"
            };

            // Act
            bool isSuccess = dal.loginCheck(loginInfo);

            // Assert
            Assert.IsFalse(isSuccess, "Login check should return false for invalid credentials.");
        }
    }

}