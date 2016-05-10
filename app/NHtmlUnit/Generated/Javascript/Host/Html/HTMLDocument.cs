// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDocument : NHtmlUnit.Javascript.Host.Dom.Document, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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


      public System.Int32 DocumentMode
      {
         get
         {
            return WObj.getDocumentMode();
         }
      }

      public NHtmlUnit.Javascript.Host.Html.HTMLElement ActiveElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getActiveElement());
         }
         set
         {
            WObj.setActiveElement((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)value.WrappedObject);
         }

      }


      public System.String CompatMode
      {
         get
         {
            return WObj.getCompatMode();
         }
      }

      public System.String Domain
      {
         get
         {
            return WObj.getDomain();
         }
         set
         {
            WObj.setDomain(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Html.HTMLElement Body
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getBody());
         }
      }


      public System.Object Forms
      {
         get
         {
            return WObj.getForms();
         }
      }

      public System.Object Links
      {
         get
         {
            return WObj.getLinks();
         }
      }

      public System.String LastModified
      {
         get
         {
            return WObj.getLastModified();
         }
      }

      public System.Object Namespaces
      {
         get
         {
            return WObj.getNamespaces();
         }
      }

      public System.Object Anchors
      {
         get
         {
            return WObj.getAnchors();
         }
      }

      public System.Object Applets
      {
         get
         {
            return WObj.getApplets();
         }
      }

      public System.String BaseURI
      {
         get
         {
            return WObj.getBaseURI();
         }
      }

      public System.String Cookie
      {
         get
         {
            return WObj.getCookie();
         }
         set
         {
            WObj.setCookie(value);
         }

      }

      public System.Object Images
      {
         get
         {
            return WObj.getImages();
         }
      }

      public System.String InputEncoding
      {
         get
         {
            return WObj.getInputEncoding();
         }
      }

      public System.String CharacterSet
      {
         get
         {
            return WObj.getCharacterSet();
         }
      }

      public System.String Charset
      {
         get
         {
            return WObj.getCharset();
         }
      }

      public System.String DefaultCharset
      {
         get
         {
            return WObj.getDefaultCharset();
         }
      }

      public System.String URL
      {
         get
         {
            return WObj.getURL();
         }
      }

      public System.String UniqueID
      {
         get
         {
            return WObj.getUniqueID();
         }
      }

      public NHtmlUnit.Javascript.Host.Html.HTMLCollection All
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(
               WObj.getAll());
         }
      }


      public System.Object ParentWindow
      {
         get
         {
            return WObj.getParentWindow();
         }
      }

      public System.String Title
      {
         get
         {
            return WObj.getTitle();
         }
         set
         {
            WObj.setTitle(value);
         }

      }

      public System.String BgColor
      {
         get
         {
            return WObj.getBgColor();
         }
         set
         {
            WObj.setBgColor(value);
         }

      }

      public System.String AlinkColor
      {
         get
         {
            return WObj.getAlinkColor();
         }
         set
         {
            WObj.setAlinkColor(value);
         }

      }

      public System.String LinkColor
      {
         get
         {
            return WObj.getLinkColor();
         }
         set
         {
            WObj.setLinkColor(value);
         }

      }

      public System.String VlinkColor
      {
         get
         {
            return WObj.getVlinkColor();
         }
         set
         {
            WObj.setVlinkColor(value);
         }

      }

      public System.String FgColor
      {
         get
         {
            return WObj.getFgColor();
         }
         set
         {
            WObj.setFgColor(value);
         }

      }

      public System.String ReadyState
      {
         get
         {
            return WObj.getReadyState();
         }
      }

      public System.Object Scripts
      {
         get
         {
            return WObj.getScripts();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.Selection Selection_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Selection>(
               WObj.getSelection_js());
         }
      }


      public System.Object Frames
      {
         get
         {
            return WObj.getFrames();
         }
      }

      public NHtmlUnit.Javascript.Host.Css.StyleSheetList StyleSheets
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.StyleSheetList>(
               WObj.getStyleSheets());
         }
      }


      public NHtmlUnit.Javascript.Host.Dom.Selection Selection
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Selection>(
               WObj.getSelection());
         }
      }

