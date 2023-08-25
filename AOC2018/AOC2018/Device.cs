namespace AOC2018;

public class Device
{
    private int[] visitedFrequencies;
        
    public int Calibrate(string calibrationData)
    {
        var parser = new CalibrationDataParser();
        var numbers = parser.Parse(calibrationData);

        visitedFrequencies = numbers;
        
        var result = numbers.Sum();

        return result;
    }

    public int GetFirstDuplicatedFrequency()
    {
        return 0;
    }
}