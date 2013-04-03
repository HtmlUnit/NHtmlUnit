// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgGroup : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static SvgGroup()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgGroup o) =>
            new SvgGroup(o));
      }

      public SvgGroup(com.gargoylesoftware.htmlunit.svg.SvgGroup wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgGroup WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgGroup)WrappedObject; }
      }

   }


}
