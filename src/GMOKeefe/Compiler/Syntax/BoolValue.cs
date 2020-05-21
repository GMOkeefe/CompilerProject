namespace GMOKeefe.Compiler.Syntax
{
    /// <summary>
    /// Representation of a boolean value.
    /// </summary>
    public class BoolValue : IValue
    {
        bool value;

        /// <summary>
        /// Creates a BoolValue based on the given value.
        /// </summary>
        /// <param name="value">
        /// The boolean that sets the value.
        /// </param>
        public BoolValue(bool value)
        {
            this.value = value;
        }

        /// <summary>
        /// Retrieves the actual value of this IValue.
        /// </summary>
        /// <returns>
        /// The boolean that represents the actual value.
        /// </returns>
        public object Value()
        {
            return value;
        }
    }
}