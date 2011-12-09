// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLElement : NHtmlUnit.Javascript.Host.Element, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement o) =>
            new HTMLElement(o));
      }

      public HTMLElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)WrappedObject; }
      }

      public HTMLElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement()) {}


      public System.Int32 PosY
      {
         get
         {
            return WObj.getPosY();
         }
      }

      public System.Int32 PosX
      {
         get
         {
            return WObj.getPosX();
         }
      }

      public System.Int32 AvailHeight
      {
         get
         {
            return WObj.getAvailHeight();
         }
      }

      public System.Int32 AvailWidth
      {
         get
         {
            return WObj.getAvailWidth();
         }
      }

      public System.Int32 BufferDepth
      {
         get
         {
            return WObj.getBufferDepth();
         }
      }

      public NHtmlUnit.Javascript.Host.BoxObject BoxObject
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.BoxObject>(
               WObj.getBoxObject());
         }
      }


      public System.Int32 ColorDepth
      {
         get
         {
            return WObj.getColorDepth();
         }
      }

      public System.String ConnectionType
      {
         get
         {
            return WObj.getConnectionType();
         }
      }

      public System.Boolean CookieEnabled
      {
         get
         {
            return WObj.getCookieEnabled();
         }
      }

      public System.String CpuClass
      {
         get
         {
            return WObj.getCpuClass();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }

      public System.Boolean JavaEnabled
      {
         get
         {
            return WObj.getJavaEnabled();
         }
      }

      public System.String Platform
      {
         get
         {
            return WObj.getPlatform();
         }
      }

      public System.String SystemLanguage
      {
         get
         {
            return WObj.getSystemLanguage();
         }
      }

      public System.String UserLanguage
      {
         get
         {
            return WObj.getUserLanguage();
         }
      }

      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public NHtmlUnit.Javascript.Host.Html.HTMLElement ParentHTMLElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getParentHTMLElement());
         }
      }

// Generating method code for jsxGet_currentStyle
      public virtual NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration JsxGet_currentStyle()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration>(WObj.jsxGet_currentStyle());
      }

// Generating method code for jsxFunction_setActive
      public virtual void JsxFunction_setActive()
      {
         WObj.jsxFunction_setActive();
      }

// Generating method code for jsxFunction_removeAttributeNS
      public virtual void JsxFunction_removeAttributeNS(string namespaceURI, string localName)
      {
         WObj.jsxFunction_removeAttributeNS(namespaceURI, localName);
      }

// Generating method code for jsxGet_parentElement
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement JsxGet_parentElement()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.jsxGet_parentElement());
      }

// Generating method code for jsxGet_offsetLeft
      public virtual int JsxGet_offsetLeft()
      {
         return WObj.jsxGet_offsetLeft();
      }

// Generating method code for jsxGet_offsetParent
      public virtual object JsxGet_offsetParent()
      {
         return WObj.jsxGet_offsetParent();
      }

// Generating method code for jsxGet_offsetTop
      public virtual int JsxGet_offsetTop()
      {
         return WObj.jsxGet_offsetTop();
      }

// Generating method code for jsxGet_clientLeft
      public virtual int JsxGet_clientLeft()
      {
         return WObj.jsxGet_clientLeft();
      }

// Generating method code for jsxGet_clientTop
      public virtual int JsxGet_clientTop()
      {
         return WObj.jsxGet_clientTop();
      }

// Generating method code for jsxGet_all
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxGet_all()
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxGet_all());
      }

// Generating method code for jsxGet_style
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration JsxGet_style()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(WObj.jsxGet_style());
      }

// Generating method code for jsxGet_runtimeStyle
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration JsxGet_runtimeStyle()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(WObj.jsxGet_runtimeStyle());
      }

// Generating method code for jsxGet_id
      public virtual string JsxGet_id()
      {
         return WObj.jsxGet_id();
      }

// Generating method code for jsxSet_id
      public virtual void JsxSet_id(string newId)
      {
         WObj.jsxSet_id(newId);
      }

// Generating method code for jsxGet_title
      public virtual string JsxGet_title()
      {
         return WObj.jsxGet_title();
      }

// Generating method code for jsxSet_title
      public virtual void JsxSet_title(string newTitle)
      {
         WObj.jsxSet_title(newTitle);
      }

