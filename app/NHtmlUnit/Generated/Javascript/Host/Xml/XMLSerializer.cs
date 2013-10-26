// Generated class v2.13, don't modify

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

// Generating method code for serializeToString
      public virtual string SerializeToString(NHtmlUnit.Javascript.Host.Node root)
      {
         return WObj.serializeToString((com.gargoylesoftware.htmlunit.javascript.host.Node)root.WrappedObject);
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

   }


}
