namespace GMOKeefe.Compiler.Lex
{
    /// <summary>
    /// The Reader interface.\
    /// Defines the functionality necessary for the Lexer to read code.
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Indicates whether the Reader has been used or not.
        /// </summary>
        /// <returns>
        /// A boolean value indicating if the Reader has been fully used.
        /// </returns>
        bool Done();

        /// <summary>
        /// Reads the text file, either whole or in part.
        /// </summary>
        /// <returns>
        /// Some portion of the text in the text file.
        /// </returns>
        string Read();
    }
}