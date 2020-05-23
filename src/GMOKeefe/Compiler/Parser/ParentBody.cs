using System;
using System.Collections.Generic;

namespace GMOKeefe.Compiler.Parser
{
    /// <summary>
    /// An IBody that contains a list of IBody's.
    /// </summary>
    public class ParentBody : IBody
    {
        private Dictionary<string, string> OPEN_CLOSE_CHARS;

        private List<IBody> children;

        /// <summary>
        /// Creates a new ParentBody.
        /// </summary>
        public ParentBody()
        {
            OPEN_CLOSE_CHARS = new Dictionary<string, string>();
            OPEN_CLOSE_CHARS.Add("(", ")");
            OPEN_CLOSE_CHARS.Add("{", "}");
            OPEN_CLOSE_CHARS.Add("[", "]");
            OPEN_CLOSE_CHARS.Add("<", ">");
            OPEN_CLOSE_CHARS.Add("\"", "\"");
            OPEN_CLOSE_CHARS.Add("\'", "\'");

            children = new List<IBody>();
        }

        /// <summary>
        /// Creates a new ParentBody given a list of child IBodys.
        /// </summary>
        /// <param name="children">
        /// The list of child IBodys that this ParentBody contains.
        /// </param>
        public ParentBody(List<IBody> children)
        {
            OPEN_CLOSE_CHARS = new Dictionary<string, string>();
            OPEN_CLOSE_CHARS.Add("(", ")");
            OPEN_CLOSE_CHARS.Add("{", "}");
            OPEN_CLOSE_CHARS.Add("[", "]");
            OPEN_CLOSE_CHARS.Add("<", ">");
            OPEN_CLOSE_CHARS.Add("\"", "\"");
            OPEN_CLOSE_CHARS.Add("\'", "\'");

            this.children = children;
        }

        /// <summary>
        /// Adds a new child IBody.
        /// </summary>
        /// <param name="child">
        /// The child IBody to be added.
        /// </param>
        public void AddChild(IBody child)
        {
            children.Add(child);
        }

        /// <summary>
        /// Converts a list of strings into a list of bodies. Call when encountering an opening paren for the first time.
        /// </summary>
        /// <param name="opener">
        /// The opening paren that starts this call.
        /// </param>
        /// <param name="rest">
        /// Every string in the list after the opening paren.
        /// </param>
        /// <returns>
        /// The strings in the list after the closing paren.
        /// </returns>
        public List<string> Associate(string opener, List<string> rest)
        {
            for (int i = 0; i < rest.Count; i++)
            {
                string val;

                if (OPEN_CLOSE_CHARS.ContainsKey(rest[i]))
                {
                    ParentBody newBody = new ParentBody();

                    rest = newBody.Associate(rest[i],
                        rest.GetRange(i + 1, rest.Count - (i + 1)));
                    i = -1;

                    children.Add(newBody);
                }
                else if (OPEN_CLOSE_CHARS.TryGetValue(opener, out val) && rest[i] == val)
                {
                    if (i >= rest.Count - 1)
                    {
                        return new List<string>();
                    }
                    return rest.GetRange(i + 1, rest.Count - (i + 1));
                }
                else {
                    children.Add(new StringBody(rest[i]));
                }
            }

            throw new UnmatchedParenException(opener);
        }

        /// <summary>
        /// Generates a hash code for this ParentBody.
        /// </summary>
        /// <returns>
        /// The hash code representing the current state of the ParentBody.
        /// </returns>
        public override int GetHashCode()
        {
            int sum = 0;

            foreach (var c in children)
            {
                sum += c.GetHashCode();
            }

            return sum;
        }

        /// <summary>
        /// Checks equality with any object.
        /// </summary>
        /// <param name="obj">
        /// The object to compare with.
        /// </param>
        /// <returns>
        /// True if they are equal, false if not.
        /// </returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as ParentBody);
        }

        /// <summary>
        /// Checks equality with another ParentBody.
        /// </summary>
        /// <param name="p">
        /// The other ParentBody.
        /// </param>
        /// <returns>
        /// True if the children match, false if not.
        /// </returns>
        public bool Equals(ParentBody p)
        {
            if (Object.ReferenceEquals(p, null))
            {
                return false;
            }
            else if (Object.ReferenceEquals(this, p))
            {
                return true;
            }
            else if (this.GetType() != p.GetType())
            {
                return false;
            }
            else if (this.children.Count != p.children.Count)
            {
                return false;
            }

            bool equality = true;

            for (int i = 0; i < this.children.Count; i++)
            {
                if (!this.children[i].Equals(p.children[i]))
                {
                    equality = false;
                }
            }

            return equality;
        }
    }
}