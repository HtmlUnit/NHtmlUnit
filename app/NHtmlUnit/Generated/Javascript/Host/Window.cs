// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Window : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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


      public NHtmlUnit.Javascript.Host.Event CurrentEvent
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Event>(
               WObj.getCurrentEvent());
         }
      }


      public NHtmlUnit.Javascript.Host.EventListenersContainer EventListenersContainer
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.EventListenersContainer>(
               WObj.getEventListenersContainer());
         }
      }


      public NHtmlUnit.Javascript.Host.Document Document
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Document>(
               WObj.getDocument());
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

// Generating method code for jsxGet_scrollY
      public virtual int JsxGet_scrollY()
      {
         return WObj.jsxGet_scrollY();
      }

// Generating method code for jsxSet_status
      public virtual void JsxSet_status(string message)
      {
         WObj.jsxSet_status(message);
      }

// Generating method code for jsxFunction_attachEvent
      public virtual bool JsxFunction_attachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         return WObj.jsxFunction_attachEvent(type, listener);
      }

// Generating method code for getPrototype
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable GetPrototype(java.lang.Class jsClass)
      {
         return WObj.getPrototype(jsClass);
      }

// Generating method code for jsxFunction_getComputedStyle
      public virtual NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration JsxFunction_getComputedStyle(NHtmlUnit.Javascript.Host.Element element, string pseudo)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration>(WObj.jsxFunction_getComputedStyle((com.gargoylesoftware.htmlunit.javascript.host.Element)element.WrappedObject, pseudo));
      }

// Generating method code for jsxGet_location
      public virtual NHtmlUnit.Javascript.Host.Location JsxGet_location()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Location>(WObj.jsxGet_location());
      }

// Generating method code for jsxSet_location
      public virtual void JsxSet_location(string newLocation)
      {
         WObj.jsxSet_location(newLocation);
      }

// Generating method code for jsxGet_document
      public virtual NHtmlUnit.Javascript.Host.Html.DocumentProxy JsxGet_document()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DocumentProxy>(WObj.jsxGet_document());
      }

// Generating method code for jsxGet_screen
      public virtual NHtmlUnit.Javascript.Host.Screen JsxGet_screen()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Screen>(WObj.jsxGet_screen());
      }

// Generating method code for jsxGet_navigator
      public virtual NHtmlUnit.Javascript.Host.Navigator JsxGet_navigator()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Navigator>(WObj.jsxGet_navigator());
      }

// Generating method code for jsxGet_frames
      public virtual NHtmlUnit.Javascript.Host.WindowProxy JsxGet_frames()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(WObj.jsxGet_frames());
      }

// Generating method code for jsxGet_innerWidth
      public virtual int JsxGet_innerWidth()
      {
         return WObj.jsxGet_innerWidth();
      }

// Generating method code for jsxGet_innerHeight
      public virtual int JsxGet_innerHeight()
      {
         return WObj.jsxGet_innerHeight();
      }

// Generating method code for executeEvent
      public virtual NHtmlUnit.ScriptResult ExecuteEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject));
      }

// Generating method code for jsxFunction_scrollTo
      public virtual void JsxFunction_scrollTo(int x, int y)
      {
         WObj.jsxFunction_scrollTo(x, y);
      }

// Generating method code for jsxGet_onerror
      public virtual object JsxGet_onerror()
      {
         return WObj.jsxGet_onerror();
      }

// Generating method code for custom_eval
      public virtual object Custom_eval(string scriptCode)
      {
         return WObj.custom_eval(scriptCode);
      }

// Generating method code for jsxFunction_setTimeout
      public virtual int JsxFunction_setTimeout(object code, int timeout, object language)
      {
         return WObj.jsxFunction_setTimeout(code, timeout, language);
      }

// Generating method code for jsxFunction_alert
      public virtual void JsxFunction_alert(object message)
      {
         WObj.jsxFunction_alert(message);
      }

// Generating method code for jsxFunction_btoa
      public virtual string JsxFunction_btoa(string stringToEncode)
      {
         return WObj.jsxFunction_btoa(stringToEncode);
      }

// Generating method code for jsxFunction_atob
      public virtual string JsxFunction_atob(string encodedData)
      {
         return WObj.jsxFunction_atob(encodedData);
      }

// Generating method code for jsxFunction_confirm
      public virtual bool JsxFunction_confirm(string message)
      {
         return WObj.jsxFunction_confirm(message);
      }

