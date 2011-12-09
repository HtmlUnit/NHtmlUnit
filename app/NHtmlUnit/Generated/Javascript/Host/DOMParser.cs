// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class DOMParser : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMParser()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.DOMParser o) =>
            new DOMParser(o));
      }

      public DOMParser(com.gargoylesoftware.htmlunit.javascript.host.DOMParser wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.DOMParser WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.DOMParser)WrappedObject; }
      }

      public DOMParser()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DOMParser()) {}

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for jsxFunction_parseFromString
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDocument JsxFunction_parseFromString(string str, string contentType)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDocument>(WObj.jsxFunction_parseFromString(str, contentType));
      }

   }


}
