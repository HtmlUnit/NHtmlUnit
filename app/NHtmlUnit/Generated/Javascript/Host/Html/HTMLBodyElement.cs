// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBodyElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLBodyElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement o) =>
            new HTMLBodyElement(o));
      }

      public HTMLBodyElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement)WrappedObject; }
      }

      public HTMLBodyElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement()) {}


      public System.String ALink
      {
         get
         {
            return WObj.getALink();
         }
         set
         {
            WObj.setALink(value);
         }

      }

      public System.String BgColor
      {
         get
         {
            return WObj.getBgColor();
         }
         set
         {
            WObj.setBgColor(value);
         }

      }

      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
         }

      }

      public System.String Link
      {
         get
         {
            return WObj.getLink();
         }
         set
         {
            WObj.setLink(value);
         }

      }

      public System.String VLink
      {
         get
         {
            return WObj.getVLink();
         }
         set
         {
            WObj.setVLink(value);
         }

      }

      public System.String Background
      {
         get
         {
            return WObj.getBackground();
         }
         set
         {
            WObj.setBackground(value);
         }

      }
// Generating method code for createEventHandlerFromAttribute
      public virtual void CreateEventHandlerFromAttribute(string attributeName, string value)
      {
         WObj.createEventHandlerFromAttribute(attributeName, value);
      }

// Generating method code for createTextRange
      public virtual NHtmlUnit.Javascript.Host.Dom.TextRange CreateTextRange()
      {
         var arg = WObj.createTextRange();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.TextRange>(arg);
      }

// Generating method code for getOnbeforeunload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforeunload()
      {
         return WObj.getOnbeforeunload();
      }

// Generating method code for setOnbeforeunload
      public virtual void SetOnbeforeunload(object onbeforeunload)
      {
         WObj.setOnbeforeunload(onbeforeunload);
      }

// Generating method code for getOnhashchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnhashchange()
      {
         return WObj.getOnhashchange();
      }

// Generating method code for setOnhashchange
      public virtual void SetOnhashchange(object onhashchange)
      {
         WObj.setOnhashchange(onhashchange);
      }

// Generating method code for getOnlanguagechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnlanguagechange()
      {
         return WObj.getOnlanguagechange();
      }

// Generating method code for setOnlanguagechange
      public virtual void SetOnlanguagechange(object onlanguagechange)
      {
         WObj.setOnlanguagechange(onlanguagechange);
      }

// Generating method code for getOnmessage
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmessage()
      {
         return WObj.getOnmessage();
      }

// Generating method code for setOnmessage
      public virtual void SetOnmessage(object onmessage)
      {
         WObj.setOnmessage(onmessage);
      }

// Generating method code for getOnoffline
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnoffline()
      {
         return WObj.getOnoffline();
      }

// Generating method code for setOnoffline
      public virtual void SetOnoffline(object onoffline)
      {
         WObj.setOnoffline(onoffline);
      }

// Generating method code for getOnonline
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnonline()
      {
         return WObj.getOnonline();
      }

// Generating method code for setOnonline
      public virtual void SetOnonline(object ononline)
      {
         WObj.setOnonline(ononline);
      }

// Generating method code for getOnpagehide
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpagehide()
      {
         return WObj.getOnpagehide();
      }

// Generating method code for setOnpagehide
      public virtual void SetOnpagehide(object onpagehide)
      {
         WObj.setOnpagehide(onpagehide);
      }

// Generating method code for getOnpageshow
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpageshow()
      {
         return WObj.getOnpageshow();
      }

// Generating method code for setOnpageshow
      public virtual void SetOnpageshow(object onpageshow)
      {
         WObj.setOnpageshow(onpageshow);
      }

// Generating method code for getOnpopstate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpopstate()
      {
         return WObj.getOnpopstate();
      }

// Generating method code for setOnpopstate
      public virtual void SetOnpopstate(object onpopstate)
      {
         WObj.setOnpopstate(onpopstate);
      }

// Generating method code for getOnrejectionhandled
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnrejectionhandled()
      {
         return WObj.getOnrejectionhandled();
      }

// Generating method code for setOnrejectionhandled
      public virtual void SetOnrejectionhandled(object onrejectionhandled)
      {
         WObj.setOnrejectionhandled(onrejectionhandled);
      }

// Generating method code for getOnstorage
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstorage()
      {
         return WObj.getOnstorage();
      }

// Generating method code for setOnstorage
      public virtual void SetOnstorage(object onstorage)
      {
         WObj.setOnstorage(onstorage);
      }

// Generating method code for getOnunhandledrejection
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnunhandledrejection()
      {
         return WObj.getOnunhandledrejection();
      }

// Generating method code for setOnunhandledrejection
      public virtual void SetOnunhandledrejection(object onunhandledrejection)
      {
         WObj.setOnunhandledrejection(onunhandledrejection);
      }

// Generating method code for getOnunload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnunload()
      {
         return WObj.getOnunload();
      }

// Generating method code for setOnunload
      public virtual void SetOnunload(object onunload)
      {
         WObj.setOnunload(onunload);
      }

// Generating method code for getOnafterprint
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnafterprint()
      {
         return WObj.getOnafterprint();
      }

// Generating method code for setOnafterprint
      public virtual void SetOnafterprint(object onafterprint)
      {
         WObj.setOnafterprint(onafterprint);
      }

// Generating method code for getOnbeforeprint
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforeprint()
      {
         return WObj.getOnbeforeprint();
      }

// Generating method code for setOnbeforeprint
      public virtual void SetOnbeforeprint(object onbeforeprint)
      {
         WObj.setOnbeforeprint(onbeforeprint);
      }

// Generating method code for getOnmessageerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmessageerror()
      {
         return WObj.getOnmessageerror();
      }

// Generating method code for setOnmessageerror
      public virtual void SetOnmessageerror(object onmessageerror)
      {
         WObj.setOnmessageerror(onmessageerror);
      }

   }


}
