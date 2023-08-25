namespace AOC2018;

public class Device
{
    private int? firstDuplicatedFreq;
        
    public int Calibrate(string calibrationData)
    {
        var parser = new CalibrationDataParser();
        var numbers = parser.Parse(calibrationData);

        var result = SumFrequecies(numbers);

        return result;
    }

    private int SumFrequecies(int[] numbers)
    {
        var result = 0;
        var hashedFreqs = new HashSet<int>();
        foreach (var number in numbers) {
            result += number;
            if (firstDuplicatedFreq == null) {
                if (hashedFreqs.Contains(number)) {
                    firstDuplicatedFreq = number;
                }
                else {
                    hashedFreqs.Add(number);
                }
            }
        }
        return result;
    }

    public int? GetFirstDuplicatedFrequency()
    {
        return firstDuplicatedFreq;
    }
}