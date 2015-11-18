// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileReader : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static FileReader()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileReader o) =>
            new FileReader(o));
      }

      public FileReader(com.gargoylesoftware.htmlunit.javascript.host.file.FileReader wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileReader WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileReader)WrappedObject; }
      }

      public FileReader()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileReader()) {}

   }


}
