// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMMatrix : NHtmlUnit.Javascript.Host.Dom.DOMMatrixReadOnly
   {
      static DOMMatrix()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrix o) =>
            new DOMMatrix(o));
      }

      public DOMMatrix(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrix wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrix WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrix)WrappedObject; }
      }

      public DOMMatrix()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrix()) {}

   }


}
