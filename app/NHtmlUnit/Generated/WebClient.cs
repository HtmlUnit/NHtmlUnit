// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebClient : ObjectWrapper
   {
      static WebClient()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebClient o) =>
            new WebClient(o));
      }

      public WebClient(com.gargoylesoftware.htmlunit.WebClient wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebClient WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebClient)WrappedObject; }
      }

      public WebClient(NHtmlUnit.BrowserVersion browserVersion)
         : this(new com.gargoylesoftware.htmlunit.WebClient((com.gargoylesoftware.htmlunit.BrowserVersion)browserVersion.WrappedObject)) {}

      public WebClient()
         : this(new com.gargoylesoftware.htmlunit.WebClient()) {}

      public WebClient(NHtmlUnit.BrowserVersion browserVersion, string proxyHost, int proxyPort)
         : this(new com.gargoylesoftware.htmlunit.WebClient((com.gargoylesoftware.htmlunit.BrowserVersion)browserVersion.WrappedObject, proxyHost, proxyPort)) {}


      public NHtmlUnit.Cache Cache
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Cache>(
               WObj.getCache());
         }
         set
         {
            WObj.setCache((com.gargoylesoftware.htmlunit.Cache)value.WrappedObject);
         }

      }


      public NHtmlUnit.Javascript.JavaScriptEngine JavaScriptEngine
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.JavaScriptEngine>(
               WObj.getJavaScriptEngine());
         }
         set
         {
            WObj.setJavaScriptEngine((com.gargoylesoftware.htmlunit.javascript.JavaScriptEngine)value.WrappedObject);
         }

      }


      public NHtmlUnit.BrowserVersion BrowserVersion
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
               WObj.getBrowserVersion());
         }
      }


      public NHtmlUnit.AjaxController AjaxController
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.AjaxController>(
               WObj.getAjaxController());
         }
         set
         {
            WObj.setAjaxController((com.gargoylesoftware.htmlunit.AjaxController)value.WrappedObject);
         }

      }


      public NHtmlUnit.WebClientOptions Options
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebClientOptions>(
               WObj.getOptions());
         }
      }


      public NHtmlUnit.IIncorrectnessListener IncorrectnessListener
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IIncorrectnessListener>(
               WObj.getIncorrectnessListener());
         }
         set
         {
            WObj.setIncorrectnessListener((com.gargoylesoftware.htmlunit.IncorrectnessListener)value.WrappedObject);
         }

      }


      public NHtmlUnit.IWebWindow CurrentWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(
               WObj.getCurrentWindow());
         }
         set
         {
            WObj.setCurrentWindow((com.gargoylesoftware.htmlunit.WebWindow)value.WrappedObject);
         }

      }


      public NHtmlUnit.IAppletConfirmHandler AppletConfirmHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IAppletConfirmHandler>(
               WObj.getAppletConfirmHandler());
         }
         set
         {
            WObj.setAppletConfirmHandler((com.gargoylesoftware.htmlunit.AppletConfirmHandler)value.WrappedObject);
         }

      }


      public NHtmlUnit.Javascript.IJavaScriptErrorListener JavaScriptErrorListener
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.IJavaScriptErrorListener>(
               WObj.getJavaScriptErrorListener());
         }
         set
         {
            WObj.setJavaScriptErrorListener((com.gargoylesoftware.htmlunit.javascript.JavaScriptErrorListener)value.WrappedObject);
         }

      }


      public NHtmlUnit.IOnbeforeunloadHandler OnbeforeunloadHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IOnbeforeunloadHandler>(
               WObj.getOnbeforeunloadHandler());
         }
         set
         {
            WObj.setOnbeforeunloadHandler((com.gargoylesoftware.htmlunit.OnbeforeunloadHandler)value.WrappedObject);
         }

      }


      public NHtmlUnit.IRefreshHandler RefreshHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IRefreshHandler>(
               WObj.getRefreshHandler());
         }
         set
         {
            WObj.setRefreshHandler((com.gargoylesoftware.htmlunit.RefreshHandler)value.WrappedObject);
         }

      }


      public NHtmlUnit.Html.IHTMLParserListener HTMLParserListener
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.IHTMLParserListener>(
               WObj.getHTMLParserListener());
         }
         set
         {
            WObj.setHTMLParserListener((com.gargoylesoftware.htmlunit.html.HTMLParserListener)value.WrappedObject);
         }

      }


      public org.apache.http.client.CredentialsProvider CredentialsProvider
      {
         get
         {
            return WObj.getCredentialsProvider();
         }
         set
         {
            WObj.setCredentialsProvider(value);
         }

      }

      public NHtmlUnit.CookieManager CookieManager
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.CookieManager>(
               WObj.getCookieManager());
         }
         set
         {
            WObj.setCookieManager((com.gargoylesoftware.htmlunit.CookieManager)value.WrappedObject);
         }

      }


      public NHtmlUnit.Activex.Javascript.Msxml.MSXMLActiveXObjectFactory MSXMLActiveXObjectFactory
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.MSXMLActiveXObjectFactory>(
               WObj.getMSXMLActiveXObjectFactory());
         }
      }


      public java.util.Map ActiveXObjectMap
      {
         get
         {
            return WObj.getActiveXObjectMap();
         }
         set
         {
            WObj.setActiveXObjectMap(value);
         }

      }

      public NHtmlUnit.WebConsole WebConsole
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebConsole>(
               WObj.getWebConsole());
         }
      }


      public org.w3c.css.sac.ErrorHandler CssErrorHandler
      {
         get
         {
            return WObj.getCssErrorHandler();
         }
         set
         {
            WObj.setCssErrorHandler(value);
         }

      }

      public NHtmlUnit.IAlertHandler AlertHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IAlertHandler>(
               WObj.getAlertHandler());
         }
         set
         {
            WObj.setAlertHandler((com.gargoylesoftware.htmlunit.AlertHandler)value.WrappedObject);
         }

      }


      public NHtmlUnit.IConfirmHandler ConfirmHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IConfirmHandler>(
               WObj.getConfirmHandler());
         }
         set
         {
            WObj.setConfirmHandler((com.gargoylesoftware.htmlunit.ConfirmHandler)value.WrappedObject);
         }

      }


      public NHtmlUnit.IPromptHandler PromptHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IPromptHandler>(
               WObj.getPromptHandler());
         }
         set
         {
            WObj.setPromptHandler((com.gargoylesoftware.htmlunit.PromptHandler)value.WrappedObject);
         }

      }


      public NHtmlUnit.StorageHolder StorageHolder
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.StorageHolder>(
               WObj.getStorageHolder());
         }
      }


      public NHtmlUnit.IStatusHandler StatusHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IStatusHandler>(
               WObj.getStatusHandler());
         }
         set
         {
            WObj.setStatusHandler((com.gargoylesoftware.htmlunit.StatusHandler)value.WrappedObject);
         }

      }


      public NHtmlUnit.IScriptPreProcessor ScriptPreProcessor
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IScriptPreProcessor>(
               WObj.getScriptPreProcessor());
         }
         set
         {
            WObj.setScriptPreProcessor((com.gargoylesoftware.htmlunit.ScriptPreProcessor)value.WrappedObject);
         }

      }


      public NHtmlUnit.IWebConnection WebConnection
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebConnection>(
               WObj.getWebConnection());
         }
         set
         {
            WObj.setWebConnection((com.gargoylesoftware.htmlunit.WebConnection)value.WrappedObject);
         }

      }


      public IList<NHtmlUnit.IWebWindow> WebWindows
      {
         get
         {
            return new ListWrapper<NHtmlUnit.IWebWindow>(
               WObj.getWebWindows());
         }
       }

      public NHtmlUnit.IPageCreator PageCreator
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IPageCreator>(
               WObj.getPageCreator());
         }
         set
         {
            WObj.setPageCreator((com.gargoylesoftware.htmlunit.PageCreator)value.WrappedObject);
         }

      }


      public IList<NHtmlUnit.TopLevelWindow> TopLevelWindows
      {
         get
         {
            return new ListWrapper<NHtmlUnit.TopLevelWindow>(
               WObj.getTopLevelWindows());
         }
       }

      public System.Int64 JavaScriptTimeout
      {
         get
         {
            return WObj.getJavaScriptTimeout();
         }
         set
         {
            WObj.setJavaScriptTimeout(value);
         }

      }

      public NHtmlUnit.Attachment.IAttachmentHandler AttachmentHandler
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Attachment.IAttachmentHandler>(
               WObj.getAttachmentHandler());
         }
         set
         {
            WObj.setAttachmentHandler((com.gargoylesoftware.htmlunit.attachment.AttachmentHandler)value.WrappedObject);
         }

      }