// Generating method code for jsxFunction_prompt
      public virtual string JsxFunction_prompt(string message)
      {
         return WObj.jsxFunction_prompt(message);
      }

// Generating method code for jsxGet_applicationCache
      public virtual NHtmlUnit.Javascript.Host.OfflineResourceList JsxGet_applicationCache()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.OfflineResourceList>(WObj.jsxGet_applicationCache());
      }

// Generating method code for jsxGet_event
      public virtual object JsxGet_event()
      {
         return WObj.jsxGet_event();
      }

// Generating method code for jsxFunction_open
      public virtual NHtmlUnit.Javascript.Host.WindowProxy JsxFunction_open(object url, object name, object features, object replace)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(WObj.jsxFunction_open(url, name, features, replace));
      }

// Generating method code for jsxFunction_createPopup
      public virtual NHtmlUnit.Javascript.Host.Popup JsxFunction_createPopup()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Popup>(WObj.jsxFunction_createPopup());
      }

// Generating method code for jsxFunction_clearTimeout
      public virtual void JsxFunction_clearTimeout(int timeoutId)
      {
         WObj.jsxFunction_clearTimeout(timeoutId);
      }

// Generating method code for jsxGet_clientInformation
      public virtual NHtmlUnit.Javascript.Host.Navigator JsxGet_clientInformation()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Navigator>(WObj.jsxGet_clientInformation());
      }

// Generating method code for jsxGet_clipboardData
      public virtual NHtmlUnit.Javascript.Host.ClipboardData JsxGet_clipboardData()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ClipboardData>(WObj.jsxGet_clipboardData());
      }

// Generating method code for jsxGet_window
      public virtual NHtmlUnit.Javascript.Host.WindowProxy JsxGet_window()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(WObj.jsxGet_window());
      }

// Generating method code for jsxGet_self
      public virtual NHtmlUnit.Javascript.Host.WindowProxy JsxGet_self()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(WObj.jsxGet_self());
      }

// Generating method code for jsxGet_localStorage
      public virtual NHtmlUnit.Javascript.Host.Storage JsxGet_localStorage()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Storage>(WObj.jsxGet_localStorage());
      }

// Generating method code for jsxGet_sessionStorage
      public virtual NHtmlUnit.Javascript.Host.Storage JsxGet_sessionStorage()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Storage>(WObj.jsxGet_sessionStorage());
      }

// Generating method code for jsxGet_globalStorage
      public virtual NHtmlUnit.Javascript.Host.StorageList JsxGet_globalStorage()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.StorageList>(WObj.jsxGet_globalStorage());
      }

// Generating method code for jsxGet_history
      public virtual NHtmlUnit.Javascript.Host.History JsxGet_history()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.History>(WObj.jsxGet_history());
      }

// Generating method code for jsxGet_external
      public virtual NHtmlUnit.Javascript.Host.External JsxGet_external()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.External>(WObj.jsxGet_external());
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

// Generating method code for jsxGet_top
      public virtual object JsxGet_top()
      {
         return WObj.jsxGet_top();
      }

// Generating method code for jsxSet_top
      public virtual void JsxSet_top(object o)
      {
         WObj.jsxSet_top(o);
      }

// Generating method code for jsxGet_parent
      public virtual NHtmlUnit.Javascript.Host.WindowProxy JsxGet_parent()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(WObj.jsxGet_parent());
      }

// Generating method code for jsxGet_opener
      public virtual object JsxGet_opener()
      {
         return WObj.jsxGet_opener();
      }

// Generating method code for jsxSet_opener
      public virtual void JsxSet_opener(object newValue)
      {
         WObj.jsxSet_opener(newValue);
      }

