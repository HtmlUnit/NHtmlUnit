// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class XPathEvaluator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XPathEvaluator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.XPathEvaluator o) =>
            new XPathEvaluator(o));
      }

      public XPathEvaluator(com.gargoylesoftware.htmlunit.javascript.host.dom.XPathEvaluator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.XPathEvaluator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.XPathEvaluator)WrappedObject; }
      }

      public XPathEvaluator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.XPathEvaluator()) {}

// Generating method code for createNSResolver
      public virtual NHtmlUnit.Javascript.Host.Dom.XPathNSResolver CreateNSResolver(NHtmlUnit.Javascript.Host.Dom.Node nodeResolver)
      {
         var arg = WObj.createNSResolver((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)nodeResolver.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.XPathNSResolver>(arg);
      }

// Generating method code for evaluate
      public virtual NHtmlUnit.Javascript.Host.Dom.XPathResult Evaluate(string expression, object contextNodeObj, object resolver, int type, object result)
      {
         var arg = WObj.evaluate(expression, contextNodeObj, resolver, type, result);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.XPathResult>(arg);
      }

   }


}
