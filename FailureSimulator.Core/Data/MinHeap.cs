using System;
using System.Collections.Generic;

namespace FailureSimulator.Core.Data
{
    /// <summary>
    /// Двоичная куча с минимальным элементом в корне
    /// </summary>
    /// <typeparam name="T">Тип данных, хранящийся в куче</typeparam>
    /// <typeparam name="C">Тип компаратора приоритета</typeparam>
    public class MinHeap<T, C> where T : IComparable where C : IHeapPriorityComparer<T>, new()
    {
        // 0 - корень
        // Вершина i:
        //   2*i+1 - левый потомок
        //   2*i+2 - правый потомок
        private List<T> _elements;
        private C _comparer;

        public MinHeap()
        {
            _elements = new List<T>();
            _comparer = new C();
        }

        public MinHeap(int capacity)
        {
            _elements = new List<T>(capacity);
        }

        public void Add(T item)
        {
            _elements.Add(item);

            int itemIndex = _elements.Count - 1;
            int parentIndex = (itemIndex - 1) / 2;

            // Перемещаем элемент вверх до тех пор, пока он не станет меньше родителя
            while (!_comparer.IsHeaped(_elements[parentIndex], _elements[itemIndex]))
            {
                Swap(itemIndex, parentIndex);

                itemIndex = parentIndex;
                parentIndex = (itemIndex - 1) / 2;
            }
        }


        private void Heapify(int index)
        {
            int leftIndex = index * 2 + 1;
            int rightIndex = index * 2 - 1;
            int swapIndex;

            // Нужно ли вообще менять вершины
            if(_comparer.IsHeaped(_elements[index], _elements[leftIndex]))
                return;

            // Определяем потомка с наибольшим приоритетом, с ним и будем менять
            if (_comparer.IsHeaped(_elements[leftIndex], _elements[rightIndex]))
                swapIndex = leftIndex;
            else
                swapIndex = rightIndex;


            Swap(index, swapIndex);
            Heapify(swapIndex);
        }

        private void Swap(int indexA, int indexB)
        {
            var tmp = _elements[indexA];
            _elements[indexA] = _elements[indexB];
            _elements[indexB] = tmp;
        }
    }


    /// <summary>
    /// Определение приоритета
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHeapPriorityComparer<T>
    {
        /// <summary>
        /// Проверяет, что родитель и потомок удовлетворяют основному свойству кучи
        /// </summary>
        /// <param name="parent">Родительский</param>
        /// <param name="child">Потомок</param>
        /// <returns></returns>
        bool IsHeaped(T parent, T child);
    }

    public class MinPriorityComparer<T> : IHeapPriorityComparer<T> where T: IComparable
    {
        public bool IsHeaped(T parent, T child)
        {
            return parent.CompareTo(child) < 0;
        }
    }

}