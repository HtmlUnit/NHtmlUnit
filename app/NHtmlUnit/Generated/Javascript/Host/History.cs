// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class History : NHtmlUnit.Javascript.SimpleScriptable
   {
      static History()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.History o) =>
            new History(o));
      }

      public History(com.gargoylesoftware.htmlunit.javascript.host.History wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.History WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.History)WrappedObject; }
      }

      public History()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.History()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }

      public System.Object State
      {
         get
         {
            return WObj.getState();
         }
      }

      public System.String ScrollRestoration
      {
         get
         {
            return WObj.getScrollRestoration();
         }
         set
         {
            WObj.setScrollRestoration(value);
         }

      }
// Generating method code for back
      public virtual void Back()
      {
         WObj.back();
      }

// Generating method code for forward
      public virtual void Forward()
      {
         WObj.forward();
      }

// Generating method code for go
      public virtual void Go(int relativeIndex)
      {
         WObj.go(relativeIndex);
      }

// Generating method code for replaceState
      public virtual void ReplaceState(object objectArg, string title, string url)
      {
         WObj.replaceState(objectArg, title, url);
      }

// Generating method code for pushState
      public virtual void PushState(object objectArg, string title, string url)
      {
         WObj.pushState(objectArg, title, url);
      }

   }


}
