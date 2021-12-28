
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement radioButton;

    static void Main()
    {
        //Variables
        string url = "https://testing.todorvachev.com/radio-button-test/";
        string[] option = { "1", "3", "5" };

        //Navigation
        driver.Navigate().GoToUrl(url);


        for (int i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + option[i] + ")"));

            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The " + (i + 1) + " radio button is checked.");
            }
            else
            {
                Console.WriteLine("The " + (i + 1) + " radio button is one of the unchecked radio buttons.");
            }
        }

        //PostCondition
        driver.Quit();

    }
}

