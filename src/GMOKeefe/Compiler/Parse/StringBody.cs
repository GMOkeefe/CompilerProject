using System;

namespace GMOKeefe.Compiler.Parse
{
    /// <summary>
    /// An IBody that contains a string.
    /// </summary>
    public class StringBody : IBody
    {
        private string body;

        /// <summary>
        /// Creates a new StringBody.
        /// </summary>
        /// <param name="body">
        /// The string that the StringBody contains.
        /// </param>
        public StringBody(string body)
        {
            this.body = body;
        }

        /// <summary>
        /// Retrieves the string that the StringBody contains.
        /// </summary>
        /// <returns>
        /// The string that the StringBody contains.
        /// </returns>
        public string GetString()
        {
            return body;
        }

        /// <summary>
        /// Creates a hash code for the current StringBody.
        /// </summary>
        /// <returns>
        /// The hash code of the string inside the StringBody.
        /// </returns>
        public override int GetHashCode()
        {
            return body.GetHashCode();
        }

        /// <summary>
        /// Checks for equality with any object.
        /// </summary>
        /// <param name="obj">
        /// The other object.
        /// </param>
        /// <returns>
        /// True if they are equal, false if not.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as StringBody);
        }

        /// <summary>
        /// Checks for equality with another StringBody.
        /// </summary>
        /// <param name="s">
        /// The other StringBody.
        /// </param>
        /// <returns>
        /// True if they are equal, false if not.
        /// </returns>
        public bool Equals(StringBody s)
        {
            if (Object.ReferenceEquals(s, null))
            {
                return false;
            }
            else if (Object.ReferenceEquals(this, s))
            {
                return true;
            }
            else if (this.GetType() != s.GetType())
            {
                return false;
            }

            return this.body == s.body;
        }
    }
}