// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomProcessingInstruction : NHtmlUnit.Html.DomNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IProcessingInstruction
   {
      static DomProcessingInstruction()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomProcessingInstruction o) =>
            new DomProcessingInstruction(o));
      }

      public DomProcessingInstruction(com.gargoylesoftware.htmlunit.html.DomProcessingInstruction wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomProcessingInstruction WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomProcessingInstruction)WrappedObject; }
      }

      public DomProcessingInstruction(NHtmlUnit.SgmlPage page, string target, string data)
         : this(new com.gargoylesoftware.htmlunit.html.DomProcessingInstruction((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, target, data)) {}


      public System.String Data
      {
         get
         {
            return WObj.getData();
         }
         set
         {
            WObj.setData(value);
         }

      }

      public System.String Target
      {
         get
         {
            return WObj.getTarget();
         }
      }
   }


}
