// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLSerializer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XMLSerializer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLSerializer o) =>
            new XMLSerializer(o));
      }

      public XMLSerializer(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLSerializer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLSerializer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLSerializer)WrappedObject; }
      }

      public XMLSerializer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLSerializer()) {}

// Generating method code for jsxFunction_serializeToString
      public virtual string JsxFunction_serializeToString(NHtmlUnit.Javascript.Host.Node root)
      {
         return WObj.jsxFunction_serializeToString((com.gargoylesoftware.htmlunit.javascript.host.Node)root.WrappedObject);
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

   }


}
