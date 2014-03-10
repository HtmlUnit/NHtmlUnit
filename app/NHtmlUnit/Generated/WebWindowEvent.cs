// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebWindowEvent : ObjectWrapper
   {
      static WebWindowEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebWindowEvent o) =>
            new WebWindowEvent(o));
      }

      public WebWindowEvent(com.gargoylesoftware.htmlunit.WebWindowEvent wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebWindowEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebWindowEvent)WrappedObject; }
      }

      public WebWindowEvent(NHtmlUnit.IWebWindow webWindow, int type, NHtmlUnit.IPage oldPage, NHtmlUnit.IPage newPage)
         : this(new com.gargoylesoftware.htmlunit.WebWindowEvent((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject, type, (com.gargoylesoftware.htmlunit.Page)oldPage.WrappedObject, (com.gargoylesoftware.htmlunit.Page)newPage.WrappedObject)) {}


      public NHtmlUnit.IWebWindow WebWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(
               WObj.getWebWindow());
         }
      }


      public NHtmlUnit.IPage OldPage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(
               WObj.getOldPage());
         }
      }


      public System.Int32 EventType
      {
         get
         {
            return WObj.getEventType();
         }
      }

      public NHtmlUnit.IPage NewPage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(
               WObj.getNewPage());
         }
      }

   }


}
