// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgPolyline : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static SvgPolyline()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgPolyline o) =>
            new SvgPolyline(o));
      }

      public SvgPolyline(com.gargoylesoftware.htmlunit.svg.SvgPolyline wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgPolyline WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgPolyline)WrappedObject; }
      }

   }


}
