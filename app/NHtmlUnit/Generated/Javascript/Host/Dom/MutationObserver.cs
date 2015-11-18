// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class MutationObserver : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.Html.IHtmlAttributeChangeListener, NHtmlUnit.Html.ICharacterDataChangeListener
   {
      static MutationObserver()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.MutationObserver o) =>
            new MutationObserver(o));
      }

      public MutationObserver(com.gargoylesoftware.htmlunit.javascript.host.dom.MutationObserver wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.MutationObserver WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.MutationObserver)WrappedObject; }
      }

      public MutationObserver()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.MutationObserver()) {}

      public MutationObserver(net.sourceforge.htmlunit.corejs.javascript.Function function)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.MutationObserver(function)) {}

// Generating method code for observe
      public virtual void Observe(NHtmlUnit.Javascript.Host.Dom.Node node, net.sourceforge.htmlunit.corejs.javascript.NativeObject options)
      {
         WObj.observe((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)node.WrappedObject, options);
      }

// Generating method code for disconnect
      public virtual void Disconnect()
      {
         WObj.disconnect();
      }

// Generating method code for characterDataChanged
      public virtual void CharacterDataChanged(NHtmlUnit.Html.CharacterDataChangeEvent eventArg)
      {
         WObj.characterDataChanged((com.gargoylesoftware.htmlunit.html.CharacterDataChangeEvent)eventArg.WrappedObject);
      }

// Generating method code for attributeAdded
      public virtual void AttributeAdded(NHtmlUnit.Html.HtmlAttributeChangeEvent eventArg)
      {
         WObj.attributeAdded((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent)eventArg.WrappedObject);
      }

// Generating method code for attributeRemoved
      public virtual void AttributeRemoved(NHtmlUnit.Html.HtmlAttributeChangeEvent eventArg)
      {
         WObj.attributeRemoved((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent)eventArg.WrappedObject);
      }

// Generating method code for attributeReplaced
      public virtual void AttributeReplaced(NHtmlUnit.Html.HtmlAttributeChangeEvent eventArg)
      {
         WObj.attributeReplaced((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent)eventArg.WrappedObject);
      }

   }


}
