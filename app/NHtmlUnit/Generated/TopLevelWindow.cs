// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class TopLevelWindow : NHtmlUnit.WebWindowImpl, NHtmlUnit.IWebWindow
   {
      static TopLevelWindow()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.TopLevelWindow o) =>
            new TopLevelWindow(o));
      }

      public TopLevelWindow(com.gargoylesoftware.htmlunit.TopLevelWindow wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.TopLevelWindow WObj
      {
         get { return (com.gargoylesoftware.htmlunit.TopLevelWindow)WrappedObject; }
      }


      public NHtmlUnit.IWebWindow Opener
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(
               WObj.getOpener());
         }
         set
         {
            WObj.setOpener((com.gargoylesoftware.htmlunit.WebWindow)value.WrappedObject);
         }

      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

   }


}
