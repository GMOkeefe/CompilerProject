using System;
using GMOKeefe.Compiler.Lexer;

namespace GMOKeefe.ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            FullReader fr = new FullReader("./example/constant.mza");
            Console.WriteLine(fr.Read());
        }
    }
}
