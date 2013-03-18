// Generated class v5, don't modify

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

      public ComputedCSSStyleDeclaration(NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration style)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration)style.WrappedObject)) {}

      public ComputedCSSStyleDeclaration()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration()) {}


      public System.Int32 MarginRightValue
      {
         get
         {
            return WObj.getMarginRightValue();
         }
      }

      public System.Int32 MarginBottomValue
      {
         get
         {
            return WObj.getMarginBottomValue();
         }
      }

      public System.String PositionWithInheritance
      {
         get
         {
            return WObj.getPositionWithInheritance();
         }
      }

      public System.Int32 MarginLeftValue
      {
         get
         {
            return WObj.getMarginLeftValue();
         }
      }

      public System.Int32 PaddingLeftValue
      {
         get
         {
            return WObj.getPaddingLeftValue();
         }
      }

      public System.Int32 BorderLeftValue
      {
         get
         {
            return WObj.getBorderLeftValue();
         }
      }

      public System.Int32 BorderTopValue
      {
         get
         {
            return WObj.getBorderTopValue();
         }
      }

      public System.Int32 MarginTopValue
      {
         get
         {
            return WObj.getMarginTopValue();
         }
      }

      public System.Int32 PaddingTopValue
      {
         get
         {
            return WObj.getPaddingTopValue();
         }
      }

      public System.Int32 BorderRightValue
      {
         get
         {
            return WObj.getBorderRightValue();
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

      public System.Int32 PaddingRightValue
      {
         get
         {
            return WObj.getPaddingRightValue();
         }
      }

      public System.Int32 PaddingBottomValue
      {
         get
         {
            return WObj.getPaddingBottomValue();
         }
      }

      public System.Int32 BorderBottomValue
      {
         get
         {
            return WObj.getBorderBottomValue();
         }
      }

      public java.util.Map StyleMap
      {
         get
         {
            return WObj.getStyleMap();
         }
      }
// Generating method code for getCalculatedWidth
      public virtual int GetCalculatedWidth(bool includeBorder, bool includePadding)
      {
         return WObj.getCalculatedWidth(includeBorder, includePadding);
      }

// Generating method code for getCalculatedHeight
      public virtual int GetCalculatedHeight(bool includeBorder, bool includePadding)
      {
         return WObj.getCalculatedHeight(includeBorder, includePadding);
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

// Generating method code for getTop
      public virtual int GetTop(bool includeMargin, bool includeBorder, bool includePadding)
      {
         return WObj.getTop(includeMargin, includeBorder, includePadding);
      }

// Generating method code for setDefaultLocalStyleAttribute
      public virtual void SetDefaultLocalStyleAttribute(string name, string newValue)
      {
         WObj.setDefaultLocalStyleAttribute(name, newValue);
      }

// Generating method code for applyStyleFromSelector
      public virtual void ApplyStyleFromSelector(NHtmlUnit.W3C.Dom.Css.ICSSStyleDeclaration declaration, org.w3c.css.sac.Selector selector)
      {
         WObj.applyStyleFromSelector((org.w3c.dom.css.CSSStyleDeclaration)declaration.WrappedObject, selector);
      }

   }


}
