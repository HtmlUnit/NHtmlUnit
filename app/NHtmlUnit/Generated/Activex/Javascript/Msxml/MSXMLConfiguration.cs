// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class MSXMLConfiguration : NHtmlUnit.Javascript.Configuration.AbstractJavaScriptConfiguration
   {
      static MSXMLConfiguration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLConfiguration o) =>
            new MSXMLConfiguration(o));
      }

      public MSXMLConfiguration(com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLConfiguration wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLConfiguration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLConfiguration)WrappedObject; }
      }

   }


}
