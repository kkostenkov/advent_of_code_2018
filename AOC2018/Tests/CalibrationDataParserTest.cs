using AOC2018;

namespace Tests;

public class CalibrationDataParserTest
{
    [Test]
    [TestCase("0", 0)]
    public void Should_ReturnInt_When_ProvidedString(string input, int expectedResult)
    {
        var parser = new CalibrationDataParser();
        int actualResult = parser.Parse(input);
        Assert.AreEqual(expectedResult, actualResult);
    }
}