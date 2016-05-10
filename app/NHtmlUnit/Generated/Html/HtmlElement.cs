// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlElement : NHtmlUnit.Html.DomElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlElement o) =>
            new HtmlElement(o));
      }

      public HtmlElement(com.gargoylesoftware.htmlunit.html.HtmlElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlElement)WrappedObject; }
      }


      public NHtmlUnit.Html.HtmlForm EnclosingForm
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlForm>(
               WObj.getEnclosingForm());
         }
      }


      public java.lang.Short TabIndex
      {
         get
         {
            return WObj.getTabIndex();
         }
      }

      public NHtmlUnit.Html.HtmlForm EnclosingFormOrDie
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlForm>(
               WObj.getEnclosingFormOrDie());
         }
      }


      public System.String LangAttribute
      {
         get
         {
            return WObj.getLangAttribute();
         }
      }

      public System.String XmlLangAttribute
      {
         get
         {
            return WObj.getXmlLangAttribute();
         }
      }

      public System.String TextDirectionAttribute
      {
         get
         {
            return WObj.getTextDirectionAttribute();
         }
      }

      public System.String OnClickAttribute
      {
         get
         {
            return WObj.getOnClickAttribute();
         }
      }

      public System.String OnDblClickAttribute
      {
         get
         {
            return WObj.getOnDblClickAttribute();
         }
      }

      public System.String OnMouseDownAttribute
      {
         get
         {
            return WObj.getOnMouseDownAttribute();
         }
      }

      public System.String OnMouseUpAttribute
      {
         get
         {
            return WObj.getOnMouseUpAttribute();
         }
      }

      public System.String OnMouseOverAttribute
      {
         get
         {
            return WObj.getOnMouseOverAttribute();
         }
      }

      public System.String OnMouseMoveAttribute
      {
         get
         {
            return WObj.getOnMouseMoveAttribute();
         }
      }

      public System.String OnMouseOutAttribute
      {
         get
         {
            return WObj.getOnMouseOutAttribute();
         }
      }

      public System.String OnKeyPressAttribute
      {
         get
         {
            return WObj.getOnKeyPressAttribute();
         }
      }

      public System.String OnKeyDownAttribute
      {
         get
         {
            return WObj.getOnKeyDownAttribute();
         }
      }

      public System.String OnKeyUpAttribute
      {
         get
         {
            return WObj.getOnKeyUpAttribute();
         }
      }
// Generating method code for addHtmlAttributeChangeListener
      public virtual void AddHtmlAttributeChangeListener(NHtmlUnit.Html.IHtmlAttributeChangeListener listener)
      {
         WObj.addHtmlAttributeChangeListener((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeListener)listener.WrappedObject);
      }

// Generating method code for getHtmlElementsByTagName
      public virtual IList<System.Object> GetHtmlElementsByTagName(string tagName)
      {

return new ShallowListWrapper<System.Object>(WObj.getHtmlElementsByTagName(tagName));
      }

// Generating method code for getEnclosingElement
      public virtual NHtmlUnit.Html.HtmlElement GetEnclosingElement(string tagName)
      {
         var arg = WObj.getEnclosingElement(tagName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for type
      public virtual NHtmlUnit.IPage Type(System.Char c)
      {
         var arg = WObj.type(c);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for getElementsByAttribute
      public virtual IList<System.Object> GetElementsByAttribute(string elementName, string attributeName, string attributeValue)
      {

return new ShallowListWrapper<System.Object>(WObj.getElementsByAttribute(elementName, attributeName, attributeValue));
      }

// Generating method code for setEventHandler
      public virtual void SetEventHandler(string eventName, net.sourceforge.htmlunit.corejs.javascript.Function eventHandler)
      {
         WObj.setEventHandler(eventName, eventHandler);
      }

// Generating method code for getHtmlElementsByTagNames
      public virtual IList<NHtmlUnit.Html.HtmlElement> GetHtmlElementsByTagNames(java.util.List tagNames)
      {

return new ListWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getHtmlElementsByTagNames(tagNames));
      }

// Generating method code for type
      public virtual void Type(string text)
      {
         WObj.type(text);
      }

// Generating method code for type
      public virtual NHtmlUnit.IPage Type(int keyCode)
      {
         var arg = WObj.type(keyCode);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for type
      public virtual NHtmlUnit.IPage Type(NHtmlUnit.Html.Keyboard keyboard)
      {
         var arg = WObj.type((com.gargoylesoftware.htmlunit.html.Keyboard)keyboard.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for getOneHtmlElementByAttribute
      public virtual NHtmlUnit.Html.HtmlElement GetOneHtmlElementByAttribute(string elementName, string attributeName, string attributeValue)
      {
         var arg = WObj.getOneHtmlElementByAttribute(elementName, attributeName, attributeValue);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for appendChildIfNoneExists
      public virtual NHtmlUnit.Html.HtmlElement AppendChildIfNoneExists(string tagName)
      {
         var arg = WObj.appendChildIfNoneExists(tagName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(arg);
      }

// Generating method code for removeChild
      public virtual void RemoveChild(string tagName, int i)
      {
         WObj.removeChild(tagName, i);
      }

// Generating method code for hasEventHandlers
      public virtual bool HasEventHandlers(string eventName)
      {
         return WObj.hasEventHandlers(eventName);
      }

// Generating method code for setEventHandler
      public virtual void SetEventHandler(string eventName, string jsSnippet)
      {
         WObj.setEventHandler(eventName, jsSnippet);
      }

// Generating method code for removeEventHandler
      public virtual void RemoveEventHandler(string eventName)
      {
         WObj.removeEventHandler(eventName);
      }

// Generating method code for removeHtmlAttributeChangeListener
      public virtual void RemoveHtmlAttributeChangeListener(NHtmlUnit.Html.IHtmlAttributeChangeListener listener)
      {
         WObj.removeHtmlAttributeChangeListener((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeListener)listener.WrappedObject);
      }

   }


}
