namespace GMOKeefe.Compiler.Syntax
{
    /// <summary>
    /// Interface for any AST Expression.
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// Evaluates the expression and returns the value.
        /// </summary>
        /// <returns>
        /// The IValue representing the value of the expression.
        /// </returns>
        IValue Eval();
    }
}