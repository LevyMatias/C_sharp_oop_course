using System;

namespace problemEx_1
{
    class PrintService<T>
    {
        private T[] values = new T[10];
        private int count = 0;
        public void AddValue(T value)
        {
            if(count == 10)
            {
                throw new InvalidOperationException("Print service is full");
            }
            values[count] = value;
            count++;
        }

        public T First()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Print service is Empty");
            }
            return values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(var i = 0; i < count - 1; i++)
            {
                Console.Write(values[i] + ", ");
            }
            if(count > 0)
            {
                Console.Write(values[count - 1]);
            }

            Console.Write("]");
            Console.WriteLine();
        }
    }
}
