using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Robot robot = new Robot("МшкФредди");
            robot.Work();
            robot.Work();
            robot.Charger();
            robot.Work();
        }
    }

}

