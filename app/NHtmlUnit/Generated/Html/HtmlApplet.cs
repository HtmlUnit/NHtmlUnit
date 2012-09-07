// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlApplet : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlApplet()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlApplet o) =>
            new HtmlApplet(o));
      }

      public HtmlApplet(com.gargoylesoftware.htmlunit.html.HtmlApplet wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlApplet WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlApplet)WrappedObject; }
      }


      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String ObjectAttribute
      {
         get
         {
            return WObj.getObjectAttribute();
         }
      }

      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }

      public System.String AltAttribute
      {
         get
         {
            return WObj.getAltAttribute();
         }
      }

      public System.String HeightAttribute
      {
         get
         {
            return WObj.getHeightAttribute();
         }
      }

      public System.String HspaceAttribute
      {
         get
         {
            return WObj.getHspaceAttribute();
         }
      }

      public System.String VspaceAttribute
      {
         get
         {
            return WObj.getVspaceAttribute();
         }
      }

      public System.String WidthAttribute
      {
         get
         {
            return WObj.getWidthAttribute();
         }
      }

      public System.String CodebaseAttribute
      {
         get
         {
            return WObj.getCodebaseAttribute();
         }
      }

      public System.String ArchiveAttribute
      {
         get
         {
            return WObj.getArchiveAttribute();
         }
      }

      public System.String CodeAttribute
      {
         get
         {
            return WObj.getCodeAttribute();
         }
      }

      public java.applet.Applet Applet
      {
         get
         {
            return WObj.getApplet();
         }
      }

      public IList<java.net.URL> ArchiveUrls
      {
         get
         {
            return new ShallowListWrapper<java.net.URL>(
               WObj.getArchiveUrls());
         }
       }
   }


}
