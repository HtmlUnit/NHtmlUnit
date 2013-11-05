// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomComment : NHtmlUnit.Html.DomCharacterData, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.ICharacterData, NHtmlUnit.W3C.Dom.IComment
   {
      static DomComment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomComment o) =>
            new DomComment(o));
      }

      public DomComment(com.gargoylesoftware.htmlunit.html.DomComment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomComment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomComment)WrappedObject; }
      }

      public DomComment(NHtmlUnit.SgmlPage page, string data)
         : this(new com.gargoylesoftware.htmlunit.html.DomComment((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, data)) {}

   }


}
