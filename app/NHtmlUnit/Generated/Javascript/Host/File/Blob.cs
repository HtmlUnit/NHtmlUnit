// Generated class v2.19.0.0, don't modify

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

   }


}
