// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLObjectElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLObjectElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement o) =>
            new HTMLObjectElement(o));
      }

      public HTMLObjectElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement)WrappedObject; }
      }

      public HTMLObjectElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement()) {}


      public System.String Classid
      {
         get
         {
            return WObj.getClassid();
         }
         set
         {
            WObj.setClassid(value);
         }

      }

      public System.String Alt
      {
         get
         {
            return WObj.getAlt();
         }
         set
         {
            WObj.setAlt(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
         }

      }
// Generating method code for unwrap
      public virtual object Unwrap()
      {
         return WObj.unwrap();
      }

   }


}
