using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class DigitInputProcess
    {
        InputState inputState = new InputState();
        
        public void InputDigit(string digitInput, TextBox outputbox, CalcState calcState, TextBox operationBox)
        {
            calcState.PreviousInput = calcState.CurrentInput;
            calcState.CurrentInput = InputType.digit;

            inputState.inputBoxTextCurrent = outputbox.Text;
            inputState.inputBoxTextNew = inputState.inputBoxTextCurrent + digitInput; //Добавляем символ справа

            //Вычисление позиции запятой
            CommaPosition(outputbox, inputState);

            // Проверяем на наличие запятой первым симоволом
            if (inputState.newCommaPosition == 0)
            {
                inputState.inputBoxTextNew = "0" + inputState.inputBoxTextNew;
                outputbox.Text = inputState.inputBoxTextNew;
            }

            //NOTE Блок вызова операций
            // Цифра после операции
            if (calcState.PreviousInput == InputType.none || calcState.PreviousInput == InputType.operation)
            {
                outputbox.Text = digitInput;
                return;
            }

            // Цифра после равно
            if (calcState.PreviousInput == InputType.equals)
            {
                outputbox.Text = digitInput;
                return;
            }

            // Проверяем на длину введенной строки
            if (inputState.inputBoxTextNew.Length > inputState.lengthLimit)
            {
                MessageBox.Show("Превышено максимальное количество знаков. Возможно ввести не более 10 знаков," +
                    " без учета запятой.", "Превышение количества знаков");
            }

            // Проверяем на вторую запятую
            if (digitInput == "," && inputState.currentCommaPosition != -1)
            {
                return;
            }

            outputbox.Text = inputState.inputBoxTextNew;
        } // Окончание метода InputDigit

        public void DeleteDigit(TextBox outputbox)
        {
            if (outputbox.Text.Length > 0)
            {
                outputbox.Text = outputbox.Text.Substring(0, outputbox.Text.Length - 1);
            }
        } // Окончание метода DeleteDigit

        // Проверяем на наличие запятой
        private void CommaPosition(TextBox outputbox, InputState inputState)
        {
            inputState.currentCommaPosition = inputState.inputBoxTextCurrent.IndexOf(',');
            inputState.newCommaPosition = inputState.inputBoxTextNew.IndexOf(',');

            if (inputState.newCommaPosition == -1) // если нет запятой
            {
                inputState.lengthLimit = 10;
            }
            else
            {
                inputState.lengthLimit = 11;
            }
        }

    } // Окончание public class InputProcess
} // Окончание namespace Calculator


