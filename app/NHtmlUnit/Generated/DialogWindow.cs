// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class DialogWindow : NHtmlUnit.WebWindowImpl, NHtmlUnit.IWebWindow
   {
      static DialogWindow()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.DialogWindow o) =>
            new DialogWindow(o));
      }

      public DialogWindow(com.gargoylesoftware.htmlunit.DialogWindow wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.DialogWindow WObj
      {
         get { return (com.gargoylesoftware.htmlunit.DialogWindow)WrappedObject; }
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

   }


}
