using System.Collections;
using System.Collections.Generic;
using FailureSimulator.Core.Graph;

namespace FailureSimulator.Core.Simulator.Report
{
    /// <summary>
    /// Диаграмма восстановления
    /// Хранит в какие моменты в каком состоянии 
    /// (работает, отказ, восстановление) находятся
    /// все узлы и связи
    /// 
    /// Ключ - имя элемента
    /// Значение - последовательность состояний
    /// </summary>
    public class TimeDiagram : Dictionary<IGraphUnit, TimeLine> { }

    /*public class TimeDiagram : IEnumerable<TimeLine>
    {
        private Dictionary<IGraphUnit, TimeLine> _dict;

        public TimeDiagram()
        {
            _dict = new Dictionary<IGraphUnit, TimeLine>();
        }

        public TimeDiagram(IReadOnlyDictionary<IGraphUnit, DestroyableElement> elements)
        {
            _dict = new Dictionary<IGraphUnit, TimeLine>(elements.Count);
            foreach (var element in elements)
                _dict.Add(element.Key, new TimeLine());
        }

        public void Add(IGraphUnit element)
        {
            _dict.Add(element, new TimeLine());
        }

        public IEnumerator<TimeLine> GetEnumerator()
        {
            return _dict.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dict.GetEnumerator();
        }
    }*/

    /// <summary>
    /// Последовательность смены состояний элемента во времени
    /// </summary>
    public class TimeLine : List<StatePoint> { }


    /// <summary>
    /// Состояния элемента
    /// </summary>
    public enum ElementState
    {
        OK,
        FAILURE,
        REPAIR
    }

    /// <summary>
    /// Состояние элемента во времени
    /// </summary>
    public class StatePoint
    {
        public ElementState State { get; set; }
        public double Time { get; set; }

        public override string ToString()
        {
            return $"{State} ({Time})";
        }
    }
}