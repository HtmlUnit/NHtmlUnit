// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Document : NHtmlUnit.Javascript.Host.Dom.Node
   {
      static Document()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Document o) =>
            new Document(o));
      }

      public Document(com.gargoylesoftware.htmlunit.javascript.host.dom.Document wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Document WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Document)WrappedObject; }
      }

      public Document()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Document()) {}


      public net.sourceforge.htmlunit.corejs.javascript.ScriptableObject CurrentScript
      {
         get
         {
            return WObj.getCurrentScript();
         }
         set
         {
            WObj.setCurrentScript(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.ScriptableObject Fonts
      {
         get
         {
            return WObj.getFonts();
         }
      }

      public NHtmlUnit.Javascript.Host.Html.HTMLCollection All
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(
               WObj.getAll());
         }
      }


      public System.Object ParentWindow
      {
         get
         {
            return WObj.getParentWindow();
         }
      }

      public System.Int32 DocumentMode
      {
         get
         {
            return WObj.getDocumentMode();
         }
      }

      public System.String DesignMode
      {
         get
         {
            return WObj.getDesignMode();
         }
         set
         {
            WObj.setDesignMode(value);
         }

      }

      public System.String CompatMode
      {
         get
         {
            return WObj.getCompatMode();
         }
      }

      public NHtmlUnit.SgmlPage Page
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.SgmlPage>(
               WObj.getPage());
         }
      }


      public System.String URL
      {
         get
         {
            return WObj.getURL();
         }
      }

      public System.String Domain
      {
         get
         {
            return WObj.getDomain();
         }
         set
         {
            WObj.setDomain(value);
         }

      }

      public System.Object Embeds
      {
         get
         {
            return WObj.getEmbeds();
         }
      }

      public NHtmlUnit.Javascript.Host.Html.HTMLElement Body
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getBody());
         }
      }


      public NHtmlUnit.Javascript.Host.Element DocumentElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getDocumentElement());
         }
      }


      public System.String Referrer
      {
         get
         {
            return WObj.getReferrer();
         }
      }

      public NHtmlUnit.Javascript.Host.Element RootElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getRootElement());
         }
      }


      public NHtmlUnit.Javascript.SimpleScriptable Doctype
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.SimpleScriptable>(
               WObj.getDoctype());
         }
      }


      public System.Object DefaultView
      {
         get
         {
            return WObj.getDefaultView();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.DOMImplementation Implementation
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DOMImplementation>(
               WObj.getImplementation());
         }
      }


      public System.Object ActiveElement
      {
         get
         {
            return WObj.getActiveElement();
         }
      }

      public System.String CharacterSet
      {
         get
         {
            return WObj.getCharacterSet();
         }
      }

      public System.String Charset
      {
         get
         {
            return WObj.getCharset();
         }
      }

      public System.String DefaultCharset
      {
         get
         {
            return WObj.getDefaultCharset();
         }
      }

      public System.Object Anchors
      {
         get
         {
            return WObj.getAnchors();
         }
      }

      public System.Object Applets
      {
         get
         {
            return WObj.getApplets();
         }
      }

      public System.String UniqueID
      {
         get
         {
            return WObj.getUniqueID();
         }
      }

      public System.String DocumentURI
      {
         get
         {
            return WObj.getDocumentURI();
         }
      }

      public System.String URLUnencoded
      {
         get
         {
            return WObj.getURLUnencoded();
         }
      }

      public System.String Cookie
      {
         get
         {
            return WObj.getCookie();
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

      public System.Object Onresize
      {
         get
         {
            return WObj.getOnresize();
         }
         set
         {
            WObj.setOnresize(value);
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

      public System.Boolean Hidden
      {
         get
         {
            return WObj.getHidden();
         }
      }

      public System.Int32 ChildElementCount
      {
         get
         {
            return WObj.getChildElementCount();
         }
      }

      public System.Object Forms
      {
         get
         {
            return WObj.getForms();
         }
      }

      public System.Object Images
      {
         get
         {
            return WObj.getImages();
         }
      }

      public System.Object Scripts
      {
         get
         {
            return WObj.getScripts();
         }
      }

      public NHtmlUnit.Javascript.Host.Css.StyleSheetList StyleSheets
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.StyleSheetList>(
               WObj.getStyleSheets());
         }
      }


      public System.Object Plugins
      {
         get
         {
            return WObj.getPlugins();
         }
      }

      public System.Object Links
      {
         get
         {
            return WObj.getLinks();
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

      public NHtmlUnit.Javascript.Host.Html.HTMLCollection Children
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(
               WObj.getChildren());
         }
      }


      public System.String ContentType
      {
         get
         {
            return WObj.getContentType();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.Selection Selection
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Selection>(
               WObj.getSelection());
         }
      }


      public System.Object Head
      {
         get
         {
            return WObj.getHead();
         }
      }

      public System.String InputEncoding
      {
         get
         {
            return WObj.getInputEncoding();
         }
      }

      public System.String LastModified
      {
         get
         {
            return WObj.getLastModified();
         }
      }

      public System.String ReadyState
      {
         get
         {
            return WObj.getReadyState();
         }
      }

      public System.String AlinkColor
      {
         get
         {
            return WObj.getAlinkColor();
         }
         set
         {
            WObj.setAlinkColor(value);
         }

      }

      public System.String BgColor
      {
         get
         {
            return WObj.getBgColor();
         }
         set
         {
            WObj.setBgColor(value);
         }

      }

      public System.String FgColor
      {
         get
         {
            return WObj.getFgColor();
         }
         set
         {
            WObj.setFgColor(value);
         }

      }

      public System.String LinkColor
      {
         get
         {
            return WObj.getLinkColor();
         }
         set
         {
            WObj.setLinkColor(value);
         }

      }

      public System.String VlinkColor
      {
         get
         {
            return WObj.getVlinkColor();
         }
         set
         {
            WObj.setVlinkColor(value);
         }

      }

      public System.Object Frames
      {
         get
         {
            return WObj.getFrames();
         }
      }

      public NHtmlUnit.Javascript.Host.Element LastElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getLastElementChild());
         }
      }


      public NHtmlUnit.Javascript.Host.Element FirstElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getFirstElementChild());
         }
      }


      public System.String XmlEncoding
      {
         get
         {
            return WObj.getXmlEncoding();
         }
      }

      public System.String XmlVersion
      {
         get
         {
            return WObj.getXmlVersion();
         }
      }
