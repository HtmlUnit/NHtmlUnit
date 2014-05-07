// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMImplementation : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable
   {
      static XMLDOMImplementation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMImplementation o) =>
            new XMLDOMImplementation(o));
      }

      public XMLDOMImplementation(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMImplementation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMImplementation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMImplementation)WrappedObject; }
      }

      public XMLDOMImplementation()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMImplementation()) {}

// Generating method code for hasFeature
      public virtual bool HasFeature(string feature, string version)
      {
         return WObj.hasFeature(feature, version);
      }

   }


}
