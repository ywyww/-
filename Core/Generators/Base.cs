namespace Core.Generators;

public abstract class SignalGeneratorBase
{
    protected void Validate(
        double amplitude,
        double frequency,
        int pointsCount,
        double duration)
    {
        if (amplitude <= 0)
            throw new ArgumentException(
                "Амплитуда должна быть больше нуля.");

        if (frequency <= 0)
            throw new ArgumentException(
                "Частота должна быть больше нуля.");

        if (duration <= 0)
            throw new ArgumentException(
                "Длительность должна быть больше нуля.");

        if (pointsCount < 100 || pointsCount > 10000)
            throw new ArgumentException(
                "Количество точек должно быть от 100 до 10000.");
    }
}