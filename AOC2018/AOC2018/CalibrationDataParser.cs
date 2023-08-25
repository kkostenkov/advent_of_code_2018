namespace AOC2018;

public class CalibrationDataParser
{
    public int[] Parse(string input)
    {
        var textDigits = input.Split("\n").ToList();
        for (var index = 0; index < textDigits.Count; index++) {
            var s = textDigits[index];
            textDigits[index] = s.TrimEnd(',');
        }

        var result = textDigits.Select(int.Parse);
        return result.ToArray();
    }
}