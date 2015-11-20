// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ReadableStream : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ReadableStream()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ReadableStream o) =>
            new ReadableStream(o));
      }

      public ReadableStream(com.gargoylesoftware.htmlunit.javascript.host.ReadableStream wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ReadableStream WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ReadableStream)WrappedObject; }
      }

      public ReadableStream()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ReadableStream()) {}

   }


}
