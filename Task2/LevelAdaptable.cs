using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal interface LevelAdjustable
    {
        int Level { get; }
        
        void SetLevel(int level);
    }
}
