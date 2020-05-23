using Xunit;

using GMOKeefe.Compiler.Lex;

namespace GMOKeefe.Compiler.Tests.Lex
{
    public class LineReaderTest
    {
        [Fact]
        public void TestRead()
        {
            // Arrange
            string expectedText = "(define main() -> int:" + System.Environment.NewLine + "    (1))";
            LineReader lr = new LineReader("../../../example/constant.mza");

            // Act
            string outText = "";
            while (!lr.Done())
            {
                outText += lr.Read();
            }

            // Assert
            Assert.Equal(expectedText, outText);
        }

        [Fact]
        public void TestDone()
        {
            //Arrange
            LineReader lr = new LineReader("../../../example/constant.mza");

            // Act
            while (!lr.Done())
            {
                lr.Read();
            }

            // Assert
            Assert.True(lr.Done());
        }
    }
}