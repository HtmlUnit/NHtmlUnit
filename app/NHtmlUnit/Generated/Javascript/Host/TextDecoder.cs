// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class TextDecoder : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TextDecoder()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.TextDecoder o) =>
            new TextDecoder(o));
      }

      public TextDecoder(com.gargoylesoftware.htmlunit.javascript.host.TextDecoder wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.TextDecoder WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.TextDecoder)WrappedObject; }
      }

      public TextDecoder()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextDecoder()) {}

   }


}
