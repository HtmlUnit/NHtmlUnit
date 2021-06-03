// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSStyleDeclaration : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSSStyleDeclaration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration o) =>
            new CSSStyleDeclaration(o));
      }

      public CSSStyleDeclaration(com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration)WrappedObject; }
      }

      public CSSStyleDeclaration()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration()) {}

      public CSSStyleDeclaration(NHtmlUnit.Javascript.Host.Element element)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration((com.gargoylesoftware.htmlunit.javascript.host.Element)element.WrappedObject)) {}


      public System.String Display
      {
         get
         {
            return WObj.getDisplay();
         }
         set
         {
            WObj.setDisplay(value);
         }

      }

      public System.String Font
      {
         get
         {
            return WObj.getFont();
         }
         set
         {
            WObj.setFont(value);
         }

      }

      public System.String LineHeight
      {
         get
         {
            return WObj.getLineHeight();
         }
         set
         {
            WObj.setLineHeight(value);
         }

      }

      public System.String FontFamily
      {
         get
         {
            return WObj.getFontFamily();
         }
         set
         {
            WObj.setFontFamily(value);
         }

      }

      public System.String Accelerator
      {
         get
         {
            return WObj.getAccelerator();
         }
         set
         {
            WObj.setAccelerator(value);
         }

      }

      public System.String BackgroundAttachment
      {
         get
         {
            return WObj.getBackgroundAttachment();
         }
         set
         {
            WObj.setBackgroundAttachment(value);
         }

      }

      public System.String BackgroundColor
      {
         get
         {
            return WObj.getBackgroundColor();
         }
         set
         {
            WObj.setBackgroundColor(value);
         }

      }

      public System.String BackgroundImage
      {
         get
         {
            return WObj.getBackgroundImage();
         }
         set
         {
            WObj.setBackgroundImage(value);
         }

      }

      public System.String BackgroundPosition
      {
         get
         {
            return WObj.getBackgroundPosition();
         }
         set
         {
            WObj.setBackgroundPosition(value);
         }

      }

      public System.String BackgroundRepeat
      {
         get
         {
            return WObj.getBackgroundRepeat();
         }
         set
         {
            WObj.setBackgroundRepeat(value);
         }

      }

      public System.String BorderBottomColor
      {
         get
         {
            return WObj.getBorderBottomColor();
         }
         set
         {
            WObj.setBorderBottomColor(value);
         }

      }

      public System.String BorderBottomStyle
      {
         get
         {
            return WObj.getBorderBottomStyle();
         }
         set
         {
            WObj.setBorderBottomStyle(value);
         }

      }

      public System.String BorderLeftColor
      {
         get
         {
            return WObj.getBorderLeftColor();
         }
         set
         {
            WObj.setBorderLeftColor(value);
         }

      }

      public System.String BorderLeftStyle
      {
         get
         {
            return WObj.getBorderLeftStyle();
         }
         set
         {
            WObj.setBorderLeftStyle(value);
         }

      }

      public System.String BorderRightColor
      {
         get
         {
            return WObj.getBorderRightColor();
         }
         set
         {
            WObj.setBorderRightColor(value);
         }

      }

      public System.String BorderRightStyle
      {
         get
         {
            return WObj.getBorderRightStyle();
         }
         set
         {
            WObj.setBorderRightStyle(value);
         }

      }

      public System.String BorderTopColor
      {
         get
         {
            return WObj.getBorderTopColor();
         }
         set
         {
            WObj.setBorderTopColor(value);
         }

      }

      public System.String BorderTopStyle
      {
         get
         {
            return WObj.getBorderTopStyle();
         }
         set
         {
            WObj.setBorderTopStyle(value);
         }

      }

      public System.String Color
      {
         get
         {
            return WObj.getColor();
         }
         set
         {
            WObj.setColor(value);
         }

      }

      public System.String CssFloat
      {
         get
         {
            return WObj.getCssFloat();
         }
         set
         {
            WObj.setCssFloat(value);
         }

      }

      public System.String CssText
      {
         get
         {
            return WObj.getCssText();
         }
         set
         {
            WObj.setCssText(value);
         }

      }

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }

      public System.String Margin
      {
         get
         {
            return WObj.getMargin();
         }
         set
         {
            WObj.setMargin(value);
         }

      }

      public System.String Outline
      {
         get
         {
            return WObj.getOutline();
         }
         set
         {
            WObj.setOutline(value);
         }

      }

      public System.String Padding
      {
         get
         {
            return WObj.getPadding();
         }
         set
         {
            WObj.setPadding(value);
         }

      }

      public System.Int32 PixelBottom
      {
         get
         {
            return WObj.getPixelBottom();
         }
         set
         {
            WObj.setPixelBottom(value);
         }

      }

      public System.Int32 PixelHeight
      {
         get
         {
            return WObj.getPixelHeight();
         }
         set
         {
            WObj.setPixelHeight(value);
         }

      }

      public System.Int32 PixelLeft
      {
         get
         {
            return WObj.getPixelLeft();
         }
         set
         {
            WObj.setPixelLeft(value);
         }

      }

      public System.Int32 PixelRight
      {
         get
         {
            return WObj.getPixelRight();
         }
         set
         {
            WObj.setPixelRight(value);
         }

      }

      public System.Int32 PixelTop
      {
         get
         {
            return WObj.getPixelTop();
         }
         set
         {
            WObj.setPixelTop(value);
         }

      }

      public System.Int32 PixelWidth
      {
         get
         {
            return WObj.getPixelWidth();
         }
         set
         {
            WObj.setPixelWidth(value);
         }

      }

      public System.Int32 PosBottom
      {
         get
         {
            return WObj.getPosBottom();
         }
         set
         {
            WObj.setPosBottom(value);
         }

      }

      public System.Int32 PosHeight
      {
         get
         {
            return WObj.getPosHeight();
         }
         set
         {
            WObj.setPosHeight(value);
         }

      }

      public System.Int32 PosLeft
      {
         get
         {
            return WObj.getPosLeft();
         }
         set
         {
            WObj.setPosLeft(value);
         }

      }

      public System.Int32 PosRight
      {
         get
         {
            return WObj.getPosRight();
         }
         set
         {
            WObj.setPosRight(value);
         }

      }

      public System.Int32 PosTop
      {
         get
         {
            return WObj.getPosTop();
         }
         set
         {
            WObj.setPosTop(value);
         }

      }

      public System.Int32 PosWidth
      {
         get
         {
            return WObj.getPosWidth();
         }
         set
         {
            WObj.setPosWidth(value);
         }

      }

      public System.String RubyAlign
      {
         get
         {
            return WObj.getRubyAlign();
         }
         set
         {
            WObj.setRubyAlign(value);
         }

      }

      public System.String Size
      {
         get
         {
            return WObj.getSize();
         }
         set
         {
            WObj.setSize(value);
         }

      }

      public System.Boolean TextDecorationUnderline
      {
         get
         {
            return WObj.getTextDecorationUnderline();
         }
         set
         {
            WObj.setTextDecorationUnderline(value);
         }

      }

      public System.String Widows
      {
         get
         {
            return WObj.getWidows();
         }
         set
         {
            WObj.setWidows(value);
         }

      }

      public System.String Orphans
      {
         get
         {
            return WObj.getOrphans();
         }
         set
         {
            WObj.setOrphans(value);
         }

      }

      public System.String Position
      {
         get
         {
            return WObj.getPosition();
         }
         set
         {
            WObj.setPosition(value);
         }

      }

      public System.Object ZIndex
      {
         get
         {
            return WObj.getZIndex();
         }
         set
         {
            WObj.setZIndex(value);
         }

      }
