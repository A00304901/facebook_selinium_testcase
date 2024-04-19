using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Initialize ChromeDriver
        IWebDriver driver = new ChromeDriver();

        // Navigate to Facebook sign-up page
        driver.Navigate().GoToUrl("https://www.facebook.com/r.php");

        // Find the email input field
        IWebElement emailInput = driver.FindElement(By.Name("reg_email__"));

        // Enter an invalid email address
        emailInput.SendKeys("venuspate771gmail.com");

        // Find the sign-up button and click it
        IWebElement signUpButton = driver.FindElement(By.Name("websubmit"));
        signUpButton.Click();

        // Check if an error message is displayed for invalid email
       //nEW THINGS
        // Close the browser
        Thread.Sleep(TimeSpan.FromSeconds(10));
        driver.Quit();
    }
}
