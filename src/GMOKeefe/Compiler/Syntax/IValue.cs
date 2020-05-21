namespace GMOKeefe.Compiler.Syntax
{
    /// <summary>
    /// The abstract representation of a value.
    /// </summary>
    public interface IValue
    {
        /// <summary>
        /// Generates the native value.
        /// </summary>
        /// <returns>
        /// The natively represented value.
        /// </returns>
        object Value();
    }
}