using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Linq;

namespace FacebookSignup
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterInValidEmail();
        }

        // User entering valid password
        static void EnterInValidEmail()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://www.facebook.com/r.php";

                var first_Name = driver.FindElement(By.Name("firstname"));
                first_Name.SendKeys("John");

                var last_Name = driver.FindElement(By.Name("lastname"));
                last_Name.SendKeys("Doe");

                var mobile_Number = driver.FindElement(By.Name("reg_email__"));
                mobile_Number.SendKeys("ven123gmail.com");

                var password = driver.FindElement(By.Name("reg_passwd__"));
                password.SendKeys("P@ssw0rd");

                var dob = new SelectElement(driver.FindElement(By.Name("birthday_day")));
                dob.SelectByValue("1");

                var birthday_Month = new SelectElement(driver.FindElement(By.Name("birthday_month")));
                birthday_Month.SelectByValue("1");

                var birthday_Year = new SelectElement(driver.FindElement(By.Name("birthday_year")));
                birthday_Year.SelectByValue("2000");

                var Gender = driver.FindElement(By.CssSelector("input[type='radio'][value='2']"));
                Gender.Click();

                var signUpButton = driver.FindElement(By.Name("websubmit"));
                signUpButton.Click();

                var errorMessage = driver.FindElements(By.CssSelector(".uiMessage.error")).Select((x) => x.Text);

                if (errorMessage.Any())
                {
                    foreach (var message in errorMessage)
                    {
                        Console.WriteLine(message);
                    }
                    Console.WriteLine("This test is because it was able to prove.");
                }
                else
                {
                    Console.WriteLine("This test is failed because it was not able to prove.");
                }
                Console.ReadLine();
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
