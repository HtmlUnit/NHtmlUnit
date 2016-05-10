// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Window : NHtmlUnit.Javascript.Host.Events.EventTarget, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static Window()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Window o) =>
            new Window(o));
      }

      public Window(com.gargoylesoftware.htmlunit.javascript.host.Window wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Window WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Window)WrappedObject; }
      }

      public Window()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Window()) {}


      public NHtmlUnit.IWebWindow WebWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(
               WObj.getWebWindow());
         }
      }


      public System.String Status
      {
         get
         {
            return WObj.getStatus();
         }
         set
         {
            WObj.setStatus(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Dom.Document Document
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Document>(
               WObj.getDocument());
         }
      }


      public NHtmlUnit.Javascript.Host.Events.Event CurrentEvent
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Events.Event>(
               WObj.getCurrentEvent());
         }
         set
         {
            WObj.setCurrentEvent((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)value.WrappedObject);
         }

      }


      public NHtmlUnit.Javascript.Host.Screen Screen
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Screen>(
               WObj.getScreen());
         }
      }


      public NHtmlUnit.Javascript.Host.Html.DocumentProxy Document_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DocumentProxy>(
               WObj.getDocument_js());
         }
      }


      public System.Object Event
      {
         get
         {
            return WObj.getEvent();
         }
      }

      public NHtmlUnit.Javascript.Host.Navigator Navigator
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Navigator>(
               WObj.getNavigator());
         }
      }


      public NHtmlUnit.Javascript.Host.Dom.Selection SelectionImpl
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Selection>(
               WObj.getSelectionImpl());
         }
      }


      public NHtmlUnit.Javascript.Host.WindowProxy Frames_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(
               WObj.getFrames_js());
         }
      }


      public System.Int32 InnerWidth
      {
         get
         {
            return WObj.getInnerWidth();
         }
      }

      public System.Int32 InnerHeight
      {
         get
         {
            return WObj.getInnerHeight();
         }
      }

      public System.Object Onerror
      {
         get
         {
            return WObj.getOnerror();
         }
         set
         {
            WObj.setOnerror(value);
         }

      }

      public NHtmlUnit.Javascript.Host.ApplicationCache ApplicationCache
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ApplicationCache>(
               WObj.getApplicationCache());
         }
      }


      public NHtmlUnit.Javascript.Host.Navigator ClientInformation
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Navigator>(
               WObj.getClientInformation());
         }
      }


      public NHtmlUnit.Javascript.Host.Html.DataTransfer ClipboardData
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DataTransfer>(
               WObj.getClipboardData());
         }
      }


      public NHtmlUnit.Javascript.Host.WindowProxy Window_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(
               WObj.getWindow_js());
         }
      }


      public NHtmlUnit.Javascript.Host.WindowProxy Self
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(
               WObj.getSelf());
         }
      }


      public NHtmlUnit.Javascript.Host.Storage LocalStorage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Storage>(
               WObj.getLocalStorage());
         }
      }


      public NHtmlUnit.Javascript.Host.Storage SessionStorage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Storage>(
               WObj.getSessionStorage());
         }
      }


      public net.sourceforge.htmlunit.corejs.javascript.ScriptableObject Console
      {
         get
         {
            return WObj.getConsole();
         }
         set
         {
            WObj.setConsole(value);
         }

      }

      public NHtmlUnit.Javascript.Host.History History
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.History>(
               WObj.getHistory());
         }
      }


      public NHtmlUnit.Javascript.Host.External External
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.External>(
               WObj.getExternal());
         }
      }


      public System.Object Top
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

      public NHtmlUnit.Javascript.Host.WindowProxy Parent
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(
               WObj.getParent());
         }
      }


      public System.Object Opener
      {
         get
         {
            return WObj.getOpener();
         }
         set
         {
            WObj.setOpener(value);
         }

      }

      public System.Object FrameElement
      {
         get
         {
            return WObj.getFrameElement();
         }
      }

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }

      public System.Boolean Closed
      {
         get
         {
            return WObj.getClosed();
         }
      }

      public System.Object Onload
      {
         get
         {
            return WObj.getOnload();
         }
         set
         {
            WObj.setOnload(value);
         }

      }

      public System.Object Onclick
      {
         get
         {
            return WObj.getOnclick();
         }
         set
         {
            WObj.setOnclick(value);
         }

      }

      public System.Object Ondblclick
      {
         get
         {
            return WObj.getOndblclick();
         }
         set
         {
            WObj.setOndblclick(value);
         }

      }

      public System.Object Onhashchange
      {
         get
         {
            return WObj.getOnhashchange();
         }
         set
         {
            WObj.setOnhashchange(value);
         }

      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
         set
         {
            WObj.setName(value);
         }

      }

      public System.Object Onbeforeunload
      {
         get
         {
            return WObj.getOnbeforeunload();
         }
         set
         {
            WObj.setOnbeforeunload(value);
         }

      }

      public System.Object Onmessage
      {
         get
         {
            return WObj.getOnmessage();
         }
         set
         {
            WObj.setOnmessage(value);
         }

      }

      public System.Int32 OuterWidth
      {
         get
         {
            return WObj.getOuterWidth();
         }
      }

      public System.Int32 OuterHeight
      {
         get
         {
            return WObj.getOuterHeight();
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


      public System.Object Controllers
      {
         get
         {
            return WObj.getControllers();
         }
         set
         {
            WObj.setControllers(value);
         }

      }

      public System.Int32 MozInnerScreenX
      {
         get
         {
            return WObj.getMozInnerScreenX();
         }
      }

      public System.Int32 MozInnerScreenY
      {
         get
         {
            return WObj.getMozInnerScreenY();
         }
      }

      public System.Int32 MozPaintCount
      {
         get
         {
            return WObj.getMozPaintCount();
         }
      }

      public System.Int32 PageXOffset
      {
         get
         {
            return WObj.getPageXOffset();
         }
      }

      public System.Int32 PageYOffset
      {
         get
         {
            return WObj.getPageYOffset();
         }
      }

      public System.Int32 ScrollX
      {
         get
         {
            return WObj.getScrollX();
         }
      }

      public System.Int32 ScrollY
      {
         get
         {
            return WObj.getScrollY();
         }
      }

      public NHtmlUnit.Javascript.Host.Netscape Netscape
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Netscape>(
               WObj.getNetscape());
         }
      }


      public System.Object Onchange
      {
         get
         {
            return WObj.getOnchange();
         }
         set
         {
            WObj.setOnchange(value);
         }

      }

      public System.Object Onsubmit
      {
         get
         {
            return WObj.getOnsubmit();
         }
         set
         {
            WObj.setOnsubmit(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Performance.Performance Performance
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Performance.Performance>(
               WObj.getPerformance());
         }
      }


      public System.Int32 DevicePixelRatio
      {
         get
         {
            return WObj.getDevicePixelRatio();
         }
      }

      public NHtmlUnit.Javascript.Host.Css.StyleMedia StyleMedia
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.StyleMedia>(
               WObj.getStyleMedia());
         }
      }


      public NHtmlUnit.Javascript.Host.Speech.SpeechSynthesis SpeechSynthesis
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Speech.SpeechSynthesis>(
               WObj.getSpeechSynthesis());
         }
      }


      public System.Object OffscreenBuffering
      {
         get
         {
            return WObj.getOffscreenBuffering();
         }
      }

      public NHtmlUnit.Javascript.Host.Crypto.Crypto Crypto
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Crypto.Crypto>(
               WObj.getCrypto());
         }
      }

