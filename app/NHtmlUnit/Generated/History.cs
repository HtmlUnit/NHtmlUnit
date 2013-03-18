// Generated class v5, don't modify

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
// Generating method code for back
      public virtual NHtmlUnit.History Back()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.History>(WObj.back());
      }

// Generating method code for forward
      public virtual NHtmlUnit.History Forward()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.History>(WObj.forward());
      }

// Generating method code for go
      public virtual NHtmlUnit.History Go(int relativeIndex)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.History>(WObj.go(relativeIndex));
      }

// Generating method code for removeCurrent
      public virtual void RemoveCurrent()
      {
         WObj.removeCurrent();
      }

// Generating method code for getUrl
      public virtual java.net.URL GetUrl(int index)
      {
         return WObj.getUrl(index);
      }

   }


}
