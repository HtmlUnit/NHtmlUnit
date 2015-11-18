// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomAttr : NHtmlUnit.Html.DomNamespaceNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IAttr
   {
      static DomAttr()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomAttr o) =>
            new DomAttr(o));
      }

      public DomAttr(com.gargoylesoftware.htmlunit.html.DomAttr wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomAttr WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomAttr)WrappedObject; }
      }

      public DomAttr(NHtmlUnit.SgmlPage page, string namespaceURI, string qualifiedName, string value, bool specified)
         : this(new com.gargoylesoftware.htmlunit.html.DomAttr((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, namespaceURI, qualifiedName, value, specified)) {}


      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public System.Boolean Specified
      {
         get
         {
            return WObj.getSpecified();
         }
      }

      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
         set
         {
            WObj.setValue(value);
         }

      }

      public NHtmlUnit.Html.DomElement OwnerElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getOwnerElement());
         }
      }


      public NHtmlUnit.W3C.Dom.ITypeInfo SchemaTypeInfo
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.ITypeInfo>(
               WObj.getSchemaTypeInfo());
         }
      }

// Generating method code for isId
      public virtual bool IsId()
      {
         return WObj.isId();
      }

   }


}
