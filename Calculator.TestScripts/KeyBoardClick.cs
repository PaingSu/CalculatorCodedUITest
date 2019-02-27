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
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;


namespace Calculator.TestScripts
{
    /// <summary>
    /// Summary description for KeyBoardClick
    /// </summary>
    [CodedUITest]
    public class KeyBoardClick
    {
        public KeyBoardClick()
        {
        }

        [TestMethod]
        public void KeyAdd()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("123");
            Keyboard.SendKeys("{Add}");
            Keyboard.SendKeys("450");
            Keyboard.SendKeys("{Enter}");
            Assert.AreEqual("573", txtResult.Text);
        }

        [TestMethod]
        public void KeySubtract()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("456");
            Keyboard.SendKeys("{Subtract}");
            Keyboard.SendKeys("123");
            Keyboard.SendKeys("{Enter}");
            Assert.AreEqual("333", txtResult.Text);
        }

        [TestMethod]
        public void KeyMultiply()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("65");
            Keyboard.SendKeys("{Multiply}");
            Keyboard.SendKeys("75");
            Keyboard.SendKeys("{Enter}");
            Assert.AreEqual("4875", txtResult.Text);
        }

        [TestMethod]
        public void KeyDivide()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("90");
            Keyboard.SendKeys("{Divide}");
            Keyboard.SendKeys("3");
            Keyboard.SendKeys("{Enter}");
            Assert.AreEqual("30", txtResult.Text);
        }

        [TestMethod]
        public void KeyPeriod()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("90");
            Keyboard.SendKeys("{Decimal}");
            Keyboard.SendKeys("5");
            Keyboard.SendKeys("{Add}");
            Keyboard.SendKeys("60");
            Keyboard.SendKeys("{Decimal}");
            Keyboard.SendKeys("5");
            Keyboard.SendKeys("{Enter}");
            Assert.AreEqual("151", txtResult.Text);
        }

        [TestMethod]
        public void KeyEsc()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("90");
            Assert.AreEqual("90", txtResult.Text);
            Keyboard.SendKeys("{Escape}");
        }

        [TestMethod]
        public void KeyBackSpace()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("90");
            Assert.AreEqual("90", txtResult.Text);
            Keyboard.SendKeys("{Back}");
            Assert.AreEqual("9", txtResult.Text);
        }

        [TestMethod]
        public void MouseKey()
        {
            #region Variable Declarations
            WpfButton btn8 = this.UIMap.UICalculatorWindow.UIItem8Button;
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn8);
            Keyboard.SendKeys("{Add}");
            Mouse.Click(btn9);
            Keyboard.SendKeys("{Enter}");
            Assert.AreEqual("17", txtResult.Text);
        }

        [TestMethod]
        public void Copy_Paste()
        {
            #region Variable Declarations
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            System.Threading.Thread.Sleep(3000);
            Keyboard.SendKeys("90");
            Keyboard.SendKeys("^"+"C");
            Keyboard.SendKeys("{Escape}");
            Keyboard.SendKeys("^"+"V");            
            Assert.AreEqual("90", txtResult.Text);
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Calc.Open();
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            Calc.Close();
        }

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
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
