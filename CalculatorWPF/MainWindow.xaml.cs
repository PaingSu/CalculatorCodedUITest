using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sign_Indicator = 0;
        Boolean f1 = false;
        int addBit = 0;
        int subBit = 0;
        int multBit = 0;
        int divBit = 0;
        int modBit = 0;
        double temp1, temp2;
        string s1 = string.Empty;
        string s2 = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {

            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(5);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(5);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void brnSix_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                txtCalculate.Text = txtCalculate.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (sign_Indicator == 0)
            {
                 txtCalculate.Text = txtCalculate.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                txtCalculate.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
            f1 = true;
            btnEqual.Focus();
        }

        private void btnPeriod_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            char chr = '\0';
            int decimal_Indicator = 0;
            int l = txtCalculate.Text.Length - 1;
            if (sign_Indicator != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = txtCalculate.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }
                if (decimal_Indicator != 1)
                {
                    txtCalculate.Text = txtCalculate.Text + Convert.ToString(".");
                }
            }
            if (sign_Indicator == 1)
            {
                if (chr == '.')
                {
                    decimal_Indicator = 1;
                }
                if (decimal_Indicator != 1)
                    txtCalculate.Text = "0" + Convert.ToString(".");
                sign_Indicator = 0;
            }
        }

        private void reset_SignBits()
        {
            addBit = 0;
            subBit = 0;
            multBit = 0;
            divBit = 0;
            modBit = 0;
            f1 = false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtCalculate.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                addBit = 1;
                sign_Indicator = 1;
            }
        }

        private void btnDifference_Click(object sender, RoutedEventArgs e)
        {
            if (txtCalculate.Text.Length == 0)
            {
                temp1 = 0;
                txtCalculate.Text = Convert.ToString(temp1);
                reset_SignBits();
                sign_Indicator = 1;
            }
            if (txtCalculate.Text.Length != 0)
            {
                temp2 = Convert.ToDouble(txtCalculate.Text);
                calculate();
                reset_SignBits();
                subBit = 1;
                sign_Indicator = 1;
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (txtCalculate.Text.Length != 0)
            {
                temp2 = Convert.ToDouble(txtCalculate.Text);
                calculate();
                reset_SignBits();
                multBit = 1;
                sign_Indicator = 1;
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (txtCalculate.Text.Length != 0)
            {
                temp2 = Convert.ToDouble(txtCalculate.Text);
                calculate();
                reset_SignBits();
                divBit = 1;
                sign_Indicator = 1;
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (txtCalculate.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign_Indicator = 1;
        }

        private void calculate()
        {
            if (txtCalculate.Text != ".")
            {
                temp2 = Convert.ToDouble(txtCalculate.Text);
                if (f1 == false)
                    temp1 = temp2;

                else if (addBit == 1)
                    temp1 = temp1 + temp2;

                else if (subBit == 1)
                    temp1 = temp1 - temp2;

                else if (multBit == 1)
                    temp1 = temp1 * temp2;

                else if (divBit == 1)
                    temp1 = temp1 / temp2;

                else if (modBit == 1)
                {
                    temp2 = Convert.ToInt32(txtCalculate.Text);
                    temp1 = Convert.ToInt32(temp1 % temp2);
                }
                else
                {
                    temp1 = temp2;
                }
                txtCalculate.Text = Convert.ToString(temp1);
            }
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            s1 = txtCalculate.Text;
            int l = s1.Length;
            for (int i = 0; i < l - 1; i++)
            {
                s2 += s1[i];
            }
            txtCalculate.Text = s2;
            s2 = "";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtCalculate.Clear();
            sign_Indicator = 0;
            temp1 = 0;
            temp2 = 0;
            reset_SignBits();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtCalculate.Text = " ";
            sign_Indicator = 1;
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            if (txtCalculate.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                modBit = 1;
                sign_Indicator = 1;
            }
        }

        private void btnFat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(txtCalculate.Text); i++)
                {
                    fact = fact * i;
                }
                txtCalculate.Text = Convert.ToString(fact);
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double temp, t2;
                t2 = Convert.ToDouble(txtCalculate.Text);
                temp = Math.Sqrt(t2);
                txtCalculate.Text = Convert.ToString(temp);
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch { }
        }

        private void btnPlusMin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t1 = Convert.ToDouble(txtCalculate.Text);
                t1 = -t1;
                txtCalculate.Text = t1.ToString();
            }
            catch { }
        }

        private void CopyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtCalculate.Text.ToString());
        }

        private void PasteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            string myTest = "";
            txtCalculate.Clear();
            myTest = Clipboard.GetText();
            foreach (Char c in myTest)
            {
                keyPress1(c);
            }
        }

        public void keyPress1(char c)
        {
            switch (c)
            {
                case '1': btnOne_Click(this, null);
                    break;
                case '2': btnTwo_Click(this, null);
                    break;
                case '3': btnThree_Click(this, null);
                    break;
                case '4': btnFour_Click(this, null);
                    break;
                case '5': btnFive_Click(this, null);
                    break;
                case '6': brnSix_Click(this, null);
                    break;
                case '7': btnSeven_Click(this, null);
                    break;
                case '8': btnEight_Click(this, null);
                    break;
                case '9': btnNine_Click(this, null);
                    break;
                case '0': btnZero_Click(this, null);
                    break;
                case '.': btnPeriod_Click(this, null);
                    break;
                case '+': btnAdd_Click(this, null);
                    break;
                case '-': btnDifference_Click(this, null);
                    break;
                case '*': btnMultiply_Click(this, null);
                    break;
                case '/': btnDivide_Click(this, null);
                    break;
                case '=': btnEqual_Click(this, null);
                    break;
            }
        }

        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Sin(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnTan_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Tan(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnX2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Convert.ToDouble(txtCalculate.Text);
                    double x = l * l;
                    txtCalculate.Text = Convert.ToString(x);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnPi_Click(object sender, RoutedEventArgs e)
        {
            txtCalculate.Text = Convert.ToString(Math.PI);
            sign_Indicator = 0;
            f1 = true;
            btnEqual.Focus();
        }

        private void btnSinh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Sinh(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCosh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Cosh(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnTanh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Tanh(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Log10(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnExp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCalculate.Text.Length != 0)
                {
                    double l;
                    l = Math.Exp(Convert.ToDouble(txtCalculate.Text));
                    txtCalculate.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
                btnEqual.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                btnEqual_Click(this, null);

            if (e.Key == Key.Escape)
                btnC_Click(this, null);

            keyPress(e.Key);

            string myTest = "";            
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.V)
            {
                txtCalculate.Clear();
                myTest = Clipboard.GetText();
                foreach (Char c in myTest)
                {
                    keyPress1(c);
                }
            }
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.C)
            {
                Clipboard.SetText(txtCalculate.Text.ToString());
            }
        }

        public void keyPress(Key k)
        {           
            switch (k)
            {
                case Key.NumPad1: btnOne_Click(this, null);
                    break;
                case Key.NumPad2: btnTwo_Click(this, null);
                    break;
                case Key.NumPad3: btnThree_Click(this, null);
                    break;
                case Key.NumPad4: btnFour_Click(this, null);
                    break;
                case Key.NumPad5: btnFive_Click(this, null);
                    break;
                case Key.NumPad6: brnSix_Click(this, null);
                    break;
                case Key.NumPad7: btnSeven_Click(this, null);
                    break;
                case Key.NumPad8: btnEight_Click(this, null);
                    break;
                case Key.NumPad9: btnNine_Click(this, null);
                    break;
                case Key.NumPad0: btnZero_Click(this, null);
                    break;
                case Key.Decimal: btnPeriod_Click(this, null);
                    break;
                case Key.Add: btnAdd_Click(this, null);
                    break;
                case Key.Subtract: btnDifference_Click(this, null);
                    break;
                case Key.Multiply: btnMultiply_Click(this, null);
                    break;
                case Key.Divide: btnDivide_Click(this, null);
                    break;
                case Key.Enter: btnEqual_Click(this, null);
                    break;
                case Key.D1: btnOne_Click(this, null);
                    break;
                case Key.D2: btnTwo_Click(this, null);
                    break;
                case Key.D3: btnThree_Click(this, null);
                    break;
                case Key.D4: btnFour_Click(this, null);
                    break;
                case Key.D5: btnFive_Click(this, null);
                    break;
                case Key.D6: brnSix_Click(this, null);
                    break;
                case Key.D7: btnSeven_Click(this, null);
                    break;
                case Key.D8: btnEight_Click(this, null);
                    break;
                case Key.D9: btnNine_Click(this, null);
                    break;
                case Key.D0: btnZero_Click(this, null);
                    break;
                case Key.Back: btnBackSpace_Click(this, null);
                    break;
            }
        }
    }
}
