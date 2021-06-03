// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgLine : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static SvgLine()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgLine o) =>
            new SvgLine(o));
      }

      public SvgLine(com.gargoylesoftware.htmlunit.svg.SvgLine wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgLine WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgLine)WrappedObject; }
      }

   }


}
