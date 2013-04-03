// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class CDATASection : NHtmlUnit.Javascript.Host.Text
   {
      static CDATASection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.CDATASection o) =>
            new CDATASection(o));
      }

      public CDATASection(com.gargoylesoftware.htmlunit.javascript.host.CDATASection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.CDATASection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.CDATASection)WrappedObject; }
      }

      public CDATASection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.CDATASection()) {}

   }


}
