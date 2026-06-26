using Core.Generators;

namespace Tests.Generators;

public class SineSignalGeneratorTests
{
    [Fact]
    public void Generate_ReturnsCorrectCount()
    {
        var generator = new SineSignalGenerator();

        var result = generator
            .Generate(5, 2, 100)
            .ToList();

        Assert.Equal(100, result.Count);
    }

    [Fact]
    public void Generate_Throws_WhenPointsLessThan100()
    {
        var generator = new SineSignalGenerator();

        Assert.Throws<ArgumentException>(
            () => generator.Generate(5, 2, 50).ToList());
    }
}