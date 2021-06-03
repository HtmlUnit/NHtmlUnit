// Generated class v2.50.0.0, don't modify

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

      public TextDecoder(object encoding)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextDecoder(encoding)) {}


      public System.String Encoding
      {
         get
         {
            return WObj.getEncoding();
         }
      }
// Generating method code for decode
      public virtual string Decode(object buffer)
      {
         return WObj.decode(buffer);
      }

   }


}
