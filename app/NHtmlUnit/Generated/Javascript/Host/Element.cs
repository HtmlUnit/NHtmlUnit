// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Element : NHtmlUnit.Javascript.Host.Dom.Node
   {
      static Element()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Element o) =>
            new Element(o));
      }

      public Element(com.gargoylesoftware.htmlunit.javascript.host.Element wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Element WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Element)WrappedObject; }
      }

      public Element()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Element()) {}


      public System.String Id
      {
         get
         {
            return WObj.getId();
         }
         set
         {
            WObj.setId(value);
         }

      }

      public NHtmlUnit.Javascript.Host.ClientRect BoundingClientRect
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ClientRect>(
               WObj.getBoundingClientRect());
         }
      }


      public System.String TagName
      {
         get
         {
            return WObj.getTagName();
         }
      }

      public System.Int32 ClientHeight
      {
         get
         {
            return WObj.getClientHeight();
         }
      }

      public System.Int32 ClientWidth
      {
         get
         {
            return WObj.getClientWidth();
         }
      }

      public System.Int32 ChildElementCount
      {
         get
         {
            return WObj.getChildElementCount();
         }
      }

      public NHtmlUnit.Javascript.Host.Element FirstElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getFirstElementChild());
         }
      }


      public NHtmlUnit.Javascript.Host.Element LastElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getLastElementChild());
         }
      }


      public NHtmlUnit.Javascript.Host.Element NextElementSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getNextElementSibling());
         }
      }


      public NHtmlUnit.Javascript.Host.Element PreviousElementSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getPreviousElementSibling());
         }
      }


      public NHtmlUnit.Javascript.Host.Html.HTMLCollection Children
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(
               WObj.getChildren());
         }
      }


      public NHtmlUnit.Javascript.Host.Dom.DOMTokenList ClassList
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DOMTokenList>(
               WObj.getClassList());
         }
      }


      public System.Int32 ClientLeft
      {
         get
         {
            return WObj.getClientLeft();
         }
      }

      public System.Int32 ClientTop
      {
         get
         {
            return WObj.getClientTop();
         }
      }

      public NHtmlUnit.Javascript.Host.ClientRectList ClientRects
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ClientRectList>(
               WObj.getClientRects());
         }
      }


      public System.Int32 ScrollTop
      {
         get
         {
            return WObj.getScrollTop();
         }
         set
         {
            WObj.setScrollTop(value);
         }

      }

      public System.Int32 ScrollLeft
      {
         get
         {
            return WObj.getScrollLeft();
         }
         set
         {
            WObj.setScrollLeft(value);
         }

      }

      public System.Int32 ScrollHeight
      {
         get
         {
            return WObj.getScrollHeight();
         }
      }

      public System.Int32 ScrollWidth
      {
         get
         {
            return WObj.getScrollWidth();
         }
      }
// Generating method code for removeAttributeNS
      public virtual void RemoveAttributeNS(string namespaceURI, string localName)
      {
         WObj.removeAttributeNS(namespaceURI, localName);
      }

// Generating method code for getAttribute
      public virtual string GetAttribute(string attributeName, java.lang.Integer flags)
      {
         return WObj.getAttribute(attributeName, flags);
      }

// Generating method code for setAttribute
      public virtual void SetAttribute(string name, string value)
      {
         WObj.setAttribute(name, value);
      }

