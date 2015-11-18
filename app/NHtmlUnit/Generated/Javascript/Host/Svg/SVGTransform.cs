// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGTransform : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGTransform()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransform o) =>
            new SVGTransform(o));
      }

      public SVGTransform(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransform wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransform WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransform)WrappedObject; }
      }

      public SVGTransform()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransform()) {}

   }


}
