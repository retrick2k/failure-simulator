using System.Collections.Generic;

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
    public class TimeDiagram : Dictionary<string, TimeLine> { }


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
    }
}