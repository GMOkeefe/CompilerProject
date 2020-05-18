using System;
using GMOKeefe.Compiler.Lexer;

namespace Compiler_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string frText = "";
            FullReader fr = new FullReader("./example/constant.mza");

            string lrText = "";
            LineReader lr = new LineReader("./example/constant.mza");

            while (!fr.Done())
            {
                frText += fr.Read();
            }
            frText += "\n";

            while (!lr.Done())
            {
                lrText += lr.Read() + "\n";
            }

            Console.WriteLine(frText);
            Console.WriteLine(lrText);
        }
    }
}
