using Core.Models;
using Core.Interfaces;

namespace Core.Generators;

public class SineSignalGenerator :
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
                amplitude *
                Math.Sin(
                    2 * Math.PI *
                    frequency *
                    time);

            yield return new SignalPoint(
                time,
                value);
        }
    }

}