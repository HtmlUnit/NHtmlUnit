// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLIFrameElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLIFrameElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIFrameElement o) =>
            new HTMLIFrameElement(o));
      }

      public HTMLIFrameElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIFrameElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIFrameElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIFrameElement)WrappedObject; }
      }

      public HTMLIFrameElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIFrameElement()) {}


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
// Generating method code for onRefresh
      public virtual void OnRefresh()
      {
         WObj.onRefresh();
      }

   }


}
