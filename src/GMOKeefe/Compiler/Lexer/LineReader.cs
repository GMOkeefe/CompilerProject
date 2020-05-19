using System.IO;

namespace GMOKeefe.Compiler.Lexer
{
    /// <summary>
    /// Reads the given text file line-by-line.
    /// </summary>
    public class LineReader : IReader
    {
        private bool done;
        private string filePath;

        private StreamReader reader;

        /// <summary>
        /// Creates a LineReader given the path of the file to be read.
        /// </summary>
        /// <param name="filePath">
        /// The path of the file to be read.
        /// </param>
        public LineReader(string filePath)
        {
            this.filePath = filePath;
            this.done = false;

            this.reader = new StreamReader(filePath);
        }

        /// <summary>
        /// Indicates whether the LineReader has been used or not.
        /// </summary>
        /// <returns>
        /// A boolean value indicating if the LineReader has been fully used.
        /// </returns>
        public bool Done()
        {
            return done;
        }

        /// <summary>
        /// Reads one line of the text file.
        /// </summary>
        /// <returns>
        /// One line of the text file.
        /// </returns>
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