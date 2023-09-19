namespace Tests;

public class FileReaderTest
{
    [TestCase("input/test_frequency.txt", ExpectedResult = "-1\n-2\n-3")]
    public string Should_CalculateSum_When_GivenFilePassInput(string path)
    {
        var reader = new FrequencyFileReader();
        var result = reader.Read(path);
        return result;
    }
}

public class FrequencyFileReader
{
    public string Read(string path)
    {
        var result = File.ReadAllText("../../../../" + path);
        return result;
    }
}