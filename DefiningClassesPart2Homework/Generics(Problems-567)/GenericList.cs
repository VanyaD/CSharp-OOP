using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Problems_567_
{
    public class GenericList<T> where T : IComparable
    {
        private const int DEFAULT_CAPACITY = 5;

        private T[] items;
        private int capacity;
        private int count;

        public GenericList(int capacity)
        {
            this.Items = new T[capacity];
            this.Capacity = capacity;
        }
        public GenericList()
            : this(DEFAULT_CAPACITY)
        {
        }

        public T[] Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.items = value;
            }
        }

        public T this[int i] // indexer
        {
            get
            {
                return this.items[i];
            }
            set
            {
                this.items[i] = value;
            }
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }


        public void AddElement(T item) // adding elements to the list
        {
            if (this.Count >= this.Items.Length)
            {
                DoubleSize();
            }
            this.items[count] = item;
            this.Count++;
        }

        private void DoubleSize() // auto-double array's capacity
        {
            int newSize = this.items.Length * 2;
            T[] doubledCapacity = new T[newSize];

            for (int i = 0; i < this.Count; i++)
            {
                doubledCapacity[i] = items[i];
            }

            this.Items = doubledCapacity;
            this.Capacity = Capacity * 2;
        }

        public void RemoveElement(int position) // removing element by index
        {
            int newSize = this.items.Length - 1;
            int newCount = 0;
            T[] newList = new T[newSize];
            for (int i = 0; i < position; i++)
            {
                newList[i] = this.items[i];
                newCount++;
            }
            for (int i = position; i < newSize; i++)
            {
                newList[i] = this.Items[i + 1];
                newCount++;
            }
            this.Items = newList;
            this.Count = newCount;
        }

        public void InsertAt(int position, T item) // inserting element on given position
        {
            T[] newList = new T[count + 1];
            for (int i = 0; i < count; i++)
            {
                newList[i] = this.Items[i];
                if (i == position)
                {
                    newList[i] = item;
                }
                //if (i > position)
                //{
                //    newList[i] = this.Items[i - 1];
                //}
            }
            this.Items = newList;
            this.Count = this.Count + 1;
        }

        public void ClearAll() // clearing list
        {
            T[] newList = new T[DEFAULT_CAPACITY];
            this.Items = newList;
            this.Count = 0;
            this.Capacity = DEFAULT_CAPACITY;
        }

        public int IndexOf(T item)
        {
            int position = -1;

            for (int i = 0; i < count; i++)
            {
                if (this.Items[i].Equals(item))
                {
                    position = i;
                }
            }
            return position;
        }

        public override string ToString() // overriding ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Items.Count(); i++)
            {
                result.Append(this.Items[i]);

                if (i != this.Items.Count() - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }

        public T Min()
        {
            T item = this.Items[0];
            for (int i = 1; i < this.Items.Count(); i++)
            {
                if (item.CompareTo(this.Items[i]) > 0)
                {
                    item = this.Items[i];
                }
            }
            return item;
        }

        public T Max()
        {
            T item = this.Items[0];
            for (int i = 1; i < this.Items.Count(); i++)
            {
                if (item.CompareTo(this.Items[i]) < 0)
                {
                    item = this.Items[i];
                }
            }
            return item;
        }
        
    }
}
