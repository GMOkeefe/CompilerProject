using System.IO;

namespace GMOKeefe.Compiler.Lexer
{
    public class LineReader : IReader
    {
        private bool done;
        private string filePath;

        private StreamReader reader;

        public LineReader(string filePath)
        {
            this.filePath = filePath;
            this.done = false;

            this.reader = new StreamReader(filePath);
        }

        public bool Done()
        {
            return done;
        }

        public string Read()
        {
            string line;
            if ((line = reader.ReadLine()) == null)
            {
                done = true;
                reader.Close();
                return "";
            }
            else
            {
                return line;
            }
        }
    }
}