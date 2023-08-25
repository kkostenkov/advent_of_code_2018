using AOC2018;

namespace Tests;

public class CalibrationDataParserTest
{
    [Test]
    [TestCase("0", new[] { 0 })]
    [TestCase("+1,\n+1,\n+1", new int[] { 1, 1, 1 })]
    public void Should_ReturnInt_When_ProvidedString(string input, int[] expectedResult)
    {
        var parser = new CalibrationDataParser();
        int[] actualResult = parser.Parse(input);
        Assert.AreEqual(expectedResult, actualResult);
    }
}