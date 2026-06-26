using Core.Generators;

var generator = new SineSignalGenerator();

foreach (var point in generator.Generate(5, 2, 200))
{
    Console.WriteLine($"{point.Time} {point.Value}");
}