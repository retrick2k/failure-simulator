using System;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Генерация случайных чисел, распределенных по различным законам
    /// </summary>
    public class Distribution
    {
        private Random _rnd;

        public Distribution()
        {
            _rnd = new Random();
        }

        public Distribution(Random rnd)
        {
            _rnd = rnd;
        }

        public double Exponential(double lambda)
        {
            return -1 / lambda * Math.Log(_rnd.NextDouble());
        }

        public double Uniform(double a, double b)
        {
            return a + (b - a) * _rnd.NextDouble();
        }
    }
}