// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDivElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDivElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement o) =>
            new HTMLDivElement(o));
      }

      public HTMLDivElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement)WrappedObject; }
      }

      public HTMLDivElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement()) {}


      public System.String Align
      {
         get
         {
            return WObj.getAlign();
         }
         set
         {
            WObj.setAlign(value);
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
   }


}
