// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Popup : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Popup()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Popup o) =>
            new Popup(o));
      }

      public Popup(com.gargoylesoftware.htmlunit.javascript.host.Popup wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Popup WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Popup)WrappedObject; }
      }

      public Popup()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Popup()) {}

// Generating method code for jsxGet_document
      public virtual object JsxGet_document()
      {
         return WObj.jsxGet_document();
      }

// Generating method code for jsxGet_isOpen
      public virtual bool JsxGet_isOpen()
      {
         return WObj.jsxGet_isOpen();
      }

// Generating method code for jsxFunction_hide
      public virtual void JsxFunction_hide()
      {
         WObj.jsxFunction_hide();
      }

// Generating method code for jsxFunction_show
      public virtual void JsxFunction_show()
      {
         WObj.jsxFunction_show();
      }

   }


}
