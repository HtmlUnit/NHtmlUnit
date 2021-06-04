// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFrameElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLFrameElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement o) =>
            new HTMLFrameElement(o));
      }

      public HTMLFrameElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement)WrappedObject; }
      }

      public HTMLFrameElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement()) {}


      public System.String Src
      {
         get
         {
            return WObj.getSrc();
         }
         set
         {
            WObj.setSrc(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Html.DocumentProxy ContentDocument
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DocumentProxy>(
               WObj.getContentDocument());
         }
      }


      public NHtmlUnit.Javascript.Host.WindowProxy ContentWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(
               WObj.getContentWindow());
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
   }


}
