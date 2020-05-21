namespace GMOKeefe.Compiler.Syntax
{
    /// <summary>
    /// Expression that contains a boolean value.
    /// </summary>
    public class BoolExpr : IExpression
    {
        bool value;

        /// <summary>
        /// Creates a BoolExpr based on a given boolean.
        /// </summary>
        /// <param name="value">
        /// The boolean that sets the value.
        /// </param>
        public BoolExpr(bool value)
        {
            this.value = value;
        }

        /// <summary>
        /// Returns the IValue that this Expression evaluates to.
        /// </summary>
        /// <returns>
        /// The IValue that represents the value of this Expression.
        /// </returns>
        public IValue Eval()
        {
            return new BoolValue(value);
        }
    }
}