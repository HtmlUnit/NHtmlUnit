// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Attr : NHtmlUnit.Javascript.Host.Node
   {
      static Attr()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Attr o) =>
            new Attr(o));
      }

      public Attr(com.gargoylesoftware.htmlunit.javascript.host.Attr wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Attr WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Attr)WrappedObject; }
      }

      public Attr()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Attr()) {}

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxGet_value
      public virtual string JsxGet_value()
      {
         return WObj.jsxGet_value();
      }

// Generating method code for detachFromParent
      public virtual void DetachFromParent()
      {
         WObj.detachFromParent();
      }

// Generating method code for jsxGet_isId
      public virtual bool JsxGet_isId()
      {
         return WObj.jsxGet_isId();
      }

// Generating method code for jsxGet_expando
      public virtual bool JsxGet_expando()
      {
         return WObj.jsxGet_expando();
      }

// Generating method code for jsxGet_ownerElement
      public virtual object JsxGet_ownerElement()
      {
         return WObj.jsxGet_ownerElement();
      }

// Generating method code for jsxGet_specified
      public virtual bool JsxGet_specified()
      {
         return WObj.jsxGet_specified();
      }

// Generating method code for jsxSet_value
      public virtual void JsxSet_value(string value)
      {
         WObj.jsxSet_value(value);
      }

   }


}
