
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            PassMessage("Element myName is displayed.");
        }
        else
        {
            FailMessage("Element myName is not displayed.");
        }

        driver.Quit();
    }

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
