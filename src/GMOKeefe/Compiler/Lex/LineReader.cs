using System.IO;

namespace GMOKeefe.Compiler.Lex
{
    /// <summary>
    /// Reads the given text file line-by-line.
    /// </summary>
    public class LineReader : IReader
    {
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
            if (reader == null)
            {
                return true;
            }
            return reader.EndOfStream;
        }

        /// <summary>
        /// Reads one line of the text file.
        /// </summary>
        /// <returns>
        /// One line of the text file.
        /// </returns>
        public string Read()
        {
            string line = reader.ReadLine();

            if (Done())
            {
                reader.Close();
                reader.Dispose();
                reader = null;
            }
            else
            {
                line += System.Environment.NewLine;
            }

            return line;
        }
    }
}