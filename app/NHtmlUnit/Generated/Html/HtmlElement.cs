// Generated class v2.14.0.0, don't modify

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

// Generating method code for fireEvent
      public virtual NHtmlUnit.ScriptResult FireEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.fireEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject));
      }

// Generating method code for getHtmlElementsByTagName
      public virtual IList<System.Object> GetHtmlElementsByTagName(string tagName)
      {

         return new ShallowListWrapper<System.Object>(WObj.getHtmlElementsByTagName(tagName));
      }

// Generating method code for getEnclosingElement
      public virtual NHtmlUnit.Html.HtmlElement GetEnclosingElement(string tagName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getEnclosingElement(tagName));
      }

// Generating method code for type
      public virtual NHtmlUnit.IPage Type(System.Char c)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.type(c));
      }

// Generating method code for type
      public virtual NHtmlUnit.IPage Type(System.Char c, bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.type(c, shiftKey, ctrlKey, altKey));
      }

// Generating method code for focus
      public virtual void Focus()
      {
         WObj.focus();
      }

// Generating method code for click
      public virtual NHtmlUnit.IPage Click()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.click());
      }

// Generating method code for type
      public virtual NHtmlUnit.IPage Type(int keyCode, bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.type(keyCode, shiftKey, ctrlKey, altKey));
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

// Generating method code for mouseOver
      public virtual NHtmlUnit.IPage MouseOver(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOver(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for mouseMove
      public virtual NHtmlUnit.IPage MouseMove(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseMove(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for mouseOut
      public virtual NHtmlUnit.IPage MouseOut(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOut(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for mouseDown
      public virtual NHtmlUnit.IPage MouseDown(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseDown(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for mouseUp
      public virtual NHtmlUnit.IPage MouseUp(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseUp(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for rightClick
      public virtual NHtmlUnit.IPage RightClick(bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.rightClick(shiftKey, ctrlKey, altKey));
      }

// Generating method code for click
      public virtual NHtmlUnit.IPage Click(bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.click(shiftKey, ctrlKey, altKey));
      }

// Generating method code for click
      public virtual NHtmlUnit.IPage Click(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.click((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject));
      }

// Generating method code for dblClick
      public virtual NHtmlUnit.IPage DblClick(bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.dblClick(shiftKey, ctrlKey, altKey));
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
      public virtual void Type(string text, bool shiftKey, bool ctrlKey, bool altKey)
      {
         WObj.type(text, shiftKey, ctrlKey, altKey);
      }

// Generating method code for type
      public virtual NHtmlUnit.IPage Type(int keyCode)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.type(keyCode));
      }

// Generating method code for getOneHtmlElementByAttribute
      public virtual NHtmlUnit.Html.HtmlElement GetOneHtmlElementByAttribute(string elementName, string attributeName, string attributeValue)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.getOneHtmlElementByAttribute(elementName, attributeName, attributeValue));
      }

// Generating method code for appendChildIfNoneExists
      public virtual NHtmlUnit.Html.HtmlElement AppendChildIfNoneExists(string tagName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(WObj.appendChildIfNoneExists(tagName));
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

// Generating method code for fireEvent
      public virtual NHtmlUnit.ScriptResult FireEvent(string eventType)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.fireEvent(eventType));
      }

// Generating method code for mouseOver
      public virtual NHtmlUnit.IPage MouseOver()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOver());
      }

// Generating method code for mouseMove
      public virtual NHtmlUnit.IPage MouseMove()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseMove());
      }

// Generating method code for mouseOut
      public virtual NHtmlUnit.IPage MouseOut()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOut());
      }

// Generating method code for mouseDown
      public virtual NHtmlUnit.IPage MouseDown()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseDown());
      }

// Generating method code for mouseUp
      public virtual NHtmlUnit.IPage MouseUp()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseUp());
      }

// Generating method code for rightClick
      public virtual NHtmlUnit.IPage RightClick()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.rightClick());
      }

// Generating method code for blur
      public virtual void Blur()
      {
         WObj.blur();
      }

// Generating method code for dblClick
      public virtual NHtmlUnit.IPage DblClick()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.dblClick());
      }

   }


}