// Generating method code for loadWebResponse
      public virtual NHtmlUnit.WebResponse LoadWebResponse(NHtmlUnit.WebRequest webRequest)
      {
         var arg = WObj.loadWebResponse((com.gargoylesoftware.htmlunit.WebRequest)webRequest.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.WebResponse>(arg);
      }

// Generating method code for registerWebWindow
      public virtual void RegisterWebWindow(NHtmlUnit.IWebWindow webWindow)
      {
         WObj.registerWebWindow((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.IWebWindow webWindow)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.IPage newPage)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.Page)newPage.WrappedObject);
      }

// Generating method code for deregisterWebWindow
      public virtual void DeregisterWebWindow(NHtmlUnit.IWebWindow webWindow)
      {
         WObj.deregisterWebWindow((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
      }

// Generating method code for getPage
      public virtual NHtmlUnit.IPage GetPage(NHtmlUnit.IWebWindow webWindow, NHtmlUnit.WebRequest webRequest)
      {
         var arg = WObj.getPage((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject, (com.gargoylesoftware.htmlunit.WebRequest)webRequest.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for openTargetWindow
      public virtual NHtmlUnit.IWebWindow OpenTargetWindow(NHtmlUnit.IWebWindow opener, string windowName, string defaultName)
      {
         var arg = WObj.openTargetWindow((com.gargoylesoftware.htmlunit.WebWindow)opener.WrappedObject, windowName, defaultName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(arg);
      }

// Generating method code for download
      public virtual void Download(NHtmlUnit.IWebWindow requestingWindow, string target, NHtmlUnit.WebRequest request, bool forceLoad, string description)
      {
         WObj.download((com.gargoylesoftware.htmlunit.WebWindow)requestingWindow.WrappedObject, target, (com.gargoylesoftware.htmlunit.WebRequest)request.WrappedObject, forceLoad, description);
      }

// Generating method code for openWindow
      public virtual NHtmlUnit.IWebWindow OpenWindow(java.net.URL url, string windowName)
      {
         var arg = WObj.openWindow(url, windowName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(arg);
      }

// Generating method code for throwFailingHttpStatusCodeExceptionIfNecessary
      public virtual void ThrowFailingHttpStatusCodeExceptionIfNecessary(NHtmlUnit.WebResponse webResponse)
      {
         WObj.throwFailingHttpStatusCodeExceptionIfNecessary((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject);
      }

// Generating method code for getPage
      public virtual NHtmlUnit.IPage GetPage(NHtmlUnit.IWebWindow opener, string target, NHtmlUnit.WebRequest paramsArg)
      {
         var arg = WObj.getPage((com.gargoylesoftware.htmlunit.WebWindow)opener.WrappedObject, target, (com.gargoylesoftware.htmlunit.WebRequest)paramsArg.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for containsWebWindow
      public virtual bool ContainsWebWindow(NHtmlUnit.IWebWindow webWindow)
      {
         return WObj.containsWebWindow((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
      }

// Generating method code for guessContentType
      public virtual string GuessContentType(java.io.File file)
      {
         return WObj.guessContentType(file);
      }

// Generating method code for addCookie
      public virtual void AddCookie(string cookieString, java.net.URL pageUrl, object origin)
      {
         WObj.addCookie(cookieString, pageUrl, origin);
      }

// Generating method code for printContentIfNecessary
      public virtual void PrintContentIfNecessary(NHtmlUnit.WebResponse webResponse)
      {
         WObj.printContentIfNecessary((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject);
      }

// Generating method code for getPage
      public virtual NHtmlUnit.IPage GetPage(NHtmlUnit.WebRequest request)
      {
         var arg = WObj.getPage((com.gargoylesoftware.htmlunit.WebRequest)request.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for getPage
      public virtual NHtmlUnit.IPage GetPage(string url)
      {
         var arg = WObj.getPage(url);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

// Generating method code for getCookies
      public virtual ICollection<NHtmlUnit.Util.Cookie> GetCookies(java.net.URL url)
      {

return new CollectionWrapper<NHtmlUnit.Util.Cookie>(WObj.getCookies(url));
      }

// Generating method code for loadWebResponseInto
      public virtual NHtmlUnit.IPage LoadWebResponseInto(NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow webWindow)
      {
         var arg = WObj.loadWebResponseInto((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for getWebWindowByName
      public virtual NHtmlUnit.IWebWindow GetWebWindowByName(string name)
      {
         var arg = WObj.getWebWindowByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(arg);
      }

// Generating method code for openWindow
      public virtual NHtmlUnit.IWebWindow OpenWindow(java.net.URL url, string windowName, NHtmlUnit.IWebWindow opener)
      {
         var arg = WObj.openWindow(url, windowName, (com.gargoylesoftware.htmlunit.WebWindow)opener.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(arg);
      }

// Generating method code for openDialogWindow
      public virtual NHtmlUnit.DialogWindow OpenDialogWindow(java.net.URL url, NHtmlUnit.IWebWindow opener, object dialogArguments)
      {
         var arg = WObj.openDialogWindow(url, (com.gargoylesoftware.htmlunit.WebWindow)opener.WrappedObject, dialogArguments);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.DialogWindow>(arg);
      }

// Generating method code for loadDownloadedResponses
      public virtual void LoadDownloadedResponses()
      {
         WObj.loadDownloadedResponses();
      }

// Generating method code for addWebWindowListener
      public virtual void AddWebWindowListener(NHtmlUnit.IWebWindowListener listener)
      {
         WObj.addWebWindowListener((com.gargoylesoftware.htmlunit.WebWindowListener)listener.WrappedObject);
      }

// Generating method code for getPage
      public virtual NHtmlUnit.IPage GetPage(java.net.URL url)
      {
         var arg = WObj.getPage(url);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for initializeEmptyWindow
      public virtual void InitializeEmptyWindow(NHtmlUnit.IWebWindow webWindow)
      {
         WObj.initializeEmptyWindow((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
      }

// Generating method code for waitForBackgroundJavaScript
      public virtual int WaitForBackgroundJavaScript(System.Int64 timeoutMillis)
      {
         return WObj.waitForBackgroundJavaScript(timeoutMillis);
      }

// Generating method code for waitForBackgroundJavaScriptStartingBefore
      public virtual int WaitForBackgroundJavaScriptStartingBefore(System.Int64 delayMillis)
      {
         return WObj.waitForBackgroundJavaScriptStartingBefore(delayMillis);
      }

// Generating method code for addRequestHeader
      public virtual void AddRequestHeader(string name, string value)
      {
         WObj.addRequestHeader(name, value);
      }

// Generating method code for removeRequestHeader
      public virtual void RemoveRequestHeader(string name)
      {
         WObj.removeRequestHeader(name);
      }

// Generating method code for removeWebWindowListener
      public virtual void RemoveWebWindowListener(NHtmlUnit.IWebWindowListener listener)
      {
         WObj.removeWebWindowListener((com.gargoylesoftware.htmlunit.WebWindowListener)listener.WrappedObject);
      }

   }


}
