using Core.Models;
namespace Core.Interfaces;

public interface ISignalSaver
{
    string Save(
        string signalType,
        double amplitude,
        double frequency,
        IEnumerable<SignalPoint> points);
}