// Generating method code for getElementById
      public virtual object GetElementById(string id)
      {
         var arg = WObj.getElementById(id);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createProcessingInstruction
      public virtual object CreateProcessingInstruction(string target, string data)
      {
         var arg = WObj.createProcessingInstruction(target, data);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createCDATASection
      public virtual object CreateCDATASection(string data)
      {
         var arg = WObj.createCDATASection(data);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

// Generating method code for forceDocumentMode
      public virtual void ForceDocumentMode(int documentMode)
      {
         WObj.forceDocumentMode(documentMode);
      }

// Generating method code for createTextNode
      public virtual object CreateTextNode(string newData)
      {
         var arg = WObj.createTextNode(newData);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for importNode
      public virtual object ImportNode(NHtmlUnit.Javascript.Host.Dom.Node importedNode, bool deep)
      {
         var arg = WObj.importNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)importedNode.WrappedObject, deep);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createDocumentFragment
      public virtual object CreateDocumentFragment()
      {
         var arg = WObj.createDocumentFragment();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createAttribute
      public virtual NHtmlUnit.Javascript.Host.Dom.Attr CreateAttribute(string attributeName)
      {
         var arg = WObj.createAttribute(attributeName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Attr>(arg);
      }

// Generating method code for adoptNode
      public virtual object AdoptNode(NHtmlUnit.Javascript.Host.Dom.Node externalNode)
      {
         var arg = WObj.adoptNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)externalNode.WrappedObject);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createNSResolver
      public virtual NHtmlUnit.Javascript.Host.Dom.XPathNSResolver CreateNSResolver(NHtmlUnit.Javascript.Host.Dom.Node nodeResolver)
      {
         var arg = WObj.createNSResolver((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)nodeResolver.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.XPathNSResolver>(arg);
      }

// Generating method code for createComment
      public virtual object CreateComment(string comment)
      {
         var arg = WObj.createComment(comment);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for evaluate
      public virtual NHtmlUnit.Javascript.Host.Dom.XPathResult Evaluate(string expression, NHtmlUnit.Javascript.Host.Dom.Node contextNode, object resolver, int type, object result)
      {
         var arg = WObj.evaluate(expression, (com.gargoylesoftware.htmlunit.javascript.host.dom.Node)contextNode.WrappedObject, resolver, type, result);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.XPathResult>(arg);
      }

// Generating method code for createElement
      public virtual object CreateElement(string tagName)
      {
         var arg = WObj.createElement(tagName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createElementNS
      public virtual object CreateElementNS(string namespaceURI, string qualifiedName)
      {
         var arg = WObj.createElementNS(namespaceURI, qualifiedName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getElementsByTagName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByTagName(string tagName)
      {
         var arg = WObj.getElementsByTagName(tagName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for getElementsByTagNameNS
      public virtual object GetElementsByTagNameNS(object namespaceURI, string localName)
      {
         var arg = WObj.getElementsByTagNameNS(namespaceURI, localName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Dom.Node QuerySelector(string selectors)
      {
         var arg = WObj.querySelector(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.Dom.NodeList QuerySelectorAll(string selectors)
      {
         var arg = WObj.querySelectorAll(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeList>(arg);
      }

// Generating method code for queryCommandSupported
      public virtual bool QueryCommandSupported(string cmd)
      {
         return WObj.queryCommandSupported(cmd);
      }

// Generating method code for queryCommandEnabled
      public virtual bool QueryCommandEnabled(string cmd)
      {
         return WObj.queryCommandEnabled(cmd);
      }

// Generating method code for execCommand
      public virtual bool ExecCommand(string cmd, bool userInterface, object value)
      {
         return WObj.execCommand(cmd, userInterface, value);
      }

// Generating method code for createEvent
      public virtual NHtmlUnit.Javascript.Host.Events.Event CreateEvent(string eventType)
      {
         var arg = WObj.createEvent(eventType);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Events.Event>(arg);
      }

// Generating method code for createNodeIterator
      public virtual NHtmlUnit.Javascript.Host.Dom.NodeIterator CreateNodeIterator(NHtmlUnit.Javascript.Host.Dom.Node root, int whatToShow, net.sourceforge.htmlunit.corejs.javascript.Scriptable filter)
      {
         var arg = WObj.createNodeIterator((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, filter);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeIterator>(arg);
      }

// Generating method code for createTreeWalker
      public virtual object CreateTreeWalker(NHtmlUnit.Javascript.Host.Dom.Node root, System.Double whatToShow, net.sourceforge.htmlunit.corejs.javascript.Scriptable filter, bool expandEntityReferences)
      {
         var arg = WObj.createTreeWalker((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, filter, expandEntityReferences);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createRange
      public virtual NHtmlUnit.Javascript.Host.Dom.Range CreateRange()
      {
         var arg = WObj.createRange();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Range>(arg);
      }

// Generating method code for elementFromPoint
      public virtual object ElementFromPoint(int x, int y)
      {
         var arg = WObj.elementFromPoint(x, y);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getElementsByClassName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByClassName(string className)
      {
         var arg = WObj.getElementsByClassName(className);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for getElementsByName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByName(string elementName)
      {
         var arg = WObj.getElementsByName(elementName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for hasFocus
      public virtual bool HasFocus()
      {
         return WObj.hasFocus();
      }

// Generating method code for releaseCapture
      public virtual bool ReleaseCapture()
      {
         return WObj.releaseCapture();
      }

// Generating method code for captureEvents
      public virtual void CaptureEvents(string type)
      {
         WObj.captureEvents(type);
      }

// Generating method code for releaseEvents
      public virtual void ReleaseEvents(string type)
      {
         WObj.releaseEvents(type);
      }

// Generating method code for isXmlStandalone
      public virtual bool IsXmlStandalone()
      {
         return WObj.isXmlStandalone();
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

// Generating method code for getOnsubmit
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnsubmit()
      {
         return WObj.getOnsubmit();
      }

// Generating method code for setOnsubmit
      public virtual void SetOnsubmit(object onsubmit)
      {
         WObj.setOnsubmit(onsubmit);
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

// Generating method code for getOnwebkitfullscreenchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkitfullscreenchange()
      {
         return WObj.getOnwebkitfullscreenchange();
      }

// Generating method code for setOnwebkitfullscreenchange
      public virtual void SetOnwebkitfullscreenchange(object onwebkitfullscreenchange)
      {
         WObj.setOnwebkitfullscreenchange(onwebkitfullscreenchange);
      }

// Generating method code for getOnwebkitfullscreenerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwebkitfullscreenerror()
      {
         return WObj.getOnwebkitfullscreenerror();
      }

// Generating method code for setOnwebkitfullscreenerror
      public virtual void SetOnwebkitfullscreenerror(object onwebkitfullscreenerror)
      {
         WObj.setOnwebkitfullscreenerror(onwebkitfullscreenerror);
      }

// Generating method code for getOnwheel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwheel()
      {
         return WObj.getOnwheel();
      }

// Generating method code for setOnwheel
      public virtual void SetOnwheel(object onwheel)
      {
         WObj.setOnwheel(onwheel);
      }

// Generating method code for getOnafterscriptexecute
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnafterscriptexecute()
      {
         return WObj.getOnafterscriptexecute();
      }

// Generating method code for setOnafterscriptexecute
      public virtual void SetOnafterscriptexecute(object onafterscriptexecute)
      {
         WObj.setOnafterscriptexecute(onafterscriptexecute);
      }

// Generating method code for getOnbeforescriptexecute
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforescriptexecute()
      {
         return WObj.getOnbeforescriptexecute();
      }

// Generating method code for setOnbeforescriptexecute
      public virtual void SetOnbeforescriptexecute(object onbeforescriptexecute)
      {
         WObj.setOnbeforescriptexecute(onbeforescriptexecute);
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

// Generating method code for getOnmsfullscreenchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsfullscreenchange()
      {
         return WObj.getOnmsfullscreenchange();
      }

// Generating method code for setOnmsfullscreenchange
      public virtual void SetOnmsfullscreenchange(object onmsfullscreenchange)
      {
         WObj.setOnmsfullscreenchange(onmsfullscreenchange);
      }

// Generating method code for getOnmsfullscreenerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsfullscreenerror()
      {
         return WObj.getOnmsfullscreenerror();
      }

// Generating method code for setOnmsfullscreenerror
      public virtual void SetOnmsfullscreenerror(object onmsfullscreenerror)
      {
         WObj.setOnmsfullscreenerror(onmsfullscreenerror);
      }

// Generating method code for getOnmsgesturechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturechange()
      {
         return WObj.getOnmsgesturechange();
      }

// Generating method code for setOnmsgesturechange
      public virtual void SetOnmsgesturechange(object onmsgesturechange)
      {
         WObj.setOnmsgesturechange(onmsgesturechange);
      }

// Generating method code for getOnmsgesturedoubletap
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturedoubletap()
      {
         return WObj.getOnmsgesturedoubletap();
      }

// Generating method code for setOnmsgesturedoubletap
      public virtual void SetOnmsgesturedoubletap(object onmsgesturedoubletap)
      {
         WObj.setOnmsgesturedoubletap(onmsgesturedoubletap);
      }

// Generating method code for getOnmsgestureend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgestureend()
      {
         return WObj.getOnmsgestureend();
      }

// Generating method code for setOnmsgestureend
      public virtual void SetOnmsgestureend(object onmsgestureend)
      {
         WObj.setOnmsgestureend(onmsgestureend);
      }

// Generating method code for getOnmsgesturehold
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturehold()
      {
         return WObj.getOnmsgesturehold();
      }

// Generating method code for setOnmsgesturehold
      public virtual void SetOnmsgesturehold(object onmsgesturehold)
      {
         WObj.setOnmsgesturehold(onmsgesturehold);
      }

// Generating method code for getOnmsgesturestart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturestart()
      {
         return WObj.getOnmsgesturestart();
      }

// Generating method code for setOnmsgesturestart
      public virtual void SetOnmsgesturestart(object onmsgesturestart)
      {
         WObj.setOnmsgesturestart(onmsgesturestart);
      }

// Generating method code for getOnmsgesturetap
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsgesturetap()
      {
         return WObj.getOnmsgesturetap();
      }

// Generating method code for setOnmsgesturetap
      public virtual void SetOnmsgesturetap(object onmsgesturetap)
      {
         WObj.setOnmsgesturetap(onmsgesturetap);
      }

// Generating method code for getOnmsinertiastart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsinertiastart()
      {
         return WObj.getOnmsinertiastart();
      }

// Generating method code for setOnmsinertiastart
      public virtual void SetOnmsinertiastart(object onmsinertiastart)
      {
         WObj.setOnmsinertiastart(onmsinertiastart);
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

// Generating method code for getOnmspointercancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointercancel()
      {
         return WObj.getOnmspointercancel();
      }

// Generating method code for setOnmspointercancel
      public virtual void SetOnmspointercancel(object onmspointercancel)
      {
         WObj.setOnmspointercancel(onmspointercancel);
      }

// Generating method code for getOnmspointerdown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerdown()
      {
         return WObj.getOnmspointerdown();
      }

// Generating method code for setOnmspointerdown
      public virtual void SetOnmspointerdown(object onmspointerdown)
      {
         WObj.setOnmspointerdown(onmspointerdown);
      }

// Generating method code for getOnmspointerenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerenter()
      {
         return WObj.getOnmspointerenter();
      }

// Generating method code for setOnmspointerenter
      public virtual void SetOnmspointerenter(object onmspointerenter)
      {
         WObj.setOnmspointerenter(onmspointerenter);
      }

// Generating method code for getOnmspointerleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerleave()
      {
         return WObj.getOnmspointerleave();
      }

// Generating method code for setOnmspointerleave
      public virtual void SetOnmspointerleave(object onmspointerleave)
      {
         WObj.setOnmspointerleave(onmspointerleave);
      }

// Generating method code for getOnmspointermove
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointermove()
      {
         return WObj.getOnmspointermove();
      }

// Generating method code for setOnmspointermove
      public virtual void SetOnmspointermove(object onmspointermove)
      {
         WObj.setOnmspointermove(onmspointermove);
      }

// Generating method code for getOnmspointerout
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerout()
      {
         return WObj.getOnmspointerout();
      }

// Generating method code for setOnmspointerout
      public virtual void SetOnmspointerout(object onmspointerout)
      {
         WObj.setOnmspointerout(onmspointerout);
      }

// Generating method code for getOnmspointerover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerover()
      {
         return WObj.getOnmspointerover();
      }

// Generating method code for setOnmspointerover
      public virtual void SetOnmspointerover(object onmspointerover)
      {
         WObj.setOnmspointerover(onmspointerover);
      }

// Generating method code for getOnmspointerup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmspointerup()
      {
         return WObj.getOnmspointerup();
      }

// Generating method code for setOnmspointerup
      public virtual void SetOnmspointerup(object onmspointerup)
      {
         WObj.setOnmspointerup(onmspointerup);
      }

// Generating method code for getOnmssitemodejumplistitemremoved
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmssitemodejumplistitemremoved()
      {
         return WObj.getOnmssitemodejumplistitemremoved();
      }

// Generating method code for setOnmssitemodejumplistitemremoved
      public virtual void SetOnmssitemodejumplistitemremoved(object onmssitemodejumplistitemremoved)
      {
         WObj.setOnmssitemodejumplistitemremoved(onmssitemodejumplistitemremoved);
      }

// Generating method code for getOnmsthumbnailclick
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmsthumbnailclick()
      {
         return WObj.getOnmsthumbnailclick();
      }

// Generating method code for setOnmsthumbnailclick
      public virtual void SetOnmsthumbnailclick(object onmsthumbnailclick)
      {
         WObj.setOnmsthumbnailclick(onmsthumbnailclick);
      }

// Generating method code for getOnstop
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstop()
      {
         return WObj.getOnstop();
      }

// Generating method code for setOnstop
      public virtual void SetOnstop(object onstop)
      {
         WObj.setOnstop(onstop);
      }

// Generating method code for getOnstoragecommit
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstoragecommit()
      {
         return WObj.getOnstoragecommit();
      }

// Generating method code for setOnstoragecommit
      public virtual void SetOnstoragecommit(object onstoragecommit)
      {
         WObj.setOnstoragecommit(onstoragecommit);
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

// Generating method code for getLocation
      public virtual NHtmlUnit.Javascript.Host.Location GetLocation()
      {
         var arg = WObj.getLocation();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Location>(arg);
      }

// Generating method code for setLocation
      public virtual void SetLocation(string location)
      {
         WObj.setLocation(location);
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

// Generating method code for getOnbeforecopy
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforecopy()
      {
         return WObj.getOnbeforecopy();
      }

// Generating method code for setOnbeforecopy
      public virtual void SetOnbeforecopy(object onbeforecopy)
      {
         WObj.setOnbeforecopy(onbeforecopy);
      }

// Generating method code for getOnbeforecut
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforecut()
      {
         return WObj.getOnbeforecut();
      }

// Generating method code for setOnbeforecut
      public virtual void SetOnbeforecut(object onbeforecut)
      {
         WObj.setOnbeforecut(onbeforecut);
      }

// Generating method code for getOnbeforepaste
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnbeforepaste()
      {
         return WObj.getOnbeforepaste();
      }

// Generating method code for setOnbeforepaste
      public virtual void SetOnbeforepaste(object onbeforepaste)
      {
         WObj.setOnbeforepaste(onbeforepaste);
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

// Generating method code for getOngotpointercapture
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOngotpointercapture()
      {
         return WObj.getOngotpointercapture();
      }

// Generating method code for setOngotpointercapture
      public virtual void SetOngotpointercapture(object ongotpointercapture)
      {
         WObj.setOngotpointercapture(ongotpointercapture);
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

// Generating method code for getOnload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnload()
      {
         return WObj.getOnload();
      }

// Generating method code for setOnload
      public virtual void SetOnload(object onload)
      {
         WObj.setOnload(onload);
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

// Generating method code for getOnlostpointercapture
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnlostpointercapture()
      {
         return WObj.getOnlostpointercapture();
      }

// Generating method code for setOnlostpointercapture
      public virtual void SetOnlostpointercapture(object onlostpointercapture)
      {
         WObj.setOnlostpointercapture(onlostpointercapture);
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

// Generating method code for getOnpointercancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointercancel()
      {
         return WObj.getOnpointercancel();
      }

// Generating method code for setOnpointercancel
      public virtual void SetOnpointercancel(object onpointercancel)
      {
         WObj.setOnpointercancel(onpointercancel);
      }

// Generating method code for getOnpointerdown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerdown()
      {
         return WObj.getOnpointerdown();
      }

// Generating method code for setOnpointerdown
      public virtual void SetOnpointerdown(object onpointerdown)
      {
         WObj.setOnpointerdown(onpointerdown);
      }

// Generating method code for getOnpointerenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerenter()
      {
         return WObj.getOnpointerenter();
      }

// Generating method code for setOnpointerenter
      public virtual void SetOnpointerenter(object onpointerenter)
      {
         WObj.setOnpointerenter(onpointerenter);
      }

// Generating method code for getOnpointerleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerleave()
      {
         return WObj.getOnpointerleave();
      }

// Generating method code for setOnpointerleave
      public virtual void SetOnpointerleave(object onpointerleave)
      {
         WObj.setOnpointerleave(onpointerleave);
      }

// Generating method code for getOnpointerlockchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerlockchange()
      {
         return WObj.getOnpointerlockchange();
      }

// Generating method code for setOnpointerlockchange
      public virtual void SetOnpointerlockchange(object onpointerlockchange)
      {
         WObj.setOnpointerlockchange(onpointerlockchange);
      }

// Generating method code for getOnpointerlockerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerlockerror()
      {
         return WObj.getOnpointerlockerror();
      }

// Generating method code for setOnpointerlockerror
      public virtual void SetOnpointerlockerror(object onpointerlockerror)
      {
         WObj.setOnpointerlockerror(onpointerlockerror);
      }

// Generating method code for getOnpointermove
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointermove()
      {
         return WObj.getOnpointermove();
      }

// Generating method code for setOnpointermove
      public virtual void SetOnpointermove(object onpointermove)
      {
         WObj.setOnpointermove(onpointermove);
      }

// Generating method code for getOnpointerout
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerout()
      {
         return WObj.getOnpointerout();
      }

// Generating method code for setOnpointerout
      public virtual void SetOnpointerout(object onpointerout)
      {
         WObj.setOnpointerout(onpointerout);
      }

// Generating method code for getOnpointerover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerover()
      {
         return WObj.getOnpointerover();
      }

// Generating method code for setOnpointerover
      public virtual void SetOnpointerover(object onpointerover)
      {
         WObj.setOnpointerover(onpointerover);
      }

// Generating method code for getOnpointerup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpointerup()
      {
         return WObj.getOnpointerup();
      }

// Generating method code for setOnpointerup
      public virtual void SetOnpointerup(object onpointerup)
      {
         WObj.setOnpointerup(onpointerup);
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

// Generating method code for getOnreadystatechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnreadystatechange()
      {
         return WObj.getOnreadystatechange();
      }

// Generating method code for setOnreadystatechange
      public virtual void SetOnreadystatechange(object onreadystatechange)
      {
         WObj.setOnreadystatechange(onreadystatechange);
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

// Generating method code for getOnsearch
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnsearch()
      {
         return WObj.getOnsearch();
      }

// Generating method code for setOnsearch
      public virtual void SetOnsearch(object onsearch)
      {
         WObj.setOnsearch(onsearch);
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

   }


}
