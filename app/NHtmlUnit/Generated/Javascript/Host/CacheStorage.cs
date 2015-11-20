// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class CacheStorage : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CacheStorage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.CacheStorage o) =>
            new CacheStorage(o));
      }

      public CacheStorage(com.gargoylesoftware.htmlunit.javascript.host.CacheStorage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.CacheStorage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.CacheStorage)WrappedObject; }
      }

      public CacheStorage()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.CacheStorage()) {}

   }


}
