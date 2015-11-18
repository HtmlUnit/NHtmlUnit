// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class InteractivePage : NHtmlUnit.SgmlPage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.IPage, NHtmlUnit.W3C.Dom.IDocument
   {
      static InteractivePage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.InteractivePage o) =>
            new InteractivePage(o));
      }

      public InteractivePage(com.gargoylesoftware.htmlunit.InteractivePage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.InteractivePage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.InteractivePage)WrappedObject; }
      }


      public NHtmlUnit.Html.DomElement FocusedElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getFocusedElement());
         }
      }


      public IList<NHtmlUnit.W3C.Dom.Ranges.IRange> SelectionRanges
      {
         get
         {
            return new ListWrapper<NHtmlUnit.W3C.Dom.Ranges.IRange>(
               WObj.getSelectionRanges());
         }
       }
// Generating method code for setFocusedElement
      public virtual bool SetFocusedElement(NHtmlUnit.Html.DomElement newElement)
      {
         return WObj.setFocusedElement((com.gargoylesoftware.htmlunit.html.DomElement)newElement.WrappedObject);
      }

// Generating method code for setFocusedElement
      public virtual bool SetFocusedElement(NHtmlUnit.Html.DomElement newElement, bool windowActivated)
      {
         return WObj.setFocusedElement((com.gargoylesoftware.htmlunit.html.DomElement)newElement.WrappedObject, windowActivated);
      }

// Generating method code for executeJavaScriptFunctionIfPossible
      public virtual NHtmlUnit.ScriptResult ExecuteJavaScriptFunctionIfPossible(net.sourceforge.htmlunit.corejs.javascript.Function function, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObject, System.Object[] args, NHtmlUnit.Html.DomNode htmlElementScope)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeJavaScriptFunctionIfPossible(function, thisObject, args, (com.gargoylesoftware.htmlunit.html.DomNode)htmlElementScope.WrappedObject));
      }

   }


}
