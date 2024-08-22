using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MSTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IWebDriver driver;
        By googleSearchBar = By.Id("APjFqb");
        By googleButtonClick = By.Name("btnK");
        By resultGoogle = By.Id("_fl27ZqToJumrwbkPr_-wcQ_33");
        int tiempo = 3000;
        public UnitTest1()
        {
            driver= new ChromeDriver();
        }

        public void Dispose()
        {
            driver.Quit();
            driver.Dispose();
        }


        //[TestMethod]
        //public void Create_Get_ReturnCreateView()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl("https://localhost:7023/ClienteSql/Create");
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.Id("Cedula")).SendKeys("1754146676");
        //    driver.FindElement(By.Id("Nombres")).SendKeys("Steven");
        //    driver.FindElement(By.Id("Apellidos")).SendKeys("Ramirez");
        //    driver.FindElement(By.Id("FechaNacimiento")).SendKeys("22-12-002024T23:00");
        //    driver.FindElement(By.Id("Mail")).SendKeys("Steven@gmail.com");
        //    driver.FindElement(By.Id("Telefono")).SendKeys("0980180542");
        //    driver.FindElement(By.Id("Direccion")).SendKeys("Pintag");
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.Id("btn")).Click();
        //    driver.FindElement(By.XPath("//a[@href='/ClienteSql/Delete/6'][@title='Eliminar']")).Click();
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.Id("eliminar")).Click();
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.XPath("//a[@href='/ClienteSql/Edit/11'][@title='Editar']")).Click();
        //    driver.FindElement(By.Id("Nombres")).Clear();
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.Id("Nombres")).SendKeys("Juan Jose");
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.Id("editar")).Click();
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.XPath("//a[text()='Crear Nuevo Cliente']")).Click();
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.Id("Cedula")).SendKeys("1754146676");
        //    driver.FindElement(By.Id("Nombres")).SendKeys("Luis");
        //    driver.FindElement(By.Id("Apellidos")).SendKeys("Ramirez");
        //    driver.FindElement(By.Id("FechaNacimiento")).SendKeys("22-12-002024T23:00");
        //    driver.FindElement(By.Id("Mail")).SendKeys("Steven@gmail.com");
        //    driver.FindElement(By.Id("Telefono")).SendKeys("0980180542");
        //    driver.FindElement(By.Id("Direccion")).SendKeys("Pintag");
        //    Thread.Sleep(tiempo);
        //    driver.FindElement(By.Id("btn")).Click();
        //}



        [TestMethod]
        public void Create_Get_ReturnCreateView()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:7023/ClienteSql/Create");
            Thread.Sleep(tiempo);
            driver.FindElement(By.Id("Cedula")).SendKeys("1754146676");
            driver.FindElement(By.Id("Nombres")).SendKeys("Steven");
            driver.FindElement(By.Id("Apellidos")).SendKeys("Ramirez");
            driver.FindElement(By.Id("FechaNacimiento")).SendKeys("22-12-002024T23:00");
            driver.FindElement(By.Id("Mail")).SendKeys("Steven@gmail.com");
            driver.FindElement(By.Id("Telefono")).SendKeys("0980180542");
            driver.FindElement(By.Id("Direccion")).SendKeys("Pintag");
            Thread.Sleep(tiempo);
            driver.FindElement(By.Id("btn")).Click();
            driver.FindElement(By.XPath("//a[@href='/ClienteSql/Delete/6'][@title='Eliminar']")).Click();
            Thread.Sleep(tiempo);
            driver.FindElement(By.Id("eliminar")).Click();
            Thread.Sleep(tiempo);
            driver.FindElement(By.XPath("//a[@href='/ClienteSql/Edit/11'][@title='Editar']")).Click();
            driver.FindElement(By.Id("Nombres")).Clear();
            Thread.Sleep(tiempo);
            driver.FindElement(By.Id("Nombres")).SendKeys("Juan Jose");
            Thread.Sleep(tiempo);
            driver.FindElement(By.Id("editar")).Click();
            Thread.Sleep(tiempo);
            driver.FindElement(By.XPath("//a[text()='Crear Nuevo Cliente']")).Click();
            Thread.Sleep(tiempo);
            driver.FindElement(By.Id("Cedula")).SendKeys("1754146676");
            driver.FindElement(By.Id("Nombres")).SendKeys("Luis");
            driver.FindElement(By.Id("Apellidos")).SendKeys("Ramirez");
            driver.FindElement(By.Id("FechaNacimiento")).SendKeys("22-12-002024T23:00");
            driver.FindElement(By.Id("Mail")).SendKeys("Steven@gmail.com");
            driver.FindElement(By.Id("Telefono")).SendKeys("0980180542");
            driver.FindElement(By.Id("Direccion")).SendKeys("Pintag");
            Thread.Sleep(tiempo);
            driver.FindElement(By.Id("btn")).Click();
        }
    }
}