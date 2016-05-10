// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class FileList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static FileList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.FileList o) =>
            new FileList(o));
      }

      public FileList(com.gargoylesoftware.htmlunit.javascript.host.file.FileList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.FileList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.FileList)WrappedObject; }
      }

      public FileList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileList()) {}

      public FileList(java.util.List pathnames)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.FileList(pathnames)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual NHtmlUnit.Javascript.Host.File.File Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.File.File>(arg);
      }

   }


}
