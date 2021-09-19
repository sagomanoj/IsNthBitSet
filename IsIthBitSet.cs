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
           return  ((number >> i) & 1) == 1;
        }

    }
}
