// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLElement : NHtmlUnit.Javascript.Host.Element, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement o) =>
            new HTMLElement(o));
      }

      public HTMLElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)WrappedObject; }
      }

      public HTMLElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement()) {}


      public System.Int32 PosX
      {
         get
         {
            return WObj.getPosX();
         }
      }

      public System.Int32 PosY
      {
         get
         {
            return WObj.getPosY();
         }
      }

      public System.Int32 ClientWidth
      {
         get
         {
            return WObj.getClientWidth();
         }
      }

      public System.Int32 ClientHeight
      {
         get
         {
            return WObj.getClientHeight();
         }
      }

      public NHtmlUnit.Javascript.Host.BoxObject BoxObject
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.BoxObject>(
               WObj.getBoxObject());
         }
      }


      public NHtmlUnit.Javascript.Host.Html.HTMLElement ParentHTMLElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getParentHTMLElement());
         }
      }


      public System.Int32 OffsetLeft
      {
         get
         {
            return WObj.getOffsetLeft();
         }
      }

      public System.Int32 OffsetTop
      {
         get
         {
            return WObj.getOffsetTop();
         }
      }

      public System.Object OffsetParent_js
      {
         get
         {
            return WObj.getOffsetParent_js();
         }
      }

      public System.Int32 ScrollLeft
      {
         get
         {
            return WObj.getScrollLeft();
         }
         set
         {
            WObj.setScrollLeft(value);
         }

      }

      public System.Int32 ScrollTop
      {
         get
         {
            return WObj.getScrollTop();
         }
         set
         {
            WObj.setScrollTop(value);
         }

      }

      public IList<NHtmlUnit.W3C.Dom.INode> All
      {
         get
         {
            return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(
               WObj.getAll());
         }
       }

      public System.String Id
      {
         get
         {
            return WObj.getId();
         }
         set
         {
            WObj.setId(value);
         }

      }

      public System.String Title
      {
         get
         {
            return WObj.getTitle();
         }
         set
         {
            WObj.setTitle(value);
         }

      }

      public System.Boolean Disabled
      {
         get
         {
            return WObj.getDisabled();
         }
         set
         {
            WObj.setDisabled(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Html.DocumentProxy Document
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DocumentProxy>(
               WObj.getDocument());
         }
      }


      public System.Object ClassName_js
      {
         get
         {
            return WObj.getClassName_js();
         }
      }

      public System.String InnerText
      {
         get
         {
            return WObj.getInnerText();
         }
         set
         {
            WObj.setInnerText(value);
         }

      }

      public System.String OuterHTML
      {
         get
         {
            return WObj.getOuterHTML();
         }
         set
         {
            WObj.setOuterHTML(value);
         }

      }

      public System.Int32 AvailHeight
      {
         get
         {
            return WObj.getAvailHeight();
         }
      }

      public System.Int32 AvailWidth
      {
         get
         {
            return WObj.getAvailWidth();
         }
      }

      public System.Int32 BufferDepth
      {
         get
         {
            return WObj.getBufferDepth();
         }
      }

      public System.Int32 ColorDepth
      {
         get
         {
            return WObj.getColorDepth();
         }
      }

      public System.String ConnectionType
      {
         get
         {
            return WObj.getConnectionType();
         }
      }

      public System.Boolean CookieEnabled
      {
         get
         {
            return WObj.getCookieEnabled();
         }
      }

      public System.String CpuClass
      {
         get
         {
            return WObj.getCpuClass();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }

      public System.Boolean JavaEnabled
      {
         get
         {
            return WObj.getJavaEnabled();
         }
      }

      public System.String Platform
      {
         get
         {
            return WObj.getPlatform();
         }
      }

      public System.String SystemLanguage
      {
         get
         {
            return WObj.getSystemLanguage();
         }
      }

      public System.String UserLanguage
      {
         get
         {
            return WObj.getUserLanguage();
         }
      }

      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public System.Int32 OffsetHeight
      {
         get
         {
            return WObj.getOffsetHeight();
         }
      }

      public System.Int32 OffsetWidth
      {
         get
         {
            return WObj.getOffsetWidth();
         }
      }

      public System.Int32 ScrollHeight
      {
         get
         {
            return WObj.getScrollHeight();
         }
      }

      public System.Int32 ScrollWidth
      {
         get
         {
            return WObj.getScrollWidth();
         }
      }

      public System.String ScopeName
      {
         get
         {
            return WObj.getScopeName();
         }
      }

      public System.String TagUrn
      {
         get
         {
            return WObj.getTagUrn();
         }
         set
         {
            WObj.setTagUrn(value);
         }

      }

      public System.Object ClientRects
      {
         get
         {
            return WObj.getClientRects();
         }
      }

      public System.String UniqueID
      {
         get
         {
            return WObj.getUniqueID();
         }
      }

      public System.Object Filters
      {
         get
         {
            return WObj.getFilters();
         }
      }

      public System.Boolean Spellcheck
      {
         get
         {
            return WObj.getSpellcheck();
         }
         set
         {
            WObj.setSpellcheck(value);
         }

      }

      public System.String Lang
      {
         get
         {
            return WObj.getLang();
         }
         set
         {
            WObj.setLang(value);
         }

      }

      public System.String Language
      {
         get
         {
            return WObj.getLanguage();
         }
         set
         {
            WObj.setLanguage(value);
         }

      }

      public System.String Dir
      {
         get
         {
            return WObj.getDir();
         }
         set
         {
            WObj.setDir(value);
         }

      }

      public System.Int32 TabIndex
      {
         get
         {
            return WObj.getTabIndex();
         }
         set
         {
            WObj.setTabIndex(value);
         }

      }

      public System.String AccessKey
      {
         get
         {
            return WObj.getAccessKey();
         }
         set
         {
            WObj.setAccessKey(value);
         }

      }

      public System.Int32 ClientLeft
      {
         get
         {
            return WObj.getClientLeft();
         }
      }

      public System.Int32 ClientTop
      {
         get
         {
            return WObj.getClientTop();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.DOMStringMap Dataset
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DOMStringMap>(
               WObj.getDataset());
         }
      }


      public System.Object Onsubmit
      {
         get
         {
            return WObj.getOnsubmit();
         }
         set
         {
            WObj.setOnsubmit(value);
         }

      }
// Generating method code for setActive
      public virtual void SetActive()
      {
         WObj.setActive();
      }

// Generating method code for addBehavior
      public virtual int AddBehavior(string behavior)
      {
         return WObj.addBehavior(behavior);
      }

// Generating method code for removeBehavior
      public virtual void RemoveBehavior(int id)
      {
         WObj.removeBehavior(id);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for clearAttributes
      public virtual void ClearAttributes()
      {
         WObj.clearAttributes();
      }

// Generating method code for mergeAttributes
      public virtual void MergeAttributes(NHtmlUnit.Javascript.Host.Html.HTMLElement source, object preserveIdentity)
      {
         WObj.mergeAttributes((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)source.WrappedObject, preserveIdentity);
      }

// Generating method code for getAttributeNodeNS
      public virtual object GetAttributeNodeNS(string namespaceURI, string localName)
      {
         return WObj.getAttributeNodeNS(namespaceURI, localName);
      }

// Generating method code for removeAttributeNode
      public virtual void RemoveAttributeNode(NHtmlUnit.Javascript.Host.Attr attribute)
      {
         WObj.removeAttributeNode((com.gargoylesoftware.htmlunit.javascript.host.Attr)attribute.WrappedObject);
      }

// Generating method code for removeNode
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement RemoveNode(bool removeChildren)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.removeNode(removeChildren));
      }

// Generating method code for setAttributeNode
      public virtual NHtmlUnit.Javascript.Host.Attr SetAttributeNode(NHtmlUnit.Javascript.Host.Attr newAtt)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Attr>(WObj.setAttributeNode((com.gargoylesoftware.htmlunit.javascript.host.Attr)newAtt.WrappedObject));
      }

