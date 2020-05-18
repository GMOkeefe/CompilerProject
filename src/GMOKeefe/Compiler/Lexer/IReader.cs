namespace GMOKeefe.Compiler.Lexer
{
    public interface IReader
    {
        bool Done();
        string Read();
    }
}