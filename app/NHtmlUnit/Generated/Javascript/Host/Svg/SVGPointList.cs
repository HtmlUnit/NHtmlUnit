// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPointList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGPointList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPointList o) =>
            new SVGPointList(o));
      }

      public SVGPointList(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPointList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPointList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPointList)WrappedObject; }
      }

      public SVGPointList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPointList()) {}

   }


}
