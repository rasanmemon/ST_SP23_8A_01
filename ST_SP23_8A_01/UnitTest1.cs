using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ST_SP23_8A_01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, Description("This is demo test")]
        [TestCategory("Login"), TestCategory("Smoke")]
        [Owner("Usman")]
        [WorkItem(1223)]
        [Priority(2)]
        public void TestMethod1()
        {
        }
        [TestMethod]
        [DataRow("AmirImam","AmirImam")]
        [DataRow("invalid", "invalid123")]
        [DataRow("", "")]
        [DataRow("@#$@#$", "@##$")]
        public void Login_ValidUserValidPass(string user,string pass)
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Url = "https://adactinhotelapp.com/";

            //driver.FindElement(By.Id("username")).SendKeys(user);
            //driver.FindElement(By.Name("password")).SendKeys(pass);
            //driver.FindElement(By.ClassName("login_button")).Click();
            //string message = driver.FindElement(By.ClassName("welcome_menu")).Text;
            //Assert.AreEqual("Welcome to Adactin Group of Hotels", message);
            //Thread.Sleep(5000);
            //driver.Close();

            LoginPage loginPage = new LoginPage();
            loginPage.Login("https://adactinhotelapp.com/",user,pass);
        }
        [TestMethod]
        public void Login_InvalidUserInvalidPass()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            driver.FindElement(By.Id("username")).SendKeys("invalid");
            driver.FindElement(By.Name("password")).SendKeys("invalid123");
            driver.FindElement(By.ClassName("login_button")).Click();

            //string message = driver.FindElement(By.ClassName("welcome_menu")).Text;
            //Assert.AreEqual("Welcome to Adactin Group of Hotels", message);
            Thread.Sleep(5000);
            driver.Close();
        }
    }

    
}
