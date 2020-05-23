using System;
using System.Collections.Generic;
using Xunit;

using GMOKeefe.Compiler.Lexer;

namespace GMOKeefe.Compiler.Tests
{
    public class LexerTest
    {
        [Fact]
        public void TestTokenize1()
        {
            // Arrange
            Tokenizer t = new Tokenizer(
                new DummyReader("(define main() -> int:\r\n(1))")
            );
            List<string> expectedList = new List<string>(12) {
                "(", "define", "main", "(", ")", "->", "int", ":",
                "(", "1", ")", ")"
            };

            // Act
            List<string> outList = t.Tokens();

            // Assert
            Assert.Equal(expectedList, outList);
        }
    }
}
