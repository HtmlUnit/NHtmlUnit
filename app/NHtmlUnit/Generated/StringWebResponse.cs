// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class StringWebResponse : NHtmlUnit.WebResponse
   {
      static StringWebResponse()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.StringWebResponse o) =>
            new StringWebResponse(o));
      }

      public StringWebResponse(com.gargoylesoftware.htmlunit.StringWebResponse wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.StringWebResponse WObj
      {
         get { return (com.gargoylesoftware.htmlunit.StringWebResponse)WrappedObject; }
      }

      public StringWebResponse(string content, string charset, java.net.URL originatingURL)
         : this(new com.gargoylesoftware.htmlunit.StringWebResponse(content, charset, originatingURL)) {}

      public StringWebResponse(string content, java.net.URL originatingURL)
         : this(new com.gargoylesoftware.htmlunit.StringWebResponse(content, originatingURL)) {}

// Generating method code for isFromJavascript
      public virtual bool IsFromJavascript()
      {
         return WObj.isFromJavascript();
      }

   }


}
