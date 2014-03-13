// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class SimpleScriptable : ObjectWrapper
   {
      static SimpleScriptable()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable o) =>
            new SimpleScriptable(o));
      }

      public SimpleScriptable(com.gargoylesoftware.htmlunit.javascript.SimpleScriptable wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.SimpleScriptable WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)WrappedObject; }
      }

      public SimpleScriptable()
         : this(new com.gargoylesoftware.htmlunit.javascript.SimpleScriptable()) {}


      public NHtmlUnit.Javascript.Host.Window Window
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Window>(
               WObj.getWindow());
         }
      }


      public NHtmlUnit.BrowserVersion BrowserVersion
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
               WObj.getBrowserVersion());
         }
      }


      public NHtmlUnit.Html.DomNode DomNodeOrNull
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getDomNodeOrNull());
         }
      }


      public NHtmlUnit.Html.DomNode DomNodeOrDie
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getDomNodeOrDie());
         }
      }

// Generating method code for makeScriptableFor
      public virtual NHtmlUnit.Javascript.SimpleScriptable MakeScriptableFor(NHtmlUnit.Html.DomNode domNode)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.SimpleScriptable>(WObj.makeScriptableFor((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject));
      }

// Generating method code for clone
      public virtual NHtmlUnit.Javascript.SimpleScriptable Clone()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.SimpleScriptable>(WObj.clone());
      }

   }


}
