// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class RadioNodeList : NHtmlUnit.Javascript.Host.Dom.NodeList
   {
      static RadioNodeList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.RadioNodeList o) =>
            new RadioNodeList(o));
      }

      public RadioNodeList(com.gargoylesoftware.htmlunit.javascript.host.dom.RadioNodeList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.RadioNodeList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.RadioNodeList)WrappedObject; }
      }

      public RadioNodeList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.RadioNodeList()) {}

   }


}
