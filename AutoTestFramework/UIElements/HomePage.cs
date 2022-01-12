
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        //Elements

        //Introduction Header
        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]

        //Create property
        public IWebElement Headline { get; set; }
    }
}
