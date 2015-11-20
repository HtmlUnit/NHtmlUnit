// Generated class v2.19.0.0, don't modify

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

      public System.Boolean IsId
      {
         get
         {
            return WObj.getIsId();
         }
      }

      public System.Boolean Expando
      {
         get
         {
            return WObj.getExpando();
         }
      }

      public System.Boolean Specified
      {
         get
         {
            return WObj.getSpecified();
         }
      }

      public System.String BaseURI
      {
         get
         {
            return WObj.getBaseURI();
         }
      }
// Generating method code for detachFromParent
      public virtual void DetachFromParent()
      {
         WObj.detachFromParent();
      }

   }


}
