// Generated class v2.13, don't modify

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


      public NHtmlUnit.Javascript.Host.Html.HTMLElement OwnerNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getOwnerNode());
         }
      }


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


      public NHtmlUnit.Javascript.Host.Css.CSSRuleList CssRules
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSRuleList>(
               WObj.getCssRules());
         }
      }


      public NHtmlUnit.Javascript.Host.Html.HTMLElement OwningElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getOwningElement());
         }
      }


      public NHtmlUnit.Javascript.Host.Css.CSSRuleList Rules
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSRuleList>(
               WObj.getRules());
         }
      }


      public System.String Href
      {
         get
         {
            return WObj.getHref();
         }
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

// Generating method code for insertRule
      public virtual int InsertRule(string rule, int position)
      {
         return WObj.insertRule(rule, position);
      }

// Generating method code for deleteRule
      public virtual void DeleteRule(int position)
      {
         WObj.deleteRule(position);
      }

// Generating method code for addRule
      public virtual int AddRule(string selector, string rule)
      {
         return WObj.addRule(selector, rule);
      }

// Generating method code for removeRule
      public virtual void RemoveRule(int position)
      {
         WObj.removeRule(position);
      }

// Generating method code for isActive
      public virtual bool IsActive()
      {
         return WObj.isActive();
      }

   }


}
