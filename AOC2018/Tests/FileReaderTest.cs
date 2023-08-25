using AOC2018;

namespace Tests;

public class FileReaderTest
{
    [Test]
    [TestCase("../../../../Inputs/Test1.txt", "+12,\n-10")]
    public void Should_ReturnText_When_GivenPath(string path, string expectedResult)
    {
        var reader = new FileReader();
        var text = reader.ReadFile(path);
        Assert.AreEqual(expectedResult, text);
    }
}