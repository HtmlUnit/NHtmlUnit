// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMText : NHtmlUnit.Activex.Javascript.Msxml.XMLDOMCharacterData
   {
      static XMLDOMText()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMText o) =>
            new XMLDOMText(o));
      }

      public XMLDOMText(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMText wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMText WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMText)WrappedObject; }
      }

      public XMLDOMText()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMText()) {}

// Generating method code for splitText
      public virtual object SplitText(int offset)
      {
         return WObj.splitText(offset);
      }

   }


}
