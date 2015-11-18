// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class LockedFile : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static LockedFile()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.LockedFile o) =>
            new LockedFile(o));
      }

      public LockedFile(com.gargoylesoftware.htmlunit.javascript.host.file.LockedFile wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.LockedFile WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.LockedFile)WrappedObject; }
      }

      public LockedFile()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.LockedFile()) {}

   }


}