// Generating method code for getStyleAttribute
      public virtual string GetStyleAttribute(com.gargoylesoftware.htmlunit.javascript.host.css.StyleAttributes.Definition definition)
      {
         return WObj.getStyleAttribute(definition);
      }

// Generating method code for getStyleAttribute
      public virtual string GetStyleAttribute(com.gargoylesoftware.htmlunit.javascript.host.css.StyleAttributes.Definition definition, bool getDefaultValueIfEmpty)
      {
         return WObj.getStyleAttribute(definition, getDefaultValueIfEmpty);
      }

// Generating method code for isTextDecorationBlink
      public virtual bool IsTextDecorationBlink()
      {
         return WObj.isTextDecorationBlink();
      }

// Generating method code for isTextDecorationLineThrough
      public virtual bool IsTextDecorationLineThrough()
      {
         return WObj.isTextDecorationLineThrough();
      }

// Generating method code for isTextDecorationNone
      public virtual bool IsTextDecorationNone()
      {
         return WObj.isTextDecorationNone();
      }

// Generating method code for isTextDecorationOverline
      public virtual bool IsTextDecorationOverline()
      {
         return WObj.isTextDecorationOverline();
      }

// Generating method code for getPropertyValue
      public virtual string GetPropertyValue(string name)
      {
         return WObj.getPropertyValue(name);
      }

