// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGTextElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGTextElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextElement o) =>
            new SVGTextElement(o));
      }

      public SVGTextElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextElement)WrappedObject; }
      }

      public SVGTextElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextElement()) {}

   }


}
