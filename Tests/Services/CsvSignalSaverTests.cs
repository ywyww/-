using Core.Services.Savers;

namespace Tests.Services;

public class CsvSignalSaverTests
{
    [Fact]
    public void Save_CreatesFile()
    {
        var saver = new CsvSignalSaver();

        var file = saver.Save(
            "sine",
            5,
            2,
            []);

        Assert.True(File.Exists(file));

        File.Delete(file);
    }
}