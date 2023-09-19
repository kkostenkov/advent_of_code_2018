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

    public int FindFirstFrequencyDuplication(int[] input)
    {
        var freq = 0;
        var known = new HashSet<int>();
        while (true) {
            for (int i = 0; i < input.Length; i++) {
                var num = input[i];
                freq += num;
                if (known.Contains(freq)) {
                    return freq;
                }
                known.Add(freq);
            }
        }
        return int.MinValue;
    }
}