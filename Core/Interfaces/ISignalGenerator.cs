using Core.Models;

namespace Core.Interfaces;

public interface ISignalGenerator
{
    IEnumerable<SignalPoint> Generate(
        double amplitude,
        double frequency,
        int pointsCount,
        double duration=1);
}