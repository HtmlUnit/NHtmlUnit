// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileError : NHtmlUnit.Javascript.Host.Dom.DOMError
   {
      static FileError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileError o) =>
            new FileError(o));
      }

      public FileError(com.gargoylesoftware.htmlunit.javascript.host.file.FileError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileError)WrappedObject; }
      }

      public FileError()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileError()) {}

   }


}
