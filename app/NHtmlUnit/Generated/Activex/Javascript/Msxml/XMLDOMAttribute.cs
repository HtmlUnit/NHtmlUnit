// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMAttribute : NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode
   {
      static XMLDOMAttribute()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMAttribute o) =>
            new XMLDOMAttribute(o));
      }

      public XMLDOMAttribute(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMAttribute wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMAttribute WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMAttribute)WrappedObject; }
      }

      public XMLDOMAttribute()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMAttribute()) {}


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

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }
// Generating method code for isSpecified
      public virtual bool IsSpecified()
      {
         return WObj.isSpecified();
      }

// Generating method code for detachFromParent
      public virtual void DetachFromParent()
      {
         WObj.detachFromParent();
      }

   }


}
