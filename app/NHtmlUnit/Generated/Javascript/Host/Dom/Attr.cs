// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Attr : NHtmlUnit.Javascript.Host.Dom.Node
   {
      static Attr()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Attr o) =>
            new Attr(o));
      }

      public Attr(com.gargoylesoftware.htmlunit.javascript.host.dom.Attr wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Attr WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Attr)WrappedObject; }
      }

      public Attr()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Attr()) {}


      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public System.Object OwnerElement
      {
         get
         {
            return WObj.getOwnerElement();
         }
      }

      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
         set
         {
            WObj.setValue(value);
         }

      }
// Generating method code for detachFromParent
      public virtual void DetachFromParent()
      {
         WObj.detachFromParent();
      }

// Generating method code for isExpando
      public virtual bool IsExpando()
      {
         return WObj.isExpando();
      }

// Generating method code for isSpecified
      public virtual bool IsSpecified()
      {
         return WObj.isSpecified();
      }

   }


}
