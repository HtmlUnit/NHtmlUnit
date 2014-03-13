// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class StorageList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static StorageList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.StorageList o) =>
            new StorageList(o));
      }

      public StorageList(com.gargoylesoftware.htmlunit.javascript.host.StorageList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.StorageList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.StorageList)WrappedObject; }
      }

      public StorageList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.StorageList()) {}

   }


}
