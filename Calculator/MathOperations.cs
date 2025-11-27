using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Calculator
{
    public class MathOperationsControl
    {
        public void OperationControl(CalcState state, TextBox outputbox)
        {
            StringToDigit(state);

            OperationSelect(state);
            
            DigitToString(state);

            outputbox.Text = state.ResultStringComma;
        }
        public void OperationSelect(CalcState state)
        {
            if (state.PreviousOpr == OperationType.add)
            {
                MathOperations add = new Addition();
                add.Execute(state);
            }
            if (state.PreviousOpr == OperationType.substract)
            {
                MathOperations substract = new Substraction();
                substract.Execute(state);
            }
            if (state.PreviousOpr == OperationType.multiply)
            {
                MathOperations multiply = new Multiplication();
                multiply.Execute(state);
            }
            if (state.PreviousOpr == OperationType.divide)
            {
                MathOperations divide = new Division();
                divide.Execute(state);
            }
        }
        private void StringToDigit (CalcState state)
        {
            //state.CurrentNumberDot = state.CurrentNumber.Replace(',', '.');
            //state.CurrentNumberDot = state.CurrentNumber;
            double.TryParse(state.CurrentNumber, out double currentDouble);
            state.CurrentDouble = currentDouble;

            //state.PreviousNumberDot = state.PreviousNumber.Replace(',', '.');
            double.TryParse(state.PreviousNumber, out double previousDouble);
            state.PreviousDouble = previousDouble;
        }
        private void DigitToString (CalcState state)
        {
            state.ResultStringComma = state.ResultDouble.ToString();
            //state.ResultStringComma = state.ResultStringDot.Replace(',', '.');
        }
    }
    public abstract class MathOperations
    {
        public void Execute(CalcState state)
        {
            PerformOperation(state);
        }

        protected abstract void PerformOperation(CalcState state);
    }
    public class Addition : MathOperations
    {
        protected override void PerformOperation(CalcState state)
        {
            state.ResultDouble = state.PreviousDouble + state.CurrentDouble;
        }
    }
    public class Substraction : MathOperations
    {
        protected override void PerformOperation(CalcState state)
        {
            state.ResultDouble = state.PreviousDouble - state.CurrentDouble;
        }
    }
    public class Multiplication : MathOperations
    {
        protected override void PerformOperation(CalcState state)
        {
            state.ResultDouble = state.PreviousDouble * state.CurrentDouble;
        }
    }
    public class Division : MathOperations
    {
        protected override void PerformOperation(CalcState state)
        {
            state.ResultDouble = state.PreviousDouble / state.CurrentDouble;
        }
    }

}
