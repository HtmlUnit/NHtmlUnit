// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGNumberList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGNumberList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumberList o) =>
            new SVGNumberList(o));
      }

      public SVGNumberList(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumberList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumberList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumberList)WrappedObject; }
      }

      public SVGNumberList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGNumberList()) {}

   }


}
