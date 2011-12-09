// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDocument : NHtmlUnit.Javascript.Host.Document, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDocument()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument o) =>
            new HTMLDocument(o));
      }

      public HTMLDocument(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument)WrappedObject; }
      }

      public HTMLDocument()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument()) {}


      public NHtmlUnit.Html.HtmlPage HtmlPage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlPage>(
               WObj.getHtmlPage());
         }
      }


      public NHtmlUnit.Html.HtmlPage HtmlPageOrNull
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlPage>(
               WObj.getHtmlPageOrNull());
         }
      }

// Generating method code for jsxGet_activeElement
      public virtual object JsxGet_activeElement()
      {
         return WObj.jsxGet_activeElement();
      }

// Generating method code for jsxFunction_close
      public virtual void JsxFunction_close()
      {
         WObj.jsxFunction_close();
      }

// Generating method code for jsxFunction_getElementsByName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxFunction_getElementsByName(string elementName)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxFunction_getElementsByName(elementName));
      }

// Generating method code for jsxGet_domain
      public virtual string JsxGet_domain()
      {
         return WObj.jsxGet_domain();
      }

// Generating method code for jsxGet_body
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement JsxGet_body()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.jsxGet_body());
      }

// Generating method code for jsxGet_forms
      public virtual object JsxGet_forms()
      {
         return WObj.jsxGet_forms();
      }

// Generating method code for jsxGet_links
      public virtual object JsxGet_links()
      {
         return WObj.jsxGet_links();
      }

// Generating method code for jsxGet_lastModified
      public virtual string JsxGet_lastModified()
      {
         return WObj.jsxGet_lastModified();
      }

// Generating method code for jsxGet_namespaces
      public virtual object JsxGet_namespaces()
      {
         return WObj.jsxGet_namespaces();
      }

// Generating method code for jsxGet_anchors
      public virtual object JsxGet_anchors()
      {
         return WObj.jsxGet_anchors();
      }

// Generating method code for jsxGet_applets
      public virtual object JsxGet_applets()
      {
         return WObj.jsxGet_applets();
      }

// Generating method code for jsxGet_cookie
      public virtual string JsxGet_cookie()
      {
         return WObj.jsxGet_cookie();
      }

// Generating method code for jsxGet_compatMode
      public virtual string JsxGet_compatMode()
      {
         return WObj.jsxGet_compatMode();
      }

// Generating method code for jsxSet_cookie
      public virtual void JsxSet_cookie(string newCookie)
      {
         WObj.jsxSet_cookie(newCookie);
      }

// Generating method code for jsxGet_images
      public virtual object JsxGet_images()
      {
         return WObj.jsxGet_images();
      }

// Generating method code for jsxGet_URL
      public virtual string JsxGet_URL()
      {
         return WObj.jsxGet_URL();
      }

// Generating method code for jsxGet_uniqueID
      public virtual string JsxGet_uniqueID()
      {
         return WObj.jsxGet_uniqueID();
      }

// Generating method code for jsxGet_all
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxGet_all()
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxGet_all());
      }

// Generating method code for jsxFunction_open
      public virtual object JsxFunction_open(string url, object name, object features, object replace)
      {
         return WObj.jsxFunction_open(url, name, features, replace);
      }

// Generating method code for jsxGet_parentWindow
      public virtual object JsxGet_parentWindow()
      {
         return WObj.jsxGet_parentWindow();
      }

// Generating method code for jsxFunction_createStyleSheet
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleSheet JsxFunction_createStyleSheet(string url, int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(WObj.jsxFunction_createStyleSheet(url, index));
      }

// Generating method code for jsxFunction_getElementById
      public virtual object JsxFunction_getElementById(string id)
      {
         return WObj.jsxFunction_getElementById(id);
      }

// Generating method code for jsxFunction_getElementsByClassName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxFunction_getElementsByClassName(string className)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxFunction_getElementsByClassName(className));
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for jsxGet_title
      public virtual string JsxGet_title()
      {
         return WObj.jsxGet_title();
      }

