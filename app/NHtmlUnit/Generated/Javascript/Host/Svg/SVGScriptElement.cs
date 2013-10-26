// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGScriptElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGScriptElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGScriptElement o) =>
            new SVGScriptElement(o));
      }

      public SVGScriptElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGScriptElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGScriptElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGScriptElement)WrappedObject; }
      }

      public SVGScriptElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGScriptElement()) {}

   }


}
