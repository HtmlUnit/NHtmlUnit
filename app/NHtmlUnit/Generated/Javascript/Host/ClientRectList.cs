// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ClientRectList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ClientRectList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ClientRectList o) =>
            new ClientRectList(o));
      }

      public ClientRectList(com.gargoylesoftware.htmlunit.javascript.host.ClientRectList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ClientRectList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ClientRectList)WrappedObject; }
      }

      public ClientRectList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ClientRectList()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual NHtmlUnit.Javascript.Host.ClientRect Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ClientRect>(arg);
      }

// Generating method code for add
      public virtual void Add(NHtmlUnit.Javascript.Host.ClientRect clientRect)
      {
         WObj.add((com.gargoylesoftware.htmlunit.javascript.host.ClientRect)clientRect.WrappedObject);
      }

   }


}
