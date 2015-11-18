// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPreserveAspectRatio : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGPreserveAspectRatio()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPreserveAspectRatio o) =>
            new SVGPreserveAspectRatio(o));
      }

      public SVGPreserveAspectRatio(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPreserveAspectRatio wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPreserveAspectRatio WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPreserveAspectRatio)WrappedObject; }
      }

      public SVGPreserveAspectRatio()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPreserveAspectRatio()) {}

   }


}
