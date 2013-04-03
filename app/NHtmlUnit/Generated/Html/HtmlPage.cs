// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlPage : NHtmlUnit.SgmlPage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IDocument, NHtmlUnit.IPage
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

      public HtmlPage(java.net.URL originatingUrl, NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow webWindow)
         : this(new com.gargoylesoftware.htmlunit.html.HtmlPage(originatingUrl, (com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject)) {}


      public IList<NHtmlUnit.W3C.Dom.Ranges.IRange> SelectionRanges
      {
         get
         {
            return new ListWrapper<NHtmlUnit.W3C.Dom.Ranges.IRange>(
               WObj.getSelectionRanges());
         }
       }

      public java.util.Map Namespaces
      {
         get
         {
            return WObj.getNamespaces();
         }
      }

      public NHtmlUnit.Html.HtmlElement FocusedElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getFocusedElement());
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

      public IList<NHtmlUnit.Html.HtmlAnchor> Anchors
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlAnchor>(
               WObj.getAnchors());
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

      public IList<NHtmlUnit.Html.HtmlElement> TabbableElements
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getTabbableElements());
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

// Generating method code for isOnbeforeunloadAccepted
      public virtual bool IsOnbeforeunloadAccepted()
      {
         return WObj.isOnbeforeunloadAccepted();
      }

// Generating method code for setFocusedElement
      public virtual bool SetFocusedElement(NHtmlUnit.Html.HtmlElement newElement, bool windowActivated)
      {
         return WObj.setFocusedElement((com.gargoylesoftware.htmlunit.html.HtmlElement)newElement.WrappedObject, windowActivated);
      }

// Generating method code for executeJavaScriptIfPossible
      public virtual NHtmlUnit.ScriptResult ExecuteJavaScriptIfPossible(string sourceCode, string sourceName, int startLine)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeJavaScriptIfPossible(sourceCode, sourceName, startLine));
      }

// Generating method code for getHtmlElementById
      public virtual NHtmlUnit.Html.HtmlElement GetHtmlElementById(string id)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getHtmlElementById(id));
      }

// Generating method code for getFormByName
      public virtual NHtmlUnit.Html.HtmlForm GetFormByName(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlForm>(WObj.getFormByName(name));
      }

// Generating method code for setFocusedElement
      public virtual bool SetFocusedElement(NHtmlUnit.Html.HtmlElement newElement)
      {
         return WObj.setFocusedElement((com.gargoylesoftware.htmlunit.html.HtmlElement)newElement.WrappedObject);
      }

// Generating method code for getFullyQualifiedUrl
      public virtual java.net.URL GetFullyQualifiedUrl(string relativeUrl)
      {
         return WObj.getFullyQualifiedUrl(relativeUrl);
      }

// Generating method code for getResolvedTarget
      public virtual string GetResolvedTarget(string elementTarget)
      {
         return WObj.getResolvedTarget(elementTarget);
      }

// Generating method code for deregisterFramesIfNeeded
      public virtual void DeregisterFramesIfNeeded()
      {
         WObj.deregisterFramesIfNeeded();
      }

// Generating method code for getElementById
      public virtual NHtmlUnit.Html.DomElement GetElementById(string id, bool caseSensitive)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(WObj.getElementById(id, caseSensitive));
      }

// Generating method code for getHtmlElementByAccessKey
      public virtual NHtmlUnit.Html.HtmlElement GetHtmlElementByAccessKey(System.Char accessKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getHtmlElementByAccessKey(accessKey));
      }

// Generating method code for getHtmlElementsByAccessKey
      public virtual IList<NHtmlUnit.Html.HtmlElement> GetHtmlElementsByAccessKey(System.Char accessKey)
      {

         return new ListWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getHtmlElementsByAccessKey(accessKey));
      }

// Generating method code for getAnchorByName
      public virtual NHtmlUnit.Html.HtmlAnchor GetAnchorByName(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlAnchor>(WObj.getAnchorByName(name));
      }

// Generating method code for getAnchorByHref
      public virtual NHtmlUnit.Html.HtmlAnchor GetAnchorByHref(string href)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlAnchor>(WObj.getAnchorByHref(href));
      }

// Generating method code for getAnchorByText
      public virtual NHtmlUnit.Html.HtmlAnchor GetAnchorByText(string text)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlAnchor>(WObj.getAnchorByText(text));
      }

// Generating method code for executeJavaScript
      public virtual NHtmlUnit.ScriptResult ExecuteJavaScript(string sourceCode)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeJavaScript(sourceCode));
      }

// Generating method code for executeJavaScriptFunctionIfPossible
      public virtual NHtmlUnit.ScriptResult ExecuteJavaScriptFunctionIfPossible(net.sourceforge.htmlunit.corejs.javascript.Function function, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObject, System.Object[] args, NHtmlUnit.Html.DomNode htmlElementScope)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeJavaScriptFunctionIfPossible(function, thisObject, args, (com.gargoylesoftware.htmlunit.html.DomNode)htmlElementScope.WrappedObject));
      }

// Generating method code for getFrameByName
      public virtual NHtmlUnit.Html.FrameWindow GetFrameByName(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.FrameWindow>(WObj.getFrameByName(name));
      }

// Generating method code for pressAccessKey
      public virtual NHtmlUnit.Html.HtmlElement PressAccessKey(System.Char accessKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.pressAccessKey(accessKey));
      }

// Generating method code for tabToNextElement
      public virtual NHtmlUnit.Html.HtmlElement TabToNextElement()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.tabToNextElement());
      }

// Generating method code for tabToPreviousElement
      public virtual NHtmlUnit.Html.HtmlElement TabToPreviousElement()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.tabToPreviousElement());
      }

// Generating method code for getHtmlElementById
      public virtual NHtmlUnit.Html.HtmlElement GetHtmlElementById(string id, bool caseSensitive)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getHtmlElementById(id, caseSensitive));
      }

// Generating method code for getElementByName
      public virtual NHtmlUnit.Html.DomElement GetElementByName(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(WObj.getElementByName(name));
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

// Generating method code for refresh
      public virtual NHtmlUnit.IPage Refresh()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.refresh());
      }

   }


}
