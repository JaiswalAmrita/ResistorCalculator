using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResColCodeCalculator
{
    public class ColCodeOutputEnum
    {
       
        //band A band B
        public enum bandAbandB
        {
            black = 0,
            brown = 1,
            red = 2,
            orange = 3,
            yellow = 4,
            green = 5,
            blue = 6,
            violet = 7,
            gray = 8,
            white = 9
        }

        // band C
        public enum bandCMulti
        {
            pink = -3,
            silver = -2,
            gold = -1,
            black = 0,
            brown = 1,
            red = 2,
            orange = 3,
            yellow = 4,
            green = 5,
            blue = 6,
            violet = 7,
            gray = 8,
            white = 9
        }
    }
}
