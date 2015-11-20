// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileRequest : NHtmlUnit.Javascript.Host.Dom.DOMRequest
   {
      static FileRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileRequest o) =>
            new FileRequest(o));
      }

      public FileRequest(com.gargoylesoftware.htmlunit.javascript.host.file.FileRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileRequest)WrappedObject; }
      }

      public FileRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileRequest()) {}

   }


}
