// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class XPathResult : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XPathResult()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.XPathResult o) =>
            new XPathResult(o));
      }

      public XPathResult(com.gargoylesoftware.htmlunit.javascript.host.XPathResult wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.XPathResult WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.XPathResult)WrappedObject; }
      }

      public XPathResult()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.XPathResult()) {}

// Generating method code for jsxGet_resultType
      public virtual int JsxGet_resultType()
      {
         return WObj.jsxGet_resultType();
      }

// Generating method code for jsxGet_snapshotLength
      public virtual int JsxGet_snapshotLength()
      {
         return WObj.jsxGet_snapshotLength();
      }

// Generating method code for jsxGet_singleNodeValue
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_singleNodeValue()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_singleNodeValue());
      }

// Generating method code for jsxFunction_iterateNext
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_iterateNext()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_iterateNext());
      }

// Generating method code for jsxFunction_snapshotItem
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_snapshotItem(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_snapshotItem(index));
      }

// Generating method code for jsxGet_numberValue
      public virtual System.Double JsxGet_numberValue()
      {
         return WObj.jsxGet_numberValue();
      }

// Generating method code for jsxGet_booleanValue
      public virtual bool JsxGet_booleanValue()
      {
         return WObj.jsxGet_booleanValue();
      }

// Generating method code for jsxGet_stringValue
      public virtual string JsxGet_stringValue()
      {
         return WObj.jsxGet_stringValue();
      }

   }


}
