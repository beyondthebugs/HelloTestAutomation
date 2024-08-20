using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

public class Program
{
    private static object passwordTextbox;

    private static void Main(string[] args)
    {
        //Open Edge browser
        IWebDriver driver = new EdgeDriver();
        // Launch TurnUp portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        driver.Manage().Window.Maximize();
        //Identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");
        //Identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");
        //Identify login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        //Check if user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if(helloHari.Text=="Hello hari!")
        {
            Console.WriteLine("User has logged in successfully. Test passed!");
        }
        else
        {
            Console.WriteLine("User has not logged in. Test failed!");
        }
    }
}