// Generating method code for getPropertyPriority
      public virtual string GetPropertyPriority(string name)
      {
         return WObj.getPropertyPriority(name);
      }

// Generating method code for setProperty
      public virtual void SetProperty(string name, object value, string important)
      {
         WObj.setProperty(name, value, important);
      }

// Generating method code for removeProperty
      public virtual string RemoveProperty(object name)
      {
         return WObj.removeProperty(name);
      }

// Generating method code for getAttribute
      public virtual object GetAttribute(string name, int flag)
      {
         var arg = WObj.getAttribute(name, flag);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setAttribute
      public virtual void SetAttribute(string name, string value, object flag)
      {
         WObj.setAttribute(name, value, flag);
      }

// Generating method code for removeAttribute
      public virtual bool RemoveAttribute(string name, object flag)
      {
         return WObj.removeAttribute(name, flag);
      }

// Generating method code for getFontSize
      public virtual string GetFontSize()
      {
         return WObj.getFontSize();
      }

// Generating method code for setFontSize
      public virtual void SetFontSize(object fontSize)
      {
         WObj.setFontSize(fontSize);
      }

// Generating method code for getBottom
      public virtual string GetBottom()
      {
         return WObj.getBottom();
      }

// Generating method code for setBottom
      public virtual void SetBottom(object bottom)
      {
         WObj.setBottom(bottom);
      }

// Generating method code for getHeight
      public virtual string GetHeight()
      {
         return WObj.getHeight();
      }

// Generating method code for setHeight
      public virtual void SetHeight(object height)
      {
         WObj.setHeight(height);
      }

// Generating method code for getLeft
      public virtual string GetLeft()
      {
         return WObj.getLeft();
      }

// Generating method code for setLeft
      public virtual void SetLeft(object left)
      {
         WObj.setLeft(left);
      }

// Generating method code for getRight
      public virtual string GetRight()
      {
         return WObj.getRight();
      }

// Generating method code for setRight
      public virtual void SetRight(object right)
      {
         WObj.setRight(right);
      }

// Generating method code for getTop
      public virtual string GetTop()
      {
         return WObj.getTop();
      }

// Generating method code for setTop
      public virtual void SetTop(object top)
      {
         WObj.setTop(top);
      }

// Generating method code for getWidth
      public virtual string GetWidth()
      {
         return WObj.getWidth();
      }

// Generating method code for setWidth
      public virtual void SetWidth(object width)
      {
         WObj.setWidth(width);
      }

// Generating method code for getBorderBottomWidth
      public virtual string GetBorderBottomWidth()
      {
         return WObj.getBorderBottomWidth();
      }

// Generating method code for setBorderBottomWidth
      public virtual void SetBorderBottomWidth(object borderBottomWidth)
      {
         WObj.setBorderBottomWidth(borderBottomWidth);
      }

// Generating method code for getBorderLeftWidth
      public virtual string GetBorderLeftWidth()
      {
         return WObj.getBorderLeftWidth();
      }

// Generating method code for setBorderLeftWidth
      public virtual void SetBorderLeftWidth(object borderLeftWidth)
      {
         WObj.setBorderLeftWidth(borderLeftWidth);
      }

// Generating method code for getBorderRightWidth
      public virtual string GetBorderRightWidth()
      {
         return WObj.getBorderRightWidth();
      }

// Generating method code for setBorderRightWidth
      public virtual void SetBorderRightWidth(object borderRightWidth)
      {
         WObj.setBorderRightWidth(borderRightWidth);
      }

// Generating method code for getBorderTopWidth
      public virtual string GetBorderTopWidth()
      {
         return WObj.getBorderTopWidth();
      }

// Generating method code for setBorderTopWidth
      public virtual void SetBorderTopWidth(object borderTopWidth)
      {
         WObj.setBorderTopWidth(borderTopWidth);
      }

// Generating method code for getLetterSpacing
      public virtual string GetLetterSpacing()
      {
         return WObj.getLetterSpacing();
      }

// Generating method code for setLetterSpacing
      public virtual void SetLetterSpacing(object letterSpacing)
      {
         WObj.setLetterSpacing(letterSpacing);
      }

// Generating method code for getMarginBottom
      public virtual string GetMarginBottom()
      {
         return WObj.getMarginBottom();
      }

// Generating method code for setMarginBottom
      public virtual void SetMarginBottom(object marginBottom)
      {
         WObj.setMarginBottom(marginBottom);
      }

// Generating method code for getMarginLeft
      public virtual string GetMarginLeft()
      {
         return WObj.getMarginLeft();
      }

// Generating method code for setMarginLeft
      public virtual void SetMarginLeft(object marginLeft)
      {
         WObj.setMarginLeft(marginLeft);
      }

// Generating method code for getMarginRight
      public virtual string GetMarginRight()
      {
         return WObj.getMarginRight();
      }

// Generating method code for setMarginRight
      public virtual void SetMarginRight(object marginRight)
      {
         WObj.setMarginRight(marginRight);
      }

// Generating method code for getMarginTop
      public virtual string GetMarginTop()
      {
         return WObj.getMarginTop();
      }

// Generating method code for setMarginTop
      public virtual void SetMarginTop(object marginTop)
      {
         WObj.setMarginTop(marginTop);
      }

// Generating method code for getMaxHeight
      public virtual string GetMaxHeight()
      {
         return WObj.getMaxHeight();
      }

// Generating method code for setMaxHeight
      public virtual void SetMaxHeight(object maxHeight)
      {
         WObj.setMaxHeight(maxHeight);
      }

// Generating method code for getMaxWidth
      public virtual string GetMaxWidth()
      {
         return WObj.getMaxWidth();
      }

// Generating method code for setMaxWidth
      public virtual void SetMaxWidth(object maxWidth)
      {
         WObj.setMaxWidth(maxWidth);
      }

// Generating method code for getMinHeight
      public virtual string GetMinHeight()
      {
         return WObj.getMinHeight();
      }

// Generating method code for setMinHeight
      public virtual void SetMinHeight(object minHeight)
      {
         WObj.setMinHeight(minHeight);
      }

// Generating method code for getMinWidth
      public virtual string GetMinWidth()
      {
         return WObj.getMinWidth();
      }

// Generating method code for setMinWidth
      public virtual void SetMinWidth(object minWidth)
      {
         WObj.setMinWidth(minWidth);
      }

// Generating method code for getOpacity
      public virtual string GetOpacity()
      {
         return WObj.getOpacity();
      }

// Generating method code for setOpacity
      public virtual void SetOpacity(object opacity)
      {
         WObj.setOpacity(opacity);
      }

// Generating method code for getOutlineWidth
      public virtual string GetOutlineWidth()
      {
         return WObj.getOutlineWidth();
      }

// Generating method code for setOutlineWidth
      public virtual void SetOutlineWidth(object outlineWidth)
      {
         WObj.setOutlineWidth(outlineWidth);
      }

// Generating method code for getPaddingBottom
      public virtual string GetPaddingBottom()
      {
         return WObj.getPaddingBottom();
      }

// Generating method code for setPaddingBottom
      public virtual void SetPaddingBottom(object paddingBottom)
      {
         WObj.setPaddingBottom(paddingBottom);
      }

// Generating method code for getPaddingLeft
      public virtual string GetPaddingLeft()
      {
         return WObj.getPaddingLeft();
      }

// Generating method code for setPaddingLeft
      public virtual void SetPaddingLeft(object paddingLeft)
      {
         WObj.setPaddingLeft(paddingLeft);
      }

// Generating method code for getPaddingRight
      public virtual string GetPaddingRight()
      {
         return WObj.getPaddingRight();
      }

// Generating method code for setPaddingRight
      public virtual void SetPaddingRight(object paddingRight)
      {
         WObj.setPaddingRight(paddingRight);
      }

// Generating method code for getPaddingTop
      public virtual string GetPaddingTop()
      {
         return WObj.getPaddingTop();
      }

// Generating method code for setPaddingTop
      public virtual void SetPaddingTop(object paddingTop)
      {
         WObj.setPaddingTop(paddingTop);
      }

// Generating method code for getTextIndent
      public virtual string GetTextIndent()
      {
         return WObj.getTextIndent();
      }

// Generating method code for setTextIndent
      public virtual void SetTextIndent(object textIndent)
      {
         WObj.setTextIndent(textIndent);
      }

// Generating method code for getVerticalAlign
      public virtual string GetVerticalAlign()
      {
         return WObj.getVerticalAlign();
      }

// Generating method code for setVerticalAlign
      public virtual void SetVerticalAlign(object verticalAlign)
      {
         WObj.setVerticalAlign(verticalAlign);
      }

// Generating method code for getWordSpacing
      public virtual string GetWordSpacing()
      {
         return WObj.getWordSpacing();
      }

// Generating method code for setWordSpacing
      public virtual void SetWordSpacing(object wordSpacing)
      {
         WObj.setWordSpacing(wordSpacing);
      }

   }


}
