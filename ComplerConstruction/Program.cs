using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompilerConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            LexicalPhase lp = new LexicalPhase();
            lp.Write();
            Console.ReadKey();
        }
    }
}
