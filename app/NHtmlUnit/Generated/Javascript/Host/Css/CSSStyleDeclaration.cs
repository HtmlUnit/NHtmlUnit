// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSStyleDeclaration : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

      public CSSStyleDeclaration(NHtmlUnit.Javascript.Host.Element element)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration((com.gargoylesoftware.htmlunit.javascript.host.Element)element.WrappedObject)) {}

      public CSSStyleDeclaration()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration()) {}


      public System.String PointerEvents
      {
         get
         {
            return WObj.getPointerEvents();
         }
         set
         {
            WObj.setPointerEvents(value);
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

      public System.String RubyOverhang
      {
         get
         {
            return WObj.getRubyOverhang();
         }
         set
         {
            WObj.setRubyOverhang(value);
         }

      }

      public System.String RubyPosition
      {
         get
         {
            return WObj.getRubyPosition();
         }
         set
         {
            WObj.setRubyPosition(value);
         }

      }

      public System.String Scrollbar3dLightColor
      {
         get
         {
            return WObj.getScrollbar3dLightColor();
         }
         set
         {
            WObj.setScrollbar3dLightColor(value);
         }

      }

      public System.String ScrollbarArrowColor
      {
         get
         {
            return WObj.getScrollbarArrowColor();
         }
         set
         {
            WObj.setScrollbarArrowColor(value);
         }

      }

      public System.String ScrollbarBaseColor
      {
         get
         {
            return WObj.getScrollbarBaseColor();
         }
         set
         {
            WObj.setScrollbarBaseColor(value);
         }

      }

      public System.String ScrollbarDarkShadowColor
      {
         get
         {
            return WObj.getScrollbarDarkShadowColor();
         }
         set
         {
            WObj.setScrollbarDarkShadowColor(value);
         }

      }

      public System.String ScrollbarFaceColor
      {
         get
         {
            return WObj.getScrollbarFaceColor();
         }
         set
         {
            WObj.setScrollbarFaceColor(value);
         }

      }

      public System.String ScrollbarHighlightColor
      {
         get
         {
            return WObj.getScrollbarHighlightColor();
         }
         set
         {
            WObj.setScrollbarHighlightColor(value);
         }

      }

      public System.String ScrollbarShadowColor
      {
         get
         {
            return WObj.getScrollbarShadowColor();
         }
         set
         {
            WObj.setScrollbarShadowColor(value);
         }

      }

      public System.String ScrollbarTrackColor
      {
         get
         {
            return WObj.getScrollbarTrackColor();
         }
         set
         {
            WObj.setScrollbarTrackColor(value);
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

      public System.String StyleFloat
      {
         get
         {
            return WObj.getStyleFloat();
         }
         set
         {
            WObj.setStyleFloat(value);
         }

      }

      public System.String TableLayout
      {
         get
         {
            return WObj.getTableLayout();
         }
         set
         {
            WObj.setTableLayout(value);
         }

      }

      public System.String TextAlign
      {
         get
         {
            return WObj.getTextAlign();
         }
         set
         {
            WObj.setTextAlign(value);
         }

      }

      public System.String TextAlignLast
      {
         get
         {
            return WObj.getTextAlignLast();
         }
         set
         {
            WObj.setTextAlignLast(value);
         }

      }

      public System.String TextAutospace
      {
         get
         {
            return WObj.getTextAutospace();
         }
         set
         {
            WObj.setTextAutospace(value);
         }

      }

      public System.String TextDecoration
      {
         get
         {
            return WObj.getTextDecoration();
         }
         set
         {
            WObj.setTextDecoration(value);
         }

      }

      public System.Boolean TextDecorationBlink
      {
         get
         {
            return WObj.getTextDecorationBlink();
         }
         set
         {
            WObj.setTextDecorationBlink(value);
         }

      }

      public System.Boolean TextDecorationLineThrough
      {
         get
         {
            return WObj.getTextDecorationLineThrough();
         }
         set
         {
            WObj.setTextDecorationLineThrough(value);
         }

      }

      public System.Boolean TextDecorationNone
      {
         get
         {
            return WObj.getTextDecorationNone();
         }
         set
         {
            WObj.setTextDecorationNone(value);
         }

      }

      public System.Boolean TextDecorationOverline
      {
         get
         {
            return WObj.getTextDecorationOverline();
         }
         set
         {
            WObj.setTextDecorationOverline(value);
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

      public System.String TextIndent
      {
         get
         {
            return WObj.getTextIndent();
         }
         set
         {
            WObj.setTextIndent(value);
         }

      }

      public System.String TextJustify
      {
         get
         {
            return WObj.getTextJustify();
         }
         set
         {
            WObj.setTextJustify(value);
         }

      }

      public System.String TextJustifyTrim
      {
         get
         {
            return WObj.getTextJustifyTrim();
         }
         set
         {
            WObj.setTextJustifyTrim(value);
         }

      }

      public System.String TextKashida
      {
         get
         {
            return WObj.getTextKashida();
         }
         set
         {
            WObj.setTextKashida(value);
         }

      }

      public System.String TextKashidaSpace
      {
         get
         {
            return WObj.getTextKashidaSpace();
         }
         set
         {
            WObj.setTextKashidaSpace(value);
         }

      }

      public System.String TextOverflow
      {
         get
         {
            return WObj.getTextOverflow();
         }
         set
         {
            WObj.setTextOverflow(value);
         }

      }

      public System.String TextShadow
      {
         get
         {
            return WObj.getTextShadow();
         }
         set
         {
            WObj.setTextShadow(value);
         }

      }

      public System.String TextTransform
      {
         get
         {
            return WObj.getTextTransform();
         }
         set
         {
            WObj.setTextTransform(value);
         }

      }

      public System.String TextUnderlinePosition
      {
         get
         {
            return WObj.getTextUnderlinePosition();
         }
         set
         {
            WObj.setTextUnderlinePosition(value);
         }

      }

      public System.String VerticalAlign
      {
         get
         {
            return WObj.getVerticalAlign();
         }
         set
         {
            WObj.setVerticalAlign(value);
         }

      }

      public System.String Visibility
      {
         get
         {
            return WObj.getVisibility();
         }
         set
         {
            WObj.setVisibility(value);
         }

      }

      public System.String WhiteSpace
      {
         get
         {
            return WObj.getWhiteSpace();
         }
         set
         {
            WObj.setWhiteSpace(value);
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

      public System.String Width
      {
         get
         {
            return WObj.getWidth();
         }
         set
         {
            WObj.setWidth(value);
         }

      }

      public System.String WordSpacing
      {
         get
         {
            return WObj.getWordSpacing();
         }
         set
         {
            WObj.setWordSpacing(value);
         }

      }

      public System.String WordWrap
      {
         get
         {
            return WObj.getWordWrap();
         }
         set
         {
            WObj.setWordWrap(value);
         }

      }

      public System.String WritingMode
      {
         get
         {
            return WObj.getWritingMode();
         }
         set
         {
            WObj.setWritingMode(value);
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

      public System.String Zoom
      {
         get
         {
            return WObj.getZoom();
         }
         set
         {
            WObj.setZoom(value);
         }

      }

      public System.String CounterIncrement
      {
         get
         {
            return WObj.getCounterIncrement();
         }
         set
         {
            WObj.setCounterIncrement(value);
         }

      }

      public System.String CounterReset
      {
         get
         {
            return WObj.getCounterReset();
         }
         set
         {
            WObj.setCounterReset(value);
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

      public System.String Cursor
      {
         get
         {
            return WObj.getCursor();
         }
         set
         {
            WObj.setCursor(value);
         }

      }

      public System.String Direction
      {
         get
         {
            return WObj.getDirection();
         }
         set
         {
            WObj.setDirection(value);
         }

      }

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

      public System.String EmptyCells
      {
         get
         {
            return WObj.getEmptyCells();
         }
         set
         {
            WObj.setEmptyCells(value);
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

      public System.String FontSize
      {
         get
         {
            return WObj.getFontSize();
         }
         set
         {
            WObj.setFontSize(value);
         }

      }

      public System.String FontSizeAdjust
      {
         get
         {
            return WObj.getFontSizeAdjust();
         }
         set
         {
            WObj.setFontSizeAdjust(value);
         }

      }

      public System.String FontStretch
      {
         get
         {
            return WObj.getFontStretch();
         }
         set
         {
            WObj.setFontStretch(value);
         }

      }

      public System.String FontStyle
      {
         get
         {
            return WObj.getFontStyle();
         }
         set
         {
            WObj.setFontStyle(value);
         }

      }

      public System.String FontVariant
      {
         get
         {
            return WObj.getFontVariant();
         }
         set
         {
            WObj.setFontVariant(value);
         }

      }

      public System.String FontWeight
      {
         get
         {
            return WObj.getFontWeight();
         }
         set
         {
            WObj.setFontWeight(value);
         }

      }

      public System.String Height
      {
         get
         {
            return WObj.getHeight();
         }
         set
         {
            WObj.setHeight(value);
         }

      }

      public System.String ImeMode
      {
         get
         {
            return WObj.getImeMode();
         }
         set
         {
            WObj.setImeMode(value);
         }

      }

      public System.String LayoutFlow
      {
         get
         {
            return WObj.getLayoutFlow();
         }
         set
         {
            WObj.setLayoutFlow(value);
         }

      }

      public System.String LayoutGrid
      {
         get
         {
            return WObj.getLayoutGrid();
         }
         set
         {
            WObj.setLayoutGrid(value);
         }

      }

      public System.String LayoutGridChar
      {
         get
         {
            return WObj.getLayoutGridChar();
         }
         set
         {
            WObj.setLayoutGridChar(value);
         }

      }

      public System.String LayoutGridLine
      {
         get
         {
            return WObj.getLayoutGridLine();
         }
         set
         {
            WObj.setLayoutGridLine(value);
         }

      }

      public System.String LayoutGridMode
      {
         get
         {
            return WObj.getLayoutGridMode();
         }
         set
         {
            WObj.setLayoutGridMode(value);
         }

      }

      public System.String LayoutGridType
      {
         get
         {
            return WObj.getLayoutGridType();
         }
         set
         {
            WObj.setLayoutGridType(value);
         }

      }

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }

      public System.String LetterSpacing
      {
         get
         {
            return WObj.getLetterSpacing();
         }
         set
         {
            WObj.setLetterSpacing(value);
         }

      }

      public System.String LineBreak
      {
         get
         {
            return WObj.getLineBreak();
         }
         set
         {
            WObj.setLineBreak(value);
         }

      }

      public System.String ListStyle
      {
         get
         {
            return WObj.getListStyle();
         }
         set
         {
            WObj.setListStyle(value);
         }

      }

      public System.String ListStyleImage
      {
         get
         {
            return WObj.getListStyleImage();
         }
         set
         {
            WObj.setListStyleImage(value);
         }

      }

      public System.String ListStylePosition
      {
         get
         {
            return WObj.getListStylePosition();
         }
         set
         {
            WObj.setListStylePosition(value);
         }

      }

      public System.String ListStyleType
      {
         get
         {
            return WObj.getListStyleType();
         }
         set
         {
            WObj.setListStyleType(value);
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

      public System.String MarginBottom
      {
         get
         {
            return WObj.getMarginBottom();
         }
         set
         {
            WObj.setMarginBottom(value);
         }

      }

      public System.String MarginLeft
      {
         get
         {
            return WObj.getMarginLeft();
         }
         set
         {
            WObj.setMarginLeft(value);
         }

      }

      public System.String MarginRight
      {
         get
         {
            return WObj.getMarginRight();
         }
         set
         {
            WObj.setMarginRight(value);
         }

      }

      public System.String MarginTop
      {
         get
         {
            return WObj.getMarginTop();
         }
         set
         {
            WObj.setMarginTop(value);
         }

      }

      public System.String MarkerOffset
      {
         get
         {
            return WObj.getMarkerOffset();
         }
         set
         {
            WObj.setMarkerOffset(value);
         }

      }

      public System.String Marks
      {
         get
         {
            return WObj.getMarks();
         }
         set
         {
            WObj.setMarks(value);
         }

      }

      public System.String MaxHeight
      {
         get
         {
            return WObj.getMaxHeight();
         }
         set
         {
            WObj.setMaxHeight(value);
         }

      }

      public System.String MaxWidth
      {
         get
         {
            return WObj.getMaxWidth();
         }
         set
         {
            WObj.setMaxWidth(value);
         }

      }

      public System.String MinHeight
      {
         get
         {
            return WObj.getMinHeight();
         }
         set
         {
            WObj.setMinHeight(value);
         }

      }

      public System.String MinWidth
      {
         get
         {
            return WObj.getMinWidth();
         }
         set
         {
            WObj.setMinWidth(value);
         }

      }

      public System.String MsBlockProgression
      {
         get
         {
            return WObj.getMsBlockProgression();
         }
         set
         {
            WObj.setMsBlockProgression(value);
         }

      }

      public System.String MsInterpolationMode
      {
         get
         {
            return WObj.getMsInterpolationMode();
         }
         set
         {
            WObj.setMsInterpolationMode(value);
         }

      }

      public System.String Opacity
      {
         get
         {
            return WObj.getOpacity();
         }
         set
         {
            WObj.setOpacity(value);
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

      public System.String OutlineColor
      {
         get
         {
            return WObj.getOutlineColor();
         }
         set
         {
            WObj.setOutlineColor(value);
         }

      }

      public System.String OutlineOffset
      {
         get
         {
            return WObj.getOutlineOffset();
         }
         set
         {
            WObj.setOutlineOffset(value);
         }

      }

      public System.String OutlineStyle
      {
         get
         {
            return WObj.getOutlineStyle();
         }
         set
         {
            WObj.setOutlineStyle(value);
         }

      }

      public System.String OutlineWidth
      {
         get
         {
            return WObj.getOutlineWidth();
         }
         set
         {
            WObj.setOutlineWidth(value);
         }

      }

      public System.String Overflow
      {
         get
         {
            return WObj.getOverflow();
         }
         set
         {
            WObj.setOverflow(value);
         }

      }

      public System.String OverflowX
      {
         get
         {
            return WObj.getOverflowX();
         }
         set
         {
            WObj.setOverflowX(value);
         }

      }

      public System.String OverflowY
      {
         get
         {
            return WObj.getOverflowY();
         }
         set
         {
            WObj.setOverflowY(value);
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

      public System.String PaddingBottom
      {
         get
         {
            return WObj.getPaddingBottom();
         }
         set
         {
            WObj.setPaddingBottom(value);
         }

      }

      public System.String PaddingLeft
      {
         get
         {
            return WObj.getPaddingLeft();
         }
         set
         {
            WObj.setPaddingLeft(value);
         }

      }

      public System.String PaddingRight
      {
         get
         {
            return WObj.getPaddingRight();
         }
         set
         {
            WObj.setPaddingRight(value);
         }

      }

      public System.String PaddingTop
      {
         get
         {
            return WObj.getPaddingTop();
         }
         set
         {
            WObj.setPaddingTop(value);
         }

      }

      public System.String Page
      {
         get
         {
            return WObj.getPage();
         }
         set
         {
            WObj.setPage(value);
         }

      }

      public System.String PageBreakAfter
      {
         get
         {
            return WObj.getPageBreakAfter();
         }
         set
         {
            WObj.setPageBreakAfter(value);
         }

      }

      public System.String PageBreakBefore
      {
         get
         {
            return WObj.getPageBreakBefore();
         }
         set
         {
            WObj.setPageBreakBefore(value);
         }

      }

      public System.String PageBreakInside
      {
         get
         {
            return WObj.getPageBreakInside();
         }
         set
         {
            WObj.setPageBreakInside(value);
         }

      }

      public System.String BorderCollapse
      {
         get
         {
            return WObj.getBorderCollapse();
         }
         set
         {
            WObj.setBorderCollapse(value);
         }

      }

      public System.String Bottom
      {
         get
         {
            return WObj.getBottom();
         }
         set
         {
            WObj.setBottom(value);
         }

      }

      public System.String Left
      {
         get
         {
            return WObj.getLeft();
         }
         set
         {
            WObj.setLeft(value);
         }

      }

      public System.String Right
      {
         get
         {
            return WObj.getRight();
         }
         set
         {
            WObj.setRight(value);
         }

      }

      public System.String Top
      {
         get
         {
            return WObj.getTop();
         }
         set
         {
            WObj.setTop(value);
         }

      }

      public System.String Background
      {
         get
         {
            return WObj.getBackground();
         }
         set
         {
            WObj.setBackground(value);
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

      public System.String BackgroundPositionX
      {
         get
         {
            return WObj.getBackgroundPositionX();
         }
         set
         {
            WObj.setBackgroundPositionX(value);
         }

      }

      public System.String BackgroundPositionY
      {
         get
         {
            return WObj.getBackgroundPositionY();
         }
         set
         {
            WObj.setBackgroundPositionY(value);
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

      public System.String Behavior
      {
         get
         {
            return WObj.getBehavior();
         }
         set
         {
            WObj.setBehavior(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
         }

      }

      public System.String BorderBottom
      {
         get
         {
            return WObj.getBorderBottom();
         }
         set
         {
            WObj.setBorderBottom(value);
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

      public System.String BorderBottomWidth
      {
         get
         {
            return WObj.getBorderBottomWidth();
         }
         set
         {
            WObj.setBorderBottomWidth(value);
         }

      }

      public System.String BorderColor
      {
         get
         {
            return WObj.getBorderColor();
         }
         set
         {
            WObj.setBorderColor(value);
         }

      }

      public System.String BorderLeft
      {
         get
         {
            return WObj.getBorderLeft();
         }
         set
         {
            WObj.setBorderLeft(value);
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

      public System.String BorderLeftWidth
      {
         get
         {
            return WObj.getBorderLeftWidth();
         }
         set
         {
            WObj.setBorderLeftWidth(value);
         }

      }

      public System.String BorderRight
      {
         get
         {
            return WObj.getBorderRight();
         }
         set
         {
            WObj.setBorderRight(value);
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

      public System.String BorderRightWidth
      {
         get
         {
            return WObj.getBorderRightWidth();
         }
         set
         {
            WObj.setBorderRightWidth(value);
         }

      }

      public System.String BorderSpacing
      {
         get
         {
            return WObj.getBorderSpacing();
         }
         set
         {
            WObj.setBorderSpacing(value);
         }

      }

      public System.String BorderStyle
      {
         get
         {
            return WObj.getBorderStyle();
         }
         set
         {
            WObj.setBorderStyle(value);
         }

      }

      public System.String BorderTop
      {
         get
         {
            return WObj.getBorderTop();
         }
         set
         {
            WObj.setBorderTop(value);
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

      public System.String BorderTopWidth
      {
         get
         {
            return WObj.getBorderTopWidth();
         }
         set
         {
            WObj.setBorderTopWidth(value);
         }

      }

      public System.String BorderWidth
      {
         get
         {
            return WObj.getBorderWidth();
         }
         set
         {
            WObj.setBorderWidth(value);
         }

      }

      public System.String BoxSizing
      {
         get
         {
            return WObj.getBoxSizing();
         }
         set
         {
            WObj.setBoxSizing(value);
         }

      }

      public System.String CaptionSide
      {
         get
         {
            return WObj.getCaptionSide();
         }
         set
         {
            WObj.setCaptionSide(value);
         }

      }

      public System.String Clear
      {
         get
         {
            return WObj.getClear();
         }
         set
         {
            WObj.setClear(value);
         }

      }

      public System.String Clip
      {
         get
         {
            return WObj.getClip();
         }
         set
         {
            WObj.setClip(value);
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

      public System.String Content
      {
         get
         {
            return WObj.getContent();
         }
         set
         {
            WObj.setContent(value);
         }

      }
// Generating method code for getPropertyValue
      public virtual string GetPropertyValue(string name)
      {
         return WObj.getPropertyValue(name);
      }

// Generating method code for getPropertyCSSValue
      public virtual NHtmlUnit.Javascript.Host.Css.CSSValue GetPropertyCSSValue(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSValue>(WObj.getPropertyCSSValue(name));
      }

// Generating method code for removeProperty
      public virtual string RemoveProperty(string name)
      {
         return WObj.removeProperty(name);
      }

// Generating method code for setExpression
      public virtual void SetExpression(string propertyName, string expression, string language)
      {
         WObj.setExpression(propertyName, expression, language);
      }

// Generating method code for removeExpression
      public virtual bool RemoveExpression(string propertyName)
      {
         return WObj.removeExpression(propertyName);
      }

// Generating method code for getAttribute
      public virtual object GetAttribute(string name, int flag)
      {
         return WObj.getAttribute(name, flag);
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

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

   }


}
