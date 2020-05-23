using System;
using GMOKeefe.Compiler.Lex;

namespace GMOKeefe.ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Tokenizer t = new Tokenizer("./example/constant.mza");

            Console.Write("Tokens: { ");
            foreach (var s in t.Tokens())
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine("\b\b }");
        }
    }
}