// Generating method code for jsxGet_disabled
      public virtual bool JsxGet_disabled()
      {
         return WObj.jsxGet_disabled();
      }

// Generating method code for jsxGet_document
      public virtual NHtmlUnit.Javascript.Host.Html.DocumentProxy JsxGet_document()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DocumentProxy>(WObj.jsxGet_document());
      }

// Generating method code for jsxSet_disabled
      public virtual void JsxSet_disabled(bool disabled)
      {
         WObj.jsxSet_disabled(disabled);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for jsxFunction_clearAttributes
      public virtual void JsxFunction_clearAttributes()
      {
         WObj.jsxFunction_clearAttributes();
      }

// Generating method code for jsxFunction_mergeAttributes
      public virtual void JsxFunction_mergeAttributes(NHtmlUnit.Javascript.Host.Html.HTMLElement source, object preserveIdentity)
      {
         WObj.jsxFunction_mergeAttributes((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)source.WrappedObject, preserveIdentity);
      }

// Generating method code for jsxFunction_getAttributeNodeNS
      public virtual object JsxFunction_getAttributeNodeNS(string namespaceURI, string localName)
      {
         return WObj.jsxFunction_getAttributeNodeNS(namespaceURI, localName);
      }

// Generating method code for jsxFunction_getAttributeNS
      public virtual string JsxFunction_getAttributeNS(string namespaceURI, string localName)
      {
         return WObj.jsxFunction_getAttributeNS(namespaceURI, localName);
      }

// Generating method code for jsxFunction_hasAttributeNS
      public virtual bool JsxFunction_hasAttributeNS(string namespaceURI, string localName)
      {
         return WObj.jsxFunction_hasAttributeNS(namespaceURI, localName);
      }

// Generating method code for jsxFunction_setAttributeNS
      public virtual void JsxFunction_setAttributeNS(string namespaceURI, string qualifiedName, string value)
      {
         WObj.jsxFunction_setAttributeNS(namespaceURI, qualifiedName, value);
      }

// Generating method code for jsxFunction_removeAttributeNode
      public virtual void JsxFunction_removeAttributeNode(NHtmlUnit.Javascript.Host.Attr attribute)
      {
         WObj.jsxFunction_removeAttributeNode((com.gargoylesoftware.htmlunit.javascript.host.Attr)attribute.WrappedObject);
      }

// Generating method code for jsxFunction_removeNode
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement JsxFunction_removeNode(bool removeChildren)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.jsxFunction_removeNode(removeChildren));
      }

// Generating method code for jsxFunction_setAttributeNode
      public virtual NHtmlUnit.Javascript.Host.Attr JsxFunction_setAttributeNode(NHtmlUnit.Javascript.Host.Attr newAtt)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Attr>(WObj.jsxFunction_setAttributeNode((com.gargoylesoftware.htmlunit.javascript.host.Attr)newAtt.WrappedObject));
      }

// Generating method code for jsxFunction_getElementsByClassName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxFunction_getElementsByClassName(string className)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxFunction_getElementsByClassName(className));
      }

// Generating method code for jsxGet_className
      public virtual object JsxGet_className()
      {
         return WObj.jsxGet_className();
      }

// Generating method code for jsxGet_clientHeight
      public virtual int JsxGet_clientHeight()
      {
         return WObj.jsxGet_clientHeight();
      }

// Generating method code for jsxGet_clientWidth
      public virtual int JsxGet_clientWidth()
      {
         return WObj.jsxGet_clientWidth();
      }

// Generating method code for jsxSet_className
      public virtual void JsxSet_className(string className)
      {
         WObj.jsxSet_className(className);
      }

// Generating method code for jsxGet_innerHTML
      public virtual string JsxGet_innerHTML()
      {
         return WObj.jsxGet_innerHTML();
      }

// Generating method code for jsxGet_outerHTML
      public virtual string JsxGet_outerHTML()
      {
         return WObj.jsxGet_outerHTML();
      }

// Generating method code for jsxSet_innerHTML
      public virtual void JsxSet_innerHTML(object value)
      {
         WObj.jsxSet_innerHTML(value);
      }

// Generating method code for jsxSet_outerHTML
      public virtual void JsxSet_outerHTML(string value)
      {
         WObj.jsxSet_outerHTML(value);
      }

