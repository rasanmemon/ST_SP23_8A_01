using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ST_SP23_8A_01
{
    [TestClass]
    public class LoginPage
    {
        public void Login(string url,string user,string pass)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            driver.FindElement(By.Id("username")).SendKeys("AmirImam");
            driver.FindElement(By.Name("password")).SendKeys("AmirImam");
            driver.FindElement(By.ClassName("login_button")).Click();
            string message = driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", message);
            Thread.Sleep(5000);
            driver.Close();
        }
        public void ForgotPassword() { }
        public void NewUserRegister() { }
    }
}
