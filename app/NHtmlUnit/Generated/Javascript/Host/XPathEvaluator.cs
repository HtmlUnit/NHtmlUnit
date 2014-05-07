// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class XPathEvaluator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XPathEvaluator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.XPathEvaluator o) =>
            new XPathEvaluator(o));
      }

      public XPathEvaluator(com.gargoylesoftware.htmlunit.javascript.host.XPathEvaluator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.XPathEvaluator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.XPathEvaluator)WrappedObject; }
      }

      public XPathEvaluator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.XPathEvaluator()) {}

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for createNSResolver
      public virtual NHtmlUnit.Javascript.Host.XPathNSResolver CreateNSResolver(NHtmlUnit.Javascript.Host.Node nodeResolver)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XPathNSResolver>(WObj.createNSResolver((com.gargoylesoftware.htmlunit.javascript.host.Node)nodeResolver.WrappedObject));
      }

// Generating method code for evaluate
      public virtual NHtmlUnit.Javascript.Host.XPathResult Evaluate(string expression, object contextNodeObj, object resolver, int type, object result)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XPathResult>(WObj.evaluate(expression, contextNodeObj, resolver, type, result));
      }

   }


}
