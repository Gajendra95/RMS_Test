using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace UnitTest1
{
    [TestFixture]
    public class RMSTEST
    {


        [Test]
        public void FacultyPublication_test()

        {

            //string Url = "http://172.16.18.106/RMSStage/";
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);

            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--start-maximized");
            //driver = new ChromeDriver(options);

            string Url = "https://csd-test.manipal.edu/rmsstage/login.aspx";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            //string Url = "http://172.16.18.106/RMSStage";
            //IWebDriver driver = new ChromeDriver();


            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
            //driver.Url = "http://172.16.51.47/RMSPublish/Login.aspx";
            driver.FindElement(By.Id("TextBoxUid")).SendKeys("fassv4");
            driver.FindElement(By.Id("TextBoxPassword")).SendKeys("mubop@123");
            //driver.FindElement(By.XPath(""))
            driver.FindElement(By.Id("btnlogin")).Click();
            Task.Delay(2000);


            var option = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListPublicationEntry"));
            var selectElement = new SelectElement(option);
            //System.Threading.Thread.Sleep(2000);
            selectElement.SelectByText("Journal Article");
            //Console.Read();
            Task.Delay(2000).Wait();
            //Actions builder = new Actions(driver);
            //builder.SendKeys(Keys.Enter);
            // _ = driver.SwitchTo().Alert();
            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtboxTitleOfWrkItem")).SendKeys("Karnataka");
            //Task.Delay(2000).Wait();

            var option2 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListMuCategory"));
            var selectoption = new SelectElement(option2);
            Task.Delay(4000).Wait();
            //System.Threading.Thread.Sleep(2000);
            selectoption.SelectByText("Book");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtboxTitleOfWrkItem")).SendKeys("Karnataka");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxAbstract")).SendKeys("One State Many Worlds");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxKeywords")).SendKeys("Places");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxDOINum")).SendKeys("171");
            Task.Delay(2000).Wait();

            var option3 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListhasProjectreference"));
            var select_option = new SelectElement(option3);
            //System.Threading.Thread.Sleep(2000);
            select_option.SelectByText("No");
            Task.Delay(2000).Wait();



            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnAddMU")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_EmployeeCodeBtn")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup']//tr//tr[2]//td[1]")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_EmployeeCodeBtn")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_affiliateSrch")).SendKeys("sreepathy");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnEmployeeSearch")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup']//td//td[1]")).Click();
            Task.Delay(2000).Wait();

            var author = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_isCorrAuth"));
            var select_author = new SelectElement(author);
            //System.Threading.Thread.Sleep(2000);
            select_author.SelectByText("No");
            Task.Delay(2000).Wait();

            var author1 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl02_AuthorType"));
            var select_author1 = new SelectElement(author1);
            //System.Threading.Thread.Sleep(2000);
            select_author1.SelectByIndex(1);
            Task.Delay(2000).Wait();

            var author2 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_AuthorType"));
            var select_author2 = new SelectElement(author2);
            //System.Threading.Thread.Sleep(2000);
            select_author2.SelectByIndex(2);
            Task.Delay(2000).Wait();

            var author3 = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Grid_AuthorEntry_ctl03_isCorrAuth"));
            var select_author3 = new SelectElement(author3);
            //System.Threading.Thread.Sleep(2000);
            select_author3.SelectByText("Yes");
            Task.Delay(2000).Wait();






            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_imageBkCbtn']")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup2']//tr//tr[2]//td[1]")).Click();
            Task.Delay(2000).Wait();

            //var element = driver.FindElement(By.Id("closeButton"));

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxVolume")).SendKeys("30");
            Task.Delay(2000).Wait();



            var month = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_DropDownListMonthJA"));
            var select_month = new SelectElement(month);
            //System.Threading.Thread.Sleep(2000);
            select_month.SelectByText("July");
            Task.Delay(2000).Wait();




            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnSave")).Click();
            Task.Delay(4000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxWorkItemSearch")).SendKeys("Karnataka");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_ButtonSearchPub")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_GridViewSearch_ctl02_BtnEdit")).Click();
            Task.Delay(2000).Wait();





            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_imageBkCbtn']")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//body//div[@id='commentpopup2']//tr//tr[2]//td[1]")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_TextBoxPageFrom")).SendKeys("1");
            Task.Delay(2000).Wait();



            driver.FindElement(By.Id("FileUploadPdf")).SendKeys("C:\\Users\\SOIS\\Downloads\\ADC_code.pdf");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_Buttonupload")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnFeedback")).Click();
            Task.Delay(4000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_TextBoxPageTo']")).SendKeys("2");
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//input[@id='ctl00_ContentPlaceHolder1_CheckboxIndexAgency_1']")).Click();
            Task.Delay(2000).Wait();



            driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_BtnFeedback")).Click();
            Task.Delay(2000).Wait();


            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept();
            Task.Delay(2000).Wait();






            //driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnfedbackexit")).Click();
            //Task.Delay(4000).Wait();

            driver.FindElement(By.Id("ctl00_Label3")).Click();
            Task.Delay(4000).Wait();                                                                  //Faculty Logout
            driver.Close();
        }
    }
}