// Generating method code for jsxGet_frameElement
      public virtual object JsxGet_frameElement()
      {
         return WObj.jsxGet_frameElement();
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxFunction_focus
      public virtual void JsxFunction_focus()
      {
         WObj.jsxFunction_focus();
      }

// Generating method code for jsxFunction_blur
      public virtual void JsxFunction_blur()
      {
         WObj.jsxFunction_blur();
      }

// Generating method code for jsxFunction_close
      public virtual void JsxFunction_close()
      {
         WObj.jsxFunction_close();
      }

// Generating method code for jsxGet_closed
      public virtual bool JsxGet_closed()
      {
         return WObj.jsxGet_closed();
      }

// Generating method code for jsxFunction_moveTo
      public virtual void JsxFunction_moveTo(int x, int y)
      {
         WObj.jsxFunction_moveTo(x, y);
      }

// Generating method code for jsxFunction_moveBy
      public virtual void JsxFunction_moveBy(int x, int y)
      {
         WObj.jsxFunction_moveBy(x, y);
      }

// Generating method code for jsxFunction_resizeBy
      public virtual void JsxFunction_resizeBy(int width, int height)
      {
         WObj.jsxFunction_resizeBy(width, height);
      }

// Generating method code for jsxFunction_resizeTo
      public virtual void JsxFunction_resizeTo(int width, int height)
      {
         WObj.jsxFunction_resizeTo(width, height);
      }

// Generating method code for jsxFunction_scroll
      public virtual void JsxFunction_scroll(int x, int y)
      {
         WObj.jsxFunction_scroll(x, y);
      }

// Generating method code for jsxFunction_scrollBy
      public virtual void JsxFunction_scrollBy(int x, int y)
      {
         WObj.jsxFunction_scrollBy(x, y);
      }

// Generating method code for jsxFunction_scrollByLines
      public virtual void JsxFunction_scrollByLines(int lines)
      {
         WObj.jsxFunction_scrollByLines(lines);
      }

// Generating method code for jsxFunction_scrollByPages
      public virtual void JsxFunction_scrollByPages(int pages)
      {
         WObj.jsxFunction_scrollByPages(pages);
      }

// Generating method code for jsxSet_onload
      public virtual void JsxSet_onload(object newOnload)
      {
         WObj.jsxSet_onload(newOnload);
      }

// Generating method code for jsxSet_onclick
      public virtual void JsxSet_onclick(object newOnload)
      {
         WObj.jsxSet_onclick(newOnload);
      }

// Generating method code for jsxGet_onclick
      public virtual object JsxGet_onclick()
      {
         return WObj.jsxGet_onclick();
      }

// Generating method code for jsxSet_ondblclick
      public virtual void JsxSet_ondblclick(object newHandler)
      {
         WObj.jsxSet_ondblclick(newHandler);
      }

// Generating method code for jsxGet_ondblclick
      public virtual object JsxGet_ondblclick()
      {
         return WObj.jsxGet_ondblclick();
      }

// Generating method code for jsxGet_onload
      public virtual object JsxGet_onload()
      {
         return WObj.jsxGet_onload();
      }

// Generating method code for jsxGet_onhashchange
      public virtual object JsxGet_onhashchange()
      {
         return WObj.jsxGet_onhashchange();
      }

// Generating method code for jsxSet_onhashchange
      public virtual void JsxSet_onhashchange(object newHandler)
      {
         WObj.jsxSet_onhashchange(newHandler);
      }

// Generating method code for jsxFunction_addEventListener
      public virtual void JsxFunction_addEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.jsxFunction_addEventListener(type, listener, useCapture);
      }

// Generating method code for jsxFunction_detachEvent
      public virtual void JsxFunction_detachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         WObj.jsxFunction_detachEvent(type, listener);
      }

// Generating method code for jsxFunction_removeEventListener
      public virtual void JsxFunction_removeEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.jsxFunction_removeEventListener(type, listener, useCapture);
      }

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxSet_name
      public virtual void JsxSet_name(string name)
      {
         WObj.jsxSet_name(name);
      }

// Generating method code for jsxGet_onbeforeunload
      public virtual object JsxGet_onbeforeunload()
      {
         return WObj.jsxGet_onbeforeunload();
      }

// Generating method code for jsxSet_onbeforeunload
      public virtual void JsxSet_onbeforeunload(object onbeforeunload)
      {
         WObj.jsxSet_onbeforeunload(onbeforeunload);
      }

// Generating method code for jsxSet_onerror
      public virtual void JsxSet_onerror(object onerror)
      {
         WObj.jsxSet_onerror(onerror);
      }

// Generating method code for triggerOnError
      public virtual void TriggerOnError(NHtmlUnit.ScriptException e)
      {
         WObj.triggerOnError((com.gargoylesoftware.htmlunit.ScriptException)e.WrappedObject);
      }

// Generating method code for call
      public virtual object Call(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObj, System.Object[] args)
      {
         return WObj.call(cx, scope, thisObj, args);
      }

