// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Comment : NHtmlUnit.Javascript.Host.CharacterDataImpl
   {
      static Comment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Comment o) =>
            new Comment(o));
      }

      public Comment(com.gargoylesoftware.htmlunit.javascript.host.Comment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Comment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Comment)WrappedObject; }
      }

      public Comment()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Comment()) {}


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
         return WObj.getAttributeNode(attributeName);
      }

// Generating method code for getAttribute
      public virtual object GetAttribute(string attributeName, java.lang.Integer flags)
      {
         return WObj.getAttribute(attributeName, flags);
      }

   }


}
