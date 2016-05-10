// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Comment : NHtmlUnit.Javascript.Host.Dom.CharacterData
   {
      static Comment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Comment o) =>
            new Comment(o));
      }

      public Comment(com.gargoylesoftware.htmlunit.javascript.host.dom.Comment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Comment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Comment)WrappedObject; }
      }

      public Comment()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Comment()) {}


      public System.String Id
      {
         get
         {
            return WObj.getId();
         }
      }

      public System.Object ClassName_js
      {
         get
         {
            return WObj.getClassName_js();
         }
      }

      public System.Object TagName
      {
         get
         {
            return WObj.getTagName();
         }
      }

      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
      }

      public System.Object Document
      {
         get
         {
            return WObj.getDocument();
         }
      }

      public System.String InnerText
      {
         get
         {
            return WObj.getInnerText();
         }
         set
         {
            WObj.setInnerText(value);
         }

      }
// Generating method code for getAttributeNode
      public virtual object GetAttributeNode(string attributeName)
      {
         var arg = WObj.getAttributeNode(attributeName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getAttribute
      public virtual object GetAttribute(string attributeName, java.lang.Integer flags)
      {
         var arg = WObj.getAttribute(attributeName, flags);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