// Generating method code for getElementsByClassName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByClassName(string className)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByClassName(className));
      }

// Generating method code for insertAdjacentHTML
      public virtual void InsertAdjacentHTML(string whereArg, string text)
      {
         WObj.insertAdjacentHTML(whereArg, text);
      }

// Generating method code for insertAdjacentElement
      public virtual object InsertAdjacentElement(string whereArg, object objectArg)
      {
         return WObj.insertAdjacentElement(whereArg, objectArg);
      }

// Generating method code for addComponentRequest
      public virtual void AddComponentRequest(string id, string idType, string minVersion)
      {
         WObj.addComponentRequest(id, idType, minVersion);
      }

// Generating method code for clearComponentRequest
      public virtual void ClearComponentRequest()
      {
         WObj.clearComponentRequest();
      }

// Generating method code for compareVersions
      public virtual int CompareVersions(string v1, string v2)
      {
         return WObj.compareVersions(v1, v2);
      }

// Generating method code for doComponentRequest
      public virtual bool DoComponentRequest()
      {
         return WObj.doComponentRequest();
      }

// Generating method code for getComponentVersion
      public virtual string GetComponentVersion(string id, string idType)
      {
         return WObj.getComponentVersion(id, idType);
      }

// Generating method code for isComponentInstalled
      public virtual bool IsComponentInstalled(string id, string idType, string minVersion)
      {
         return WObj.isComponentInstalled(id, idType, minVersion);
      }

