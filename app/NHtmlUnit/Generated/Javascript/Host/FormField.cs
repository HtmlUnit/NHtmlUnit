// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class FormField : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static FormField()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.FormField o) =>
            new FormField(o));
      }

      public FormField(com.gargoylesoftware.htmlunit.javascript.host.FormField wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.FormField WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.FormField)WrappedObject; }
      }

      public FormField()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.FormField()) {}

// Generating method code for jsxGet_value
      public virtual string JsxGet_value()
      {
         return WObj.jsxGet_value();
      }

// Generating method code for jsxSet_value
      public virtual void JsxSet_value(string newValue)
      {
         WObj.jsxSet_value(newValue);
      }

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxSet_name
      public virtual void JsxSet_name(string newName)
      {
         WObj.jsxSet_name(newName);
      }

// Generating method code for jsxGet_type
      public virtual string JsxGet_type()
      {
         return WObj.jsxGet_type();
      }

// Generating method code for jsxSet_onchange
      public virtual void JsxSet_onchange(object onchange)
      {
         WObj.jsxSet_onchange(onchange);
      }

// Generating method code for jsxGet_onchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function JsxGet_onchange()
      {
         return WObj.jsxGet_onchange();
      }

   }


}
