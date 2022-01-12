
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace SeleniumScreenshot
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver chrome = new ChromeDriver();

            string screenshotsDirectory = Directory.GetCurrentDirectory() + @"\screenshots";

            chrome.Navigate().GoToUrl("http://google.com");

            Screenshot googleScreenshot = ((ITakesScreenshot)chrome).GetScreenshot();

            if (!Directory.Exists(screenshotsDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
            }

            googleScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshot.png", ScreenshotImageFormat.Png);

            //If you wanted to see where exactly screenshots were being saved to be default
            //System.Console.WriteLine(Directory.GetCurrentDirectory());


            chrome.Quit();
        }
    }
}
