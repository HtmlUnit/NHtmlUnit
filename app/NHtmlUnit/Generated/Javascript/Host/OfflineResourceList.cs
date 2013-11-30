// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class OfflineResourceList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static OfflineResourceList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.OfflineResourceList o) =>
            new OfflineResourceList(o));
      }

      public OfflineResourceList(com.gargoylesoftware.htmlunit.javascript.host.OfflineResourceList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.OfflineResourceList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.OfflineResourceList)WrappedObject; }
      }

      public OfflineResourceList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.OfflineResourceList()) {}


      public System.Object Onchecking
      {
         get
         {
            return WObj.getOnchecking();
         }
         set
         {
            WObj.setOnchecking(value);
         }

      }

      public System.Object Onerror
      {
         get
         {
            return WObj.getOnerror();
         }
         set
         {
            WObj.setOnerror(value);
         }

      }

      public System.Object Onnoupdate
      {
         get
         {
            return WObj.getOnnoupdate();
         }
         set
         {
            WObj.setOnnoupdate(value);
         }

      }

      public System.Object Ondownloading
      {
         get
         {
            return WObj.getOndownloading();
         }
         set
         {
            WObj.setOndownloading(value);
         }

      }

      public System.Object Onprogress
      {
         get
         {
            return WObj.getOnprogress();
         }
         set
         {
            WObj.setOnprogress(value);
         }

      }

      public System.Object Onupdateready
      {
         get
         {
            return WObj.getOnupdateready();
         }
         set
         {
            WObj.setOnupdateready(value);
         }

      }

      public System.Object Oncached
      {
         get
         {
            return WObj.getOncached();
         }
         set
         {
            WObj.setOncached(value);
         }

      }

      public System.Int16 Status
      {
         get
         {
            return WObj.getStatus();
         }
      }

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for add
      public virtual void Add(string uri)
      {
         WObj.add(uri);
      }

// Generating method code for hasItem
      public virtual bool HasItem(string uri)
      {
         return WObj.hasItem(uri);
      }

// Generating method code for item
      public virtual string Item(int index)
      {
         return WObj.item(index);
      }

// Generating method code for remove
      public virtual void Remove(string uri)
      {
         WObj.remove(uri);
      }

// Generating method code for swapCache
      public virtual void SwapCache()
      {
         WObj.swapCache();
      }

// Generating method code for update
      public virtual void Update()
      {
         WObj.update();
      }

   }


}
