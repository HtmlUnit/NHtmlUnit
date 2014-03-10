// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class MSXMLActiveXObjectFactory : ObjectWrapper
   {
      static MSXMLActiveXObjectFactory()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLActiveXObjectFactory o) =>
            new MSXMLActiveXObjectFactory(o));
      }

      public MSXMLActiveXObjectFactory(com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLActiveXObjectFactory wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLActiveXObjectFactory WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLActiveXObjectFactory)WrappedObject; }
      }

      public MSXMLActiveXObjectFactory()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLActiveXObjectFactory()) {}

// Generating method code for init
      public virtual void Init(NHtmlUnit.BrowserVersion browserVersion)
      {
         WObj.init((com.gargoylesoftware.htmlunit.BrowserVersion)browserVersion.WrappedObject);
      }

// Generating method code for supports
      public virtual bool Supports(string activeXName)
      {
         return WObj.supports(activeXName);
      }

// Generating method code for create
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Create(string activeXName, NHtmlUnit.IWebWindow enclosingWindow)
      {
         return WObj.create(activeXName, (com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject);
      }

   }


}
