// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ReadableByteStream : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ReadableByteStream()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ReadableByteStream o) =>
            new ReadableByteStream(o));
      }

      public ReadableByteStream(com.gargoylesoftware.htmlunit.javascript.host.ReadableByteStream wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ReadableByteStream WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ReadableByteStream)WrappedObject; }
      }

      public ReadableByteStream()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ReadableByteStream()) {}

   }


}
