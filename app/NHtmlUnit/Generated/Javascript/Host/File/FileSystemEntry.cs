// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileSystemEntry : NHtmlUnit.Javascript.SimpleScriptable
   {
      static FileSystemEntry()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemEntry o) =>
            new FileSystemEntry(o));
      }

      public FileSystemEntry(com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemEntry wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemEntry WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemEntry)WrappedObject; }
      }

      public FileSystemEntry()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileSystemEntry()) {}

   }


}
