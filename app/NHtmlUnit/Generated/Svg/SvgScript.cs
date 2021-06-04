// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Svg
{
   public partial class SvgScript : NHtmlUnit.Svg.SvgElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IScriptElement
   {
      static SvgScript()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.svg.SvgScript o) =>
            new SvgScript(o));
      }

      public SvgScript(com.gargoylesoftware.htmlunit.svg.SvgScript wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.svg.SvgScript WObj
      {
         get { return (com.gargoylesoftware.htmlunit.svg.SvgScript)WrappedObject; }
      }


      public System.String DeferAttribute
      {
         get
         {
            return WObj.getDeferAttribute();
         }
      }

      public System.String SrcAttribute
      {
         get
         {
            return WObj.getSrcAttribute();
         }
      }

      public System.String CharsetAttribute
      {
         get
         {
            return WObj.getCharsetAttribute();
         }
      }
// Generating method code for isExecuted
      public virtual bool IsExecuted()
      {
         return WObj.isExecuted();
      }

// Generating method code for isDeferred
      public virtual bool IsDeferred()
      {
         return WObj.isDeferred();
      }

   }


}
