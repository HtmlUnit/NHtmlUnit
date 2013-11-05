// Generated class v2.13, don't modify

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
