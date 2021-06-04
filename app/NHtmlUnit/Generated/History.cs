// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class History : ObjectWrapper
   {
      static History()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.History o) =>
            new History(o));
      }

      public History(com.gargoylesoftware.htmlunit.History wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.History WObj
      {
         get { return (com.gargoylesoftware.htmlunit.History)WrappedObject; }
      }

      public History(NHtmlUnit.IWebWindow window)
         : this(new com.gargoylesoftware.htmlunit.History((com.gargoylesoftware.htmlunit.WebWindow)window.WrappedObject)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }

      public System.Int32 Index
      {
         get
         {
            return WObj.getIndex();
         }
      }

      public System.Object CurrentState
      {
         get
         {
            return WObj.getCurrentState();
         }
      }
// Generating method code for getUrl
      public virtual java.net.URL GetUrl(int index)
      {
         return WObj.getUrl(index);
      }

// Generating method code for back
      public virtual NHtmlUnit.History Back()
      {
         var arg = WObj.back();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.History>(arg);
      }

// Generating method code for forward
      public virtual NHtmlUnit.History Forward()
      {
         var arg = WObj.forward();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.History>(arg);
      }

// Generating method code for go
      public virtual NHtmlUnit.History Go(int relativeIndex)
      {
         var arg = WObj.go(relativeIndex);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.History>(arg);
      }

// Generating method code for removeCurrent
      public virtual void RemoveCurrent()
      {
         WObj.removeCurrent();
      }

// Generating method code for replaceState
      public virtual void ReplaceState(object state, java.net.URL url)
      {
         WObj.replaceState(state, url);
      }

// Generating method code for pushState
      public virtual void PushState(object state, java.net.URL url)
      {
         WObj.pushState(state, url);
      }

   }


}
