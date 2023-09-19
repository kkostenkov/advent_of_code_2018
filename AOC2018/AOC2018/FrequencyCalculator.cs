namespace Tests;

public class FrequencyCalculator
{
    public int Calculate(int[] input)
    {
        return input.Sum();
    }
    
    public int Calculate(List<int> input)
    {
        return input.Sum();
    }

    public int Calculate(string input)
    {
        if (string.IsNullOrEmpty(input)) {
            return 0;
        }
        var numbers = input.Split("\n").Select(int.Parse).ToArray();
        return Calculate(numbers);
    }
}