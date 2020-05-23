using GMOKeefe.Compiler.Lexer;

namespace GMOKeefe.Compiler.Tests
{
    /// Acts as a TextReader, but only returns the given text.\
    /// For debugging purposes.
    public class DummyReader : IReader
    {
        private bool done;
        private string text;

        public DummyReader(string text)
        {
            this.text = text;
            this.done = false;
        }

        public bool Done()
        {
            return done;
        }

        public string Read()
        {
            done = true;
            return text;
        }
    }
}