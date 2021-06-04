// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Window : NHtmlUnit.Javascript.Host.Events.EventTarget, NHtmlUnit.Javascript.Host.IWindowOrWorkerGlobalScope
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


      public System.Object DoNotTrack
      {
         get
         {
            return WObj.getDoNotTrack();
         }
      }

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

      public NHtmlUnit.Javascript.Host.Screen Screen
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Screen>(
               WObj.getScreen());
         }
      }


      public System.Object Event
      {
         get
         {
            return WObj.getEvent();
         }
      }

      public NHtmlUnit.Javascript.Host.Window Frames_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Window>(
               WObj.getFrames_js());
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


      public NHtmlUnit.Javascript.Host.Html.DocumentProxy Document_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DocumentProxy>(
               WObj.getDocument_js());
         }
      }


      public System.Int32 InnerWidth
      {
         get
         {
            return WObj.getInnerWidth();
         }
         set
         {
            WObj.setInnerWidth(value);
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


      public NHtmlUnit.Javascript.Host.Html.DataTransfer ClipboardData
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DataTransfer>(
               WObj.getClipboardData());
         }
      }


      public NHtmlUnit.Javascript.Host.Window Window_js
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Window>(
               WObj.getWindow_js());
         }
      }


      public NHtmlUnit.Javascript.Host.Window Self
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Window>(
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

      public net.sourceforge.htmlunit.corejs.javascript.ScriptableObject Parent
      {
         get
         {
            return WObj.getParent();
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

      public System.Object Onblur
      {
         get
         {
            return WObj.getOnblur();
         }
         set
         {
            WObj.setOnblur(value);
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
         set
         {
            WObj.setOuterWidth(value);
         }

      }

      public System.Int32 OuterHeight
      {
         get
         {
            return WObj.getOuterHeight();
         }
         set
         {
            WObj.setOuterHeight(value);
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

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         var arg = WObj.getWithFallback(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.IPage enclosedPage)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.Page)enclosedPage.WrappedObject);
      }

// Generating method code for getComputedStyle
      public virtual NHtmlUnit.Javascript.Host.Css.CSS2Properties GetComputedStyle(object element, string pseudoElement)
      {
         var arg = WObj.getComputedStyle(element, pseudoElement);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSS2Properties>(arg);
      }

// Generating method code for clearComputedStyles
      public virtual void ClearComputedStyles()
      {
         WObj.clearComputedStyles();
      }

// Generating method code for clearComputedStylesUpToRoot
      public virtual void ClearComputedStylesUpToRoot(NHtmlUnit.Javascript.Host.Element element)
      {
         WObj.clearComputedStylesUpToRoot((com.gargoylesoftware.htmlunit.javascript.host.Element)element.WrappedObject);
      }

// Generating method code for clearComputedStyles
      public virtual void ClearComputedStyles(NHtmlUnit.Javascript.Host.Element element)
      {
         WObj.clearComputedStyles((com.gargoylesoftware.htmlunit.javascript.host.Element)element.WrappedObject);
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
      public virtual string Prompt(string message, object defaultValue)
      {
         return WObj.prompt(message, defaultValue);
      }

// Generating method code for open
      public virtual NHtmlUnit.Javascript.Host.WindowProxy Open(object url, object name, object features, object replace)
      {
         var arg = WObj.open(url, name, features, replace);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(arg);
      }

// Generating method code for clearTimeout
      public virtual void ClearTimeout(int timeoutId)
      {
         WObj.clearTimeout(timeoutId);
      }

// Generating method code for clearInterval
      public virtual void ClearInterval(int intervalID)
      {
         WObj.clearInterval(intervalID);
      }

// Generating method code for dump
      public virtual void Dump(string message)
      {
         WObj.dump(message);
      }

// Generating method code for animateAnimationsFrames
      public virtual int AnimateAnimationsFrames()
      {
         return WObj.animateAnimationsFrames();
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
      public virtual void Initialize(NHtmlUnit.IWebWindow webWindow, NHtmlUnit.IPage pageToEnclose)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject, (com.gargoylesoftware.htmlunit.Page)pageToEnclose.WrappedObject);
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

// Generating method code for close_js
      public virtual void Close_js()
      {
         WObj.close_js();
      }

// Generating method code for isClosed
      public virtual bool IsClosed()
      {
         return WObj.isClosed();
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

// Generating method code for releaseEvents
      public virtual void ReleaseEvents(string type)
      {
         WObj.releaseEvents(type);
      }

// Generating method code for collectGarbage
      public virtual void CollectGarbage()
      {
         WObj.collectGarbage();
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

// Generating method code for scriptEngine
      public virtual string ScriptEngine()
      {
         return WObj.scriptEngine();
      }

// Generating method code for scriptEngineBuildVersion
      public virtual int ScriptEngineBuildVersion()
      {
         return WObj.scriptEngineBuildVersion();
      }

// Generating method code for scriptEngineMajorVersion
      public virtual int ScriptEngineMajorVersion()
      {
         return WObj.scriptEngineMajorVersion();
      }

// Generating method code for scriptEngineMinorVersion
      public virtual int ScriptEngineMinorVersion()
      {
         return WObj.scriptEngineMinorVersion();
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

// Generating method code for find
      public virtual bool Find(string search, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
      {
         return WObj.find(search, caseSensitive, backwards, wrapAround, wholeWord, searchInFrames, showDialog);
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

// Generating method code for getOnmousewheel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmousewheel()
      {
         return WObj.getOnmousewheel();
      }

// Generating method code for setOnmousewheel
      public virtual void SetOnmousewheel(object onmousewheel)
      {
         WObj.setOnmousewheel(onmousewheel);
      }

// Generating method code for getOnseeking
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnseeking()
      {
         return WObj.getOnseeking();
      }

// Generating method code for setOnseeking
      public virtual void SetOnseeking(object onseeking)
      {
         WObj.setOnseeking(onseeking);
      }

// Generating method code for getOncuechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncuechange()
      {
         return WObj.getOncuechange();
      }

// Generating method code for setOncuechange
      public virtual void SetOncuechange(object oncuechange)
      {
         WObj.setOncuechange(oncuechange);
      }

// Generating method code for getOnpageshow
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpageshow()
      {
         return WObj.getOnpageshow();
      }

// Generating method code for setOnpageshow
      public virtual void SetOnpageshow(object onpageshow)
      {
         WObj.setOnpageshow(onpageshow);
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

// Generating method code for getOnmozfullscreenchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmozfullscreenchange()
      {
         return WObj.getOnmozfullscreenchange();
      }

// Generating method code for setOnmozfullscreenchange
      public virtual void SetOnmozfullscreenchange(object onmozfullscreenchange)
      {
         WObj.setOnmozfullscreenchange(onmozfullscreenchange);
      }

// Generating method code for getOndurationchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndurationchange()
      {
         return WObj.getOndurationchange();
      }

// Generating method code for setOndurationchange
      public virtual void SetOndurationchange(object ondurationchange)
      {
         WObj.setOndurationchange(ondurationchange);
      }

// Generating method code for getOnplaying
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnplaying()
      {
         return WObj.getOnplaying();
      }

// Generating method code for setOnplaying
      public virtual void SetOnplaying(object onplaying)
      {
         WObj.setOnplaying(onplaying);
      }

// Generating method code for getOnended
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnended()
      {
         return WObj.getOnended();
      }

// Generating method code for setOnended
      public virtual void SetOnended(object onended)
      {
         WObj.setOnended(onended);
      }

// Generating method code for getOnloadeddata
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadeddata()
      {
         return WObj.getOnloadeddata();
      }

// Generating method code for setOnloadeddata
      public virtual void SetOnloadeddata(object onloadeddata)
      {
         WObj.setOnloadeddata(onloadeddata);
      }

// Generating method code for getOnunhandledrejection
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnunhandledrejection()
      {
         return WObj.getOnunhandledrejection();
      }

// Generating method code for setOnunhandledrejection
      public virtual void SetOnunhandledrejection(object onunhandledrejection)
      {
         WObj.setOnunhandledrejection(onunhandledrejection);
      }

// Generating method code for getOnmouseout
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseout()
      {
         return WObj.getOnmouseout();
      }

// Generating method code for setOnmouseout
      public virtual void SetOnmouseout(object onmouseout)
      {
         WObj.setOnmouseout(onmouseout);
      }

// Generating method code for getOnsuspend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnsuspend()
      {
         return WObj.getOnsuspend();
      }

// Generating method code for setOnsuspend
      public virtual void SetOnsuspend(object onsuspend)
      {
         WObj.setOnsuspend(onsuspend);
      }

// Generating method code for getOnwaiting
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwaiting()
      {
         return WObj.getOnwaiting();
      }

// Generating method code for setOnwaiting
      public virtual void SetOnwaiting(object onwaiting)
      {
         WObj.setOnwaiting(onwaiting);
      }

// Generating method code for getOncanplay
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncanplay()
      {
         return WObj.getOncanplay();
      }

// Generating method code for setOncanplay
      public virtual void SetOncanplay(object oncanplay)
      {
         WObj.setOncanplay(oncanplay);
      }

// Generating method code for getOnmousedown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmousedown()
      {
         return WObj.getOnmousedown();
      }

// Generating method code for setOnmousedown
      public virtual void SetOnmousedown(object onmousedown)
      {
         WObj.setOnmousedown(onmousedown);
      }

// Generating method code for getOnlanguagechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnlanguagechange()
      {
         return WObj.getOnlanguagechange();
      }

// Generating method code for setOnlanguagechange
      public virtual void SetOnlanguagechange(object onlanguagechange)
      {
         WObj.setOnlanguagechange(onlanguagechange);
      }

// Generating method code for getOnemptied
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnemptied()
      {
         return WObj.getOnemptied();
      }

// Generating method code for setOnemptied
      public virtual void SetOnemptied(object onemptied)
      {
         WObj.setOnemptied(onemptied);
      }

// Generating method code for getOnrejectionhandled
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnrejectionhandled()
      {
         return WObj.getOnrejectionhandled();
      }

// Generating method code for setOnrejectionhandled
      public virtual void SetOnrejectionhandled(object onrejectionhandled)
      {
         WObj.setOnrejectionhandled(onrejectionhandled);
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

// Generating method code for getOnresize
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnresize()
      {
         return WObj.getOnresize();
      }

// Generating method code for setOnresize
      public virtual void SetOnresize(object onresize)
      {
         WObj.setOnresize(onresize);
      }

// Generating method code for getOnpause
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpause()
      {
         return WObj.getOnpause();
      }

// Generating method code for setOnpause
      public virtual void SetOnpause(object onpause)
      {
         WObj.setOnpause(onpause);
      }

// Generating method code for getOnloadstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadstart()
      {
         return WObj.getOnloadstart();
      }

// Generating method code for setOnloadstart
      public virtual void SetOnloadstart(object onloadstart)
      {
         WObj.setOnloadstart(onloadstart);
      }

// Generating method code for getOnprogress
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnprogress()
      {
         return WObj.getOnprogress();
      }

// Generating method code for setOnprogress
      public virtual void SetOnprogress(object onprogress)
      {
         WObj.setOnprogress(onprogress);
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

// Generating method code for getOnbeforeprint
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforeprint()
      {
         return WObj.getOnbeforeprint();
      }

// Generating method code for setOnbeforeprint
      public virtual void SetOnbeforeprint(object onbeforeprint)
      {
         WObj.setOnbeforeprint(onbeforeprint);
      }

// Generating method code for getOnstorage
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstorage()
      {
         return WObj.getOnstorage();
      }

// Generating method code for setOnstorage
      public virtual void SetOnstorage(object onstorage)
      {
         WObj.setOnstorage(onstorage);
      }

// Generating method code for getOndevicelight
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndevicelight()
      {
         return WObj.getOndevicelight();
      }

// Generating method code for setOndevicelight
      public virtual void SetOndevicelight(object ondevicelight)
      {
         WObj.setOndevicelight(ondevicelight);
      }

// Generating method code for getOnanimationstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnanimationstart()
      {
         return WObj.getOnanimationstart();
      }

// Generating method code for setOnanimationstart
      public virtual void SetOnanimationstart(object onanimationstart)
      {
         WObj.setOnanimationstart(onanimationstart);
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

// Generating method code for getOntimeupdate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntimeupdate()
      {
         return WObj.getOntimeupdate();
      }

// Generating method code for setOntimeupdate
      public virtual void SetOntimeupdate(object ontimeupdate)
      {
         WObj.setOntimeupdate(ontimeupdate);
      }

// Generating method code for getOnpagehide
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpagehide()
      {
         return WObj.getOnpagehide();
      }

// Generating method code for setOnpagehide
      public virtual void SetOnpagehide(object onpagehide)
      {
         WObj.setOnpagehide(onpagehide);
      }

// Generating method code for getOnwebkitanimationiteration
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkitanimationiteration()
      {
         return WObj.getOnwebkitanimationiteration();
      }

// Generating method code for setOnwebkitanimationiteration
      public virtual void SetOnwebkitanimationiteration(object onwebkitanimationiteration)
      {
         WObj.setOnwebkitanimationiteration(onwebkitanimationiteration);
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

// Generating method code for getOnabort
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnabort()
      {
         return WObj.getOnabort();
      }

// Generating method code for setOnabort
      public virtual void SetOnabort(object onabort)
      {
         WObj.setOnabort(onabort);
      }

// Generating method code for getOnloadedmetadata
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadedmetadata()
      {
         return WObj.getOnloadedmetadata();
      }

// Generating method code for setOnloadedmetadata
      public virtual void SetOnloadedmetadata(object onloadedmetadata)
      {
         WObj.setOnloadedmetadata(onloadedmetadata);
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

// Generating method code for getOnmouseup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseup()
      {
         return WObj.getOnmouseup();
      }

// Generating method code for setOnmouseup
      public virtual void SetOnmouseup(object onmouseup)
      {
         WObj.setOnmouseup(onmouseup);
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

// Generating method code for getOndragover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragover()
      {
         return WObj.getOndragover();
      }

// Generating method code for setOndragover
      public virtual void SetOndragover(object ondragover)
      {
         WObj.setOndragover(ondragover);
      }

// Generating method code for getOnonline
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnonline()
      {
         return WObj.getOnonline();
      }

// Generating method code for setOnonline
      public virtual void SetOnonline(object ononline)
      {
         WObj.setOnonline(ononline);
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

// Generating method code for getOninput
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOninput()
      {
         return WObj.getOninput();
      }

// Generating method code for setOninput
      public virtual void SetOninput(object oninput)
      {
         WObj.setOninput(oninput);
      }

// Generating method code for getOnwebkittransitionend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkittransitionend()
      {
         return WObj.getOnwebkittransitionend();
      }

// Generating method code for setOnwebkittransitionend
      public virtual void SetOnwebkittransitionend(object onwebkittransitionend)
      {
         WObj.setOnwebkittransitionend(onwebkittransitionend);
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

// Generating method code for getOndevicemotion
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndevicemotion()
      {
         return WObj.getOndevicemotion();
      }

// Generating method code for setOndevicemotion
      public virtual void SetOndevicemotion(object ondevicemotion)
      {
         WObj.setOndevicemotion(ondevicemotion);
      }

// Generating method code for getOnstalled
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstalled()
      {
         return WObj.getOnstalled();
      }

// Generating method code for setOnstalled
      public virtual void SetOnstalled(object onstalled)
      {
         WObj.setOnstalled(onstalled);
      }

// Generating method code for getOnmouseenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseenter()
      {
         return WObj.getOnmouseenter();
      }

// Generating method code for setOnmouseenter
      public virtual void SetOnmouseenter(object onmouseenter)
      {
         WObj.setOnmouseenter(onmouseenter);
      }

// Generating method code for getOndragleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragleave()
      {
         return WObj.getOndragleave();
      }

// Generating method code for setOndragleave
      public virtual void SetOndragleave(object ondragleave)
      {
         WObj.setOndragleave(ondragleave);
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

// Generating method code for getOndrop
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndrop()
      {
         return WObj.getOndrop();
      }

// Generating method code for setOndrop
      public virtual void SetOndrop(object ondrop)
      {
         WObj.setOndrop(ondrop);
      }

// Generating method code for getOnunload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnunload()
      {
         return WObj.getOnunload();
      }

// Generating method code for setOnunload
      public virtual void SetOnunload(object onunload)
      {
         WObj.setOnunload(onunload);
      }

// Generating method code for getOnwebkitanimationend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkitanimationend()
      {
         return WObj.getOnwebkitanimationend();
      }

// Generating method code for setOnwebkitanimationend
      public virtual void SetOnwebkitanimationend(object onwebkitanimationend)
      {
         WObj.setOnwebkitanimationend(onwebkitanimationend);
      }

// Generating method code for getOndragstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragstart()
      {
         return WObj.getOndragstart();
      }

// Generating method code for setOndragstart
      public virtual void SetOndragstart(object ondragstart)
      {
         WObj.setOndragstart(ondragstart);
      }

// Generating method code for getOntransitionend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntransitionend()
      {
         return WObj.getOntransitionend();
      }

// Generating method code for setOntransitionend
      public virtual void SetOntransitionend(object ontransitionend)
      {
         WObj.setOntransitionend(ontransitionend);
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

// Generating method code for getOndeviceorientationabsolute
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndeviceorientationabsolute()
      {
         return WObj.getOndeviceorientationabsolute();
      }

// Generating method code for setOndeviceorientationabsolute
      public virtual void SetOndeviceorientationabsolute(object ondeviceorientationabsolute)
      {
         WObj.setOndeviceorientationabsolute(ondeviceorientationabsolute);
      }

// Generating method code for getOnshow
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnshow()
      {
         return WObj.getOnshow();
      }

// Generating method code for setOnshow
      public virtual void SetOnshow(object onshow)
      {
         WObj.setOnshow(onshow);
      }

// Generating method code for getOnvolumechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnvolumechange()
      {
         return WObj.getOnvolumechange();
      }

// Generating method code for setOnvolumechange
      public virtual void SetOnvolumechange(object onvolumechange)
      {
         WObj.setOnvolumechange(onvolumechange);
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

// Generating method code for getOnpopstate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpopstate()
      {
         return WObj.getOnpopstate();
      }

// Generating method code for setOnpopstate
      public virtual void SetOnpopstate(object onpopstate)
      {
         WObj.setOnpopstate(onpopstate);
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

// Generating method code for getClientInformation
      public virtual NHtmlUnit.Javascript.Host.Navigator GetClientInformation()
      {
         var arg = WObj.getClientInformation();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Navigator>(arg);
      }

// Generating method code for setClientInformation
      public virtual void SetClientInformation(object ignore)
      {
         WObj.setClientInformation(ignore);
      }

// Generating method code for getOnfocusin
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnfocusin()
      {
         return WObj.getOnfocusin();
      }

// Generating method code for setOnfocusin
      public virtual void SetOnfocusin(object onfocusin)
      {
         WObj.setOnfocusin(onfocusin);
      }

// Generating method code for getOnfocus
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnfocus()
      {
         return WObj.getOnfocus();
      }

// Generating method code for setOnfocus
      public virtual void SetOnfocus(object onfocus)
      {
         WObj.setOnfocus(onfocus);
      }

// Generating method code for getOndragend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragend()
      {
         return WObj.getOndragend();
      }

// Generating method code for setOndragend
      public virtual void SetOndragend(object ondragend)
      {
         WObj.setOndragend(ondragend);
      }

// Generating method code for getOninvalid
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOninvalid()
      {
         return WObj.getOninvalid();
      }

// Generating method code for setOninvalid
      public virtual void SetOninvalid(object oninvalid)
      {
         WObj.setOninvalid(oninvalid);
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

// Generating method code for getOnhelp
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnhelp()
      {
         return WObj.getOnhelp();
      }

// Generating method code for setOnhelp
      public virtual void SetOnhelp(object onhelp)
      {
         WObj.setOnhelp(onhelp);
      }

// Generating method code for getOnratechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnratechange()
      {
         return WObj.getOnratechange();
      }

// Generating method code for setOnratechange
      public virtual void SetOnratechange(object onratechange)
      {
         WObj.setOnratechange(onratechange);
      }

// Generating method code for getOnanimationiteration
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnanimationiteration()
      {
         return WObj.getOnanimationiteration();
      }

// Generating method code for setOnanimationiteration
      public virtual void SetOnanimationiteration(object onanimationiteration)
      {
         WObj.setOnanimationiteration(onanimationiteration);
      }

// Generating method code for getOncanplaythrough
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncanplaythrough()
      {
         return WObj.getOncanplaythrough();
      }

// Generating method code for setOncanplaythrough
      public virtual void SetOncanplaythrough(object oncanplaythrough)
      {
         WObj.setOncanplaythrough(oncanplaythrough);
      }

// Generating method code for getOncancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncancel()
      {
         return WObj.getOncancel();
      }

// Generating method code for setOncancel
      public virtual void SetOncancel(object oncancel)
      {
         WObj.setOncancel(oncancel);
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

// Generating method code for getOnselect
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnselect()
      {
         return WObj.getOnselect();
      }

// Generating method code for setOnselect
      public virtual void SetOnselect(object onselect)
      {
         WObj.setOnselect(onselect);
      }

// Generating method code for getOnauxclick
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnauxclick()
      {
         return WObj.getOnauxclick();
      }

// Generating method code for setOnauxclick
      public virtual void SetOnauxclick(object onauxclick)
      {
         WObj.setOnauxclick(onauxclick);
      }

// Generating method code for getOnscroll
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnscroll()
      {
         return WObj.getOnscroll();
      }

// Generating method code for setOnscroll
      public virtual void SetOnscroll(object onscroll)
      {
         WObj.setOnscroll(onscroll);
      }

// Generating method code for getOnkeydown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnkeydown()
      {
         return WObj.getOnkeydown();
      }

// Generating method code for setOnkeydown
      public virtual void SetOnkeydown(object onkeydown)
      {
         WObj.setOnkeydown(onkeydown);
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

// Generating method code for getOnwebkitanimationstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkitanimationstart()
      {
         return WObj.getOnwebkitanimationstart();
      }

// Generating method code for setOnwebkitanimationstart
      public virtual void SetOnwebkitanimationstart(object onwebkitanimationstart)
      {
         WObj.setOnwebkitanimationstart(onwebkitanimationstart);
      }

// Generating method code for getOnkeyup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnkeyup()
      {
         return WObj.getOnkeyup();
      }

// Generating method code for setOnkeyup
      public virtual void SetOnkeyup(object onkeyup)
      {
         WObj.setOnkeyup(onkeyup);
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

// Generating method code for getOndeviceproximity
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndeviceproximity()
      {
         return WObj.getOndeviceproximity();
      }

// Generating method code for setOndeviceproximity
      public virtual void SetOndeviceproximity(object ondeviceproximity)
      {
         WObj.setOndeviceproximity(ondeviceproximity);
      }

// Generating method code for getOnreset
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnreset()
      {
         return WObj.getOnreset();
      }

// Generating method code for setOnreset
      public virtual void SetOnreset(object onreset)
      {
         WObj.setOnreset(onreset);
      }

// Generating method code for getOnkeypress
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnkeypress()
      {
         return WObj.getOnkeypress();
      }

// Generating method code for setOnkeypress
      public virtual void SetOnkeypress(object onkeypress)
      {
         WObj.setOnkeypress(onkeypress);
      }

// Generating method code for getOndrag
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndrag()
      {
         return WObj.getOndrag();
      }

// Generating method code for setOndrag
      public virtual void SetOndrag(object ondrag)
      {
         WObj.setOndrag(ondrag);
      }

// Generating method code for getOnfocusout
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnfocusout()
      {
         return WObj.getOnfocusout();
      }

// Generating method code for setOnfocusout
      public virtual void SetOnfocusout(object onfocusout)
      {
         WObj.setOnfocusout(onfocusout);
      }

// Generating method code for getOnseeked
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnseeked()
      {
         return WObj.getOnseeked();
      }

// Generating method code for setOnseeked
      public virtual void SetOnseeked(object onseeked)
      {
         WObj.setOnseeked(onseeked);
      }

// Generating method code for getOnoffline
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnoffline()
      {
         return WObj.getOnoffline();
      }

// Generating method code for setOnoffline
      public virtual void SetOnoffline(object onoffline)
      {
         WObj.setOnoffline(onoffline);
      }

// Generating method code for getOndeviceorientation
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndeviceorientation()
      {
         return WObj.getOndeviceorientation();
      }

// Generating method code for setOndeviceorientation
      public virtual void SetOndeviceorientation(object ondeviceorientation)
      {
         WObj.setOndeviceorientation(ondeviceorientation);
      }

// Generating method code for getOntoggle
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntoggle()
      {
         return WObj.getOntoggle();
      }

// Generating method code for setOntoggle
      public virtual void SetOntoggle(object ontoggle)
      {
         WObj.setOntoggle(ontoggle);
      }

// Generating method code for getOnplay
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnplay()
      {
         return WObj.getOnplay();
      }

// Generating method code for setOnplay
      public virtual void SetOnplay(object onplay)
      {
         WObj.setOnplay(onplay);
      }

// Generating method code for getOncontextmenu
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncontextmenu()
      {
         return WObj.getOncontextmenu();
      }

// Generating method code for setOncontextmenu
      public virtual void SetOncontextmenu(object oncontextmenu)
      {
         WObj.setOncontextmenu(oncontextmenu);
      }

// Generating method code for getOnmousemove
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmousemove()
      {
         return WObj.getOnmousemove();
      }

// Generating method code for setOnmousemove
      public virtual void SetOnmousemove(object onmousemove)
      {
         WObj.setOnmousemove(onmousemove);
      }

// Generating method code for getOnreadystatechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnreadystatechange()
      {
         return WObj.getOnreadystatechange();
      }

// Generating method code for setOnreadystatechange
      public virtual void SetOnreadystatechange(object onreadystatechange)
      {
         WObj.setOnreadystatechange(onreadystatechange);
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

// Generating method code for getOnmouseover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseover()
      {
         return WObj.getOnmouseover();
      }

// Generating method code for setOnmouseover
      public virtual void SetOnmouseover(object onmouseover)
      {
         WObj.setOnmouseover(onmouseover);
      }

// Generating method code for getOnuserproximity
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnuserproximity()
      {
         return WObj.getOnuserproximity();
      }

// Generating method code for setOnuserproximity
      public virtual void SetOnuserproximity(object onuserproximity)
      {
         WObj.setOnuserproximity(onuserproximity);
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

// Generating method code for getOnclose
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnclose()
      {
         return WObj.getOnclose();
      }

// Generating method code for setOnclose
      public virtual void SetOnclose(object onclose)
      {
         WObj.setOnclose(onclose);
      }

// Generating method code for getOnanimationend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnanimationend()
      {
         return WObj.getOnanimationend();
      }

// Generating method code for setOnanimationend
      public virtual void SetOnanimationend(object onanimationend)
      {
         WObj.setOnanimationend(onanimationend);
      }

// Generating method code for getOndragenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragenter()
      {
         return WObj.getOndragenter();
      }

// Generating method code for setOndragenter
      public virtual void SetOndragenter(object ondragenter)
      {
         WObj.setOndragenter(ondragenter);
      }

// Generating method code for getOnafterprint
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnafterprint()
      {
         return WObj.getOnafterprint();
      }

// Generating method code for setOnafterprint
      public virtual void SetOnafterprint(object onafterprint)
      {
         WObj.setOnafterprint(onafterprint);
      }

// Generating method code for getOnmozfullscreenerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmozfullscreenerror()
      {
         return WObj.getOnmozfullscreenerror();
      }

// Generating method code for setOnmozfullscreenerror
      public virtual void SetOnmozfullscreenerror(object onmozfullscreenerror)
      {
         WObj.setOnmozfullscreenerror(onmozfullscreenerror);
      }

// Generating method code for getOnmouseleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseleave()
      {
         return WObj.getOnmouseleave();
      }

// Generating method code for setOnmouseleave
      public virtual void SetOnmouseleave(object onmouseleave)
      {
         WObj.setOnmouseleave(onmouseleave);
      }

   }


}
