// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOptionsCollection : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLOptionsCollection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection o) =>
            new HTMLOptionsCollection(o));
      }

      public HTMLOptionsCollection(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection)WrappedObject; }
      }

      public HTMLOptionsCollection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection()) {}

      public HTMLOptionsCollection(NHtmlUnit.Javascript.SimpleScriptable parentScope)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)parentScope.WrappedObject)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
         set
         {
            WObj.setLength(value);
         }

      }
// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.Html.HtmlSelect select)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.html.HtmlSelect)select.WrappedObject);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         return WObj.item(index);
      }

// Generating method code for add
      public virtual void Add(object newOptionObject, object newIndex)
      {
         WObj.add(newOptionObject, newIndex);
      }

// Generating method code for remove
      public virtual void Remove(int index)
      {
         WObj.remove(index);
      }

   }


}
