using System;

namespace GMOKeefe.Compiler.Parser
{
    /// <summary>
    /// An exception that represents a lack of a matching closing mark for a corresponding opening mark.
    /// </summary>
    public class UnmatchedParenException : Exception
    {
        /// <summary>
        /// Creates a new UnmatchedParenException.
        /// </summary>
        /// <param name="paren">
        /// The opening mark that caused this error.
        /// </param>
        public UnmatchedParenException(string paren)
            : base("Opening paren without matching close paren: " + paren)
        {
        }
    }
}