using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    public class MyArrayList
    {
        private object[] items;
        private int count;

        private const int defaultCapacity = 4;

        public int Count
        {
            get { return count; }
        }

        public MyArrayList()
        {
            items = new object[defaultCapacity];
            count = 0;
        }

        private void EnsureCapacity()
        {
            if (count >= items.Length) 
            {
                int newCapacity = items.Length + 2;
                object[] newArray = new object[newCapacity];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }
        }

        public void Add(object item)
        {
            EnsureCapacity();
            items[count] = item;
            count++;
        }

        public void Insert(int index, object item)
        {
            if (index < 0 || index > count)
            {
                Console.WriteLine("Hatalı indeks!");
                return;
            }

            EnsureCapacity();

            for (int i = count - 1; i >= index; i--) 
            {
                items[i + 1] = items[i];
            }

            items[index] = item;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            for (int i = index; i < count - 1; i++)             {
                items[i] = items[i + 1];
            }

            count--;
        }

        public object Get(int index)
        {
            if (index < 0 || index >= count)
            {
                return null;
            }

            return items[index];
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < count; i++) 
            {
                result += items[i];
                if (i < count - 1)
                    result += ", ";
            }

            return result;
        }
    }
}
