using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class CalculatorGUIForm : Form
    {
        private StringBuilder userNum1;
        private StringBuilder userNum2;
        private bool tester;
        private string oper;
        private double result;
        public CalculatorGUIForm()
        {
            tester = false;
            InitializeComponent();
        }
    }
    private void ValueApplied(string value)
    {
        if (!tester)
        {
            if (userNum1 != null && userNum1.ToString()[0] == '0' && !userNum1.ToString().Contains("."))
                userNum1.Clear();
            if (userNum1 == null)
                userNum1 = new StringBuilder();

            userNum1.Append(value);
            consoleLog.Text = userNum1.ToString();
        }
        else
        {
            if (userNum2 != null && userNum2.ToString()[0] == '0' && !userNum2.ToString().Contains("."))
                userNum2.Clear();
            if (userNum2 == null)
                userNum2 = new StringBuilder();
            userNum2.Append(value);
            consoleLog.Text = userNum2.ToString();
        }
    }
    //numbers pressed
    private void ZeroPress(object sent, EventArgs e)
    {
        ValueApplied("0");
    }
    private void OnePress(object sent, EventArgs e)
    {
        ValueApplied("1");
    }

    private void TwoPress(object sent, EventArgs e)
    {
        ValueApplied("2");
    }

    private void ThreePress(object sent, EventArgs e)
    {
        ValueApplied("3");
    }

    private void FourPress(object sent, EventArgs e)
    {
        ValueApplied("4");
    }

    private void FivePress(object sent, EventArgs e)
    {
        ValueApplied("5");
    }

    private void SixPress(object sent, EventArgs e)
    {
        ValueApplied("6");
    }

    private void SevenPress(object sent, EventArgs e)
    {
        ValueApplied("7");
    }

    private void EightPress(object sent, EventArgs e)
    {
        ValueApplied("8");
    }

    private void NinePress(object sent, EventArgs e)
    {
        ValueApplied("9");
    }
    //operations pressed
    private void OperApplied(string operationValue) //after operation is applied change console back to 0
    {
        oper = operationValue;
        tester = !tester;
        consoleLog.Text = "0";
    }

    private void PlusPress(object sent, EventArgs e)
    {
        OperApplied("+");
    }

    private void MinusPress(object sent, EventArgs e)
    {
        OperApplied("-");
    }

    private void DividePress(object sent, EventArgs e)
    {
        OperApplied("/");
    }

    private void ProductPress(object sent, EventArgs e)
    {
        OperApplied("*");
    }

    private void EqualPress(object sent, EventArgs e)
    {
        switch (oper)
        {
            case "+": //if plus then execute opersum
                OperSum();
                break;
            case "-": //if minus then execute opersub
                OperSub();
                break;
            case "/": //if divide then execute operdiv
                OperDiv();
                break;
            case "*": //if multiply then execute operprod
                OperProd();
                break;
        }
    }
    private void SquarePress(object sent, EventArgs e)
    {
        OperSq(!tester ? userNum1 : userNum2);
    }
    private void LogPress(object sent, EventArgs e)
    {
        OperLog(!tester ? userNum1 : userNum2, 10);
    }
    private void SignChangePress(object sent, EventArgs e)
    {
        ChangeSign(!tester ? userNum1 : userNum2);
    }
    private void InversePress(object sent, EventArgs e)
    {
        OperInv(!tester ? userNum1 : userNum2);
    }

    //operations executed
    private void ChangeSign(StringBuilder number)
    {
        double temp = Convert.ToDouble(number.ToString());
        if (number != null)
        {
            temp = -1 * temp;
            number.Clear();
            number.Append(temp);
            consoleLog.Text = number.ToString();
        }
    }

    private void OperSum()
    {
        if (userNum1 != null && userNum2 != null)
        {
            result = Convert.ToDouble(userNum1.ToString()) + Convert.ToDouble(userNum2.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            userNum2 = null;
            tester = !tester;
        }
        else if (userNum1 != null && userNum2 == null)
        {
            result = Convert.ToDouble(userNum1.ToString()) + Convert.ToDouble(userNum1.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            tester = !tester;
        }
    }

    private void OperSub()
    {
        if (userNum1 != null && userNum2 != null)
        {
            result = Convert.ToDouble(userNum1.ToString()) - Convert.ToDouble(userNum2.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            userNum2 = null;
            tester = !tester;
        }
        else if (userNum1 != null && userNum2 == null)
        {
            result = Convert.ToDouble(userNum1.ToString()) - Convert.ToDouble(userNum1.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            tester = !tester;
        }
    }

    private void OperProd()
    {
        if (userNum1 != null && userNum2 != null)
        {
            result = Convert.ToDouble(userNum1.ToString()) * Convert.ToDouble(userNum2.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            userNum2 = null;
            tester = !tester;
        }
        else if (userNum1 != null && userNum2 == null)
        {
            result = Convert.ToDouble(userNum1.ToString()) + Convert.ToDouble(userNum1.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            tester = !tester;
        }
    }

    private void OperSq(StringBuilder number)
    {
        double temp = Convert.ToDouble(number.ToString());
        number.Clear();
        number.Append(Math.Pow(temp, 2));
        consoleLog.Text = number.ToString();
    }

    private void OperDiv()
    {
        if (userNum1 != null && userNum2 != null && Convert.ToDouble(userNum2.ToString()) != 0)
        {
            result = Convert.ToDouble(userNum1.ToString()) / Convert.ToDouble(userNum2.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            userNum2 = null;
            tester = !tester;
        }
        else if (userNum1 != null && userNum2 != null && Convert.ToDouble(userNum2.ToString()) == 0)
        {
            consoleLog.Text = "error";
            userNum1 = null;
            userNum2 = null;
            tester = !tester;
        }
        else if (userNum1 != null && userNum2 == null)
        {
            result = Convert.ToDouble(userNum1.ToString()) / Convert.ToDouble(userNum1.ToString());
            consoleLog.Text = Convert.ToString(result);
            userNum1 = null;
            tester = !tester;
        }
    }



    private void OperLog(StringBuilder number, double baseNumber) // Can't figure out how to do Log with a specified base in a GUI as I can't ask the user to enter something
    {                                                                 // like I could in a console app
        double temp = Convert.ToDouble(number.ToString());
        number.Clear();
        number.Append(Math.Log(temp, baseNumber));
        consoleLog.Text = number.ToString();
    }

    private void OperInv(StringBuilder number)
    {
        double temp = Convert.ToDouble(number.ToString());
        if (temp != 0)
        {
            number.Clear();
            number.Append(1 / temp);
            consoleLog.Text = number.ToString();
        }
        else
        {
            consoleLog.Text = "error";
            number = null;
        }
    }
}
/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/