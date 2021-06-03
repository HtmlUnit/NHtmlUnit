// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlPage : NHtmlUnit.SgmlPage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.IPage, NHtmlUnit.W3C.Dom.IDocument, NHtmlUnit.W3C.Dom.Traversal.IDocumentTraversal
   {
      static HtmlPage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlPage o) =>
            new HtmlPage(o));
      }

      public HtmlPage(com.gargoylesoftware.htmlunit.html.HtmlPage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlPage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlPage)WrappedObject; }
      }

      public HtmlPage(NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow webWindow)
         : this(new com.gargoylesoftware.htmlunit.html.HtmlPage((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject)) {}


      public NHtmlUnit.Html.DomElement FocusedElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getFocusedElement());
         }
      }


      public NHtmlUnit.Html.HtmlElement Body
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getBody());
         }
      }


      public IList<NHtmlUnit.Html.FrameWindow> Frames
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.FrameWindow>(
               WObj.getFrames());
         }
       }

      public IList<NHtmlUnit.Html.HtmlAnchor> Anchors
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlAnchor>(
               WObj.getAnchors());
         }
       }

      public java.net.URL BaseURL
      {
         get
         {
            return WObj.getBaseURL();
         }
      }

      public IList<NHtmlUnit.Html.HtmlElement> TabbableElements
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getTabbableElements());
         }
       }

      public NHtmlUnit.Html.Parser.IHTMLParserDOMBuilder DOMBuilder
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.Parser.IHTMLParserDOMBuilder>(
               WObj.getDOMBuilder());
         }
         set
         {
            WObj.setDOMBuilder((com.gargoylesoftware.htmlunit.html.parser.HTMLParserDOMBuilder)value.WrappedObject);
         }

      }


      public NHtmlUnit.Html.HtmlElement Head
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getHead());
         }
      }


      public IList<NHtmlUnit.Html.HtmlForm> Forms
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlForm>(
               WObj.getForms());
         }
       }

      public IList<System.String> TabbableElementIds
      {
         get
         {
            return new ShallowListWrapper<System.String>(
               WObj.getTabbableElementIds());
         }
       }

      public System.String TitleText
      {
         get
         {
            return WObj.getTitleText();
         }
         set
         {
            WObj.setTitleText(value);
         }

      }

      public java.util.Map Namespaces
      {
         get
         {
            return WObj.getNamespaces();
         }
      }

      public IList<NHtmlUnit.W3C.Dom.Ranges.IRange> SelectionRanges
      {
         get
         {
            return new ListWrapper<NHtmlUnit.W3C.Dom.Ranges.IRange>(
               WObj.getSelectionRanges());
         }
       }
// Generating method code for getFullyQualifiedUrl
      public virtual java.net.URL GetFullyQualifiedUrl(string relativeUrl)
      {
         return WObj.getFullyQualifiedUrl(relativeUrl);
      }

// Generating method code for setFocusedElement
      public virtual bool SetFocusedElement(NHtmlUnit.Html.DomElement newElement)
      {
         return WObj.setFocusedElement((com.gargoylesoftware.htmlunit.html.DomElement)newElement.WrappedObject);
      }

// Generating method code for isParsingHtmlSnippet
      public virtual bool IsParsingHtmlSnippet()
      {
         return WObj.isParsingHtmlSnippet();
      }

// Generating method code for getResolvedTarget
      public virtual string GetResolvedTarget(string elementTarget)
      {
         return WObj.getResolvedTarget(elementTarget);
      }

// Generating method code for executeJavaScript
      public virtual NHtmlUnit.ScriptResult ExecuteJavaScript(string sourceCode, string sourceName, int startLine)
      {
         var arg = WObj.executeJavaScript(sourceCode, sourceName, startLine);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(arg);
      }

// Generating method code for getHtmlElementById
      public virtual NHtmlUnit.Html.HtmlElement GetHtmlElementById(string elementId)
      {
         var arg = WObj.getHtmlElementById(elementId);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for deregisterFramesIfNeeded
      public virtual void DeregisterFramesIfNeeded()
      {
         WObj.deregisterFramesIfNeeded();
      }

// Generating method code for getHtmlElementsByAccessKey
      public virtual IList<NHtmlUnit.Html.HtmlElement> GetHtmlElementsByAccessKey(System.Char accessKey)
      {

return new ListWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getHtmlElementsByAccessKey(accessKey));
      }

