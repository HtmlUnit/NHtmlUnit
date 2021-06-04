// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgRect : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static SvgRect()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgRect o) =>
            new SvgRect(o));
      }

      public SvgRect(com.gargoylesoftware.htmlunit.svg.SvgRect wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgRect WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgRect)WrappedObject; }
      }

   }


}