// Generating method code for startDownload
      public virtual void StartDownload(string uri, net.sourceforge.htmlunit.corejs.javascript.Function callback)
      {
         WObj.startDownload(uri, callback);
      }

// Generating method code for isHomePage
      public virtual bool IsHomePage(string url)
      {
         return WObj.isHomePage(url);
      }

// Generating method code for navigateHomePage
      public virtual void NavigateHomePage()
      {
         WObj.navigateHomePage();
      }

// Generating method code for scrollIntoView
      public virtual void ScrollIntoView()
      {
         WObj.scrollIntoView();
      }

// Generating method code for setExpression
      public virtual void SetExpression(string propertyName, string expression, string language)
      {
         WObj.setExpression(propertyName, expression, language);
      }

// Generating method code for removeExpression
      public virtual bool RemoveExpression(string propertyName)
      {
         return WObj.removeExpression(propertyName);
      }

// Generating method code for dispatchEvent
      public virtual bool DispatchEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return WObj.dispatchEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject);
      }

// Generating method code for blur
      public virtual void Blur()
      {
         WObj.blur();
      }

// Generating method code for createTextRange
      public virtual object CreateTextRange()
      {
         return WObj.createTextRange();
      }

// Generating method code for focus
      public virtual void Focus()
      {
         WObj.focus();
      }

// Generating method code for querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.StaticNodeList QuerySelectorAll(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.StaticNodeList>(WObj.querySelectorAll(selectors));
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Node QuerySelector(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.querySelector(selectors));
      }

// Generating method code for click
      public virtual void Click()
      {
         WObj.click();
      }

// Generating method code for doScroll
      public virtual void DoScroll(string scrollAction)
      {
         WObj.doScroll(scrollAction);
      }

// Generating method code for getInnerHTML
      public virtual string GetInnerHTML()
      {
         return WObj.getInnerHTML();
      }

// Generating method code for setInnerHTML
      public virtual void SetInnerHTML(object value)
      {
         WObj.setInnerHTML(value);
      }

// Generating method code for getOnchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnchange()
      {
         return WObj.getOnchange();
      }

// Generating method code for setOnchange
      public virtual void SetOnchange(object onchange)
      {
         WObj.setOnchange(onchange);
      }

   }


}
