// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class DocumentFragment : NHtmlUnit.Javascript.Host.Node
   {
      static DocumentFragment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment o) =>
            new DocumentFragment(o));
      }

      public DocumentFragment(com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment)WrappedObject; }
      }

      public DocumentFragment()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment()) {}

   }


}
