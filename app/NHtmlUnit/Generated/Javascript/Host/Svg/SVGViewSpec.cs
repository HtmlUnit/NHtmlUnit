// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGViewSpec : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGViewSpec()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewSpec o) =>
            new SVGViewSpec(o));
      }

      public SVGViewSpec(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewSpec wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewSpec WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewSpec)WrappedObject; }
      }

      public SVGViewSpec()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewSpec()) {}

   }


}
