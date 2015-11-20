// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedBoolean : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedBoolean()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedBoolean o) =>
            new SVGAnimatedBoolean(o));
      }

      public SVGAnimatedBoolean(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedBoolean wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedBoolean WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedBoolean)WrappedObject; }
      }

      public SVGAnimatedBoolean()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedBoolean()) {}

   }


}
