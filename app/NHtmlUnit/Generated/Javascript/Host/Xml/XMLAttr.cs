// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLAttr : NHtmlUnit.Javascript.Host.Attr
   {
      static XMLAttr()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLAttr o) =>
            new XMLAttr(o));
      }

      public XMLAttr(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLAttr wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLAttr WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLAttr)WrappedObject; }
      }

      public XMLAttr()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLAttr()) {}

// Generating method code for jsxGet_text
      public virtual string JsxGet_text()
      {
         return WObj.jsxGet_text();
      }

// Generating method code for jsxSet_text
      public virtual void JsxSet_text(string value)
      {
         WObj.jsxSet_text(value);
      }

   }


}
