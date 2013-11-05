// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class FrameWindow : NHtmlUnit.WebWindowImpl, NHtmlUnit.IWebWindow
   {
      static FrameWindow()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.FrameWindow o) =>
            new FrameWindow(o));
      }

      public FrameWindow(com.gargoylesoftware.htmlunit.html.FrameWindow wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.FrameWindow WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.FrameWindow)WrappedObject; }
      }


      public NHtmlUnit.Html.BaseFrameElement FrameElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.BaseFrameElement>(
               WObj.getFrameElement());
         }
      }


      public NHtmlUnit.Html.HtmlPage EnclosingPage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlPage>(
               WObj.getEnclosingPage());
         }
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

   }


}
