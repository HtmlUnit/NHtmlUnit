// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgElement : NHtmlUnit.Html.DomElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static SvgElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgElement o) =>
            new SvgElement(o));
      }

      public SvgElement(com.gargoylesoftware.htmlunit.svg.SvgElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgElement)WrappedObject; }
      }

   }


}
