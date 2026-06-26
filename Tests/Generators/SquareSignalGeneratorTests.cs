using Core.Generators;

namespace Tests.Generators;

public class SquareSignalGeneratorTests
{
    [Fact]
    public void Generate_ContainsOnlyAmplitudeValues()
    {
        var generator = new SquareSignalGenerator();

        var signal = generator
            .Generate(5, 2, 100)
            .ToList();

        Assert.All(signal,
            p => Assert.True(
                p.Value == 5 ||
                p.Value == -5));
    }
}