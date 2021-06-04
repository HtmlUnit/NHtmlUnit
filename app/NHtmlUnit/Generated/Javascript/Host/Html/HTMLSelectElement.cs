// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLSelectElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
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


      public NHtmlUnit.Javascript.Host.Html.HTMLOptionsCollection Options
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLOptionsCollection>(
               WObj.getOptions());
         }
      }


      public System.String Type
      {
         get
         {
            return WObj.getType();
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

      public NHtmlUnit.Javascript.Host.Dom.AbstractList Labels
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.AbstractList>(
               WObj.getLabels());
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
      public virtual void Add(NHtmlUnit.Javascript.Host.Html.HTMLOptionElement newOptionObject, object beforeOptionObject)
      {
         WObj.add((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement)newOptionObject.WrappedObject, beforeOptionObject);
      }

// Generating method code for insertBeforeImpl
      public virtual object InsertBeforeImpl(System.Object[] args)
      {
         var arg = WObj.insertBeforeImpl(args);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for isMultiple
      public virtual bool IsMultiple()
      {
         return WObj.isMultiple();
      }

// Generating method code for checkValidity
      public virtual bool CheckValidity()
      {
         return WObj.checkValidity();
      }

// Generating method code for isRequired
      public virtual bool IsRequired()
      {
         return WObj.isRequired();
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
