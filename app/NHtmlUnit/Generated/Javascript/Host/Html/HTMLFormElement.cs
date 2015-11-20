// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFormElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFormElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement o) =>
            new HTMLFormElement(o));
      }

      public HTMLFormElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement)WrappedObject; }
      }

      public HTMLFormElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement()) {}


      public NHtmlUnit.Javascript.Host.Html.HTMLCollection Elements
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(
               WObj.getElements());
         }
      }


      public System.String Enctype
      {
         get
         {
            return WObj.getEnctype();
         }
         set
         {
            WObj.setEnctype(value);
         }

      }

      public System.String Target
      {
         get
         {
            return WObj.getTarget();
         }
         set
         {
            WObj.setTarget(value);
         }

      }

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

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }

      public System.String Action
      {
         get
         {
            return WObj.getAction();
         }
         set
         {
            WObj.setAction(value);
         }

      }

      public System.String Method
      {
         get
         {
            return WObj.getMethod();
         }
         set
         {
            WObj.setMethod(value);
         }

      }

      public System.String Encoding
      {
         get
         {
            return WObj.getEncoding();
         }
         set
         {
            WObj.setEncoding(value);
         }

      }
// Generating method code for submit
      public virtual void Submit()
      {
         WObj.submit();
      }

// Generating method code for item
      public virtual object Item(object index, object subIndex)
      {
         return WObj.item(index, subIndex);
      }

// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for call
      public virtual object Call(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObj, System.Object[] args)
      {
         return WObj.call(cx, scope, thisObj, args);
      }

// Generating method code for construct
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Construct(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, System.Object[] args)
      {
         return WObj.construct(cx, scope, args);
      }

   }


}
