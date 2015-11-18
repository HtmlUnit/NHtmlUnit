// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class FormField : NHtmlUnit.Javascript.Host.Html.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static FormField()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.FormField o) =>
            new FormField(o));
      }

      public FormField(com.gargoylesoftware.htmlunit.javascript.host.html.FormField wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.FormField WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.FormField)WrappedObject; }
      }

      public FormField()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.FormField()) {}


      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
         set
         {
            WObj.setValue(value);
         }

      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
         set
         {
            WObj.setName(value);
         }

      }
   }


}
