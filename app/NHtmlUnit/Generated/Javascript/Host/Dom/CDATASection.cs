// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class CDATASection : NHtmlUnit.Javascript.Host.Dom.Text
   {
      static CDATASection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.CDATASection o) =>
            new CDATASection(o));
      }

      public CDATASection(com.gargoylesoftware.htmlunit.javascript.host.dom.CDATASection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.CDATASection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.CDATASection)WrappedObject; }
      }

      public CDATASection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.CDATASection()) {}

   }


}