// Generating method code for construct
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Construct(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, System.Object[] args)
      {
         return WObj.construct(cx, scope, args);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for jsxFunction_execScript
      public virtual void JsxFunction_execScript(string script, object language)
      {
         WObj.jsxFunction_execScript(script, language);
      }

// Generating method code for jsxGet_status
      public virtual string JsxGet_status()
      {
         return WObj.jsxGet_status();
      }

// Generating method code for jsxFunction_setInterval
      public virtual int JsxFunction_setInterval(object code, int timeout, object language)
      {
         return WObj.jsxFunction_setInterval(code, timeout, language);
      }

// Generating method code for jsxFunction_clearInterval
      public virtual void JsxFunction_clearInterval(int intervalID)
      {
         WObj.jsxFunction_clearInterval(intervalID);
      }

// Generating method code for jsxGet_outerWidth
      public virtual int JsxGet_outerWidth()
      {
         return WObj.jsxGet_outerWidth();
      }

// Generating method code for jsxGet_outerHeight
      public virtual int JsxGet_outerHeight()
      {
         return WObj.jsxGet_outerHeight();
      }

// Generating method code for jsxFunction_print
      public virtual void JsxFunction_print()
      {
         WObj.jsxFunction_print();
      }

// Generating method code for jsxFunction_captureEvents
      public virtual void JsxFunction_captureEvents(string type)
      {
         WObj.jsxFunction_captureEvents(type);
      }

// Generating method code for jsxFunction_CollectGarbage
      public virtual void JsxFunction_CollectGarbage()
      {
         WObj.jsxFunction_CollectGarbage();
      }

// Generating method code for jsxFunction_getSelection
      public virtual NHtmlUnit.Javascript.Host.Selection JsxFunction_getSelection()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Selection>(WObj.jsxFunction_getSelection());
      }

// Generating method code for jsxFunction_showModalDialog
      public virtual object JsxFunction_showModalDialog(string url, object arguments, string features)
      {
         return WObj.jsxFunction_showModalDialog(url, arguments, features);
      }

// Generating method code for jsxFunction_showModelessDialog
      public virtual object JsxFunction_showModelessDialog(string url, object arguments, string features)
      {
         return WObj.jsxFunction_showModelessDialog(url, arguments, features);
      }

// Generating method code for jsxGet_controllers
      public virtual object JsxGet_controllers()
      {
         return WObj.jsxGet_controllers();
      }

// Generating method code for jsxSet_controllers
      public virtual void JsxSet_controllers(object value)
      {
         WObj.jsxSet_controllers(value);
      }

// Generating method code for jsxGet_mozInnerScreenX
      public virtual int JsxGet_mozInnerScreenX()
      {
         return WObj.jsxGet_mozInnerScreenX();
      }

// Generating method code for jsxGet_mozInnerScreenY
      public virtual int JsxGet_mozInnerScreenY()
      {
         return WObj.jsxGet_mozInnerScreenY();
      }

// Generating method code for jsxGet_mozPaintCount
      public virtual int JsxGet_mozPaintCount()
      {
         return WObj.jsxGet_mozPaintCount();
      }

// Generating method code for jsxFunction_ScriptEngine
      public virtual string JsxFunction_ScriptEngine()
      {
         return WObj.jsxFunction_ScriptEngine();
      }

// Generating method code for jsxFunction_ScriptEngineBuildVersion
      public virtual int JsxFunction_ScriptEngineBuildVersion()
      {
         return WObj.jsxFunction_ScriptEngineBuildVersion();
      }

// Generating method code for jsxFunction_ScriptEngineMajorVersion
      public virtual int JsxFunction_ScriptEngineMajorVersion()
      {
         return WObj.jsxFunction_ScriptEngineMajorVersion();
      }

// Generating method code for jsxFunction_ScriptEngineMinorVersion
      public virtual int JsxFunction_ScriptEngineMinorVersion()
      {
         return WObj.jsxFunction_ScriptEngineMinorVersion();
      }

// Generating method code for jsxFunction_stop
      public virtual void JsxFunction_stop()
      {
         WObj.jsxFunction_stop();
      }

// Generating method code for jsxGet_pageXOffset
      public virtual int JsxGet_pageXOffset()
      {
         return WObj.jsxGet_pageXOffset();
      }

// Generating method code for jsxGet_pageYOffset
      public virtual int JsxGet_pageYOffset()
      {
         return WObj.jsxGet_pageYOffset();
      }

// Generating method code for jsxGet_scrollX
      public virtual int JsxGet_scrollX()
      {
         return WObj.jsxGet_scrollX();
      }

   }


}
