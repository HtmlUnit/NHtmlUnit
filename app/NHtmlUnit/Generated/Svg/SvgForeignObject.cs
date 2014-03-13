// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgForeignObject : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static SvgForeignObject()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgForeignObject o) =>
            new SvgForeignObject(o));
      }

      public SvgForeignObject(com.gargoylesoftware.htmlunit.svg.SvgForeignObject wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgForeignObject WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgForeignObject)WrappedObject; }
      }

   }


}
