// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileSystemDirectoryReader : NHtmlUnit.Javascript.SimpleScriptable
   {
      static FileSystemDirectoryReader()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryReader o) =>
            new FileSystemDirectoryReader(o));
      }

      public FileSystemDirectoryReader(com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryReader wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryReader WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryReader)WrappedObject; }
      }

      public FileSystemDirectoryReader()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryReader()) {}

   }


}
