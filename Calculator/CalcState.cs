using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum InputType { none, digit, operation, equals }
    public enum OperationType { none, add, substract, multiply, divide }
    public enum CommonActions { none, equals, escape}

    public class CalcState
    {
        public string PreviousNumber {  get; set; }
        public string CurrentNumber { get; set; }
        public InputType PreviousInput { get; set; }
        public InputType CurrentInput { get; set; }
        public OperationType PreviousOpr {  get; set; }
        public OperationType CurrenntOpr { get; set; }
        //public string PreviousNumberDot { get; set; }
        //public string CurrentNumberDot { get; set; }
        public double? CurrentDouble { get; set; }
        public double? PreviousDouble { get; set; }
        public double? ResultDouble { get; set; }
        //public string ResultStringDot { get; set; }
        public string ResultStringComma { get; set; }

        public void CalcClear(TextBox outputbox, TextBox operationBox)
        {
            PreviousNumber = null;
            CurrentNumber = null;
            PreviousInput = InputType.none;
            CurrentInput = InputType.none;
            PreviousOpr = OperationType.none;
            CurrenntOpr = OperationType.none;
            CurrentDouble = null;
            PreviousDouble = null;
            ResultDouble = null;
            ResultStringComma = "";

            operationBox.Text = "";
            outputbox.Text = "";
        }
    }
}
