using System;
using System.Collections.Generic;
using System.Text;

namespace SharpLib
{
    public class StaticList<T> : IDisposable
    {
        private int num = 0;

        private T[] list;

        public StaticList(int size)
        {
            list = new T[size];
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Clear() { }

        public int Num() { return 0; }

        public int Max() { return 0; }

        public void SetNum(int newnum) { }

        public void SetNum(int newnum, T initValue) { }

        public int Allocated() { return 0; }

        public int Size() { return 0;  }

        public int MemoryUsed() { return 0; }

        public T this[int index]
        {
            get
            {
                return default(T);
            }
            set
            {

            }
        }

        // public T* Ptr()

        public T Alloc() { return default(T); }

        public int Append(T obj) { return 0; }
        
        public int Append(StaticList<T> other) { return 0; }

        public int AddUnique(T obj) { return 0; }

        public int Insert(T obj, int index = 0) { return 0; }

        public int FindIndex(T obj) { return 0;  }

        public T Find(T obj) { return default(T); }

        public int FindNull() { return 0; }

        public int IndexOf(T obj) { return 0; }

        public bool RemoveIndex(int index) { return true; }

        public bool RemoveIndexFast(int index) { return true; }

        public bool Remove(T obj) { return true; }

        public void Swap(StaticList<T> other) { }

        public void DeleteContents(bool clear) { }

        public void Sort() { }

        private void Resize(int newsize) { }
    }
}
