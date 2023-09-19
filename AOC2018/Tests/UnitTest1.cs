namespace Tests;

public class Tests
{
    [TestCase(new[] { 1, 1, 1 }, ExpectedResult = 3)]
    public int Should_CalculateSum_When_OnInput(int[] input)
    {
        var frequencyCalc = new FrequencyCalculator();
        var result = frequencyCalc.Calculate(input);

        return result;
    }
}