// Generating method code for forceDocumentMode
      public virtual void ForceDocumentMode(int documentMode)
      {
         WObj.forceDocumentMode(documentMode);
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

// Generating method code for getElementsByName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByName(string elementName)
      {
         var arg = WObj.getElementsByName(elementName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for open
      public virtual object Open(string url, object name, object features, object replace)
      {
         var arg = WObj.open(url, name, features, replace);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createStyleSheet
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleSheet CreateStyleSheet(string url, object index)
      {
         var arg = WObj.createStyleSheet(url, index);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(arg);
      }

// Generating method code for getElementById
      public virtual object GetElementById(string id)
      {
         var arg = WObj.getElementById(id);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getElementsByClassName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByClassName(string className)
      {
         var arg = WObj.getElementsByClassName(className);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         var arg = WObj.getWithFallback(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createEvent
      public virtual NHtmlUnit.Javascript.Host.Events.Event CreateEvent(string eventType)
      {
         var arg = WObj.createEvent(eventType);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Events.Event>(arg);
      }

// Generating method code for createEventObject
      public virtual NHtmlUnit.Javascript.Host.Events.Event CreateEventObject()
      {
         var arg = WObj.createEventObject();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Events.Event>(arg);
      }

// Generating method code for elementFromPoint
      public virtual object ElementFromPoint(int x, int y)
      {
         var arg = WObj.elementFromPoint(x, y);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createRange
      public virtual NHtmlUnit.Javascript.Host.Dom.Range CreateRange()
      {
         var arg = WObj.createRange();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Range>(arg);
      }

// Generating method code for createTreeWalker
      public virtual object CreateTreeWalker(NHtmlUnit.Javascript.Host.Dom.Node root, System.Double whatToShow, net.sourceforge.htmlunit.corejs.javascript.Scriptable filter, bool expandEntityReferences)
      {
         var arg = WObj.createTreeWalker((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, filter, expandEntityReferences);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for queryCommandSupported
      public virtual bool QueryCommandSupported(string cmd)
      {
         return WObj.queryCommandSupported(cmd);
      }

// Generating method code for queryCommandEnabled
      public virtual bool QueryCommandEnabled(string cmd)
      {
         return WObj.queryCommandEnabled(cmd);
      }

// Generating method code for execCommand
      public virtual bool ExecCommand(string cmd, bool userInterface, object value)
      {
         return WObj.execCommand(cmd, userInterface, value);
      }

// Generating method code for hasFocus
      public virtual bool HasFocus()
      {
         return WObj.hasFocus();
      }

// Generating method code for querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.Dom.StaticNodeList QuerySelectorAll(string selectors)
      {
         var arg = WObj.querySelectorAll(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.StaticNodeList>(arg);
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Dom.Node QuerySelector(string selectors)
      {
         var arg = WObj.querySelector(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

// Generating method code for releaseCapture
      public virtual bool ReleaseCapture()
      {
         return WObj.releaseCapture();
      }

// Generating method code for createNodeIterator
      public virtual NHtmlUnit.Javascript.Host.Dom.NodeIterator CreateNodeIterator(NHtmlUnit.Javascript.Host.Dom.Node root, System.Double whatToShow, net.sourceforge.htmlunit.corejs.javascript.Scriptable filter)
      {
         var arg = WObj.createNodeIterator((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, filter);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeIterator>(arg);
      }

// Generating method code for getHead
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement GetHead()
      {
         var arg = WObj.getHead();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(arg);
      }

// Generating method code for setHead
      public virtual void SetHead(net.sourceforge.htmlunit.corejs.javascript.ScriptableObject head)
      {
         WObj.setHead(head);
      }

   }


}
