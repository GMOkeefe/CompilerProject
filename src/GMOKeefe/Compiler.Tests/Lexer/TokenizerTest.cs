using System;
using Xunit;

using GMOKeefe.Compiler.Lexer;

namespace GMOKeefe.Compiler.Tests
{
    public class LexerTest
    {
        [Fact]
        public void TestText()
        {
            // Arrange
            string expectedText = "(define main() -> int:\n    (1))";
            Tokenizer l = new Tokenizer("../../../example/constant.mza");

            // Act
            string outText = l.Text();

            // Assert
            Assert.Equal(expectedText, outText);
        }
    }
}
