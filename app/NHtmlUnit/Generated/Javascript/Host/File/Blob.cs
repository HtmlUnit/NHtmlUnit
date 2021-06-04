// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class Blob : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Blob()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.Blob o) =>
            new Blob(o));
      }

      public Blob(com.gargoylesoftware.htmlunit.javascript.host.file.Blob wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.Blob WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.Blob)WrappedObject; }
      }

      public Blob()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.Blob()) {}

      public Blob(net.sourceforge.htmlunit.corejs.javascript.NativeArray fileBits, net.sourceforge.htmlunit.corejs.javascript.ScriptableObject properties)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.Blob(fileBits, properties)) {}


      public System.Int64 Size
      {
         get
         {
            return WObj.getSize();
         }
      }

      public System.Byte[] Bytes
      {
         get
         {
            return WObj.getBytes();
         }
      }

      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }
// Generating method code for slice
      public virtual NHtmlUnit.Javascript.Host.File.Blob Slice(object start, object end, object contentType)
      {
         var arg = WObj.slice(start, end, contentType);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.File.Blob>(arg);
      }

// Generating method code for text
      public virtual NHtmlUnit.Javascript.Host.Promise Text()
      {
         var arg = WObj.text();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for fillRequest
      public virtual void FillRequest(NHtmlUnit.WebRequest webRequest)
      {
         WObj.fillRequest((com.gargoylesoftware.htmlunit.WebRequest)webRequest.WrappedObject);
      }

   }


}
