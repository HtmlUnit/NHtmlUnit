// Generated class v2.50.0.0, don't modify

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


      public System.Int32 ReadyState
      {
         get
         {
            return WObj.getReadyState();
         }
      }

      public System.Object Result
      {
         get
         {
            return WObj.getResult();
         }
      }
// Generating method code for readAsDataURL
      public virtual void ReadAsDataURL(object objectArg)
      {
         WObj.readAsDataURL(objectArg);
      }

// Generating method code for readAsArrayBuffer
      public virtual void ReadAsArrayBuffer(object objectArg)
      {
         WObj.readAsArrayBuffer(objectArg);
      }

// Generating method code for readAsText
      public virtual void ReadAsText(object objectArg, object encoding)
      {
         WObj.readAsText(objectArg, encoding);
      }

// Generating method code for getOnload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnload()
      {
         return WObj.getOnload();
      }

// Generating method code for setOnload
      public virtual void SetOnload(object onload)
      {
         WObj.setOnload(onload);
      }

// Generating method code for getOnerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnerror()
      {
         return WObj.getOnerror();
      }

// Generating method code for setOnerror
      public virtual void SetOnerror(object onerror)
      {
         WObj.setOnerror(onerror);
      }

   }


}
