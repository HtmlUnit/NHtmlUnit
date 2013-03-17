// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLSelectElement : NHtmlUnit.Javascript.Host.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLSelectElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement o) =>
            new HTMLSelectElement(o));
      }

      public HTMLSelectElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement)WrappedObject; }
      }

      public HTMLSelectElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement()) {}


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

      public NHtmlUnit.Javascript.Host.Html.HTMLOptionsCollection Options
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLOptionsCollection>(
               WObj.getOptions());
         }
      }


      public System.Boolean Multiple
      {
         get
         {
            return WObj.getMultiple();
         }
         set
         {
            WObj.setMultiple(value);
         }

      }
// Generating method code for initialize
      public virtual void Initialize()
      {
         WObj.initialize();
      }

// Generating method code for remove
      public virtual void Remove(int index)
      {
         WObj.remove(index);
      }

// Generating method code for add
      public virtual void Add(NHtmlUnit.Javascript.Host.Html.HTMLOptionElement newOptionObject, object arg2)
      {
         WObj.add((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement)newOptionObject.WrappedObject, arg2);
      }

// Generating method code for insertBeforeImpl
      public virtual object InsertBeforeImpl(System.Object[] args)
      {
         return WObj.insertBeforeImpl(args);
      }

// Generating method code for item
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLOptionElement Item(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLOptionElement>(WObj.item(index));
      }

// Generating method code for getSize
      public virtual int GetSize()
      {
         return WObj.getSize();
      }

// Generating method code for setSize
      public virtual void SetSize(string size)
      {
         WObj.setSize(size);
      }

   }


}
