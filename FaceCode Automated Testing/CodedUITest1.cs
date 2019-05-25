using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace FaceCode
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
          
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {

       


            ApplicationUnderTest.Launch(@"E:\faceCode\curfew\curfew\bin\Debug\curfew.exe");

            WinWindow MyParentLoginWindow = new WinWindow();
            MyParentLoginWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Create Account";

            WinWindow CreateAccountWindow = new WinWindow(MyParentLoginWindow);
            CreateAccountWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "txttext";

            WinText CreateAccountButton = new WinText(CreateAccountWindow);
            CreateAccountButton.SearchProperties[WinText.PropertyNames.ControlType] = "Text";


            Mouse.Click(CreateAccountButton);

            WinWindow RegistrationWindow = new WinWindow();
            RegistrationWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Registration";

            WinWindow FirstnameWindow = new WinWindow(RegistrationWindow);
            FirstnameWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "firstname";

            WinEdit FirstnameWinEdit = new WinEdit(FirstnameWindow);
            FirstnameWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(FirstnameWinEdit, "Shiela Anne");

            WinWindow LastnameWindow = new WinWindow(RegistrationWindow);
            LastnameWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "lastname";

            WinEdit LastnameWinEdit = new WinEdit(LastnameWindow);
            LastnameWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(LastnameWinEdit, "Llena");

            WinWindow UsernameWindow = new WinWindow(RegistrationWindow);
            UsernameWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "username";

            WinEdit UsernameWinEdit = new WinEdit(UsernameWindow);
            UsernameWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(UsernameWinEdit, "admin");

            WinWindow PasswordWindow = new WinWindow(RegistrationWindow);
            PasswordWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "password";

            WinEdit PasswordEdit = new WinEdit(PasswordWindow);
            PasswordEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(PasswordEdit, "admin");

            WinWindow ConfirmPasswordWindow = new WinWindow(RegistrationWindow);
            ConfirmPasswordWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "confirmpass";

            WinEdit ConfirmPasswordEdit = new WinEdit(ConfirmPasswordWindow);
            ConfirmPasswordEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(ConfirmPasswordEdit, "admin");

            WinWindow CreateButtonWindow = new WinWindow(RegistrationWindow);
            CreateButtonWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "create";

            WinText CreateButton = new WinText(CreateButtonWindow);
            CreateButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Text";

            Mouse.Click(CreateButton);
            Keyboard.SendKeys("{F4}", ModifierKeys.Alt);

            WinWindow LoginWindow = new WinWindow();
            LoginWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Login";

            WinWindow UserNameWindow = new WinWindow(LoginWindow);
            UserNameWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "username";

            WinEdit UserNameWinEdit = new WinEdit(UserNameWindow);
            UserNameWinEdit.SearchProperties[WinClient.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(UserNameWinEdit, "admin");

            WinWindow Password1Window = new WinWindow(LoginWindow);
            Password1Window.SearchProperties[WinWindow.PropertyNames.ControlName] = "Password";

            WinEdit Password1WinEdit = new WinEdit(Password1Window);
            Password1WinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(Password1WinEdit, "admin");

            WinWindow LoginButtonWindow = new WinWindow(LoginWindow);
            LoginButtonWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "signinbtn";

            WinText LoginButton = new WinText(LoginButtonWindow);
            LoginButton.SearchProperties[WinText.PropertyNames.ControlType] = "Text";

            Mouse.Click(LoginButton);

            WinWindow Desktop = new WinWindow();
            Desktop.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Desktop 1";

            WinWindow AddOffenderButton = new WinWindow(Desktop);
            AddOffenderButton.SearchProperties[WinWindow.PropertyNames.ControlName] = "resaddbtn";

            WinClient AddOffenderWinClient = new WinClient(AddOffenderButton);
            AddOffenderWinClient.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";

            Mouse.Click(AddOffenderWinClient);

            WinWindow SlideShow = new WinWindow(Desktop);
            SlideShow.SearchProperties[WinWindow.PropertyNames.ControlName] = "bunifuiOSSwitch1";

            WinClient SlideshowWinClient = new WinClient(SlideShow);
            SlideshowWinClient.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";

            Mouse.Click(SlideshowWinClient);


            WinWindow FirstName = new WinWindow(Desktop);
            FirstName.SearchProperties[WinWindow.PropertyNames.ControlName] = "fname";

            WinEdit FirstNameWinEdit = new WinEdit(FirstName);
            FirstNameWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(FirstNameWinEdit, "Jerico");

            WinWindow LastName = new WinWindow(Desktop);
            LastName.SearchProperties[WinWindow.PropertyNames.ControlName] = "lname";

            WinEdit LastNameWinEdit = new WinEdit(LastName);
            LastNameWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(LastNameWinEdit, "Tilacas");

            //this.UIMap.RecordedMethod1();


            WinWindow Birthdate = new WinWindow(Desktop);
            Birthdate.SearchProperties[WinWindow.PropertyNames.ControlName] = "DOB";

            WinEdit BirthdateWinEdit = new WinEdit(Birthdate);
            BirthdateWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "DateTimePicker";
            Keyboard.SendKeys(BirthdateWinEdit, "12-08-1998");
            this.UIMap.Gender();

            WinWindow Address = new WinWindow(Desktop);
            Address.SearchProperties[WinWindow.PropertyNames.ControlName] = "address";

            WinEdit AddressWinEdit = new WinEdit(Address);
            AddressWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(AddressWinEdit, "Poblacion Pardo");

            WinWindow Contact = new WinWindow(Desktop);
            Contact.SearchProperties[WinWindow.PropertyNames.ControlName] = "contact";

            WinEdit ContactWinEdit = new WinEdit(Contact);
            ContactWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

            Keyboard.SendKeys(ContactWinEdit, "09064125140");

            WinWindow CaptureFace = new WinWindow(Desktop);
            CaptureFace.SearchProperties[WinWindow.PropertyNames.ControlName] = "capturebtn";

            WinClient CaptureWinClient = new WinClient(CaptureFace);
            CaptureWinClient.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";

            Mouse.Click(CaptureWinClient);

            WinWindow RecordFace = new WinWindow();
            RecordFace.SearchProperties[WinWindow.PropertyNames.Name] = "recordFaceFrm";

            WinWindow CapturePhoto = new WinWindow(RecordFace);
            CapturePhoto.SearchProperties[WinWindow.PropertyNames.ControlName] = "bunifuImageButton1";

            WinClient CapturePhotoButton = new WinClient(CapturePhoto);
            CapturePhotoButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";

            Mouse.Click(CapturePhotoButton);
            Playback.Wait(5000);
            Keyboard.SendKeys("{F4}", ModifierKeys.Alt);

            WinWindow SaveWinWindow = new WinWindow(Desktop);
            SaveWinWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "sendbtn";

            WinClient SaveButton = new WinClient(SaveWinWindow);
            SaveButton.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";

            Mouse.Click(SaveButton);
            Playback.Wait(5000);
            Keyboard.SendKeys("{F4}", ModifierKeys.Alt);

            WinWindow RecognizeIcon = new WinWindow(Desktop);
            RecognizeIcon.SearchProperties[WinWindow.PropertyNames.ControlName] = "recordbtn";

            WinClient RecognizeWinClient = new WinClient(RecognizeIcon);
            RecognizeWinClient.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";

            Mouse.Click(RecognizeWinClient);

            WinWindow Recognize = new WinWindow();
            Recognize.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Recognize";

            WinWindow RecognizeButton = new WinWindow(Recognize);
            RecognizeButton.SearchProperties[WinWindow.PropertyNames.ControlName] = "recognizebtn";

            WinText RecognizeButtonWinText = new WinText(RecognizeButton);
            RecognizeButtonWinText.SearchProperties[WinText.PropertyNames.ControlType] = "Text";

            Mouse.Click(RecognizeButtonWinText);

         

            WinWindow OffenderInfo = new WinWindow();
            OffenderInfo.SearchProperties[WinWindow.PropertyNames.Name] = "Offender Information";

            WinWindow NotifyParentWindow = new WinWindow(OffenderInfo);
            NotifyParentWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "notify";

            WinText NotifyParentButton = new WinText(NotifyParentWindow);
            NotifyParentButton.SearchProperties[WinText.PropertyNames.ControlType] = "Text";

            Mouse.Click(NotifyParentButton);
            Playback.Wait(5000);
            Keyboard.SendKeys("{F4}", ModifierKeys.Alt);


            WinWindow PrintWindow = new WinWindow(OffenderInfo);
            PrintWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "print";

            WinText PrintButton = new WinText(PrintWindow);
            PrintButton.SearchProperties[WinText.PropertyNames.ControlType] = "Text";

            Mouse.Click(PrintButton);
            Playback.Wait(5000);
            Keyboard.SendKeys("{F4}", ModifierKeys.Alt);

            WinWindow RecordIcon = new WinWindow(Desktop);
            RecordIcon.SearchProperties[WinWindow.PropertyNames.ControlName] = "bunifuFlatButton1";

            WinClient RecordWinClient = new WinClient(RecordIcon);
            RecordWinClient.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";

            Mouse.Click(RecordWinClient);
        

            /**  WinWindow SearchBox = new WinWindow(Desktop);
                 SearchBox.SearchProperties[WinWindow.PropertyNames.ControlName] = "searchBox";

                 WinEdit SearchBOxWinEdit = new WinEdit(SearchBox);
                 SearchBOxWinEdit.SearchProperties[WinEdit.PropertyNames.ControlType] = "Edit";

                 Keyboard.SendKeys(SearchBOxWinEdit, "Jerico");

                 WinWindow Search = new WinWindow(Desktop);
                 Search.SearchProperties[WinWindow.PropertyNames.ControlName] = "searchBtn";

                 WinText SearchButton = new WinText(Search);
                 SearchButton.SearchProperties[WinText.PropertyNames.ControlType] = "Text";

                 Mouse.Click(SearchButton);**/

            this.UIMap.PrintRecord();
          //  this.UIMap.logout2();
            //  this.UIMap.logout();
            //  this.UIMap.search();


             
              WinWindow logoutwindow = new WinWindow();
              logoutwindow.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "  Logout";
            
               WinWindow logoutbutton = new WinWindow(logoutwindow);
               logoutbutton.SearchProperties[WinWindow.PropertyNames.ControlName] = "bunifuFlatButton2";

               WinClient logout = new WinClient(logoutbutton);
               logout.SearchProperties[WinClient.PropertyNames.ControlType] = "Client";
               Mouse.Click(logout);
               Keyboard.SendKeys("{F4}", ModifierKeys.Alt);
            /**    WinWindow yesbutton = new WinWindow();
                yesbutton.SearchProperties[WinWindow.PropertyNames.Name] = "Yes";

                WinWindow yes = new WinWindow(yesbutton);
                yes.SearchProperties[WinWindow.PropertyNames.ControlName] = "";

                WinClient UIYes = new WinClient(yes);
                UIYes.SearchProperties[WinClient.PropertyNames.ControlType] = "Button";
                Mouse.Click(UIYes);**/


            Playback.Wait(5000);


        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
