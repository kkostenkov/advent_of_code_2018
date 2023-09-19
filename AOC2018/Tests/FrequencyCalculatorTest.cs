namespace Tests;

public class FrequencyCalculatorTest
{
    [TestCase(new[] { 3, 3, 4, -2, -4 }, ExpectedResult = 10)]
    public int Should_RememberFirstAlreadyVisitedFrequency(int[] input)
    {
        var frequencyCalc = new FrequencyCalculator();
        var result = frequencyCalc.FindFirstFrequencyDuplication(input);
        return result;
    }


    [TestCase(new[] { 1, 1, 1 }, ExpectedResult = 3)]
    [TestCase(new[] { -1, -2, -3 }, ExpectedResult = -6)]
    public int Should_CalculateSum_When_OnInput(int[] input)
    {
        var frequencyCalc = new FrequencyCalculator();
        var result = frequencyCalc.Calculate(input);

        return result;
    }
    
    [TestCase(new[] { 1, 1, 1 }, ExpectedResult = 3)]
    [TestCase(new[] { -1, -2, -3 }, ExpectedResult = -6)]
    public int Should_CalculateListSum_When_OnInput(int[] input)
    {
        var frequencyCalc = new FrequencyCalculator();
        var result = frequencyCalc.Calculate(input.ToList());

        return result;
    }

    [TestCase("1\n1\n1", ExpectedResult = 3)]
    [TestCase("-1\n-2\n-3", ExpectedResult = -6)]
    [TestCase(null, ExpectedResult = 0)]
    [TestCase("", ExpectedResult = 0)]
    public int Should_CalculateSum_When_GivenStringInput(string input)
    {
        var frequencyCalc = new FrequencyCalculator();
        var result = frequencyCalc.Calculate(input);
        return result; 
    }
}