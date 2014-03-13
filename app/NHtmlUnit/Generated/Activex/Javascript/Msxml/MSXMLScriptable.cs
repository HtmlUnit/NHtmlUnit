// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class MSXMLScriptable : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MSXMLScriptable()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLScriptable o) =>
            new MSXMLScriptable(o));
      }

      public MSXMLScriptable(com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLScriptable wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLScriptable WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLScriptable)WrappedObject; }
      }

      public MSXMLScriptable()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLScriptable()) {}


      public NHtmlUnit.Activex.Javascript.Msxml.MSXMLJavaScriptEnvironment Environment
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.MSXMLJavaScriptEnvironment>(
               WObj.getEnvironment());
         }
         set
         {
            WObj.setEnvironment((com.gargoylesoftware.htmlunit.activex.javascript.msxml.MSXMLJavaScriptEnvironment)value.WrappedObject);
         }

      }

   }


}