// Generating method code for jsxFunction_insertAdjacentHTML
      public virtual void JsxFunction_insertAdjacentHTML(string whereArg, string text)
      {
         WObj.jsxFunction_insertAdjacentHTML(whereArg, text);
      }

// Generating method code for jsxFunction_insertAdjacentElement
      public virtual object JsxFunction_insertAdjacentElement(string whereArg, object objectArg)
      {
         return WObj.jsxFunction_insertAdjacentElement(whereArg, objectArg);
      }

// Generating method code for jsxFunction_addBehavior
      public virtual int JsxFunction_addBehavior(string behavior)
      {
         return WObj.jsxFunction_addBehavior(behavior);
      }

// Generating method code for jsxFunction_removeBehavior
      public virtual void JsxFunction_removeBehavior(int id)
      {
         WObj.jsxFunction_removeBehavior(id);
      }

// Generating method code for addComponentRequest
      public virtual void AddComponentRequest(string id, string idType, string minVersion)
      {
         WObj.addComponentRequest(id, idType, minVersion);
      }

// Generating method code for clearComponentRequest
      public virtual void ClearComponentRequest()
      {
         WObj.clearComponentRequest();
      }

// Generating method code for compareVersions
      public virtual int CompareVersions(string v1, string v2)
      {
         return WObj.compareVersions(v1, v2);
      }

// Generating method code for doComponentRequest
      public virtual bool DoComponentRequest()
      {
         return WObj.doComponentRequest();
      }

// Generating method code for getComponentVersion
      public virtual string GetComponentVersion(string id, string idType)
      {
         return WObj.getComponentVersion(id, idType);
      }

// Generating method code for isComponentInstalled
      public virtual bool IsComponentInstalled(string id, string idType, string minVersion)
      {
         return WObj.isComponentInstalled(id, idType, minVersion);
      }

// Generating method code for startDownload
      public virtual void StartDownload(string uri, net.sourceforge.htmlunit.corejs.javascript.Function callback)
      {
         WObj.startDownload(uri, callback);
      }

// Generating method code for isHomePage
      public virtual bool IsHomePage(string url)
      {
         return WObj.isHomePage(url);
      }

// Generating method code for navigateHomePage
      public virtual void NavigateHomePage()
      {
         WObj.navigateHomePage();
      }

// Generating method code for jsxGet_children
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxGet_children()
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxGet_children());
      }

// Generating method code for jsxGet_offsetHeight
      public virtual int JsxGet_offsetHeight()
      {
         return WObj.jsxGet_offsetHeight();
      }

// Generating method code for jsxGet_offsetWidth
      public virtual int JsxGet_offsetWidth()
      {
         return WObj.jsxGet_offsetWidth();
      }

// Generating method code for jsxGet_scrollTop
      public virtual int JsxGet_scrollTop()
      {
         return WObj.jsxGet_scrollTop();
      }

// Generating method code for jsxSet_scrollTop
      public virtual void JsxSet_scrollTop(int scroll)
      {
         WObj.jsxSet_scrollTop(scroll);
      }

// Generating method code for jsxGet_scrollLeft
      public virtual int JsxGet_scrollLeft()
      {
         return WObj.jsxGet_scrollLeft();
      }

// Generating method code for jsxSet_scrollLeft
      public virtual void JsxSet_scrollLeft(int scroll)
      {
         WObj.jsxSet_scrollLeft(scroll);
      }

// Generating method code for jsxGet_scrollHeight
      public virtual int JsxGet_scrollHeight()
      {
         return WObj.jsxGet_scrollHeight();
      }

// Generating method code for jsxGet_scrollWidth
      public virtual int JsxGet_scrollWidth()
      {
         return WObj.jsxGet_scrollWidth();
      }

// Generating method code for jsxGet_scopeName
      public virtual string JsxGet_scopeName()
      {
         return WObj.jsxGet_scopeName();
      }

// Generating method code for jsxGet_tagUrn
      public virtual string JsxGet_tagUrn()
      {
         return WObj.jsxGet_tagUrn();
      }

// Generating method code for jsxSet_tagUrn
      public virtual void JsxSet_tagUrn(string tagUrn)
      {
         WObj.jsxSet_tagUrn(tagUrn);
      }

// Generating method code for jsxFunction_scrollIntoView
      public virtual void JsxFunction_scrollIntoView()
      {
         WObj.jsxFunction_scrollIntoView();
      }

