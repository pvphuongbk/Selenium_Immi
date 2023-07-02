using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Immi
{
    public partial class Login : Form
    {
        private IWebDriver driver;
        private IWebDriver drivers;
        private WebDriverWait wait;
        private System.Media.SoundPlayer player;
        public Login()
        {
            InitializeComponent();
            btn_CanhTrangthai.ForeColor = Color.Gray;
            var path = System.AppDomain.CurrentDomain.BaseDirectory + $"amthanh//file_example_WAV_10MG.wav";
            player = new System.Media.SoundPlayer(path);
        }

        private void Run()
        {
            try
            {
                Login1();
                ChoseApp();
                Step1();
                Step2();
                Step3();
                Step4();
                Thread.Sleep(1000);
                Thread.Sleep(10000);
            }
            catch
            {
                Run();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                driver = new ChromeDriver();
                wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
                Run();
            }
            catch
            {
            }
            finally
            {
                driver.Close();
            }

        }

        private void PhatLoa()
        {
            player.Play();
        }
        private void Login1()
        {
            //driver.Navigate().GoToUrl("https://online.immi.gov.au/lusc/login");
            //var familyname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div/div[1]/div[1]/div/input")));
            //familyname.SendKeys("Pham");
            string username = "mr.phuongbk@gmail.com";
            string password = "Sieunhanmin123";
            if (!string.IsNullOrEmpty(txt_userName.Text) && !string.IsNullOrEmpty(txt_password.Text))
            {
                username = txt_userName.Text;
                password = txt_password.Text;
            }

            driver.Navigate().GoToUrl("https://online.immi.gov.au/lusc/login");
            driver.FindElements(By.Id("username"))[0].SendKeys(username);


            driver.FindElements(By.Id("password"))[0].SendKeys(password);
            //driver.FindElements(By.Id("password"))[0].SendKeys("Sieunhanmin123");
            driver.FindElements(By.Name("login"))[0].Click();
        }

        private void ChoseApp()
        {
            var element1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("continue")));
            element1.Click();
            driver.Navigate().GoToUrl("https://online.immi.gov.au/ola/app");
            var element2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/section/div/div/div[1]/div/div/div[1]/div/div/div/div[1]/button/span")));
            element2.Click();
            Thread.Sleep(1000);
            var element3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/section/div/div/div[2]/div/div[1]/div/div/div[17]/button/i")));
            Thread.Sleep(1000);
            element3.Click();
            Thread.Sleep(1000);
            // chọn 462
            var element4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/section/div/div/div[2]/div/div[1]/div/div/div[17]/div/button[2]/span")));
            element4.Click();
        }
        private void Step1()
        {
            driver.Navigate().GoToUrl("https://online.immi.gov.au/elp/app?action=new&formId=WHV-AP-462");
            var element5 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[3]/div/div/div[2]/span")));
            element5.Click();

            var element6 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[6]/div/div/div/div[2]/button")));
            element6.Click();
        }
        private void Step2()
        {
            driver.Navigate().GoToUrl("https://online.immi.gov.au/elp/app");

            var country = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[2]/div/div[3]/div/div/div[2]/span/select")));
            var selectElement1 = new SelectElement(country);
            // Current location
            selectElement1.SelectByValue("VIET");

            var legal = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[2]/span/select")));
            var selectElement2 = new SelectElement(legal);
            // Legal status
            selectElement2.SelectByText("Citizen");
            // Current application      No - No
            var radio1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[4]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio1.Click();

            var radio2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[5]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio2.Click();
            //Application Type   No
            var radio3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[9]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[1]/input")));
            radio3.Click();

            var radio4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[10]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio4.Click();
            //Proposed arrival date
            var time = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[17]/div/div/div[2]/div/div/div[1]/div/input")));
            time.SendKeys(DateTime.Now.AddMonths(3).ToString("dd MMM yyyy"));
            //Government support  - No
            var radio5 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[19]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio5.Click();
            // Next
            var next1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[6]/div/div/div/div[2]/button")));
            next1.Click();
        }

        private void Step3()
        {
            #region Online Lodgement  3
            // Family name
            var familyname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[6]/div/div[1]/div/div[1]/div/div/div[2]/div/div/div[1]/span/input")));
            familyname.SendKeys("Pham");
            //Given names
            var givennames = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[6]/div/div[1]/div/div[2]/div/div/div[2]/div/div/div[1]/span/input")));
            givennames.SendKeys("Van Phuong");
            // Sex
            var sex = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[6]/div/div[2]/div/div/div[2]/fieldset/div/label[2]/input")));
            sex.Click();
            //Date of birth
            var dateofbirth = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[6]/div/div[3]/div/div/div[2]/div/input")));
            dateofbirth.SendKeys("04 Jul 1991");

            var passportnumber = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[7]/div/div[1]/div/div/div[2]/span/input")));
            passportnumber.SendKeys("011112");

            //Country of passport
            var countrypassport = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[7]/div/div[2]/div/div/div[2]/span/select")));
            var selectElementCountrypassport = new SelectElement(countrypassport);
            selectElementCountrypassport.SelectByText("VIET NAM - VNM");

            //Nationality of passport holder
            var nationalityHolder = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[7]/div/div[3]/div/div/div[2]/span/select")));
            var selectnationalityHolder = new SelectElement(nationalityHolder);
            selectnationalityHolder.SelectByText("VIET NAM - VNM");

            //Date of issue
            var dateofissue = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[7]/div/div[4]/div/div/div[2]/div/input")));
            dateofissue.SendKeys(DateTime.Now.AddYears(-1).ToString("dd MMM yyyy"));
            var Dateofexpiry = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[7]/div/div[5]/div/div/div[2]/div/input")));
            //Date of expiry
            Dateofexpiry.SendKeys(DateTime.Now.AddYears(1).ToString("dd MMM yyyy"));

            //Place of issue / issuing authority
            var issuingauthority = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[7]/div/div[7]/div/div/div[2]/span/input")));
            issuingauthority.SendKeys("Viet nam");

            //National identity card  yes
            var radio7 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[9]/div/div[2]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[1]/input")));
            radio7.Click();

            // if radio7 yes
            var buttonAdd = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[9]/div/div[7]/div/button")));
            buttonAdd.Click();
            var cardFname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div[1]/div/div[3]/div/div[1]/div/div/div[2]/div/div/div[1]/span/input")));
            cardFname.SendKeys("Pham");
            var cardGname = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div[1]/div/div[3]/div/div[2]/div/div/div[2]/div/div/div[1]/span/input")));
            cardGname.SendKeys("Van Phuong");
            var cardId = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div[1]/div/div[4]/div/div/div[2]/span/input")));
            cardId.SendKeys("12345678");
            var carCountry = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div[1]/div/div[5]/div/div/div[2]/span/select")));
            var SelectcarCountry = new SelectElement(carCountry);
            SelectcarCountry.SelectByText("VIETNAM");
            var Carddateofissue = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div[1]/div/div[7]/div/div/div[2]/div/input")));
            Carddateofissue.SendKeys(DateTime.Now.AddYears(-2).ToString("dd MMM yyyy"));
            var CarddateofExpire = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div[1]/div/div[8]/div/div/div[2]/div/input")));
            CarddateofExpire.SendKeys(DateTime.Now.AddYears(2).ToString("dd MMM yyyy"));
            var confirm = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div[2]/div/div/div[2]/button")));
            confirm.Click();


            //Town / City
            var townCity = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[10]/div/div[2]/div/div/div[2]/span/input")));
            townCity.SendKeys("Thanh Hoa");

            //State / Province
            var Province = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[10]/div/div[3]/div/div/div[2]/span/input")));
            Province.SendKeys("Thanh Hoa");

            //Country of birth
            var Countryofbirth = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[10]/div/div[4]/div/div/div[2]/div/div/div[1]/span/select")));
            var SelectCountryofbirth = new SelectElement(Countryofbirth);
            SelectCountryofbirth.SelectByText("VIETNAM");

            //Relationship status
            var Relationshipstatus = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[12]/div/div[2]/div/div/div[2]/div/div/div[1]/span/select")));
            var SelectRelationshipstatus = new SelectElement(Relationshipstatus);
            SelectRelationshipstatus.SelectByText("Married");


            //Other names / spellings  No
            var radio21 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[13]/div/div[2]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio21.Click();
            //Citizenship  Yes  No  (No)
            var radio22 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[14]/div/div[2]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[1]/input")));
            radio22.Click();
            var radio23 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[14]/div/div[3]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio23.Click();
            //var radio24 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[14]/div/div[6]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[1]/input")));
            //radio24.Click();
            //Other passports  No
            var radio25 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[15]/div/div[2]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio25.Click();
            //Other identity documents  No
            var radio26 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[16]/div/div[2]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio26.Click();
            //Health examination  No
            var radio27 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[19]/div/div[2]/div/div[2]/div[2]/div/div/div[1]/fieldset/div/label[2]/input")));
            radio27.Click();


            //next
            var next2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[6]/div/div/div/div[2]/button")));
            next2.Click();
            #endregion
        }


        private void Step4()
        {
            var radio41 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[4]/div/div/div/div/div/div/div[10]/div/div/div[2]/div/div/div[1]/fieldset/div/label[1]/input")));
            radio41.Click();

            //next
            var next4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/form/div[1]/div/div/div[1]/section/div/div/div/div[6]/div/div/div/div[2]/button")));
            next4.Click();

            //PhatLoa();
            Console.ReadKey();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lb_canhbao.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhatLoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
        bool iscanh = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (btn_CanhTrangthai.Text == "Bắt đầu canh")
            {
                btn_CanhTrangthai.ForeColor = Color.Blue;
                btn_CanhTrangthai.Text = "Đang canh";

                lb_canhbao.Visible = true;
                lb_canhbao.Text = "";
                drivers = new ChromeDriver();
                iscanh = true;
                Thread thre = new Thread(Canh);
                thre.Start();

            }
            else
            {
                if (drivers != null)
                    drivers.Close();
                iscanh = false;
                btn_CanhTrangthai.Text = "Bắt đầu canh";
                btn_CanhTrangthai.ForeColor = Color.Gray;
            }
        }

        private void Canh()
        {
            while (iscanh)
            {
                try
                {
                    RunCheckStatus();
                }
                catch
                {
                }
            }
        }

        private void RunCheckStatus()
        {
            bool isVietnam = false;
            drivers.Navigate().GoToUrl("https://immi.homeaffairs.gov.au/what-we-do/whm-program/status-of-country-caps?fbclid=IwAR2S-XAE0MzVMs62zwA2HCzZDeEfyVcA8S-1j_iiaqcJCPKjnR3jJoY79pc");

            IList<IWebElement> allElement = drivers.FindElements(By.TagName("td"));
            foreach (IWebElement element in allElement)
            {
                string cellText = element.Text;
                Console.WriteLine(cellText);

                if (isVietnam)
                {
                    SetText("Trạng thái đang là : " + cellText);
                    if (cellText == "OPEN")
                    {
                        lb_canhbao.ForeColor = Color.Blue;
                        PhatLoa();
                    }
                    else
                    {
                        lb_canhbao.ForeColor = Color.Red;
                    }

                    break;
                }

                if (cellText == "Vietnam") // Thailand  Vietnam
                    isVietnam = true;
            }
        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lb_canhbao.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lb_canhbao.Text = text;
            }
        }
    }
}
