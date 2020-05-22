using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
            throw new NotImplementedException();
        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}
