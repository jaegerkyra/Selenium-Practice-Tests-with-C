
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        //setup variables
        string url = "http://testing.todorvachev.com/selectors/class-name/";
        string className = "testClass";

        //Preconditions: initialize webdriver and navigate to link
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        //test
        IWebElement element = driver.FindElement(By.ClassName(className));

        Console.WriteLine(element.Text);

        //output result message
        //if (element.displayed)
        //{
        //    passmessage("element id was diplayed.");
        //}
        //else
        //{
        //    failmessage("element id was not displayed");
        //}

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
