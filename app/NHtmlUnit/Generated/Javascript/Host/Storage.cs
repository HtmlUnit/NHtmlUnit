// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Storage : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Storage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Storage o) =>
            new Storage(o));
      }

      public Storage(com.gargoylesoftware.htmlunit.javascript.host.Storage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Storage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Storage)WrappedObject; }
      }

      public Storage(NHtmlUnit.Javascript.Host.Window window, java.util.Map store)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Storage((com.gargoylesoftware.htmlunit.javascript.host.Window)window.WrappedObject, store)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for setItem
      public virtual void SetItem(string key, string data)
      {
         WObj.setItem(key, data);
      }

// Generating method code for getItem
      public virtual object GetItem(string key)
      {
         return WObj.getItem(key);
      }

// Generating method code for removeItem
      public virtual void RemoveItem(string key)
      {
         WObj.removeItem(key);
      }

// Generating method code for key
      public virtual string Key(int index)
      {
         return WObj.key(index);
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

   }


}
