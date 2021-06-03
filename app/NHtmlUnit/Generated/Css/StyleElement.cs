// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Css
{
   public partial class StyleElement : ObjectWrapper
   {
      static StyleElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.css.StyleElement o) =>
            new StyleElement(o));
      }

      public StyleElement(com.gargoylesoftware.htmlunit.css.StyleElement wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.css.StyleElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.css.StyleElement)WrappedObject; }
      }

      public StyleElement(string name, string value, string priority, com.gargoylesoftware.css.parser.selector.SelectorSpecificity specificity, System.Int64 index)
         : this(new com.gargoylesoftware.htmlunit.css.StyleElement(name, value, priority, specificity, index)) {}

      public StyleElement(string name, string value, string priority, com.gargoylesoftware.css.parser.selector.SelectorSpecificity specificity)
         : this(new com.gargoylesoftware.htmlunit.css.StyleElement(name, value, priority, specificity)) {}


      public System.String Priority
      {
         get
         {
            return WObj.getPriority();
         }
      }

      public com.gargoylesoftware.css.parser.selector.SelectorSpecificity Specificity
      {
         get
         {
            return WObj.getSpecificity();
         }
      }

      public System.Int64 Index
      {
         get
         {
            return WObj.getIndex();
         }
      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
      }
// Generating method code for isImportant
      public virtual bool IsImportant()
      {
         return WObj.isImportant();
      }

// Generating method code for compareTo
      public virtual int CompareTo(NHtmlUnit.Css.StyleElement e)
      {
         return WObj.compareTo((com.gargoylesoftware.htmlunit.css.StyleElement)e.WrappedObject);
      }

// Generating method code for compareTo
      public virtual int CompareTo(object obj)
      {
         return WObj.compareTo(obj);
      }

   }


}
