// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MimeTypeArray : NHtmlUnit.Javascript.Host.SimpleArray, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static MimeTypeArray()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MimeTypeArray o) =>
            new MimeTypeArray(o));
      }

      public MimeTypeArray(com.gargoylesoftware.htmlunit.javascript.host.MimeTypeArray wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MimeTypeArray WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MimeTypeArray)WrappedObject; }
      }

      public MimeTypeArray()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MimeTypeArray()) {}

   }


}
