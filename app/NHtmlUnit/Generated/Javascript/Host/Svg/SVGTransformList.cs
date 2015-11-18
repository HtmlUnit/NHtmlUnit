// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGTransformList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGTransformList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransformList o) =>
            new SVGTransformList(o));
      }

      public SVGTransformList(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransformList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransformList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransformList)WrappedObject; }
      }

      public SVGTransformList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTransformList()) {}

   }


}
