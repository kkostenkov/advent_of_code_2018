namespace AOC2018;

public class Device
{
    private int[] calibrationData;
    private int? firstDuplicatedFreq;
        
    public int Calibrate(string calibrationInput)
    {
        var parser = new CalibrationDataParser();
        calibrationData = parser.Parse(calibrationInput);

        var result = SumFrequecies(calibrationData);

        return result;
    }

    private int SumFrequecies(int[] numbers)
    {
        var result = 0;
        foreach (var number in numbers) {
            result += number;
        }
        return result;
    }

    public int? GetFirstDuplicatedFrequency()
    {
        return firstDuplicatedFreq;
    }
}