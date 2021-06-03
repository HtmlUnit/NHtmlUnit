// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGFilterElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGFilterElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFilterElement o) =>
            new SVGFilterElement(o));
      }

      public SVGFilterElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFilterElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFilterElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFilterElement)WrappedObject; }
      }

      public SVGFilterElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFilterElement()) {}

   }


}
