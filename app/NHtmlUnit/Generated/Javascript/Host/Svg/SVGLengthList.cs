// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGLengthList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGLengthList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLengthList o) =>
            new SVGLengthList(o));
      }

      public SVGLengthList(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLengthList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLengthList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLengthList)WrappedObject; }
      }

      public SVGLengthList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLengthList()) {}

   }


}
