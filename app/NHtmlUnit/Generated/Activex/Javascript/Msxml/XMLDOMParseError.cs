// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMParseError : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable
   {
      static XMLDOMParseError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMParseError o) =>
            new XMLDOMParseError(o));
      }

      public XMLDOMParseError(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMParseError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMParseError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMParseError)WrappedObject; }
      }

      public XMLDOMParseError()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMParseError()) {}


      public System.Int32 ErrorCode
      {
         get
         {
            return WObj.getErrorCode();
         }
      }

      public System.Int32 Filepos
      {
         get
         {
            return WObj.getFilepos();
         }
      }

      public System.Int32 Line
      {
         get
         {
            return WObj.getLine();
         }
      }

      public System.Int32 Linepos
      {
         get
         {
            return WObj.getLinepos();
         }
      }

      public System.String Reason
      {
         get
         {
            return WObj.getReason();
         }
      }

      public System.String SrcText
      {
         get
         {
            return WObj.getSrcText();
         }
      }

      public System.String Url
      {
         get
         {
            return WObj.getUrl();
         }
      }
   }


}
