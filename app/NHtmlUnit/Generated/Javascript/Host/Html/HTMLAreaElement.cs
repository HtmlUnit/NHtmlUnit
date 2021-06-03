// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAreaElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLAreaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement o) =>
            new HTMLAreaElement(o));
      }

      public HTMLAreaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement)WrappedObject; }
      }

      public HTMLAreaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement()) {}


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

      public System.String Rel
      {
         get
         {
            return WObj.getRel();
         }
         set
         {
            WObj.setRel(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Dom.DOMTokenList RelList
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DOMTokenList>(
               WObj.getRelList());
         }
      }


      public System.String Coords
      {
         get
         {
            return WObj.getCoords();
         }
         set
         {
            WObj.setCoords(value);
         }

      }
   }


}
