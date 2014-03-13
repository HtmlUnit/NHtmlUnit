// Generated class v2.14.0.0, don't modify

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

      public NHtmlUnit.Javascript.Host.Node SingleNodeValue
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
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
      public virtual NHtmlUnit.Javascript.Host.Node IterateNext()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.iterateNext());
      }

// Generating method code for snapshotItem
      public virtual NHtmlUnit.Javascript.Host.Node SnapshotItem(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.snapshotItem(index));
      }

   }


}
