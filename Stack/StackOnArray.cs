using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    //LIFO
    //Last in first out
    //Pringles
    public class StackOnArray<T>
    {
        T[] items;
        int count;
        const int length = 10; // кол-во элементов по умолчанию
        public StackOnArray() 
        {
            items = new T[length];
        }

        public StackOnArray(int length)
        {
            items = new T[length];
        }
        //пуст ли стек
        public bool IsEmpty
        {
            get { return items.Length is 0; }
        }
        //размер стека
        public int Count
        {
            get { return count; }
        }

        //добавление элемента
        public void Push(T item)
        {
            if (count >= length)
            {
                throw new StackOverflowException("стек переполнен");
            }

            //постинкремент
            items[count++] = item;
        }

        //извлечение элемента
        public T Pop()
        {
            if (count <= 0)
            {
                throw new InvalidOperationException("стек пуст");
            }

            //преинкремент
            var element = items[--count];
            items[count] = default;
            return element;
        }

        //возвращение элемента
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("стек пуст");
            }

            return items[count - 1];
        }
    }
}
