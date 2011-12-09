#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System.Collections;
using System.Collections.Generic;

using java.lang;

namespace NHtmlUnit
{
    public class IterableWrapper<T> : IEnumerable<T>
        where T : IObjectWrapper
    {
        private readonly Iterable wrappedIterable;


        public IterableWrapper(Iterable wrappedIterable)
        {
            this.wrappedIterable = wrappedIterable;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var iterator = this.wrappedIterable.iterator();

            while (iterator.hasNext())
                yield return ObjectWrapper.CreateWrapper<T>(iterator.next());
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}