// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class SimpleScriptable : NHtmlUnit.Javascript.HtmlUnitScriptable
   {
      static SimpleScriptable()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable o) =>
            new SimpleScriptable(o));
      }

      public SimpleScriptable(com.gargoylesoftware.htmlunit.javascript.SimpleScriptable wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.SimpleScriptable WObj
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


      public NHtmlUnit.BrowserVersion BrowserVersion
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
               WObj.getBrowserVersion());
         }
      }

// Generating method code for makeScriptableFor
      public virtual NHtmlUnit.Javascript.SimpleScriptable MakeScriptableFor(NHtmlUnit.Html.DomNode domNode)
      {
         var arg = WObj.makeScriptableFor((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.SimpleScriptable>(arg);
      }

// Generating method code for getPrototype
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable GetPrototype(java.lang.Class javaScriptClass)
      {
         return WObj.getPrototype(javaScriptClass);
      }

// Generating method code for clone
      public virtual NHtmlUnit.Javascript.SimpleScriptable Clone()
      {
         var arg = WObj.clone();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.SimpleScriptable>(arg);
      }

   }


}
