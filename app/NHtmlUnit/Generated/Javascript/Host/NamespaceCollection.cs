// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class NamespaceCollection : NHtmlUnit.Javascript.SimpleScriptable
   {
      static NamespaceCollection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.NamespaceCollection o) =>
            new NamespaceCollection(o));
      }

      public NamespaceCollection(com.gargoylesoftware.htmlunit.javascript.host.NamespaceCollection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.NamespaceCollection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.NamespaceCollection)WrappedObject; }
      }

      public NamespaceCollection(NHtmlUnit.Javascript.Host.Html.HTMLDocument doc)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.NamespaceCollection((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument)doc.WrappedObject)) {}

      public NamespaceCollection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.NamespaceCollection()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual object Item(object index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for add
      public virtual NHtmlUnit.Javascript.Host.Namespace Add(string namespaceArg, string urn, string url)
      {
         var arg = WObj.add(namespaceArg, urn, url);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Namespace>(arg);
      }

// Generating method code for call
      public virtual object Call(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObj, System.Object[] args)
      {
         var arg = WObj.call(cx, scope, thisObj, args);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for construct
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Construct(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, System.Object[] args)
      {
         return WObj.construct(cx, scope, args);
      }

   }


}
