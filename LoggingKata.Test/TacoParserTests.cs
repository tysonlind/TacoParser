using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            TacoParser tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("31.570771, -84.10353,   Taco Bell Albany...", -84.10353)]
        [InlineData("32.92496, -85.961342, Taco Bell Alexander Cit...", -85.961342)]
        [InlineData("31.597099, -84.176122, Taco Bell Albany...", -84.176122)]
        [InlineData("34.018008, -86.079099, Taco Bell Attall...", -86.079099)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            TacoParser parser = new TacoParser();
            //Act
            var actual = parser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude


        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("31.570771, -84.10353,   Taco Bell Albany...", 31.570771)]
        [InlineData("32.92496, -85.961342, Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("31.597099, -84.176122, Taco Bell Albany...", 31.597099)]
        [InlineData("34.018008, -86.079099, Taco Bell Attall...", 34.018008)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            TacoParser parser = new TacoParser();
            //Act
            var actual = parser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
