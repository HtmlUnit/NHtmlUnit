// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgPath : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static SvgPath()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgPath o) =>
            new SvgPath(o));
      }

      public SvgPath(com.gargoylesoftware.htmlunit.svg.SvgPath wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgPath WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgPath)WrappedObject; }
      }

   }


}
