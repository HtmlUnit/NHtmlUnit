// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLElement : NHtmlUnit.Javascript.Host.Element
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


      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
         set
         {
            WObj.setName(value);
         }

      }

      public System.Object Value
      {
         get
         {
            return WObj.getValue();
         }
         set
         {
            WObj.setValue(value);
         }

      }

      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }

      public System.Int32 OffsetHeight
      {
         get
         {
            return WObj.getOffsetHeight();
         }
      }

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

      public System.Int32 OffsetWidth
      {
         get
         {
            return WObj.getOffsetWidth();
         }
      }

      public System.String ContentEditable
      {
         get
         {
            return WObj.getContentEditable();
         }
         set
         {
            WObj.setContentEditable(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Html.HTMLFormElement Form
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLFormElement>(
               WObj.getForm());
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

      public System.String CpuClass
      {
         get
         {
            return WObj.getCpuClass();
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

      public NHtmlUnit.Javascript.Host.Html.HTMLElement ParentHTMLElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getParentHTMLElement());
         }
      }


      public System.String UniqueID
      {
         get
         {
            return WObj.getUniqueID();
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

      public System.Object OffsetParent_js
      {
         get
         {
            return WObj.getOffsetParent_js();
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

      public NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration RuntimeStyle
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(
               WObj.getRuntimeStyle());
         }
      }


      public NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration CurrentStyle
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration>(
               WObj.getCurrentStyle());
         }
      }


      public System.Object Onclick
      {
         get
         {
            return WObj.getOnclick();
         }
         set
         {
            WObj.setOnclick(value);
         }

      }

      public System.Object Ondblclick
      {
         get
         {
            return WObj.getOndblclick();
         }
         set
         {
            WObj.setOndblclick(value);
         }

      }

      public System.Object Onblur
      {
         get
         {
            return WObj.getOnblur();
         }
         set
         {
            WObj.setOnblur(value);
         }

      }

      public System.Object Onfocus
      {
         get
         {
            return WObj.getOnfocus();
         }
         set
         {
            WObj.setOnfocus(value);
         }

      }

      public System.Object Onfocusin
      {
         get
         {
            return WObj.getOnfocusin();
         }
         set
         {
            WObj.setOnfocusin(value);
         }

      }

      public System.Object Onfocusout
      {
         get
         {
            return WObj.getOnfocusout();
         }
         set
         {
            WObj.setOnfocusout(value);
         }

      }

      public System.Object Onkeydown
      {
         get
         {
            return WObj.getOnkeydown();
         }
         set
         {
            WObj.setOnkeydown(value);
         }

      }

      public System.Object Onkeypress
      {
         get
         {
            return WObj.getOnkeypress();
         }
         set
         {
            WObj.setOnkeypress(value);
         }

      }

      public System.Object Onkeyup
      {
         get
         {
            return WObj.getOnkeyup();
         }
         set
         {
            WObj.setOnkeyup(value);
         }

      }

      public System.Object Onmousedown
      {
         get
         {
            return WObj.getOnmousedown();
         }
         set
         {
            WObj.setOnmousedown(value);
         }

      }

      public System.Object Onmousemove
      {
         get
         {
            return WObj.getOnmousemove();
         }
         set
         {
            WObj.setOnmousemove(value);
         }

      }

      public System.Object Onmouseout
      {
         get
         {
            return WObj.getOnmouseout();
         }
         set
         {
            WObj.setOnmouseout(value);
         }

      }

      public System.Object Onmouseover
      {
         get
         {
            return WObj.getOnmouseover();
         }
         set
         {
            WObj.setOnmouseover(value);
         }

      }

      public System.Object Onmouseup
      {
         get
         {
            return WObj.getOnmouseup();
         }
         set
         {
            WObj.setOnmouseup(value);
         }

      }

      public System.Object Oncontextmenu
      {
         get
         {
            return WObj.getOncontextmenu();
         }
         set
         {
            WObj.setOncontextmenu(value);
         }

      }

      public System.Object Onerror
      {
         get
         {
            return WObj.getOnerror();
         }
         set
         {
            WObj.setOnerror(value);
         }

      }

      public System.Object Onload
      {
         get
         {
            return WObj.getOnload();
         }
         set
         {
            WObj.setOnload(value);
         }

      }
// Generating method code for isIsContentEditable
      public virtual bool IsIsContentEditable()
      {
         return WObj.isIsContentEditable();
      }

// Generating method code for addBehavior
      public virtual int AddBehavior(string behavior)
      {
         return WObj.addBehavior(behavior);
      }

// Generating method code for isDisabled
      public virtual bool IsDisabled()
      {
         return WObj.isDisabled();
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

// Generating method code for removeNode
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement RemoveNode(bool removeChildren)
      {
         var arg = WObj.removeNode(removeChildren);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(arg);
      }

// Generating method code for removeBehavior
      public virtual void RemoveBehavior(int id)
      {
         WObj.removeBehavior(id);
      }

// Generating method code for isCookieEnabled
      public virtual bool IsCookieEnabled()
      {
         return WObj.isCookieEnabled();
      }

// Generating method code for isJavaEnabled
      public virtual bool IsJavaEnabled()
      {
         return WObj.isJavaEnabled();
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

// Generating method code for blur
      public virtual void Blur()
      {
         WObj.blur();
      }

// Generating method code for focus
      public virtual void Focus()
      {
         WObj.focus();
      }

// Generating method code for setActive
      public virtual void SetActive()
      {
         WObj.setActive();
      }

// Generating method code for click
      public virtual void Click()
      {
         WObj.click();
      }

// Generating method code for isSpellcheck
      public virtual bool IsSpellcheck()
      {
         return WObj.isSpellcheck();
      }

// Generating method code for isHidden
      public virtual bool IsHidden()
      {
         return WObj.isHidden();
      }

// Generating method code for getOnstalled
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstalled()
      {
         return WObj.getOnstalled();
      }

// Generating method code for setOnstalled
      public virtual void SetOnstalled(object onstalled)
      {
         WObj.setOnstalled(onstalled);
      }

// Generating method code for getOnsuspend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnsuspend()
      {
         return WObj.getOnsuspend();
      }

// Generating method code for setOnsuspend
      public virtual void SetOnsuspend(object onsuspend)
      {
         WObj.setOnsuspend(onsuspend);
      }

// Generating method code for getOntimeupdate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntimeupdate()
      {
         return WObj.getOntimeupdate();
      }

// Generating method code for setOntimeupdate
      public virtual void SetOntimeupdate(object ontimeupdate)
      {
         WObj.setOntimeupdate(ontimeupdate);
      }

// Generating method code for getOntoggle
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntoggle()
      {
         return WObj.getOntoggle();
      }

// Generating method code for setOntoggle
      public virtual void SetOntoggle(object ontoggle)
      {
         WObj.setOntoggle(ontoggle);
      }

// Generating method code for getOnvolumechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnvolumechange()
      {
         return WObj.getOnvolumechange();
      }

// Generating method code for setOnvolumechange
      public virtual void SetOnvolumechange(object onvolumechange)
      {
         WObj.setOnvolumechange(onvolumechange);
      }

// Generating method code for getOnwaiting
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwaiting()
      {
         return WObj.getOnwaiting();
      }

// Generating method code for setOnwaiting
      public virtual void SetOnwaiting(object onwaiting)
      {
         WObj.setOnwaiting(onwaiting);
      }

// Generating method code for getOncopy
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncopy()
      {
         return WObj.getOncopy();
      }

// Generating method code for setOncopy
      public virtual void SetOncopy(object oncopy)
      {
         WObj.setOncopy(oncopy);
      }

// Generating method code for getOncut
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncut()
      {
         return WObj.getOncut();
      }

// Generating method code for setOncut
      public virtual void SetOncut(object oncut)
      {
         WObj.setOncut(oncut);
      }

// Generating method code for getOnpaste
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpaste()
      {
         return WObj.getOnpaste();
      }

// Generating method code for setOnpaste
      public virtual void SetOnpaste(object onpaste)
      {
         WObj.setOnpaste(onpaste);
      }

// Generating method code for getOnmozfullscreenchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmozfullscreenchange()
      {
         return WObj.getOnmozfullscreenchange();
      }

// Generating method code for setOnmozfullscreenchange
      public virtual void SetOnmozfullscreenchange(object onmozfullscreenchange)
      {
         WObj.setOnmozfullscreenchange(onmozfullscreenchange);
      }

// Generating method code for getOnmozfullscreenerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmozfullscreenerror()
      {
         return WObj.getOnmozfullscreenerror();
      }

// Generating method code for setOnmozfullscreenerror
      public virtual void SetOnmozfullscreenerror(object onmozfullscreenerror)
      {
         WObj.setOnmozfullscreenerror(onmozfullscreenerror);
      }

// Generating method code for getOnactivate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnactivate()
      {
         return WObj.getOnactivate();
      }

// Generating method code for setOnactivate
      public virtual void SetOnactivate(object onactivate)
      {
         WObj.setOnactivate(onactivate);
      }

// Generating method code for getOnbeforeactivate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforeactivate()
      {
         return WObj.getOnbeforeactivate();
      }

// Generating method code for setOnbeforeactivate
      public virtual void SetOnbeforeactivate(object onbeforeactivate)
      {
         WObj.setOnbeforeactivate(onbeforeactivate);
      }

// Generating method code for getOnbeforedeactivate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforedeactivate()
      {
         return WObj.getOnbeforedeactivate();
      }

// Generating method code for setOnbeforedeactivate
      public virtual void SetOnbeforedeactivate(object onbeforedeactivate)
      {
         WObj.setOnbeforedeactivate(onbeforedeactivate);
      }

// Generating method code for getOndeactivate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndeactivate()
      {
         return WObj.getOndeactivate();
      }

// Generating method code for setOndeactivate
      public virtual void SetOndeactivate(object ondeactivate)
      {
         WObj.setOndeactivate(ondeactivate);
      }

// Generating method code for getOnhelp
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnhelp()
      {
         return WObj.getOnhelp();
      }

// Generating method code for setOnhelp
      public virtual void SetOnhelp(object onhelp)
      {
         WObj.setOnhelp(onhelp);
      }

// Generating method code for getOnmscontentzoom
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmscontentzoom()
      {
         return WObj.getOnmscontentzoom();
      }

// Generating method code for setOnmscontentzoom
      public virtual void SetOnmscontentzoom(object onmscontentzoom)
      {
         WObj.setOnmscontentzoom(onmscontentzoom);
      }

// Generating method code for getOnmsmanipulationstatechanged
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsmanipulationstatechanged()
      {
         return WObj.getOnmsmanipulationstatechanged();
      }

// Generating method code for setOnmsmanipulationstatechanged
      public virtual void SetOnmsmanipulationstatechanged(object onmsmanipulationstatechanged)
      {
         WObj.setOnmsmanipulationstatechanged(onmsmanipulationstatechanged);
      }

// Generating method code for getOnselectstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnselectstart()
      {
         return WObj.getOnselectstart();
      }

// Generating method code for setOnselectstart
      public virtual void SetOnselectstart(object onselectstart)
      {
         WObj.setOnselectstart(onselectstart);
      }

// Generating method code for getOnanimationcancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnanimationcancel()
      {
         return WObj.getOnanimationcancel();
      }

// Generating method code for setOnanimationcancel
      public virtual void SetOnanimationcancel(object onanimationcancel)
      {
         WObj.setOnanimationcancel(onanimationcancel);
      }

// Generating method code for getOnanimationend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnanimationend()
      {
         return WObj.getOnanimationend();
      }

// Generating method code for setOnanimationend
      public virtual void SetOnanimationend(object onanimationend)
      {
         WObj.setOnanimationend(onanimationend);
      }

// Generating method code for getOnanimationiteration
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnanimationiteration()
      {
         return WObj.getOnanimationiteration();
      }

// Generating method code for setOnanimationiteration
      public virtual void SetOnanimationiteration(object onanimationiteration)
      {
         WObj.setOnanimationiteration(onanimationiteration);
      }

// Generating method code for getOnanimationstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnanimationstart()
      {
         return WObj.getOnanimationstart();
      }

// Generating method code for setOnanimationstart
      public virtual void SetOnanimationstart(object onanimationstart)
      {
         WObj.setOnanimationstart(onanimationstart);
      }

// Generating method code for getOnselectionchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnselectionchange()
      {
         return WObj.getOnselectionchange();
      }

// Generating method code for setOnselectionchange
      public virtual void SetOnselectionchange(object onselectionchange)
      {
         WObj.setOnselectionchange(onselectionchange);
      }

// Generating method code for getOntransitioncancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntransitioncancel()
      {
         return WObj.getOntransitioncancel();
      }

// Generating method code for setOntransitioncancel
      public virtual void SetOntransitioncancel(object ontransitioncancel)
      {
         WObj.setOntransitioncancel(ontransitioncancel);
      }

// Generating method code for getOntransitionend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntransitionend()
      {
         return WObj.getOntransitionend();
      }

// Generating method code for setOntransitionend
      public virtual void SetOntransitionend(object ontransitionend)
      {
         WObj.setOntransitionend(ontransitionend);
      }

// Generating method code for getOntransitionrun
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntransitionrun()
      {
         return WObj.getOntransitionrun();
      }

// Generating method code for setOntransitionrun
      public virtual void SetOntransitionrun(object ontransitionrun)
      {
         WObj.setOntransitionrun(ontransitionrun);
      }

// Generating method code for getOntransitionstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntransitionstart()
      {
         return WObj.getOntransitionstart();
      }

// Generating method code for setOntransitionstart
      public virtual void SetOntransitionstart(object ontransitionstart)
      {
         WObj.setOntransitionstart(ontransitionstart);
      }

// Generating method code for getStyle
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration GetStyle()
      {
         var arg = WObj.getStyle();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(arg);
      }

// Generating method code for setStyle
      public virtual void SetStyle(string style)
      {
         WObj.setStyle(style);
      }

// Generating method code for getInnerText
      public virtual string GetInnerText()
      {
         return WObj.getInnerText();
      }

// Generating method code for setInnerText
      public virtual void SetInnerText(object value)
      {
         WObj.setInnerText(value);
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

// Generating method code for getOnresize
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnresize()
      {
         return WObj.getOnresize();
      }

// Generating method code for setOnresize
      public virtual void SetOnresize(object handler)
      {
         WObj.setOnresize(handler);
      }

// Generating method code for getOninput
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOninput()
      {
         return WObj.getOninput();
      }

// Generating method code for setOninput
      public virtual void SetOninput(object oninput)
      {
         WObj.setOninput(oninput);
      }

// Generating method code for getOnabort
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnabort()
      {
         return WObj.getOnabort();
      }

// Generating method code for setOnabort
      public virtual void SetOnabort(object onabort)
      {
         WObj.setOnabort(onabort);
      }

// Generating method code for getOnauxclick
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnauxclick()
      {
         return WObj.getOnauxclick();
      }

// Generating method code for setOnauxclick
      public virtual void SetOnauxclick(object onauxclick)
      {
         WObj.setOnauxclick(onauxclick);
      }

// Generating method code for getOncancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncancel()
      {
         return WObj.getOncancel();
      }

// Generating method code for setOncancel
      public virtual void SetOncancel(object oncancel)
      {
         WObj.setOncancel(oncancel);
      }

// Generating method code for getOncanplay
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncanplay()
      {
         return WObj.getOncanplay();
      }

// Generating method code for setOncanplay
      public virtual void SetOncanplay(object oncanplay)
      {
         WObj.setOncanplay(oncanplay);
      }

// Generating method code for getOncanplaythrough
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncanplaythrough()
      {
         return WObj.getOncanplaythrough();
      }

// Generating method code for setOncanplaythrough
      public virtual void SetOncanplaythrough(object oncanplaythrough)
      {
         WObj.setOncanplaythrough(oncanplaythrough);
      }

// Generating method code for getOnclose
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnclose()
      {
         return WObj.getOnclose();
      }

// Generating method code for setOnclose
      public virtual void SetOnclose(object onclose)
      {
         WObj.setOnclose(onclose);
      }

// Generating method code for getOncuechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncuechange()
      {
         return WObj.getOncuechange();
      }

// Generating method code for setOncuechange
      public virtual void SetOncuechange(object oncuechange)
      {
         WObj.setOncuechange(oncuechange);
      }

// Generating method code for getOndrag
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndrag()
      {
         return WObj.getOndrag();
      }

// Generating method code for setOndrag
      public virtual void SetOndrag(object ondrag)
      {
         WObj.setOndrag(ondrag);
      }

// Generating method code for getOndragend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragend()
      {
         return WObj.getOndragend();
      }

// Generating method code for setOndragend
      public virtual void SetOndragend(object ondragend)
      {
         WObj.setOndragend(ondragend);
      }

// Generating method code for getOndragenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragenter()
      {
         return WObj.getOndragenter();
      }

// Generating method code for setOndragenter
      public virtual void SetOndragenter(object ondragenter)
      {
         WObj.setOndragenter(ondragenter);
      }

// Generating method code for getOndragleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragleave()
      {
         return WObj.getOndragleave();
      }

// Generating method code for setOndragleave
      public virtual void SetOndragleave(object ondragleave)
      {
         WObj.setOndragleave(ondragleave);
      }

// Generating method code for getOndragover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragover()
      {
         return WObj.getOndragover();
      }

// Generating method code for setOndragover
      public virtual void SetOndragover(object ondragover)
      {
         WObj.setOndragover(ondragover);
      }

// Generating method code for getOndragstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragstart()
      {
         return WObj.getOndragstart();
      }

// Generating method code for setOndragstart
      public virtual void SetOndragstart(object ondragstart)
      {
         WObj.setOndragstart(ondragstart);
      }

// Generating method code for getOndrop
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndrop()
      {
         return WObj.getOndrop();
      }

// Generating method code for setOndrop
      public virtual void SetOndrop(object ondrop)
      {
         WObj.setOndrop(ondrop);
      }

// Generating method code for getOndurationchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndurationchange()
      {
         return WObj.getOndurationchange();
      }

// Generating method code for setOndurationchange
      public virtual void SetOndurationchange(object ondurationchange)
      {
         WObj.setOndurationchange(ondurationchange);
      }

// Generating method code for getOnemptied
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnemptied()
      {
         return WObj.getOnemptied();
      }

// Generating method code for setOnemptied
      public virtual void SetOnemptied(object onemptied)
      {
         WObj.setOnemptied(onemptied);
      }

// Generating method code for getOnended
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnended()
      {
         return WObj.getOnended();
      }

// Generating method code for setOnended
      public virtual void SetOnended(object onended)
      {
         WObj.setOnended(onended);
      }

// Generating method code for getOninvalid
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOninvalid()
      {
         return WObj.getOninvalid();
      }

// Generating method code for setOninvalid
      public virtual void SetOninvalid(object oninvalid)
      {
         WObj.setOninvalid(oninvalid);
      }

// Generating method code for getOnloadeddata
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadeddata()
      {
         return WObj.getOnloadeddata();
      }

// Generating method code for setOnloadeddata
      public virtual void SetOnloadeddata(object onloadeddata)
      {
         WObj.setOnloadeddata(onloadeddata);
      }

// Generating method code for getOnloadedmetadata
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadedmetadata()
      {
         return WObj.getOnloadedmetadata();
      }

// Generating method code for setOnloadedmetadata
      public virtual void SetOnloadedmetadata(object onloadedmetadata)
      {
         WObj.setOnloadedmetadata(onloadedmetadata);
      }

// Generating method code for getOnloadstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadstart()
      {
         return WObj.getOnloadstart();
      }

// Generating method code for setOnloadstart
      public virtual void SetOnloadstart(object onloadstart)
      {
         WObj.setOnloadstart(onloadstart);
      }

// Generating method code for getOnmouseenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseenter()
      {
         return WObj.getOnmouseenter();
      }

// Generating method code for setOnmouseenter
      public virtual void SetOnmouseenter(object onmouseenter)
      {
         WObj.setOnmouseenter(onmouseenter);
      }

// Generating method code for getOnmouseleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseleave()
      {
         return WObj.getOnmouseleave();
      }

// Generating method code for setOnmouseleave
      public virtual void SetOnmouseleave(object onmouseleave)
      {
         WObj.setOnmouseleave(onmouseleave);
      }

// Generating method code for getOnmousewheel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmousewheel()
      {
         return WObj.getOnmousewheel();
      }

// Generating method code for setOnmousewheel
      public virtual void SetOnmousewheel(object onmousewheel)
      {
         WObj.setOnmousewheel(onmousewheel);
      }

// Generating method code for getOnpause
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpause()
      {
         return WObj.getOnpause();
      }

// Generating method code for setOnpause
      public virtual void SetOnpause(object onpause)
      {
         WObj.setOnpause(onpause);
      }

// Generating method code for getOnplay
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnplay()
      {
         return WObj.getOnplay();
      }

// Generating method code for setOnplay
      public virtual void SetOnplay(object onplay)
      {
         WObj.setOnplay(onplay);
      }

// Generating method code for getOnplaying
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnplaying()
      {
         return WObj.getOnplaying();
      }

// Generating method code for setOnplaying
      public virtual void SetOnplaying(object onplaying)
      {
         WObj.setOnplaying(onplaying);
      }

// Generating method code for getOnprogress
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnprogress()
      {
         return WObj.getOnprogress();
      }

// Generating method code for setOnprogress
      public virtual void SetOnprogress(object onprogress)
      {
         WObj.setOnprogress(onprogress);
      }

// Generating method code for getOnratechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnratechange()
      {
         return WObj.getOnratechange();
      }

// Generating method code for setOnratechange
      public virtual void SetOnratechange(object onratechange)
      {
         WObj.setOnratechange(onratechange);
      }

// Generating method code for getOnreset
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnreset()
      {
         return WObj.getOnreset();
      }

// Generating method code for setOnreset
      public virtual void SetOnreset(object onreset)
      {
         WObj.setOnreset(onreset);
      }

// Generating method code for getOnscroll
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnscroll()
      {
         return WObj.getOnscroll();
      }

// Generating method code for setOnscroll
      public virtual void SetOnscroll(object onscroll)
      {
         WObj.setOnscroll(onscroll);
      }

// Generating method code for getOnseeked
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnseeked()
      {
         return WObj.getOnseeked();
      }

// Generating method code for setOnseeked
      public virtual void SetOnseeked(object onseeked)
      {
         WObj.setOnseeked(onseeked);
      }

// Generating method code for getOnseeking
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnseeking()
      {
         return WObj.getOnseeking();
      }

// Generating method code for setOnseeking
      public virtual void SetOnseeking(object onseeking)
      {
         WObj.setOnseeking(onseeking);
      }

// Generating method code for getOnselect
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnselect()
      {
         return WObj.getOnselect();
      }

// Generating method code for setOnselect
      public virtual void SetOnselect(object onselect)
      {
         WObj.setOnselect(onselect);
      }

// Generating method code for getOnshow
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnshow()
      {
         return WObj.getOnshow();
      }

// Generating method code for setOnshow
      public virtual void SetOnshow(object onshow)
      {
         WObj.setOnshow(onshow);
      }

   }


}
