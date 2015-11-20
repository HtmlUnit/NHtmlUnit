// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class UIEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static UIEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.UIEvent o) =>
            new UIEvent(o));
      }

      public UIEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.UIEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.UIEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.UIEvent)WrappedObject; }
      }

      public UIEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.UIEvent()) {}

      public UIEvent(NHtmlUnit.Html.DomNode domNode, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.UIEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type)) {}

      public UIEvent(NHtmlUnit.Javascript.SimpleScriptable scriptable, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.UIEvent((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)scriptable.WrappedObject, type)) {}


      public System.Int64 Detail
      {
         get
         {
            return WObj.getDetail();
         }
      }

      public System.Object View
      {
         get
         {
            return WObj.getView();
         }
      }

      public System.Boolean MetaKey
      {
         get
         {
            return WObj.getMetaKey();
         }
      }
// Generating method code for initUIEvent
      public virtual void InitUIEvent(string type, bool bubbles, bool cancelable, object view, int detail)
      {
         WObj.initUIEvent(type, bubbles, cancelable, view, detail);
      }

   }


}
