// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLDocument : NHtmlUnit.Javascript.Host.Document
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


      public System.Boolean Async
      {
         get
         {
            return WObj.getAsync();
         }
         set
         {
            WObj.setAsync(value);
         }

      }
// Generating method code for loadXML
      public virtual bool LoadXML(string strXML)
      {
         return WObj.loadXML(strXML);
      }

// Generating method code for load
      public virtual bool Load(string xmlSource)
      {
         return WObj.load(xmlSource);
      }

// Generating method code for getElementById
      public virtual object GetElementById(string id)
      {
         return WObj.getElementById(id);
      }

// Generating method code for createProcessingInstruction
      public virtual object CreateProcessingInstruction(string target, string data)
      {
         return WObj.createProcessingInstruction(target, data);
      }

// Generating method code for createCDATASection
      public virtual object CreateCDATASection(string data)
      {
         return WObj.createCDATASection(data);
      }

   }


}
