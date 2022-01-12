using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{
    public class Menu
    {
        public Menu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Elements

        //Introduction Menu
        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement Introduction { get; set; }

        //Selectors Menu
        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement Selectors { get; set; }

        //Special Elements Menu
        [FindsBy(How = How.Id, Using = "menu-item-35")]
        public IWebElement SpecialElements { get; set; }

        //Test Cases Menu
        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement TestCases { get; set; }

        //Test Sceanarios Menu
        [FindsBy(How = How.Id, Using = "menu-item-58")]
        public IWebElement TestScenarios { get; set; }

        //About Menu
        [FindsBy(How = How.Id, Using = "menu-item-26")]
        public IWebElement About { get; set; }
    }
}
