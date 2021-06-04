// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOptionsCollection : NHtmlUnit.Javascript.SimpleScriptable
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

      public System.Int32 SelectedIndex
      {
         get
         {
            return WObj.getSelectedIndex();
         }
         set
         {
            WObj.setSelectedIndex(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Dom.NodeList ChildNodes
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeList>(
               WObj.getChildNodes());
         }
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.Html.HtmlSelect select)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.html.HtmlSelect)select.WrappedObject);
      }

// Generating method code for add
      public virtual void Add(object newOptionObject, object beforeOptionObject)
      {
         WObj.add(newOptionObject, beforeOptionObject);
      }

// Generating method code for remove
      public virtual void Remove(int index)
      {
         WObj.remove(index);
      }

   }


}
