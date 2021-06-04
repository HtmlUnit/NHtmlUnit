// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgStyle : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
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
