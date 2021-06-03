// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFrameSetElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLFrameSetElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement o) =>
            new HTMLFrameSetElement(o));
      }

      public HTMLFrameSetElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement)WrappedObject; }
      }

      public HTMLFrameSetElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement()) {}


      public System.String Rows
      {
         get
         {
            return WObj.getRows();
         }
         set
         {
            WObj.setRows(value);
         }

      }

      public System.String Cols
      {
         get
         {
            return WObj.getCols();
         }
         set
         {
            WObj.setCols(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
         }

      }
// Generating method code for getOnbeforeunload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforeunload()
      {
         return WObj.getOnbeforeunload();
      }

// Generating method code for setOnbeforeunload
      public virtual void SetOnbeforeunload(object beforeunload)
      {
         WObj.setOnbeforeunload(beforeunload);
      }

// Generating method code for getOnhashchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnhashchange()
      {
         return WObj.getOnhashchange();
      }

// Generating method code for setOnhashchange
      public virtual void SetOnhashchange(object hashchange)
      {
         WObj.setOnhashchange(hashchange);
      }

// Generating method code for getOnlanguagechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnlanguagechange()
      {
         return WObj.getOnlanguagechange();
      }

// Generating method code for setOnlanguagechange
      public virtual void SetOnlanguagechange(object languagechange)
      {
         WObj.setOnlanguagechange(languagechange);
      }

// Generating method code for getOnmessage
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmessage()
      {
         return WObj.getOnmessage();
      }

// Generating method code for setOnmessage
      public virtual void SetOnmessage(object message)
      {
         WObj.setOnmessage(message);
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

// Generating method code for getOnoffline
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnoffline()
      {
         return WObj.getOnoffline();
      }

// Generating method code for setOnoffline
      public virtual void SetOnoffline(object offline)
      {
         WObj.setOnoffline(offline);
      }

// Generating method code for getOnonline
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnonline()
      {
         return WObj.getOnonline();
      }

// Generating method code for setOnonline
      public virtual void SetOnonline(object online)
      {
         WObj.setOnonline(online);
      }

// Generating method code for getOnpagehide
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpagehide()
      {
         return WObj.getOnpagehide();
      }

// Generating method code for setOnpagehide
      public virtual void SetOnpagehide(object pagehide)
      {
         WObj.setOnpagehide(pagehide);
      }

// Generating method code for getOnpageshow
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpageshow()
      {
         return WObj.getOnpageshow();
      }

// Generating method code for setOnpageshow
      public virtual void SetOnpageshow(object pageshow)
      {
         WObj.setOnpageshow(pageshow);
      }

// Generating method code for getOnpopstate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpopstate()
      {
         return WObj.getOnpopstate();
      }

// Generating method code for setOnpopstate
      public virtual void SetOnpopstate(object popstate)
      {
         WObj.setOnpopstate(popstate);
      }

// Generating method code for getOnrejectionhandled
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnrejectionhandled()
      {
         return WObj.getOnrejectionhandled();
      }

// Generating method code for setOnrejectionhandled
      public virtual void SetOnrejectionhandled(object rejectionhandled)
      {
         WObj.setOnrejectionhandled(rejectionhandled);
      }

// Generating method code for getOnstorage
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstorage()
      {
         return WObj.getOnstorage();
      }

// Generating method code for setOnstorage
      public virtual void SetOnstorage(object storage)
      {
         WObj.setOnstorage(storage);
      }

// Generating method code for getOnunhandledrejection
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnunhandledrejection()
      {
         return WObj.getOnunhandledrejection();
      }

// Generating method code for setOnunhandledrejection
      public virtual void SetOnunhandledrejection(object unhandledrejection)
      {
         WObj.setOnunhandledrejection(unhandledrejection);
      }

// Generating method code for getOnunload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnunload()
      {
         return WObj.getOnunload();
      }

// Generating method code for setOnunload
      public virtual void SetOnunload(object unload)
      {
         WObj.setOnunload(unload);
      }

// Generating method code for getOnafterprint
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnafterprint()
      {
         return WObj.getOnafterprint();
      }

// Generating method code for setOnafterprint
      public virtual void SetOnafterprint(object afterprint)
      {
         WObj.setOnafterprint(afterprint);
      }

// Generating method code for getOnbeforeprint
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforeprint()
      {
         return WObj.getOnbeforeprint();
      }

// Generating method code for setOnbeforeprint
      public virtual void SetOnbeforeprint(object beforeprint)
      {
         WObj.setOnbeforeprint(beforeprint);
      }

   }


}
