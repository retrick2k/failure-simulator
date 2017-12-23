using System;

namespace FailureSimulator.Core.Probability
{
    public class BaseDistribution
    {
        private Random _rnd;

        protected BaseDistribution(int seed = 0)
        {
            _rnd = new Random(seed);
        }

        protected double GetRandom() => _rnd.NextDouble();
    }
}