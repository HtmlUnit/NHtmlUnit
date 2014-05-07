// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomCDataSection : NHtmlUnit.Html.DomText, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.ICharacterData, NHtmlUnit.W3C.Dom.IText, NHtmlUnit.W3C.Dom.ICDATASection
   {
      static DomCDataSection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomCDataSection o) =>
            new DomCDataSection(o));
      }

      public DomCDataSection(com.gargoylesoftware.htmlunit.html.DomCDataSection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomCDataSection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomCDataSection)WrappedObject; }
      }

      public DomCDataSection(NHtmlUnit.SgmlPage page, string data)
         : this(new com.gargoylesoftware.htmlunit.html.DomCDataSection((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, data)) {}

   }


}
