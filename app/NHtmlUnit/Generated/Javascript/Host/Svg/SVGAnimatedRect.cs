// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedRect : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedRect()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedRect o) =>
            new SVGAnimatedRect(o));
      }

      public SVGAnimatedRect(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedRect wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedRect WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedRect)WrappedObject; }
      }

      public SVGAnimatedRect()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedRect()) {}

   }


}