// Generating method code for getHtmlElementByAccessKey
      public virtual NHtmlUnit.Html.HtmlElement GetHtmlElementByAccessKey(System.Char accessKey)
      {
         var arg = WObj.getHtmlElementByAccessKey(accessKey);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for setFocusedElement
      public virtual bool SetFocusedElement(NHtmlUnit.Html.DomElement newElement, bool windowActivated)
      {
         return WObj.setFocusedElement((com.gargoylesoftware.htmlunit.html.DomElement)newElement.WrappedObject, windowActivated);
      }

// Generating method code for getAnchorByName
      public virtual NHtmlUnit.Html.HtmlAnchor GetAnchorByName(string name)
      {
         var arg = WObj.getAnchorByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlAnchor>(arg);
      }

// Generating method code for getAnchorByHref
      public virtual NHtmlUnit.Html.HtmlAnchor GetAnchorByHref(string href)
      {
         var arg = WObj.getAnchorByHref(href);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlAnchor>(arg);
      }

// Generating method code for getAnchorByText
      public virtual NHtmlUnit.Html.HtmlAnchor GetAnchorByText(string text)
      {
         var arg = WObj.getAnchorByText(text);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlAnchor>(arg);
      }

// Generating method code for getFormByName
      public virtual NHtmlUnit.Html.HtmlForm GetFormByName(string name)
      {
         var arg = WObj.getFormByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlForm>(arg);
      }

// Generating method code for executeJavaScript
      public virtual NHtmlUnit.ScriptResult ExecuteJavaScript(string sourceCode)
      {
         var arg = WObj.executeJavaScript(sourceCode);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(arg);
      }

// Generating method code for isOnbeforeunloadAccepted
      public virtual bool IsOnbeforeunloadAccepted()
      {
         return WObj.isOnbeforeunloadAccepted();
      }

// Generating method code for getFrameByName
      public virtual NHtmlUnit.Html.FrameWindow GetFrameByName(string name)
      {
         var arg = WObj.getFrameByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.FrameWindow>(arg);
      }

// Generating method code for pressAccessKey
      public virtual NHtmlUnit.Html.DomElement PressAccessKey(System.Char accessKey)
      {
         var arg = WObj.pressAccessKey(accessKey);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(arg);
      }

// Generating method code for tabToNextElement
      public virtual NHtmlUnit.Html.HtmlElement TabToNextElement()
      {
         var arg = WObj.tabToNextElement();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for tabToPreviousElement
      public virtual NHtmlUnit.Html.HtmlElement TabToPreviousElement()
      {
         var arg = WObj.tabToPreviousElement();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for getElementsById
      public virtual IList<NHtmlUnit.Html.DomElement> GetElementsById(string elementId)
      {

return new ListWrapper<NHtmlUnit.Html.DomElement>(WObj.getElementsById(elementId));
      }

// Generating method code for getElementByName
      public virtual NHtmlUnit.Html.DomElement GetElementByName(string name)
      {
         var arg = WObj.getElementByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(arg);
      }

// Generating method code for getElementsByName
      public virtual IList<NHtmlUnit.Html.DomElement> GetElementsByName(string name)
      {

return new ListWrapper<NHtmlUnit.Html.DomElement>(WObj.getElementsByName(name));
      }

// Generating method code for getElementsByIdAndOrName
      public virtual IList<NHtmlUnit.Html.DomElement> GetElementsByIdAndOrName(string idAndOrName)
      {

return new ListWrapper<NHtmlUnit.Html.DomElement>(WObj.getElementsByIdAndOrName(idAndOrName));
      }

// Generating method code for addHtmlAttributeChangeListener
      public virtual void AddHtmlAttributeChangeListener(NHtmlUnit.Html.IHtmlAttributeChangeListener listener)
      {
         WObj.addHtmlAttributeChangeListener((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeListener)listener.WrappedObject);
      }

// Generating method code for removeHtmlAttributeChangeListener
      public virtual void RemoveHtmlAttributeChangeListener(NHtmlUnit.Html.IHtmlAttributeChangeListener listener)
      {
         WObj.removeHtmlAttributeChangeListener((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeListener)listener.WrappedObject);
      }

// Generating method code for isBeingParsed
      public virtual bool IsBeingParsed()
      {
         return WObj.isBeingParsed();
      }

// Generating method code for registerParsingStart
      public virtual void RegisterParsingStart()
      {
         WObj.registerParsingStart();
      }

// Generating method code for registerParsingEnd
      public virtual void RegisterParsingEnd()
      {
         WObj.registerParsingEnd();
      }

// Generating method code for registerSnippetParsingStart
      public virtual void RegisterSnippetParsingStart()
      {
         WObj.registerSnippetParsingStart();
      }

// Generating method code for registerSnippetParsingEnd
      public virtual void RegisterSnippetParsingEnd()
      {
         WObj.registerSnippetParsingEnd();
      }

// Generating method code for isParsingInlineHtmlSnippet
      public virtual bool IsParsingInlineHtmlSnippet()
      {
         return WObj.isParsingInlineHtmlSnippet();
      }

// Generating method code for registerInlineSnippetParsingStart
      public virtual void RegisterInlineSnippetParsingStart()
      {
         WObj.registerInlineSnippetParsingStart();
      }

// Generating method code for registerInlineSnippetParsingEnd
      public virtual void RegisterInlineSnippetParsingEnd()
      {
         WObj.registerInlineSnippetParsingEnd();
      }

// Generating method code for refresh
      public virtual NHtmlUnit.IPage Refresh()
      {
         var arg = WObj.refresh();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for writeInParsedStream
      public virtual void WriteInParsedStream(string stringArg)
      {
         WObj.writeInParsedStream(stringArg);
      }

// Generating method code for save
      public virtual void Save(java.io.File file)
      {
         WObj.save(file);
      }

// Generating method code for isQuirksMode
      public virtual bool IsQuirksMode()
      {
         return WObj.isQuirksMode();
      }

// Generating method code for addAutoCloseable
      public virtual void AddAutoCloseable(System.IDisposable autoCloseable)
      {
         WObj.addAutoCloseable(autoCloseable);
      }

// Generating method code for getElementFromPoint
      public virtual NHtmlUnit.Html.HtmlElement GetElementFromPoint(int x, int y)
      {
         var arg = WObj.getElementFromPoint(x, y);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for executeJavaScriptFunction
      public virtual NHtmlUnit.ScriptResult ExecuteJavaScriptFunction(object function, object thisObject, System.Object[] args, NHtmlUnit.Html.DomNode htmlElementScope)
      {
         var arg = WObj.executeJavaScriptFunction(function, thisObject, args, (com.gargoylesoftware.htmlunit.html.DomNode)htmlElementScope.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(arg);
      }

   }


}
