// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGTextContentElement : NHtmlUnit.Javascript.Host.Svg.SVGGraphicsElement
   {
      static SVGTextContentElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextContentElement o) =>
            new SVGTextContentElement(o));
      }

      public SVGTextContentElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextContentElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextContentElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextContentElement)WrappedObject; }
      }

      public SVGTextContentElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextContentElement()) {}

   }


}
