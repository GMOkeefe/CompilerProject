using Xunit;

using GMOKeefe.Compiler.Lexer;

namespace GMOKeefe.Compiler.Tests.Lexer
{
    public class FullReaderTest
    {
        [Fact]
        public void TestRead()
        {
            // Arrange
            string expectedText = "(define main() -> int:" + System.Environment.NewLine + "    (1))";
            FullReader fr = new FullReader("../../../example/constant.mza");

            // Act
            string outText = fr.Read();

            // Assert
            Assert.Equal(expectedText, outText);
        }

        [Fact]
        public void TestDone()
        {
            //Arrange
            FullReader fr = new FullReader("../../../example/constant.mza");

            // Act
            fr.Read();

            // Assert
            Assert.True(fr.Done());
        }
    }
}