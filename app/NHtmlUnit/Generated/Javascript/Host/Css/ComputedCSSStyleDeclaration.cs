// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class ComputedCSSStyleDeclaration : NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration
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

      public System.Int32 PaddingTopValue
      {
         get
         {
            return WObj.getPaddingTopValue();
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

      public System.Int32 BorderLeftValue
      {
         get
         {
            return WObj.getBorderLeftValue();
         }
      }

      public System.Int32 BorderRightValue
      {
         get
         {
            return WObj.getBorderRightValue();
         }
      }

      public System.Int32 BorderTopValue
      {
         get
         {
            return WObj.getBorderTopValue();
         }
      }

      public System.Int32 BorderBottomValue
      {
         get
         {
            return WObj.getBorderBottomValue();
         }
      }

      public System.Int32 MarginRightValue
      {
         get
         {
            return WObj.getMarginRightValue();
         }
      }

      public System.Int32 MarginTopValue
      {
         get
         {
            return WObj.getMarginTopValue();
         }
      }

      public System.Int32 MarginBottomValue
      {
         get
         {
            return WObj.getMarginBottomValue();
         }
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
      public virtual void ApplyStyleFromSelector(com.gargoylesoftware.css.dom.CSSStyleDeclarationImpl declaration, com.gargoylesoftware.css.parser.selector.Selector selector)
      {
         WObj.applyStyleFromSelector(declaration, selector);
      }

// Generating method code for setDefaultLocalStyleAttribute
      public virtual void SetDefaultLocalStyleAttribute(string name, string newValue)
      {
         WObj.setDefaultLocalStyleAttribute(name, newValue);
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

   }


}
