// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Background
{
   public partial class GAEJavaScriptExecutor : NHtmlUnit.Javascript.Background.JavaScriptExecutor
   {
      static GAEJavaScriptExecutor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.background.GAEJavaScriptExecutor o) =>
            new GAEJavaScriptExecutor(o));
      }

      public GAEJavaScriptExecutor(com.gargoylesoftware.htmlunit.javascript.background.GAEJavaScriptExecutor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.background.GAEJavaScriptExecutor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.background.GAEJavaScriptExecutor)WrappedObject; }
      }

      public GAEJavaScriptExecutor(NHtmlUnit.WebClient webClient)
         : this(new com.gargoylesoftware.htmlunit.javascript.background.GAEJavaScriptExecutor((com.gargoylesoftware.htmlunit.WebClient)webClient.WrappedObject)) {}

   }


}
