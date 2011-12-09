// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebWindowImpl : ObjectWrapper, NHtmlUnit.IWebWindow
   {
      static WebWindowImpl()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebWindowImpl o) =>
            new WebWindowImpl(o));
      }

      public WebWindowImpl(com.gargoylesoftware.htmlunit.WebWindowImpl wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebWindowImpl WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebWindowImpl)WrappedObject; }
      }


      public NHtmlUnit.IPage EnclosedPage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(
               WObj.getEnclosedPage());
         }
         set
         {
            WObj.setEnclosedPage((com.gargoylesoftware.htmlunit.Page)value.WrappedObject);
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

      public NHtmlUnit.Javascript.Background.IJavaScriptJobManager JobManager
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Background.IJavaScriptJobManager>(
               WObj.getJobManager());
         }
         set
         {
            WObj.setJobManager((com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJobManager)value.WrappedObject);
         }

      }


      public NHtmlUnit.WebClient WebClient
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebClient>(
               WObj.getWebClient());
         }
      }


      public System.Object ScriptObject
      {
         get
         {
            return WObj.getScriptObject();
         }
         set
         {
            WObj.setScriptObject(value);
         }

      }

      public NHtmlUnit.History History
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.History>(
               WObj.getHistory());
         }
      }


      public NHtmlUnit.IWebWindow ParentWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(
               WObj.getParentWindow());
         }
      }


      public NHtmlUnit.IWebWindow TopWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(
               WObj.getTopWindow());
         }
      }

// Generating method code for addChildWindow
      public virtual void AddChildWindow(NHtmlUnit.Html.FrameWindow child)
      {
         WObj.addChildWindow((com.gargoylesoftware.htmlunit.html.FrameWindow)child.WrappedObject);
      }

// Generating method code for isClosed
      public virtual bool IsClosed()
      {
         return WObj.isClosed();
      }

   }


}
