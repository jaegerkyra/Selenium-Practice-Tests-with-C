
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        //Variables
        string url = "https://testing.todorvachev.com/text-input-field/";
        
        //Navigation
        driver.Navigate().GoToUrl(url);

        //Find username textbox
        textBox = driver.FindElement(By.Name("username"));

        //Enter test text
        textBox.SendKeys("Test text");


        Thread.Sleep(3000);

        //Deletes text in textBox
        //textBox.Clear();

        //Gets text from textBox
        //Console.WriteLine(textBox.GetAttribute("value"));

        //Gets max length from textBox
        Console.WriteLine(textBox.GetAttribute("maxlength"));

        Thread.Sleep(3000);



        //PostCondition
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

