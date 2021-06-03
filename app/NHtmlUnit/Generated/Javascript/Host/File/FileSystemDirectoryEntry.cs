// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileSystemDirectoryEntry : NHtmlUnit.Javascript.Host.File.FileSystemEntry
   {
      static FileSystemDirectoryEntry()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryEntry o) =>
            new FileSystemDirectoryEntry(o));
      }

      public FileSystemDirectoryEntry(com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryEntry wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryEntry WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryEntry)WrappedObject; }
      }

      public FileSystemDirectoryEntry()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemDirectoryEntry()) {}

   }


}
