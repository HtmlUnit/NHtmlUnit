// Generated class v2.14.1.0, don't modify

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


      public System.Int32 DocumentMode
      {
         get
         {
            return WObj.getDocumentMode();
         }
      }

      public System.String CompatMode
      {
         get
         {
            return WObj.getCompatMode();
         }
      }

      public NHtmlUnit.Html.HtmlPage HtmlPage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlPage>(
               WObj.getHtmlPage());
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


      public NHtmlUnit.Html.HtmlPage HtmlPageOrNull
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlPage>(
               WObj.getHtmlPageOrNull());
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

      public IList<NHtmlUnit.W3C.Dom.INode> All
      {
         get
         {
            return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(
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

      public NHtmlUnit.Javascript.Host.Selection Selection_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Selection>(
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


      public NHtmlUnit.Javascript.Host.Selection Selection
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Selection>(
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
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByName(string elementName)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByName(elementName));
      }

// Generating method code for open
      public virtual object Open(string url, object name, object features, object replace)
      {
         return WObj.open(url, name, features, replace);
      }

// Generating method code for createStyleSheet
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleSheet CreateStyleSheet(string url, object index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(WObj.createStyleSheet(url, index));
      }

// Generating method code for getElementById
      public virtual object GetElementById(string id)
      {
         return WObj.getElementById(id);
      }

// Generating method code for getElementsByClassName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByClassName(string className)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByClassName(className));
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for createEvent
      public virtual NHtmlUnit.Javascript.Host.Event CreateEvent(string eventType)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Event>(WObj.createEvent(eventType));
      }

// Generating method code for createEventObject
      public virtual NHtmlUnit.Javascript.Host.Event CreateEventObject()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Event>(WObj.createEventObject());
      }

// Generating method code for elementFromPoint
      public virtual object ElementFromPoint(int x, int y)
      {
         return WObj.elementFromPoint(x, y);
      }

// Generating method code for createRange
      public virtual NHtmlUnit.Javascript.Host.Range CreateRange()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Range>(WObj.createRange());
      }

// Generating method code for createTreeWalker
      public virtual object CreateTreeWalker(NHtmlUnit.Javascript.Host.Node root, System.Double whatToShow, net.sourceforge.htmlunit.corejs.javascript.Scriptable filter, bool expandEntityReferences)
      {
         return WObj.createTreeWalker((com.gargoylesoftware.htmlunit.javascript.host.Node)root.WrappedObject, whatToShow, filter, expandEntityReferences);
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

// Generating method code for dispatchEvent
      public virtual bool DispatchEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return WObj.dispatchEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject);
      }

// Generating method code for querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.StaticNodeList QuerySelectorAll(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.StaticNodeList>(WObj.querySelectorAll(selectors));
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Node QuerySelector(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.querySelector(selectors));
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

// Generating method code for getActiveElement
      public virtual object GetActiveElement()
      {
         return WObj.getActiveElement();
      }

// Generating method code for setActiveElement
      public virtual void SetActiveElement(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
      {
         WObj.setActiveElement((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject);
      }

// Generating method code for getHead
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement GetHead()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.getHead());
      }

// Generating method code for setHead
      public virtual void SetHead(net.sourceforge.htmlunit.corejs.javascript.ScriptableObject head)
      {
         WObj.setHead(head);
      }

   }


}
