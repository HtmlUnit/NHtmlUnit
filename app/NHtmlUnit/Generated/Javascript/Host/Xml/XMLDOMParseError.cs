// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLDOMParseError : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XMLDOMParseError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDOMParseError o) =>
            new XMLDOMParseError(o));
      }

      public XMLDOMParseError(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDOMParseError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDOMParseError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDOMParseError)WrappedObject; }
      }

      public XMLDOMParseError()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDOMParseError()) {}

// Generating method code for jsxGet_errorCode
      public virtual int JsxGet_errorCode()
      {
         return WObj.jsxGet_errorCode();
      }

// Generating method code for jsxGet_filepos
      public virtual int JsxGet_filepos()
      {
         return WObj.jsxGet_filepos();
      }

// Generating method code for jsxGet_line
      public virtual int JsxGet_line()
      {
         return WObj.jsxGet_line();
      }

// Generating method code for jsxGet_linepos
      public virtual int JsxGet_linepos()
      {
         return WObj.jsxGet_linepos();
      }

// Generating method code for jsxGet_reason
      public virtual string JsxGet_reason()
      {
         return WObj.jsxGet_reason();
      }

// Generating method code for jsxGet_srcText
      public virtual string JsxGet_srcText()
      {
         return WObj.jsxGet_srcText();
      }

// Generating method code for jsxGet_url
      public virtual string JsxGet_url()
      {
         return WObj.jsxGet_url();
      }

   }


}
