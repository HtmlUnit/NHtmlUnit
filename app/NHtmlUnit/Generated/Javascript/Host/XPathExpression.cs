// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class XPathExpression : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XPathExpression()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.XPathExpression o) =>
            new XPathExpression(o));
      }

      public XPathExpression(com.gargoylesoftware.htmlunit.javascript.host.XPathExpression wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.XPathExpression WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.XPathExpression)WrappedObject; }
      }

      public XPathExpression()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.XPathExpression()) {}

   }


}
