// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGSVGElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGSVGElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSVGElement o) =>
            new SVGSVGElement(o));
      }

      public SVGSVGElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSVGElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSVGElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSVGElement)WrappedObject; }
      }

      public SVGSVGElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSVGElement()) {}


      public NHtmlUnit.Javascript.Host.Svg.SVGMatrix ScreenCTM
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(
               WObj.getScreenCTM());
         }
      }

// Generating method code for createSVGMatrix
      public virtual NHtmlUnit.Javascript.Host.Svg.SVGMatrix CreateSVGMatrix()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Svg.SVGMatrix>(WObj.createSVGMatrix());
      }

   }


}
