using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public static class SequenceTestHelper
    {
        public static bool TestLinearSquence(List<int> sequence, int input, int first, int delta)
        {
            //initally not correct
            var rtn = false;
            //check length
            if (sequence.Count > 0)
            {
                rtn = first == sequence[0];

                //only do sequence test if sequence length greater than 1
                if (sequence.Count > 2)
                    for (int i = 0; i < sequence.Count - 1; i++)
                    {
                        rtn = sequence[i] + delta == sequence[i + 1];
                        if (rtn == false) break;
                    }
            }
            else if (input < first) { //it is correct not to have any elements if input is less than value
                rtn = true;
            }
            return rtn;
        }

    }
}
