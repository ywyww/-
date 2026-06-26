using System.Globalization;
using Core.Models;
using Core.Interfaces;

namespace Core.Services.Savers;

public class CsvSignalSaver : ISignalSaver
{
    public string Save(
        string signalType,
        double amplitude,
        double frequency,
        IEnumerable<SignalPoint> points)
    {
        var fileName =
            $"{signalType}_A{amplitude}_F{frequency}_{DateTime.Now:yyyyMMddHHmmss}.csv";

        using var writer = new StreamWriter(fileName);

        writer.WriteLine($"Type: {signalType}");
        writer.WriteLine($"Amplitude: {amplitude}");
        writer.WriteLine($"Frequency: {frequency}");
        writer.WriteLine();
        writer.WriteLine("Time,Value");

        foreach (var point in points)
        {
            writer.WriteLine(
                $"{point.Time.ToString(CultureInfo.InvariantCulture)}," +
                $"{point.Value.ToString(CultureInfo.InvariantCulture)}");
        }

        return fileName;
    }
}