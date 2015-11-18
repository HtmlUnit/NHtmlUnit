// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class XPathResult : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XPathResult()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.XPathResult o) =>
            new XPathResult(o));
      }

      public XPathResult(com.gargoylesoftware.htmlunit.javascript.host.dom.XPathResult wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.XPathResult WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.XPathResult)WrappedObject; }
      }

      public XPathResult()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.XPathResult()) {}


      public System.Int32 ResultType
      {
         get
         {
            return WObj.getResultType();
         }
      }

      public System.Int32 SnapshotLength
      {
         get
         {
            return WObj.getSnapshotLength();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.Node SingleNodeValue
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getSingleNodeValue());
         }
      }


      public System.Double NumberValue
      {
         get
         {
            return WObj.getNumberValue();
         }
      }

      public System.Boolean BooleanValue
      {
         get
         {
            return WObj.getBooleanValue();
         }
      }

      public System.String StringValue
      {
         get
         {
            return WObj.getStringValue();
         }
      }
// Generating method code for iterateNext
      public virtual NHtmlUnit.Javascript.Host.Dom.Node IterateNext()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(WObj.iterateNext());
      }

// Generating method code for snapshotItem
      public virtual NHtmlUnit.Javascript.Host.Dom.Node SnapshotItem(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(WObj.snapshotItem(index));
      }

   }


}
