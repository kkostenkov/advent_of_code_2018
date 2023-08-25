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

    [Test]
    [TestCase("+1,\n-1", 0)]
    [TestCase("+3,\n+3,\n+4,\n-2,\n-4", 10)]
    [TestCase("-6,\n+3,\n+8,\n+5,\n-6", 5)]
    [TestCase("+7,\n+7,\n-2,\n-7,\n-4", 14)]
    public void Should_RecordVisitedFrequences_When_GivenInput(string calibrationData, int expectedResult)
    {
        var device = new Device();
        device.Calibrate(calibrationData);
        var recordedFrequences = device.GetFirstDuplicatedFrequency();
        
        Assert.AreEqual(expectedResult, recordedFrequences);
    }

}