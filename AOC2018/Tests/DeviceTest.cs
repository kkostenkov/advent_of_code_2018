using AOC2018;

namespace Tests;

public class Tests
{
    [Test]
    [TestCase("+1,\n+1,\n+1", 3)]
    [TestCase("+1,\n+1,\n-2", 0)]
    [TestCase("-1,\n-2,\n-3", -6)]
    public void Should_ParseDigits_When_GivenInput(string calibrationData, int expectedResult)
    {
        var device = new Device();
        var actualResult = device.Calibrate(calibrationData);
        Assert.AreEqual(expectedResult, actualResult);
    }
}