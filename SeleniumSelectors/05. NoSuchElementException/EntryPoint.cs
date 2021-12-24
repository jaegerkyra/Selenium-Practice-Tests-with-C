
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        //setup variables
        string url = "http://testing.todorvachev.com/selectors/css-path/";

        //Intentionally broke selector to get a fail and work with No Such Element Exception
        string cssPath = "#post-108 > div > figure eareadskfhdsjhalskdjfhal img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";


        //Preconditions: initialize webdriver and navigate to link
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);


        //test
        IWebElement cssPathElement;
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));


        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));

            if (cssPathElement.Displayed)
            {
                PassMessage("CSS Path Element is displayed.");
            }

        }
        catch (NoSuchElementException)
        {
            FailMessage("CSS Path Element could not be found.");
        }


        //Result Messages

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
