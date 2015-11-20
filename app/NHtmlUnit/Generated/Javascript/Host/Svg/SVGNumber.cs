// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGNumber : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGNumber()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumber o) =>
            new SVGNumber(o));
      }

      public SVGNumber(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumber wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumber WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumber)WrappedObject; }
      }

      public SVGNumber()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumber()) {}

   }


}
