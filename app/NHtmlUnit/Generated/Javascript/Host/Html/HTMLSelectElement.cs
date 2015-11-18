// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLSelectElement : NHtmlUnit.Javascript.Host.Html.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

      public System.String DataFld
      {
         get
         {
            return WObj.getDataFld();
         }
         set
         {
            WObj.setDataFld(value);
         }

      }

      public System.String DataFormatAs
      {
         get
         {
            return WObj.getDataFormatAs();
         }
         set
         {
            WObj.setDataFormatAs(value);
         }

      }

      public System.String DataSrc
      {
         get
         {
            return WObj.getDataSrc();
         }
         set
         {
            WObj.setDataSrc(value);
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
         return WObj.insertBeforeImpl(args);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         return WObj.item(index);
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
