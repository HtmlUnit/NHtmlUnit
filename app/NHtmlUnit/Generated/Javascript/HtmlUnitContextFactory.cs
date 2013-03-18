// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class HtmlUnitContextFactory : ObjectWrapper
   {
      static HtmlUnitContextFactory()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.HtmlUnitContextFactory o) =>
            new HtmlUnitContextFactory(o));
      }

      public HtmlUnitContextFactory(com.gargoylesoftware.htmlunit.javascript.HtmlUnitContextFactory wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.HtmlUnitContextFactory WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.HtmlUnitContextFactory)WrappedObject; }
      }

      public HtmlUnitContextFactory(NHtmlUnit.WebClient webClient)
         : this(new com.gargoylesoftware.htmlunit.javascript.HtmlUnitContextFactory((com.gargoylesoftware.htmlunit.WebClient)webClient.WrappedObject)) {}


      public System.Int64 Timeout
      {
         get
         {
            return WObj.getTimeout();
         }
         set
         {
            WObj.setTimeout(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.debug.Debugger Debugger
      {
         get
         {
            return WObj.getDebugger();
         }
         set
         {
            WObj.setDebugger(value);
         }

      }
   }


}
