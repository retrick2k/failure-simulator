using System;

namespace FailureSimulator.Core.Probability
{
    /// <summary>
    /// Экспоненциальное распределение
    /// </summary>
    public class ExponentialDistribution : BaseDistribution, IDistribution
    {
        private double _lambda;

        /// <summary>
        /// Создает распределение
        /// </summary>
        /// <param name="lambda">Параметр распределения</param>
        public ExponentialDistribution(double lambda, int seed):base(seed)
        {
            _lambda = lambda;
        }

        public double Random()
        {
            return -1 / _lambda * Math.Log(GetRandom());
        }

        public double Density(double x)
        {
            throw new System.NotImplementedException();
        }

        public double ExpectedValue { get; }
        public double Dispersion { get; }
    }
}