// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgPage : NHtmlUnit.InteractivePage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.IPage, NHtmlUnit.W3C.Dom.IDocument
   {
      static SvgPage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgPage o) =>
            new SvgPage(o));
      }

      public SvgPage(com.gargoylesoftware.htmlunit.svg.SvgPage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgPage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgPage)WrappedObject; }
      }

      public SvgPage(NHtmlUnit.WebResponse webResponse, NHtmlUnit.W3C.Dom.INode node, NHtmlUnit.IWebWindow enclosingWindow)
         : this(new com.gargoylesoftware.htmlunit.svg.SvgPage((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (org.w3c.dom.Node)node.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject)) {}

   }


}
