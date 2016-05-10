// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLObjectElement : NHtmlUnit.Javascript.Host.Html.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

      public System.String DataFld
      {
         get
         {
            return WObj.getDataFld();
         }
         set
         {
            WObj.setDataFld(value);
         }

      }

      public System.String DataFormatAs
      {
         get
         {
            return WObj.getDataFormatAs();
         }
         set
         {
            WObj.setDataFormatAs(value);
         }

      }

      public System.String DataSrc
      {
         get
         {
            return WObj.getDataSrc();
         }
         set
         {
            WObj.setDataSrc(value);
         }

      }

      public System.String Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }

      public System.String Height_js
      {
         get
         {
            return WObj.getHeight_js();
         }
      }
// Generating method code for unwrap
      public virtual object Unwrap()
      {
         var arg = WObj.unwrap();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
