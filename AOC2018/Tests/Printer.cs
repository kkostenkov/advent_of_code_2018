namespace Tests;

public class Printer
{
    [Test]
    public void PrintResultForTask1()
    {
        var input = (new FrequencyFileReader()).Read("input/frequency.txt");
        var calc = new FrequencyCalculator();
        Console.WriteLine(calc.Calculate(input));
    }
}