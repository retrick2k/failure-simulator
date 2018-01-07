using System;
using System.Collections.Generic;
using System.Linq;

namespace FailureSimulator.Core.DataStruct
{
    /// <summary>
    /// Двоичная куча
    /// </summary>
    /// <typeparam name="T">Тип данных, хранящийся в куче</typeparam>
    /// <typeparam name="C">Тип компаратора приоритета</typeparam>
    public class Heap<T> where T : IComparable<T>
    {
        // 0 - корень
        // Вершина i:
        //   2*i+1 - левый потомок
        //   2*i+2 - правый потомок
        private List<T> _elements;
        private IHeapPriorityComparer<T> _comparer;


        /// <summary>
        /// Создает кучу
        /// </summary>
        public Heap(IHeapPriorityComparer<T> comparer)
        {
            _elements = new List<T>();
            _comparer = comparer;
        }

        /// <summary>
        /// Создает кучу заданного начального размераы
        /// </summary>
        /// <param name="capacity"></param>
        public Heap(IHeapPriorityComparer<T> comparer, int capacity)
        {
            _elements = new List<T>(capacity);
            _comparer = comparer;
        }

        /// <summary>
        /// Создает кучу на основе данных
        /// </summary>
        /// <param name="elements"></param>
        public Heap(IHeapPriorityComparer<T> comparer, IEnumerable<T> elements)
        {
            /* 1. Просто кладем произвольно в кучу
             * 2. Вызываем Heapefi для всех вершин с хотя бы одним потомком
             * 3. Потомок есть у первых heap_size/2
             */

            _comparer = comparer;
            _elements = elements.ToList();
            for(int i = _elements.Count / 2; i>=0; i--)
                Heapify(i);
        }

        public void Add(T item)
        {
            _elements.Add(item);

            int itemIndex = _elements.Count - 1;
            int parentIndex = (itemIndex - 1) / 2;

            // Перемещаем элемент вверх до тех пор, пока он не станет меньше родителя
            while (itemIndex > 0 && !_comparer.IsHeaped(_elements[parentIndex], _elements[itemIndex]))
            {
                Swap(itemIndex, parentIndex);

                itemIndex = parentIndex;
                parentIndex = (itemIndex - 1) / 2;
            }
        }

        /// <summary>
        /// Возвращает максимальный (согласно заданному критерию)
        /// элемент       
        /// </summary>
        public T First
        {
            get
            {
                if (_elements.Count == 0)
                    throw new IndexOutOfRangeException("Heap is empty");

                return _elements[0];
            }
        }

        /// <summary>
        /// Количество элементов в куче
        /// </summary>
        public int Count => _elements.Count;

        /// <summary>
        /// Удаляет максимальный (согласно заданному критерию)
        /// элемент
        /// </summary>
        public T Pop()
        {

            if (_elements.Count == 0)
                throw new IndexOutOfRangeException("Heap is empty");

            var top = _elements[0];

            _elements[0] = _elements[_elements.Count - 1];
            _elements.RemoveAt(_elements.Count-1);
            Heapify(0);

            return top;
        }

        // Восстанавливает кучу
        private void Heapify(int index)
        {
            while (true)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int largestChild = index;

                if (leftChild < _elements.Count && _comparer.IsHeaped(_elements[leftChild], _elements[largestChild]))
                    largestChild = leftChild;
                

                if (rightChild < _elements.Count && _comparer.IsHeaped(_elements[rightChild], _elements[largestChild]))                
                    largestChild = rightChild;                

                if (largestChild == index)                
                    break;                                

                Swap(index, largestChild);
                index = largestChild;
            }
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

    public class MinPriorityComparer<T> : IHeapPriorityComparer<T> where T: IComparable<T>
    {
        public bool IsHeaped(T parent, T child)
        {
            return parent.CompareTo(child) < 0;
        }
        
    }

}