// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlScript : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlScript()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlScript o) =>
            new HtmlScript(o));
      }

      public HtmlScript(com.gargoylesoftware.htmlunit.html.HtmlScript wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlScript WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlScript)WrappedObject; }
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

      public System.String HtmlForAttribute
      {
         get
         {
            return WObj.getHtmlForAttribute();
         }
      }

      public System.String EventAttribute
      {
         get
         {
            return WObj.getEventAttribute();
         }
      }

      public System.String CharsetAttribute
      {
         get
         {
            return WObj.getCharsetAttribute();
         }
      }

      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String LanguageAttribute
      {
         get
         {
            return WObj.getLanguageAttribute();
         }
      }
// Generating method code for executeScriptIfNeeded
      public virtual void ExecuteScriptIfNeeded()
      {
         WObj.executeScriptIfNeeded();
      }

// Generating method code for resetExecuted
      public virtual void ResetExecuted()
      {
         WObj.resetExecuted();
      }

   }


}
