// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Popup : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Popup()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Popup o) =>
            new Popup(o));
      }

      public Popup(com.gargoylesoftware.htmlunit.javascript.host.Popup wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Popup WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Popup)WrappedObject; }
      }

      public Popup()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Popup()) {}


      public System.Object Document
      {
         get
         {
            return WObj.getDocument();
         }
      }

      public System.Boolean IsOpen
      {
         get
         {
            return WObj.getIsOpen();
         }
      }
// Generating method code for hide
      public virtual void Hide()
      {
         WObj.hide();
      }

// Generating method code for show
      public virtual void Show()
      {
         WObj.show();
      }

   }


}
