// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class AbstractList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static AbstractList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.AbstractList o) =>
            new AbstractList(o));
      }

      public AbstractList(com.gargoylesoftware.htmlunit.javascript.host.dom.AbstractList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.AbstractList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.AbstractList)WrappedObject; }
      }

      public AbstractList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.AbstractList()) {}

      public AbstractList(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.AbstractList((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}


      public IList<java.lang.Object> Elements
      {
         get
         {
            return new ShallowListWrapper<java.lang.Object>(
               WObj.getElements());
         }
       }

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for call
      public virtual object Call(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObj, System.Object[] args)
      {
         return WObj.call(cx, scope, thisObj, args);
      }

// Generating method code for construct
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Construct(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, System.Object[] args)
      {
         return WObj.construct(cx, scope, args);
      }

// Generating method code for item
      public virtual object Item(object index)
      {
         return WObj.item(index);
      }

   }


}
