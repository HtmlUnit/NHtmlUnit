// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class StorageManager : NHtmlUnit.Javascript.SimpleScriptable
   {
      static StorageManager()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.StorageManager o) =>
            new StorageManager(o));
      }

      public StorageManager(com.gargoylesoftware.htmlunit.javascript.host.StorageManager wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.StorageManager WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.StorageManager)WrappedObject; }
      }

      public StorageManager()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.StorageManager()) {}

   }


}
