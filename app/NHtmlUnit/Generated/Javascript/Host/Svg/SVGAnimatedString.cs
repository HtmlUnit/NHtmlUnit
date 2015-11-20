// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedString : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedString()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedString o) =>
            new SVGAnimatedString(o));
      }

      public SVGAnimatedString(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedString wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedString WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedString)WrappedObject; }
      }

      public SVGAnimatedString()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedString()) {}

   }


}