// Generating method code for jsxSet_title
      public virtual void JsxSet_title(string title)
      {
         WObj.jsxSet_title(title);
      }

// Generating method code for jsxGet_bgColor
      public virtual string JsxGet_bgColor()
      {
         return WObj.jsxGet_bgColor();
      }

// Generating method code for jsxSet_bgColor
      public virtual void JsxSet_bgColor(string bgColor)
      {
         WObj.jsxSet_bgColor(bgColor);
      }

// Generating method code for jsxGet_readyState
      public virtual string JsxGet_readyState()
      {
         return WObj.jsxGet_readyState();
      }

// Generating method code for jsxSet_domain
      public virtual void JsxSet_domain(string newDomain)
      {
         WObj.jsxSet_domain(newDomain);
      }

// Generating method code for jsxGet_scripts
      public virtual object JsxGet_scripts()
      {
         return WObj.jsxGet_scripts();
      }

// Generating method code for jsxGet_selection
      public virtual NHtmlUnit.Javascript.Host.Selection JsxGet_selection()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Selection>(WObj.jsxGet_selection());
      }

// Generating method code for jsxGet_frames
      public virtual object JsxGet_frames()
      {
         return WObj.jsxGet_frames();
      }

// Generating method code for jsxGet_styleSheets
      public virtual NHtmlUnit.Javascript.Host.Css.StyleSheetList JsxGet_styleSheets()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.StyleSheetList>(WObj.jsxGet_styleSheets());
      }

// Generating method code for jsxFunction_createEvent
      public virtual NHtmlUnit.Javascript.Host.Event JsxFunction_createEvent(string eventType)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Event>(WObj.jsxFunction_createEvent(eventType));
      }

// Generating method code for jsxFunction_createEventObject
      public virtual NHtmlUnit.Javascript.Host.Event JsxFunction_createEventObject()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Event>(WObj.jsxFunction_createEventObject());
      }

// Generating method code for jsxFunction_elementFromPoint
      public virtual object JsxFunction_elementFromPoint(int x, int y)
      {
         return WObj.jsxFunction_elementFromPoint(x, y);
      }

// Generating method code for jsxFunction_createRange
      public virtual NHtmlUnit.Javascript.Host.Range JsxFunction_createRange()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Range>(WObj.jsxFunction_createRange());
      }

// Generating method code for jsxFunction_createTreeWalker
      public virtual object JsxFunction_createTreeWalker(NHtmlUnit.Javascript.Host.Node root, int whatToShow, net.sourceforge.htmlunit.corejs.javascript.Scriptable filter, bool expandEntityReferences)
      {
         return WObj.jsxFunction_createTreeWalker((com.gargoylesoftware.htmlunit.javascript.host.Node)root.WrappedObject, whatToShow, filter, expandEntityReferences);
      }

// Generating method code for jsxFunction_queryCommandSupported
      public virtual bool JsxFunction_queryCommandSupported(string cmd)
      {
         return WObj.jsxFunction_queryCommandSupported(cmd);
      }

// Generating method code for jsxFunction_queryCommandEnabled
      public virtual bool JsxFunction_queryCommandEnabled(string cmd)
      {
         return WObj.jsxFunction_queryCommandEnabled(cmd);
      }

// Generating method code for jsxFunction_execCommand
      public virtual bool JsxFunction_execCommand(string cmd, bool userInterface, object value)
      {
         return WObj.jsxFunction_execCommand(cmd, userInterface, value);
      }

// Generating method code for jsxFunction_dispatchEvent
      public virtual bool JsxFunction_dispatchEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return WObj.jsxFunction_dispatchEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject);
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

// Generating method code for jsxFunction_clear
      public virtual void JsxFunction_clear()
      {
         WObj.jsxFunction_clear();
      }

   }


}
