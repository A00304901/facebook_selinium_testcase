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
            Enter_InValid_Email();
            EmptyField_Testcase_prove();
        }

        // User entering valid password
        static void Enter_InValid_Email()
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
                    Console.WriteLine("This test has failed because it was able to find an error message.");
                }
                else
                {
                    Console.WriteLine("This test has passed because it was able to find error.");
                }
                Console.ReadLine();
            }
            finally
            {
                driver.Quit();
            }
        }
         static void Enter_InValid_password()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://www.facebook.com/r.php";

                var first_Name = driver.FindElement(By.Name("firstname"));
                first_Name.SendKeys("Jacky");

                var last_Name = driver.FindElement(By.Name("lastname"));
                last_Name.SendKeys("Doe");

                var mobile_Number = driver.FindElement(By.Name("reg_email__"));
                mobile_Number.SendKeys("jacky@gmail.com");

                var password = driver.FindElement(By.Name("reg_passwd__"));
                password.SendKeys("Password");

                var dob = new SelectElement(driver.FindElement(By.Name("birthday_day")));
                dob.SelectByValue("2");

                var birthday_Month = new SelectElement(driver.FindElement(By.Name("birthday_month")));
                birthday_Month.SelectByValue("10");

                var birthday_Year = new SelectElement(driver.FindElement(By.Name("birthday_year")));
                birthday_Year.SelectByValue("1999");

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
                    Console.WriteLine("This test has failed because it was able to find an error message.");
                }
                else
                {
                    Console.WriteLine("This test has passed because it was able to find error.");
                }
                Console.ReadLine();
            }
            finally
            {
                driver.Quit();
            }
        }

        //2nd test case below
        //Created by entering last name
        static void EmptyField_Testcase_prove()
        {
            var driver = new EdgeDriver();
            try
            {
                driver.Url = "https://www.facebook.com/r.php";

                var lastName = driver.FindElement(By.Name("lastname"));
                lastName.SendKeys("");

                var signUpButton = driver.FindElement(By.CssSelector("button[name='websubmit']"));
                signUpButton.Click();

                var errorMessage = driver.FindElements(By.CssSelector(".uiBoxRed")).Count > 0;

            if (!string.IsNullOrEmpty(lastName.GetAttribute("value")) && !errorMessage)
            {
                Console.WriteLine("Test case: Empty Last Name - fail");
            }
            else
            {
                Console.WriteLine("Test case: Empty Last Name - pass");
            }
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
