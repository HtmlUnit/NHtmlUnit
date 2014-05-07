// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgStyle : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static SvgStyle()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgStyle o) =>
            new SvgStyle(o));
      }

      public SvgStyle(com.gargoylesoftware.htmlunit.svg.SvgStyle wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgStyle WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgStyle)WrappedObject; }
      }

   }


}
