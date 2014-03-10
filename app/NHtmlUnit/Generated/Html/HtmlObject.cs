// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlObject : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlObject()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlObject o) =>
            new HtmlObject(o));
      }

      public HtmlObject(com.gargoylesoftware.htmlunit.html.HtmlObject wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlObject WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlObject)WrappedObject; }
      }


      public System.String DeclareAttribute
      {
         get
         {
            return WObj.getDeclareAttribute();
         }
      }

      public System.String ClassIdAttribute
      {
         get
         {
            return WObj.getClassIdAttribute();
         }
      }

      public System.String CodebaseAttribute
      {
         get
         {
            return WObj.getCodebaseAttribute();
         }
      }

      public System.String DataAttribute
      {
         get
         {
            return WObj.getDataAttribute();
         }
      }

      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String CodeTypeAttribute
      {
         get
         {
            return WObj.getCodeTypeAttribute();
         }
      }

      public System.String ArchiveAttribute
      {
         get
         {
            return WObj.getArchiveAttribute();
         }
      }

      public System.String StandbyAttribute
      {
         get
         {
            return WObj.getStandbyAttribute();
         }
      }

      public System.String HeightAttribute
      {
         get
         {
            return WObj.getHeightAttribute();
         }
      }

      public System.String WidthAttribute
      {
         get
         {
            return WObj.getWidthAttribute();
         }
      }

      public System.String UseMapAttribute
      {
         get
         {
            return WObj.getUseMapAttribute();
         }
      }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String TabIndexAttribute
      {
         get
         {
            return WObj.getTabIndexAttribute();
         }
      }

      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }

      public System.String BorderAttribute
      {
         get
         {
            return WObj.getBorderAttribute();
         }
      }

      public System.String HspaceAttribute
      {
         get
         {
            return WObj.getHspaceAttribute();
         }
      }

      public System.String VspaceAttribute
      {
         get
         {
            return WObj.getVspaceAttribute();
         }
      }
   }


}
