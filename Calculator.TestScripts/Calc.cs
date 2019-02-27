using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.TestScripts
{
    class Calc
    {
        public static void Open()
        {
            string applicationPath = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.LastIndexOf("\\TestResults\\"))
                + @"\CalculatorWPF\bin\Debug\CalculatorWPF.exe";

            Process.Start(applicationPath);
        }
        public static void Close()
        {
            new UIMap().Close_Calculator();
        }
    }
}