// Generating method code for getElementsByTagName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByTagName(string tagName)
      {
         var arg = WObj.getElementsByTagName(tagName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for getAttributeNode
      public virtual object GetAttributeNode(string name)
      {
         var arg = WObj.getAttributeNode(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getElementsByTagNameNS
      public virtual object GetElementsByTagNameNS(object namespaceURI, string localName)
      {
         var arg = WObj.getElementsByTagNameNS(namespaceURI, localName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for hasAttribute
      public virtual bool HasAttribute(string name)
      {
         return WObj.hasAttribute(name);
      }

// Generating method code for removeAttribute
      public virtual void RemoveAttribute(string name)
      {
         WObj.removeAttribute(name);
      }

// Generating method code for getAttributeNS
      public virtual string GetAttributeNS(string namespaceURI, string localName)
      {
         return WObj.getAttributeNS(namespaceURI, localName);
      }

// Generating method code for hasAttributeNS
      public virtual bool HasAttributeNS(string namespaceURI, string localName)
      {
         return WObj.hasAttributeNS(namespaceURI, localName);
      }

// Generating method code for setAttributeNS
      public virtual void SetAttributeNS(string namespaceURI, string qualifiedName, string value)
      {
         WObj.setAttributeNS(namespaceURI, qualifiedName, value);
      }

// Generating method code for setAttributeNode
      public virtual NHtmlUnit.Javascript.Host.Dom.Attr SetAttributeNode(NHtmlUnit.Javascript.Host.Dom.Attr newAtt)
      {
         var arg = WObj.setAttributeNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Attr)newAtt.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Attr>(arg);
      }

// Generating method code for querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.Dom.NodeList QuerySelectorAll(string selectors)
      {
         var arg = WObj.querySelectorAll(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeList>(arg);
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Dom.Node QuerySelector(string selectors)
      {
         var arg = WObj.querySelector(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for getAttributeNodeNS
      public virtual object GetAttributeNodeNS(string namespaceURI, string localName)
      {
         var arg = WObj.getAttributeNodeNS(namespaceURI, localName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getElementsByClassName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByClassName(string className)
      {
         var arg = WObj.getElementsByClassName(className);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for insertAdjacentElement
      public virtual object InsertAdjacentElement(string whereArg, object insertedElement)
      {
         var arg = WObj.insertAdjacentElement(whereArg, insertedElement);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for insertAdjacentText
      public virtual void InsertAdjacentText(string whereArg, string text)
      {
         WObj.insertAdjacentText(whereArg, text);
      }

// Generating method code for insertAdjacentHTML
      public virtual void InsertAdjacentHTML(string position, string text)
      {
         WObj.insertAdjacentHTML(position, text);
      }

// Generating method code for removeAttributeNode
      public virtual void RemoveAttributeNode(NHtmlUnit.Javascript.Host.Dom.Attr attribute)
      {
         WObj.removeAttributeNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Attr)attribute.WrappedObject);
      }

// Generating method code for scrollIntoView
      public virtual void ScrollIntoView()
      {
         WObj.scrollIntoView();
      }

// Generating method code for scrollIntoViewIfNeeded
      public virtual void ScrollIntoViewIfNeeded()
      {
         WObj.scrollIntoViewIfNeeded();
      }

// Generating method code for remove
      public virtual void Remove()
      {
         WObj.remove();
      }

// Generating method code for releaseCapture
      public virtual bool ReleaseCapture()
      {
         return WObj.releaseCapture();
      }

// Generating method code for getOuterHTML
      public virtual string GetOuterHTML()
      {
         return WObj.getOuterHTML();
      }

// Generating method code for setOuterHTML
      public virtual void SetOuterHTML(object value)
      {
         WObj.setOuterHTML(value);
      }

// Generating method code for getClassName_js
      public virtual object GetClassName_js()
      {
         var arg = WObj.getClassName_js();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setClassName_js
      public virtual void SetClassName_js(string className)
      {
         WObj.setClassName_js(className);
      }

// Generating method code for getInnerHTML
      public virtual string GetInnerHTML()
      {
         return WObj.getInnerHTML();
      }

// Generating method code for setInnerHTML
      public virtual void SetInnerHTML(object value)
      {
         WObj.setInnerHTML(value);
      }

// Generating method code for getOnbeforecopy
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforecopy()
      {
         return WObj.getOnbeforecopy();
      }

// Generating method code for setOnbeforecopy
      public virtual void SetOnbeforecopy(object onbeforecopy)
      {
         WObj.setOnbeforecopy(onbeforecopy);
      }

// Generating method code for getOnbeforecut
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforecut()
      {
         return WObj.getOnbeforecut();
      }

// Generating method code for setOnbeforecut
      public virtual void SetOnbeforecut(object onbeforecut)
      {
         WObj.setOnbeforecut(onbeforecut);
      }

// Generating method code for getOnbeforepaste
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforepaste()
      {
         return WObj.getOnbeforepaste();
      }

// Generating method code for setOnbeforepaste
      public virtual void SetOnbeforepaste(object onbeforepaste)
      {
         WObj.setOnbeforepaste(onbeforepaste);
      }

// Generating method code for getOnsearch
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnsearch()
      {
         return WObj.getOnsearch();
      }

// Generating method code for setOnsearch
      public virtual void SetOnsearch(object onsearch)
      {
         WObj.setOnsearch(onsearch);
      }

// Generating method code for getOnwebkitfullscreenchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkitfullscreenchange()
      {
         return WObj.getOnwebkitfullscreenchange();
      }

// Generating method code for setOnwebkitfullscreenchange
      public virtual void SetOnwebkitfullscreenchange(object onwebkitfullscreenchange)
      {
         WObj.setOnwebkitfullscreenchange(onwebkitfullscreenchange);
      }

// Generating method code for getOnwebkitfullscreenerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkitfullscreenerror()
      {
         return WObj.getOnwebkitfullscreenerror();
      }

// Generating method code for setOnwebkitfullscreenerror
      public virtual void SetOnwebkitfullscreenerror(object onwebkitfullscreenerror)
      {
         WObj.setOnwebkitfullscreenerror(onwebkitfullscreenerror);
      }

// Generating method code for getOnwheel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwheel()
      {
         return WObj.getOnwheel();
      }

// Generating method code for setOnwheel
      public virtual void SetOnwheel(object onwheel)
      {
         WObj.setOnwheel(onwheel);
      }

// Generating method code for getOngotpointercapture
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOngotpointercapture()
      {
         return WObj.getOngotpointercapture();
      }

// Generating method code for setOngotpointercapture
      public virtual void SetOngotpointercapture(object ongotpointercapture)
      {
         WObj.setOngotpointercapture(ongotpointercapture);
      }

// Generating method code for getOnlostpointercapture
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnlostpointercapture()
      {
         return WObj.getOnlostpointercapture();
      }

// Generating method code for setOnlostpointercapture
      public virtual void SetOnlostpointercapture(object onlostpointercapture)
      {
         WObj.setOnlostpointercapture(onlostpointercapture);
      }

// Generating method code for getOnmsgesturechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturechange()
      {
         return WObj.getOnmsgesturechange();
      }

// Generating method code for setOnmsgesturechange
      public virtual void SetOnmsgesturechange(object onmsgesturechange)
      {
         WObj.setOnmsgesturechange(onmsgesturechange);
      }

// Generating method code for getOnmsgesturedoubletap
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturedoubletap()
      {
         return WObj.getOnmsgesturedoubletap();
      }

// Generating method code for setOnmsgesturedoubletap
      public virtual void SetOnmsgesturedoubletap(object onmsgesturedoubletap)
      {
         WObj.setOnmsgesturedoubletap(onmsgesturedoubletap);
      }

// Generating method code for getOnmsgestureend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgestureend()
      {
         return WObj.getOnmsgestureend();
      }

// Generating method code for setOnmsgestureend
      public virtual void SetOnmsgestureend(object onmsgestureend)
      {
         WObj.setOnmsgestureend(onmsgestureend);
      }

// Generating method code for getOnmsgesturehold
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturehold()
      {
         return WObj.getOnmsgesturehold();
      }

// Generating method code for setOnmsgesturehold
      public virtual void SetOnmsgesturehold(object onmsgesturehold)
      {
         WObj.setOnmsgesturehold(onmsgesturehold);
      }

// Generating method code for getOnmsgesturestart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturestart()
      {
         return WObj.getOnmsgesturestart();
      }

// Generating method code for setOnmsgesturestart
      public virtual void SetOnmsgesturestart(object onmsgesturestart)
      {
         WObj.setOnmsgesturestart(onmsgesturestart);
      }

// Generating method code for getOnmsgesturetap
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturetap()
      {
         return WObj.getOnmsgesturetap();
      }

// Generating method code for setOnmsgesturetap
      public virtual void SetOnmsgesturetap(object onmsgesturetap)
      {
         WObj.setOnmsgesturetap(onmsgesturetap);
      }

// Generating method code for getOnmsgotpointercapture
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgotpointercapture()
      {
         return WObj.getOnmsgotpointercapture();
      }

// Generating method code for setOnmsgotpointercapture
      public virtual void SetOnmsgotpointercapture(object onmsgotpointercapture)
      {
         WObj.setOnmsgotpointercapture(onmsgotpointercapture);
      }

// Generating method code for getOnmsinertiastart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsinertiastart()
      {
         return WObj.getOnmsinertiastart();
      }

// Generating method code for setOnmsinertiastart
      public virtual void SetOnmsinertiastart(object onmsinertiastart)
      {
         WObj.setOnmsinertiastart(onmsinertiastart);
      }

// Generating method code for getOnmslostpointercapture
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmslostpointercapture()
      {
         return WObj.getOnmslostpointercapture();
      }

// Generating method code for setOnmslostpointercapture
      public virtual void SetOnmslostpointercapture(object onmslostpointercapture)
      {
         WObj.setOnmslostpointercapture(onmslostpointercapture);
      }

// Generating method code for getOnmspointercancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointercancel()
      {
         return WObj.getOnmspointercancel();
      }

// Generating method code for setOnmspointercancel
      public virtual void SetOnmspointercancel(object onmspointercancel)
      {
         WObj.setOnmspointercancel(onmspointercancel);
      }

// Generating method code for getOnmspointerdown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerdown()
      {
         return WObj.getOnmspointerdown();
      }

// Generating method code for setOnmspointerdown
      public virtual void SetOnmspointerdown(object onmspointerdown)
      {
         WObj.setOnmspointerdown(onmspointerdown);
      }

// Generating method code for getOnmspointerenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerenter()
      {
         return WObj.getOnmspointerenter();
      }

// Generating method code for setOnmspointerenter
      public virtual void SetOnmspointerenter(object onmspointerenter)
      {
         WObj.setOnmspointerenter(onmspointerenter);
      }

// Generating method code for getOnmspointerleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerleave()
      {
         return WObj.getOnmspointerleave();
      }

// Generating method code for setOnmspointerleave
      public virtual void SetOnmspointerleave(object onmspointerleave)
      {
         WObj.setOnmspointerleave(onmspointerleave);
      }

// Generating method code for getOnmspointermove
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointermove()
      {
         return WObj.getOnmspointermove();
      }

// Generating method code for setOnmspointermove
      public virtual void SetOnmspointermove(object onmspointermove)
      {
         WObj.setOnmspointermove(onmspointermove);
      }

// Generating method code for getOnmspointerout
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerout()
      {
         return WObj.getOnmspointerout();
      }

// Generating method code for setOnmspointerout
      public virtual void SetOnmspointerout(object onmspointerout)
      {
         WObj.setOnmspointerout(onmspointerout);
      }

// Generating method code for getOnmspointerover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerover()
      {
         return WObj.getOnmspointerover();
      }

// Generating method code for setOnmspointerover
      public virtual void SetOnmspointerover(object onmspointerover)
      {
         WObj.setOnmspointerover(onmspointerover);
      }

// Generating method code for getOnmspointerup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerup()
      {
         return WObj.getOnmspointerup();
      }

// Generating method code for setOnmspointerup
      public virtual void SetOnmspointerup(object onmspointerup)
      {
         WObj.setOnmspointerup(onmspointerup);
      }

// Generating method code for getOnpointercancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointercancel()
      {
         return WObj.getOnpointercancel();
      }

// Generating method code for setOnpointercancel
      public virtual void SetOnpointercancel(object onpointercancel)
      {
         WObj.setOnpointercancel(onpointercancel);
      }

// Generating method code for getOnpointerdown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerdown()
      {
         return WObj.getOnpointerdown();
      }

// Generating method code for setOnpointerdown
      public virtual void SetOnpointerdown(object onpointerdown)
      {
         WObj.setOnpointerdown(onpointerdown);
      }

// Generating method code for getOnpointerenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerenter()
      {
         return WObj.getOnpointerenter();
      }

// Generating method code for setOnpointerenter
      public virtual void SetOnpointerenter(object onpointerenter)
      {
         WObj.setOnpointerenter(onpointerenter);
      }

// Generating method code for getOnpointerleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerleave()
      {
         return WObj.getOnpointerleave();
      }

// Generating method code for setOnpointerleave
      public virtual void SetOnpointerleave(object onpointerleave)
      {
         WObj.setOnpointerleave(onpointerleave);
      }

// Generating method code for getOnpointermove
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointermove()
      {
         return WObj.getOnpointermove();
      }

// Generating method code for setOnpointermove
      public virtual void SetOnpointermove(object onpointermove)
      {
         WObj.setOnpointermove(onpointermove);
      }

// Generating method code for getOnpointerout
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerout()
      {
         return WObj.getOnpointerout();
      }

// Generating method code for setOnpointerout
      public virtual void SetOnpointerout(object onpointerout)
      {
         WObj.setOnpointerout(onpointerout);
      }

// Generating method code for getOnpointerover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerover()
      {
         return WObj.getOnpointerover();
      }

// Generating method code for setOnpointerover
      public virtual void SetOnpointerover(object onpointerover)
      {
         WObj.setOnpointerover(onpointerover);
      }

// Generating method code for getOnpointerup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerup()
      {
         return WObj.getOnpointerup();
      }

// Generating method code for setOnpointerup
      public virtual void SetOnpointerup(object onpointerup)
      {
         WObj.setOnpointerup(onpointerup);
      }

   }


}
