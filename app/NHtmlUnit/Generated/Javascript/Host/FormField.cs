// Generated class v2.14.1.0, don't modify

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

      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }
   }


}
