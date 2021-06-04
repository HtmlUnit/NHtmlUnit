// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMProcessingInstruction : NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode
   {
      static XMLDOMProcessingInstruction()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMProcessingInstruction o) =>
            new XMLDOMProcessingInstruction(o));
      }

      public XMLDOMProcessingInstruction(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMProcessingInstruction wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMProcessingInstruction WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMProcessingInstruction)WrappedObject; }
      }

      public XMLDOMProcessingInstruction()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMProcessingInstruction()) {}


      public System.String Target
      {
         get
         {
            return WObj.getTarget();
         }
      }

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
   }


}
