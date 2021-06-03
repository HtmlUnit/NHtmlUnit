// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class ScriptResult : ObjectWrapper
   {
      static ScriptResult()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.ScriptResult o) =>
            new ScriptResult(o));
      }

      public ScriptResult(com.gargoylesoftware.htmlunit.ScriptResult wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.ScriptResult WObj
      {
         get { return (com.gargoylesoftware.htmlunit.ScriptResult)WrappedObject; }
      }

      public ScriptResult(object javaScriptResult)
         : this(new com.gargoylesoftware.htmlunit.ScriptResult(javaScriptResult)) {}


      public System.Object JavaScriptResult
      {
         get
         {
            return WObj.getJavaScriptResult();
         }
      }
   }


}
