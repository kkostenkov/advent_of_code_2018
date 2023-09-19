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
        return 0;
        if (string.IsNullOrEmpty(input))
        {}
        
    }
}