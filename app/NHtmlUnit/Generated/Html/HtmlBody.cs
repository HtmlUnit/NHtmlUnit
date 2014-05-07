// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlBody : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlBody()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlBody o) =>
            new HtmlBody(o));
      }

      public HtmlBody(com.gargoylesoftware.htmlunit.html.HtmlBody wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlBody WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlBody)WrappedObject; }
      }

      public HtmlBody(string qualifiedName, NHtmlUnit.SgmlPage page, java.util.Map attributes, bool temporary)
         : this(new com.gargoylesoftware.htmlunit.html.HtmlBody(qualifiedName, (com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, attributes, temporary)) {}


      public System.String OnLoadAttribute
      {
         get
         {
            return WObj.getOnLoadAttribute();
         }
      }

      public System.String OnUnloadAttribute
      {
         get
         {
            return WObj.getOnUnloadAttribute();
         }
      }

      public System.String BackgroundAttribute
      {
         get
         {
            return WObj.getBackgroundAttribute();
         }
      }

      public System.String BgcolorAttribute
      {
         get
         {
            return WObj.getBgcolorAttribute();
         }
      }

      public System.String TextAttribute
      {
         get
         {
            return WObj.getTextAttribute();
         }
      }

      public System.String LinkAttribute
      {
         get
         {
            return WObj.getLinkAttribute();
         }
      }

      public System.String VlinkAttribute
      {
         get
         {
            return WObj.getVlinkAttribute();
         }
      }

      public System.String AlinkAttribute
      {
         get
         {
            return WObj.getAlinkAttribute();
         }
      }
// Generating method code for isTemporary
      public virtual bool IsTemporary()
      {
         return WObj.isTemporary();
      }

   }


}
