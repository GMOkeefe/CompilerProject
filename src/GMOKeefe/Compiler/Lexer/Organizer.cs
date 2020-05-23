using System.Collections.Generic;

using GMOKeefe.Compiler.Parser;

namespace GMOKeefe.Compiler.Lexer
{
    /// <summary>
    /// Organizes a list of string tokens into a hierarchical structure based on opening and closing symbols.
    /// </summary>
    public class Organizer
    {
        private Dictionary<string, string> OPEN_CLOSE_CHARS;
        private List<string> tokens;

        /// <summary>
        /// Creates a new Organizer based on a list of string tokens.
        /// </summary>
        /// <param name="tokens">
        /// The string tokens (presumably given by the Tokenizer).
        /// </param>
        public Organizer(List<string> tokens)
        {
            OPEN_CLOSE_CHARS = new Dictionary<string, string>();
            OPEN_CLOSE_CHARS.Add("(", ")");
            OPEN_CLOSE_CHARS.Add("{", "}");
            OPEN_CLOSE_CHARS.Add("[", "]");
            OPEN_CLOSE_CHARS.Add("<", ">");
            OPEN_CLOSE_CHARS.Add("\"", "\"");
            OPEN_CLOSE_CHARS.Add("\'", "\'");

            this.tokens = tokens;
        }

        /// <summary>
        /// Organizes the string tokens into a list of IBodys.
        /// </summary>
        /// <returns>
        /// The hierarchical list of IBodys.
        /// </returns>
        public List<IBody> Organize()
        {
            List<IBody> bodies = new List<IBody>();
            List<string> temp = tokens;

            for (int i = 0; i < temp.Count; i++)
            {
                if (OPEN_CLOSE_CHARS.ContainsKey(temp[i]))
                {
                    ParentBody newParent = new ParentBody();
                    temp = newParent.Associate(temp[i],
                        temp.GetRange(i + 1, temp.Count - (i + 1)));
                    i = -1;

                    bodies.Add(newParent);
                }
                else
                {
                    bodies.Add(new StringBody(temp[i]));
                }
            }

            return bodies;
        }
    }
}