// Generating method code for jsxFunction_getBoundingClientRect
      public virtual NHtmlUnit.Javascript.Host.TextRectangle JsxFunction_getBoundingClientRect()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.TextRectangle>(WObj.jsxFunction_getBoundingClientRect());
      }

// Generating method code for jsxFunction_getClientRects
      public virtual object JsxFunction_getClientRects()
      {
         return WObj.jsxFunction_getClientRects();
      }

// Generating method code for jsxFunction_setExpression
      public virtual void JsxFunction_setExpression(string propertyName, string expression, string language)
      {
         WObj.jsxFunction_setExpression(propertyName, expression, language);
      }

// Generating method code for jsxFunction_removeExpression
      public virtual bool JsxFunction_removeExpression(string propertyName)
      {
         return WObj.jsxFunction_removeExpression(propertyName);
      }

// Generating method code for jsxGet_uniqueID
      public virtual string JsxGet_uniqueID()
      {
         return WObj.jsxGet_uniqueID();
      }

// Generating method code for jsxFunction_dispatchEvent
      public virtual bool JsxFunction_dispatchEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return WObj.jsxFunction_dispatchEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject);
      }

// Generating method code for jsxFunction_blur
      public virtual void JsxFunction_blur()
      {
         WObj.jsxFunction_blur();
      }

// Generating method code for jsxFunction_createTextRange
      public virtual object JsxFunction_createTextRange()
      {
         return WObj.jsxFunction_createTextRange();
      }

// Generating method code for jsxFunction_contains
      public virtual bool JsxFunction_contains(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
      {
         return WObj.jsxFunction_contains((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject);
      }

// Generating method code for jsxFunction_focus
      public virtual void JsxFunction_focus()
      {
         WObj.jsxFunction_focus();
      }

// Generating method code for jsxFunction_querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.StaticNodeList JsxFunction_querySelectorAll(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.StaticNodeList>(WObj.jsxFunction_querySelectorAll(selectors));
      }

// Generating method code for jsxFunction_querySelector
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_querySelector(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_querySelector(selectors));
      }

// Generating method code for jsxGet_filters
      public virtual object JsxGet_filters()
      {
         return WObj.jsxGet_filters();
      }

// Generating method code for jsxFunction_click
      public virtual void JsxFunction_click()
      {
         WObj.jsxFunction_click();
      }

// Generating method code for jsxGet_spellcheck
      public virtual bool JsxGet_spellcheck()
      {
         return WObj.jsxGet_spellcheck();
      }

// Generating method code for jsxSet_spellcheck
      public virtual void JsxSet_spellcheck(bool spellcheck)
      {
         WObj.jsxSet_spellcheck(spellcheck);
      }

// Generating method code for jsxGet_lang
      public virtual string JsxGet_lang()
      {
         return WObj.jsxGet_lang();
      }

// Generating method code for jsxSet_lang
      public virtual void JsxSet_lang(string lang)
      {
         WObj.jsxSet_lang(lang);
      }

// Generating method code for jsxGet_language
      public virtual string JsxGet_language()
      {
         return WObj.jsxGet_language();
      }

// Generating method code for jsxSet_language
      public virtual void JsxSet_language(string language)
      {
         WObj.jsxSet_language(language);
      }

// Generating method code for jsxGet_dir
      public virtual string JsxGet_dir()
      {
         return WObj.jsxGet_dir();
      }

// Generating method code for jsxSet_dir
      public virtual void JsxSet_dir(string dir)
      {
         WObj.jsxSet_dir(dir);
      }

// Generating method code for jsxGet_tabIndex
      public virtual int JsxGet_tabIndex()
      {
         return WObj.jsxGet_tabIndex();
      }

// Generating method code for jsxSet_tabIndex
      public virtual void JsxSet_tabIndex(int tabIndex)
      {
         WObj.jsxSet_tabIndex(tabIndex);
      }

// Generating method code for jsxFunction_doScroll
      public virtual void JsxFunction_doScroll(string scrollAction)
      {
         WObj.jsxFunction_doScroll(scrollAction);
      }

// Generating method code for jsxGet_accessKey
      public virtual string JsxGet_accessKey()
      {
         return WObj.jsxGet_accessKey();
      }

// Generating method code for jsxSet_accessKey
      public virtual void JsxSet_accessKey(string accessKey)
      {
         WObj.jsxSet_accessKey(accessKey);
      }

   }


}
