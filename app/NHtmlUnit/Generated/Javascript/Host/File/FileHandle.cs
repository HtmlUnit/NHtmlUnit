// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileHandle : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static FileHandle()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileHandle o) =>
            new FileHandle(o));
      }

      public FileHandle(com.gargoylesoftware.htmlunit.javascript.host.file.FileHandle wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileHandle WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileHandle)WrappedObject; }
      }

      public FileHandle()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileHandle()) {}

   }


}
