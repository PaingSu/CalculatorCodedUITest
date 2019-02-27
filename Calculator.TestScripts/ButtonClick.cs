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
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ButtonClick
    {
        public ButtonClick()
        {
        }

        [TestMethod]
        public void BackSpace()
        {
            #region Variable Declarations
            WpfButton btn7 = this.UIMap.UICalculatorWindow.UIItem7Button;
            WpfButton btn8 = this.UIMap.UICalculatorWindow.UIItem8Button;
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnBackSpace = this.UIMap.UICalculatorWindow.UIItemButton8;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn7);
            Mouse.Click(btn8);
            Mouse.Click(btn9);
            Mouse.Click(btnBackSpace);
            Mouse.Click(btnBackSpace);
            Mouse.Click(btnEqual);
            Assert.AreEqual("7", txtResult.Text);
        }

        [TestMethod]
        public void CE()
        {
            #region Variable Declarations
            WpfButton btn8 = this.UIMap.UICalculatorWindow.UIItem8Button;
            WpfButton btnMultiply = this.UIMap.UICalculatorWindow.UIItemButton3;
            WpfButton btn5 = this.UIMap.UICalculatorWindow.UIItem5Button;
            WpfButton btnCE = this.UIMap.UICalculatorWindow.UICEButton;
            WpfButton btn4 = this.UIMap.UICalculatorWindow.UIItem4Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn8);
            Mouse.Click(btnMultiply);
            Mouse.Click(btn5);
            Mouse.Click(btnCE);
            Mouse.Click(btn4);
            Mouse.Click(btnEqual);
            Assert.AreEqual("32", txtResult.Text);
        }

        [TestMethod]
        public void C()
        {
            #region Variable Declarations
            WpfButton btn5 = this.UIMap.UICalculatorWindow.UIItem5Button;
            WpfButton btnMinus = this.UIMap.UICalculatorWindow.UIItemButton2;
            WpfButton btn2 = this.UIMap.UICalculatorWindow.UIItem2Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            WpfButton btnC = this.UIMap.UICalculatorWindow.UICButton;
            #endregion

            Mouse.Click(btn5);
            Mouse.Click(btnMinus);
            Mouse.Click(btn2);
            Mouse.Click(btnEqual);
            Assert.AreEqual("3", txtResult.Text);
            Mouse.Click(btnC);
        }

        [TestMethod]
        public void Add()
        {
            #region Variable Declarations
            WpfButton btn8 = this.UIMap.UICalculatorWindow.UIItem8Button;
            WpfButton btnAdd = this.UIMap.UICalculatorWindow.UIItemButton;
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn8);
            Mouse.Click(btnAdd);
            Mouse.Click(btn9);
            Mouse.Click(btnEqual);
            Assert.AreEqual("17", txtResult.Text);
        }

        [TestMethod]
        public void Subtract()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btn8 = this.UIMap.UICalculatorWindow.UIItem8Button;
            WpfButton btnSub = this.UIMap.UICalculatorWindow.UIItemButton2;
            WpfButton btn6 = this.UIMap.UICalculatorWindow.UIItem6Button;
            WpfButton btn5 = this.UIMap.UICalculatorWindow.UIItem5Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btn8);
            Mouse.Click(btnSub);
            Mouse.Click(btn6);
            Mouse.Click(btn5);
            Mouse.Click(btnEqual);
            Assert.AreEqual("33", txtResult.Text);
        }

        [TestMethod]
        public void Multiply()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnMultiply = this.UIMap.UICalculatorWindow.UIItemButton3;
            WpfButton btn6 = this.UIMap.UICalculatorWindow.UIItem6Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btn9);
            Mouse.Click(btnMultiply);
            Mouse.Click(btn6);
            Mouse.Click(btn6);
            Mouse.Click(btnEqual);
            Assert.AreEqual("6534", txtResult.Text);
        }

        [TestMethod]
        public void Divide()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnDivide = this.UIMap.UICalculatorWindow.UIItemButton4;
            WpfButton btn3 = this.UIMap.UICalculatorWindow.UIItem3Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btnDivide);
            Mouse.Click(btn3);
            Mouse.Click(btnEqual);
            Assert.AreEqual("3", txtResult.Text);
        }

        [TestMethod]
        public void Period()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnPeriod = this.UIMap.UICalculatorWindow.UIItemButton9;
            WpfButton btn5 = this.UIMap.UICalculatorWindow.UIItem5Button;
            WpfButton btnAdd = this.UIMap.UICalculatorWindow.UIItemButton;
            WpfButton btn4 = this.UIMap.UICalculatorWindow.UIItem4Button;
            WpfButton btnPeriod1 = this.UIMap.UICalculatorWindow.UIItemButton10;
            WpfButton btn6 = this.UIMap.UICalculatorWindow.UIItem6Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btnPeriod);
            Mouse.Click(btn5);
            Mouse.Click(btnAdd);
            Mouse.Click(btn4);
            Mouse.Click(btnPeriod1);
            Mouse.Click(btn6);
            Mouse.Click(btnEqual);
            Assert.AreEqual("14.1", txtResult.Text);
        }

        [TestMethod]
        public void PlusMinus()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnPlusMinus = this.UIMap.UICalculatorWindow.UIItemButton5;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btnPlusMinus);
            Mouse.Click(btnEqual);
            Assert.AreEqual("-9", txtResult.Text);
        }

        [TestMethod]
        public void PlusMinus1()
        {
            #region Variable Declarations
            WpfButton btnSub = this.UIMap.UICalculatorWindow.UIItemButton2;
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnPlusMinus = this.UIMap.UICalculatorWindow.UIItemButton5;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btnSub);
            Mouse.Click(btn9);
            Mouse.Click(btnPlusMinus);
            Mouse.Click(btnEqual);
            Assert.AreEqual("9", txtResult.Text);
        }

        [TestMethod]
        public void SquareRoot()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnSqrt = this.UIMap.UICalculatorWindow.UIItemButton6;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btnSqrt);
            Mouse.Click(btnEqual);
            Assert.AreEqual("3", txtResult.Text);
        }

        [TestMethod]
        public void Modulus()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnMod = this.UIMap.UICalculatorWindow.UIItemButton7;
            WpfButton btn3 = this.UIMap.UICalculatorWindow.UIItem3Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btnMod);
            Mouse.Click(btn3);
            Mouse.Click(btnEqual);
            Assert.AreEqual("0", txtResult.Text);
        }

        [TestMethod]
        public void Factorial()
        {
            #region Variable Declarations
            WpfButton btn3 = this.UIMap.UICalculatorWindow.UIItem3Button;
            WpfButton btnFact = this.UIMap.UICalculatorWindow.UIXButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn3);
            Mouse.Click(btnFact);
            Mouse.Click(btnEqual);
            Assert.AreEqual("6", txtResult.Text);
        }

        [TestMethod]
        public void Sine()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnSine = this.UIMap.UICalculatorWindow.UISinButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btnSine);
            Mouse.Click(btnEqual);
            Assert.AreEqual("0.412118485241757", txtResult.Text);
        }

        [TestMethod]
        public void Sinh()
        {
            #region Variable Declarations
            WpfButton btn2 = this.UIMap.UICalculatorWindow.UIItem2Button;
            WpfButton btn3 = this.UIMap.UICalculatorWindow.UIItem3Button;
            WpfButton btnSinh = this.UIMap.UICalculatorWindow.UISinhButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn2);
            Mouse.Click(btn3);
            Mouse.Click(btnSinh);
            Mouse.Click(btnEqual);
            Assert.AreEqual("4872401723.12445", txtResult.Text);
        }

        [TestMethod]
        public void Cos()
        {
            #region Variable Declarations
            WpfButton btn3 = this.UIMap.UICalculatorWindow.UIItem3Button;
            WpfButton btnCos = this.UIMap.UICalculatorWindow.UICosButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn3);
            Mouse.Click(btn3);
            Mouse.Click(btnCos);
            Mouse.Click(btnEqual);
            Assert.AreEqual("-0.0132767472230595", txtResult.Text);
        }

        [TestMethod]
        public void Cosh()
        {
            #region Variable Declarations
            WpfButton btn2 = this.UIMap.UICalculatorWindow.UIItem2Button;
            WpfButton btn7 = this.UIMap.UICalculatorWindow.UIItem7Button;
            WpfButton btnCosh = this.UIMap.UICalculatorWindow.UICoshButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn2);
            Mouse.Click(btn7);
            Mouse.Click(btnCosh);
            Mouse.Click(btnEqual);
            Assert.AreEqual("266024120300.899", txtResult.Text);
        }

        [TestMethod]
        public void Tan()
        {
            #region Variable Declarations
            WpfButton btn7 = this.UIMap.UICalculatorWindow.UIItem7Button;
            WpfButton btn8 = this.UIMap.UICalculatorWindow.UIItem8Button;
            WpfButton btnTan = this.UIMap.UICalculatorWindow.UITanButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn7);
            Mouse.Click(btn8);
            Mouse.Click(btnTan);
            Mouse.Click(btnEqual);
            Assert.AreEqual("-0.599179998341115", txtResult.Text);
        }

        [TestMethod]
        public void Tanh()
        {
            #region Variable Declarations
            WpfButton btn2 = this.UIMap.UICalculatorWindow.UIItem2Button;
            WpfButton btn3 = this.UIMap.UICalculatorWindow.UIItem3Button;
            WpfButton btnTanh = this.UIMap.UICalculatorWindow.UITanhButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn2);
            Mouse.Click(btn3);
            Mouse.Click(btnTanh);
            Mouse.Click(btnEqual);
            Assert.AreEqual("1", txtResult.Text);
        }

        [TestMethod]
        public void Square()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btnSquare = this.UIMap.UICalculatorWindow.UIX2Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btnSquare);
            Mouse.Click(btnEqual);
            Assert.AreEqual("81", txtResult.Text);
        }

        [TestMethod]
        public void Log()
        {
            #region Variable Declarations
            WpfButton btn4 = this.UIMap.UICalculatorWindow.UIItem4Button;
            WpfButton btn0 = this.UIMap.UICalculatorWindow.UIItem0Button;
            WpfButton btnLog = this.UIMap.UICalculatorWindow.UILogButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn4);
            Mouse.Click(btn0);
            Mouse.Click(btnLog);
            Mouse.Click(btnEqual);
            Assert.AreEqual("1.60205999132796", txtResult.Text);
        }

        [TestMethod]
        public void Pi()
        {
            #region Variable Declarations
            WpfButton btnPi = this.UIMap.UICalculatorWindow.UIPIButton;
            WpfButton btnMultiply = this.UIMap.UICalculatorWindow.UIItemButton3;
            WpfButton btn2 = this.UIMap.UICalculatorWindow.UIItem2Button;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btnPi);
            Mouse.Click(btnMultiply);
            Mouse.Click(btn2);
            Mouse.Click(btnEqual);
            Assert.AreEqual("6.28318530717958", txtResult.Text);
        }

        [TestMethod]
        public void Exp()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btn1 = this.UIMap.UICalculatorWindow.UIItem1Button;
            WpfButton btnExp = this.UIMap.UICalculatorWindow.UIExpButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btn1);
            Mouse.Click(btnExp);
            Mouse.Click(btnEqual);
            Assert.AreEqual("3.31740009833574E+39", txtResult.Text);
        }

        [TestMethod]
        public void Exp_1()
        {

            #region Variable Declarations
            WpfButton uIItem3Button = this.UIMap.UICalculatorWindow.UIItem3Button;
            WpfButton uIItem6Button = this.UIMap.UICalculatorWindow.UIItem6Button;
            WpfButton uIItemButton = this.UIMap.UICalculatorWindow.UIItemButton;
            WpfButton uIItem9Button = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton uIItemButton1 = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            #endregion
            Mouse.Click(uIItem3Button);
            Mouse.Click(uIItem6Button);
            Mouse.Click(uIItemButton);
            Mouse.Click(uIItem9Button);
            Mouse.Click(uIItemButton1);
            Assert.AreEqual("45", txtResult.Text);
        }

        [TestMethod]
        public void Copy_Paste()
        {
            #region Variable Declarations
            WpfButton btn9 = this.UIMap.UICalculatorWindow.UIItem9Button;
            WpfButton btn1 = this.UIMap.UICalculatorWindow.UIItem1Button;
            WpfEdit txtResult = this.UIMap.UICalculatorWindow.UITxtCalculateEdit;
            WpfMenuItem CopyMenu = this.UIMap.UICalculatorWindow.UITextBoxMeunMenu.UICopyMenuItem;
            WpfButton btnC = this.UIMap.UICalculatorWindow.UICButton;
            WpfButton btnEqual = this.UIMap.UICalculatorWindow.UIItemButton1;
            WpfMenuItem PasteMenu = this.UIMap.UICalculatorWindow.UITextBoxMeunMenu.UIPasteMenuItem;
            #endregion

            Mouse.Click(btn9);
            Mouse.Click(btn1);
            Mouse.Click(txtResult, MouseButtons.Right);
            Mouse.Click(CopyMenu);
            Mouse.Click(btnC);
            Mouse.Click(txtResult, MouseButtons.Right);
            Mouse.Click(PasteMenu);
            Mouse.Click(btnEqual);
            Assert.AreEqual("91", txtResult.Text);
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
