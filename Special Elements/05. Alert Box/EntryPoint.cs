
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{

    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;
    static IWebElement image;

    static void Main()
    {
        //Variables
        string url = "https://testing.todorvachev.com/alert-box/";

        //Navigation
        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("The alert was successfully accepted and image is showing.");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Something went wrong");
        }


        Thread.Sleep(3000);


        //PostCondition
        driver.Quit();

    }
}


