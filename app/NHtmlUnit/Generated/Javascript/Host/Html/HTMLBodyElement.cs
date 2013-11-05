// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBodyElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBodyElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement o) =>
            new HTMLBodyElement(o));
      }

      public HTMLBodyElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement)WrappedObject; }
      }

      public HTMLBodyElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement()) {}


      public System.String ALink
      {
         get
         {
            return WObj.getALink();
         }
         set
         {
            WObj.setALink(value);
         }

      }

      public System.String Background
      {
         get
         {
            return WObj.getBackground();
         }
         set
         {
            WObj.setBackground(value);
         }

      }

      public System.String BgColor
      {
         get
         {
            return WObj.getBgColor();
         }
         set
         {
            WObj.setBgColor(value);
         }

      }

      public System.String Link
      {
         get
         {
            return WObj.getLink();
         }
         set
         {
            WObj.setLink(value);
         }

      }

      public System.String VLink
      {
         get
         {
            return WObj.getVLink();
         }
         set
         {
            WObj.setVLink(value);
         }

      }
// Generating method code for createEventHandlerFromAttribute
      public virtual void CreateEventHandlerFromAttribute(string attributeName, string value)
      {
         WObj.createEventHandlerFromAttribute(attributeName, value);
      }

   }


}
