using Core.Models;

namespace Core.Services;

public class SignalAnalyzer
{
    public SignalStatistics Analyze(
        IEnumerable<SignalPoint> signal)
    {
        using var enumerator = signal.GetEnumerator();

        if (!enumerator.MoveNext())
            throw new ArgumentException(
                "Сигнал пуст.");

        var first = enumerator.Current;

        double min = first.Value;
        double max = first.Value;
        double sum = first.Value;
        int count = 1;
        int zeroCrossings = 0;
        double previous = first.Value;

        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;

            min = Math.Min(min, current.Value);
            max = Math.Max(max, current.Value);

            sum += current.Value;
            count++;

            if ((previous < 0 && current.Value >= 0) ||
                (previous > 0 && current.Value <= 0))
            {
                zeroCrossings++;
            }

            previous = current.Value;
        }

        return new SignalStatistics
        {
            Min = min,
            Max = max,
            Average = sum / count,
            ZeroCrossings = zeroCrossings
        };
    }
}
