// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class MSXMLJavaScriptEnvironment : ObjectWrapper
   {
      static MSXMLJavaScriptEnvironment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLJavaScriptEnvironment o) =>
            new MSXMLJavaScriptEnvironment(o));
      }

      public MSXMLJavaScriptEnvironment(com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLJavaScriptEnvironment wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLJavaScriptEnvironment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLJavaScriptEnvironment)WrappedObject; }
      }

      public MSXMLJavaScriptEnvironment(NHtmlUnit.BrowserVersion browserVersion)
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLJavaScriptEnvironment((com.gargoylesoftware.htmlunit.BrowserVersion)browserVersion.WrappedObject)) {}

// Generating method code for getPrototype
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable GetPrototype(java.lang.Class jsClass)
      {
         return WObj.getPrototype(jsClass);
      }

// Generating method code for getJavaScriptClass
      public virtual java.lang.Class GetJavaScriptClass(java.lang.Class c)
      {
         return WObj.getJavaScriptClass(c);
      }

   }


}
