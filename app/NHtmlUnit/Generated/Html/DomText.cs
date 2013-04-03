// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomText : NHtmlUnit.Html.DomCharacterData, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.ICharacterData, NHtmlUnit.W3C.Dom.IText
   {
      static DomText()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomText o) =>
            new DomText(o));
      }

      public DomText(com.gargoylesoftware.htmlunit.html.DomText wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomText WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomText)WrappedObject; }
      }

      public DomText(NHtmlUnit.SgmlPage page, string data)
         : this(new com.gargoylesoftware.htmlunit.html.DomText((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, data)) {}


      public System.String WholeText
      {
         get
         {
            return WObj.getWholeText();
         }
      }
// Generating method code for splitText
      public virtual NHtmlUnit.Html.DomText SplitText(int offset)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomText>(WObj.splitText(offset));
      }

// Generating method code for isElementContentWhitespace
      public virtual bool IsElementContentWhitespace()
      {
         return WObj.isElementContentWhitespace();
      }

// Generating method code for replaceWholeText
      public virtual NHtmlUnit.W3C.Dom.IText ReplaceWholeText(string content)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IText>(WObj.replaceWholeText(content));
      }

   }


}
