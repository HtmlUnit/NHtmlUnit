// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileSystemFileEntry : NHtmlUnit.Javascript.Host.File.FileSystemEntry
   {
      static FileSystemFileEntry()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemFileEntry o) =>
            new FileSystemFileEntry(o));
      }

      public FileSystemFileEntry(com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemFileEntry wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemFileEntry WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemFileEntry)WrappedObject; }
      }

      public FileSystemFileEntry()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemFileEntry()) {}

   }


}
