using Core.Models;
using Core.Interfaces;

namespace Core.Generators;

public class SquareSignalGenerator :
    SignalGeneratorBase,
    ISignalGenerator
{
    public IEnumerable<SignalPoint> Generate(
        double amplitude,
        double frequency,
        int pointsCount,
        double duration=1)
    {
        Validate(
            amplitude,
            frequency,
            pointsCount,
            duration);

        double dt = duration / pointsCount;

        for (int i = 0; i < pointsCount; i++)
        {
            double time = i * dt;

            double value =
                Math.Sin(
                    2 * Math.PI *
                    frequency *
                    time) >= 0
                        ? amplitude
                        : -amplitude;

            yield return new SignalPoint(
                time,
                value);
        }
    }
}