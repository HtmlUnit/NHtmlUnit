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
    public class ShallowCollectionWrapper<T> : ShallowIterableWrapper<T>, ICollection<T>
    {
        private readonly Collection wrappedCollection;


        public ShallowCollectionWrapper(Collection wrappedCollection)
            : base(wrappedCollection)
        {
            this.wrappedCollection = wrappedCollection;
        }


        public int Count
        {
            get { return this.wrappedCollection.size(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }


        public void Add(T item)
        {
            this.wrappedCollection.add(item);
        }


        public void Clear()
        {
            this.wrappedCollection.clear();
        }


        public bool Contains(T item)
        {
            return this.wrappedCollection.contains(item);
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }


        public bool Remove(T item)
        {
            return this.wrappedCollection.remove(item);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}