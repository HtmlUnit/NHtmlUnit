// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class BoxObject : NHtmlUnit.Javascript.SimpleScriptable
   {
      static BoxObject()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.BoxObject o) =>
            new BoxObject(o));
      }

      public BoxObject(com.gargoylesoftware.htmlunit.javascript.host.BoxObject wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.BoxObject WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.BoxObject)WrappedObject; }
      }

      public BoxObject(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BoxObject((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject)) {}

      public BoxObject()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BoxObject()) {}


      public System.Int32 X
      {
         get
         {
            return WObj.getX();
         }
      }

      public System.Int32 Y
      {
         get
         {
            return WObj.getY();
         }
      }

      public NHtmlUnit.Javascript.Host.Html.HTMLElement Element
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getElement());
         }
      }


      public System.Object FirstChild
      {
         get
         {
            return WObj.getFirstChild();
         }
      }

      public System.Object LastChild
      {
         get
         {
            return WObj.getLastChild();
         }
      }

      public System.Object NextSibling
      {
         get
         {
            return WObj.getNextSibling();
         }
      }

      public System.Object PreviousSibling
      {
         get
         {
            return WObj.getPreviousSibling();
         }
      }

      public System.Int32 ScreenX
      {
         get
         {
            return WObj.getScreenX();
         }
      }

      public System.Int32 ScreenY
      {
         get
         {
            return WObj.getScreenY();
         }
      }

      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }
   }


}
