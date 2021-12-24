
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/id/";
        string ID = "testImage";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(ID));

        if (element.Displayed)
        {
            PassMessage("Element ID was diplayed.");
        }
        else
        {
            FailMessage("Element ID was not displayed");
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

