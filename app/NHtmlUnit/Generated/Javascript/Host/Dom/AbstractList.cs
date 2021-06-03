// Generated class v2.50.0.0, don't modify

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

      public AbstractList(NHtmlUnit.Html.DomNode domeNode, bool attributeChangeSensitive)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.AbstractList((com.gargoylesoftware.htmlunit.html.DomNode)domeNode.WrappedObject, attributeChangeSensitive)) {}


      public IList<NHtmlUnit.Html.DomNode> Elements
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.DomNode>(
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

      public System.Int32 ArrayLength
      {
         get
         {
            return WObj.getArrayLength();
         }
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

// Generating method code for item
      public virtual object Item(object index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getArrayElement
      public virtual object GetArrayElement(int index)
      {
         var arg = WObj.getArrayElement(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setArrayElement
      public virtual void SetArrayElement(int index, object value)
      {
         WObj.setArrayElement(index, value);
      }

   }


}
