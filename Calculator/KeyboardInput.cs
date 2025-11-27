using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace Calculator
{
    public class KeyboardInput
    {
        DigitInputProcess inputDigit = new DigitInputProcess();
        InputOperationMath inputKeyboardOperation = new InputOperationMath();

        public string HandleKeyDown(Keys keyData, TextBox outputbox, CalcState calcState, TextBox operationBox)
        {
            string inputKeyboardDigit = "";
            OperationType inputOperation = OperationType.none;

            // Вычленение данных из нажатий клавиш цифр
            if (keyData == Keys.D0 || keyData == Keys.NumPad0) { inputKeyboardDigit = "0"; }
            else if (keyData == Keys.D1 || keyData == Keys.NumPad1) { inputKeyboardDigit = "1"; }
            else if (keyData == Keys.D2 || keyData == Keys.NumPad2) { inputKeyboardDigit = "2"; }
            else if (keyData == Keys.D3 || keyData == Keys.NumPad3) { inputKeyboardDigit = "3"; }
            else if (keyData == Keys.D4 || keyData == Keys.NumPad4) { inputKeyboardDigit = "4"; }
            else if (keyData == Keys.D5 || keyData == Keys.NumPad5) { inputKeyboardDigit = "5"; }
            else if (keyData == Keys.D6 || keyData == Keys.NumPad6) { inputKeyboardDigit = "6"; }
            else if (keyData == Keys.D7 || keyData == Keys.NumPad7) { inputKeyboardDigit = "7"; }
            else if (keyData == Keys.D8 || keyData == Keys.NumPad8) { inputKeyboardDigit = "8"; }
            else if (keyData == Keys.D9 || keyData == Keys.NumPad9) { inputKeyboardDigit = "9"; }

            // Нажатие запятой
            if (keyData == Keys.Decimal) { inputKeyboardDigit = ","; }

            // Нажатие BackSpace
            if (keyData == Keys.Back) { inputDigit.DeleteDigit(outputbox); }

            // Вызов операций
            if (keyData == Keys.Add) { inputOperation = OperationType.add; }
            if (keyData == Keys.Subtract) { inputOperation = OperationType.substract; }
            if (keyData == Keys.Multiply) { inputOperation = OperationType.multiply; }
            if (keyData == Keys.Divide) { inputOperation = OperationType.divide; }

            // Вызов общих действий
            if (keyData == Keys.Enter)
            {
                inputKeyboardOperation.OperationEquals(outputbox, calcState, operationBox);
            }

            if (keyData == Keys.Escape)
            {
                calcState.CalcClear(outputbox, operationBox);
            }

            // Вызов обработки
            if ((inputKeyboardDigit != "" || inputOperation == OperationType.none) && calcState.CurrentInput != InputType.equals)
            {
                inputDigit.InputDigit(inputKeyboardDigit, outputbox, calcState, operationBox);
            }
            else if ((inputKeyboardDigit == "" || inputOperation != OperationType.none) && calcState.CurrentInput != InputType.equals)
            {
                inputKeyboardOperation.OperationMath(inputOperation, outputbox, calcState, operationBox);
            }

            return "";
        }
    }
}
