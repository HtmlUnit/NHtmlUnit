// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class File : NHtmlUnit.Javascript.Host.File.Blob
   {
      static File()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.File o) =>
            new File(o));
      }

      public File(com.gargoylesoftware.htmlunit.javascript.host.file.File wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.File WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.File)WrappedObject; }
      }

      public File()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.File()) {}

      public File(net.sourceforge.htmlunit.corejs.javascript.NativeArray fileBits, string fileName, net.sourceforge.htmlunit.corejs.javascript.ScriptableObject properties)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.File(fileBits, fileName, properties)) {}


      public System.Int64 LastModified
      {
         get
         {
            return WObj.getLastModified();
         }
      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public System.String LastModifiedDate
      {
         get
         {
            return WObj.getLastModifiedDate();
         }
      }

      public System.String WebkitRelativePath
      {
         get
         {
            return WObj.getWebkitRelativePath();
         }
      }
// Generating method code for slice
      public virtual void Slice()
      {
         WObj.slice();
      }

// Generating method code for msClose
      public virtual void MsClose()
      {
         WObj.msClose();
      }

// Generating method code for getFile
      public virtual java.io.File GetFile()
      {
         return WObj.getFile();
      }

   }


}
