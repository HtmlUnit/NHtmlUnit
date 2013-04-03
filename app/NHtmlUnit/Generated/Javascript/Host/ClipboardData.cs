// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ClipboardData : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ClipboardData()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ClipboardData o) =>
            new ClipboardData(o));
      }

      public ClipboardData(com.gargoylesoftware.htmlunit.javascript.host.ClipboardData wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ClipboardData WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ClipboardData)WrappedObject; }
      }

      public ClipboardData()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ClipboardData()) {}

   }


}
