// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGLength : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGLength()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLength o) =>
            new SVGLength(o));
      }

      public SVGLength(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLength wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLength WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLength)WrappedObject; }
      }

      public SVGLength()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLength()) {}

   }


}
