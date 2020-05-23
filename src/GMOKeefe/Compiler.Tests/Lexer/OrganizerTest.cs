using System.Collections.Generic;
using Xunit;

using GMOKeefe.Compiler.Lexer;
using GMOKeefe.Compiler.Parser;

namespace GMOKeefe.Compiler.Tests
{
    public class OrganizerTest
    {
        [Fact]
        public void TestOrganize()
        {
            // Arrange
            Organizer og = new Organizer(new List<string>(12) {
                "(", "define", "main", "(", ")", "->", "int", ":",
                "(", "1", ")", ")"
            });
            List<IBody> expectedBodies = new List<IBody>(1) {
                new ParentBody(new List<IBody>(7) {
                    new StringBody("define"),
                    new StringBody("main"),
                    new ParentBody(new List<IBody>()),
                    new StringBody("->"),
                    new StringBody("int"),
                    new StringBody(":"),
                    new ParentBody(new List<IBody>(1) {
                        new StringBody("1")
                    })
                })
            };

            // Act
            List<IBody> actualBodies = og.Organize();

            // Assert
            bool equality = true;

            if (expectedBodies.Count == actualBodies.Count)
            {
                for (int i = 0; i < expectedBodies.Count; i++)
                {
                    if (!expectedBodies[i].Equals(actualBodies[i]))
                    {
                        equality = false;
                    }
                }
            }

            Assert.True(equality);
        }
    }
}