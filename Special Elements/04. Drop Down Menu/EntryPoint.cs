
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropDownMenu;

    static void Main()
    {
        //Variables
        string url = "https://testing.todorvachev.com/drop-down-menu-test/";
        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        //Navigation
        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine("The selected value is : " + dropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        Console.WriteLine("The third option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu.Click();

        Console.WriteLine("The selected value is : " + dropDownMenu.GetAttribute("value"));
        Thread.Sleep(3000);

        for (int i = 1; i <= 4; i++)
        {
            dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";

            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine("The " + i + " option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
        }

        Thread.Sleep(5000);

        //PostCondition
        driver.Quit();

    }
}
