// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLDocument : NHtmlUnit.Javascript.Host.Dom.Document
   {
      static XMLDocument()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument o) =>
            new XMLDocument(o));
      }

      public XMLDocument(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument)WrappedObject; }
      }

      public XMLDocument(NHtmlUnit.IWebWindow enclosingWindow)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument((com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject)) {}

      public XMLDocument()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument()) {}

// Generating method code for loadXML
      public virtual bool LoadXML(string strXML)
      {
         return WObj.loadXML(strXML);
      }

   }


}
