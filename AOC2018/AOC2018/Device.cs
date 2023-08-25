namespace AOC2018;

public class Device
{
    public int Calibrate(string calibrationData)
    {
        var parser = new CalibrationDataParser();
        var numbers = parser.Parse(calibrationData);
        var result = numbers.Sum();

        return result;
    }
}