namespace GMOKeefe.Compiler.Lexer
{
    public class FullReader : IReader
    {
        private bool done;
        private string filePath;
        public FullReader(string filePath)
        {
            this.filePath = filePath;
            this.done = false;
        }

        public bool Done()
        {
            return done;
        }

        public string Read()
        {
            if (done != true)
            {
                done = true;
                return System.IO.File.ReadAllText(filePath);
            }
            else
            {
                return "";
            }
        }
    }
}