// Generating method code for getComputedStyle
      public virtual NHtmlUnit.Javascript.Host.Css.CSS2Properties GetComputedStyle(NHtmlUnit.Javascript.Host.Element element, string pseudo)
      {
         var arg = WObj.getComputedStyle((com.gargoylesoftware.htmlunit.javascript.host.Element)element.WrappedObject, pseudo);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSS2Properties>(arg);
      }

// Generating method code for attachEvent
      public virtual bool AttachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         return WObj.attachEvent(type, listener);
      }

// Generating method code for getStorage
      public virtual NHtmlUnit.Javascript.Host.Storage GetStorage(com.gargoylesoftware.htmlunit.StorageHolder.Type storageType)
      {
         var arg = WObj.getStorage(storageType);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Storage>(arg);
      }

// Generating method code for scrollTo
      public virtual void ScrollTo(int x, int y)
      {
         WObj.scrollTo(x, y);
      }

// Generating method code for setTimeout
      public virtual int SetTimeout(object code, int timeout, object language)
      {
         return WObj.setTimeout(code, timeout, language);
      }

// Generating method code for getPrototype
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable GetPrototype(string className)
      {
         return WObj.getPrototype(className);
      }

// Generating method code for setPrototypes
      public virtual void SetPrototypes(java.util.Map map, java.util.Map prototypesPerJSName)
      {
         WObj.setPrototypes(map, prototypesPerJSName);
      }

// Generating method code for alert
      public virtual void Alert(object message)
      {
         WObj.alert(message);
      }

// Generating method code for btoa
      public virtual string Btoa(string stringToEncode)
      {
         return WObj.btoa(stringToEncode);
      }

// Generating method code for atob
      public virtual string Atob(string encodedData)
      {
         return WObj.atob(encodedData);
      }

// Generating method code for confirm
      public virtual bool Confirm(string message)
      {
         return WObj.confirm(message);
      }

// Generating method code for prompt
      public virtual string Prompt(string message)
      {
         return WObj.prompt(message);
      }

// Generating method code for open
      public virtual NHtmlUnit.Javascript.Host.WindowProxy Open(object url, object name, object features, object replace)
      {
         var arg = WObj.open(url, name, features, replace);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(arg);
      }

// Generating method code for createPopup
      public virtual NHtmlUnit.Javascript.Host.Popup CreatePopup()
      {
         var arg = WObj.createPopup();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Popup>(arg);
      }

// Generating method code for clearTimeout
      public virtual void ClearTimeout(int timeoutId)
      {
         WObj.clearTimeout(timeoutId);
      }

// Generating method code for dump
      public virtual void Dump(string message)
      {
         WObj.dump(message);
      }

