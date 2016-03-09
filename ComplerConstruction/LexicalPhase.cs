using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompilerConstruction
{
    class LexicalPhase
    {
        public string[] keywords = new string[] {"bold","div","alpha","bit","twine","stop","current","obj","def","empty","begin","Continue","Either","Or","Or Either","At","Proc","Allign","Template"};
        public string[] Punctuators = new string[] {"(", ")", "{", "}",".."};
        public string WordBreaker = ",.:(){}='..' ";
        public string[] classPart;
        public string[] valuePart;
        string[] split = null;
        int lineNo = 0;

        public void ReadFile()
        {
            string text;
            using (StreamReader sr = new StreamReader(@"D:\CC_Work\CompilerConstruction\Files\Main.txt"))
            {
                char[] Delimeters = WordBreaker.ToCharArray();
                do
                {
                   text = sr.ReadLine();
                   lineNo++;
                   int i = lineNo;
                   split = text.Split(Delimeters,Delimeters.Length);
                   Console.WriteLine("\nLine Number = {0} ",i);
	               foreach (string s in split) 
                   {
                        Console.WriteLine("Keyword = {0} ", s);
  	               }
                }while(text != null);
            }
        }
    }
}
