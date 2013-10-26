// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlEmbed : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlEmbed()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlEmbed o) =>
            new HtmlEmbed(o));
      }

      public HtmlEmbed(com.gargoylesoftware.htmlunit.html.HtmlEmbed wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlEmbed WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlEmbed)WrappedObject; }
      }

// Generating method code for saveAs
      public virtual void SaveAs(java.io.File file)
      {
         WObj.saveAs(file);
      }

   }


}
