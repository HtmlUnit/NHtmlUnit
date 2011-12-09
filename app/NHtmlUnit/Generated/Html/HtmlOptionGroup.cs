// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlOptionGroup : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement
   {
      static HtmlOptionGroup()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlOptionGroup o) =>
            new HtmlOptionGroup(o));
      }

      public HtmlOptionGroup(com.gargoylesoftware.htmlunit.html.HtmlOptionGroup wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlOptionGroup WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlOptionGroup)WrappedObject; }
      }


      public System.String DisabledAttribute
      {
         get
         {
            return WObj.getDisabledAttribute();
         }
      }

      public System.String LabelAttribute
      {
         get
         {
            return WObj.getLabelAttribute();
         }
      }

      public NHtmlUnit.Html.HtmlSelect EnclosingSelect
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlSelect>(
               WObj.getEnclosingSelect());
         }
      }

// Generating method code for isDisabled
      public virtual bool IsDisabled()
      {
         return WObj.isDisabled();
      }

   }


}
