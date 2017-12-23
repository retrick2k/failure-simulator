namespace FailureSimulator.Core.Probability
{
    /// <summary>
    /// Случайное распределение
    /// </summary>
    public interface IDistribution
    {
        /// <summary>
        /// Генерирует очередное случайное число
        /// </summary>
        /// <returns></returns>
        double Random();

        /// <summary>
        /// Функция плотности распределения вероятности
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        double Density(double x);

        /// <summary>
        /// Матожидание
        /// </summary>
        double ExpectedValue { get; }

        /// <summary>
        /// Дисперсия
        /// </summary>
        double Dispersion { get; }
    }
}