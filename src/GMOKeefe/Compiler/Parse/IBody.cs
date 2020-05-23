namespace GMOKeefe.Compiler.Parse
{
    /// <summary>
    /// An interface that represents the union of the string and the list of IBodys.
    /// </summary>
    public interface IBody
    {
        /// <summary>
        /// Generates the hash code of this IBody.
        /// </summary>
        /// <returns>
        /// The hash code.
        /// </returns>
        int GetHashCode();

        /// <summary>
        /// Checks if the object is equal to another object.
        /// </summary>
        /// <param name="obj">
        /// The other object to test.
        /// </param>
        /// <returns>
        /// True if they are equal, false if not.
        /// </returns>
        bool Equals(object obj);
    }
}