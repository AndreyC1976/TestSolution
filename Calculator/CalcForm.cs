using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        string inputText = "";
        double inputNumber = 0;
        DigitInputProcess inputDigit = new DigitInputProcess();
        InputOperationMath inputButtonOperation = new InputOperationMath();
        //InputEquals inputButtonEquals = new InputEquals();
        KeyboardInput InKey = new KeyboardInput();
        CalcState calcState = new CalcState();
               

        public CalcForm()
        {
            InitializeComponent();
            //OutputBox.Text = calcState.CurrentNumber;
        }

        // Ловим нажатие клавиш на клавиатуре, включая Enter
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string inputBoxTextNew = InKey.HandleKeyDown(keyData, OutputBox, calcState, OperationBox);
            return true;
        }

        // Операция нажатия экранной клавиши: цифры, запятая, удаление последнего знака
        private void Number1_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("1", OutputBox, calcState, OperationBox);
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("2", OutputBox, calcState, OperationBox);
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("3", OutputBox, calcState, OperationBox);
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("4", OutputBox, calcState, OperationBox);
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("5", OutputBox, calcState, OperationBox);
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("6", OutputBox, calcState, OperationBox);
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("7", OutputBox, calcState, OperationBox);
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("8", OutputBox, calcState, OperationBox);
        }

        private void Number9_Click_1(object sender, EventArgs e)
        {
            inputDigit.InputDigit("9", OutputBox, calcState, OperationBox);
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit("0", OutputBox, calcState, OperationBox);
        }

        // Ввод математических действий
        private void OprAdd_Click(object sender, EventArgs e)
        {
            inputButtonOperation.OperationMath(OperationType.add, OutputBox, calcState, OperationBox);
        }

        private void OprSubstraction_Click(object sender, EventArgs e)
        {
            inputButtonOperation.OperationMath(OperationType.substract, OutputBox, calcState, OperationBox);
        }
        private void OprMultiply_Click(object sender, EventArgs e)
        {
            inputButtonOperation.OperationMath(OperationType.multiply, OutputBox, calcState, OperationBox);
        }

        private void OprDivide_Click(object sender, EventArgs e)
        {
            inputButtonOperation.OperationMath(OperationType.divide, OutputBox, calcState, OperationBox);
        }

        // Операция нажатия экранной клавиши: остальные символы и операции
        private void NumberComma_Click(object sender, EventArgs e)
        {
            inputDigit.InputDigit(",", OutputBox, calcState, OperationBox);
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            inputDigit.DeleteDigit(OutputBox);
        }

        private void OprEquals_Click(object sender, EventArgs e)
        {
            inputButtonOperation.OperationEquals(OutputBox, calcState, OperationBox);
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            calcState.CalcClear(OutputBox, OperationBox);
        }

    }// Окончание public partial class CalcForm
}// Окончание namespace Calculator
