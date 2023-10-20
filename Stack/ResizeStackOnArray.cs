using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ResizeStackOnArray<T>
    {
        T[] items;
        int count;
        const int size = 10;
        public ResizeStackOnArray() 
        {
            this.items = new T[size];
        }

        public ResizeStackOnArray(int length)
        {
            this.items = new T[length];
        }

        public bool IsEmpty
        {
            get { return (count is 0); } 
        }

        public int Count
        {
            get { return count; }
        }

        public void Resize(int size)
        {
            var tempItems = new T[size];

            for (int i = 0; i < count; i++)
            {
                tempItems[i] = items[i];
            }

            items = tempItems;
            return;
        }

        public void Push(T value)
        {
            if (count == items.Length)
            {
                Resize(items.Length + 10);
            }

            items[count++] = value;
        }

        public T Pop()
        {
            if (count is 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var item = items[--count];
            items[count] = default(T);

            if (count > 0 && items.Length - count == 10)
            {
                Resize(items.Length - 10);
            }

            return item;
        }

        public T Peek()
        {
            if (count is 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[count - 1];
        }
    }
}
