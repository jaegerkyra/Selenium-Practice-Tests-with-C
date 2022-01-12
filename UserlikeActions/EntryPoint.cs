﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        string url = "https://testing.todorvachev.com/draganddrop/draganddrop.html";
        

        driver.Navigate().GoToUrl(url);

        string[] elementIDs =
        {
            "Drag1",
            "Drag2",
            "Drag3",
            "Drag4",
            "Drag5",
        };

        IWebElement[] elements =
        {
            driver.FindElement(By.Id(elementIDs[0])),
            driver.FindElement(By.Id(elementIDs[1])),
            driver.FindElement(By.Id(elementIDs[2])),
            driver.FindElement(By.Id(elementIDs[3])),
            driver.FindElement(By.Id(elementIDs[4]))
        };

        //Actions actions = new Actions(driver);

        //string lightGreen = "rgba(144, 238, 144, 1)";
        //actions.MoveToElement(elements[0]).Build().Perform();
        //Console.WriteLine(elements[0].GetCssValue("background-color") == lightGreen);     

        MoveElement(new Actions(driver), elements[0], elements[1], 0, 10);
        Thread.Sleep(1000);
        MoveElement(new Actions(driver), elements[0], elements[2], 0, 10);
        Thread.Sleep(1000);
        MoveElement(new Actions(driver), elements[4], elements[1], 0, 10);
    }

    static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 0)
    {
        actions.ClickAndHold(from)
            .MoveToElement(to)
            .MoveByOffset(x, y)
            .Release()
            .Build()
            .Perform();
    }
}

