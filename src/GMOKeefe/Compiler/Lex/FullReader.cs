using System;

namespace GMOKeefe.Compiler.Lex
{
    /// <summary>
    /// Reads the given text file in its entirety.
    /// </summary>
    public class FullReader : IReader
    {
        private bool done;
        private string filePath;

        /// <summary>
        /// Creates a FullReader given the path of the file to be read.
        /// </summary>
        /// <param name="filePath">
        /// The path of the file to be read.
        /// </param>
        public FullReader(string filePath)
        {
            this.filePath = filePath;
            this.done = false;
        }

        /// <summary>
        /// Indicates whether the FullReader has been used or not.
        /// </summary>
        /// <returns>
        /// A boolean value indicating if the FullReader has been fully used.
        /// </returns>
        public bool Done()
        {
            return done;
        }

        /// <summary>
        /// Reads the text file.
        /// </summary>
        /// <returns>
        /// The entire contents of the text file.
        /// </returns>
        public string Read()
        {
            try
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
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}