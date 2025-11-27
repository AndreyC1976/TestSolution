using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputState
    {
        public string digitInput {  get; set; }
        public string inputBoxTextCurrent {  get; set; }
        public string inputBoxTextNew { get; set; }
        public int currentCommaPosition { get; set; }
        public int newCommaPosition { get; set; }
        public int lengthLimit { get; set; } = 0;
    }
}
