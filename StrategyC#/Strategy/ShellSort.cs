using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
   public class ShellSort: SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}
