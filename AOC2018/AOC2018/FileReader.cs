namespace AOC2018;

public class FileReader
{
    public string ReadFile(string path)
    {
        using var fs = new FileStream(path, FileMode.Open);
        var text = new StreamReader(fs).ReadToEnd();
        return text;
    }
}