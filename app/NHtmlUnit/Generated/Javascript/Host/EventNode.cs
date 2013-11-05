// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class EventNode : NHtmlUnit.Javascript.Host.Node
   {
      static EventNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.EventNode o) =>
            new EventNode(o));
      }

      public EventNode(com.gargoylesoftware.htmlunit.javascript.host.EventNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.EventNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.EventNode)WrappedObject; }
      }

      public EventNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.EventNode()) {}


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
      public virtual bool FireEvent(string type, NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return WObj.fireEvent(type, (com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject);
      }

   }


}
