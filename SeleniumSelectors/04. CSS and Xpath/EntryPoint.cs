
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        //setup variables
        string url = "http://testing.todorvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";


        //Preconditions: initialize webdriver and navigate to link
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        //test
        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        if (cssPathElement.Displayed)
        {
            PassMessage("CSS Path Element is displayed.");
        }
        else
        {
            FailMessage("CSS Path Element is not displayed.");
        }

        if (xPathElement.Displayed)
        {
            PassMessage("XPath Element is displayed.");
        }
        else
        {
            FailMessage("XPath Element is not displayed.");
        }


        driver.Quit();

    }

    //methods for color console message for pass/fail
    private static void FailMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void PassMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
