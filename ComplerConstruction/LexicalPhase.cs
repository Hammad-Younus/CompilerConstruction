using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompilerConstruction
{
    class LexicalPhase
    {
        public string[] classPart;
        public string[] valuePart;
        int lineNo = 0;
        public string[] Code;

        public void ReadFile()
        {
            string text;
            using (StreamReader sr = new StreamReader(@"D:\CC_Work\CompilerConstruction\Files\Main.txt"))
            {
                text = sr.ReadToEnd();
            }
        }
    }
}
