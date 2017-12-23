using System;

namespace FailureSimulator.Core.Probability
{
    public class UniformDistribution : BaseDistribution, IDistribution
    {
        private double _a, _b;

        /// <summary>
        /// Создает распределение в интеравале (a, b)
        /// </summary>
        /// <param name="a">Нижняя граница интервала</param>
        /// <param name="b">Верхняя граница интервала</param>
        public UniformDistribution(double a, double b, int seed = 0) : base(seed)
        {
            _a = a;
            _b = b;
        }

        public double Random()
        {
            return _a + (_b - _a) * GetRandom();
        }

        public double Density(double x)
        {
            throw new System.NotImplementedException();
        }

        public double ExpectedValue { get; }
        public double Dispersion { get; }
    }
}