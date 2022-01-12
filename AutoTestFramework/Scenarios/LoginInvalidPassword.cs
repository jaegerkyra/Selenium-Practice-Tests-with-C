namespace AutoTestFramework.Pages
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
 
    [Parallelizable]

    public class LoginInvalidPassword
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases(Driver);
        }

        [Test]
        public void LessThan5Chars()
        {
          
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.FourCharacters, 
                Config.Credentials.Invalid.Password.FourCharacters, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();

        }
        

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters, Driver);

            alert = Driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }
        
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
