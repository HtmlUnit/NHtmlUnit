// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class ComputedCSSStyleDeclaration : NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static ComputedCSSStyleDeclaration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration o) =>
            new ComputedCSSStyleDeclaration(o));
      }

      public ComputedCSSStyleDeclaration(com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration)WrappedObject; }
      }

      public ComputedCSSStyleDeclaration()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration()) {}

      public ComputedCSSStyleDeclaration(NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration style)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration)style.WrappedObject)) {}


      public System.Int32 MarginRight
      {
         get
         {
            return WObj.getMarginRight();
         }
      }

      public System.Int32 MarginTop
      {
         get
         {
            return WObj.getMarginTop();
         }
      }

      public System.Int32 MarginBottom
      {
         get
         {
            return WObj.getMarginBottom();
         }
      }

      public System.Int32 ContentWidth
      {
         get
         {
            return WObj.getContentWidth();
         }
      }

      public System.Int32 ContentHeight
      {
         get
         {
            return WObj.getContentHeight();
         }
      }

      public System.String PositionWithInheritance
      {
         get
         {
            return WObj.getPositionWithInheritance();
         }
      }

      public System.String TopWithInheritance
      {
         get
         {
            return WObj.getTopWithInheritance();
         }
      }

      public System.String BottomWithInheritance
      {
         get
         {
            return WObj.getBottomWithInheritance();
         }
      }

      public System.Int32 PaddingTop
      {
         get
         {
            return WObj.getPaddingTop();
         }
      }

      public System.String LeftWithInheritance
      {
         get
         {
            return WObj.getLeftWithInheritance();
         }
      }

      public System.String RightWithInheritance
      {
         get
         {
            return WObj.getRightWithInheritance();
         }
      }

      public System.Int32 MarginLeft
      {
         get
         {
            return WObj.getMarginLeft();
         }
      }

      public System.Int32 PaddingLeft
      {
         get
         {
            return WObj.getPaddingLeft();
         }
      }

      public System.Int32 PaddingRight
      {
         get
         {
            return WObj.getPaddingRight();
         }
      }

      public System.Int32 PaddingBottom
      {
         get
         {
            return WObj.getPaddingBottom();
         }
      }

      public System.Int32 BorderLeft
      {
         get
         {
            return WObj.getBorderLeft();
         }
      }

      public System.Int32 BorderRight
      {
         get
         {
            return WObj.getBorderRight();
         }
      }

      public System.Int32 BorderTop
      {
         get
         {
            return WObj.getBorderTop();
         }
      }

      public System.Int32 BorderBottom
      {
         get
         {
            return WObj.getBorderBottom();
         }
      }
// Generating method code for isScrollable
      public virtual bool IsScrollable(bool horizontal)
      {
         return WObj.isScrollable(horizontal);
      }

// Generating method code for getLeft
      public virtual int GetLeft(bool includeMargin, bool includeBorder, bool includePadding)
      {
         return WObj.getLeft(includeMargin, includeBorder, includePadding);
      }

// Generating method code for getCalculatedWidth
      public virtual int GetCalculatedWidth(bool includeBorder, bool includePadding)
      {
         return WObj.getCalculatedWidth(includeBorder, includePadding);
      }

// Generating method code for getTop
      public virtual int GetTop(bool includeMargin, bool includeBorder, bool includePadding)
      {
         return WObj.getTop(includeMargin, includeBorder, includePadding);
      }

// Generating method code for getCalculatedHeight
      public virtual int GetCalculatedHeight(bool includeBorder, bool includePadding)
      {
         return WObj.getCalculatedHeight(includeBorder, includePadding);
      }

// Generating method code for applyStyleFromSelector
      public virtual void ApplyStyleFromSelector(NHtmlUnit.W3C.Dom.Css.ICSSStyleDeclaration declaration, org.w3c.css.sac.Selector selector)
      {
         WObj.applyStyleFromSelector((org.w3c.dom.css.CSSStyleDeclaration)declaration.WrappedObject, selector);
      }

// Generating method code for setDefaultLocalStyleAttribute
      public virtual void SetDefaultLocalStyleAttribute(string name, string newValue)
      {
         WObj.setDefaultLocalStyleAttribute(name, newValue);
      }

   }


}
