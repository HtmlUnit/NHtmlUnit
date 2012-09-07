// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSStyleSheet : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSSStyleSheet()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet o) =>
            new CSSStyleSheet(o));
      }

      public CSSStyleSheet(com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet)WrappedObject; }
      }

      public CSSStyleSheet(NHtmlUnit.Javascript.Host.Html.HTMLElement element, NHtmlUnit.W3C.Dom.Css.ICSSStyleSheet wrapped, string uri)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject, (org.w3c.dom.css.CSSStyleSheet)wrapped.WrappedObject, uri)) {}

      public CSSStyleSheet(NHtmlUnit.Javascript.Host.Html.HTMLElement element, org.w3c.css.sac.InputSource source, string uri)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject, source, uri)) {}

      public CSSStyleSheet()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet()) {}


      public System.String Uri
      {
         get
         {
            return WObj.getUri();
         }
      }

      public NHtmlUnit.W3C.Dom.Css.ICSSStyleSheet WrappedSheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.Css.ICSSStyleSheet>(
               WObj.getWrappedSheet());
         }
      }

// Generating method code for jsxGet_ownerNode
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement JsxGet_ownerNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.jsxGet_ownerNode());
      }

// Generating method code for jsxGet_cssRules
      public virtual NHtmlUnit.Javascript.Host.Css.CSSRuleList JsxGet_cssRules()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSRuleList>(WObj.jsxGet_cssRules());
      }

// Generating method code for modifyIfNecessary
      public virtual void ModifyIfNecessary(NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration style, NHtmlUnit.Javascript.Host.Element element)
      {
         WObj.modifyIfNecessary((com.gargoylesoftware.htmlunit.javascript.host.css.ComputedCSSStyleDeclaration)style.WrappedObject, (com.gargoylesoftware.htmlunit.javascript.host.Element)element.WrappedObject);
      }

// Generating method code for parseSelectors
      public virtual org.w3c.css.sac.SelectorList ParseSelectors(org.w3c.css.sac.InputSource source)
      {
         return WObj.parseSelectors(source);
      }

// Generating method code for jsxGet_owningElement
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement JsxGet_owningElement()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.jsxGet_owningElement());
      }

// Generating method code for jsxGet_rules
      public virtual NHtmlUnit.Javascript.Host.Css.CSSRuleList JsxGet_rules()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSRuleList>(WObj.jsxGet_rules());
      }

// Generating method code for jsxGet_href
      public virtual string JsxGet_href()
      {
         return WObj.jsxGet_href();
      }

// Generating method code for jsxFunction_insertRule
      public virtual int JsxFunction_insertRule(string rule, int position)
      {
         return WObj.jsxFunction_insertRule(rule, position);
      }

// Generating method code for jsxFunction_deleteRule
      public virtual void JsxFunction_deleteRule(int position)
      {
         WObj.jsxFunction_deleteRule(position);
      }

// Generating method code for jsxFunction_addRule
      public virtual int JsxFunction_addRule(string selector, string rule)
      {
         return WObj.jsxFunction_addRule(selector, rule);
      }

// Generating method code for jsxFunction_removeRule
      public virtual void JsxFunction_removeRule(int position)
      {
         WObj.jsxFunction_removeRule(position);
      }

// Generating method code for isActive
      public virtual bool IsActive()
      {
         return WObj.isActive();
      }

   }


}
