// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class EventNode : NHtmlUnit.Javascript.Host.Dom.Node
   {
      static EventNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.EventNode o) =>
            new EventNode(o));
      }

      public EventNode(com.gargoylesoftware.htmlunit.javascript.host.dom.EventNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.EventNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.EventNode)WrappedObject; }
      }

      public EventNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.EventNode()) {}


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

      public System.Object Onfocus
      {
         get
         {
            return WObj.getOnfocus();
         }
         set
         {
            WObj.setOnfocus(value);
         }

      }

      public System.Object Onfocusin
      {
         get
         {
            return WObj.getOnfocusin();
         }
         set
         {
            WObj.setOnfocusin(value);
         }

      }

      public System.Object Onfocusout
      {
         get
         {
            return WObj.getOnfocusout();
         }
         set
         {
            WObj.setOnfocusout(value);
         }

      }

      public System.Object Onkeydown
      {
         get
         {
            return WObj.getOnkeydown();
         }
         set
         {
            WObj.setOnkeydown(value);
         }

      }

      public System.Object Onkeypress
      {
         get
         {
            return WObj.getOnkeypress();
         }
         set
         {
            WObj.setOnkeypress(value);
         }

      }

      public System.Object Onkeyup
      {
         get
         {
            return WObj.getOnkeyup();
         }
         set
         {
            WObj.setOnkeyup(value);
         }

      }

      public System.Object Onmousedown
      {
         get
         {
            return WObj.getOnmousedown();
         }
         set
         {
            WObj.setOnmousedown(value);
         }

      }

      public System.Object Onmousemove
      {
         get
         {
            return WObj.getOnmousemove();
         }
         set
         {
            WObj.setOnmousemove(value);
         }

      }

      public System.Object Onmouseout
      {
         get
         {
            return WObj.getOnmouseout();
         }
         set
         {
            WObj.setOnmouseout(value);
         }

      }

      public System.Object Onmouseover
      {
         get
         {
            return WObj.getOnmouseover();
         }
         set
         {
            WObj.setOnmouseover(value);
         }

      }

      public System.Object Onmouseup
      {
         get
         {
            return WObj.getOnmouseup();
         }
         set
         {
            WObj.setOnmouseup(value);
         }

      }

      public System.Object Oncontextmenu
      {
         get
         {
            return WObj.getOncontextmenu();
         }
         set
         {
            WObj.setOncontextmenu(value);
         }

      }

      public System.Object Onresize
      {
         get
         {
            return WObj.getOnresize();
         }
         set
         {
            WObj.setOnresize(value);
         }

      }

      public System.Object Onpropertychange
      {
         get
         {
            return WObj.getOnpropertychange();
         }
         set
         {
            WObj.setOnpropertychange(value);
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
// Generating method code for fireEvent
      public virtual bool FireEvent(string type, NHtmlUnit.Javascript.Host.Events.Event eventArg)
      {
         return WObj.fireEvent(type, (com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject);
      }

// Generating method code for getOninput
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOninput()
      {
         return WObj.getOninput();
      }

// Generating method code for setOninput
      public virtual void SetOninput(object onchange)
      {
         WObj.setOninput(onchange);
      }

   }


}
