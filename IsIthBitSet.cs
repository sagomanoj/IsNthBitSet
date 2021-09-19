using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class IsIthBitSet
    {
        //Given a number and find if the i the bit is Set

        //Move the number i times right and do & with 1, if 1 then i th bit is set
        public bool isIthBitSet(int number,int i)
        {
            //100100
            //   1>> to last position then AND with 1
            return ((number >> i) & 1) == 1;
        }

        //Shift 1 by i times to the left and do AND operation with 1 .
        public bool IsIthBitSetByLeftShift(int number, int i)
        {
            //100100
            //   <<1 
            //move 1 left to the i times then do AND with number if result > 0 then i th bit is Sets
            return (number & (1 << i)) > 0;
        }

    }
}
