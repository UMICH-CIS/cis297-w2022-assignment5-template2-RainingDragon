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