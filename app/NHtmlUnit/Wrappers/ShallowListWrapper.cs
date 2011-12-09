#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;
using System.Collections;
using System.Collections.Generic;

using java.util;

namespace NHtmlUnit
{
    public class ShallowListWrapper<T> : IList<T>
    {
        private readonly List wrappedList;


        public ShallowListWrapper(List wrappedList)
        {
            this.wrappedList = wrappedList;
        }


        public T this[int index]
        {
            get { return (T)this.wrappedList.get(index); }
            set { this.wrappedList.set(index, value); }
        }


        public int Count
        {
            get { return this.wrappedList.size(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }


        public void Add(T item)
        {
            this.wrappedList.add(item);
        }


        public void Clear()
        {
            this.wrappedList.clear();
        }


        public bool Contains(T item)
        {
            return this.wrappedList.contains(item);
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.wrappedList.size(); i++)
                yield return ObjectWrapper.CreateWrapper<T>(this.wrappedList.get(i));
        }


        public int IndexOf(T item)
        {
            return this.wrappedList.indexOf(item);
        }


        public void Insert(int index, T item)
        {
            this.wrappedList.add(index, item);
        }


        public bool Remove(T item)
        {
            return this.wrappedList.remove(item);
        }


        public void RemoveAt(int index)
        {
            this.wrappedList.remove(index);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}