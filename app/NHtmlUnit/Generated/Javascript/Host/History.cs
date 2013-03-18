// Generated class v5, don't modify

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

      public System.String Current
      {
         get
         {
            return WObj.getCurrent();
         }
      }

      public System.String Previous
      {
         get
         {
            return WObj.getPrevious();
         }
      }

      public System.String Next
      {
         get
         {
            return WObj.getNext();
         }
      }
// Generating method code for item
      public virtual string Item(int index)
      {
         return WObj.item(index);
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

   }


}
