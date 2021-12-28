
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        //Variables
        string url = "https://testing.todorvachev.com/check-button-test-3/";
        string option = "1";

        //Navigation
        driver.Navigate().GoToUrl(url);

        //Check first checkbox
        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));

        //Click checkbox
        checkBox.Click();

        Thread.Sleep(3000);


        //This checks if a checkbox is checked
        /*if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The checkbox is checked.");
        }
        else
        {
            Console.WriteLine("The checkbox is not checked.");
        }*/

        //This checks value of checkbox
        //Console.WriteLine(checkBox.GetAttribute("value"));


        //PostCondition
        driver.Quit();

    }
}

