// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class UIEvent : NHtmlUnit.Javascript.Host.Event
   {
      static UIEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.UIEvent o) =>
            new UIEvent(o));
      }

      public UIEvent(com.gargoylesoftware.htmlunit.javascript.host.UIEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.UIEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.UIEvent)WrappedObject; }
      }

      public UIEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.UIEvent()) {}

      public UIEvent(NHtmlUnit.Html.DomNode domNode, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.UIEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type)) {}

// Generating method code for jsxGet_detail
      public virtual System.Int64 JsxGet_detail()
      {
         return WObj.jsxGet_detail();
      }

// Generating method code for jsxGet_view
      public virtual object JsxGet_view()
      {
         return WObj.jsxGet_view();
      }

// Generating method code for jsxFunction_initUIEvent
      public virtual void JsxFunction_initUIEvent(string type, bool bubbles, bool cancelable, object view, int detail)
      {
         WObj.jsxFunction_initUIEvent(type, bubbles, cancelable, view, detail);
      }

// Generating method code for jsxGet_metaKey
      public virtual bool JsxGet_metaKey()
      {
         return WObj.jsxGet_metaKey();
      }

   }


}