// Generating method code for requestAnimationFrame
      public virtual int RequestAnimationFrame(object callback)
      {
         return WObj.requestAnimationFrame(callback);
      }

// Generating method code for cancelAnimationFrame
      public virtual void CancelAnimationFrame(object requestId)
      {
         WObj.cancelAnimationFrame(requestId);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.IWebWindow webWindow)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.IPage enclosedPage)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.Page)enclosedPage.WrappedObject);
      }

// Generating method code for initialize
      public virtual void Initialize()
      {
         WObj.initialize();
      }

// Generating method code for focus
      public virtual void Focus()
      {
         WObj.focus();
      }

// Generating method code for blur
      public virtual void Blur()
      {
         WObj.blur();
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

// Generating method code for moveTo
      public virtual void MoveTo(int x, int y)
      {
         WObj.moveTo(x, y);
      }

// Generating method code for moveBy
      public virtual void MoveBy(int x, int y)
      {
         WObj.moveBy(x, y);
      }

// Generating method code for navigate
      public virtual void Navigate(string url)
      {
         WObj.navigate(url);
      }

// Generating method code for resizeBy
      public virtual void ResizeBy(int width, int height)
      {
         WObj.resizeBy(width, height);
      }

// Generating method code for resizeTo
      public virtual void ResizeTo(int width, int height)
      {
         WObj.resizeTo(width, height);
      }

// Generating method code for scroll
      public virtual void Scroll(int x, int y)
      {
         WObj.scroll(x, y);
      }

// Generating method code for scrollBy
      public virtual void ScrollBy(int x, int y)
      {
         WObj.scrollBy(x, y);
      }

// Generating method code for scrollByLines
      public virtual void ScrollByLines(int lines)
      {
         WObj.scrollByLines(lines);
      }

// Generating method code for scrollByPages
      public virtual void ScrollByPages(int pages)
      {
         WObj.scrollByPages(pages);
      }

// Generating method code for detachEvent
      public virtual void DetachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         WObj.detachEvent(type, listener);
      }

// Generating method code for triggerOnError
      public virtual void TriggerOnError(NHtmlUnit.ScriptException e)
      {
         WObj.triggerOnError((com.gargoylesoftware.htmlunit.ScriptException)e.WrappedObject);
      }

// Generating method code for call
      public virtual object Call(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObj, System.Object[] args)
      {
         var arg = WObj.call(cx, scope, thisObj, args);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for construct
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Construct(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, System.Object[] args)
      {
         return WObj.construct(cx, scope, args);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         var arg = WObj.getWithFallback(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for execScript
      public virtual void ExecScript(string script, object language)
      {
         WObj.execScript(script, language);
      }

// Generating method code for setInterval
      public virtual int SetInterval(object code, int timeout, object language)
      {
         return WObj.setInterval(code, timeout, language);
      }

// Generating method code for clearInterval
      public virtual void ClearInterval(int intervalID)
      {
         WObj.clearInterval(intervalID);
      }

// Generating method code for print
      public virtual void Print()
      {
         WObj.print();
      }

// Generating method code for captureEvents
      public virtual void CaptureEvents(string type)
      {
         WObj.captureEvents(type);
      }

// Generating method code for CollectGarbage
      public virtual void CollectGarbage()
      {
         WObj.CollectGarbage();
      }

// Generating method code for showModalDialog
      public virtual object ShowModalDialog(string url, object arguments, string features)
      {
         var arg = WObj.showModalDialog(url, arguments, features);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for showModelessDialog
      public virtual object ShowModelessDialog(string url, object arguments, string features)
      {
         var arg = WObj.showModelessDialog(url, arguments, features);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for ScriptEngine
      public virtual string ScriptEngine()
      {
         return WObj.ScriptEngine();
      }

// Generating method code for ScriptEngineBuildVersion
      public virtual int ScriptEngineBuildVersion()
      {
         return WObj.ScriptEngineBuildVersion();
      }

// Generating method code for ScriptEngineMajorVersion
      public virtual int ScriptEngineMajorVersion()
      {
         return WObj.ScriptEngineMajorVersion();
      }

// Generating method code for ScriptEngineMinorVersion
      public virtual int ScriptEngineMinorVersion()
      {
         return WObj.ScriptEngineMinorVersion();
      }

// Generating method code for stop
      public virtual void Stop()
      {
         WObj.stop();
      }

// Generating method code for postMessage
      public virtual void PostMessage(string message, string targetOrigin, object transfer)
      {
         WObj.postMessage(message, targetOrigin, transfer);
      }

// Generating method code for matchMedia
      public virtual NHtmlUnit.Javascript.Host.Css.MediaQueryList MatchMedia(string mediaQueryString)
      {
         var arg = WObj.matchMedia(mediaQueryString);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.MediaQueryList>(arg);
      }

// Generating method code for getLocation
      public virtual NHtmlUnit.Javascript.Host.Location GetLocation()
      {
         var arg = WObj.getLocation();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Location>(arg);
      }

// Generating method code for setLocation
      public virtual void SetLocation(string newLocation)
      {
         WObj.setLocation(newLocation);
      }

   }


}
