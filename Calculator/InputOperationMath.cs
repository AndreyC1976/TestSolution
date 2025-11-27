using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Calculator
{
    public class InputOperationMath
    {
        MathOperationsControl operationControl = new MathOperationsControl();

        public void OperationMath(OperationType inputOperation, TextBox outputbox, CalcState calcState, TextBox operationBox)
        {
            calcState.PreviousInput = calcState.CurrentInput;
            calcState.CurrentInput = InputType.operation;

            // Блок вызова операций
            // Операция после цифры && первая операция вообще
            if (calcState.PreviousInput == InputType.digit && calcState.CurrenntOpr == OperationType.none)
            {
                calcState.CurrentNumber = outputbox.Text;
                calcState.CurrenntOpr = inputOperation;
                return;
            }

            // Операция после цифры && последующие операции
            if (calcState.PreviousInput == InputType.digit && calcState.CurrenntOpr != OperationType.none)
            {
                calcState.PreviousNumber = calcState.CurrentNumber;
                calcState.CurrentNumber = outputbox.Text;
                
                calcState.PreviousOpr = calcState.CurrenntOpr;
                calcState.CurrenntOpr = inputOperation;

                operationControl.OperationControl(calcState, outputbox); // Вызов вычислений
                calcState.CurrentNumber = calcState.ResultStringComma; // Результат equals становится новым числом ввода

                return;
            }
            
            // Операция после операции
            if (calcState.PreviousInput == InputType.operation)
            {
                calcState.CurrenntOpr = inputOperation;
                return;
            }

            // Операция после равно
            if (calcState.PreviousInput == InputType.equals)
            {
                calcState.PreviousNumber = calcState.CurrentNumber;
                calcState.CurrentNumber = calcState.ResultStringComma;
                calcState.CurrenntOpr = inputOperation;
                //operationControl.OperationControl(calcState, outputbox); // Вызов вычислений

                return;

                //calcState.PreviousOpr = calcState.CurrenntOpr;
                //calcState.CurrentNumber = calcState.ResultStringComma; // Результат equals становится новым числом ввода
                //calcState.CurrenntOpr = inputOperation;

                //operationControl.OperationControl(calcState, outputbox); // Вызов вычислений
                //calcState.CurrentNumber = calcState.ResultStringComma; // Результат equals становится новым числом ввода

            }
        } // Окончание public void OperationMath
        
        // OperationEquals
        public void OperationEquals(TextBox outputbox, CalcState calcState, TextBox operationbox)
        {
            calcState.PreviousInput = calcState.CurrentInput;
            calcState.CurrentInput = InputType.equals;
            calcState.PreviousNumber = calcState.CurrentNumber;

            // Равно && это первое равно
            if (calcState.CurrentInput == InputType.equals && calcState.PreviousInput != InputType.equals)
            {
                //calcState.PreviousInput = calcState.CurrentInput;
                //calcState.CurrentInput = InputType.operation;
                
                
                calcState.CurrentNumber = outputbox.Text;

                calcState.PreviousOpr = calcState.CurrenntOpr;


                operationControl.OperationControl(calcState, outputbox);
                
                //return;
            }


            // Равно && это второе и последующее равно
            if (calcState.CurrentInput == InputType.equals && calcState.PreviousInput == InputType.equals)
            {
                //calcState.PreviousNumber = calcState.CurrentNumber;
                calcState.PreviousNumber = calcState.ResultStringComma;

                operationControl.OperationControl(calcState, outputbox);

                //return;
            }

        }

    } // Окончание public class InputOperationMath


    //            public void OperationEquals(TextBox outputbox, CalcState calcState)
    //{
    //    calcState.PreviousInput = calcState.CurrentInput;
    //    calcState.CurrentInput = InputType.equals;
    //}


    //            public void OperationEquals(TextBox outputbox, CalcState calcState)
    //{
    //    calcState.PreviousInput = calcState.CurrentInput;
    //    calcState.CurrentInput = InputType.equals;
    //}


    // Если до этого:
    //1. Цифра.
    //2. Опрация.
    //3. Равно.

    //outputbox.Text = inputBoxTextNew;

    //public string PreviousNumber { get; set; }
    //public string CurrentNumber { get; set; }
    //public InputType PreviousInput { get; set; }
    //public InputType CurrentInput { get; set; }
    //public OperationType PreviousOpr { get; set; }
    //public OperationType CurrenntOpr { get; set; }
    //public double Result { get; set; }

    //public enum InputType { digit, operation, equals }
    //public enum OperationType { none, add, substract, multiply, divide }
    //public enum CommonActions { none, equals, escape }
} //Окончание namespace Calculator
